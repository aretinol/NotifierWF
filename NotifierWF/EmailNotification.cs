using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using MimeKit;
using MailKit.Net.Smtp;
using MailKit.Security;


namespace NotifierWF
{
    /// <summary>
    /// Уведомления по электронной почте
    /// </summary>
    public class EmailNotification
    {
		/// <summary>
		/// Отправитель сообщения
		/// </summary>
		public string Sender { get; set; }


		/// <summary>
		/// Получатель сообщения
		/// </summary>
		public string Receiver { get; set; }


		/// <summary>
		/// Тема сообщения
		/// </summary>
		public string Subject { get; set; }


		/// <summary>
		/// Само сообщение
		/// </summary>
		public string Message { get; set; }


		/// <summary>
		/// Дополнительные заголовки
		/// </summary>
		public string Headers { get; set; }


		/// <summary>     
		/// Логин
		/// </summary>
		public string Username { get; set; }


		/// <summary>     
		/// Пароль
		/// </summary>
		public string Password { get; set; }


		/// <summary>
		/// Адрес smtp сервера. Если равен null, то параметры подключения вычисляются автоматически через сервер
		/// </summary>
		public string SmtpServer { get; set; }


		/// <summary>
		/// Порт smtp сервера. Если равен -1, то параметры подключения вычисляются автоматически через сервер
		/// </summary>
		public int SmtpPort { get; set; }


		/// <summary>
		/// Параметры шифрования
		/// </summary>
		public bool UseSsl { get; set; }


		public EmailNotification(
			string sender, 
			string receiver, 
			string subject, 
			string message, 
			string headers,
			string username, 
			string password,
			string smtpServer,
			int smtpPort,
			bool useSsl)
		{			
			Sender = sender;
			Receiver = receiver;
			Subject = subject;
			Message = message;
			Headers = headers;

			Username = username;
			Password = password;
			SmtpServer = smtpServer;
			SmtpPort = smtpPort;
			UseSsl = useSsl;
		}


		/// <summary>
		/// Отправить сообщение на указанный адрес по протоколу SMTP. 		
		/// </summary>
		/// <returns></returns>		
		public bool Send()
		{			
			try
			{								
				SecureSocketOptions socketOptions = SecureSocketOptions.None;
				if (UseSsl)
					socketOptions = SecureSocketOptions.SslOnConnect;

				SendMessageInner(GeneratePlainMessage(), SmtpServer, SmtpPort, Username, Password, socketOptions);
			}
			catch (Exception ex)
			{
				Log.HandleError(ex, "Error in EmailNotification.Send");
				return false;
			}
			return true;
		}


		/// <summary>
		/// Сформировать простое сообщение
		/// </summary>
		/// <returns></returns>
		private MimeMessage GeneratePlainMessage()
		{			
			var message = new MimeMessage();
			message.From.Add(MailboxAddress.Parse(Sender));
			message.To.Add(MailboxAddress.Parse(Receiver));
			message.Subject = Subject;

			message.Body = new TextPart(MimeKit.Text.TextFormat.Html)
			{
				Text = Message
			};

			var MapHeaders = Extension.ParseHeaders(Headers);
            foreach (var item in MapHeaders)
            {
				message.Headers.Add(item.Key, item.Value);
			}			

			return message;
		}


		/// <summary>
		/// Отправить сообщение по протоколу SMTP
		/// </summary>
		/// <param name="message">Сообщение</param>
		/// <param name="host">Адрес smtp сервера</param>
		/// <param name="port">Порт smtp сервера</param>
		/// <param name="userName">Логин</param>
		/// <param name="password">Пароль</param>
		/// <param name="secureOptions">Шифрование</param>
		private void SendMessageInner(MimeMessage message, string host, int port, string userName, string password, SecureSocketOptions secureOptions)
		{
			using (var client = new SmtpClient())
			{
				client.Connect(host, port, secureOptions);
				client.Authenticate(userName, password);
				client.Send(message);
				client.Disconnect(true);
			}
		}		
    }
}

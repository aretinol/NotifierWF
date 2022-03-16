using Microsoft.VisualStudio.TestTools.UnitTesting;
using NotifierWF;
using System;

namespace UnitTestNotifier
{
	/// <summary>
	/// Тестирование отправки уведомления с разных почтовых сервисов: Google, Rambler, Mail.ru. С яндексом не получилось, он блокирует спам.
	/// </summary>
	[TestClass]
	public class UnitTestSendEmail
	{
		/// <summary>
		/// Параметры подключения к smtp серверу вводятся вручную, например: 
		/// smtp.rambler.ru:465,
		/// smtp.gmail.com:465,
		/// smtp.mail.ru:465
		/// </summary>
		[TestMethod]
		public void TestSMTP()
		{
            using (NotifierForm form = new NotifierForm())
            {
				//Test rambler.ru                
				form.TextBox_Sender.Text = "<SenderEmail>@rambler.ru";
				form.TextBox_Password.Text = "<Password>";
				form.TextBox_Receiver.Text = "<ReceiverEmail>";
				form.TextBox_Subject.Text = "Test SMTP rambler.ru";
				form.TextBox_Body.Text = "This is for testing SMTP mail";
				form.TextBox_Server.Text = "smtp.rambler.ru";
				form.TextBox_Port.Text = "465";
				form.CheckBox_UseSsl.Checked = true;
				bool res1 = form.SendEmail();
				Assert.IsTrue(res1);


				//Test gmail.com
				form.TextBox_Sender.Text = "<SenderEmail>@gmail.com";
				form.TextBox_Password.Text = "<Password>";
				form.TextBox_Receiver.Text = "<ReceiverEmail>";
				form.TextBox_Subject.Text = "Test SMTP gmail.com";
				form.TextBox_Body.Text = "This is for testing SMTP mail2";
				form.TextBox_Server.Text = "smtp.gmail.com";
				form.TextBox_Port.Text = "465";
				form.CheckBox_UseSsl.Checked = true;
				bool res2 = form.SendEmail();
				Assert.IsTrue(res2);


				//Test mail.ru
				form.TextBox_Sender.Text = "<SenderEmail>@mail.ru";
                form.TextBox_Password.Text = "<Password>";
                form.TextBox_Receiver.Text = "<ReceiverEmail>";
                form.TextBox_Subject.Text = "Test SMTP mail.ru";
                form.TextBox_Body.Text = "This is for testing SMTP mail3";
                form.TextBox_Server.Text = "smtp.mail.ru";
                form.TextBox_Port.Text = "465";
                form.CheckBox_UseSsl.Checked = true;                
                bool res3 = form.SendEmail();
                Assert.IsTrue(res3);
            }
        }
	}
}

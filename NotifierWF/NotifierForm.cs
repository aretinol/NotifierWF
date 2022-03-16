using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


[assembly: InternalsVisibleToAttribute("UnitTestNotifier")]
namespace NotifierWF
{
	public partial class NotifierForm : Form
	{
		BackgroundWorker worker = new BackgroundWorker();

		public NotifierForm()
		{
			InitializeComponent();
			Initialize();
		}

		public void Initialize() 				
		{
			worker.WorkerReportsProgress = true;			
			worker.DoWork += Worker_DoWork;
			worker.ProgressChanged += Worker_ProgressChanged;			
		}


		private void Button_Send_Click(object sender, EventArgs e)
		{
			if (worker.IsBusy != true)
			{
				worker.RunWorkerAsync();
			}
			else
			{
				Label_Status.Text = "Сообщение все ещё отправляется";
			}
		}


		private void Worker_DoWork(object sender, DoWorkEventArgs e)
		{
			SendEmail();
		}		


		internal bool SendEmail()
		{
			try
			{				
				string Sender = TextBox_Sender.Text;
				string Password = TextBox_Password.Text;
				string Server = TextBox_Server.Text;
				int Port = Int32.Parse(TextBox_Port.Text);
				string Receiver = TextBox_Receiver.Text;
				string Subject = TextBox_Subject.Text;
				string Body = TextBox_Body.Text;
				string Headers = TextBox_Headers.Text;
				bool UseSsl = CheckBox_UseSsl.Checked;
				EmailNotification notification = new EmailNotification(Sender, Receiver, Subject, Body, Headers, Sender, Password, Server, Port, UseSsl);
				worker.ReportProgress(0, "Сообщение отправляется...");
				bool result = notification.Send();												

				if (result)
					worker.ReportProgress(100, DateTime.Now + " Сообщение отправлено");
				else
					worker.ReportProgress(100, DateTime.Now + " Ошибка при отправлении сообщения");
				return result;
			}
			catch (Exception ex)
			{
				Log.HandleError(ex, "Error in NotifierForm.SendEmail");
				worker.ReportProgress(100, DateTime.Now + " " + ex.Message);
				return false;
			}			
		}


		private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			Label_Status.Text = e.UserState.ToString();
		}		
	}
}

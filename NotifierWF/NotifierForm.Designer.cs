
namespace NotifierWF
{
	partial class NotifierForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.Label_Sender = new System.Windows.Forms.Label();
			this.Label_Password = new System.Windows.Forms.Label();
			this.Label_Server = new System.Windows.Forms.Label();
			this.Label_Port = new System.Windows.Forms.Label();
			this.Label_Receiver = new System.Windows.Forms.Label();
			this.Label_Subject = new System.Windows.Forms.Label();
			this.Label_Body = new System.Windows.Forms.Label();
			this.Label_Headers = new System.Windows.Forms.Label();
			this.Button_Send = new System.Windows.Forms.Button();
			this.TextBox_Sender = new System.Windows.Forms.TextBox();
			this.TextBox_Password = new System.Windows.Forms.TextBox();
			this.TextBox_Server = new System.Windows.Forms.TextBox();
			this.TextBox_Port = new System.Windows.Forms.TextBox();
			this.TextBox_Receiver = new System.Windows.Forms.TextBox();
			this.TextBox_Subject = new System.Windows.Forms.TextBox();
			this.TextBox_Body = new System.Windows.Forms.TextBox();
			this.TextBox_Headers = new System.Windows.Forms.TextBox();
			this.CheckBox_UseSsl = new System.Windows.Forms.CheckBox();
			this.Label_Status = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.Label_Sender, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.Label_Password, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.Label_Server, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.Label_Port, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.Label_Receiver, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.Label_Subject, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.Label_Body, 0, 7);
			this.tableLayoutPanel1.Controls.Add(this.Label_Headers, 0, 8);
			this.tableLayoutPanel1.Controls.Add(this.Button_Send, 0, 9);
			this.tableLayoutPanel1.Controls.Add(this.TextBox_Sender, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.TextBox_Password, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.TextBox_Server, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.TextBox_Port, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.TextBox_Receiver, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.TextBox_Subject, 1, 6);
			this.tableLayoutPanel1.Controls.Add(this.TextBox_Body, 1, 7);
			this.tableLayoutPanel1.Controls.Add(this.TextBox_Headers, 1, 8);
			this.tableLayoutPanel1.Controls.Add(this.CheckBox_UseSsl, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.Label_Status, 0, 10);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 11;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(525, 466);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// Label_Sender
			// 
			this.Label_Sender.AutoSize = true;
			this.Label_Sender.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.Label_Sender.Location = new System.Drawing.Point(10, 10);
			this.Label_Sender.Margin = new System.Windows.Forms.Padding(10, 0, 0, 7);
			this.Label_Sender.Name = "Label_Sender";
			this.Label_Sender.Size = new System.Drawing.Size(115, 13);
			this.Label_Sender.TabIndex = 0;
			this.Label_Sender.Text = "Email отправителя:";
			// 
			// Label_Password
			// 
			this.Label_Password.AutoSize = true;
			this.Label_Password.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.Label_Password.Location = new System.Drawing.Point(10, 40);
			this.Label_Password.Margin = new System.Windows.Forms.Padding(10, 0, 0, 7);
			this.Label_Password.Name = "Label_Password";
			this.Label_Password.Size = new System.Drawing.Size(115, 13);
			this.Label_Password.TabIndex = 1;
			this.Label_Password.Text = "Пароль:";
			// 
			// Label_Server
			// 
			this.Label_Server.AutoSize = true;
			this.Label_Server.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.Label_Server.Location = new System.Drawing.Point(10, 70);
			this.Label_Server.Margin = new System.Windows.Forms.Padding(10, 0, 0, 7);
			this.Label_Server.Name = "Label_Server";
			this.Label_Server.Size = new System.Drawing.Size(115, 13);
			this.Label_Server.TabIndex = 2;
			this.Label_Server.Text = "Сервер:";
			// 
			// Label_Port
			// 
			this.Label_Port.AutoSize = true;
			this.Label_Port.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.Label_Port.Location = new System.Drawing.Point(10, 100);
			this.Label_Port.Margin = new System.Windows.Forms.Padding(10, 0, 0, 7);
			this.Label_Port.Name = "Label_Port";
			this.Label_Port.Size = new System.Drawing.Size(115, 13);
			this.Label_Port.TabIndex = 3;
			this.Label_Port.Text = "Порт:";
			// 
			// Label_Receiver
			// 
			this.Label_Receiver.AutoSize = true;
			this.Label_Receiver.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.Label_Receiver.Location = new System.Drawing.Point(10, 160);
			this.Label_Receiver.Margin = new System.Windows.Forms.Padding(10, 0, 0, 7);
			this.Label_Receiver.Name = "Label_Receiver";
			this.Label_Receiver.Size = new System.Drawing.Size(115, 13);
			this.Label_Receiver.TabIndex = 5;
			this.Label_Receiver.Text = "Email получателя:";
			// 
			// Label_Subject
			// 
			this.Label_Subject.AutoSize = true;
			this.Label_Subject.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.Label_Subject.Location = new System.Drawing.Point(10, 190);
			this.Label_Subject.Margin = new System.Windows.Forms.Padding(10, 0, 0, 7);
			this.Label_Subject.Name = "Label_Subject";
			this.Label_Subject.Size = new System.Drawing.Size(115, 13);
			this.Label_Subject.TabIndex = 6;
			this.Label_Subject.Text = "Тема письма:";
			// 
			// Label_Body
			// 
			this.Label_Body.AutoSize = true;
			this.Label_Body.Dock = System.Windows.Forms.DockStyle.Top;
			this.Label_Body.Location = new System.Drawing.Point(10, 220);
			this.Label_Body.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
			this.Label_Body.Name = "Label_Body";
			this.Label_Body.Size = new System.Drawing.Size(115, 13);
			this.Label_Body.TabIndex = 7;
			this.Label_Body.Text = "Содержание письма:";
			// 
			// Label_Headers
			// 
			this.Label_Headers.AutoSize = true;
			this.Label_Headers.Dock = System.Windows.Forms.DockStyle.Top;
			this.Label_Headers.Location = new System.Drawing.Point(10, 300);
			this.Label_Headers.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
			this.Label_Headers.Name = "Label_Headers";
			this.Label_Headers.Size = new System.Drawing.Size(115, 13);
			this.Label_Headers.TabIndex = 8;
			this.Label_Headers.Text = "Доп. заголовки:";
			// 
			// Button_Send
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.Button_Send, 2);
			this.Button_Send.Dock = System.Windows.Forms.DockStyle.Top;
			this.Button_Send.Location = new System.Drawing.Point(3, 373);
			this.Button_Send.Name = "Button_Send";
			this.Button_Send.Size = new System.Drawing.Size(519, 34);
			this.Button_Send.TabIndex = 10;
			this.Button_Send.Text = "Отправить письмо";
			this.Button_Send.UseVisualStyleBackColor = true;
			this.Button_Send.Click += new System.EventHandler(this.Button_Send_Click);
			// 
			// TextBox_Sender
			// 
			this.TextBox_Sender.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.TextBox_Sender.Location = new System.Drawing.Point(128, 7);
			this.TextBox_Sender.Name = "TextBox_Sender";
			this.TextBox_Sender.Size = new System.Drawing.Size(394, 20);
			this.TextBox_Sender.TabIndex = 1;
			// 
			// TextBox_Password
			// 
			this.TextBox_Password.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.TextBox_Password.Location = new System.Drawing.Point(128, 37);
			this.TextBox_Password.Name = "TextBox_Password";
			this.TextBox_Password.Size = new System.Drawing.Size(394, 20);
			this.TextBox_Password.TabIndex = 2;
			// 
			// TextBox_Server
			// 
			this.TextBox_Server.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.TextBox_Server.Location = new System.Drawing.Point(128, 67);
			this.TextBox_Server.Name = "TextBox_Server";
			this.TextBox_Server.Size = new System.Drawing.Size(394, 20);
			this.TextBox_Server.TabIndex = 3;
			// 
			// TextBox_Port
			// 
			this.TextBox_Port.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.TextBox_Port.Location = new System.Drawing.Point(128, 97);
			this.TextBox_Port.Name = "TextBox_Port";
			this.TextBox_Port.Size = new System.Drawing.Size(394, 20);
			this.TextBox_Port.TabIndex = 4;
			// 
			// TextBox_Receiver
			// 
			this.TextBox_Receiver.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.TextBox_Receiver.Location = new System.Drawing.Point(128, 157);
			this.TextBox_Receiver.Name = "TextBox_Receiver";
			this.TextBox_Receiver.Size = new System.Drawing.Size(394, 20);
			this.TextBox_Receiver.TabIndex = 6;
			// 
			// TextBox_Subject
			// 
			this.TextBox_Subject.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.TextBox_Subject.Location = new System.Drawing.Point(128, 187);
			this.TextBox_Subject.Name = "TextBox_Subject";
			this.TextBox_Subject.Size = new System.Drawing.Size(394, 20);
			this.TextBox_Subject.TabIndex = 7;
			// 
			// TextBox_Body
			// 
			this.TextBox_Body.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TextBox_Body.Location = new System.Drawing.Point(128, 213);
			this.TextBox_Body.Multiline = true;
			this.TextBox_Body.Name = "TextBox_Body";
			this.TextBox_Body.Size = new System.Drawing.Size(394, 74);
			this.TextBox_Body.TabIndex = 8;
			// 
			// TextBox_Headers
			// 
			this.TextBox_Headers.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TextBox_Headers.Location = new System.Drawing.Point(128, 293);
			this.TextBox_Headers.Multiline = true;
			this.TextBox_Headers.Name = "TextBox_Headers";
			this.TextBox_Headers.Size = new System.Drawing.Size(394, 74);
			this.TextBox_Headers.TabIndex = 9;
			// 
			// CheckBox_UseSsl
			// 
			this.CheckBox_UseSsl.AutoSize = true;
			this.CheckBox_UseSsl.Checked = true;
			this.CheckBox_UseSsl.CheckState = System.Windows.Forms.CheckState.Checked;
			this.tableLayoutPanel1.SetColumnSpan(this.CheckBox_UseSsl, 2);
			this.CheckBox_UseSsl.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.CheckBox_UseSsl.Location = new System.Drawing.Point(10, 128);
			this.CheckBox_UseSsl.Margin = new System.Windows.Forms.Padding(10, 0, 0, 5);
			this.CheckBox_UseSsl.Name = "CheckBox_UseSsl";
			this.CheckBox_UseSsl.Size = new System.Drawing.Size(515, 17);
			this.CheckBox_UseSsl.TabIndex = 5;
			this.CheckBox_UseSsl.Text = "Использовать SSL";
			this.CheckBox_UseSsl.UseVisualStyleBackColor = true;
			// 
			// Label_Status
			// 
			this.Label_Status.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.Label_Status, 2);
			this.Label_Status.Dock = System.Windows.Forms.DockStyle.Top;
			this.Label_Status.Location = new System.Drawing.Point(10, 420);
			this.Label_Status.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
			this.Label_Status.Name = "Label_Status";
			this.Label_Status.Size = new System.Drawing.Size(515, 13);
			this.Label_Status.TabIndex = 11;
			this.Label_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// NotifierForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(525, 466);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "NotifierForm";
			this.Text = "EmailNotifier";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		internal System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		internal System.Windows.Forms.Label Label_Sender;
		internal System.Windows.Forms.Label Label_Password;
		internal System.Windows.Forms.Label Label_Server;
		internal System.Windows.Forms.Label Label_Port;
		internal System.Windows.Forms.Label Label_Receiver;
		internal System.Windows.Forms.Label Label_Subject;
		internal System.Windows.Forms.Label Label_Body;
		internal System.Windows.Forms.Label Label_Headers;
		internal System.Windows.Forms.Button Button_Send;
		internal System.Windows.Forms.TextBox TextBox_Sender;
		internal System.Windows.Forms.TextBox TextBox_Password;
		internal System.Windows.Forms.TextBox TextBox_Server;
		internal System.Windows.Forms.TextBox TextBox_Port;
		internal System.Windows.Forms.TextBox TextBox_Receiver;
		internal System.Windows.Forms.TextBox TextBox_Subject;
		internal System.Windows.Forms.TextBox TextBox_Body;
		internal System.Windows.Forms.TextBox TextBox_Headers;
		internal System.Windows.Forms.CheckBox CheckBox_UseSsl;
		internal System.Windows.Forms.Label Label_Status;
	}
}


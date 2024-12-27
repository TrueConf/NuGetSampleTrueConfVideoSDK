namespace NuGetSampleTrueConfVideoSDK
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            imageList = new ImageList(components);
            labelError = new Label();
            helpProvider1 = new HelpProvider();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            buttonSendChatMessage = new Button();
            label2 = new Label();
            checkBoxAutoAccept = new CheckBox();
            buttonLogout = new Button();
            textBoxVideoSDK_PIN = new TextBox();
            label3 = new Label();
            textBoxVideoSDK_Port = new TextBox();
            label12 = new Label();
            buttonOpenSession = new Button();
            textBoxVideoSDK_IP = new TextBox();
            label11 = new Label();
            label10 = new Label();
            buttonCall = new Button();
            textBoxCallID = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            textBoxPassword = new TextBox();
            buttonLogin = new Button();
            textBoxTrueConfID = new TextBox();
            label5 = new Label();
            buttonConnectToTCS = new Button();
            textBoxTrueConfServerAddress = new TextBox();
            label4 = new Label();
            labelStatus = new Label();
            labelStateColor = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            textBoxLog = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth8Bit;
            imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.TransparentColor = Color.Transparent;
            imageList.Images.SetKeyName(0, "call-disabled.png");
            imageList.Images.SetKeyName(1, "call.png");
            imageList.Images.SetKeyName(2, "hangup-disabled.png");
            imageList.Images.SetKeyName(3, "hangup.png");
            // 
            // labelError
            // 
            labelError.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelError.ForeColor = Color.Firebrick;
            labelError.Location = new Point(12, 728);
            labelError.Name = "labelError";
            labelError.Size = new Size(963, 63);
            labelError.TabIndex = 16;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(17, 14);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(958, 696);
            tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(buttonSendChatMessage);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(checkBoxAutoAccept);
            tabPage1.Controls.Add(buttonLogout);
            tabPage1.Controls.Add(textBoxVideoSDK_PIN);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(textBoxVideoSDK_Port);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(buttonOpenSession);
            tabPage1.Controls.Add(textBoxVideoSDK_IP);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(buttonCall);
            tabPage1.Controls.Add(textBoxCallID);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(textBoxPassword);
            tabPage1.Controls.Add(buttonLogin);
            tabPage1.Controls.Add(textBoxTrueConfID);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(buttonConnectToTCS);
            tabPage1.Controls.Add(textBoxTrueConfServerAddress);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(labelStatus);
            tabPage1.Controls.Add(labelStateColor);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(950, 658);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Manage";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonSendChatMessage
            // 
            buttonSendChatMessage.Location = new Point(656, 549);
            buttonSendChatMessage.Name = "buttonSendChatMessage";
            buttonSendChatMessage.Size = new Size(275, 34);
            buttonSendChatMessage.TabIndex = 50;
            buttonSendChatMessage.Text = "Send \"Hi!\" chat message";
            buttonSendChatMessage.UseVisualStyleBackColor = true;
            buttonSendChatMessage.Click += buttonSendChatMessage_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(57, 470);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 49;
            label2.Text = "Videocall";
            // 
            // checkBoxAutoAccept
            // 
            checkBoxAutoAccept.AutoSize = true;
            checkBoxAutoAccept.Location = new Point(39, 586);
            checkBoxAutoAccept.Name = "checkBoxAutoAccept";
            checkBoxAutoAccept.Size = new Size(440, 29);
            checkBoxAutoAccept.TabIndex = 48;
            checkBoxAutoAccept.Text = "Automatically accept incoming calls and invitations";
            checkBoxAutoAccept.UseVisualStyleBackColor = true;
            // 
            // buttonLogout
            // 
            buttonLogout.Location = new Point(656, 333);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(275, 34);
            buttonLogout.TabIndex = 47;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // textBoxVideoSDK_PIN
            // 
            textBoxVideoSDK_PIN.Location = new Point(511, 111);
            textBoxVideoSDK_PIN.Name = "textBoxVideoSDK_PIN";
            textBoxVideoSDK_PIN.Size = new Size(125, 31);
            textBoxVideoSDK_PIN.TabIndex = 46;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.Control;
            label3.Location = new Point(427, 112);
            label3.Name = "label3";
            label3.Size = new Size(67, 30);
            label3.TabIndex = 45;
            label3.Text = "PIN";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // textBoxVideoSDK_Port
            // 
            textBoxVideoSDK_Port.Location = new Point(511, 67);
            textBoxVideoSDK_Port.Name = "textBoxVideoSDK_Port";
            textBoxVideoSDK_Port.PlaceholderText = "default port is 80";
            textBoxVideoSDK_Port.Size = new Size(125, 31);
            textBoxVideoSDK_Port.TabIndex = 44;
            textBoxVideoSDK_Port.Text = "80";
            // 
            // label12
            // 
            label12.BackColor = SystemColors.Control;
            label12.Location = new Point(427, 68);
            label12.Name = "label12";
            label12.Size = new Size(67, 30);
            label12.TabIndex = 43;
            label12.Text = "Port";
            label12.TextAlign = ContentAlignment.TopRight;
            // 
            // buttonOpenSession
            // 
            buttonOpenSession.Location = new Point(656, 65);
            buttonOpenSession.Name = "buttonOpenSession";
            buttonOpenSession.Size = new Size(275, 77);
            buttonOpenSession.TabIndex = 42;
            buttonOpenSession.Text = "OpenSession";
            buttonOpenSession.UseVisualStyleBackColor = true;
            buttonOpenSession.Click += buttonOpenSession_Click;
            // 
            // textBoxVideoSDK_IP
            // 
            textBoxVideoSDK_IP.Location = new Point(288, 67);
            textBoxVideoSDK_IP.Name = "textBoxVideoSDK_IP";
            textBoxVideoSDK_IP.PlaceholderText = "127.0.0.1";
            textBoxVideoSDK_IP.Size = new Size(125, 31);
            textBoxVideoSDK_IP.TabIndex = 41;
            textBoxVideoSDK_IP.Text = "127.0.0.1";
            // 
            // label11
            // 
            label11.BackColor = SystemColors.Control;
            label11.Location = new Point(204, 68);
            label11.Name = "label11";
            label11.Size = new Size(67, 30);
            label11.TabIndex = 40;
            label11.Text = "IP";
            label11.TextAlign = ContentAlignment.TopRight;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(52, 21);
            label10.Name = "label10";
            label10.Size = new Size(393, 25);
            label10.TabIndex = 39;
            label10.Text = "Open a new session with TrueConf VideoSDK";
            // 
            // buttonCall
            // 
            buttonCall.ImageIndex = 0;
            buttonCall.ImageList = imageList;
            buttonCall.Location = new Point(656, 501);
            buttonCall.Name = "buttonCall";
            buttonCall.Size = new Size(275, 34);
            buttonCall.TabIndex = 38;
            buttonCall.UseVisualStyleBackColor = true;
            buttonCall.Click += buttonCall_Click;
            // 
            // textBoxCallID
            // 
            textBoxCallID.Location = new Point(370, 503);
            textBoxCallID.Name = "textBoxCallID";
            textBoxCallID.Size = new Size(266, 31);
            textBoxCallID.TabIndex = 37;
            // 
            // label9
            // 
            label9.BackColor = SystemColors.Control;
            label9.Location = new Point(39, 504);
            label9.Name = "label9";
            label9.Size = new Size(311, 30);
            label9.TabIndex = 36;
            label9.Text = "TrueConf ID or Conference ID";
            label9.TextAlign = ContentAlignment.TopRight;
            // 
            // label8
            // 
            label8.BackColor = SystemColors.Control;
            label8.Location = new Point(39, 336);
            label8.Name = "label8";
            label8.Size = new Size(232, 30);
            label8.TabIndex = 35;
            label8.Text = "Password";
            label8.TextAlign = ContentAlignment.TopRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(52, 247);
            label7.Name = "label7";
            label7.Size = new Size(59, 25);
            label7.TabIndex = 34;
            label7.Text = "Login";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(52, 153);
            label6.Name = "label6";
            label6.Size = new Size(163, 25);
            label6.TabIndex = 33;
            label6.Text = "Connect to server";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(288, 335);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PlaceholderText = "********";
            textBoxPassword.Size = new Size(348, 31);
            textBoxPassword.TabIndex = 32;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(656, 284);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(275, 34);
            buttonLogin.TabIndex = 31;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textBoxTrueConfID
            // 
            textBoxTrueConfID.Location = new Point(288, 286);
            textBoxTrueConfID.Name = "textBoxTrueConfID";
            textBoxTrueConfID.PlaceholderText = "TrueConf ID";
            textBoxTrueConfID.Size = new Size(348, 31);
            textBoxTrueConfID.TabIndex = 30;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.Control;
            label5.Location = new Point(39, 287);
            label5.Name = "label5";
            label5.Size = new Size(232, 30);
            label5.TabIndex = 29;
            label5.Text = "User";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // buttonConnectToTCS
            // 
            buttonConnectToTCS.Location = new Point(656, 196);
            buttonConnectToTCS.Name = "buttonConnectToTCS";
            buttonConnectToTCS.Size = new Size(275, 34);
            buttonConnectToTCS.TabIndex = 28;
            buttonConnectToTCS.Text = "Connect to TrueConf server";
            buttonConnectToTCS.UseVisualStyleBackColor = true;
            buttonConnectToTCS.Click += buttonConnectToTCS_Click;
            // 
            // textBoxTrueConfServerAddress
            // 
            textBoxTrueConfServerAddress.Location = new Point(288, 198);
            textBoxTrueConfServerAddress.Name = "textBoxTrueConfServerAddress";
            textBoxTrueConfServerAddress.PlaceholderText = "server.name.com or IP address";
            textBoxTrueConfServerAddress.Size = new Size(348, 31);
            textBoxTrueConfServerAddress.TabIndex = 27;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.Control;
            label4.Location = new Point(39, 199);
            label4.Name = "label4";
            label4.Size = new Size(232, 30);
            label4.TabIndex = 26;
            label4.Text = "TrueConf Server";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // labelStatus
            // 
            labelStatus.BackColor = SystemColors.Control;
            labelStatus.Location = new Point(456, 420);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(475, 30);
            labelStatus.TabIndex = 25;
            labelStatus.Text = "Unknown";
            // 
            // labelStateColor
            // 
            labelStateColor.BackColor = Color.DarkGray;
            labelStateColor.Location = new Point(370, 420);
            labelStateColor.Name = "labelStateColor";
            labelStateColor.Size = new Size(66, 30);
            labelStateColor.TabIndex = 24;
            labelStateColor.TextAlign = ContentAlignment.TopRight;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Control;
            label1.Location = new Point(39, 420);
            label1.Name = "label1";
            label1.Size = new Size(314, 30);
            label1.TabIndex = 23;
            label1.Text = "Current state";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(textBoxLog);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(950, 658);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Loging";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxLog
            // 
            textBoxLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxLog.Location = new Point(6, 6);
            textBoxLog.Multiline = true;
            textBoxLog.Name = "textBoxLog";
            textBoxLog.ScrollBars = ScrollBars.Both;
            textBoxLog.Size = new Size(938, 646);
            textBoxLog.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 800);
            Controls.Add(tabControl1);
            Controls.Add(labelError);
            Name = "Form1";
            Text = "Remote control of TrueConf VideoSDK Demo Application";
            Load += Form1_Load;
            Shown += Form1_Shown;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageList;
        private Label labelError;
        private HelpProvider helpProvider1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox textBoxVideoSDK_Port;
        private Label label12;
        private Button buttonOpenSession;
        private TextBox textBoxVideoSDK_IP;
        private Label label11;
        private Label label10;
        private Button buttonCall;
        private TextBox textBoxCallID;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox textBoxPassword;
        private Button buttonLogin;
        private TextBox textBoxTrueConfID;
        private Label label5;
        private Button buttonConnectToTCS;
        private TextBox textBoxTrueConfServerAddress;
        private Label label4;
        private Label labelStatus;
        private Label labelStateColor;
        private Label label1;
        private TabPage tabPage2;
        private TextBox textBoxLog;
        private TextBox textBoxVideoSDK_PIN;
        private Label label3;
        private Button buttonLogout;
        private CheckBox checkBoxAutoAccept;
        private Label label2;
        private Button buttonSendChatMessage;
    }
}
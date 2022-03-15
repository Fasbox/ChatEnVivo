namespace TrackerUI
{
    partial class Chat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chat));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.bottomChatPanel = new System.Windows.Forms.Panel();
            this.sendButton = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.messagesSetPanel = new System.Windows.Forms.Panel();
            this.listBoxMessagesReceived = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.profileLabel = new System.Windows.Forms.Label();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ListBoxUsers = new System.Windows.Forms.ListBox();
            this.buttonClient = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.LabelIP = new System.Windows.Forms.Label();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.headerPanel.SuspendLayout();
            this.bottomChatPanel.SuspendLayout();
            this.messagesSetPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(110)))));
            this.headerPanel.Controls.Add(this.exitButton);
            this.headerPanel.Controls.Add(this.headerLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(957, 32);
            this.headerPanel.TabIndex = 0;
            this.headerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.headerPanel_Paint);
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseDown);
            this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseMove);
            this.headerPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseUp);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(110)))));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(898, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(59, 32);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.Color.White;
            this.headerLabel.Location = new System.Drawing.Point(12, 2);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(66, 28);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Chat";
            this.headerLabel.Click += new System.EventHandler(this.headerLabel_Click);
            // 
            // bottomChatPanel
            // 
            this.bottomChatPanel.Controls.Add(this.sendButton);
            this.bottomChatPanel.Controls.Add(this.textBox);
            this.bottomChatPanel.Location = new System.Drawing.Point(206, 499);
            this.bottomChatPanel.Name = "bottomChatPanel";
            this.bottomChatPanel.Size = new System.Drawing.Size(694, 55);
            this.bottomChatPanel.TabIndex = 1;
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(110)))));
            this.sendButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sendButton.BackgroundImage")));
            this.sendButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sendButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.sendButton.FlatAppearance.BorderSize = 0;
            this.sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendButton.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sendButton.ForeColor = System.Drawing.Color.White;
            this.sendButton.Location = new System.Drawing.Point(631, 0);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(63, 55);
            this.sendButton.TabIndex = 2;
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(34)))), ((int)(((byte)(58)))));
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox.ForeColor = System.Drawing.Color.White;
            this.textBox.Location = new System.Drawing.Point(22, 1);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(672, 47);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "Type Something";
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox_MouseDown);
            // 
            // messagesSetPanel
            // 
            this.messagesSetPanel.Controls.Add(this.listBoxMessagesReceived);
            this.messagesSetPanel.Location = new System.Drawing.Point(206, 137);
            this.messagesSetPanel.Name = "messagesSetPanel";
            this.messagesSetPanel.Size = new System.Drawing.Size(694, 341);
            this.messagesSetPanel.TabIndex = 2;
            // 
            // listBoxMessagesReceived
            // 
            this.listBoxMessagesReceived.FormattingEnabled = true;
            this.listBoxMessagesReceived.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listBoxMessagesReceived.ItemHeight = 15;
            this.listBoxMessagesReceived.Location = new System.Drawing.Point(22, -2);
            this.listBoxMessagesReceived.Name = "listBoxMessagesReceived";
            this.listBoxMessagesReceived.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxMessagesReceived.Size = new System.Drawing.Size(669, 349);
            this.listBoxMessagesReceived.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.profileLabel);
            this.panel1.Controls.Add(this.profilePictureBox);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(228, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 93);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(89, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Some user text here";
            // 
            // profileLabel
            // 
            this.profileLabel.AutoSize = true;
            this.profileLabel.BackColor = System.Drawing.Color.Transparent;
            this.profileLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.profileLabel.ForeColor = System.Drawing.Color.Snow;
            this.profileLabel.Location = new System.Drawing.Point(88, 3);
            this.profileLabel.Name = "profileLabel";
            this.profileLabel.Size = new System.Drawing.Size(103, 20);
            this.profileLabel.TabIndex = 2;
            this.profileLabel.Text = "User name";
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Image = global::ProyectoCodigoLimpioClient.Properties.Resources.profile1;
            this.profilePictureBox.Location = new System.Drawing.Point(0, -3);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(83, 96);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox.TabIndex = 0;
            this.profilePictureBox.TabStop = false;
            this.profilePictureBox.Click += new System.EventHandler(this.profilePictureBox_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ListBoxUsers);
            this.panel2.Controls.Add(this.buttonClient);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 545);
            this.panel2.TabIndex = 4;
            // 
            // ListBoxUsers
            // 
            this.ListBoxUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ListBoxUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxUsers.ForeColor = System.Drawing.SystemColors.Window;
            this.ListBoxUsers.FormattingEnabled = true;
            this.ListBoxUsers.ItemHeight = 15;
            this.ListBoxUsers.Location = new System.Drawing.Point(0, 157);
            this.ListBoxUsers.Name = "ListBoxUsers";
            this.ListBoxUsers.Size = new System.Drawing.Size(222, 388);
            this.ListBoxUsers.TabIndex = 6;
            // 
            // buttonClient
            // 
            this.buttonClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonClient.Location = new System.Drawing.Point(0, 128);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(222, 29);
            this.buttonClient.TabIndex = 4;
            this.buttonClient.Text = "Connect ";
            this.buttonClient.UseVisualStyleBackColor = true;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBoxUserName);
            this.panel3.Controls.Add(this.labelUserName);
            this.panel3.Controls.Add(this.textBoxPort);
            this.panel3.Controls.Add(this.labelPort);
            this.panel3.Controls.Add(this.LabelIP);
            this.panel3.Controls.Add(this.textBoxIP);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(222, 128);
            this.panel3.TabIndex = 0;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(70, 91);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(100, 23);
            this.textBoxUserName.TabIndex = 5;
            this.textBoxUserName.TextChanged += new System.EventHandler(this.textBoxUserName_TextChanged);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelUserName.Location = new System.Drawing.Point(3, 94);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(62, 15);
            this.labelUserName.TabIndex = 4;
            this.labelUserName.Text = "UserName";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(70, 50);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(100, 23);
            this.textBoxPort.TabIndex = 3;
            this.textBoxPort.TextChanged += new System.EventHandler(this.textBoxPort_TextChanged);
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPort.Location = new System.Drawing.Point(16, 53);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(35, 15);
            this.labelPort.TabIndex = 2;
            this.labelPort.Text = "PORT";
            // 
            // LabelIP
            // 
            this.LabelIP.AutoSize = true;
            this.LabelIP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelIP.Location = new System.Drawing.Point(34, 14);
            this.LabelIP.Name = "LabelIP";
            this.LabelIP.Size = new System.Drawing.Size(17, 15);
            this.LabelIP.TabIndex = 1;
            this.LabelIP.Text = "IP";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(70, 11);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(100, 23);
            this.textBoxIP.TabIndex = 0;
            this.textBoxIP.TextChanged += new System.EventHandler(this.textBoxIP_TextChanged);
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(957, 577);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.messagesSetPanel);
            this.Controls.Add(this.bottomChatPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Chat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.Chat_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.bottomChatPanel.ResumeLayout(false);
            this.bottomChatPanel.PerformLayout();
            this.messagesSetPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel headerPanel;
        private Label headerLabel;
        private Button exitButton;
        private Panel bottomChatPanel;
        private TextBox textBox;
        private Panel messagesSetPanel;
        private Button sendButton;
        private Panel panel1;
        private Label label1;
        private Label profileLabel;
        private PictureBox profilePictureBox;
        private Panel panel2;
        private Button buttonClient;
        private Panel panel3;
        private TextBox textBoxPort;
        private Label labelPort;
        private Label LabelIP;
        private TextBox textBoxIP;
        private TextBox textBoxUserName;
        private Label labelUserName;
        private ListBox ListBoxUsers;
        private ListBox listBoxMessagesReceived;
    }
}
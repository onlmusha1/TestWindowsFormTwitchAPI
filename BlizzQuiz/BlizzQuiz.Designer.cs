namespace BlizzQuiz
{
    partial class BlizzQuiz
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
            this.chatTxtBox = new System.Windows.Forms.RichTextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.txtBoxSendMsg = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterCredentialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConnectChannel = new System.Windows.Forms.Button();
            this.txtBoxChannel = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chatTxtBox
            // 
            this.chatTxtBox.Enabled = false;
            this.chatTxtBox.Location = new System.Drawing.Point(12, 38);
            this.chatTxtBox.Name = "chatTxtBox";
            this.chatTxtBox.Size = new System.Drawing.Size(384, 599);
            this.chatTxtBox.TabIndex = 0;
            this.chatTxtBox.Text = "";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(402, 83);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(128, 27);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Location = new System.Drawing.Point(96, 37);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(187, 27);
            this.btnSendMsg.TabIndex = 2;
            this.btnSendMsg.Text = "Send a Message to Chat";
            this.btnSendMsg.UseVisualStyleBackColor = true;
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // txtBoxSendMsg
            // 
            this.txtBoxSendMsg.Location = new System.Drawing.Point(43, 11);
            this.txtBoxSendMsg.Name = "txtBoxSendMsg";
            this.txtBoxSendMsg.Size = new System.Drawing.Size(287, 20);
            this.txtBoxSendMsg.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1269, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem,
            this.enterCredentialsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.connectToolStripMenuItem.Text = "&Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.disconnectToolStripMenuItem.Text = "&Disconnect";
            // 
            // enterCredentialsToolStripMenuItem
            // 
            this.enterCredentialsToolStripMenuItem.Name = "enterCredentialsToolStripMenuItem";
            this.enterCredentialsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.enterCredentialsToolStripMenuItem.Text = "Enter Credentials";
            this.enterCredentialsToolStripMenuItem.Click += new System.EventHandler(this.enterCredentialsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.versionToolStripMenuItem.Text = "Version";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.btnConnectChannel);
            this.panel1.Controls.Add(this.txtBoxSendMsg);
            this.panel1.Controls.Add(this.btnSendMsg);
            this.panel1.Location = new System.Drawing.Point(884, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 216);
            this.panel1.TabIndex = 5;
            // 
            // btnConnectChannel
            // 
            this.btnConnectChannel.Location = new System.Drawing.Point(96, 125);
            this.btnConnectChannel.Name = "btnConnectChannel";
            this.btnConnectChannel.Size = new System.Drawing.Size(187, 29);
            this.btnConnectChannel.TabIndex = 6;
            this.btnConnectChannel.Text = "Connect to Channel";
            this.btnConnectChannel.UseVisualStyleBackColor = true;
            // 
            // txtBoxChannel
            // 
            this.txtBoxChannel.Location = new System.Drawing.Point(402, 57);
            this.txtBoxChannel.Name = "txtBoxChannel";
            this.txtBoxChannel.Size = new System.Drawing.Size(287, 20);
            this.txtBoxChannel.TabIndex = 5;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Gray;
            this.lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl.Location = new System.Drawing.Point(402, 41);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(132, 13);
            this.lbl.TabIndex = 4;
            this.lbl.Text = "Channel Name to Connect";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(402, 116);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(128, 27);
            this.btnDisconnect.TabIndex = 6;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // BlizzQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1269, 649);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtBoxChannel);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.chatTxtBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BlizzQuiz";
            this.Text = "BlizzQuiz";
            this.Load += new System.EventHandler(this.BlizzQuiz_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox chatTxtBox;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnSendMsg;
        private System.Windows.Forms.TextBox txtBoxSendMsg;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterCredentialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtBoxChannel;
        private System.Windows.Forms.Button btnConnectChannel;
        private System.Windows.Forms.Button btnDisconnect;
    }
}


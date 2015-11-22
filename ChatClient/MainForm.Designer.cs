namespace JonasWallander.ChatClient
{
    partial class MainForm
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
            this.uxConnect = new System.Windows.Forms.Button();
            this.uxRemoteUrl = new System.Windows.Forms.TextBox();
            this.uxRemotePort = new System.Windows.Forms.TextBox();
            this.uxLocalPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uxChatMessage = new System.Windows.Forms.TextBox();
            this.uxChat = new System.Windows.Forms.TextBox();
            this.uxSend = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.uxName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uxConnect
            // 
            this.uxConnect.Location = new System.Drawing.Point(261, 92);
            this.uxConnect.Name = "uxConnect";
            this.uxConnect.Size = new System.Drawing.Size(75, 23);
            this.uxConnect.TabIndex = 0;
            this.uxConnect.Text = "Connect";
            this.uxConnect.UseVisualStyleBackColor = true;
            this.uxConnect.Click += new System.EventHandler(this.OnUxConnectClick);
            // 
            // uxRemoteUrl
            // 
            this.uxRemoteUrl.Location = new System.Drawing.Point(88, 41);
            this.uxRemoteUrl.Name = "uxRemoteUrl";
            this.uxRemoteUrl.Size = new System.Drawing.Size(248, 20);
            this.uxRemoteUrl.TabIndex = 1;
            // 
            // uxRemotePort
            // 
            this.uxRemotePort.Location = new System.Drawing.Point(88, 68);
            this.uxRemotePort.Name = "uxRemotePort";
            this.uxRemotePort.Size = new System.Drawing.Size(100, 20);
            this.uxRemotePort.TabIndex = 2;
            this.uxRemotePort.TextChanged += new System.EventHandler(this.ValidateConnect);
            // 
            // uxLocalPort
            // 
            this.uxLocalPort.Location = new System.Drawing.Point(88, 95);
            this.uxLocalPort.Name = "uxLocalPort";
            this.uxLocalPort.Size = new System.Drawing.Size(100, 20);
            this.uxLocalPort.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Remote URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Remote port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Local port";
            // 
            // uxChatMessage
            // 
            this.uxChatMessage.Location = new System.Drawing.Point(12, 470);
            this.uxChatMessage.Name = "uxChatMessage";
            this.uxChatMessage.Size = new System.Drawing.Size(324, 20);
            this.uxChatMessage.TabIndex = 7;
            // 
            // uxChat
            // 
            this.uxChat.Location = new System.Drawing.Point(12, 139);
            this.uxChat.Multiline = true;
            this.uxChat.Name = "uxChat";
            this.uxChat.Size = new System.Drawing.Size(324, 312);
            this.uxChat.TabIndex = 8;
            // 
            // uxSend
            // 
            this.uxSend.Location = new System.Drawing.Point(261, 496);
            this.uxSend.Name = "uxSend";
            this.uxSend.Size = new System.Drawing.Size(75, 23);
            this.uxSend.TabIndex = 9;
            this.uxSend.Text = "Send";
            this.uxSend.UseVisualStyleBackColor = true;
            this.uxSend.Click += new System.EventHandler(this.OnUxChatMessageClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Name";
            // 
            // uxName
            // 
            this.uxName.Location = new System.Drawing.Point(88, 15);
            this.uxName.Name = "uxName";
            this.uxName.Size = new System.Drawing.Size(248, 20);
            this.uxName.TabIndex = 10;
            this.uxName.TextChanged += new System.EventHandler(this.ValidateConnect);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 530);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uxName);
            this.Controls.Add(this.uxSend);
            this.Controls.Add(this.uxChat);
            this.Controls.Add(this.uxChatMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxLocalPort);
            this.Controls.Add(this.uxRemotePort);
            this.Controls.Add(this.uxRemoteUrl);
            this.Controls.Add(this.uxConnect);
            this.Name = "MainForm";
            this.Text = "Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxConnect;
        private System.Windows.Forms.TextBox uxRemoteUrl;
        private System.Windows.Forms.TextBox uxRemotePort;
        private System.Windows.Forms.TextBox uxLocalPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uxChatMessage;
        private System.Windows.Forms.TextBox uxChat;
        private System.Windows.Forms.Button uxSend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox uxName;
    }
}


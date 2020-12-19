namespace Chat_Application_For_PC
{
    partial class Chat
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
            this.chatBox = new System.Windows.Forms.RichTextBox();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.SendButton = new LollipopButton();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.listUsers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // chatBox
            // 
            this.chatBox.Location = new System.Drawing.Point(388, 18);
            this.chatBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chatBox.Name = "chatBox";
            this.chatBox.ReadOnly = true;
            this.chatBox.Size = new System.Drawing.Size(792, 558);
            this.chatBox.TabIndex = 0;
            this.chatBox.Text = "";
            this.chatBox.TextChanged += new System.EventHandler(this.ChatBox_TextChanged);
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(388, 588);
            this.messageBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.messageBox.Multiline = true;
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(688, 84);
            this.messageBox.TabIndex = 1;
            this.messageBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MessageBox_KeyDown);
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.Color.Transparent;
            this.SendButton.BGColor = "#3a230f";
            this.SendButton.FontColor = "#c1b098";
            this.SendButton.Location = new System.Drawing.Point(1088, 588);
            this.SendButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(94, 86);
            this.SendButton.TabIndex = 2;
            this.SendButton.Text = "Send";
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(24, 18);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(48, 29);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "Hi, ";
            // 
            // listUsers
            // 
            this.listUsers.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.listUsers.FormattingEnabled = true;
            this.listUsers.ItemHeight = 20;
            this.listUsers.Location = new System.Drawing.Point(29, 68);
            this.listUsers.Name = "listUsers";
            this.listUsers.Size = new System.Drawing.Size(336, 604);
            this.listUsers.TabIndex = 5;
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(1211, 693);
            this.Controls.Add(this.listUsers);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.chatBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Chat";
            this.Text = "Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Chat_FormClosing);
            this.Load += new System.EventHandler(this.Chat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox chatBox;
        private System.Windows.Forms.TextBox messageBox;
        private LollipopButton SendButton;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.ListBox listUsers;
    }
}
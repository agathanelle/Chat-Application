namespace Chat_Application_For_PC
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.Logo = new System.Windows.Forms.PictureBox();
            this.UsernameLabel = new LollipopLabel();
            this.PasswordLabel = new LollipopLabel();
            this.RepeatPasswordLabel = new LollipopLabel();
            this.SignUpButton = new LollipopButton();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.checkBoxShowRepeatPassword = new System.Windows.Forms.CheckBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.ErrorPanel = new System.Windows.Forms.Panel();
            this.ErrorLabel = new LollipopLabel();
            this.ErrorPicture = new System.Windows.Forms.PictureBox();
            this.RepeatPasswordTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.ErrorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(121, 24);
            this.Logo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(162, 155);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(176)))), ((int)(((byte)(152)))));
            this.UsernameLabel.Location = new System.Drawing.Point(27, 268);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(108, 25);
            this.UsernameLabel.TabIndex = 9;
            this.UsernameLabel.Text = "Username:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(176)))), ((int)(((byte)(152)))));
            this.PasswordLabel.Location = new System.Drawing.Point(27, 358);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(104, 25);
            this.PasswordLabel.TabIndex = 10;
            this.PasswordLabel.Text = "Password:";
            // 
            // RepeatPasswordLabel
            // 
            this.RepeatPasswordLabel.AutoSize = true;
            this.RepeatPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.RepeatPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepeatPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(176)))), ((int)(((byte)(152)))));
            this.RepeatPasswordLabel.Location = new System.Drawing.Point(27, 452);
            this.RepeatPasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RepeatPasswordLabel.Name = "RepeatPasswordLabel";
            this.RepeatPasswordLabel.Size = new System.Drawing.Size(169, 25);
            this.RepeatPasswordLabel.TabIndex = 11;
            this.RepeatPasswordLabel.Text = "Repeat password:";
            // 
            // SignUpButton
            // 
            this.SignUpButton.BackColor = System.Drawing.Color.Transparent;
            this.SignUpButton.BGColor = "#3a230f";
            this.SignUpButton.FontColor = "#c1b098";
            this.SignUpButton.Location = new System.Drawing.Point(92, 558);
            this.SignUpButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(214, 63);
            this.SignUpButton.TabIndex = 12;
            this.SignUpButton.Text = "Sign up";
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Location = new System.Drawing.Point(290, 388);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(148, 24);
            this.checkBoxShowPassword.TabIndex = 14;
            this.checkBoxShowPassword.Text = "Show Password";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.CheckBoxShowPassword_CheckedChanged);
            // 
            // checkBoxShowRepeatPassword
            // 
            this.checkBoxShowRepeatPassword.AutoSize = true;
            this.checkBoxShowRepeatPassword.Location = new System.Drawing.Point(290, 482);
            this.checkBoxShowRepeatPassword.Name = "checkBoxShowRepeatPassword";
            this.checkBoxShowRepeatPassword.Size = new System.Drawing.Size(148, 24);
            this.checkBoxShowRepeatPassword.TabIndex = 15;
            this.checkBoxShowRepeatPassword.Text = "Show Password";
            this.checkBoxShowRepeatPassword.UseVisualStyleBackColor = true;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(32, 296);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(251, 26);
            this.UsernameTextBox.TabIndex = 16;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(32, 386);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(251, 26);
            this.PasswordTextBox.TabIndex = 17;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // ErrorPanel
            // 
            this.ErrorPanel.BackColor = System.Drawing.Color.MistyRose;
            this.ErrorPanel.Controls.Add(this.ErrorLabel);
            this.ErrorPanel.Controls.Add(this.ErrorPicture);
            this.ErrorPanel.Location = new System.Drawing.Point(32, 187);
            this.ErrorPanel.Name = "ErrorPanel";
            this.ErrorPanel.Size = new System.Drawing.Size(364, 66);
            this.ErrorPanel.TabIndex = 18;
            this.ErrorPanel.Visible = false;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.BackColor = System.Drawing.Color.Transparent;
            this.ErrorLabel.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ErrorLabel.Location = new System.Drawing.Point(83, 7);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(237, 54);
            this.ErrorLabel.TabIndex = 1;
            this.ErrorLabel.Text = "Username is used or\r\npasswords do not match";
            // 
            // ErrorPicture
            // 
            this.ErrorPicture.Image = ((System.Drawing.Image)(resources.GetObject("ErrorPicture.Image")));
            this.ErrorPicture.Location = new System.Drawing.Point(3, 3);
            this.ErrorPicture.Name = "ErrorPicture";
            this.ErrorPicture.Size = new System.Drawing.Size(60, 58);
            this.ErrorPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ErrorPicture.TabIndex = 0;
            this.ErrorPicture.TabStop = false;
            // 
            // RepeatPasswordTextBox
            // 
            this.RepeatPasswordTextBox.Location = new System.Drawing.Point(32, 480);
            this.RepeatPasswordTextBox.Name = "RepeatPasswordTextBox";
            this.RepeatPasswordTextBox.Size = new System.Drawing.Size(251, 26);
            this.RepeatPasswordTextBox.TabIndex = 19;
            this.RepeatPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(432, 766);
            this.Controls.Add(this.RepeatPasswordTextBox);
            this.Controls.Add(this.ErrorPanel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.checkBoxShowRepeatPassword);
            this.Controls.Add(this.checkBoxShowPassword);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.RepeatPasswordLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.Logo);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Registration";
            this.Text = "Registration";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ErrorPanel.ResumeLayout(false);
            this.ErrorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private LollipopLabel UsernameLabel;
        private LollipopLabel PasswordLabel;
        private LollipopLabel RepeatPasswordLabel;
        private LollipopButton SignUpButton;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
        private System.Windows.Forms.CheckBox checkBoxShowRepeatPassword;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Panel ErrorPanel;
        private LollipopLabel ErrorLabel;
        private System.Windows.Forms.PictureBox ErrorPicture;
        private System.Windows.Forms.TextBox RepeatPasswordTextBox;
    }
}
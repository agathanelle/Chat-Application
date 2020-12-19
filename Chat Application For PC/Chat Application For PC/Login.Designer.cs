namespace Chat_Application_For_PC
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Logo = new System.Windows.Forms.PictureBox();
            this.ForgotPasswordLabel = new LollipopLabel();
            this.SignUpButton = new LollipopButton();
            this.LoginButton = new LollipopButton();
            this.PasswordLabel = new LollipopLabel();
            this.UsernameLabel = new LollipopLabel();
            this.ErrorPicture = new System.Windows.Forms.PictureBox();
            this.ErrorLabel = new LollipopLabel();
            this.ErrorPanel = new System.Windows.Forms.Panel();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPicture)).BeginInit();
            this.ErrorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(123, 14);
            this.Logo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(162, 155);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // ForgotPasswordLabel
            // 
            this.ForgotPasswordLabel.AutoSize = true;
            this.ForgotPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.ForgotPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgotPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(35)))), ((int)(((byte)(15)))));
            this.ForgotPasswordLabel.Location = new System.Drawing.Point(117, 640);
            this.ForgotPasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ForgotPasswordLabel.Name = "ForgotPasswordLabel";
            this.ForgotPasswordLabel.Size = new System.Drawing.Size(168, 25);
            this.ForgotPasswordLabel.TabIndex = 9;
            this.ForgotPasswordLabel.Text = "Forgot password?";
            // 
            // SignUpButton
            // 
            this.SignUpButton.BackColor = System.Drawing.Color.Transparent;
            this.SignUpButton.BGColor = "#c1b098";
            this.SignUpButton.FontColor = "#3a230f";
            this.SignUpButton.Location = new System.Drawing.Point(94, 555);
            this.SignUpButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(214, 63);
            this.SignUpButton.TabIndex = 8;
            this.SignUpButton.Text = "Sign up";
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Transparent;
            this.LoginButton.BGColor = "#3a230f";
            this.LoginButton.FontColor = "#c1b098";
            this.LoginButton.Location = new System.Drawing.Point(94, 483);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(214, 63);
            this.LoginButton.TabIndex = 7;
            this.LoginButton.Text = "Login";
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(176)))), ((int)(((byte)(152)))));
            this.PasswordLabel.Location = new System.Drawing.Point(30, 361);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(98, 25);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Password";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(176)))), ((int)(((byte)(152)))));
            this.UsernameLabel.Location = new System.Drawing.Point(30, 280);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(102, 25);
            this.UsernameLabel.TabIndex = 3;
            this.UsernameLabel.Text = "Username";
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
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.BackColor = System.Drawing.Color.Transparent;
            this.ErrorLabel.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ErrorLabel.Location = new System.Drawing.Point(83, 7);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(191, 54);
            this.ErrorLabel.TabIndex = 1;
            this.ErrorLabel.Text = "Incorrect username\r\nor password";
            // 
            // ErrorPanel
            // 
            this.ErrorPanel.BackColor = System.Drawing.Color.MistyRose;
            this.ErrorPanel.Controls.Add(this.ErrorLabel);
            this.ErrorPanel.Controls.Add(this.ErrorPicture);
            this.ErrorPanel.Location = new System.Drawing.Point(35, 193);
            this.ErrorPanel.Name = "ErrorPanel";
            this.ErrorPanel.Size = new System.Drawing.Size(364, 66);
            this.ErrorPanel.TabIndex = 10;
            this.ErrorPanel.Visible = false;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsernameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.UsernameTextBox.Location = new System.Drawing.Point(37, 308);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(248, 26);
            this.UsernameTextBox.TabIndex = 11;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.PasswordTextBox.Location = new System.Drawing.Point(35, 389);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(250, 26);
            this.PasswordTextBox.TabIndex = 12;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Location = new System.Drawing.Point(291, 389);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(148, 24);
            this.checkBoxShowPassword.TabIndex = 15;
            this.checkBoxShowPassword.Text = "Show Password";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(432, 766);
            this.Controls.Add(this.checkBoxShowPassword);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.ErrorPanel);
            this.Controls.Add(this.ForgotPasswordLabel);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.Logo);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPicture)).EndInit();
            this.ErrorPanel.ResumeLayout(false);
            this.ErrorPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private LollipopLabel UsernameLabel;
        private LollipopLabel PasswordLabel;
        private LollipopButton LoginButton;
        private LollipopButton SignUpButton;
        private LollipopLabel ForgotPasswordLabel;
        private System.Windows.Forms.PictureBox ErrorPicture;
        private LollipopLabel ErrorLabel;
        private System.Windows.Forms.Panel ErrorPanel;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
    }
}


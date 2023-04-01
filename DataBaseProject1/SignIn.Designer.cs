namespace DataBaseProject1
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.loginButton = new System.Windows.Forms.Button();
            this.outsideUsername = new System.Windows.Forms.TextBox();
            this.outsidePassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.goToRegister = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.showPassword = new System.Windows.Forms.PictureBox();
            this.hidePassword = new System.Windows.Forms.PictureBox();
            this.UsernameLog = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.focus = new System.Windows.Forms.Label();
            this.usernameInfo = new System.Windows.Forms.Label();
            this.passwordInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidePassword)).BeginInit();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(103)))));
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold);
            this.loginButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginButton.Location = new System.Drawing.Point(231, 305);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 34);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Enter";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click_1);
            // 
            // outsideUsername
            // 
            this.outsideUsername.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F);
            this.outsideUsername.Location = new System.Drawing.Point(88, 165);
            this.outsideUsername.Name = "outsideUsername";
            this.outsideUsername.Size = new System.Drawing.Size(218, 21);
            this.outsideUsername.TabIndex = 1;
            // 
            // outsidePassword
            // 
            this.outsidePassword.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F);
            this.outsidePassword.Location = new System.Drawing.Point(88, 234);
            this.outsidePassword.Name = "outsidePassword";
            this.outsidePassword.Size = new System.Drawing.Size(218, 21);
            this.outsidePassword.TabIndex = 2;
            this.outsidePassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Oswald", 20.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(147, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "SIGN IN";
            // 
            // goToRegister
            // 
            this.goToRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToRegister.FlatAppearance.BorderSize = 0;
            this.goToRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToRegister.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold);
            this.goToRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(103)))));
            this.goToRegister.Location = new System.Drawing.Point(79, 305);
            this.goToRegister.Margin = new System.Windows.Forms.Padding(0);
            this.goToRegister.Name = "goToRegister";
            this.goToRegister.Size = new System.Drawing.Size(117, 34);
            this.goToRegister.TabIndex = 6;
            this.goToRegister.Text = "Create Account";
            this.goToRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToRegister.UseVisualStyleBackColor = true;
            this.goToRegister.Click += new System.EventHandler(this.goToRegister_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(176, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // showPassword
            // 
            this.showPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPassword.Image = ((System.Drawing.Image)(resources.GetObject("showPassword.Image")));
            this.showPassword.Location = new System.Drawing.Point(326, 229);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(31, 30);
            this.showPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showPassword.TabIndex = 20;
            this.showPassword.TabStop = false;
            this.showPassword.Click += new System.EventHandler(this.showPassword_Click);
            // 
            // hidePassword
            // 
            this.hidePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hidePassword.Image = ((System.Drawing.Image)(resources.GetObject("hidePassword.Image")));
            this.hidePassword.Location = new System.Drawing.Point(326, 229);
            this.hidePassword.Name = "hidePassword";
            this.hidePassword.Size = new System.Drawing.Size(31, 30);
            this.hidePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hidePassword.TabIndex = 21;
            this.hidePassword.TabStop = false;
            this.hidePassword.Visible = false;
            this.hidePassword.Click += new System.EventHandler(this.hidePassword_Click);
            // 
            // UsernameLog
            // 
            this.UsernameLog.AutoSize = true;
            this.UsernameLog.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLog.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.UsernameLog.Location = new System.Drawing.Point(85, 146);
            this.UsernameLog.Name = "UsernameLog";
            this.UsernameLog.Size = new System.Drawing.Size(60, 16);
            this.UsernameLog.TabIndex = 22;
            this.UsernameLog.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(85, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Password";
            // 
            // focus
            // 
            this.focus.AutoSize = true;
            this.focus.Location = new System.Drawing.Point(180, 44);
            this.focus.Name = "focus";
            this.focus.Size = new System.Drawing.Size(33, 13);
            this.focus.TabIndex = 24;
            this.focus.Text = "focus";
            // 
            // usernameInfo
            // 
            this.usernameInfo.AutoSize = true;
            this.usernameInfo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.usernameInfo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.usernameInfo.Font = new System.Drawing.Font("Microsoft Tai Le", 7F, System.Drawing.FontStyle.Bold);
            this.usernameInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.usernameInfo.Location = new System.Drawing.Point(85, 189);
            this.usernameInfo.Name = "usernameInfo";
            this.usernameInfo.Size = new System.Drawing.Size(88, 13);
            this.usernameInfo.TabIndex = 27;
            this.usernameInfo.Text = "Invalid username!";
            this.usernameInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.usernameInfo.Visible = false;
            // 
            // passwordInfo
            // 
            this.passwordInfo.AutoSize = true;
            this.passwordInfo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passwordInfo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.passwordInfo.Font = new System.Drawing.Font("Microsoft Tai Le", 7F, System.Drawing.FontStyle.Bold);
            this.passwordInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.passwordInfo.Location = new System.Drawing.Point(85, 258);
            this.passwordInfo.Name = "passwordInfo";
            this.passwordInfo.Size = new System.Drawing.Size(87, 13);
            this.passwordInfo.TabIndex = 28;
            this.passwordInfo.Text = "Invalid password!";
            this.passwordInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.passwordInfo.Visible = false;
            // 
            // SignIn
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(400, 427);
            this.Controls.Add(this.passwordInfo);
            this.Controls.Add(this.usernameInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UsernameLog);
            this.Controls.Add(this.hidePassword);
            this.Controls.Add(this.showPassword);
            this.Controls.Add(this.goToRegister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outsidePassword);
            this.Controls.Add(this.outsideUsername);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.focus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign in";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidePassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox outsideUsername;
        private System.Windows.Forms.TextBox outsidePassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button goToRegister;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox showPassword;
        private System.Windows.Forms.PictureBox hidePassword;
        private System.Windows.Forms.Label UsernameLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label focus;
        private System.Windows.Forms.Label usernameInfo;
        private System.Windows.Forms.Label passwordInfo;
    }
}


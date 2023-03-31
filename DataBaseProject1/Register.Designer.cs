namespace DataBaseProject1
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.Username = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameRegister = new System.Windows.Forms.TextBox();
            this.passwordRegister = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.goToLogin = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.phoneRegister = new System.Windows.Forms.TextBox();
            this.emailRegister = new System.Windows.Forms.TextBox();
            this.phhone = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameInfo = new System.Windows.Forms.Label();
            this.passwordInfo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.phoneInfo = new System.Windows.Forms.Label();
            this.usernameInformation = new System.Windows.Forms.Label();
            this.labelfocus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Username.Location = new System.Drawing.Point(93, 70);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(65, 16);
            this.Username.TabIndex = 0;
            this.Username.Text = "Username*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(93, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password*";
            // 
            // usernameRegister
            // 
            this.usernameRegister.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.usernameRegister.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameRegister.ForeColor = System.Drawing.SystemColors.MenuText;
            this.usernameRegister.Location = new System.Drawing.Point(96, 86);
            this.usernameRegister.Name = "usernameRegister";
            this.usernameRegister.Size = new System.Drawing.Size(197, 21);
            this.usernameRegister.TabIndex = 2;
            this.usernameRegister.Enter += new System.EventHandler(this.usernameRegister_Enter);
            this.usernameRegister.Leave += new System.EventHandler(this.usernameRegister_Leave);
            // 
            // passwordRegister
            // 
            this.passwordRegister.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordRegister.Location = new System.Drawing.Point(96, 144);
            this.passwordRegister.Name = "passwordRegister";
            this.passwordRegister.Size = new System.Drawing.Size(197, 21);
            this.passwordRegister.TabIndex = 3;
            this.passwordRegister.Enter += new System.EventHandler(this.passwordRegister_Enter);
            this.passwordRegister.Leave += new System.EventHandler(this.passwordRegister_Leave);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(103)))));
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegister.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRegister.Location = new System.Drawing.Point(220, 333);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(75, 34);
            this.buttonRegister.TabIndex = 7;
            this.buttonRegister.Text = "Create";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // goToLogin
            // 
            this.goToLogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.goToLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.goToLogin.FlatAppearance.BorderSize = 0;
            this.goToLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToLogin.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold);
            this.goToLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(103)))));
            this.goToLogin.Location = new System.Drawing.Point(86, 333);
            this.goToLogin.Margin = new System.Windows.Forms.Padding(0);
            this.goToLogin.Name = "goToLogin";
            this.goToLogin.Size = new System.Drawing.Size(114, 34);
            this.goToLogin.TabIndex = 6;
            this.goToLogin.Text = "Sign in instead";
            this.goToLogin.UseVisualStyleBackColor = false;
            this.goToLogin.Click += new System.EventHandler(this.goToLogin_Click);
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(93, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "* Required";
            // 
            // phoneRegister
            // 
            this.phoneRegister.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneRegister.Location = new System.Drawing.Point(96, 259);
            this.phoneRegister.Name = "phoneRegister";
            this.phoneRegister.Size = new System.Drawing.Size(197, 21);
            this.phoneRegister.TabIndex = 5;
            this.phoneRegister.Enter += new System.EventHandler(this.phoneRegister_Enter);
            this.phoneRegister.Leave += new System.EventHandler(this.phoneRegister_Leave);
            // 
            // emailRegister
            // 
            this.emailRegister.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailRegister.Location = new System.Drawing.Point(96, 202);
            this.emailRegister.Name = "emailRegister";
            this.emailRegister.Size = new System.Drawing.Size(197, 21);
            this.emailRegister.TabIndex = 4;
            // 
            // phhone
            // 
            this.phhone.AutoSize = true;
            this.phhone.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phhone.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.phhone.Location = new System.Drawing.Point(93, 243);
            this.phhone.Name = "phhone";
            this.phhone.Size = new System.Drawing.Size(88, 16);
            this.phhone.TabIndex = 14;
            this.phhone.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(93, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "E-Mail Adress*";
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Oswald", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(111, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 40);
            this.label5.TabIndex = 17;
            this.label5.Text = "REGISTRATION";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(395, -3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 373);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(444, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 14);
            this.label1.TabIndex = 19;
            this.label1.Text = "KEEP YOUR PRIVACY SAFE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameInfo
            // 
            this.usernameInfo.AutoSize = true;
            this.usernameInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.usernameInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usernameInfo.Font = new System.Drawing.Font("Microsoft Tai Le", 7F, System.Drawing.FontStyle.Bold);
            this.usernameInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.usernameInfo.Location = new System.Drawing.Point(297, 83);
            this.usernameInfo.Name = "usernameInfo";
            this.usernameInfo.Size = new System.Drawing.Size(126, 28);
            this.usernameInfo.TabIndex = 20;
            this.usernameInfo.Text = "Only letters and numbers\r\nare allowed.";
            this.usernameInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.usernameInfo.Visible = false;
            this.usernameInfo.Click += new System.EventHandler(this.emailInfo_Click);
            // 
            // passwordInfo
            // 
            this.passwordInfo.AutoSize = true;
            this.passwordInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(103)))));
            this.passwordInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passwordInfo.Font = new System.Drawing.Font("Microsoft Tai Le", 7F, System.Drawing.FontStyle.Bold);
            this.passwordInfo.ForeColor = System.Drawing.Color.Gold;
            this.passwordInfo.Location = new System.Drawing.Point(297, 134);
            this.passwordInfo.Name = "passwordInfo";
            this.passwordInfo.Size = new System.Drawing.Size(127, 41);
            this.passwordInfo.TabIndex = 21;
            this.passwordInfo.Text = "Use 8 or more characters \r\nwith a mix of letters, \r\nnumbers and symbols";
            this.passwordInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.passwordInfo.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(24, 186);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 25);
            this.button1.TabIndex = 22;
            this.button1.TabStop = false;
            this.button1.Text = "borderbutton";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // phoneInfo
            // 
            this.phoneInfo.AutoSize = true;
            this.phoneInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(103)))));
            this.phoneInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.phoneInfo.Font = new System.Drawing.Font("Microsoft Tai Le", 7F, System.Drawing.FontStyle.Bold);
            this.phoneInfo.ForeColor = System.Drawing.Color.Gold;
            this.phoneInfo.Location = new System.Drawing.Point(296, 243);
            this.phoneInfo.Name = "phoneInfo";
            this.phoneInfo.Size = new System.Drawing.Size(144, 54);
            this.phoneInfo.TabIndex = 23;
            this.phoneInfo.Text = "Provide your phone \r\nnumber to access your\r\ndata faster and gain \r\nEXTRA SECURITY" +
    " FEATURES!";
            this.phoneInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.phoneInfo.Visible = false;
            // 
            // usernameInformation
            // 
            this.usernameInformation.AutoSize = true;
            this.usernameInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(103)))));
            this.usernameInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usernameInformation.Font = new System.Drawing.Font("Microsoft Tai Le", 7F, System.Drawing.FontStyle.Bold);
            this.usernameInformation.ForeColor = System.Drawing.Color.Gold;
            this.usernameInformation.Location = new System.Drawing.Point(297, 83);
            this.usernameInformation.Name = "usernameInformation";
            this.usernameInformation.Size = new System.Drawing.Size(126, 28);
            this.usernameInformation.TabIndex = 24;
            this.usernameInformation.Text = "Only letters and numbers\r\nare allowed.";
            this.usernameInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.usernameInformation.Visible = false;
            // 
            // labelfocus
            // 
            this.labelfocus.AutoSize = true;
            this.labelfocus.Location = new System.Drawing.Point(488, 189);
            this.labelfocus.Name = "labelfocus";
            this.labelfocus.Size = new System.Drawing.Size(55, 13);
            this.labelfocus.TabIndex = 25;
            this.labelfocus.Text = "labelfocus";
            // 
            // Register
            // 
            this.AcceptButton = this.buttonRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton = this.goToLogin;
            this.ClientSize = new System.Drawing.Size(639, 398);
            this.Controls.Add(this.phoneInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordInfo);
            this.Controls.Add(this.usernameInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.phoneRegister);
            this.Controls.Add(this.emailRegister);
            this.Controls.Add(this.phhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.goToLogin);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.passwordRegister);
            this.Controls.Add(this.usernameRegister);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.usernameInformation);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelfocus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(655, 437);
            this.MinimumSize = new System.Drawing.Size(655, 437);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameRegister;
        private System.Windows.Forms.TextBox passwordRegister;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button goToLogin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox phoneRegister;
        private System.Windows.Forms.TextBox emailRegister;
        private System.Windows.Forms.Label phhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label usernameInfo;
        private System.Windows.Forms.Label passwordInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label phoneInfo;
        private System.Windows.Forms.Label usernameInformation;
        private System.Windows.Forms.Label labelfocus;
    }
}
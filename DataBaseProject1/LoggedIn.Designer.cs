namespace DataBaseProject1
{
    partial class LoggedIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoggedIn));
            this.panel1 = new System.Windows.Forms.Panel();
            this.identityTab = new System.Windows.Forms.Button();
            this.cardTab = new System.Windows.Forms.Button();
            this.loginTab = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.emptyLoginList = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.addNewLogin = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.newFormHeader = new System.Windows.Forms.Panel();
            this.newFormType = new System.Windows.Forms.ComboBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.newFormHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.identityTab);
            this.panel1.Controls.Add(this.cardTab);
            this.panel1.Controls.Add(this.loginTab);
            this.panel1.Location = new System.Drawing.Point(-3, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 638);
            this.panel1.TabIndex = 0;
            // 
            // identityTab
            // 
            this.identityTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.identityTab.FlatAppearance.BorderSize = 0;
            this.identityTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.identityTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.identityTab.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.identityTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.identityTab.Location = new System.Drawing.Point(3, 111);
            this.identityTab.Name = "identityTab";
            this.identityTab.Size = new System.Drawing.Size(210, 48);
            this.identityTab.TabIndex = 2;
            this.identityTab.Text = "🙍   Identity";
            this.identityTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.identityTab.UseVisualStyleBackColor = true;
            this.identityTab.Click += new System.EventHandler(this.identityTab_Click);
            // 
            // cardTab
            // 
            this.cardTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardTab.FlatAppearance.BorderSize = 0;
            this.cardTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cardTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardTab.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cardTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cardTab.Location = new System.Drawing.Point(3, 57);
            this.cardTab.Name = "cardTab";
            this.cardTab.Size = new System.Drawing.Size(210, 48);
            this.cardTab.TabIndex = 1;
            this.cardTab.Text = "💳  Card";
            this.cardTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cardTab.UseVisualStyleBackColor = true;
            this.cardTab.Click += new System.EventHandler(this.cardTab_Click);
            // 
            // loginTab
            // 
            this.loginTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginTab.FlatAppearance.BorderSize = 0;
            this.loginTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.loginTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginTab.Location = new System.Drawing.Point(3, 3);
            this.loginTab.Name = "loginTab";
            this.loginTab.Size = new System.Drawing.Size(210, 48);
            this.loginTab.TabIndex = 0;
            this.loginTab.Text = "🌍  Login";
            this.loginTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginTab.UseVisualStyleBackColor = true;
            this.loginTab.Click += new System.EventHandler(this.loginTab_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.emptyLoginList);
            this.panel2.Location = new System.Drawing.Point(209, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 576);
            this.panel2.TabIndex = 1;
            // 
            // emptyLoginList
            // 
            this.emptyLoginList.AutoSize = true;
            this.emptyLoginList.Location = new System.Drawing.Point(81, 256);
            this.emptyLoginList.Name = "emptyLoginList";
            this.emptyLoginList.Size = new System.Drawing.Size(125, 13);
            this.emptyLoginList.TabIndex = 0;
            this.emptyLoginList.Text = "There are no items to list.";
            this.emptyLoginList.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.addNewLogin);
            this.panel5.Location = new System.Drawing.Point(207, 617);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(284, 67);
            this.panel5.TabIndex = 2;
            // 
            // addNewLogin
            // 
            this.addNewLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addNewLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewLogin.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addNewLogin.Location = new System.Drawing.Point(8, 15);
            this.addNewLogin.Name = "addNewLogin";
            this.addNewLogin.Size = new System.Drawing.Size(268, 40);
            this.addNewLogin.TabIndex = 1;
            this.addNewLogin.Text = "➕";
            this.addNewLogin.UseVisualStyleBackColor = true;
            this.addNewLogin.Visible = false;
            this.addNewLogin.Click += new System.EventHandler(this.addNewLogin_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(103)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Location = new System.Drawing.Point(-3, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1268, 48);
            this.panel4.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(77)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Enabled = false;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(346, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(27, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "🔍";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(77)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(252)))), ((int)(((byte)(242)))));
            this.textBox1.Location = new System.Drawing.Point(373, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(538, 23);
            this.textBox1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(490, 123);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(755, 561);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(305, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 14);
            this.label1.TabIndex = 20;
            this.label1.Text = "KEEP YOUR PRIVACY SAFE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(204, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // newFormHeader
            // 
            this.newFormHeader.AutoScroll = true;
            this.newFormHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.newFormHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newFormHeader.Controls.Add(this.newFormType);
            this.newFormHeader.Controls.Add(this.typeLabel);
            this.newFormHeader.Location = new System.Drawing.Point(490, 42);
            this.newFormHeader.Name = "newFormHeader";
            this.newFormHeader.Size = new System.Drawing.Size(755, 82);
            this.newFormHeader.TabIndex = 21;
            // 
            // newFormType
            // 
            this.newFormType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.newFormType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newFormType.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newFormType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.newFormType.FormattingEnabled = true;
            this.newFormType.Items.AddRange(new object[] {
            "Login",
            "Card",
            "Identity"});
            this.newFormType.Location = new System.Drawing.Point(187, 35);
            this.newFormType.Name = "newFormType";
            this.newFormType.Size = new System.Drawing.Size(379, 22);
            this.newFormType.TabIndex = 10;
            this.newFormType.SelectedIndexChanged += new System.EventHandler(this.newFormType_SelectedIndexChanged);
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.typeLabel.Location = new System.Drawing.Point(355, 18);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(29, 14);
            this.typeLabel.TabIndex = 9;
            this.typeLabel.Text = "TYPE";
            // 
            // LoggedIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1244, 683);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.newFormHeader);
            this.Controls.Add(this.panel3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1260, 722);
            this.MinimumSize = new System.Drawing.Size(1260, 722);
            this.Name = "LoggedIn";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoggedIn";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.newFormHeader.ResumeLayout(false);
            this.newFormHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button loginTab;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button identityTab;
        private System.Windows.Forms.Button cardTab;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button addNewLogin;
        private System.Windows.Forms.Label emptyLoginList;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel newFormHeader;
        private System.Windows.Forms.Label typeLabel;
        public System.Windows.Forms.ComboBox newFormType;
    }
}
namespace DXApplication8
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxuser_name = new System.Windows.Forms.ComboBox();
            this.cbxbranches = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.connectonline = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioemployee = new System.Windows.Forms.RadioButton();
            this.radiomanger = new System.Windows.Forms.RadioButton();
            this.btnexit = new DevExpress.XtraEditors.SimpleButton();
            this.btnenter = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pctlogin = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctlogin)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Forte", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(478, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 32);
            this.label5.TabIndex = 154;
            this.label5.Text = "Big BOS TradinG";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbxuser_name);
            this.groupBox2.Controls.Add(this.cbxbranches);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtpassword);
            this.groupBox2.Location = new System.Drawing.Point(4, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 196);
            this.groupBox2.TabIndex = 152;
            this.groupBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(383, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 20);
            this.label9.TabIndex = 149;
            this.label9.Text = "كلمه السر :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(367, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 148;
            this.label8.Text = "اسم المستخدم :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(396, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 147;
            this.label7.Text = "الفرع :";
            // 
            // cbxuser_name
            // 
            this.cbxuser_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxuser_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxuser_name.FormattingEnabled = true;
            this.cbxuser_name.Location = new System.Drawing.Point(6, 102);
            this.cbxuser_name.Name = "cbxuser_name";
            this.cbxuser_name.Size = new System.Drawing.Size(443, 27);
            this.cbxuser_name.TabIndex = 146;
            this.cbxuser_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxuser_name_KeyPress);
            // 
            // cbxbranches
            // 
            this.cbxbranches.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxbranches.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxbranches.BackColor = System.Drawing.Color.RoyalBlue;
            this.cbxbranches.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxbranches.ForeColor = System.Drawing.Color.Yellow;
            this.cbxbranches.FormattingEnabled = true;
            this.cbxbranches.Location = new System.Drawing.Point(6, 41);
            this.cbxbranches.Name = "cbxbranches";
            this.cbxbranches.Size = new System.Drawing.Size(443, 27);
            this.cbxbranches.TabIndex = 145;
            this.cbxbranches.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxbranches_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 144;
            this.label4.Text = "Branch Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 142;
            this.label3.Text = "User Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 141;
            this.label1.Text = "Password :";
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.White;
            this.txtpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtpassword.Location = new System.Drawing.Point(6, 164);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(443, 26);
            this.txtpassword.TabIndex = 143;
            this.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpassword_KeyPress);
            // 
            // connectonline
            // 
            this.connectonline.Appearance.Font = new System.Drawing.Font("Droid Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectonline.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.connectonline.Appearance.Options.UseFont = true;
            this.connectonline.Appearance.Options.UseForeColor = true;
            this.connectonline.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("connectonline.ImageOptions.Image")));
            this.connectonline.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.connectonline.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.connectonline.Location = new System.Drawing.Point(476, 270);
            this.connectonline.Name = "connectonline";
            this.connectonline.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.connectonline.Size = new System.Drawing.Size(225, 34);
            this.connectonline.TabIndex = 153;
            this.connectonline.Text = "الربط اونلاين";
            this.connectonline.Click += new System.EventHandler(this.connectonline_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioemployee);
            this.groupBox1.Controls.Add(this.radiomanger);
            this.groupBox1.Location = new System.Drawing.Point(4, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 73);
            this.groupBox1.TabIndex = 151;
            this.groupBox1.TabStop = false;
            // 
            // radioemployee
            // 
            this.radioemployee.AutoSize = true;
            this.radioemployee.Location = new System.Drawing.Point(207, 25);
            this.radioemployee.Name = "radioemployee";
            this.radioemployee.Size = new System.Drawing.Size(57, 23);
            this.radioemployee.TabIndex = 3;
            this.radioemployee.TabStop = true;
            this.radioemployee.Text = "موظف";
            this.radioemployee.UseVisualStyleBackColor = true;
            // 
            // radiomanger
            // 
            this.radiomanger.AutoSize = true;
            this.radiomanger.Location = new System.Drawing.Point(400, 25);
            this.radiomanger.Name = "radiomanger";
            this.radiomanger.Size = new System.Drawing.Size(49, 23);
            this.radiomanger.TabIndex = 2;
            this.radiomanger.TabStop = true;
            this.radiomanger.Text = "مدير";
            this.radiomanger.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            this.btnexit.Appearance.Font = new System.Drawing.Font("Droid Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnexit.Appearance.Options.UseFont = true;
            this.btnexit.Appearance.Options.UseForeColor = true;
            this.btnexit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.ImageOptions.Image")));
            this.btnexit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnexit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnexit.Location = new System.Drawing.Point(476, 305);
            this.btnexit.Name = "btnexit";
            this.btnexit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnexit.Size = new System.Drawing.Size(225, 34);
            this.btnexit.TabIndex = 150;
            this.btnexit.Text = "خروج";
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnenter
            // 
            this.btnenter.Appearance.Font = new System.Drawing.Font("Droid Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenter.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnenter.Appearance.Options.UseFont = true;
            this.btnenter.Appearance.Options.UseForeColor = true;
            this.btnenter.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnenter.ImageOptions.Image")));
            this.btnenter.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnenter.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnenter.Location = new System.Drawing.Point(476, 230);
            this.btnenter.Name = "btnenter";
            this.btnenter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnenter.Size = new System.Drawing.Size(225, 39);
            this.btnenter.TabIndex = 149;
            this.btnenter.Text = "دخول";
            this.btnenter.Click += new System.EventHandler(this.btnenter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 148;
            this.label2.Text = "الدخول الي النظام";
            // 
            // pctlogin
            // 
            this.pctlogin.Image = ((System.Drawing.Image)(resources.GetObject("pctlogin.Image")));
            this.pctlogin.Location = new System.Drawing.Point(478, 3);
            this.pctlogin.Name = "pctlogin";
            this.pctlogin.Size = new System.Drawing.Size(223, 185);
            this.pctlogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctlogin.TabIndex = 147;
            this.pctlogin.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Forte", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(75, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(397, 32);
            this.label6.TabIndex = 155;
            this.label6.Text = "Welcome To Big BOS System ...";
            // 
            // dtpdate
            // 
            this.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdate.Location = new System.Drawing.Point(501, 85);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(200, 26);
            this.dtpdate.TabIndex = 156;
            this.dtpdate.Visible = false;
            // 
            // login
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Appearance.ForeColor = System.Drawing.Color.Yellow;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(701, 341);
            this.Controls.Add(this.dtpdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.connectonline);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnenter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pctlogin);
            this.Font = new System.Drawing.Font("Droid Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.login_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctlogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxuser_name;
        private System.Windows.Forms.ComboBox cbxbranches;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpassword;
        private DevExpress.XtraEditors.SimpleButton connectonline;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioemployee;
        private System.Windows.Forms.RadioButton radiomanger;
        private DevExpress.XtraEditors.SimpleButton btnexit;
        private DevExpress.XtraEditors.SimpleButton btnenter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pctlogin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpdate;
    }
}
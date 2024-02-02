namespace DXApplication8
{
    partial class serverconnectiononline
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(serverconnectiononline));
            this.btnsave = new DevExpress.XtraEditors.SimpleButton();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtdatabasename = new System.Windows.Forms.TextBox();
            this.txtservername = new System.Windows.Forms.TextBox();
            this.checkdontshow = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsave
            // 
            this.btnsave.Appearance.Font = new System.Drawing.Font("Droid Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnsave.Appearance.Options.UseFont = true;
            this.btnsave.Appearance.Options.UseForeColor = true;
            this.btnsave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.ImageOptions.Image")));
            this.btnsave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnsave.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnsave.Location = new System.Drawing.Point(12, 387);
            this.btnsave.Name = "btnsave";
            this.btnsave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnsave.Size = new System.Drawing.Size(550, 55);
            this.btnsave.TabIndex = 146;
            this.btnsave.Text = "حفظ";
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(163, 281);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(380, 26);
            this.txtpassword.TabIndex = 145;
            this.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(163, 212);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(380, 26);
            this.txtusername.TabIndex = 144;
            this.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtdatabasename
            // 
            this.txtdatabasename.Location = new System.Drawing.Point(163, 136);
            this.txtdatabasename.Name = "txtdatabasename";
            this.txtdatabasename.Size = new System.Drawing.Size(380, 26);
            this.txtdatabasename.TabIndex = 143;
            this.txtdatabasename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtservername
            // 
            this.txtservername.Location = new System.Drawing.Point(163, 62);
            this.txtservername.Name = "txtservername";
            this.txtservername.Size = new System.Drawing.Size(380, 26);
            this.txtservername.TabIndex = 142;
            this.txtservername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkdontshow
            // 
            this.checkdontshow.AutoSize = true;
            this.checkdontshow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.checkdontshow.Location = new System.Drawing.Point(223, 339);
            this.checkdontshow.Name = "checkdontshow";
            this.checkdontshow.Size = new System.Drawing.Size(191, 23);
            this.checkdontshow.TabIndex = 141;
            this.checkdontshow.Text = "عدم اظهار هذه الشاشه مره اخري";
            this.checkdontshow.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 140;
            this.label4.Text = "اسم المستخدم :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 139;
            this.label3.Text = "اسم قاعده البيانات :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 23);
            this.label2.TabIndex = 138;
            this.label2.Text = "اسم السيرفر او ال IP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 137;
            this.label1.Text = "اعدادات السيرفر";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 147;
            this.label5.Text = "كلمه المرور :";
            // 
            // serverconnectiononline
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(571, 446);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtdatabasename);
            this.Controls.Add(this.txtservername);
            this.Controls.Add(this.checkdontshow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Droid Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "serverconnectiononline";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الاتصال بقاعده البيانات";
            this.Load += new System.EventHandler(this.serverconnectiononline_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnsave;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtdatabasename;
        private System.Windows.Forms.TextBox txtservername;
        private System.Windows.Forms.CheckBox checkdontshow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}
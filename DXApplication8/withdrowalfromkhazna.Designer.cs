namespace DXApplication8
{
    partial class withdrowalfromkhazna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(withdrowalfromkhazna));
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxkhaznaname = new System.Windows.Forms.ComboBox();
            this.btnadd = new DevExpress.XtraEditors.SimpleButton();
            this.txteda3reason = new System.Windows.Forms.TextBox();
            this.txtnamemode3 = new System.Windows.Forms.TextBox();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.numericaddnewbalance = new System.Windows.Forms.NumericUpDown();
            this.lbltotal_khaznanow = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericaddnewbalance)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(64, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 21);
            this.label8.TabIndex = 90;
            this.label8.Text = "سبب السحب :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(65, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 21);
            this.label7.TabIndex = 89;
            this.label7.Text = "اسم الساحب :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 21);
            this.label6.TabIndex = 88;
            this.label6.Text = "تاريخ السحب :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 22);
            this.label5.TabIndex = 87;
            this.label5.Text = "المبلغ المراد سحبه : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 22);
            this.label4.TabIndex = 86;
            this.label4.Text = "اختر الخزنه :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(34, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 31);
            this.label2.TabIndex = 85;
            this.label2.Text = "رصيد الخزنه الحالي :";
            // 
            // cbxkhaznaname
            // 
            this.cbxkhaznaname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxkhaznaname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxkhaznaname.BackColor = System.Drawing.Color.White;
            this.cbxkhaznaname.ForeColor = System.Drawing.Color.Navy;
            this.cbxkhaznaname.FormattingEnabled = true;
            this.cbxkhaznaname.Location = new System.Drawing.Point(208, 50);
            this.cbxkhaznaname.Name = "cbxkhaznaname";
            this.cbxkhaznaname.Size = new System.Drawing.Size(307, 27);
            this.cbxkhaznaname.TabIndex = 84;
            this.cbxkhaznaname.SelectionChangeCommitted += new System.EventHandler(this.cbxkhaznaname_SelectionChangeCommitted);
            this.cbxkhaznaname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxkhaznaname_KeyPress);
            // 
            // btnadd
            // 
            this.btnadd.Appearance.BackColor = System.Drawing.Color.Red;
            this.btnadd.Appearance.BackColor2 = System.Drawing.Color.Red;
            this.btnadd.Appearance.BorderColor = System.Drawing.Color.Red;
            this.btnadd.Appearance.Font = new System.Drawing.Font("Droid Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnadd.Appearance.Options.UseBackColor = true;
            this.btnadd.Appearance.Options.UseBorderColor = true;
            this.btnadd.Appearance.Options.UseFont = true;
            this.btnadd.Appearance.Options.UseForeColor = true;
            this.btnadd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.ImageOptions.Image")));
            this.btnadd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnadd.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnadd.Location = new System.Drawing.Point(12, 428);
            this.btnadd.Name = "btnadd";
            this.btnadd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnadd.Size = new System.Drawing.Size(495, 46);
            this.btnadd.TabIndex = 83;
            this.btnadd.Text = "سحب";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txteda3reason
            // 
            this.txteda3reason.Location = new System.Drawing.Point(157, 343);
            this.txteda3reason.Multiline = true;
            this.txteda3reason.Name = "txteda3reason";
            this.txteda3reason.Size = new System.Drawing.Size(358, 72);
            this.txteda3reason.TabIndex = 82;
            // 
            // txtnamemode3
            // 
            this.txtnamemode3.Location = new System.Drawing.Point(157, 294);
            this.txtnamemode3.Name = "txtnamemode3";
            this.txtnamemode3.Size = new System.Drawing.Size(358, 26);
            this.txtnamemode3.TabIndex = 81;
            this.txtnamemode3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpdate
            // 
            this.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdate.Location = new System.Drawing.Point(157, 230);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(358, 26);
            this.dtpdate.TabIndex = 80;
            // 
            // numericaddnewbalance
            // 
            this.numericaddnewbalance.DecimalPlaces = 2;
            this.numericaddnewbalance.Location = new System.Drawing.Point(157, 167);
            this.numericaddnewbalance.Maximum = new decimal(new int[] {
            -159383552,
            46653770,
            5421,
            0});
            this.numericaddnewbalance.Name = "numericaddnewbalance";
            this.numericaddnewbalance.Size = new System.Drawing.Size(358, 26);
            this.numericaddnewbalance.TabIndex = 79;
            this.numericaddnewbalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericaddnewbalance.ValueChanged += new System.EventHandler(this.numericaddnewbalance_ValueChanged);
            // 
            // lbltotal_khaznanow
            // 
            this.lbltotal_khaznanow.AutoSize = true;
            this.lbltotal_khaznanow.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal_khaznanow.Location = new System.Drawing.Point(292, 107);
            this.lbltotal_khaznanow.Name = "lbltotal_khaznanow";
            this.lbltotal_khaznanow.Size = new System.Drawing.Size(90, 28);
            this.lbltotal_khaznanow.TabIndex = 78;
            this.lbltotal_khaznanow.Text = ".............";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(181, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 31);
            this.label1.TabIndex = 77;
            this.label1.Text = "سحب رصيد من الخزنه";
            // 
            // withdrowalfromkhazna
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(519, 477);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxkhaznaname);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txteda3reason);
            this.Controls.Add(this.txtnamemode3);
            this.Controls.Add(this.dtpdate);
            this.Controls.Add(this.numericaddnewbalance);
            this.Controls.Add(this.lbltotal_khaznanow);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Droid Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "withdrowalfromkhazna";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سحب من الخزنه";
            this.Load += new System.EventHandler(this.withdrowalfromkhazna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericaddnewbalance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxkhaznaname;
        private DevExpress.XtraEditors.SimpleButton btnadd;
        private System.Windows.Forms.TextBox txteda3reason;
        private System.Windows.Forms.TextBox txtnamemode3;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.NumericUpDown numericaddnewbalance;
        private System.Windows.Forms.Label lbltotal_khaznanow;
        private System.Windows.Forms.Label label1;
    }
}
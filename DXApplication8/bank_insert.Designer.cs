namespace DXApplication8
{
    partial class bank_insert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bank_insert));
            this.cbxbankname = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnadd = new DevExpress.XtraEditors.SimpleButton();
            this.txteda3reason = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnamemode3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.numericaddnewbalance = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.lbltotal_bankbalance = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericaddnewbalance)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxbankname
            // 
            this.cbxbankname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxbankname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxbankname.BackColor = System.Drawing.Color.White;
            this.cbxbankname.ForeColor = System.Drawing.Color.Navy;
            this.cbxbankname.FormattingEnabled = true;
            this.cbxbankname.Location = new System.Drawing.Point(112, 54);
            this.cbxbankname.Name = "cbxbankname";
            this.cbxbankname.Size = new System.Drawing.Size(468, 27);
            this.cbxbankname.TabIndex = 62;
            this.cbxbankname.SelectionChangeCommitted += new System.EventHandler(this.cbxbankname_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 61;
            this.label2.Text = "اختر البنك :";
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
            this.btnadd.Location = new System.Drawing.Point(37, 403);
            this.btnadd.Name = "btnadd";
            this.btnadd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnadd.Size = new System.Drawing.Size(543, 46);
            this.btnadd.TabIndex = 60;
            this.btnadd.Text = "اضافه";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txteda3reason
            // 
            this.txteda3reason.ForeColor = System.Drawing.Color.Navy;
            this.txteda3reason.Location = new System.Drawing.Point(220, 315);
            this.txteda3reason.Multiline = true;
            this.txteda3reason.Name = "txteda3reason";
            this.txteda3reason.Size = new System.Drawing.Size(360, 72);
            this.txteda3reason.TabIndex = 59;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Droid Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 25);
            this.label8.TabIndex = 58;
            this.label8.Text = "سبب الايداع:";
            // 
            // txtnamemode3
            // 
            this.txtnamemode3.ForeColor = System.Drawing.Color.Navy;
            this.txtnamemode3.Location = new System.Drawing.Point(220, 265);
            this.txtnamemode3.Name = "txtnamemode3";
            this.txtnamemode3.Size = new System.Drawing.Size(360, 26);
            this.txtnamemode3.TabIndex = 57;
            this.txtnamemode3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Droid Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 25);
            this.label7.TabIndex = 56;
            this.label7.Text = "اسم المودع:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Droid Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 25);
            this.label6.TabIndex = 55;
            this.label6.Text = "تاريخ الايداع :";
            // 
            // dtpdate
            // 
            this.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdate.Location = new System.Drawing.Point(220, 207);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(360, 26);
            this.dtpdate.TabIndex = 54;
            // 
            // numericaddnewbalance
            // 
            this.numericaddnewbalance.DecimalPlaces = 2;
            this.numericaddnewbalance.ForeColor = System.Drawing.Color.Navy;
            this.numericaddnewbalance.Location = new System.Drawing.Point(220, 150);
            this.numericaddnewbalance.Maximum = new decimal(new int[] {
            -159383552,
            46653770,
            5421,
            0});
            this.numericaddnewbalance.Name = "numericaddnewbalance";
            this.numericaddnewbalance.Size = new System.Drawing.Size(360, 26);
            this.numericaddnewbalance.TabIndex = 53;
            this.numericaddnewbalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Droid Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 25);
            this.label5.TabIndex = 52;
            this.label5.Text = "اضافه رصيد جديد:";
            // 
            // lbltotal_bankbalance
            // 
            this.lbltotal_bankbalance.AutoSize = true;
            this.lbltotal_bankbalance.Font = new System.Drawing.Font("Droid Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal_bankbalance.Location = new System.Drawing.Point(291, 107);
            this.lbltotal_bankbalance.Name = "lbltotal_bankbalance";
            this.lbltotal_bankbalance.Size = new System.Drawing.Size(198, 25);
            this.lbltotal_bankbalance.TabIndex = 51;
            this.lbltotal_bankbalance.Text = "...............................";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 34);
            this.label3.TabIndex = 50;
            this.label3.Text = "رصيد البنك الحالي هو:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 28);
            this.label1.TabIndex = 49;
            this.label1.Text = "ايداع في البنك";
            // 
            // bank_insert
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(588, 458);
            this.Controls.Add(this.cbxbankname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txteda3reason);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtnamemode3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpdate);
            this.Controls.Add(this.numericaddnewbalance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbltotal_bankbalance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Droid Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "bank_insert";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ايداع في البنك";
            this.Load += new System.EventHandler(this.bank_insert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericaddnewbalance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxbankname;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnadd;
        private System.Windows.Forms.TextBox txteda3reason;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtnamemode3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.NumericUpDown numericaddnewbalance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbltotal_bankbalance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}
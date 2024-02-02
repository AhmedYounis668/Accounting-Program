namespace DXApplication8
{
    partial class transferefrombanktokhaznaandother
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(transferefrombanktokhaznaandother));
            this.label2 = new System.Windows.Forms.Label();
            this.btnadd = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioconvertfrom_bank_to_khazna = new System.Windows.Forms.RadioButton();
            this.radioconvertfrom_khazna_to_bank = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtnotes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtnameofmasaoul = new System.Windows.Forms.TextBox();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.numericconvertfromto = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.lbltotalbanknow = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbltotal_khaznanow = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxkhaznaname = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxbank_name = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txttransferenumber = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericconvertfromto)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(33, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 77;
            this.label2.Text = "اختر الخزنه :";
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
            this.btnadd.Location = new System.Drawing.Point(162, 468);
            this.btnadd.Name = "btnadd";
            this.btnadd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnadd.Size = new System.Drawing.Size(466, 46);
            this.btnadd.TabIndex = 76;
            this.btnadd.Text = "تحويل";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioconvertfrom_bank_to_khazna);
            this.groupBox2.Controls.Add(this.radioconvertfrom_khazna_to_bank);
            this.groupBox2.Location = new System.Drawing.Point(12, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(685, 74);
            this.groupBox2.TabIndex = 75;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "حدد العمليه";
            // 
            // radioconvertfrom_bank_to_khazna
            // 
            this.radioconvertfrom_bank_to_khazna.AutoSize = true;
            this.radioconvertfrom_bank_to_khazna.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioconvertfrom_bank_to_khazna.Location = new System.Drawing.Point(102, 33);
            this.radioconvertfrom_bank_to_khazna.Name = "radioconvertfrom_bank_to_khazna";
            this.radioconvertfrom_bank_to_khazna.Size = new System.Drawing.Size(156, 26);
            this.radioconvertfrom_bank_to_khazna.TabIndex = 1;
            this.radioconvertfrom_bank_to_khazna.TabStop = true;
            this.radioconvertfrom_bank_to_khazna.Text = "تحويل من البنك للخزنه";
            this.radioconvertfrom_bank_to_khazna.UseVisualStyleBackColor = true;
            // 
            // radioconvertfrom_khazna_to_bank
            // 
            this.radioconvertfrom_khazna_to_bank.AutoSize = true;
            this.radioconvertfrom_khazna_to_bank.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioconvertfrom_khazna_to_bank.Location = new System.Drawing.Point(469, 33);
            this.radioconvertfrom_khazna_to_bank.Name = "radioconvertfrom_khazna_to_bank";
            this.radioconvertfrom_khazna_to_bank.Size = new System.Drawing.Size(160, 26);
            this.radioconvertfrom_khazna_to_bank.TabIndex = 0;
            this.radioconvertfrom_khazna_to_bank.TabStop = true;
            this.radioconvertfrom_khazna_to_bank.Text = "تحويل من الخزنه للبنك ";
            this.radioconvertfrom_khazna_to_bank.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtnotes);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtnameofmasaoul);
            this.groupBox1.Controls.Add(this.dtpdate);
            this.groupBox1.Controls.Add(this.numericconvertfromto);
            this.groupBox1.Location = new System.Drawing.Point(139, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 193);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ادخل البيانات";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Droid Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(389, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 25);
            this.label10.TabIndex = 60;
            this.label10.Text = "Notes:";
            // 
            // txtnotes
            // 
            this.txtnotes.Location = new System.Drawing.Point(28, 127);
            this.txtnotes.Multiline = true;
            this.txtnotes.Name = "txtnotes";
            this.txtnotes.Size = new System.Drawing.Size(330, 60);
            this.txtnotes.TabIndex = 59;
            this.txtnotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Droid Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(389, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 25);
            this.label7.TabIndex = 58;
            this.label7.Text = "المسؤل عن التحويل :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Droid Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(414, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 25);
            this.label6.TabIndex = 57;
            this.label6.Text = "تاريخ التحويل :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Droid Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(389, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 25);
            this.label9.TabIndex = 56;
            this.label9.Text = "المبلغ المراد تحويله :";
            // 
            // txtnameofmasaoul
            // 
            this.txtnameofmasaoul.Location = new System.Drawing.Point(28, 95);
            this.txtnameofmasaoul.Name = "txtnameofmasaoul";
            this.txtnameofmasaoul.Size = new System.Drawing.Size(330, 26);
            this.txtnameofmasaoul.TabIndex = 53;
            this.txtnameofmasaoul.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpdate
            // 
            this.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdate.Location = new System.Drawing.Point(28, 57);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(330, 26);
            this.dtpdate.TabIndex = 50;
            // 
            // numericconvertfromto
            // 
            this.numericconvertfromto.DecimalPlaces = 2;
            this.numericconvertfromto.Location = new System.Drawing.Point(28, 25);
            this.numericconvertfromto.Maximum = new decimal(new int[] {
            -159383552,
            46653770,
            5421,
            0});
            this.numericconvertfromto.Name = "numericconvertfromto";
            this.numericconvertfromto.Size = new System.Drawing.Size(330, 26);
            this.numericconvertfromto.TabIndex = 49;
            this.numericconvertfromto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(244, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(297, 31);
            this.label5.TabIndex = 73;
            this.label5.Text = "تحويل رصيد من الخزنه للبنك والعكس";
            // 
            // lbltotalbanknow
            // 
            this.lbltotalbanknow.AutoSize = true;
            this.lbltotalbanknow.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalbanknow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbltotalbanknow.Location = new System.Drawing.Point(285, 232);
            this.lbltotalbanknow.Name = "lbltotalbanknow";
            this.lbltotalbanknow.Size = new System.Drawing.Size(90, 28);
            this.lbltotalbanknow.TabIndex = 72;
            this.lbltotalbanknow.Text = ".............";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Droid Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(29, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 34);
            this.label4.TabIndex = 71;
            this.label4.Text = "رصيد البنك الحالي هو :";
            // 
            // lbltotal_khaznanow
            // 
            this.lbltotal_khaznanow.AutoSize = true;
            this.lbltotal_khaznanow.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal_khaznanow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbltotal_khaznanow.Location = new System.Drawing.Point(285, 185);
            this.lbltotal_khaznanow.Name = "lbltotal_khaznanow";
            this.lbltotal_khaznanow.Size = new System.Drawing.Size(90, 28);
            this.lbltotal_khaznanow.TabIndex = 70;
            this.lbltotal_khaznanow.Text = ".............";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(12, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 34);
            this.label3.TabIndex = 69;
            this.label3.Text = "رصيد الخزنه الحالي هو :";
            // 
            // cbxkhaznaname
            // 
            this.cbxkhaznaname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxkhaznaname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxkhaznaname.BackColor = System.Drawing.Color.White;
            this.cbxkhaznaname.ForeColor = System.Drawing.Color.Navy;
            this.cbxkhaznaname.FormattingEnabled = true;
            this.cbxkhaznaname.Location = new System.Drawing.Point(146, 133);
            this.cbxkhaznaname.Name = "cbxkhaznaname";
            this.cbxkhaznaname.Size = new System.Drawing.Size(228, 27);
            this.cbxkhaznaname.TabIndex = 68;
            this.cbxkhaznaname.SelectionChangeCommitted += new System.EventHandler(this.cbxkhaznaname_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(415, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 79;
            this.label1.Text = "اختر البنك :";
            // 
            // cbxbank_name
            // 
            this.cbxbank_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxbank_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxbank_name.BackColor = System.Drawing.Color.White;
            this.cbxbank_name.ForeColor = System.Drawing.Color.Navy;
            this.cbxbank_name.FormattingEnabled = true;
            this.cbxbank_name.Location = new System.Drawing.Point(516, 131);
            this.cbxbank_name.Name = "cbxbank_name";
            this.cbxbank_name.Size = new System.Drawing.Size(203, 27);
            this.cbxbank_name.TabIndex = 78;
            this.cbxbank_name.SelectionChangeCommitted += new System.EventHandler(this.cbxbank_name_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(524, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 28);
            this.label8.TabIndex = 60;
            this.label8.Text = "رقم التحويل :";
            // 
            // txttransferenumber
            // 
            this.txttransferenumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txttransferenumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txttransferenumber.Location = new System.Drawing.Point(454, 232);
            this.txttransferenumber.Name = "txttransferenumber";
            this.txttransferenumber.Size = new System.Drawing.Size(265, 26);
            this.txttransferenumber.TabIndex = 59;
            this.txttransferenumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // transferefrombanktokhaznaandother
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(725, 519);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttransferenumber);
            this.Controls.Add(this.cbxbank_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbltotalbanknow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbltotal_khaznanow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxkhaznaname);
            this.Font = new System.Drawing.Font("Droid Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "transferefrombanktokhaznaandother";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تحويل من البنك الي الخزنه والعكس";
            this.Load += new System.EventHandler(this.transferefrombanktokhaznaandother_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericconvertfromto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnadd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioconvertfrom_bank_to_khazna;
        private System.Windows.Forms.RadioButton radioconvertfrom_khazna_to_bank;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtnameofmasaoul;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.NumericUpDown numericconvertfromto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbltotalbanknow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbltotal_khaznanow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxkhaznaname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxbank_name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttransferenumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtnotes;
    }
}
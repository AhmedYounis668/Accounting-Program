﻿namespace DXApplication8
{
    partial class employeeabsentsanddiscount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employeeabsentsanddiscount));
            this.numericnumberofdays = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtorder_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxemloyeename = new System.Windows.Forms.ComboBox();
            this.btnsave = new DevExpress.XtraEditors.SimpleButton();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radiobadl_entekal = new System.Windows.Forms.RadioButton();
            this.radiohafez = new System.Windows.Forms.RadioButton();
            this.radiokhasmmaly = new System.Windows.Forms.RadioButton();
            this.radioovertime = new System.Windows.Forms.RadioButton();
            this.radioabsents = new System.Windows.Forms.RadioButton();
            this.radiokhasm = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lblovertime = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnotes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericnumberofdays)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericnumberofdays
            // 
            this.numericnumberofdays.DecimalPlaces = 2;
            this.numericnumberofdays.ForeColor = System.Drawing.Color.Navy;
            this.numericnumberofdays.Location = new System.Drawing.Point(183, 202);
            this.numericnumberofdays.Maximum = new decimal(new int[] {
            -469762048,
            -590869294,
            5421010,
            0});
            this.numericnumberofdays.Name = "numericnumberofdays";
            this.numericnumberofdays.Size = new System.Drawing.Size(232, 26);
            this.numericnumberofdays.TabIndex = 113;
            this.numericnumberofdays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(45, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 112;
            this.label1.Text = "رقم العمليه";
            // 
            // txtorder_id
            // 
            this.txtorder_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtorder_id.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtorder_id.ForeColor = System.Drawing.Color.Navy;
            this.txtorder_id.Location = new System.Drawing.Point(148, 12);
            this.txtorder_id.Name = "txtorder_id";
            this.txtorder_id.ReadOnly = true;
            this.txtorder_id.Size = new System.Drawing.Size(523, 28);
            this.txtorder_id.TabIndex = 111;
            this.txtorder_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(92, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 110;
            this.label2.Text = "اختر موظف :";
            // 
            // cbxemloyeename
            // 
            this.cbxemloyeename.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxemloyeename.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxemloyeename.ForeColor = System.Drawing.Color.Navy;
            this.cbxemloyeename.FormattingEnabled = true;
            this.cbxemloyeename.Location = new System.Drawing.Point(183, 159);
            this.cbxemloyeename.Name = "cbxemloyeename";
            this.cbxemloyeename.Size = new System.Drawing.Size(232, 27);
            this.cbxemloyeename.TabIndex = 109;
            // 
            // btnsave
            // 
            this.btnsave.Appearance.BackColor = System.Drawing.Color.Red;
            this.btnsave.Appearance.BackColor2 = System.Drawing.Color.Red;
            this.btnsave.Appearance.BorderColor = System.Drawing.Color.Red;
            this.btnsave.Appearance.Font = new System.Drawing.Font("Droid Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnsave.Appearance.Options.UseBackColor = true;
            this.btnsave.Appearance.Options.UseBorderColor = true;
            this.btnsave.Appearance.Options.UseFont = true;
            this.btnsave.Appearance.Options.UseForeColor = true;
            this.btnsave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnsave.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnsave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnsave.ImageOptions.SvgImage")));
            this.btnsave.Location = new System.Drawing.Point(108, 249);
            this.btnsave.Name = "btnsave";
            this.btnsave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnsave.Size = new System.Drawing.Size(653, 46);
            this.btnsave.TabIndex = 108;
            this.btnsave.Text = "تنفيذ العمليه";
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // dtpdate
            // 
            this.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdate.Location = new System.Drawing.Point(148, 39);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(523, 26);
            this.dtpdate.TabIndex = 107;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radiobadl_entekal);
            this.groupBox1.Controls.Add(this.radiohafez);
            this.groupBox1.Controls.Add(this.radiokhasmmaly);
            this.groupBox1.Controls.Add(this.radioovertime);
            this.groupBox1.Controls.Add(this.radioabsents);
            this.groupBox1.Controls.Add(this.radiokhasm);
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(840, 74);
            this.groupBox1.TabIndex = 106;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اختر عمليه";
            // 
            // radiobadl_entekal
            // 
            this.radiobadl_entekal.AutoSize = true;
            this.radiobadl_entekal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.radiobadl_entekal.Location = new System.Drawing.Point(6, 30);
            this.radiobadl_entekal.Name = "radiobadl_entekal";
            this.radiobadl_entekal.Size = new System.Drawing.Size(86, 23);
            this.radiobadl_entekal.TabIndex = 5;
            this.radiobadl_entekal.TabStop = true;
            this.radiobadl_entekal.Text = "بدل انتقالات";
            this.radiobadl_entekal.UseVisualStyleBackColor = true;
            this.radiobadl_entekal.CheckedChanged += new System.EventHandler(this.radiobadl_entekal_CheckedChanged);
            // 
            // radiohafez
            // 
            this.radiohafez.AutoSize = true;
            this.radiohafez.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.radiohafez.Location = new System.Drawing.Point(167, 30);
            this.radiohafez.Name = "radiohafez";
            this.radiohafez.Size = new System.Drawing.Size(50, 23);
            this.radiohafez.TabIndex = 4;
            this.radiohafez.TabStop = true;
            this.radiohafez.Text = "حافز";
            this.radiohafez.UseVisualStyleBackColor = true;
            this.radiohafez.CheckedChanged += new System.EventHandler(this.radiohafez_CheckedChanged);
            // 
            // radiokhasmmaly
            // 
            this.radiokhasmmaly.AutoSize = true;
            this.radiokhasmmaly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radiokhasmmaly.Location = new System.Drawing.Point(290, 31);
            this.radiokhasmmaly.Name = "radiokhasmmaly";
            this.radiokhasmmaly.Size = new System.Drawing.Size(77, 23);
            this.radiokhasmmaly.TabIndex = 3;
            this.radiokhasmmaly.TabStop = true;
            this.radiokhasmmaly.Text = "خصم مالي";
            this.radiokhasmmaly.UseVisualStyleBackColor = true;
            this.radiokhasmmaly.CheckedChanged += new System.EventHandler(this.radiokhasmmaly_CheckedChanged);
            // 
            // radioovertime
            // 
            this.radioovertime.AutoSize = true;
            this.radioovertime.ForeColor = System.Drawing.Color.Navy;
            this.radioovertime.Location = new System.Drawing.Point(444, 30);
            this.radioovertime.Name = "radioovertime";
            this.radioovertime.Size = new System.Drawing.Size(82, 23);
            this.radioovertime.TabIndex = 2;
            this.radioovertime.TabStop = true;
            this.radioovertime.Text = "وقت اضافي";
            this.radioovertime.UseVisualStyleBackColor = true;
            this.radioovertime.CheckedChanged += new System.EventHandler(this.radioovertime_CheckedChanged);
            // 
            // radioabsents
            // 
            this.radioabsents.AutoSize = true;
            this.radioabsents.ForeColor = System.Drawing.Color.Navy;
            this.radioabsents.Location = new System.Drawing.Point(593, 30);
            this.radioabsents.Name = "radioabsents";
            this.radioabsents.Size = new System.Drawing.Size(61, 23);
            this.radioabsents.TabIndex = 1;
            this.radioabsents.TabStop = true;
            this.radioabsents.Text = "غيابات";
            this.radioabsents.UseVisualStyleBackColor = true;
            this.radioabsents.CheckedChanged += new System.EventHandler(this.radioabsents_CheckedChanged);
            // 
            // radiokhasm
            // 
            this.radiokhasm.AutoSize = true;
            this.radiokhasm.ForeColor = System.Drawing.Color.Navy;
            this.radiokhasm.Location = new System.Drawing.Point(726, 30);
            this.radiokhasm.Name = "radiokhasm";
            this.radiokhasm.Size = new System.Drawing.Size(72, 23);
            this.radiokhasm.TabIndex = 0;
            this.radiokhasm.TabStop = true;
            this.radiokhasm.Text = "خصومات";
            this.radiokhasm.UseVisualStyleBackColor = true;
            this.radiokhasm.CheckedChanged += new System.EventHandler(this.radiokhasm_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(51, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 21);
            this.label3.TabIndex = 114;
            this.label3.Text = "التاريخ:";
            // 
            // lblovertime
            // 
            this.lblovertime.AutoSize = true;
            this.lblovertime.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblovertime.ForeColor = System.Drawing.Color.Navy;
            this.lblovertime.Location = new System.Drawing.Point(123, 205);
            this.lblovertime.Name = "lblovertime";
            this.lblovertime.Size = new System.Drawing.Size(49, 21);
            this.lblovertime.TabIndex = 115;
            this.lblovertime.Text = "المبلغ :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(481, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 23);
            this.label7.TabIndex = 117;
            this.label7.Text = "Notes:";
            // 
            // txtnotes
            // 
            this.txtnotes.ForeColor = System.Drawing.Color.Navy;
            this.txtnotes.Location = new System.Drawing.Point(552, 146);
            this.txtnotes.Multiline = true;
            this.txtnotes.Name = "txtnotes";
            this.txtnotes.Size = new System.Drawing.Size(347, 85);
            this.txtnotes.TabIndex = 116;
            this.txtnotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // employeeabsentsanddiscount
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(920, 296);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtnotes);
            this.Controls.Add(this.lblovertime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericnumberofdays);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtorder_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxemloyeename);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.dtpdate);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Droid Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "employeeabsentsanddiscount";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "خصومات وغيابات وحوافز الموظفين";
            this.Load += new System.EventHandler(this.employeeabsentsanddiscount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericnumberofdays)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericnumberofdays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtorder_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxemloyeename;
        private DevExpress.XtraEditors.SimpleButton btnsave;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radiobadl_entekal;
        private System.Windows.Forms.RadioButton radiohafez;
        private System.Windows.Forms.RadioButton radiokhasmmaly;
        private System.Windows.Forms.RadioButton radioovertime;
        private System.Windows.Forms.RadioButton radioabsents;
        private System.Windows.Forms.RadioButton radiokhasm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblovertime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnotes;
    }
}
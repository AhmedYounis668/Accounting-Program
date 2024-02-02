namespace DXApplication8
{
    partial class employee_accounts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employee_accounts));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radiofatra = new System.Windows.Forms.RadioButton();
            this.dtpfrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpto = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnsandat_deleted = new DevExpress.XtraEditors.SimpleButton();
            this.btndeleteselectedsadad = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnprint = new DevExpress.XtraEditors.SimpleButton();
            this.radiosupname = new System.Windows.Forms.RadioButton();
            this.txt_write_emp = new System.Windows.Forms.TextBox();
            this.btnsearch = new DevExpress.XtraEditors.SimpleButton();
            this.radioempselection = new System.Windows.Forms.RadioButton();
            this.radioallemp = new System.Windows.Forms.RadioButton();
            this.cbxemployee = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtborrowmoney = new System.Windows.Forms.TextBox();
            this.btnsarfsalary = new DevExpress.XtraEditors.SimpleButton();
            this.numircprice = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpkabddate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numircprice)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Location = new System.Drawing.Point(12, 221);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1256, 329);
            this.dgv.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AccessibleDescription = "v";
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(886, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 30);
            this.label2.TabIndex = 57;
            this.label2.Text = "الاجمالي النهائي :";
            // 
            // txttotal
            // 
            this.txttotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txttotal.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.ForeColor = System.Drawing.Color.Navy;
            this.txttotal.Location = new System.Drawing.Point(1043, 173);
            this.txttotal.Multiline = true;
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(223, 45);
            this.txttotal.TabIndex = 54;
            this.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AccessibleDescription = "v";
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(524, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 30);
            this.label1.TabIndex = 56;
            this.label1.Text = "حسابات الموظفين";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radiofatra);
            this.groupBox1.Controls.Add(this.dtpfrom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnsandat_deleted);
            this.groupBox1.Controls.Add(this.btndeleteselectedsadad);
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.btnprint);
            this.groupBox1.Controls.Add(this.radiosupname);
            this.groupBox1.Controls.Add(this.txt_write_emp);
            this.groupBox1.Controls.Add(this.btnsearch);
            this.groupBox1.Controls.Add(this.radioempselection);
            this.groupBox1.Controls.Add(this.radioallemp);
            this.groupBox1.Controls.Add(this.cbxemployee);
            this.groupBox1.Location = new System.Drawing.Point(-101, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1367, 133);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بحث عام";
            // 
            // radiofatra
            // 
            this.radiofatra.AutoSize = true;
            this.radiofatra.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiofatra.ForeColor = System.Drawing.Color.Navy;
            this.radiofatra.Location = new System.Drawing.Point(1114, 83);
            this.radiofatra.Name = "radiofatra";
            this.radiofatra.Size = new System.Drawing.Size(147, 25);
            this.radiofatra.TabIndex = 129;
            this.radiofatra.TabStop = true;
            this.radiofatra.Text = "بحث في فتره محدده :";
            this.radiofatra.UseVisualStyleBackColor = true;
            // 
            // dtpfrom
            // 
            this.dtpfrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfrom.Location = new System.Drawing.Point(944, 83);
            this.dtpfrom.Name = "dtpfrom";
            this.dtpfrom.Size = new System.Drawing.Size(124, 28);
            this.dtpfrom.TabIndex = 128;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(1074, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 25);
            this.label3.TabIndex = 127;
            this.label3.Text = "من :";
            // 
            // dtpto
            // 
            this.dtpto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpto.Location = new System.Drawing.Point(759, 84);
            this.dtpto.Name = "dtpto";
            this.dtpto.Size = new System.Drawing.Size(120, 28);
            this.dtpto.TabIndex = 126;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(887, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 25);
            this.label6.TabIndex = 125;
            this.label6.Text = "الي :";
            // 
            // btnsandat_deleted
            // 
            this.btnsandat_deleted.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsandat_deleted.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnsandat_deleted.Appearance.Options.UseFont = true;
            this.btnsandat_deleted.Appearance.Options.UseForeColor = true;
            this.btnsandat_deleted.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btnsandat_deleted.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnsandat_deleted.ImageOptions.SvgImage")));
            this.btnsandat_deleted.Location = new System.Drawing.Point(229, 18);
            this.btnsandat_deleted.Name = "btnsandat_deleted";
            this.btnsandat_deleted.Size = new System.Drawing.Size(138, 47);
            this.btnsandat_deleted.TabIndex = 17;
            this.btnsandat_deleted.Text = "سندات محذوفه";
            // 
            // btndeleteselectedsadad
            // 
            this.btndeleteselectedsadad.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeleteselectedsadad.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.btndeleteselectedsadad.Appearance.Options.UseFont = true;
            this.btndeleteselectedsadad.Appearance.Options.UseForeColor = true;
            this.btndeleteselectedsadad.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btndeleteselectedsadad.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btndeleteselectedsadad.ImageOptions.SvgImage")));
            this.btndeleteselectedsadad.Location = new System.Drawing.Point(293, 73);
            this.btndeleteselectedsadad.Name = "btndeleteselectedsadad";
            this.btndeleteselectedsadad.Size = new System.Drawing.Size(176, 47);
            this.btndeleteselectedsadad.TabIndex = 13;
            this.btndeleteselectedsadad.Text = "مسح سداد محدد";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(6, 18);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(217, 47);
            this.simpleButton1.TabIndex = 15;
            this.simpleButton1.Text = "Export Data To Excell";
            // 
            // btnprint
            // 
            this.btnprint.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.btnprint.Appearance.Options.UseFont = true;
            this.btnprint.Appearance.Options.UseForeColor = true;
            this.btnprint.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btnprint.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnprint.ImageOptions.SvgImage")));
            this.btnprint.Location = new System.Drawing.Point(475, 71);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(153, 49);
            this.btnprint.TabIndex = 10;
            this.btnprint.Text = "طباعه تقرير";
            // 
            // radiosupname
            // 
            this.radiosupname.AutoSize = true;
            this.radiosupname.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiosupname.ForeColor = System.Drawing.Color.Navy;
            this.radiosupname.Location = new System.Drawing.Point(1061, 52);
            this.radiosupname.Name = "radiosupname";
            this.radiosupname.Size = new System.Drawing.Size(197, 25);
            this.radiosupname.TabIndex = 12;
            this.radiosupname.TabStop = true;
            this.radiosupname.Text = "اكتب اسم الموظف او جزء منه :";
            this.radiosupname.UseVisualStyleBackColor = true;
            // 
            // txt_write_emp
            // 
            this.txt_write_emp.BackColor = System.Drawing.Color.White;
            this.txt_write_emp.ForeColor = System.Drawing.Color.Navy;
            this.txt_write_emp.Location = new System.Drawing.Point(635, 51);
            this.txt_write_emp.Name = "txt_write_emp";
            this.txt_write_emp.Size = new System.Drawing.Size(420, 28);
            this.txt_write_emp.TabIndex = 11;
            this.txt_write_emp.TextChanged += new System.EventHandler(this.txt_write_emp_TextChanged);
            // 
            // btnsearch
            // 
            this.btnsearch.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.btnsearch.Appearance.Options.UseFont = true;
            this.btnsearch.Appearance.Options.UseForeColor = true;
            this.btnsearch.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btnsearch.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnsearch.ImageOptions.SvgImage")));
            this.btnsearch.Location = new System.Drawing.Point(373, 18);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(255, 47);
            this.btnsearch.TabIndex = 1;
            this.btnsearch.Text = "بحث";
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // radioempselection
            // 
            this.radioempselection.AutoSize = true;
            this.radioempselection.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioempselection.ForeColor = System.Drawing.Color.Navy;
            this.radioempselection.Location = new System.Drawing.Point(1005, 19);
            this.radioempselection.Name = "radioempselection";
            this.radioempselection.Size = new System.Drawing.Size(96, 25);
            this.radioempselection.TabIndex = 3;
            this.radioempselection.TabStop = true;
            this.radioempselection.Text = "موظف محدد";
            this.radioempselection.UseVisualStyleBackColor = true;
            // 
            // radioallemp
            // 
            this.radioallemp.AutoSize = true;
            this.radioallemp.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioallemp.ForeColor = System.Drawing.Color.Navy;
            this.radioallemp.Location = new System.Drawing.Point(1153, 22);
            this.radioallemp.Name = "radioallemp";
            this.radioallemp.Size = new System.Drawing.Size(101, 25);
            this.radioallemp.TabIndex = 2;
            this.radioallemp.TabStop = true;
            this.radioallemp.Text = "كل الموظفين";
            this.radioallemp.UseVisualStyleBackColor = true;
            // 
            // cbxemployee
            // 
            this.cbxemployee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxemployee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxemployee.BackColor = System.Drawing.Color.White;
            this.cbxemployee.ForeColor = System.Drawing.Color.Navy;
            this.cbxemployee.FormattingEnabled = true;
            this.cbxemployee.Location = new System.Drawing.Point(635, 18);
            this.cbxemployee.Name = "cbxemployee";
            this.cbxemployee.Size = new System.Drawing.Size(340, 29);
            this.cbxemployee.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AccessibleDescription = "v";
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(11, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 30);
            this.label4.TabIndex = 59;
            this.label4.Text = "المرتب :";
            // 
            // txtsalary
            // 
            this.txtsalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtsalary.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalary.ForeColor = System.Drawing.Color.Navy;
            this.txtsalary.Location = new System.Drawing.Point(99, 173);
            this.txtsalary.Multiline = true;
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.ReadOnly = true;
            this.txtsalary.Size = new System.Drawing.Size(223, 45);
            this.txtsalary.TabIndex = 58;
            this.txtsalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AccessibleDescription = "v";
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(378, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 30);
            this.label5.TabIndex = 61;
            this.label5.Text = "اجمالي السلفيات";
            // 
            // txtborrowmoney
            // 
            this.txtborrowmoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtborrowmoney.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtborrowmoney.ForeColor = System.Drawing.Color.Navy;
            this.txtborrowmoney.Location = new System.Drawing.Point(524, 174);
            this.txtborrowmoney.Multiline = true;
            this.txtborrowmoney.Name = "txtborrowmoney";
            this.txtborrowmoney.ReadOnly = true;
            this.txtborrowmoney.Size = new System.Drawing.Size(223, 45);
            this.txtborrowmoney.TabIndex = 60;
            this.txtborrowmoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnsarfsalary
            // 
            this.btnsarfsalary.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsarfsalary.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.btnsarfsalary.Appearance.Options.UseFont = true;
            this.btnsarfsalary.Appearance.Options.UseForeColor = true;
            this.btnsarfsalary.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsarfsalary.ImageOptions.Image")));
            this.btnsarfsalary.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btnsarfsalary.Location = new System.Drawing.Point(685, 556);
            this.btnsarfsalary.Name = "btnsarfsalary";
            this.btnsarfsalary.Size = new System.Drawing.Size(252, 47);
            this.btnsarfsalary.TabIndex = 130;
            this.btnsarfsalary.Text = "صرف مرتبات";
            this.btnsarfsalary.Click += new System.EventHandler(this.btnsarfsalary_Click);
            // 
            // numircprice
            // 
            this.numircprice.DecimalPlaces = 2;
            this.numircprice.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numircprice.Location = new System.Drawing.Point(114, 566);
            this.numircprice.Maximum = new decimal(new int[] {
            -402653184,
            -1613725636,
            54210108,
            0});
            this.numircprice.Name = "numircprice";
            this.numircprice.Size = new System.Drawing.Size(248, 28);
            this.numircprice.TabIndex = 131;
            this.numircprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(8, 569);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 23);
            this.label13.TabIndex = 132;
            this.label13.Text = "ادخل المبلغ هنا :";
            // 
            // dtpkabddate
            // 
            this.dtpkabddate.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkabddate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkabddate.Location = new System.Drawing.Point(476, 566);
            this.dtpkabddate.Name = "dtpkabddate";
            this.dtpkabddate.Size = new System.Drawing.Size(203, 28);
            this.dtpkabddate.TabIndex = 130;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(378, 566);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 23);
            this.label7.TabIndex = 130;
            this.label7.Text = "تاريخ القبض :";
            // 
            // employee_accounts
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1269, 607);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpkabddate);
            this.Controls.Add(this.btnsarfsalary);
            this.Controls.Add(this.numircprice);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtborrowmoney);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsalary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "employee_accounts";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حسابات الموظفين";
            this.Load += new System.EventHandler(this.employee_accounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numircprice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radiofatra;
        private System.Windows.Forms.DateTimePicker dtpfrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpto;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton btnsandat_deleted;
        private DevExpress.XtraEditors.SimpleButton btndeleteselectedsadad;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnprint;
        private System.Windows.Forms.RadioButton radiosupname;
        private System.Windows.Forms.TextBox txt_write_emp;
        private DevExpress.XtraEditors.SimpleButton btnsearch;
        private System.Windows.Forms.RadioButton radioempselection;
        private System.Windows.Forms.RadioButton radioallemp;
        private System.Windows.Forms.ComboBox cbxemployee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtborrowmoney;
        private DevExpress.XtraEditors.SimpleButton btnsarfsalary;
        private System.Windows.Forms.NumericUpDown numircprice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpkabddate;
        private System.Windows.Forms.Label label7;
    }
}
namespace DXApplication8
{
    partial class expenses_report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(expenses_report));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnallexpensesinbranchopennow = new DevExpress.XtraEditors.SimpleButton();
            this.cbxbranches = new System.Windows.Forms.ComboBox();
            this.radioselectedexpensesbranches = new System.Windows.Forms.RadioButton();
            this.radioallexpensesbranches = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpto = new System.Windows.Forms.DateTimePicker();
            this.dtpfrom = new System.Windows.Forms.DateTimePicker();
            this.txtsearchoftype = new System.Windows.Forms.TextBox();
            this.btnsearch = new DevExpress.XtraEditors.SimpleButton();
            this.radiopartoftyepeexpenses = new System.Windows.Forms.RadioButton();
            this.dgvsearchfortypes = new System.Windows.Forms.DataGridView();
            this.cbxtypes = new System.Windows.Forms.ComboBox();
            this.radiotypeselected = new System.Windows.Forms.RadioButton();
            this.radioallexpenses = new System.Windows.Forms.RadioButton();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsearchfortypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.btnallexpensesinbranchopennow);
            this.groupBox1.Controls.Add(this.cbxbranches);
            this.groupBox1.Controls.Add(this.radioselectedexpensesbranches);
            this.groupBox1.Controls.Add(this.radioallexpensesbranches);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtsearchoftype);
            this.groupBox1.Controls.Add(this.btnsearch);
            this.groupBox1.Controls.Add(this.radiopartoftyepeexpenses);
            this.groupBox1.Controls.Add(this.dgvsearchfortypes);
            this.groupBox1.Controls.Add(this.cbxtypes);
            this.groupBox1.Controls.Add(this.radiotypeselected);
            this.groupBox1.Controls.Add(this.radioallexpenses);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1281, 213);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(416, 40);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.simpleButton1.Size = new System.Drawing.Size(271, 32);
            this.simpleButton1.TabIndex = 74;
            this.simpleButton1.Text = "مصروفات نوع محدد في الفرع المفتوح الان";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnallexpensesinbranchopennow
            // 
            this.btnallexpensesinbranchopennow.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnallexpensesinbranchopennow.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnallexpensesinbranchopennow.Appearance.Options.UseFont = true;
            this.btnallexpensesinbranchopennow.Appearance.Options.UseForeColor = true;
            this.btnallexpensesinbranchopennow.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnallexpensesinbranchopennow.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnallexpensesinbranchopennow.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnallexpensesinbranchopennow.ImageOptions.SvgImage")));
            this.btnallexpensesinbranchopennow.Location = new System.Drawing.Point(693, 40);
            this.btnallexpensesinbranchopennow.Name = "btnallexpensesinbranchopennow";
            this.btnallexpensesinbranchopennow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnallexpensesinbranchopennow.Size = new System.Drawing.Size(240, 32);
            this.btnallexpensesinbranchopennow.TabIndex = 73;
            this.btnallexpensesinbranchopennow.Text = "كل المصروفات في الفرع المفتوح الان";
            this.btnallexpensesinbranchopennow.Click += new System.EventHandler(this.btnallexpensesinbranchopennow_Click);
            // 
            // cbxbranches
            // 
            this.cbxbranches.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxbranches.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxbranches.BackColor = System.Drawing.Color.White;
            this.cbxbranches.ForeColor = System.Drawing.Color.Navy;
            this.cbxbranches.FormattingEnabled = true;
            this.cbxbranches.Location = new System.Drawing.Point(442, 9);
            this.cbxbranches.Name = "cbxbranches";
            this.cbxbranches.Size = new System.Drawing.Size(148, 27);
            this.cbxbranches.TabIndex = 70;
            // 
            // radioselectedexpensesbranches
            // 
            this.radioselectedexpensesbranches.AutoSize = true;
            this.radioselectedexpensesbranches.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioselectedexpensesbranches.Location = new System.Drawing.Point(598, 11);
            this.radioselectedexpensesbranches.Name = "radioselectedexpensesbranches";
            this.radioselectedexpensesbranches.Size = new System.Drawing.Size(133, 25);
            this.radioselectedexpensesbranches.TabIndex = 69;
            this.radioselectedexpensesbranches.TabStop = true;
            this.radioselectedexpensesbranches.Text = "مصروفات فرع محدد";
            this.radioselectedexpensesbranches.UseVisualStyleBackColor = true;
            // 
            // radioallexpensesbranches
            // 
            this.radioallexpensesbranches.AutoSize = true;
            this.radioallexpensesbranches.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioallexpensesbranches.Location = new System.Drawing.Point(743, 10);
            this.radioallexpensesbranches.Name = "radioallexpensesbranches";
            this.radioallexpensesbranches.Size = new System.Drawing.Size(136, 25);
            this.radioallexpensesbranches.TabIndex = 68;
            this.radioallexpensesbranches.TabStop = true;
            this.radioallexpensesbranches.Text = "مصروفات كل الفروع";
            this.radioallexpensesbranches.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtpto);
            this.groupBox2.Controls.Add(this.dtpfrom);
            this.groupBox2.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(66, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 54);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "حدد التاريخ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(160, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "الي";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(328, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "من";
            // 
            // dtpto
            // 
            this.dtpto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpto.Location = new System.Drawing.Point(7, 22);
            this.dtpto.Name = "dtpto";
            this.dtpto.Size = new System.Drawing.Size(148, 28);
            this.dtpto.TabIndex = 10;
            // 
            // dtpfrom
            // 
            this.dtpfrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfrom.Location = new System.Drawing.Point(186, 22);
            this.dtpfrom.Name = "dtpfrom";
            this.dtpfrom.Size = new System.Drawing.Size(139, 28);
            this.dtpfrom.TabIndex = 9;
            // 
            // txtsearchoftype
            // 
            this.txtsearchoftype.BackColor = System.Drawing.Color.White;
            this.txtsearchoftype.ForeColor = System.Drawing.Color.Navy;
            this.txtsearchoftype.Location = new System.Drawing.Point(939, 46);
            this.txtsearchoftype.Name = "txtsearchoftype";
            this.txtsearchoftype.Size = new System.Drawing.Size(186, 26);
            this.txtsearchoftype.TabIndex = 8;
            this.txtsearchoftype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtsearchoftype.TextChanged += new System.EventHandler(this.txtsearchoftype_TextChanged);
            // 
            // btnsearch
            // 
            this.btnsearch.Appearance.Font = new System.Drawing.Font("Droid Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnsearch.Appearance.Options.UseFont = true;
            this.btnsearch.Appearance.Options.UseForeColor = true;
            this.btnsearch.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnsearch.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnsearch.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnsearch.ImageOptions.SvgImage")));
            this.btnsearch.Location = new System.Drawing.Point(-13, 15);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnsearch.Size = new System.Drawing.Size(74, 55);
            this.btnsearch.TabIndex = 3;
            this.btnsearch.Text = "بحث ";
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // radiopartoftyepeexpenses
            // 
            this.radiopartoftyepeexpenses.AutoSize = true;
            this.radiopartoftyepeexpenses.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiopartoftyepeexpenses.Location = new System.Drawing.Point(1127, 48);
            this.radiopartoftyepeexpenses.Name = "radiopartoftyepeexpenses";
            this.radiopartoftyepeexpenses.Size = new System.Drawing.Size(143, 25);
            this.radiopartoftyepeexpenses.TabIndex = 9;
            this.radiopartoftyepeexpenses.TabStop = true;
            this.radiopartoftyepeexpenses.Text = "اكتب اسم المصروف :";
            this.radiopartoftyepeexpenses.UseVisualStyleBackColor = true;
            // 
            // dgvsearchfortypes
            // 
            this.dgvsearchfortypes.AllowUserToAddRows = false;
            this.dgvsearchfortypes.AllowUserToDeleteRows = false;
            this.dgvsearchfortypes.AllowUserToResizeColumns = false;
            this.dgvsearchfortypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvsearchfortypes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvsearchfortypes.BackgroundColor = System.Drawing.Color.White;
            this.dgvsearchfortypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Droid Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvsearchfortypes.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvsearchfortypes.GridColor = System.Drawing.Color.Navy;
            this.dgvsearchfortypes.Location = new System.Drawing.Point(6, 82);
            this.dgvsearchfortypes.Name = "dgvsearchfortypes";
            this.dgvsearchfortypes.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Droid Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvsearchfortypes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvsearchfortypes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvsearchfortypes.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Navy;
            this.dgvsearchfortypes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dgvsearchfortypes.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Navy;
            this.dgvsearchfortypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvsearchfortypes.Size = new System.Drawing.Size(1269, 128);
            this.dgvsearchfortypes.TabIndex = 48;
            // 
            // cbxtypes
            // 
            this.cbxtypes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxtypes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxtypes.BackColor = System.Drawing.Color.White;
            this.cbxtypes.ForeColor = System.Drawing.Color.Navy;
            this.cbxtypes.FormattingEnabled = true;
            this.cbxtypes.Location = new System.Drawing.Point(888, 11);
            this.cbxtypes.Name = "cbxtypes";
            this.cbxtypes.Size = new System.Drawing.Size(166, 27);
            this.cbxtypes.TabIndex = 2;
            // 
            // radiotypeselected
            // 
            this.radiotypeselected.AutoSize = true;
            this.radiotypeselected.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiotypeselected.Location = new System.Drawing.Point(1068, 15);
            this.radiotypeselected.Name = "radiotypeselected";
            this.radiotypeselected.Size = new System.Drawing.Size(78, 25);
            this.radiotypeselected.TabIndex = 1;
            this.radiotypeselected.TabStop = true;
            this.radiotypeselected.Text = "نوع محدد";
            this.radiotypeselected.UseVisualStyleBackColor = true;
            // 
            // radioallexpenses
            // 
            this.radioallexpenses.AutoSize = true;
            this.radioallexpenses.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioallexpenses.Location = new System.Drawing.Point(1162, 15);
            this.radioallexpenses.Name = "radioallexpenses";
            this.radioallexpenses.Size = new System.Drawing.Size(106, 25);
            this.radioallexpenses.TabIndex = 0;
            this.radioallexpenses.TabStop = true;
            this.radioallexpenses.Text = "كل المصروفات";
            this.radioallexpenses.UseVisualStyleBackColor = true;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Droid Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.GridColor = System.Drawing.Color.Navy;
            this.dgv.Location = new System.Drawing.Point(12, 259);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Droid Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Navy;
            this.dgv.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dgv.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Navy;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1266, 289);
            this.dgv.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 72;
            this.label1.Text = "الاجمالي :";
            // 
            // txttotal
            // 
            this.txttotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txttotal.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.ForeColor = System.Drawing.Color.Navy;
            this.txttotal.Location = new System.Drawing.Point(76, 219);
            this.txttotal.Multiline = true;
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(1202, 34);
            this.txttotal.TabIndex = 71;
            // 
            // expenses_report
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1290, 552);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Droid Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "expenses_report";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقارير المصروفات";
            this.Load += new System.EventHandler(this.expenses_report_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsearchfortypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtsearchoftype;
        private DevExpress.XtraEditors.SimpleButton btnsearch;
        private System.Windows.Forms.RadioButton radiopartoftyepeexpenses;
        private System.Windows.Forms.DataGridView dgvsearchfortypes;
        private System.Windows.Forms.ComboBox cbxtypes;
        private System.Windows.Forms.RadioButton radiotypeselected;
        private System.Windows.Forms.RadioButton radioallexpenses;
        private System.Windows.Forms.ComboBox cbxbranches;
        private System.Windows.Forms.RadioButton radioselectedexpensesbranches;
        private System.Windows.Forms.RadioButton radioallexpensesbranches;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpto;
        private System.Windows.Forms.DateTimePicker dtpfrom;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttotal;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnallexpensesinbranchopennow;
    }
}
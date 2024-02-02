namespace DXApplication8
{
    partial class customer_accounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customer_accounts));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnsearchbranchses = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.radiofatra = new System.Windows.Forms.RadioButton();
            this.dtpfrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpto = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnsandat_deleted = new DevExpress.XtraEditors.SimpleButton();
            this.btndeleteoldmoney = new DevExpress.XtraEditors.SimpleButton();
            this.btndeleteselectedsadad = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnprint = new DevExpress.XtraEditors.SimpleButton();
            this.radiocustname = new System.Windows.Forms.RadioButton();
            this.txt_write_customer = new System.Windows.Forms.TextBox();
            this.btnsearch = new DevExpress.XtraEditors.SimpleButton();
            this.radioselectone = new System.Windows.Forms.RadioButton();
            this.radiocustomerall = new System.Windows.Forms.RadioButton();
            this.cbxcustomer = new System.Windows.Forms.ComboBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsearchbranchses
            // 
            this.btnsearchbranchses.Appearance.Font = new System.Drawing.Font("Droid Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearchbranchses.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnsearchbranchses.Appearance.Options.UseFont = true;
            this.btnsearchbranchses.Appearance.Options.UseForeColor = true;
            this.btnsearchbranchses.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsearchbranchses.ImageOptions.Image")));
            this.btnsearchbranchses.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnsearchbranchses.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnsearchbranchses.Location = new System.Drawing.Point(5, 3);
            this.btnsearchbranchses.Name = "btnsearchbranchses";
            this.btnsearchbranchses.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnsearchbranchses.Size = new System.Drawing.Size(81, 217);
            this.btnsearchbranchses.TabIndex = 11;
            this.btnsearchbranchses.Text = "Exit";
            this.btnsearchbranchses.Click += new System.EventHandler(this.btnsearchbranchses_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv1);
            this.panel1.Controls.Add(this.btnsearchbranchses);
            this.panel1.Location = new System.Drawing.Point(2, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1348, 219);
            this.panel1.TabIndex = 54;
            this.panel1.Visible = false;
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.AllowUserToResizeColumns = false;
            this.dgv1.AllowUserToResizeRows = false;
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv1.BackgroundColor = System.Drawing.Color.White;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Droid Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv1.Location = new System.Drawing.Point(92, 3);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(1251, 210);
            this.dgv1.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AccessibleDescription = "v";
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(-4, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 30);
            this.label2.TabIndex = 53;
            this.label2.Text = "الاجمالي النهائي :";
            // 
            // radiofatra
            // 
            this.radiofatra.AutoSize = true;
            this.radiofatra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiofatra.ForeColor = System.Drawing.Color.Navy;
            this.radiofatra.Location = new System.Drawing.Point(1114, 83);
            this.radiofatra.Name = "radiofatra";
            this.radiofatra.Size = new System.Drawing.Size(132, 24);
            this.radiofatra.TabIndex = 129;
            this.radiofatra.TabStop = true;
            this.radiofatra.Text = "بحث في فتره محدده :";
            this.radiofatra.UseVisualStyleBackColor = true;
            // 
            // dtpfrom
            // 
            this.dtpfrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfrom.Location = new System.Drawing.Point(930, 83);
            this.dtpfrom.Name = "dtpfrom";
            this.dtpfrom.Size = new System.Drawing.Size(138, 26);
            this.dtpfrom.TabIndex = 128;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(1074, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 22);
            this.label3.TabIndex = 127;
            this.label3.Text = "من :";
            // 
            // dtpto
            // 
            this.dtpto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpto.Location = new System.Drawing.Point(736, 84);
            this.dtpto.Name = "dtpto";
            this.dtpto.Size = new System.Drawing.Size(132, 26);
            this.dtpto.TabIndex = 126;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(874, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 22);
            this.label6.TabIndex = 125;
            this.label6.Text = "الي :";
            // 
            // btnsandat_deleted
            // 
            this.btnsandat_deleted.Appearance.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsandat_deleted.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnsandat_deleted.Appearance.Options.UseFont = true;
            this.btnsandat_deleted.Appearance.Options.UseForeColor = true;
            this.btnsandat_deleted.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btnsandat_deleted.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnsandat_deleted.ImageOptions.SvgImage")));
            this.btnsandat_deleted.Location = new System.Drawing.Point(5, 73);
            this.btnsandat_deleted.Name = "btnsandat_deleted";
            this.btnsandat_deleted.Size = new System.Drawing.Size(138, 47);
            this.btnsandat_deleted.TabIndex = 17;
            this.btnsandat_deleted.Text = "سندات محذوفه";
            this.btnsandat_deleted.Click += new System.EventHandler(this.btnsandat_deleted_Click);
            // 
            // btndeleteoldmoney
            // 
            this.btndeleteoldmoney.Appearance.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeleteoldmoney.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.btndeleteoldmoney.Appearance.Options.UseFont = true;
            this.btndeleteoldmoney.Appearance.Options.UseForeColor = true;
            this.btndeleteoldmoney.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btndeleteoldmoney.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btndeleteoldmoney.ImageOptions.SvgImage")));
            this.btndeleteoldmoney.Location = new System.Drawing.Point(149, 73);
            this.btndeleteoldmoney.Name = "btndeleteoldmoney";
            this.btndeleteoldmoney.Size = new System.Drawing.Size(138, 47);
            this.btndeleteoldmoney.TabIndex = 14;
            this.btndeleteoldmoney.Text = "حذف رصيد سابق";
            this.btndeleteoldmoney.Click += new System.EventHandler(this.btndeleteoldmoney_Click);
            // 
            // btndeleteselectedsadad
            // 
            this.btndeleteselectedsadad.Appearance.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btndeleteselectedsadad.Click += new System.EventHandler(this.btndeleteselectedsadad_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(191, 16);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(176, 49);
            this.simpleButton2.TabIndex = 16;
            this.simpleButton2.Text = "فلتره الفاتوره";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Droid Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(6, 18);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(179, 47);
            this.simpleButton1.TabIndex = 15;
            this.simpleButton1.Text = "Export Data To Excell";
            // 
            // btnprint
            // 
            this.btnprint.Appearance.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // radiocustname
            // 
            this.radiocustname.AutoSize = true;
            this.radiocustname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiocustname.ForeColor = System.Drawing.Color.Navy;
            this.radiocustname.Location = new System.Drawing.Point(1061, 52);
            this.radiocustname.Name = "radiocustname";
            this.radiocustname.Size = new System.Drawing.Size(196, 24);
            this.radiocustname.TabIndex = 12;
            this.radiocustname.TabStop = true;
            this.radiocustname.Text = "اكتب اسم العميل او جزء من اسمه";
            this.radiocustname.UseVisualStyleBackColor = true;
            // 
            // txt_write_customer
            // 
            this.txt_write_customer.BackColor = System.Drawing.Color.White;
            this.txt_write_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_write_customer.ForeColor = System.Drawing.Color.Navy;
            this.txt_write_customer.Location = new System.Drawing.Point(635, 51);
            this.txt_write_customer.Name = "txt_write_customer";
            this.txt_write_customer.Size = new System.Drawing.Size(420, 26);
            this.txt_write_customer.TabIndex = 11;
            this.txt_write_customer.TextChanged += new System.EventHandler(this.txt_write_customer_TextChanged);
            // 
            // btnsearch
            // 
            this.btnsearch.Appearance.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // radioselectone
            // 
            this.radioselectone.AutoSize = true;
            this.radioselectone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioselectone.ForeColor = System.Drawing.Color.Navy;
            this.radioselectone.Location = new System.Drawing.Point(1005, 19);
            this.radioselectone.Name = "radioselectone";
            this.radioselectone.Size = new System.Drawing.Size(79, 24);
            this.radioselectone.TabIndex = 3;
            this.radioselectone.TabStop = true;
            this.radioselectone.Text = "عميل محدد";
            this.radioselectone.UseVisualStyleBackColor = true;
            // 
            // radiocustomerall
            // 
            this.radiocustomerall.AutoSize = true;
            this.radiocustomerall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiocustomerall.ForeColor = System.Drawing.Color.Navy;
            this.radiocustomerall.Location = new System.Drawing.Point(1166, 24);
            this.radiocustomerall.Name = "radiocustomerall";
            this.radiocustomerall.Size = new System.Drawing.Size(80, 24);
            this.radiocustomerall.TabIndex = 2;
            this.radiocustomerall.TabStop = true;
            this.radiocustomerall.Text = "كل العملاء";
            this.radiocustomerall.UseVisualStyleBackColor = true;
            // 
            // cbxcustomer
            // 
            this.cbxcustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxcustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxcustomer.BackColor = System.Drawing.Color.White;
            this.cbxcustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxcustomer.ForeColor = System.Drawing.Color.Navy;
            this.cbxcustomer.FormattingEnabled = true;
            this.cbxcustomer.Location = new System.Drawing.Point(635, 18);
            this.cbxcustomer.Name = "cbxcustomer";
            this.cbxcustomer.Size = new System.Drawing.Size(340, 28);
            this.cbxcustomer.TabIndex = 0;
            // 
            // txttotal
            // 
            this.txttotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txttotal.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.ForeColor = System.Drawing.Color.Navy;
            this.txttotal.Location = new System.Drawing.Point(149, 186);
            this.txttotal.Multiline = true;
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(1200, 45);
            this.txttotal.TabIndex = 49;
            this.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Droid Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.Location = new System.Drawing.Point(2, 237);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1348, 349);
            this.dgv.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AccessibleDescription = "v";
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Droid Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(607, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 27);
            this.label1.TabIndex = 51;
            this.label1.Text = "حسابات العملاء";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radiofatra);
            this.groupBox1.Controls.Add(this.dtpfrom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnsandat_deleted);
            this.groupBox1.Controls.Add(this.btndeleteoldmoney);
            this.groupBox1.Controls.Add(this.btndeleteselectedsadad);
            this.groupBox1.Controls.Add(this.simpleButton2);
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.btnprint);
            this.groupBox1.Controls.Add(this.radiocustname);
            this.groupBox1.Controls.Add(this.txt_write_customer);
            this.groupBox1.Controls.Add(this.btnsearch);
            this.groupBox1.Controls.Add(this.radioselectone);
            this.groupBox1.Controls.Add(this.radiocustomerall);
            this.groupBox1.Controls.Add(this.cbxcustomer);
            this.groupBox1.Location = new System.Drawing.Point(5, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1344, 133);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بحث عام";
            // 
            // customer_accounts
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1353, 587);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Droid Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "customer_accounts";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حسابات العملاء";
            this.Load += new System.EventHandler(this.customer_accounts_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnsearchbranchses;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radiofatra;
        private System.Windows.Forms.DateTimePicker dtpfrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpto;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton btnsandat_deleted;
        private DevExpress.XtraEditors.SimpleButton btndeleteoldmoney;
        private DevExpress.XtraEditors.SimpleButton btndeleteselectedsadad;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnprint;
        private System.Windows.Forms.RadioButton radiocustname;
        private System.Windows.Forms.TextBox txt_write_customer;
        private DevExpress.XtraEditors.SimpleButton btnsearch;
        private System.Windows.Forms.RadioButton radioselectone;
        private System.Windows.Forms.RadioButton radiocustomerall;
        private System.Windows.Forms.ComboBox cbxcustomer;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
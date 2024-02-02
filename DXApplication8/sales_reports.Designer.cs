namespace DXApplication8
{
    partial class sales_reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sales_reports));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsearchwithezn = new System.Windows.Forms.TextBox();
            this.checkezn = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxsupandemp = new System.Windows.Forms.ComboBox();
            this.radioemployeesupplier = new System.Windows.Forms.RadioButton();
            this.radiosuppliers = new System.Windows.Forms.RadioButton();
            this.txtpro_name = new System.Windows.Forms.TextBox();
            this.radiopro_name = new System.Windows.Forms.RadioButton();
            this.txtcustname = new System.Windows.Forms.TextBox();
            this.btnsearch = new DevExpress.XtraEditors.SimpleButton();
            this.radiocustname = new System.Windows.Forms.RadioButton();
            this.dgvsearchforproducts = new System.Windows.Forms.DataGridView();
            this.cbxcustomer = new System.Windows.Forms.ComboBox();
            this.radioonecustomer = new System.Windows.Forms.RadioButton();
            this.radioallcustomer = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btnprintall = new DevExpress.XtraEditors.SimpleButton();
            this.dtpto = new System.Windows.Forms.DateTimePicker();
            this.txtnoofbills = new System.Windows.Forms.TextBox();
            this.checknomberofbill = new System.Windows.Forms.CheckBox();
            this.btnprintsellected = new DevExpress.XtraEditors.SimpleButton();
            this.btnsearchbranchses = new DevExpress.XtraEditors.SimpleButton();
            this.cbxbranchname = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.radiocustomerselectedinbranchselected = new System.Windows.Forms.RadioButton();
            this.radioallcustomersinselectedbranch = new System.Windows.Forms.RadioButton();
            this.txttotalsales = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpfrom = new System.Windows.Forms.DateTimePicker();
            this.radiosupplierselectioninbranch = new System.Windows.Forms.RadioButton();
            this.radioemployeeselectioninbranchselection = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsearchforproducts)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.dgv.Location = new System.Drawing.Point(8, 258);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1355, 330);
            this.dgv.TabIndex = 85;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(385, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "E";
            // 
            // txtsearchwithezn
            // 
            this.txtsearchwithezn.Location = new System.Drawing.Point(411, 61);
            this.txtsearchwithezn.Name = "txtsearchwithezn";
            this.txtsearchwithezn.Size = new System.Drawing.Size(148, 28);
            this.txtsearchwithezn.TabIndex = 7;
            this.txtsearchwithezn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsearchwithezn_KeyPress);
            // 
            // checkezn
            // 
            this.checkezn.AutoSize = true;
            this.checkezn.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkezn.Location = new System.Drawing.Point(575, 61);
            this.checkezn.Name = "checkezn";
            this.checkezn.Size = new System.Drawing.Size(118, 25);
            this.checkezn.TabIndex = 6;
            this.checkezn.Text = "بحث برقم الاذن :";
            this.checkezn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(156, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "الي";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(585, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 36);
            this.label1.TabIndex = 84;
            this.label1.Text = "تقارير المبيعات";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxsupandemp);
            this.groupBox1.Controls.Add(this.radioemployeesupplier);
            this.groupBox1.Controls.Add(this.radiosuppliers);
            this.groupBox1.Controls.Add(this.txtpro_name);
            this.groupBox1.Controls.Add(this.radiopro_name);
            this.groupBox1.Controls.Add(this.txtcustname);
            this.groupBox1.Controls.Add(this.btnsearch);
            this.groupBox1.Controls.Add(this.radiocustname);
            this.groupBox1.Controls.Add(this.dgvsearchforproducts);
            this.groupBox1.Controls.Add(this.cbxcustomer);
            this.groupBox1.Controls.Add(this.radioonecustomer);
            this.groupBox1.Controls.Add(this.radioallcustomer);
            this.groupBox1.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 219);
            this.groupBox1.TabIndex = 82;
            this.groupBox1.TabStop = false;
            // 
            // cbxsupandemp
            // 
            this.cbxsupandemp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxsupandemp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxsupandemp.FormattingEnabled = true;
            this.cbxsupandemp.Location = new System.Drawing.Point(121, 45);
            this.cbxsupandemp.Name = "cbxsupandemp";
            this.cbxsupandemp.Size = new System.Drawing.Size(171, 29);
            this.cbxsupandemp.TabIndex = 55;
            // 
            // radioemployeesupplier
            // 
            this.radioemployeesupplier.AutoSize = true;
            this.radioemployeesupplier.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioemployeesupplier.Location = new System.Drawing.Point(303, 48);
            this.radioemployeesupplier.Name = "radioemployeesupplier";
            this.radioemployeesupplier.Size = new System.Drawing.Size(96, 25);
            this.radioemployeesupplier.TabIndex = 54;
            this.radioemployeesupplier.TabStop = true;
            this.radioemployeesupplier.Text = "موظف محدد";
            this.radioemployeesupplier.UseVisualStyleBackColor = true;
            this.radioemployeesupplier.CheckedChanged += new System.EventHandler(this.radioemployeesupplier_CheckedChanged);
            // 
            // radiosuppliers
            // 
            this.radiosuppliers.AutoSize = true;
            this.radiosuppliers.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiosuppliers.Location = new System.Drawing.Point(451, 47);
            this.radiosuppliers.Name = "radiosuppliers";
            this.radiosuppliers.Size = new System.Drawing.Size(86, 25);
            this.radiosuppliers.TabIndex = 53;
            this.radiosuppliers.TabStop = true;
            this.radiosuppliers.Text = "مورد محدد";
            this.radiosuppliers.UseVisualStyleBackColor = true;
            this.radiosuppliers.CheckedChanged += new System.EventHandler(this.radiosuppliers_CheckedChanged);
            // 
            // txtpro_name
            // 
            this.txtpro_name.Location = new System.Drawing.Point(119, 102);
            this.txtpro_name.Name = "txtpro_name";
            this.txtpro_name.Size = new System.Drawing.Size(288, 28);
            this.txtpro_name.TabIndex = 52;
            this.txtpro_name.TextChanged += new System.EventHandler(this.txtpro_name_TextChanged);
            // 
            // radiopro_name
            // 
            this.radiopro_name.AutoSize = true;
            this.radiopro_name.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiopro_name.Location = new System.Drawing.Point(434, 101);
            this.radiopro_name.Name = "radiopro_name";
            this.radiopro_name.Size = new System.Drawing.Size(167, 25);
            this.radiopro_name.TabIndex = 51;
            this.radiopro_name.TabStop = true;
            this.radiopro_name.Text = "اكتب جزء من اسم المنتج :";
            this.radiopro_name.UseVisualStyleBackColor = true;
            // 
            // txtcustname
            // 
            this.txtcustname.Location = new System.Drawing.Point(121, 74);
            this.txtcustname.Name = "txtcustname";
            this.txtcustname.Size = new System.Drawing.Size(286, 28);
            this.txtcustname.TabIndex = 8;
            this.txtcustname.TextChanged += new System.EventHandler(this.txtcustname_TextChanged);
            // 
            // btnsearch
            // 
            this.btnsearch.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnsearch.Appearance.Options.UseFont = true;
            this.btnsearch.Appearance.Options.UseForeColor = true;
            this.btnsearch.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnsearch.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnsearch.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnsearch.ImageOptions.SvgImage")));
            this.btnsearch.Location = new System.Drawing.Point(6, 18);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnsearch.Size = new System.Drawing.Size(109, 100);
            this.btnsearch.TabIndex = 3;
            this.btnsearch.Text = "بحث عام";
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // radiocustname
            // 
            this.radiocustname.AutoSize = true;
            this.radiocustname.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiocustname.Location = new System.Drawing.Point(412, 74);
            this.radiocustname.Name = "radiocustname";
            this.radiocustname.Size = new System.Drawing.Size(189, 25);
            this.radiocustname.TabIndex = 9;
            this.radiocustname.TabStop = true;
            this.radiocustname.Text = "اكتب اسم العميل او جزء منه :";
            this.radiocustname.UseVisualStyleBackColor = true;
            // 
            // dgvsearchforproducts
            // 
            this.dgvsearchforproducts.AllowUserToAddRows = false;
            this.dgvsearchforproducts.AllowUserToDeleteRows = false;
            this.dgvsearchforproducts.AllowUserToResizeColumns = false;
            this.dgvsearchforproducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvsearchforproducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvsearchforproducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvsearchforproducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvsearchforproducts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvsearchforproducts.GridColor = System.Drawing.Color.Navy;
            this.dgvsearchforproducts.Location = new System.Drawing.Point(10, 131);
            this.dgvsearchforproducts.Name = "dgvsearchforproducts";
            this.dgvsearchforproducts.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvsearchforproducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvsearchforproducts.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvsearchforproducts.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Navy;
            this.dgvsearchforproducts.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dgvsearchforproducts.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Navy;
            this.dgvsearchforproducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvsearchforproducts.Size = new System.Drawing.Size(592, 85);
            this.dgvsearchforproducts.TabIndex = 48;
            // 
            // cbxcustomer
            // 
            this.cbxcustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxcustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxcustomer.FormattingEnabled = true;
            this.cbxcustomer.Location = new System.Drawing.Point(121, 15);
            this.cbxcustomer.Name = "cbxcustomer";
            this.cbxcustomer.Size = new System.Drawing.Size(171, 29);
            this.cbxcustomer.TabIndex = 2;
            // 
            // radioonecustomer
            // 
            this.radioonecustomer.AutoSize = true;
            this.radioonecustomer.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioonecustomer.Location = new System.Drawing.Point(311, 21);
            this.radioonecustomer.Name = "radioonecustomer";
            this.radioonecustomer.Size = new System.Drawing.Size(87, 25);
            this.radioonecustomer.TabIndex = 1;
            this.radioonecustomer.TabStop = true;
            this.radioonecustomer.Text = "عميل محدد";
            this.radioonecustomer.UseVisualStyleBackColor = true;
            // 
            // radioallcustomer
            // 
            this.radioallcustomer.AutoSize = true;
            this.radioallcustomer.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioallcustomer.Location = new System.Drawing.Point(451, 20);
            this.radioallcustomer.Name = "radioallcustomer";
            this.radioallcustomer.Size = new System.Drawing.Size(84, 25);
            this.radioallcustomer.TabIndex = 0;
            this.radioallcustomer.TabStop = true;
            this.radioallcustomer.Text = "كل العملاء";
            this.radioallcustomer.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "من";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(1184, 168);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(179, 36);
            this.simpleButton1.TabIndex = 89;
            this.simpleButton1.Text = "Export Data To Excell";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(241, 31);
            this.label6.TabIndex = 88;
            this.label6.Text = "اختر عمليه وقم بتحديد الفتره ";
            // 
            // btnprintall
            // 
            this.btnprintall.Appearance.Font = new System.Drawing.Font("Droid Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprintall.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnprintall.Appearance.Options.UseFont = true;
            this.btnprintall.Appearance.Options.UseForeColor = true;
            this.btnprintall.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnprintall.ImageOptions.Image")));
            this.btnprintall.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnprintall.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnprintall.Location = new System.Drawing.Point(730, 590);
            this.btnprintall.Name = "btnprintall";
            this.btnprintall.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnprintall.Size = new System.Drawing.Size(242, 40);
            this.btnprintall.TabIndex = 91;
            this.btnprintall.Text = "طباعه كل الفواتير في فتره محدده";
            // 
            // dtpto
            // 
            this.dtpto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpto.Location = new System.Drawing.Point(0, 41);
            this.dtpto.Name = "dtpto";
            this.dtpto.Size = new System.Drawing.Size(148, 28);
            this.dtpto.TabIndex = 3;
            // 
            // txtnoofbills
            // 
            this.txtnoofbills.Location = new System.Drawing.Point(411, 17);
            this.txtnoofbills.Name = "txtnoofbills";
            this.txtnoofbills.Size = new System.Drawing.Size(148, 28);
            this.txtnoofbills.TabIndex = 1;
            this.txtnoofbills.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnoofbills_KeyPress);
            // 
            // checknomberofbill
            // 
            this.checknomberofbill.AutoSize = true;
            this.checknomberofbill.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checknomberofbill.Location = new System.Drawing.Point(560, 20);
            this.checknomberofbill.Name = "checknomberofbill";
            this.checknomberofbill.Size = new System.Drawing.Size(133, 25);
            this.checknomberofbill.TabIndex = 0;
            this.checknomberofbill.Text = "بحث برقم الفاتوره :";
            this.checknomberofbill.UseVisualStyleBackColor = true;
            // 
            // btnprintsellected
            // 
            this.btnprintsellected.Appearance.Font = new System.Drawing.Font("Droid Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprintsellected.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnprintsellected.Appearance.Options.UseFont = true;
            this.btnprintsellected.Appearance.Options.UseForeColor = true;
            this.btnprintsellected.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnprintsellected.ImageOptions.Image")));
            this.btnprintsellected.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnprintsellected.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnprintsellected.Location = new System.Drawing.Point(482, 590);
            this.btnprintsellected.Name = "btnprintsellected";
            this.btnprintsellected.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnprintsellected.Size = new System.Drawing.Size(242, 40);
            this.btnprintsellected.TabIndex = 90;
            this.btnprintsellected.Text = "طباعه الفاتوره المحدده";
            this.btnprintsellected.Click += new System.EventHandler(this.btnprintsellected_Click);
            // 
            // btnsearchbranchses
            // 
            this.btnsearchbranchses.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearchbranchses.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnsearchbranchses.Appearance.Options.UseFont = true;
            this.btnsearchbranchses.Appearance.Options.UseForeColor = true;
            this.btnsearchbranchses.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsearchbranchses.ImageOptions.Image")));
            this.btnsearchbranchses.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnsearchbranchses.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnsearchbranchses.Location = new System.Drawing.Point(1061, 168);
            this.btnsearchbranchses.Name = "btnsearchbranchses";
            this.btnsearchbranchses.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnsearchbranchses.Size = new System.Drawing.Size(115, 36);
            this.btnsearchbranchses.TabIndex = 78;
            this.btnsearchbranchses.Text = "بحث الفروع";
            this.btnsearchbranchses.Click += new System.EventHandler(this.btnsearchbranchses_Click);
            // 
            // cbxbranchname
            // 
            this.cbxbranchname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxbranchname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxbranchname.FormattingEnabled = true;
            this.cbxbranchname.Location = new System.Drawing.Point(753, 183);
            this.cbxbranchname.Name = "cbxbranchname";
            this.cbxbranchname.Size = new System.Drawing.Size(302, 21);
            this.cbxbranchname.TabIndex = 79;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(666, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 21);
            this.label8.TabIndex = 77;
            this.label8.Text = "اختر الفرع :";
            // 
            // radiocustomerselectedinbranchselected
            // 
            this.radiocustomerselectedinbranchselected.AutoSize = true;
            this.radiocustomerselectedinbranchselected.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiocustomerselectedinbranchselected.Location = new System.Drawing.Point(833, 143);
            this.radiocustomerselectedinbranchselected.Name = "radiocustomerselectedinbranchselected";
            this.radiocustomerselectedinbranchselected.Size = new System.Drawing.Size(164, 25);
            this.radiocustomerselectedinbranchselected.TabIndex = 81;
            this.radiocustomerselectedinbranchselected.TabStop = true;
            this.radiocustomerselectedinbranchselected.Text = "عميل محدد في فرع محدد";
            this.radiocustomerselectedinbranchselected.UseVisualStyleBackColor = true;
            // 
            // radioallcustomersinselectedbranch
            // 
            this.radioallcustomersinselectedbranch.AutoSize = true;
            this.radioallcustomersinselectedbranch.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioallcustomersinselectedbranch.Location = new System.Drawing.Point(647, 143);
            this.radioallcustomersinselectedbranch.Name = "radioallcustomersinselectedbranch";
            this.radioallcustomersinselectedbranch.Size = new System.Drawing.Size(177, 25);
            this.radioallcustomersinselectedbranch.TabIndex = 80;
            this.radioallcustomersinselectedbranch.TabStop = true;
            this.radioallcustomersinselectedbranch.Text = "كل العملاء في الفرع المحدد";
            this.radioallcustomersinselectedbranch.UseVisualStyleBackColor = true;
            // 
            // txttotalsales
            // 
            this.txttotalsales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txttotalsales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttotalsales.Font = new System.Drawing.Font("PMingLiU-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalsales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txttotalsales.Location = new System.Drawing.Point(823, 207);
            this.txttotalsales.Multiline = true;
            this.txttotalsales.Name = "txttotalsales";
            this.txttotalsales.ReadOnly = true;
            this.txttotalsales.Size = new System.Drawing.Size(540, 45);
            this.txttotalsales.TabIndex = 87;
            this.txttotalsales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(654, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 21);
            this.label4.TabIndex = 86;
            this.label4.Text = "اجمالي مبالغ المبيعات :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtsearchwithezn);
            this.groupBox2.Controls.Add(this.checkezn);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtpto);
            this.groupBox2.Controls.Add(this.dtpfrom);
            this.groupBox2.Controls.Add(this.txtnoofbills);
            this.groupBox2.Controls.Add(this.checknomberofbill);
            this.groupBox2.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(641, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(717, 100);
            this.groupBox2.TabIndex = 83;
            this.groupBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(385, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "E";
            // 
            // dtpfrom
            // 
            this.dtpfrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfrom.Location = new System.Drawing.Point(202, 42);
            this.dtpfrom.Name = "dtpfrom";
            this.dtpfrom.Size = new System.Drawing.Size(139, 28);
            this.dtpfrom.TabIndex = 2;
            // 
            // radiosupplierselectioninbranch
            // 
            this.radiosupplierselectioninbranch.AutoSize = true;
            this.radiosupplierselectioninbranch.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiosupplierselectioninbranch.Location = new System.Drawing.Point(1016, 142);
            this.radiosupplierselectioninbranch.Name = "radiosupplierselectioninbranch";
            this.radiosupplierselectioninbranch.Size = new System.Drawing.Size(163, 25);
            this.radiosupplierselectioninbranch.TabIndex = 92;
            this.radiosupplierselectioninbranch.TabStop = true;
            this.radiosupplierselectioninbranch.Text = "مورد محدد في فرع محدد";
            this.radiosupplierselectioninbranch.UseVisualStyleBackColor = true;
            // 
            // radioemployeeselectioninbranchselection
            // 
            this.radioemployeeselectioninbranchselection.AutoSize = true;
            this.radioemployeeselectioninbranchselection.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioemployeeselectioninbranchselection.Location = new System.Drawing.Point(1192, 143);
            this.radioemployeeselectioninbranchselection.Name = "radioemployeeselectioninbranchselection";
            this.radioemployeeselectioninbranchselection.Size = new System.Drawing.Size(173, 25);
            this.radioemployeeselectioninbranchselection.TabIndex = 93;
            this.radioemployeeselectioninbranchselection.TabStop = true;
            this.radioemployeeselectioninbranchselection.Text = "موظف محدد في فرع محدد";
            this.radioemployeeselectioninbranchselection.UseVisualStyleBackColor = true;
            // 
            // sales_reports
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1370, 632);
            this.Controls.Add(this.radioemployeeselectioninbranchselection);
            this.Controls.Add(this.radiosupplierselectioninbranch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnprintall);
            this.Controls.Add(this.btnprintsellected);
            this.Controls.Add(this.btnsearchbranchses);
            this.Controls.Add(this.cbxbranchname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.radiocustomerselectedinbranchselected);
            this.Controls.Add(this.radioallcustomersinselectedbranch);
            this.Controls.Add(this.txttotalsales);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "sales_reports";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقارير المبيعات";
            this.Load += new System.EventHandler(this.sales_reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsearchforproducts)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsearchwithezn;
        private System.Windows.Forms.CheckBox checkezn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtcustname;
        private DevExpress.XtraEditors.SimpleButton btnsearch;
        private System.Windows.Forms.RadioButton radiocustname;
        private System.Windows.Forms.DataGridView dgvsearchforproducts;
        private System.Windows.Forms.ComboBox cbxcustomer;
        private System.Windows.Forms.RadioButton radioonecustomer;
        private System.Windows.Forms.RadioButton radioallcustomer;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton btnprintall;
        private System.Windows.Forms.DateTimePicker dtpto;
        private System.Windows.Forms.TextBox txtnoofbills;
        private System.Windows.Forms.CheckBox checknomberofbill;
        private DevExpress.XtraEditors.SimpleButton btnprintsellected;
        private DevExpress.XtraEditors.SimpleButton btnsearchbranchses;
        private System.Windows.Forms.ComboBox cbxbranchname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radiocustomerselectedinbranchselected;
        private System.Windows.Forms.RadioButton radioallcustomersinselectedbranch;
        private System.Windows.Forms.TextBox txttotalsales;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpfrom;
        private System.Windows.Forms.TextBox txtpro_name;
        private System.Windows.Forms.RadioButton radiopro_name;
        private System.Windows.Forms.ComboBox cbxsupandemp;
        private System.Windows.Forms.RadioButton radioemployeesupplier;
        private System.Windows.Forms.RadioButton radiosuppliers;
        private System.Windows.Forms.RadioButton radiosupplierselectioninbranch;
        private System.Windows.Forms.RadioButton radioemployeeselectioninbranchselection;
        private System.Windows.Forms.Label label7;
    }
}
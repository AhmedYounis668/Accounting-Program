namespace DXApplication8
{
    partial class buy_reports
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buy_reports));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtsupname = new System.Windows.Forms.TextBox();
            this.radiosuppname = new System.Windows.Forms.RadioButton();
            this.dgvsearchforproducts = new System.Windows.Forms.DataGridView();
            this.btnsearchbranchses = new DevExpress.XtraEditors.SimpleButton();
            this.radioallsuppliersinselectedbranch = new System.Windows.Forms.RadioButton();
            this.radiosupplierselectedinbranchselected = new System.Windows.Forms.RadioButton();
            this.cbxbranchname = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txttotalpurchases = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsearchwithezn = new System.Windows.Forms.TextBox();
            this.checkezn = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpto = new System.Windows.Forms.DateTimePicker();
            this.dtpfrom = new System.Windows.Forms.DateTimePicker();
            this.txtnoofbills = new System.Windows.Forms.TextBox();
            this.checknomberofbill = new System.Windows.Forms.CheckBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtpronamesearch = new System.Windows.Forms.TextBox();
            this.radiosearchwithproduct_name = new System.Windows.Forms.RadioButton();
            this.btnsearch = new DevExpress.XtraEditors.SimpleButton();
            this.cbxsuppliers = new System.Windows.Forms.ComboBox();
            this.radioonesupplier = new System.Windows.Forms.RadioButton();
            this.radioallsupplier = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnprintsellected = new DevExpress.XtraEditors.SimpleButton();
            this.btnprintall = new DevExpress.XtraEditors.SimpleButton();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsearchforproducts)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtsupname
            // 
            this.txtsupname.Location = new System.Drawing.Point(121, 47);
            this.txtsupname.Name = "txtsupname";
            this.txtsupname.Size = new System.Drawing.Size(309, 21);
            this.txtsupname.TabIndex = 8;
            this.txtsupname.TextChanged += new System.EventHandler(this.txtsupname_TextChanged);
            // 
            // radiosuppname
            // 
            this.radiosuppname.AutoSize = true;
            this.radiosuppname.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiosuppname.Location = new System.Drawing.Point(434, 47);
            this.radiosuppname.Name = "radiosuppname";
            this.radiosuppname.Size = new System.Drawing.Size(187, 25);
            this.radiosuppname.TabIndex = 9;
            this.radiosuppname.TabStop = true;
            this.radiosuppname.Text = "اكتب اسم المورد او جزء منه :";
            this.radiosuppname.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvsearchforproducts.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvsearchforproducts.GridColor = System.Drawing.Color.Navy;
            this.dgvsearchforproducts.Location = new System.Drawing.Point(6, 101);
            this.dgvsearchforproducts.Name = "dgvsearchforproducts";
            this.dgvsearchforproducts.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvsearchforproducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvsearchforproducts.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvsearchforproducts.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Navy;
            this.dgvsearchforproducts.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dgvsearchforproducts.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Navy;
            this.dgvsearchforproducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvsearchforproducts.Size = new System.Drawing.Size(615, 109);
            this.dgvsearchforproducts.TabIndex = 48;
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
            this.btnsearchbranchses.Location = new System.Drawing.Point(1067, 165);
            this.btnsearchbranchses.Name = "btnsearchbranchses";
            this.btnsearchbranchses.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnsearchbranchses.Size = new System.Drawing.Size(115, 36);
            this.btnsearchbranchses.TabIndex = 10;
            this.btnsearchbranchses.Text = "بحث الفروع";
            this.btnsearchbranchses.Click += new System.EventHandler(this.btnsearchbranchses_Click);
            // 
            // radioallsuppliersinselectedbranch
            // 
            this.radioallsuppliersinselectedbranch.AutoSize = true;
            this.radioallsuppliersinselectedbranch.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioallsuppliersinselectedbranch.Location = new System.Drawing.Point(651, 143);
            this.radioallsuppliersinselectedbranch.Name = "radioallsuppliersinselectedbranch";
            this.radioallsuppliersinselectedbranch.Size = new System.Drawing.Size(188, 25);
            this.radioallsuppliersinselectedbranch.TabIndex = 20;
            this.radioallsuppliersinselectedbranch.TabStop = true;
            this.radioallsuppliersinselectedbranch.Text = "كل الموردين في الفرع المحدد";
            this.radioallsuppliersinselectedbranch.UseVisualStyleBackColor = true;
            // 
            // radiosupplierselectedinbranchselected
            // 
            this.radiosupplierselectedinbranchselected.AutoSize = true;
            this.radiosupplierselectedinbranchselected.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiosupplierselectedinbranchselected.Location = new System.Drawing.Point(857, 143);
            this.radiosupplierselectedinbranchselected.Name = "radiosupplierselectedinbranchselected";
            this.radiosupplierselectedinbranchselected.Size = new System.Drawing.Size(163, 25);
            this.radiosupplierselectedinbranchselected.TabIndex = 21;
            this.radiosupplierselectedinbranchselected.TabStop = true;
            this.radiosupplierselectedinbranchselected.Text = "مورد محدد في فرع محدد";
            this.radiosupplierselectedinbranchselected.UseVisualStyleBackColor = true;
            // 
            // cbxbranchname
            // 
            this.cbxbranchname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxbranchname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxbranchname.FormattingEnabled = true;
            this.cbxbranchname.Location = new System.Drawing.Point(759, 174);
            this.cbxbranchname.Name = "cbxbranchname";
            this.cbxbranchname.Size = new System.Drawing.Size(302, 21);
            this.cbxbranchname.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(682, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "اختر الفرع :";
            // 
            // txttotalpurchases
            // 
            this.txttotalpurchases.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txttotalpurchases.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttotalpurchases.Font = new System.Drawing.Font("PMingLiU-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalpurchases.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txttotalpurchases.Location = new System.Drawing.Point(827, 207);
            this.txttotalpurchases.Multiline = true;
            this.txttotalpurchases.Name = "txttotalpurchases";
            this.txttotalpurchases.ReadOnly = true;
            this.txttotalpurchases.Size = new System.Drawing.Size(540, 45);
            this.txttotalpurchases.TabIndex = 72;
            this.txttotalpurchases.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Droid Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(658, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 28);
            this.label4.TabIndex = 71;
            this.label4.Text = "اجمالي مبالغ المشتريات :";
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
            this.groupBox2.Location = new System.Drawing.Point(645, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(713, 100);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(408, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "E";
            // 
            // txtsearchwithezn
            // 
            this.txtsearchwithezn.Location = new System.Drawing.Point(434, 63);
            this.txtsearchwithezn.Name = "txtsearchwithezn";
            this.txtsearchwithezn.Size = new System.Drawing.Size(148, 21);
            this.txtsearchwithezn.TabIndex = 7;
            this.txtsearchwithezn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsearchwithezn_KeyPress);
            // 
            // checkezn
            // 
            this.checkezn.AutoSize = true;
            this.checkezn.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkezn.Location = new System.Drawing.Point(595, 62);
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
            this.label3.Location = new System.Drawing.Point(176, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "الي";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "من";
            // 
            // dtpto
            // 
            this.dtpto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpto.Location = new System.Drawing.Point(9, 43);
            this.dtpto.Name = "dtpto";
            this.dtpto.Size = new System.Drawing.Size(161, 21);
            this.dtpto.TabIndex = 3;
            // 
            // dtpfrom
            // 
            this.dtpfrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfrom.Location = new System.Drawing.Point(218, 43);
            this.dtpfrom.Name = "dtpfrom";
            this.dtpfrom.Size = new System.Drawing.Size(139, 21);
            this.dtpfrom.TabIndex = 2;
            // 
            // txtnoofbills
            // 
            this.txtnoofbills.Location = new System.Drawing.Point(434, 23);
            this.txtnoofbills.Name = "txtnoofbills";
            this.txtnoofbills.Size = new System.Drawing.Size(148, 21);
            this.txtnoofbills.TabIndex = 1;
            this.txtnoofbills.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnoofbills_KeyPress);
            // 
            // checknomberofbill
            // 
            this.checknomberofbill.AutoSize = true;
            this.checknomberofbill.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checknomberofbill.Location = new System.Drawing.Point(580, 22);
            this.checknomberofbill.Name = "checknomberofbill";
            this.checknomberofbill.Size = new System.Drawing.Size(133, 25);
            this.checknomberofbill.TabIndex = 0;
            this.checknomberofbill.Text = "بحث برقم الفاتوره :";
            this.checknomberofbill.UseVisualStyleBackColor = true;
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
            this.dgv.Location = new System.Drawing.Point(12, 258);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1355, 330);
            this.dgv.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(589, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 36);
            this.label1.TabIndex = 69;
            this.label1.Text = "تقارير المشتريات";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtpronamesearch);
            this.groupBox1.Controls.Add(this.radiosearchwithproduct_name);
            this.groupBox1.Controls.Add(this.txtsupname);
            this.groupBox1.Controls.Add(this.btnsearch);
            this.groupBox1.Controls.Add(this.radiosuppname);
            this.groupBox1.Controls.Add(this.dgvsearchforproducts);
            this.groupBox1.Controls.Add(this.cbxsuppliers);
            this.groupBox1.Controls.Add(this.radioonesupplier);
            this.groupBox1.Controls.Add(this.radioallsupplier);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 215);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            // 
            // txtpronamesearch
            // 
            this.txtpronamesearch.Location = new System.Drawing.Point(121, 74);
            this.txtpronamesearch.Name = "txtpronamesearch";
            this.txtpronamesearch.Size = new System.Drawing.Size(309, 21);
            this.txtpronamesearch.TabIndex = 49;
            this.txtpronamesearch.TextChanged += new System.EventHandler(this.txtpronamesearch_TextChanged);
            // 
            // radiosearchwithproduct_name
            // 
            this.radiosearchwithproduct_name.AutoSize = true;
            this.radiosearchwithproduct_name.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiosearchwithproduct_name.Location = new System.Drawing.Point(454, 72);
            this.radiosearchwithproduct_name.Name = "radiosearchwithproduct_name";
            this.radiosearchwithproduct_name.Size = new System.Drawing.Size(167, 25);
            this.radiosearchwithproduct_name.TabIndex = 50;
            this.radiosearchwithproduct_name.TabStop = true;
            this.radiosearchwithproduct_name.Text = "اكتب جزء من اسم المنتج :";
            this.radiosearchwithproduct_name.UseVisualStyleBackColor = true;
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
            this.btnsearch.Location = new System.Drawing.Point(6, 18);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnsearch.Size = new System.Drawing.Size(109, 77);
            this.btnsearch.TabIndex = 3;
            this.btnsearch.Text = "بحث عام";
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // cbxsuppliers
            // 
            this.cbxsuppliers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxsuppliers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxsuppliers.FormattingEnabled = true;
            this.cbxsuppliers.Location = new System.Drawing.Point(126, 21);
            this.cbxsuppliers.Name = "cbxsuppliers";
            this.cbxsuppliers.Size = new System.Drawing.Size(166, 21);
            this.cbxsuppliers.TabIndex = 2;
            // 
            // radioonesupplier
            // 
            this.radioonesupplier.AutoSize = true;
            this.radioonesupplier.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioonesupplier.Location = new System.Drawing.Point(298, 18);
            this.radioonesupplier.Name = "radioonesupplier";
            this.radioonesupplier.Size = new System.Drawing.Size(86, 25);
            this.radioonesupplier.TabIndex = 1;
            this.radioonesupplier.TabStop = true;
            this.radioonesupplier.Text = "مورد محدد";
            this.radioonesupplier.UseVisualStyleBackColor = true;
            // 
            // radioallsupplier
            // 
            this.radioallsupplier.AutoSize = true;
            this.radioallsupplier.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioallsupplier.Location = new System.Drawing.Point(454, 17);
            this.radioallsupplier.Name = "radioallsupplier";
            this.radioallsupplier.Size = new System.Drawing.Size(95, 25);
            this.radioallsupplier.TabIndex = 0;
            this.radioallsupplier.TabStop = true;
            this.radioallsupplier.Text = "كل الموردين";
            this.radioallsupplier.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(241, 31);
            this.label6.TabIndex = 73;
            this.label6.Text = "اختر عمليه وقم بتحديد الفتره ";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(1188, 165);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(179, 36);
            this.simpleButton1.TabIndex = 74;
            this.simpleButton1.Text = "Export Data To Excell";
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
            this.btnprintsellected.Location = new System.Drawing.Point(486, 590);
            this.btnprintsellected.Name = "btnprintsellected";
            this.btnprintsellected.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnprintsellected.Size = new System.Drawing.Size(242, 40);
            this.btnprintsellected.TabIndex = 75;
            this.btnprintsellected.Text = "طباعه الفاتوره المحدده";
            this.btnprintsellected.Click += new System.EventHandler(this.btnprintsellected_Click);
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
            this.btnprintall.Location = new System.Drawing.Point(734, 590);
            this.btnprintall.Name = "btnprintall";
            this.btnprintall.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnprintall.Size = new System.Drawing.Size(242, 40);
            this.btnprintall.TabIndex = 76;
            this.btnprintall.Text = "طباعه كل الفواتير في فتره محدده";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(408, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "E";
            // 
            // buy_reports
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1370, 632);
            this.Controls.Add(this.btnprintall);
            this.Controls.Add(this.btnprintsellected);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnsearchbranchses);
            this.Controls.Add(this.cbxbranchname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.radiosupplierselectedinbranchselected);
            this.Controls.Add(this.radioallsuppliersinselectedbranch);
            this.Controls.Add(this.txttotalpurchases);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "buy_reports";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقارير المشتريات";
            this.Load += new System.EventHandler(this.buy_reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsearchforproducts)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsupname;
        private System.Windows.Forms.RadioButton radiosuppname;
        private System.Windows.Forms.DataGridView dgvsearchforproducts;
        private DevExpress.XtraEditors.SimpleButton btnsearchbranchses;
        private System.Windows.Forms.RadioButton radioallsuppliersinselectedbranch;
        private System.Windows.Forms.RadioButton radiosupplierselectedinbranchselected;
        private System.Windows.Forms.ComboBox cbxbranchname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttotalpurchases;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtsearchwithezn;
        private System.Windows.Forms.CheckBox checkezn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpto;
        private System.Windows.Forms.DateTimePicker dtpfrom;
        private System.Windows.Forms.TextBox txtnoofbills;
        private System.Windows.Forms.CheckBox checknomberofbill;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnsearch;
        private System.Windows.Forms.ComboBox cbxsuppliers;
        private System.Windows.Forms.RadioButton radioonesupplier;
        private System.Windows.Forms.RadioButton radioallsupplier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtpronamesearch;
        private System.Windows.Forms.RadioButton radiosearchwithproduct_name;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnprintsellected;
        private DevExpress.XtraEditors.SimpleButton btnprintall;
        private System.Windows.Forms.Label label7;
    }
}
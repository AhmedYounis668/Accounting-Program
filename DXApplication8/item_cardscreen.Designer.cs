namespace DXApplication8
{
    partial class item_cardscreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(item_cardscreen));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxstore = new System.Windows.Forms.ComboBox();
            this.btnsearch = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dgvproducts = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioselectediteminselectedstore = new System.Windows.Forms.RadioButton();
            this.radioallitemsinselectedstore = new System.Windows.Forms.RadioButton();
            this.txtitem = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txttotalorder = new System.Windows.Forms.TextBox();
            this.btndelete = new DevExpress.XtraEditors.SimpleButton();
            this.dtptime = new System.Windows.Forms.DateTimePicker();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtward = new System.Windows.Forms.TextBox();
            this.txtmonsarf = new System.Windows.Forms.TextBox();
            this.txtbalance = new System.Windows.Forms.TextBox();
            this.btnexportdatatoexcell = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-16, 526);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 23);
            this.label4.TabIndex = 121;
            this.label4.Text = "ملاحظات :";
            // 
            // cbxstore
            // 
            this.cbxstore.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxstore.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxstore.BackColor = System.Drawing.Color.White;
            this.cbxstore.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxstore.ForeColor = System.Drawing.Color.Navy;
            this.cbxstore.FormattingEnabled = true;
            this.cbxstore.Location = new System.Drawing.Point(150, 24);
            this.cbxstore.Name = "cbxstore";
            this.cbxstore.Size = new System.Drawing.Size(247, 29);
            this.cbxstore.TabIndex = 82;
            // 
            // btnsearch
            // 
            this.btnsearch.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Appearance.Options.UseFont = true;
            this.btnsearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsearch.ImageOptions.Image")));
            this.btnsearch.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnsearch.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnsearch.ImageOptions.SvgImage")));
            this.btnsearch.Location = new System.Drawing.Point(6, 12);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(138, 77);
            this.btnsearch.TabIndex = 74;
            this.btnsearch.Text = "Search";
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.simpleButton2);
            this.groupBox5.Controls.Add(this.simpleButton1);
            this.groupBox5.Controls.Add(this.dgvproducts);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.btnsearch);
            this.groupBox5.Controls.Add(this.cbxstore);
            this.groupBox5.Controls.Add(this.radioselectediteminselectedstore);
            this.groupBox5.Controls.Add(this.radioallitemsinselectedstore);
            this.groupBox5.Controls.Add(this.txtitem);
            this.groupBox5.Font = new System.Drawing.Font("Droid Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(720, 225);
            this.groupBox5.TabIndex = 118;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "حدد المخزن";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Droid Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.simpleButton2.Location = new System.Drawing.Point(6, 163);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(138, 56);
            this.simpleButton2.TabIndex = 135;
            this.simpleButton2.Text = "كميه كل الاصناف في مخزن محدد";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Droid Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(6, 92);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(138, 67);
            this.simpleButton1.TabIndex = 134;
            this.simpleButton1.Text = "الكميات الكليه لكل الاصناف";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // dgvproducts
            // 
            this.dgvproducts.AllowUserToAddRows = false;
            this.dgvproducts.AllowUserToDeleteRows = false;
            this.dgvproducts.AllowUserToResizeColumns = false;
            this.dgvproducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvproducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvproducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvproducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Droid Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvproducts.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvproducts.GridColor = System.Drawing.Color.Navy;
            this.dgvproducts.Location = new System.Drawing.Point(150, 91);
            this.dgvproducts.Name = "dgvproducts";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Droid Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvproducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvproducts.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvproducts.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Navy;
            this.dgvproducts.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dgvproducts.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Navy;
            this.dgvproducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvproducts.Size = new System.Drawing.Size(556, 130);
            this.dgvproducts.TabIndex = 133;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(403, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 132;
            this.label2.Text = "اختر الصنف :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(403, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 131;
            this.label1.Text = "اختر المخزن ";
            // 
            // radioselectediteminselectedstore
            // 
            this.radioselectediteminselectedstore.AutoSize = true;
            this.radioselectediteminselectedstore.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioselectediteminselectedstore.Location = new System.Drawing.Point(550, 63);
            this.radioselectediteminselectedstore.Name = "radioselectediteminselectedstore";
            this.radioselectediteminselectedstore.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioselectediteminselectedstore.Size = new System.Drawing.Size(170, 25);
            this.radioselectediteminselectedstore.TabIndex = 124;
            this.radioselectediteminselectedstore.TabStop = true;
            this.radioselectediteminselectedstore.Text = "صنف محدد في مخزن محدد";
            this.radioselectediteminselectedstore.UseVisualStyleBackColor = true;
            // 
            // radioallitemsinselectedstore
            // 
            this.radioallitemsinselectedstore.AutoSize = true;
            this.radioallitemsinselectedstore.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioallitemsinselectedstore.Location = new System.Drawing.Point(546, 28);
            this.radioallitemsinselectedstore.Name = "radioallitemsinselectedstore";
            this.radioallitemsinselectedstore.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioallitemsinselectedstore.Size = new System.Drawing.Size(174, 25);
            this.radioallitemsinselectedstore.TabIndex = 123;
            this.radioallitemsinselectedstore.TabStop = true;
            this.radioallitemsinselectedstore.Text = "كل الاصناف في مخزن محدد";
            this.radioallitemsinselectedstore.UseVisualStyleBackColor = true;
            // 
            // txtitem
            // 
            this.txtitem.BackColor = System.Drawing.Color.White;
            this.txtitem.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtitem.ForeColor = System.Drawing.Color.Navy;
            this.txtitem.Location = new System.Drawing.Point(150, 56);
            this.txtitem.Name = "txtitem";
            this.txtitem.Size = new System.Drawing.Size(247, 28);
            this.txtitem.TabIndex = 62;
            this.txtitem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtitem.TextChanged += new System.EventHandler(this.txtitem_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(377, -63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 25);
            this.label13.TabIndex = 115;
            this.label13.Text = "اجمالي المطلوب :";
            // 
            // txttotalorder
            // 
            this.txttotalorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txttotalorder.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalorder.Location = new System.Drawing.Point(483, -67);
            this.txttotalorder.Multiline = true;
            this.txttotalorder.Name = "txttotalorder";
            this.txttotalorder.ReadOnly = true;
            this.txttotalorder.Size = new System.Drawing.Size(417, 33);
            this.txttotalorder.TabIndex = 116;
            this.txttotalorder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btndelete
            // 
            this.btndelete.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Appearance.Options.UseFont = true;
            this.btndelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btndelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btndelete.ImageOptions.SvgImage")));
            this.btndelete.Location = new System.Drawing.Point(901, -67);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(262, 33);
            this.btndelete.TabIndex = 113;
            this.btndelete.Text = "Delete";
            // 
            // dtptime
            // 
            this.dtptime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtptime.Location = new System.Drawing.Point(913, -63);
            this.dtptime.Name = "dtptime";
            this.dtptime.Size = new System.Drawing.Size(234, 26);
            this.dtptime.TabIndex = 112;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
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
            this.dgv.Location = new System.Drawing.Point(0, 239);
            this.dgv.Name = "dgv";
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
            this.dgv.Size = new System.Drawing.Size(1243, 274);
            this.dgv.TabIndex = 134;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(795, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 134;
            this.label3.Text = "اجمالي الوارد :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(1075, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 24);
            this.label5.TabIndex = 135;
            this.label5.Text = "اجمالي المنصرف :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(938, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 24);
            this.label6.TabIndex = 136;
            this.label6.Text = "الرصيد النهائي :";
            // 
            // txtward
            // 
            this.txtward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtward.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtward.ForeColor = System.Drawing.Color.Navy;
            this.txtward.Location = new System.Drawing.Point(738, 75);
            this.txtward.Multiline = true;
            this.txtward.Name = "txtward";
            this.txtward.ReadOnly = true;
            this.txtward.Size = new System.Drawing.Size(247, 57);
            this.txtward.TabIndex = 134;
            this.txtward.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtmonsarf
            // 
            this.txtmonsarf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtmonsarf.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmonsarf.ForeColor = System.Drawing.Color.Navy;
            this.txtmonsarf.Location = new System.Drawing.Point(996, 75);
            this.txtmonsarf.Multiline = true;
            this.txtmonsarf.Name = "txtmonsarf";
            this.txtmonsarf.ReadOnly = true;
            this.txtmonsarf.Size = new System.Drawing.Size(247, 57);
            this.txtmonsarf.TabIndex = 137;
            this.txtmonsarf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbalance
            // 
            this.txtbalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtbalance.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbalance.ForeColor = System.Drawing.Color.Navy;
            this.txtbalance.Location = new System.Drawing.Point(738, 176);
            this.txtbalance.Multiline = true;
            this.txtbalance.Name = "txtbalance";
            this.txtbalance.ReadOnly = true;
            this.txtbalance.Size = new System.Drawing.Size(505, 57);
            this.txtbalance.TabIndex = 138;
            this.txtbalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnexportdatatoexcell
            // 
            this.btnexportdatatoexcell.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexportdatatoexcell.Appearance.Options.UseFont = true;
            this.btnexportdatatoexcell.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnexportdatatoexcell.ImageOptions.Image")));
            this.btnexportdatatoexcell.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnexportdatatoexcell.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnexportdatatoexcell.ImageOptions.SvgImage")));
            this.btnexportdatatoexcell.Location = new System.Drawing.Point(738, 6);
            this.btnexportdatatoexcell.Name = "btnexportdatatoexcell";
            this.btnexportdatatoexcell.Size = new System.Drawing.Size(505, 31);
            this.btnexportdatatoexcell.TabIndex = 136;
            this.btnexportdatatoexcell.Text = "Export Data To Excell";
            // 
            // item_cardscreen
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1255, 525);
            this.Controls.Add(this.btnexportdatatoexcell);
            this.Controls.Add(this.txtbalance);
            this.Controls.Add(this.txtmonsarf);
            this.Controls.Add(this.txtward);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txttotalorder);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.dtptime);
            this.Font = new System.Drawing.Font("Droid Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "item_cardscreen";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "كارت الاصناف -جرد ا";
            this.Load += new System.EventHandler(this.item_cardscreen_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxstore;
        private DevExpress.XtraEditors.SimpleButton btnsearch;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txttotalorder;
        private System.Windows.Forms.TextBox txtitem;
        private DevExpress.XtraEditors.SimpleButton btndelete;
        private System.Windows.Forms.DateTimePicker dtptime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioselectediteminselectedstore;
        private System.Windows.Forms.RadioButton radioallitemsinselectedstore;
        private System.Windows.Forms.DataGridView dgvproducts;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtward;
        private System.Windows.Forms.TextBox txtmonsarf;
        private System.Windows.Forms.TextBox txtbalance;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnexportdatatoexcell;
    }
}
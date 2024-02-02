namespace DXApplication8
{
    partial class transferefrombanktoanother_reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(transferefrombanktoanother_reports));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbxbranch_name = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnalltransfereinselectedbranch = new DevExpress.XtraEditors.SimpleButton();
            this.btnprint = new DevExpress.XtraEditors.SimpleButton();
            this.cbxbank_name = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttotaleda3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnsearch = new DevExpress.XtraEditors.SimpleButton();
            this.dtpto = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpfrom = new System.Windows.Forms.DateTimePicker();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxbranch_name
            // 
            this.cbxbranch_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxbranch_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxbranch_name.BackColor = System.Drawing.Color.White;
            this.cbxbranch_name.ForeColor = System.Drawing.Color.Navy;
            this.cbxbranch_name.FormattingEnabled = true;
            this.cbxbranch_name.Location = new System.Drawing.Point(170, 44);
            this.cbxbranch_name.Name = "cbxbranch_name";
            this.cbxbranch_name.Size = new System.Drawing.Size(257, 27);
            this.cbxbranch_name.TabIndex = 113;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(82, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 23);
            this.label6.TabIndex = 112;
            this.label6.Text = "اختر الفرع :";
            // 
            // btnalltransfereinselectedbranch
            // 
            this.btnalltransfereinselectedbranch.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnalltransfereinselectedbranch.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnalltransfereinselectedbranch.Appearance.Options.UseFont = true;
            this.btnalltransfereinselectedbranch.Appearance.Options.UseForeColor = true;
            this.btnalltransfereinselectedbranch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnalltransfereinselectedbranch.ImageOptions.Image")));
            this.btnalltransfereinselectedbranch.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnalltransfereinselectedbranch.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnalltransfereinselectedbranch.Location = new System.Drawing.Point(9, 113);
            this.btnalltransfereinselectedbranch.Name = "btnalltransfereinselectedbranch";
            this.btnalltransfereinselectedbranch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnalltransfereinselectedbranch.Size = new System.Drawing.Size(418, 47);
            this.btnalltransfereinselectedbranch.TabIndex = 111;
            this.btnalltransfereinselectedbranch.Text = "كل التحويلات في التاريخ المحدد والفرع المحدد";
            this.btnalltransfereinselectedbranch.Click += new System.EventHandler(this.btnalltransfereinselectedbranch_Click);
            // 
            // btnprint
            // 
            this.btnprint.Appearance.Font = new System.Drawing.Font("Droid Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnprint.Appearance.Options.UseFont = true;
            this.btnprint.Appearance.Options.UseForeColor = true;
            this.btnprint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnprint.ImageOptions.Image")));
            this.btnprint.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnprint.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnprint.Location = new System.Drawing.Point(1114, 62);
            this.btnprint.Name = "btnprint";
            this.btnprint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnprint.Size = new System.Drawing.Size(169, 47);
            this.btnprint.TabIndex = 110;
            this.btnprint.Text = "طباعه";
            // 
            // cbxbank_name
            // 
            this.cbxbank_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxbank_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxbank_name.BackColor = System.Drawing.Color.White;
            this.cbxbank_name.ForeColor = System.Drawing.Color.Navy;
            this.cbxbank_name.FormattingEnabled = true;
            this.cbxbank_name.Location = new System.Drawing.Point(170, 80);
            this.cbxbank_name.Name = "cbxbank_name";
            this.cbxbank_name.Size = new System.Drawing.Size(257, 27);
            this.cbxbank_name.TabIndex = 109;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 23);
            this.label4.TabIndex = 108;
            this.label4.Text = "اختر البنك :";
            // 
            // txttotaleda3
            // 
            this.txttotaleda3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txttotaleda3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttotaleda3.ForeColor = System.Drawing.Color.Navy;
            this.txttotaleda3.Location = new System.Drawing.Point(666, 120);
            this.txttotaleda3.Multiline = true;
            this.txttotaleda3.Name = "txttotaleda3";
            this.txttotaleda3.ReadOnly = true;
            this.txttotaleda3.Size = new System.Drawing.Size(617, 40);
            this.txttotaleda3.TabIndex = 107;
            this.txttotaleda3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Droid Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(462, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 36);
            this.label5.TabIndex = 106;
            this.label5.Text = "اجمالي التحويلات :";
            // 
            // btnsearch
            // 
            this.btnsearch.Appearance.Font = new System.Drawing.Font("Droid Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnsearch.Appearance.Options.UseFont = true;
            this.btnsearch.Appearance.Options.UseForeColor = true;
            this.btnsearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsearch.ImageOptions.Image")));
            this.btnsearch.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnsearch.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnsearch.Location = new System.Drawing.Point(967, 62);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnsearch.Size = new System.Drawing.Size(141, 47);
            this.btnsearch.TabIndex = 100;
            this.btnsearch.Text = "بحث";
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // dtpto
            // 
            this.dtpto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpto.Location = new System.Drawing.Point(757, 72);
            this.dtpto.Name = "dtpto";
            this.dtpto.Size = new System.Drawing.Size(165, 26);
            this.dtpto.TabIndex = 101;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(720, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 23);
            this.label3.TabIndex = 103;
            this.label3.Text = "الي";
            // 
            // dtpfrom
            // 
            this.dtpfrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfrom.Location = new System.Drawing.Point(523, 73);
            this.dtpfrom.Name = "dtpfrom";
            this.dtpfrom.Size = new System.Drawing.Size(148, 26);
            this.dtpfrom.TabIndex = 99;
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Droid Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Location = new System.Drawing.Point(9, 166);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1334, 366);
            this.dgv.TabIndex = 105;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(489, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 23);
            this.label2.TabIndex = 102;
            this.label2.Text = "من";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(490, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 34);
            this.label1.TabIndex = 104;
            this.label1.Text = "تقارير التحويلات بين البنوك";
            // 
            // transferefrombanktoanother_reports
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1352, 537);
            this.Controls.Add(this.cbxbranch_name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnalltransfereinselectedbranch);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.cbxbank_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttotaleda3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.dtpto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpfrom);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Droid Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "transferefrombanktoanother_reports";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تحويلات بين البنوك وبعضها";
            this.Load += new System.EventHandler(this.transferefrombanktoanother_reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxbranch_name;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton btnalltransfereinselectedbranch;
        private DevExpress.XtraEditors.SimpleButton btnprint;
        private System.Windows.Forms.ComboBox cbxbank_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttotaleda3;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton btnsearch;
        private System.Windows.Forms.DateTimePicker dtpto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpfrom;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
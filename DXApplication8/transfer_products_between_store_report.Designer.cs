namespace DXApplication8
{
    partial class transfer_products_between_store_report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(transfer_products_between_store_report));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.dtpfrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpto = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.radiofromstoretostore = new System.Windows.Forms.RadioButton();
            this.radioalltransferes = new System.Windows.Forms.RadioButton();
            this.cbxstore1 = new System.Windows.Forms.ComboBox();
            this.btnprint = new DevExpress.XtraEditors.SimpleButton();
            this.btnsearch = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxstoreto = new System.Windows.Forms.ComboBox();
            this.radiotransfereoneproduct = new System.Windows.Forms.RadioButton();
            this.cbxproduct = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblqty = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
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
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Location = new System.Drawing.Point(9, 158);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1348, 364);
            this.dgv.TabIndex = 53;
            // 
            // dtpfrom
            // 
            this.dtpfrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfrom.Location = new System.Drawing.Point(911, 70);
            this.dtpfrom.Name = "dtpfrom";
            this.dtpfrom.Size = new System.Drawing.Size(138, 26);
            this.dtpfrom.TabIndex = 135;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(675, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 23);
            this.label3.TabIndex = 134;
            this.label3.Text = "من :";
            // 
            // dtpto
            // 
            this.dtpto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpto.Location = new System.Drawing.Point(717, 71);
            this.dtpto.Name = "dtpto";
            this.dtpto.Size = new System.Drawing.Size(132, 26);
            this.dtpto.TabIndex = 133;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(862, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 23);
            this.label6.TabIndex = 132;
            this.label6.Text = "الي :";
            // 
            // radiofromstoretostore
            // 
            this.radiofromstoretostore.AutoSize = true;
            this.radiofromstoretostore.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiofromstoretostore.ForeColor = System.Drawing.Color.Navy;
            this.radiofromstoretostore.Location = new System.Drawing.Point(32, 71);
            this.radiofromstoretostore.Name = "radiofromstoretostore";
            this.radiofromstoretostore.Size = new System.Drawing.Size(149, 25);
            this.radiofromstoretostore.TabIndex = 131;
            this.radiofromstoretostore.TabStop = true;
            this.radiofromstoretostore.Text = "من مخزن الي مخزن اخر";
            this.radiofromstoretostore.UseVisualStyleBackColor = true;
            // 
            // radioalltransferes
            // 
            this.radioalltransferes.AutoSize = true;
            this.radioalltransferes.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioalltransferes.ForeColor = System.Drawing.Color.Navy;
            this.radioalltransferes.Location = new System.Drawing.Point(31, 102);
            this.radioalltransferes.Name = "radioalltransferes";
            this.radioalltransferes.Size = new System.Drawing.Size(101, 25);
            this.radioalltransferes.TabIndex = 130;
            this.radioalltransferes.TabStop = true;
            this.radioalltransferes.Text = "كل التحويلات ";
            this.radioalltransferes.UseVisualStyleBackColor = true;
            // 
            // cbxstore1
            // 
            this.cbxstore1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxstore1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxstore1.BackColor = System.Drawing.Color.White;
            this.cbxstore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxstore1.ForeColor = System.Drawing.Color.Navy;
            this.cbxstore1.FormattingEnabled = true;
            this.cbxstore1.Location = new System.Drawing.Point(242, 71);
            this.cbxstore1.Name = "cbxstore1";
            this.cbxstore1.Size = new System.Drawing.Size(167, 28);
            this.cbxstore1.TabIndex = 129;
            // 
            // btnprint
            // 
            this.btnprint.Appearance.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.btnprint.Appearance.Options.UseFont = true;
            this.btnprint.Appearance.Options.UseForeColor = true;
            this.btnprint.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btnprint.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnprint.ImageOptions.SvgImage")));
            this.btnprint.Location = new System.Drawing.Point(1208, 56);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(138, 49);
            this.btnprint.TabIndex = 137;
            this.btnprint.Text = "طباعه تقرير";
            // 
            // btnsearch
            // 
            this.btnsearch.Appearance.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.btnsearch.Appearance.Options.UseFont = true;
            this.btnsearch.Appearance.Options.UseForeColor = true;
            this.btnsearch.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btnsearch.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnsearch.ImageOptions.SvgImage")));
            this.btnsearch.Location = new System.Drawing.Point(1055, 58);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(143, 47);
            this.btnsearch.TabIndex = 136;
            this.btnsearch.Text = "بحث";
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(199, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 23);
            this.label1.TabIndex = 138;
            this.label1.Text = "من :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(415, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 23);
            this.label2.TabIndex = 139;
            this.label2.Text = "الي :";
            // 
            // cbxstoreto
            // 
            this.cbxstoreto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxstoreto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxstoreto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cbxstoreto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxstoreto.ForeColor = System.Drawing.Color.Navy;
            this.cbxstoreto.FormattingEnabled = true;
            this.cbxstoreto.Location = new System.Drawing.Point(456, 72);
            this.cbxstoreto.Name = "cbxstoreto";
            this.cbxstoreto.Size = new System.Drawing.Size(200, 28);
            this.cbxstoreto.TabIndex = 140;
            // 
            // radiotransfereoneproduct
            // 
            this.radiotransfereoneproduct.AutoSize = true;
            this.radiotransfereoneproduct.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiotransfereoneproduct.ForeColor = System.Drawing.Color.Navy;
            this.radiotransfereoneproduct.Location = new System.Drawing.Point(31, 128);
            this.radiotransfereoneproduct.Name = "radiotransfereoneproduct";
            this.radiotransfereoneproduct.Size = new System.Drawing.Size(129, 25);
            this.radiotransfereoneproduct.TabIndex = 141;
            this.radiotransfereoneproduct.TabStop = true;
            this.radiotransfereoneproduct.Text = "تحويلات صنف محدد";
            this.radiotransfereoneproduct.UseVisualStyleBackColor = true;
            // 
            // cbxproduct
            // 
            this.cbxproduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxproduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxproduct.BackColor = System.Drawing.Color.White;
            this.cbxproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxproduct.ForeColor = System.Drawing.Color.Navy;
            this.cbxproduct.FormattingEnabled = true;
            this.cbxproduct.Location = new System.Drawing.Point(170, 124);
            this.cbxproduct.Name = "cbxproduct";
            this.cbxproduct.Size = new System.Drawing.Size(167, 28);
            this.cbxproduct.TabIndex = 142;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(360, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 23);
            this.label4.TabIndex = 143;
            this.label4.Text = "الكميه :";
            // 
            // lblqty
            // 
            this.lblqty.AutoSize = true;
            this.lblqty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblqty.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqty.ForeColor = System.Drawing.Color.Blue;
            this.lblqty.Location = new System.Drawing.Point(426, 129);
            this.lblqty.Name = "lblqty";
            this.lblqty.Size = new System.Drawing.Size(21, 23);
            this.lblqty.TabIndex = 144;
            this.lblqty.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(547, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 25);
            this.label5.TabIndex = 145;
            this.label5.Text = "تقارير التحويلات بين المخازن";
            // 
            // transfer_products_between_store_report
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1358, 522);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblqty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxproduct);
            this.Controls.Add(this.radiotransfereoneproduct);
            this.Controls.Add(this.cbxstoreto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.dtpfrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radiofromstoretostore);
            this.Controls.Add(this.radioalltransferes);
            this.Controls.Add(this.cbxstore1);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "transfer_products_between_store_report";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقارير نقل المنتجات بين المخازن";
            this.Load += new System.EventHandler(this.transfer_products_between_store_report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DateTimePicker dtpfrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radiofromstoretostore;
        private System.Windows.Forms.RadioButton radioalltransferes;
        private System.Windows.Forms.ComboBox cbxstore1;
        private DevExpress.XtraEditors.SimpleButton btnprint;
        private DevExpress.XtraEditors.SimpleButton btnsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxstoreto;
        private System.Windows.Forms.RadioButton radiotransfereoneproduct;
        private System.Windows.Forms.ComboBox cbxproduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblqty;
        private System.Windows.Forms.Label label5;
    }
}
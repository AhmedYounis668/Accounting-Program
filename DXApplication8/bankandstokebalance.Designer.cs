namespace DXApplication8
{
    partial class bankandstokebalance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bankandstokebalance));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxstkes = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbltotalbalancestoke = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbltotalbalancebank = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxbankes = new System.Windows.Forms.ComboBox();
            this.radiostokes = new System.Windows.Forms.RadioButton();
            this.radiobankes = new System.Windows.Forms.RadioButton();
            this.btnsearch = new DevExpress.XtraEditors.SimpleButton();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "الاستعلام عن رصيدالخزنه والبنك";
            // 
            // cbxstkes
            // 
            this.cbxstkes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxstkes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxstkes.FormattingEnabled = true;
            this.cbxstkes.Location = new System.Drawing.Point(8, 40);
            this.cbxstkes.Name = "cbxstkes";
            this.cbxstkes.Size = new System.Drawing.Size(439, 36);
            this.cbxstkes.TabIndex = 2;
            this.cbxstkes.SelectionChangeCommitted += new System.EventHandler(this.cbxstkes_SelectionChangeCommitted);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.lbltotalbalancestoke);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbxstkes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 146);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الاستعلام عن رصيد الخزنه";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "اختر الخزنه :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "اختر البنك :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "رصيد الخزنه المحدده :";
            // 
            // lbltotalbalancestoke
            // 
            this.lbltotalbalancestoke.AutoSize = true;
            this.lbltotalbalancestoke.Location = new System.Drawing.Point(254, 93);
            this.lbltotalbalancestoke.Name = "lbltotalbalancestoke";
            this.lbltotalbalancestoke.Size = new System.Drawing.Size(23, 28);
            this.lbltotalbalancestoke.TabIndex = 7;
            this.lbltotalbalancestoke.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Controls.Add(this.lbltotalbalancebank);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbxbankes);
            this.groupBox2.Location = new System.Drawing.Point(12, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(569, 146);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "الاستعلام عن رصيد البنك";
            // 
            // lbltotalbalancebank
            // 
            this.lbltotalbalancebank.AutoSize = true;
            this.lbltotalbalancebank.Location = new System.Drawing.Point(254, 92);
            this.lbltotalbalancebank.Name = "lbltotalbalancebank";
            this.lbltotalbalancebank.Size = new System.Drawing.Size(23, 28);
            this.lbltotalbalancebank.TabIndex = 7;
            this.lbltotalbalancebank.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(395, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 28);
            this.label7.TabIndex = 6;
            this.label7.Text = "رصيد البنك المحدد :";
            // 
            // cbxbankes
            // 
            this.cbxbankes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxbankes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxbankes.FormattingEnabled = true;
            this.cbxbankes.Location = new System.Drawing.Point(8, 40);
            this.cbxbankes.Name = "cbxbankes";
            this.cbxbankes.Size = new System.Drawing.Size(439, 36);
            this.cbxbankes.TabIndex = 2;
            this.cbxbankes.SelectionChangeCommitted += new System.EventHandler(this.cbxbankes_SelectionChangeCommitted);
            // 
            // radiostokes
            // 
            this.radiostokes.AutoSize = true;
            this.radiostokes.Location = new System.Drawing.Point(642, 37);
            this.radiostokes.Name = "radiostokes";
            this.radiostokes.Size = new System.Drawing.Size(153, 32);
            this.radiostokes.TabIndex = 9;
            this.radiostokes.TabStop = true;
            this.radiostokes.Text = "بحث عن كل الخزن";
            this.radiostokes.UseVisualStyleBackColor = true;
            // 
            // radiobankes
            // 
            this.radiobankes.AutoSize = true;
            this.radiobankes.Location = new System.Drawing.Point(866, 37);
            this.radiobankes.Name = "radiobankes";
            this.radiobankes.Size = new System.Drawing.Size(161, 32);
            this.radiobankes.TabIndex = 10;
            this.radiobankes.TabStop = true;
            this.radiobankes.Text = "بحث عن كل البنوك";
            this.radiobankes.UseVisualStyleBackColor = true;
            // 
            // btnsearch
            // 
            this.btnsearch.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Appearance.Options.UseFont = true;
            this.btnsearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnsearch.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnsearch.Location = new System.Drawing.Point(587, 75);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(490, 36);
            this.btnsearch.TabIndex = 11;
            this.btnsearch.Text = "بحث";
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.GridColor = System.Drawing.Color.Navy;
            this.dgv.Location = new System.Drawing.Point(587, 117);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Navy;
            this.dgv.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dgv.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Navy;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(490, 259);
            this.dgv.TabIndex = 49;
            // 
            // bankandstokebalance
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1089, 380);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.radiobankes);
            this.Controls.Add(this.radiostokes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "bankandstokebalance";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الاستعلام عن رصيد الخزنه والبنك";
            this.Load += new System.EventHandler(this.bankandstokebalance_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxstkes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbltotalbalancestoke;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbltotalbalancebank;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxbankes;
        private System.Windows.Forms.RadioButton radiostokes;
        private System.Windows.Forms.RadioButton radiobankes;
        private DevExpress.XtraEditors.SimpleButton btnsearch;
        private System.Windows.Forms.DataGridView dgv;
    }
}
﻿namespace DXApplication8
{
    partial class buy_returns_report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buy_returns_report));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txttotalreturns = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnsearch = new DevExpress.XtraEditors.SimpleButton();
            this.cbxbranchname = new System.Windows.Forms.ComboBox();
            this.dtpto = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpfrom = new System.Windows.Forms.DateTimePicker();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnprint = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // txttotalreturns
            // 
            this.txttotalreturns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txttotalreturns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttotalreturns.ForeColor = System.Drawing.Color.Navy;
            this.txttotalreturns.Location = new System.Drawing.Point(284, 125);
            this.txttotalreturns.Multiline = true;
            this.txttotalreturns.Name = "txttotalreturns";
            this.txttotalreturns.ReadOnly = true;
            this.txttotalreturns.Size = new System.Drawing.Size(938, 40);
            this.txttotalreturns.TabIndex = 66;
            this.txttotalreturns.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Droid Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 36);
            this.label5.TabIndex = 65;
            this.label5.Text = "اجمالي مبالغ المرتجعات";
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
            this.btnsearch.Location = new System.Drawing.Point(979, 67);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnsearch.Size = new System.Drawing.Size(141, 47);
            this.btnsearch.TabIndex = 57;
            this.btnsearch.Text = "بحث";
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // cbxbranchname
            // 
            this.cbxbranchname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxbranchname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxbranchname.BackColor = System.Drawing.Color.White;
            this.cbxbranchname.ForeColor = System.Drawing.Color.Navy;
            this.cbxbranchname.FormattingEnabled = true;
            this.cbxbranchname.Location = new System.Drawing.Point(185, 79);
            this.cbxbranchname.Name = "cbxbranchname";
            this.cbxbranchname.Size = new System.Drawing.Size(257, 27);
            this.cbxbranchname.TabIndex = 64;
            // 
            // dtpto
            // 
            this.dtpto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpto.Location = new System.Drawing.Point(769, 77);
            this.dtpto.Name = "dtpto";
            this.dtpto.Size = new System.Drawing.Size(165, 26);
            this.dtpto.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Droid Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(710, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 33);
            this.label3.TabIndex = 60;
            this.label3.Text = "الي";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Droid Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 33);
            this.label6.TabIndex = 61;
            this.label6.Text = "اختر الفرع :";
            // 
            // dtpfrom
            // 
            this.dtpfrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfrom.Location = new System.Drawing.Point(535, 78);
            this.dtpfrom.Name = "dtpfrom";
            this.dtpfrom.Size = new System.Drawing.Size(148, 26);
            this.dtpfrom.TabIndex = 56;
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
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Location = new System.Drawing.Point(2, 167);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1294, 373);
            this.dgv.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Droid Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(474, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 33);
            this.label2.TabIndex = 59;
            this.label2.Text = "من";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(502, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 34);
            this.label1.TabIndex = 62;
            this.label1.Text = "تقارير مرتجعات المشتريات ";
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
            this.btnprint.Location = new System.Drawing.Point(1126, 67);
            this.btnprint.Name = "btnprint";
            this.btnprint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnprint.Size = new System.Drawing.Size(141, 47);
            this.btnprint.TabIndex = 67;
            this.btnprint.Text = "طباعه";
            // 
            // buy_returns_report
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1300, 543);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.txttotalreturns);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.cbxbranchname);
            this.Controls.Add(this.dtpto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpfrom);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Droid Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "buy_returns_report";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقارير مرتجعات المشتريات";
            this.Load += new System.EventHandler(this.buy_returns_report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttotalreturns;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton btnsearch;
        private System.Windows.Forms.ComboBox cbxbranchname;
        private System.Windows.Forms.DateTimePicker dtpto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpfrom;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnprint;
    }
}
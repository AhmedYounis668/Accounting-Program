using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DXApplication8
{
    public partial class transferefrombanktoanother_reports : DevExpress.XtraEditors.XtraForm
    {
        public transferefrombanktoanother_reports()
        {
            InitializeComponent();
        }

        DataTable tbl = new DataTable();
        database db = new database();

        private void fillcbx()
        {
            cbxbranch_name.DataSource = db.readdata("select*from branches", "");
            cbxbranch_name.DisplayMember = "branch_name";
            cbxbranch_name.ValueMember = "branch_id";

            cbxbank_name.DataSource = db.readdata("select*from bankes", "");
            cbxbank_name.DisplayMember = "bank_name";
            cbxbank_name.ValueMember = "bank_id";
        }


        private void transferefrombanktoanother_reports_Load(object sender, EventArgs e)
        {
            fillcbx();
            dtpfrom.Text = DateTime.Now.ToShortDateString();
            dtpto.Text = DateTime.Now.ToShortDateString();
        }

        private void total()
        {
            decimal total = 0;
            for (int i = 0; i <= dgv.Rows.Count - 1; i++)
            {
                total += Convert.ToDecimal(dgv.Rows[i].Cells[2].Value);
            }
            txttotaleda3.Text = total.ToString();
        }
            private void btnsearch_Click(object sender, EventArgs e)
        {
            string dfrom = "", dto = "";
            dfrom = dtpfrom.Value.ToString("yyyy-MM-dd");
            dto = dtpto.Value.ToString("yyyy-MM-dd");
            tbl.Clear();
            tbl = db.readdata("select order_id as 'رقم البيان',bankfrom_name as 'البنك المحول منه',money as 'المبلغ المحول',bankto_name as 'البنك المحول اليه',name as 'المسؤل عن التحويل',transferefrombanktobank.notes as 'السبب',type as 'نوع التحويل',transferefrombanktobank.user_name as 'المستخدم',transferefrombanktobank.branch_name as 'الفرع' from transferefrombanktobank where  transferefrombanktobank.bankfrom_id="+cbxbank_name.SelectedValue+" and convert(nvarchar,transferefrombanktobank.date,105)between N'"+dfrom+"' and N'"+dto+ "' and  branch_name=N'" + cbxbranch_name.Text + "'", "");
            dgv.DataSource = tbl;
            total();
        }

        private void btnalltransfereinselectedbranch_Click(object sender, EventArgs e)
        {
            string dfrom = "", dto = "";
            dfrom = dtpfrom.Value.ToString("yyyy-MM-dd");
            dto = dtpto.Value.ToString("yyyy-MM-dd");
            tbl.Clear();
            tbl = db.readdata("select order_id as 'رقم البيان',bankfrom_name as 'البنك المحول منه',money as 'المبلغ المحول',bankto_name as 'البنك المحول اليه',name as 'المسؤل عن التحويل',transferefrombanktobank.notes as 'السبب',type as 'نوع التحويل',transferefrombanktobank.user_name as 'المستخدم',transferefrombanktobank.branch_name as 'الفرع' from transferefrombanktobank where   branch_name=N'"+cbxbranch_name.Text+"' and convert(nvarchar,transferefrombanktobank.date,105)between N'" + dfrom + "' and N'" + dto + "'", "");
            dgv.DataSource = tbl;
            total();
        }
    }
}
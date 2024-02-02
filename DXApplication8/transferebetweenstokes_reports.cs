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
    public partial class transferebetweenstokes_reports : DevExpress.XtraEditors.XtraForm
    {
        public transferebetweenstokes_reports()
        {
            InitializeComponent();
        }

        DataTable tbl = new DataTable();
        database db = new database();
        private void fillcbx()
        {
           
            cbxstoke_name.DataSource = db.readdata("select*from stokes", "");
            cbxstoke_name.DisplayMember = "stoke_name";
            cbxstoke_name.ValueMember = "stoke_id";

            cbxbranch_name.DataSource = db.readdata("select*from branches", "");
            cbxbranch_name.DisplayMember = "branch_name";
            cbxbranch_name.ValueMember = "branch_id";
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
        private void transferebetweenstokes_reports_Load(object sender, EventArgs e)
        {
            fillcbx();
            dtpfrom.Text = DateTime.Now.ToShortDateString();
            dtpto.Text = DateTime.Now.ToShortDateString();

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string from = "", to = "";
            from = dtpfrom.Value.ToString("yyyy-MM-dd");
            to = dtpto.Value.ToString("yyyy-MM-dd");
            tbl.Clear();
            tbl = db.readdata("select order_id as 'رقم البيان',stokefrom_name as 'محول من',money as 'المبلغ',stoketo_name as 'محول الي',date as 'التاريخ',note_row as 'ملاحظه العمليه',notes as 'ملاحظات',user_name as 'المستخدم',branch_name as 'الفرع',row_nomber as 'رقم الصف' from transferebetweenstokes where stokefrom_id=" + cbxstoke_name.SelectedValue + "   and convert(nvarchar,date,105)between N'" + from + "' and N'" + to + "'", "");
            dgv.DataSource = tbl;
            total();
        }

        private void btnalltransfereinselectedbranch_Click(object sender, EventArgs e)
        {
            string from = "", to = "";
            from = dtpfrom.Value.ToString("yyyy-MM-dd");
            to = dtpto.Value.ToString("yyyy-MM-dd");
            tbl.Clear();
            tbl = db.readdata("select order_id as 'رقم البيان',stokefrom_name as 'محول من',money as 'المبلغ',stoketo_name as 'محول الي',date as 'التاريخ',note_row as 'ملاحظه العمليه',notes as 'ملاحظات',user_name as 'المستخدم',branch_name as 'الفرع',row_nomber as 'رقم الصف' from transferebetweenstokes where branch_name=N'"+cbxbranch_name.Text.Trim()+"'   and convert(nvarchar,date,105)between N'" + from + "' and N'" + to + "'", "");
            dgv.DataSource = tbl;
            total();
        }
    }
}
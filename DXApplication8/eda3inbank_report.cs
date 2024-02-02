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
    public partial class eda3inbank_report : DevExpress.XtraEditors.XtraForm
    {
        public eda3inbank_report()
        {
            InitializeComponent();
        }

        //cal database class
        DataTable tbl = new DataTable();
        database db = new database();

        //fill combobox with bankes data and branches
        private void fillcbx()
        {
            cbxbranchname.DataSource = db.readdata("select*from branches", "");
            cbxbranchname.DisplayMember = "branch_name";
            cbxbranchname.ValueMember = "branch_id";

            cbxstoke_name.DataSource = db.readdata("select*from bankes", "");
            cbxstoke_name.DisplayMember = "bank_name";
            cbxstoke_name.ValueMember = "bank_id";
        }
        //func to get total deposits in the selected bank
        private void total()
        {
            decimal total = 0;
            for (int i = 0; i <= dgv.Rows.Count - 1; i++)
            {
                total += Convert.ToDecimal(dgv.Rows[i].Cells[4].Value);
            }
            txttotaleda3.Text = total.ToString();
        }
        private void eda3inbank_report_Load(object sender, EventArgs e)
        {
            fillcbx();
            dtpfrom.Text = DateTime.Now.ToShortDateString();
            dtpto.Text = DateTime.Now.ToShortDateString();
        }
        //search about deposits in the selected bank and between two dates and get total between this time
        private void btnsearch_Click(object sender, EventArgs e)
        {
            string from = "", to = "";
            from = dtpfrom.Value.ToString("yyyy-MM-dd");
            to = dtpto.Value.ToString("yyyy-MM-dd");
            tbl.Clear();
            tbl = db.readdata("select order_id as 'رقم البيان',bankes.bank_name as'البنك',name as 'البيان',type as 'نوع البيان',money as 'المبلغ',bank_insert.notes as 'ملاحظات',bank_insert.date as 'التاريخ',bank_insert.user_name as'المستخدم',bank_insert.branch_name as 'الفرع' from bank_insert,bankes where bankes.bank_id=bank_insert.bank_id and bank_insert.bank_id="+cbxstoke_name.SelectedValue+" and convert(nvarchar,bank_insert.date,105)between N'"+from+"' and N'"+to+"' and bank_insert.branch_name=N'"+cbxbranchname.Text.Trim()+"'", "");
            dgv.DataSource = tbl;
            total();
        }
    }
}
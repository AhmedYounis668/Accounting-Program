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
    public partial class withdrowalfrombank_report : DevExpress.XtraEditors.XtraForm
    {
        public withdrowalfrombank_report()
        {
            InitializeComponent();
        }
        //call database class
        DataTable tbl = new DataTable();
        database db = new database();

        //fill combobox with bankes and branches
        private void fillcbx()
        {
            cbxbank_name.DataSource = db.readdata("select*from bankes", "");
            cbxbank_name.DisplayMember = "bank_name";
            cbxbank_name.ValueMember = "bank_id";

            cbxbranchname.DataSource = db.readdata("select*from branches","");
            cbxbranchname.DisplayMember = "branch_name";
            cbxbranchname.ValueMember = "branch_id";
        }
        private void withdrowalfrombank_report_Load(object sender, EventArgs e)
        {
            fillcbx();
            dtpfrom.Text = DateTime.Now.ToShortDateString();
            dtpto.Text = DateTime.Now.ToShortDateString();
        }
        //get total of withdrwal in bank
        private void total()
        {
            decimal total = 0;
            for(int i=0;i<=dgv.Rows.Count-1;i++)
            {
                total += Convert.ToDecimal(dgv.Rows[i].Cells[6].Value);
            }
            txttotaleda3.Text = total.ToString();
        }
        //seach about all withdrowal in bank
        private void btnsearch_Click(object sender, EventArgs e)
        {
            string dfrom = "", dto = "";
            dfrom = dtpfrom.Value.ToString("yyyy-MM-dd");
            dto = dtpfrom.Value.ToString("yyyy-MM-dd");
            tbl.Clear();
            tbl = db.readdata("select order_id as 'رقم البيان',bankes.bank_name as 'البنك',bank_money as 'المبلغ قبل السحب',type as 'نوع السحب', bank_withdrowal.notes as'ملاحظات',bank_withdrowal.date as 'تاريخ السحب',money as 'المبلغ المسحوب',bank_withdrowal.user_name as'المستخدم',bank_withdrowal.branch_name as 'الفرع' from bank_withdrowal,bankes where bankes.bank_id=bank_withdrowal.bank_id and bank_withdrowal.bank_id="+cbxbank_name.SelectedValue+" and bank_withdrowal.branch_name=N'"+cbxbranchname.Text.Trim()+"' and convert(nvarchar,bank_withdrowal.date,105)between N'"+dfrom+"' and N'"+dto+"'", "");
            dgv.DataSource = tbl;
            total();
        }
    }
}
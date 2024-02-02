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
    public partial class eda3in_khazna_report : DevExpress.XtraEditors.XtraForm
    {
        public eda3in_khazna_report()
        {
            InitializeComponent();
        }

        //call database class
        DataTable tbl = new DataTable();
        database db = new database();
        //fill combobox with stokes and branches
        private void fillcbx()
        {
            cbxbranchname.DataSource = db.readdata("select*from branches", "");
            cbxbranchname.DisplayMember = "branch_name";
            cbxbranchname.ValueMember = "branch_id";

            cbxstoke_name.DataSource = db.readdata("select*from stokes", "");
            cbxstoke_name.DisplayMember = "stoke_name";
            cbxstoke_name.ValueMember = "stoke_id";
        }
        //func to get total of data shown
        private void total()
        {
            decimal total = 0;
            for(int i=0;i<=dgv.Rows.Count-1;i++)
            {
                total += Convert.ToDecimal(dgv.Rows[i].Cells[5].Value);
            }
            txttotaleda3.Text = total.ToString();
        }
        //search about deposits in stokes
        private void btnsearch_Click(object sender, EventArgs e)
        {
            //formate data to search
            string d1 = dtpfrom.Value.ToString("yyyy-MM-dd");
            string d2 = dtpto.Value.ToString("yyyy-MM-dd");
            //get data selected between this dates and selected stoke and branch
            tbl.Clear();
            tbl = db.readdata("select order_id as 'رقم البيان',stokes.stoke_name as 'اسم الخزنه',stoke_insert.date as 'التاريخ',name as 'البيان',type as 'نوع الايداع',money as 'المبلغ',stoke_insert.notes as 'ملاحظات',stoke_insert.user_name as 'المستخدم',stoke_insert.branch_name as 'الفرع' from stoke_insert,stokes where stoke_insert.stoke_id=stokes.stoke_id and stoke_insert.stoke_id="+cbxstoke_name.SelectedValue+" and stoke_insert.branch_name=N'"+cbxbranchname.Text.Trim()+"' and convert(Nvarchar,stoke_insert.date,105)between N'"+d1+"' and N'"+d2+"'", "");
            dgv.DataSource = tbl;
            total();
        }

        private void eda3in_khazna_report_Load(object sender, EventArgs e)
        {
            dtpfrom.Text = DateTime.Now.ToShortDateString();
            dtpto.Text = DateTime.Now.ToShortDateString();
            fillcbx();
        }
    }
}
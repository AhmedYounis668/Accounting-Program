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
    public partial class withdrowalfromstokereport : DevExpress.XtraEditors.XtraForm
    {
        public withdrowalfromstokereport()
        {
            InitializeComponent();
        }

        //call database class
        DataTable tbl = new DataTable();
        database db = new database();

        //fill combobox with branches and stokes
        private void fillcbx()
        {
            cbxbranchname.DataSource = db.readdata("select*from branches", "");
            cbxbranchname.DisplayMember = "branch_name";
            cbxbranchname.ValueMember = "branch_id";

            cbxstoke_name.DataSource = db.readdata("select*from stokes", "");
            cbxstoke_name.DisplayMember = "stoke_name";
            cbxstoke_name.ValueMember = "stoke_id";
        }

        //get total of withdrowal
        private void total()
        {
            decimal total = 0;
            for (int i = 0; i <= dgv.Rows.Count - 1; i++)
            {
                total += Convert.ToDecimal(dgv.Rows[i].Cells[5].Value);
            }
            txttotaleda3.Text = total.ToString();
        }
        //search about all wthdrowal in selected stoke
        private void btnsearch_Click(object sender, EventArgs e)
        {
            string from = "", to = "";
            from = dtpfrom.Value.ToString("yyyy-MM-dd");
            to = dtpto.Value.ToString("yyyy-MM-dd");
            tbl.Clear();
            tbl = db.readdata("select order_id as 'رقم البيان',stokes.stoke_name as 'اسم الخزنه',stoke_withdrowal.date as 'التاريخ',name as 'البيان',type as 'نوع السحب',money as 'المبلغ',stoke_withdrowal.notes as 'ملاحظات',stoke_withdrowal.user_name as 'المستخدم',stoke_withdrowal.branch_name as 'الفرع' from stoke_withdrowal,stokes where stokes.stoke_id=stoke_withdrowal.stoke_id and stoke_withdrowal.stoke_id="+cbxstoke_name.SelectedValue+" and stoke_withdrowal.branch_name=N'"+cbxbranchname.Text+"' and convert(nvarchar,stoke_withdrowal.date,105)between N'"+from+"' and N'"+to+"' ", "");
            dgv.DataSource = tbl;
            total();
        }

        private void withdrowalfromstokereport_Load(object sender, EventArgs e)
        {
            fillcbx();
            dtpfrom.Text = DateTime.Now.ToShortDateString();
            dtpto.Text = DateTime.Now.ToShortDateString();
        }
    }
}
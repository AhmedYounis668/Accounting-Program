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
    public partial class stokeandbank_transfere_reports : DevExpress.XtraEditors.XtraForm
    {
        public stokeandbank_transfere_reports()
        {
            InitializeComponent();
        }
        //call database class
        DataTable tbl = new DataTable();
        database db = new database();

        //fill combobox of branches
        private void fillcbx()
        {
            cbxbranchname.DataSource = db.readdata("select*from branches", "");
            cbxbranchname.DisplayMember = "branch_name";
            cbxbranchname.ValueMember = "branch_id";
        }

        private void stokeandbank_transfere_reports_Load(object sender, EventArgs e)
        {
            fillcbx();
            dtpfrom.Text= DateTime.Now.ToShortDateString();
            dtpto.Text = DateTime.Now.ToShortDateString();
        }

        //get total of money
        private void total()
        {
            decimal money = 0;
            for (int i = 0; i <= dgv.Rows.Count - 1; i++)
            {
                money += Convert.ToDecimal(dgv.Rows[i].Cells[5].Value);
            }
            txttotaleda3.Text = money.ToString();
        }
        //search
        private void btnsearch_Click(object sender, EventArgs e)
        {
            string dfrom = "", dto = "";
            dfrom = dtpfrom.Value.ToString("yyyy-MM-dd");
            dto = dtpto.Value.ToString("yyyy-MM-dd");

            
            if(radioall.Checked==false&&radiotrnsferefromstoke.Checked==false&&radiotransferefrombank.Checked==false)
            {
                MessageBox.Show("من فضلك حدد عمليه اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //total transfer from stokes
            else if(radiotrnsferefromstoke.Checked==true)
            {
                tbl.Clear();
                tbl = db.readdata("select order_id as 'رقم البيان',stokes.stoke_name as 'الخزنه المحول منها',bankes.bank_name as 'محول الي بنك',type as 'البيييان',stoke_andbank_transfere.date as 'التاريخ',stoke_andbank_transfere.money as 'المبلغ',stoke_andbank_transfere.notes as 'ملاحظات',stoke_andbank_transfere.name as 'المسؤل عن التحويل',stoke_andbank_transfere.user_name as 'المستخدم',stoke_andbank_transfere.branch_name as 'الفرع',typeoperation as 'نوع العمليه' from stoke_andbank_transfere,stokes,bankes where stoke_andbank_transfere.transfrom=stokes.stoke_id and stoke_andbank_transfere.transto=bankes.bank_id and typeoperation=N'تحويل من الخزنه' and stoke_andbank_transfere.branch_name=N'"+cbxbranchname.Text.Trim()+ "' and convert (Nvarchar,stoke_andbank_transfere.date,105)between N'" + dfrom + "' and N'" + dto + "' ", "");
                dgv.DataSource = tbl;
                total();
            }
            //all transfers
            else if(radioall.Checked==true)
            {
                tbl.Clear();
                tbl = db.readdata("select order_id as 'رقم البيان',type as 'البيان',date as 'التاريخ',money as 'المبلغ',typeoperation as 'نوع العمليه',notes as 'ملاحظات',user_name as 'المستخدم',branch_name as 'الفرع' from stoke_andbank_transfere where branch_name=N'"+cbxbranchname.Text.Trim()+"'and convert (Nvarchar,date,105)between N'"+dfrom+"' and N'"+dto+"'", "");
                dgv.DataSource = tbl;
            }
            //total transferes from bankes
            else if(radiotransferefrombank.Checked==true)
            {
                tbl.Clear();
                tbl = db.readdata("select order_id as 'رقم البيان',bankes.bank_name as 'البنك المحول منه',stokes.stoke_name as 'محول الي الخزنه',stoke_andbank_transfere.type as 'البيان',stoke_andbank_transfere.date as 'التاريخ',stoke_andbank_transfere.money as 'المبلغ',stoke_andbank_transfere.notes as 'ملاحظات',stoke_andbank_transfere.name as'المسؤول عن التحويل',stoke_andbank_transfere.user_name as 'المستخدم',stoke_andbank_transfere.branch_name as'الفرع',typeoperation as'نوع العمليه' from stoke_andbank_transfere,bankes,stokes where stoke_andbank_transfere.transfrom=bankes.bank_id and stoke_andbank_transfere.transto=stokes.stoke_id and typeoperation=N'تحويل من البنك' and stoke_andbank_transfere.branch_name=N'" + cbxbranchname.Text.Trim()+ "' and convert(nvarchar,stoke_andbank_transfere.date,105)between N'"+dfrom+"' and N'"+dto+"'", "");
                dgv.DataSource = tbl;
                total();
            }

        }
    }
}
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
    public partial class withdrowalfrombank : DevExpress.XtraEditors.XtraForm
    {
        public withdrowalfrombank()
        {
            InitializeComponent();
        }
        //call database class
        DataTable tbl = new DataTable();
        database db = new database();

        //clear data after any action
        private void autnumber()
        {
            numericaddnewbalance.Value = 0;
            txteda3reason.Clear();
            txtnamemode3.Clear();
        }

        //fill combobox with bankes
        private void fillcbx()
        {
            cbxbankname.DataSource = db.readdata("select*from bankes", "");
            cbxbankname.DisplayMember = "bank_name";
            cbxbankname.ValueMember = "bank_id";
        }



        private void withdrowalfrombank_Load(object sender, EventArgs e)
        {
            dtpdate.Text = DateTime.Now.ToShortDateString();
            fillcbx();
        }

        //get total in selected bank when user choose
        private void cbxbankname_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readdata("select*from bank_money where bank_id=" + cbxbankname.SelectedValue + "", "");
            if (tbl.Rows.Count <= 0)
            {
                db.excutedata("insert into bank_money values(" + cbxbankname.SelectedValue + ",'0')", "");
                tbl = db.readdata("select*from bank_money where bank_id=" + cbxbankname.SelectedValue + "", "");
            }
            if (Convert.ToDecimal(tbl.Rows[0][1]) <= 0)
            {
                lbltotalbank.Text = Convert.ToDecimal(tbl.Rows[0][1]).ToString();
            }
            else if (Convert.ToDecimal(tbl.Rows[0][1]) >= 1)
            {
                lbltotalbank.Text = Convert.ToDecimal(tbl.Rows[0][1]).ToString();
            }
        }

        //add
        private void btnadd_Click(object sender, EventArgs e)
        {
            //validations to add
            if (Convert.ToDecimal(lbltotalbank.Text) < numericaddnewbalance.Value)
            {
                MessageBox.Show("المبلغ المراد سحبه اكبر من المبلغ الموجود في الخزنه من فضلك راجع بياناتك", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (numericaddnewbalance.Value <= 0)
            {
                MessageBox.Show("لايجب ان تكون القيمه المسحوبه اصغر من اوتساوي صفر  0", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtnamemode3.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم المسؤل عن السحب اولا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string d1 = "";
            d1 = dtpdate.Value.ToString("yyyy-MM-dd");
            //update money in bank
            db.excutedata("update bank_money set money=money-" + numericaddnewbalance.Value + "where bank_id=" + cbxbankname.SelectedValue + "", "");
            //insert money in bank insert
            db.excutedata("insert into bank_withdrowal(bank_id,bank_money,money,date,name,type,notes,user_name,branch_name)values(" + cbxbankname.SelectedValue + ","+lbltotalbank.Text+"," + numericaddnewbalance.Value + ",'" + d1 + "',N'" + txtnamemode3.Text + "',N'سحب كاش من البنك مباشر',N'" + txteda3reason.Text + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "')", "تم السحب بنجاح");
            autnumber();
            lbltotalbank.Text = "..........";
        }
    }
}
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
    public partial class bank_insert : DevExpress.XtraEditors.XtraForm
    {
        public bank_insert()
        {
            InitializeComponent();
        }

        //call database class
        DataTable tbl = new DataTable();
        database db = new database();

        //get the balance of money for the banck that chooses
        private void balancebank()
        {
            //ge the bank oney that bank selected
            tbl.Clear();
            tbl = db.readdata("select*from bank_money where bank_id=" + cbxbankname.SelectedValue + "", "");
            if (tbl.Rows.Count <= 0)
            {
                //if thier not data in the bank updte it and set money for it
                db.excutedata("insert into bank_money values(" + cbxbankname.SelectedValue + ",'0')", "");
                tbl.Clear();
                tbl = db.readdata("select*from bank_money where bank_id=" + cbxbankname.SelectedValue + "", "");

            }
            //if there not money in the bank selected set label the show the money =0
            if (Convert.ToDecimal(tbl.Rows[0][1]) <= 0)
            {
                lbltotal_bankbalance.Text = "0";
            }
            else if (Convert.ToDecimal(tbl.Rows[0][1]) >= 1)
            {
                //if thiere money show it inte label that show the money of selected bank
                lbltotal_bankbalance.Text = Convert.ToDecimal(tbl.Rows[0][1]).ToString();
            }
            //clear the user data after insert
            numericaddnewbalance.Value = 0;
            txtnamemode3.Clear();
            txteda3reason.Clear();
        }
 //fill combobox with bankes data from bankes table
        private void fillcbx()
        {
            cbxbankname.DataSource = db.readdata("select*from bankes", "");
            cbxbankname.DisplayMember = "bank_name";
            cbxbankname.ValueMember = "bank_id";
        }
        private void bank_insert_Load(object sender, EventArgs e)
        {
            dtpdate.Text = DateTime.Now.ToShortDateString();
            numericaddnewbalance.Focus();
            fillcbx();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            //add validation
            if (numericaddnewbalance.Value <= 0)
            {
                MessageBox.Show("من فضلك لايجب ان يكون الايداع المضاف اقل من او يساوي صفر ......تاكد من بياناتك اولا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (txtnamemode3.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم المودع اولا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //set formate date

            string d = "";
            d = dtpdate.Value.ToString("yyyy-MM-dd");
            //update banke_money
            db.excutedata("update bank_money set money=money+" + numericaddnewbalance.Value + " where bank_id=" + cbxbankname.SelectedValue + "", "");
            //insert data in bank_insert
            db.excutedata("insert into bank_insert(bank_id,money,date,name,type,notes,user_name,branch_name)values("+cbxbankname.SelectedValue+"," + numericaddnewbalance.Value + ",'" + d + "',N'" + txtnamemode3.Text + "',N'ايداع بنكي',N'" + txteda3reason.Text + "',N'" +Properties.Settings.Default.user_name+ "',N'"+Properties.Settings.Default.branch_name+"')", "تم الايداع البنكي بنجاح");
            //show bank balnace from this fanc
            balancebank();
        }

        //when chooce the bank show the balance of selected bank
        private void cbxbankname_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                tbl.Clear();
                tbl = db.readdata("select*from bank_money where bank_id=" + cbxbankname.SelectedValue + "", "");
                if (tbl.Rows.Count <= 0)
                {
                    db.excutedata("insert into bank_money values(" + cbxbankname.SelectedValue + ",'0')", "");
                    tbl.Clear();
                    tbl = db.readdata("select*from bank_money where bank_id=" + cbxbankname.SelectedValue + "", "");

                }
                if (Convert.ToDecimal(tbl.Rows[0][1]) == 0)
                {
                    lbltotal_bankbalance.Text = "0";
                }
                else if (Convert.ToDecimal(tbl.Rows[0][1]) >= 1)
                {
                    lbltotal_bankbalance.Text = Convert.ToDecimal(tbl.Rows[0][1]).ToString();
                }

            }
            catch (Exception)
            {

            }
        }
    }
}
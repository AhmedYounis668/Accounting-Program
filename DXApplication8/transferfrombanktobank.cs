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
    public partial class transferfrombanktobank : DevExpress.XtraEditors.XtraForm
    {
        public transferfrombanktobank()
        {
            InitializeComponent();
        }

        DataTable tbl = new DataTable();
        database db = new database();

        private void fillcbx()
        {
            cbxbankfrom.DataSource = db.readdata("select*from bankes", "");
            cbxbankfrom.DisplayMember = "bank_name";
            cbxbankfrom.ValueMember = "bank_id";

            cbxbankto.DataSource = db.readdata("select*from bankes", "");
            cbxbankto.DisplayMember = "bank_name";
            cbxbankto.ValueMember = "bank_id";

        }
        private void transferfrombanktobank_Load(object sender, EventArgs e)
        {
            fillcbx();
            dtpdate.Text = DateTime.Now.ToShortDateString();

        }

        private void cbxbankfrom_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readdata("select*from bank_money where bank_id=" + cbxbankfrom.SelectedValue + "", "");
            if (tbl.Rows.Count <= 0)
            {
                db.excutedata("insert into bank_money values(" + cbxbankfrom.SelectedValue + ",'0')", "");
                tbl = db.readdata("select*from bank_money where bank_id=" + cbxbankfrom.SelectedValue + "", "");

            }
            if (Convert.ToDecimal(tbl.Rows[0][1]) <= 0)
            {
                lbltotalbankbalance.Text = Convert.ToDecimal(tbl.Rows[0][1]).ToString();
            }
            else if (Convert.ToDecimal(tbl.Rows[0][1]) >= 1)
            {
                lbltotalbankbalance.Text = Convert.ToDecimal(tbl.Rows[0][1]).ToString();
            }

        }

        private void cbxbankto_SelectionChangeCommitted(object sender, EventArgs e)
        {

            tbl.Clear();
            tbl = db.readdata("select*from bank_money where bank_id=" + cbxbankto.SelectedValue + "", "");
            if (tbl.Rows.Count <= 0)
            {
                db.excutedata("insert into bank_money values(" + cbxbankto.SelectedValue + ",'0')", "");
                tbl = db.readdata("select*from bank_money where bank_id=" + cbxbankto.SelectedValue + "", "");

            }
            if (Convert.ToDecimal(tbl.Rows[0][1]) <= 0)
            {
                lbltotalbanktobalance.Text = Convert.ToDecimal(tbl.Rows[0][1]).ToString();
            }
            else if (Convert.ToDecimal(tbl.Rows[0][1]) >= 1)
            {
                lbltotalbanktobalance.Text = Convert.ToDecimal(tbl.Rows[0][1]).ToString();
            }

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            //  transferefrombanktobank
            string d = "";
            d = dtpdate.Value.ToString("yyyy-MM-dd");
            if (cbxbankfrom.Text == cbxbankto.Text)
            {
                MessageBox.Show("لايمكن التحويل من بنك الي نفسه اختر بنكين مختلفين", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (numericconvertfromto.Value <= 0)
            {
                MessageBox.Show("لايجب ان يكون المبلغ المحول اقل من او يساوي صفر ....من فضلك تاكد من بياناتك", "تنبيه هام", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (numericconvertfromto.Value > Convert.ToDecimal(lbltotalbankbalance.Text))
            {
                MessageBox.Show("القيمه المراد تحويلها اكبر من القيمه الموجوده في البنك -البنك المحول منه- ....من فضلك تاكد من بياناتك", "تنبيه هام !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtnameofmasaoul.Text == "")
            {

                MessageBox.Show("من فضلك ادخل اسم المسؤل عن هذا التحويل اولا", "تنبيه هام", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string type = "تحويل من بنك الي بنك اخر من بنك" + " " + cbxbankfrom.Text + " " + "الي" + "+" + cbxbankto.Text;
            db.excutedata("update bank_money set money=money-" + numericconvertfromto.Value + "where bank_id=" + cbxbankfrom.SelectedValue + "", "");
            db.excutedata("update bank_money set money=money+" + numericconvertfromto.Value + "where bank_id=" + cbxbankto.SelectedValue + "", "");
            db.excutedata("insert into bank_withdrowal (bank_id,bank_money,money,date,name,type,notes,user_name,branch_name)values(" + cbxbankfrom.SelectedValue + ","+lbltotalbankbalance.Text+"," + numericconvertfromto.Value + ",'" + d + "',N'" + txtnameofmasaoul.Text + "',N'"+type+"',N'" + txtreason.Text + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "')", "");
            db.excutedata("insert into bank_insert(bank_id,money,date,name,type,notes,user_name,branch_name) values(" + cbxbankto.SelectedValue + "," + numericconvertfromto.Value + ",'" + d + "',N'" + txtnameofmasaoul.Text + "',N'"+type+"',N'" + txtreason.Text + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "')", "");
            db.excutedata("insert into transferefrombanktobank (bankfrom_id,bankfrom_name,bankto_id,bankto_name,money,date,name,notes,user_name,branch_name,type) values("+cbxbankfrom.SelectedValue+",N'"+cbxbankfrom.Text.Trim()+"',"+cbxbankto.SelectedValue+",N'"+cbxbankto.Text.Trim()+"'," + numericconvertfromto.Value + ",'" + d + "',N'" + txtnameofmasaoul.Text + "',N'" + txtreason.Text + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'تحويلات بنكيه')", "تم التحويل بنجاح");
            numericconvertfromto.Value = 0;
            txtnameofmasaoul.Clear();
            txtreason.Clear();
          
            // transferbetween_stokes_Load(null, null);
        }
    }
}
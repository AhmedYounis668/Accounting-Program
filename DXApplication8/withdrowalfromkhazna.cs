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
    public partial class withdrowalfromkhazna : DevExpress.XtraEditors.XtraForm
    {
        public withdrowalfromkhazna()
        {
            InitializeComponent();
        }
        //call database class
        DataTable tbl = new DataTable();
        database db = new database();

        //when form load
        private void autnumber()
        {
            numericaddnewbalance.Value = 0;
            txteda3reason.Clear();
            txtnamemode3.Clear();
        }
//fill combobox with stokes
        private void fillcbx()
        {
            cbxkhaznaname.DataSource = db.readdata("select*from stokes", "");
            cbxkhaznaname.DisplayMember = "stoke_name";
            cbxkhaznaname.ValueMember = "stoke_id";
        }

        private void withdrowalfromkhazna_Load(object sender, EventArgs e)
        {
            dtpdate.Text = DateTime.Now.ToShortDateString();
            fillcbx();
        }

        //add
        private void btnadd_Click(object sender, EventArgs e)
        {
            //validations
            if (Convert.ToDecimal(lbltotal_khaznanow.Text) < numericaddnewbalance.Value)
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
            //update money
            db.excutedata("update stoke_money set money=money-" + numericaddnewbalance.Value + "where stoke_id=" + cbxkhaznaname.SelectedValue + "", "");
            //insert into withdrowal stoke data
            db.excutedata("insert into stoke_withdrowal(stoke_id,money,date,name,type,notes,user_name,branch_name)values(" + cbxkhaznaname.SelectedValue + "," + numericaddnewbalance.Value + ",'" + d1 + "',N'" + txtnamemode3.Text + "',N'سحب يدوي من الخزنه مباشر',N'" + txteda3reason.Text + "',N'" + Properties.Settings.Default.user_name + "','" + Properties.Settings.Default.branch_name + "')", "تم السحب بنجاح");
            autnumber();
        }

        private void numericaddnewbalance_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbxkhaznaname_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        //get the total of stoke when choose the stoke
        private void cbxkhaznaname_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readdata("select*from stoke_money where stoke_id=" + cbxkhaznaname.SelectedValue + "", "");
            if (tbl.Rows.Count <= 0)
            {
                db.excutedata("insert into stoke_money values(" + cbxkhaznaname.SelectedValue + ",'0')", "");
                tbl = db.readdata("select*from stoke_money where stoke_id=" + cbxkhaznaname.SelectedValue + "", "");
            }
            if (Convert.ToDecimal(tbl.Rows[0][1]) <= 0)
            {
                lbltotal_khaznanow.Text = Convert.ToDecimal(tbl.Rows[0][1]).ToString();
            }
            else if (Convert.ToDecimal(tbl.Rows[0][1]) >= 1)
            {
                lbltotal_khaznanow.Text = Convert.ToDecimal(tbl.Rows[0][1]).ToString();
            }
        }
    }
}
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
    public partial class eda3in_khazna : DevExpress.XtraEditors.XtraForm
    {
        public eda3in_khazna()
        {
            InitializeComponent();
        }
        //call database class
        DataTable tbl = new DataTable();
        database db = new database();

        //fill combobox with stokes
        private void fillcbx()
        {
            cbxkhaznaname.DataSource = db.readdata("select*from stokes ", "");
            cbxkhaznaname.DisplayMember = "stoke_name";
            cbxkhaznaname.ValueMember = "stoke_id";
        }
        //اعاده تحميل الشاشه بعد اضافه رصيد

        private void upload()
        {
            numericaddnewbalance.Value = 0;
            txtnamemode3.Clear();
            txteda3reason.Clear();
            lbltotal_khaznanow.Text = ".......";
            
        }

        private void eda3in_khazna_Load(object sender, EventArgs e)
        {
            fillcbx();
            upload();
            dtpdate.Text = DateTime.Now.ToShortDateString();
        }
        //add balance on stokes selected
        private void btnadd_Click(object sender, EventArgs e)
        {
            //validation to add balance
            if (cbxkhaznaname.Items.Count > 0)
            {
                if (txtnamemode3.Text == "")
                {
                    MessageBox.Show("من فضلك ادخل اسم المودع اولا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (numericaddnewbalance.Value <= 0)
                {
                    MessageBox.Show("يجب ان يكون الايداع الجديد لايساوي صفر", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //formate date
                String d = "";
                d = dtpdate.Value.ToString("yyyy-MM-dd");
                //update money of selected stoke 
                db.excutedata("update stoke_money set money=money+" + numericaddnewbalance.Value + "where stoke_id=" + cbxkhaznaname.SelectedValue + "", "");
                //insert data in stoke  information to see deposits in the reports
                db.excutedata("insert into stoke_insert (stoke_id,money,date,name,type,notes,user_name,branch_name) values(" + cbxkhaznaname.SelectedValue + "," + numericaddnewbalance.Value + ",'" + d + "',N'" + txtnamemode3.Text + "',N'ايداع يدوي -رصيد اضافي',N'" + txteda3reason.Text + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "')", "تم الحفظ بنجاح");

            }
            //reload the data
            upload();
        }

        //show the data of selected stoke when chooce it
        private void cbxkhaznaname_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                //get all data to see the balance of selected stoke from stoke_money
                tbl.Clear();
                tbl = db.readdata("select*from stoke_money where stoke_id=" + cbxkhaznaname.SelectedValue + "", "");
                //if there not data set the balance or money =0 and show it to user
                if (tbl.Rows.Count <= 0)
                {
                    db.excutedata("insert into stoke_money values(" + cbxkhaznaname.SelectedValue + ",'0')", "");
                    tbl.Clear();
                    tbl = db.readdata("select*from stoke_money where stoke_id=" + cbxkhaznaname.SelectedValue + "", "");

                }
                if (Convert.ToDecimal(tbl.Rows[0][1]) <= 0)
                {
                    lbltotal_khaznanow.Text = "0";
                }
                //else if ther is data or balance show it in the total khazna label
                else if (Convert.ToDecimal(tbl.Rows[0][1]) >= 1)
                {
                    lbltotal_khaznanow.Text = Convert.ToDecimal(tbl.Rows[0][1]).ToString();
                }

            }
            catch (Exception)
            {

            }
        }
    }
}
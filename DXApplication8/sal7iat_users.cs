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
    public partial class sal7iat_users : DevExpress.XtraEditors.XtraForm
    {
        public sal7iat_users()
        {
            InitializeComponent();
        }

        DataTable tbl = new DataTable();
        database db = new database();

        private void fillcbx()
        {
            cbxbranch_name.DataSource = db.readdata("select*from branches", "");
            cbxbranch_name.DisplayMember = "branch_name";
            cbxbranch_name.ValueMember = "branch_id";

            cbxstokename.DataSource = db.readdata("select*from stokes ", "");
            cbxstokename.DisplayMember = "stoke_name";
            cbxstokename.ValueMember = "stoke_id";
        }
        //autonumber
        private void autonumber()
        {
            DataTable tblshowdataindgv = new DataTable();
            tblshowdataindgv.Clear();
            tblshowdataindgv = db.readdata("select user_id as 'رقم المستخدم' , addnew_users.user_name as 'اسم المستخدم' , user_password as 'الرقم السري' , type as 'نوع المستخدم' , stokes.stoke_name as 'الخزنه المحدده له' , reb7 as 'نسبه ارباحه من مبيعاته',addnew_users.branch_name as 'الفرع' from addnew_users,stokes where stokes.stoke_id=addnew_users.stoke_id", "");
            dgv.DataSource = tblshowdataindgv;
            tbl.Clear();
            tbl = db.readdata("select max(user_id)from addnew_users", "");
            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                txtseries.Text = "1";
            }
            else
            {
                txtseries.Text = (Convert.ToInt16(tbl.Rows[0][0]) + 1).ToString();
            }
            txtuser_name.Clear();
            txtpassword.Clear();
            numericreb7.Value = 0;
            cbxstokename.Text = "اختر خزنه";
            cbxtype.Text = "اختر نوع";
        }
        //show

        int row = 0;
        private void show()
        {
            try
            {
                tbl.Clear();
                tbl = db.readdata("select*from addnew_users", "");
                if (tbl.Rows.Count <= 0)
                {
                    MessageBox.Show("لايوجد بيانات تخص هذه الشاشه", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    txtseries.Text = tbl.Rows[row][0].ToString();
                    txtuser_name.Text = tbl.Rows[row][1].ToString();
                    txtpassword.Text = tbl.Rows[row][2].ToString();
                    cbxtype.Text = tbl.Rows[row][3].ToString();
                    cbxstokename.SelectedValue = Convert.ToDecimal(tbl.Rows[row][4]);
                    numericreb7.Value = Convert.ToDecimal(tbl.Rows[row][5]);
                }
            }
            catch (Exception) { }
        }
        private void sal7iat_users_Load(object sender, EventArgs e)
        {
            fillcbx();
            autonumber();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtuser_name.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم المستخدم اولا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtpassword.Text == "")
            {
                MessageBox.Show("من فضلك ادخل كلمه سر للمستخدم اولا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbxstokename.Items.Count <= 0)
            {
                MessageBox.Show("من فضلك ادخل خزنه اولا في شاشه اضافه خزن", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbxstokename.Text == "اختر خزنه")
            {
                MessageBox.Show("من فضلك اختر خزنه اولا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    db.excutedata("insert into addnew_users values(" + txtseries.Text + ",N'" + txtuser_name.Text.Trim() + "',N'" + txtpassword.Text.Trim() + "',N'" + cbxtype.Text + "'," + cbxstokename.SelectedValue + "," + numericreb7.Value + ",N'" + cbxbranch_name.Text + "'," + cbxbranch_name.SelectedValue + ")", "تم ادخال بيانات المستخدم بنجاح");
                    

                }
                catch (Exception) { }
            }
            fillcbx();
            autonumber();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            autonumber();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtuser_name.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم المستخدم اولا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtpassword.Text == "")
            {
                MessageBox.Show("من فضلك ادخل كلمه سر للمستخدم اولا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            db.excutedata("update addnew_users set user_name=N'" + txtuser_name.Text.Trim() + "',user_password=N'" + txtpassword.Text.Trim() + "',type=N'" + cbxtype.Text + "',stoke_id=" + cbxstokename.SelectedValue + ",reb7=" + numericreb7.Value + ",branch_name=N'" + cbxbranch_name.Text + "',branch_id=" + cbxbranch_name.SelectedValue + " where user_id=" + txtseries.Text + "", "تم تعديل بيانات هذا المستخدم بنجاح");
            fillcbx();
            autonumber();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("هل انت متاكد من مسح بيانات هذا الممستخدم ....تنبيه هذا المستخدم لايمكنه الدخول علي البرنامج بعد حذفه", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                db.excutedata("delete from addnew_users where user_id=" + txtseries.Text + "", "");
                //db.excutedata("delete from user_settings where user_id=" + txtseries.Text + "", "");
                //db.excutedata("delete from customer_setting where user_id=" + txtseries.Text + " ", "");
                //db.excutedata("delete from supplier_setting where user_id=" + txtseries.Text + "", "");
                //db.excutedata("delete from purchases_setting where user_id=" + txtseries.Text + "", "");
                //db.excutedata("delete from sales_setting where user_id=" + txtseries.Text + "", "");
                //db.excutedata("delete from returns_setting where user_id=" + txtseries.Text + "", "");
                //db.excutedata("delete from  khaznaandbank_setting where user_id=" + txtseries.Text + "", "");
                //db.excutedata("delete from  expenses_setting where user_id=" + txtseries.Text + "", "");
                //db.excutedata("delete from  employee_setting where user_id=" + txtseries.Text + "", "");
                //db.excutedata("delete from copydata_setting where user_id=" + txtseries.Text + "", "");
                //db.excutedata("delete from reports_setting where user_id=" + txtseries.Text + "", "");
                //db.excutedata("delete from making_setting where user_id=" + txtseries.Text + "", "");

                MessageBox.Show("تم مسح هذا المستخدم بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DataTable tblusers = new DataTable();
                tblusers.Clear();
                tblusers = db.readdata("select*from addnew_users", "");
                string type = "مدير";
                if (tblusers.Rows.Count <= 0)
                {
                    db.excutedata("insert into addnew_users values(1,N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.user_name + "',N'" + type + "' ,1,0,N'" + cbxbranch_name.Text + "'," + cbxbranch_name.SelectedValue + " )", "");
                    //db.excutedata("insert into user_settings values(1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1)", "");
                    //db.excutedata("insert into customer_setting values(1,1,1,1,1,1,1,1)", "");
                    //db.excutedata("insert into supplier_setting values(1,1,1,1,1,1,1)", "");
                    //db.excutedata("insert into purchases_setting values(1,1,1,1)", "");
                    //db.excutedata("insert into sales_setting values(1,1,1,1)", "");
                    //db.excutedata("insert into returns_setting values(1,1,1)", "");
                    //db.excutedata("insert into khaznaandbank_setting values(1,1,1,1,1,1,1,1,1,1)", "");
                    //db.excutedata("insert into expenses_setting values(1,1,1,1,1,1,1,1)", "");
                    //db.excutedata("insert into employee_setting values(1,1,1,1,1,1,1,1,1,1,1)", "");
                    //db.excutedata("insert into copydata_setting values(" + txtseries.Text + ",1,1)", "");
                    //db.excutedata("insert into reports_setting values(" + txtseries.Text + ",1,1,1,1,1,1,1,1,1)", "");
                    //db.excutedata("insert into making_setting values(" + txtseries.Text + ",1,1)", "");


                }
                fillcbx();
                autonumber();
            }
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readdata("select count(user_id)from addnew_users", "");
            row = Convert.ToInt32(tbl.Rows[0][0]) - 1;
            show();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readdata("select count(user_id)from addnew_users", "");
            if (Convert.ToInt32(tbl.Rows[0][0]) - 1 == row)
            {
                row = 0;
                show();
            }
            else
            {
                row++;
                show();
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {

            tbl.Clear();
            tbl = db.readdata("select count(user_id)from addnew_users", "");
            if (row == 0)
            {
                row = Convert.ToInt32(tbl.Rows[0][0]) - 1;
                show();

            }
            else
            {
                row--;
                show();
            }
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            row = 0;
            show();
        }

        private void btnsavesetting_Click(object sender, EventArgs e)
        {

        }
    }
}
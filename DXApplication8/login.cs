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
    public partial class login : DevExpress.XtraEditors.XtraForm
    {
        public login()
        {
            InitializeComponent();
        }
        //call database class
        DataTable tbl = new DataTable();
        database db = new database();

        //fill combobox with users and branches
        private void fillcbx()
        {
            //users
            cbxuser_name.DataSource = db.readdata("select*from addnew_users", "");
            cbxuser_name.DisplayMember = "user_name";
            cbxuser_name.ValueMember = "user_id";
            //branches
            cbxbranches.DataSource = db.readdata("select*from branches", "");
            cbxbranches.DisplayMember = "branch_name";
            cbxbranches.ValueMember = "branch_id";
        }

        //connection string button
        private void connectonline_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.updateconnecttoserver == false)
            {
                MessageBox.Show("غير مسموح لك بالتعديل علي البيانات", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

                serverconnectiononline frm = new serverconnectiononline();
                frm.ShowDialog();
            }
            else if (Properties.Settings.Default.updateconnecttoserver == true)
            {
                serverconnectiononline frm = new serverconnectiononline();
                frm.ShowDialog();
            }
        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            //validation before login
            if (radiomanger.Checked == false && radioemployee.Checked == false)
            {
                MessageBox.Show("اختر اولا اذا كنت مدير ام مستخدم", "اختر قبل التنفيذ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(cbxuser_name.Text=="")
            {
                MessageBox.Show("من فضلك ادخل اسم المستخدم او اختاره اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(txtpassword.Text=="")
            {
                MessageBox.Show("من فضلك ادخل كلمه السر اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tbl.Clear();
            //manger
            if (radiomanger.Checked == true)
                //get data of selected manger
                tbl = db.readdata("select*from addnew_users where user_name=N'" + cbxuser_name.Text.Trim() + "' and user_password=N'" + txtpassword.Text + "' and type=N'مدير' and branch_id=" + cbxbranches.SelectedValue + "", "");
            //user
            else if (radioemployee.Checked == true)
                //get data of selected user
                tbl = db.readdata("select*from addnew_users where user_name=N'" + cbxuser_name.Text.Trim() + "' and user_password=N'" + txtpassword.Text + "' and type=N'مستخدم' and branch_name=N'" + cbxbranches.Text + "'", "");

            //set formate date
            string d = dtpdate.Value.ToString("yyyy-MM-dd");

            //get all data from users table
            DataTable tbluser = new DataTable();
            tbluser.Clear();
            tbluser = db.readdata("select*from addnew_users", "");
            //if there is not data in the user table or open the application for first time
            if (tbluser.Rows.Count <= 0)
            {
                //validation on data
                if (radioemployee.Checked == true)
                {
                    MessageBox.Show("انت لست مدير وليس لك اي بيانات", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (radiomanger.Checked == true && cbxuser_name.Text.Trim() != "123" && txtpassword.Text != "123")
                {
                    MessageBox.Show("من فضلك تاكد من بياناتك", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //get the data of stokes to add first stoke automatic
                DataTable tblstoke = new DataTable();
                tblstoke.Clear();
                tblstoke = db.readdata("select*from stokes", "");
                if (tblstoke.Rows.Count <= 0)
                {
                    //insert fist stoke
                    db.excutedata("insert into stokes values(1,N'الخزنه الرئيسيه',N'"+Properties.Settings.Default.user_name+"',N'الفرع الرئيسي',N'',N'"+d+"')", "");

                }
                //get data of branches to add first branch automatic
                DataTable tblbranch = new DataTable();
                tblbranch.Clear();
                tblbranch = db.readdata("select* from branches ", "");
                if(tblbranch.Rows.Count<1)
                {
                    //variable to set integer data
                    int enter2 = 1;
                    //insert branch
                    db.excutedata("insert into branches values(1,N'الفرع الرئيسي'," + enter2 + "," + enter2 + ",N'',N'',N'',N'',N'" + Properties.Settings.Default.user_name + "',N'الفرع الرئيسي')", "");
                }


                //check if their one customer or not to add cash supplier automatic

                DataTable tblcheckcustomers = new DataTable();
                tblcheckcustomers.Clear();
                tblcheckcustomers = db.readdata("select*from customers", "");
                if (tbl.Rows.Count < 1)
                {
                    //variable to set integer data
                    int custid = 1;
                    //insert first customer
                    db.excutedata("insert into customers values("+custid+",N'عميل نقدي'," + custid + ",N'',N'عميل نقدي لايجب التعامل مع هذا العميل الا بالتعاملات الكاش فقط'," + custid + ",N'-',N'-',N'" + Properties.Settings.Default.user_name + "',N'الفرع لرئيسي'," + custid + ")", "");
                }


                //check if their one supplier or not to add cash supplier automatic
                DataTable tblchecksuppliers = new DataTable();
                tblchecksuppliers.Clear();
                tblchecksuppliers = db.readdata("select*from suppliers", "");
                if (tbl.Rows.Count < 1)
                {
                    //variable to set integer data
                    int supid = 1;
                    //insert first supplier
                    db.excutedata("insert into suppliers values("+supid+",N'مورد نقدي',"+ supid + ",N'',N'مورد نقدي -لايجب التعامل مع هذا المورد الا في حاله الفواتير الكاش فقط',"+supid+",N'-',N'-',N'"+Properties.Settings.Default.user_name+"',N'الفرع الرئيسي')", "");
                }
                //insert first user as manger to login
                string type = "مدير";
                int branch_id = 1;
                //insert into user table
                db.excutedata("insert into addnew_users values(1,N'123',N'123',N'" + type + "' ,1,0,N'الفرع الرئيسي'," + branch_id + " )", "");

                //select data of user again after entered in the table to can login
                tbl.Clear();
                if (radiomanger.Checked == true)
                    tbl = db.readdata("select*from addnew_users where user_name=N'" + cbxuser_name.Text.Trim() + "' and user_password=N'" + txtpassword.Text + "' and type=N'مدير' and branch_id=" + cbxbranches.SelectedValue + "", "");
                else if (radioemployee.Checked == true)
                    tbl = db.readdata("select*from addnew_users where user_name=N'" + cbxuser_name.Text.Trim() + "' and user_password=N'" + txtpassword.Text + "' and type=N'مستخدم' and branch_id=" + cbxbranches.SelectedValue + "", "");

               
            }



            else if (tbl.Rows.Count >= 1)
            {
                //تشغيل كود النسخه التجريبيه

                //bool check;
                //check = trial();
                //if (check == false)
                //{
                //    return;
                //}
                //save data in public variables on the application
                Properties.Settings.Default.user_name = cbxuser_name.Text.Trim();
                Properties.Settings.Default.branch_name = cbxbranches.Text;
                Properties.Settings.Default.stoke_id = Convert.ToInt32(tbl.Rows[0][4]);
                Properties.Settings.Default.Save();
                this.Hide();

                //speek.SpeakAsync("Welcome to Your Sales Program" + Properties.Settings.Default.user_name);
                Form1 frm = new Form1();
                frm.ShowDialog();
            }
            else
            {

                MessageBox.Show("هذه البيانات خاطئه من فضلك تاكد من اسم المستخدم وكلمه السر", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }



        private void login_Load(object sender, EventArgs e)
        {
            dtpdate.Text = DateTime.Now.ToShortDateString();
            //add the first branch when form load automatic
            DataTable tblbranch = new DataTable();
            tblbranch.Clear();
            tblbranch = db.readdata("select* from branches ", "");
            if (tblbranch.Rows.Count < 1)
            {
                int enter2 = 1;
                //insert branch
                db.excutedata("insert into branches values(1,N'الفرع الرئيسي'," + enter2 + "," + enter2 + ",N'',N'',N'',N'',N'"+Properties.Settings.Default.user_name+ "',N'الفرع الرئيسي')", "");
            }
            txtpassword.Clear();
                    fillcbx();
    
        }


        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxbranches_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                cbxuser_name.Focus();
            }
        }

        private void cbxuser_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtpassword.Focus();
            }
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnenter_Click(null, null);
            }
        }
    }
}

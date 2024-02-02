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
    public partial class employeeabsentsanddiscount : DevExpress.XtraEditors.XtraForm
    {
        public employeeabsentsanddiscount()
        {
            InitializeComponent();
        }
        //call database class
        DataTable tbl = new DataTable();
        database db = new database();

        //autonumber
        private void autonumber()
        {
            //get max id from this table
            tbl.Clear();
            tbl = db.readdata("select max(order_id)from absentsandkhosomat where branch_name=N'" + Properties.Settings.Default.branch_name + "'", "");
            //if table or cell id is null set textbox of id =1
            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                txtorder_id.Text = "1";
            }
            else
            {
                //if the cell of id not equal null get the value of max id and add 1 on it to show in textbox id
                txtorder_id.Text = (Convert.ToDecimal(tbl.Rows[0][0]) + 1).ToString();
            }
            cbxemloyeename.Text = "اختر موظف";
            numericnumberofdays.Value = 0;
        }
        // fill combobox with employee id and name
        private void fillcbx()
        {
            cbxemloyeename.DataSource = db.readdata("select*from add_new_employee where activation='1'", "");
            cbxemloyeename.DisplayMember = "emp_name";
            cbxemloyeename.ValueMember = "emp_id";
        }
        private void employeeabsentsanddiscount_Load(object sender, EventArgs e)
        {
            autonumber();
            dtpdate.Text = DateTime.Now.ToShortDateString();
            fillcbx();
        }

        private void radioovertime_CheckedChanged(object sender, EventArgs e)
        {
            //change labels whene change choose between it
            if (radioovertime.Checked == true)
            {
                lblovertime.Text = ":عدد ايام الوقت الاضافي ";
            }
            else if (radioovertime.Checked == false)
            {
                lblovertime.Text = ":عدد الايام المخصومه";
            }
        }

        private void radiokhasmmaly_CheckedChanged(object sender, EventArgs e)
        {
            //change labels whene change choose between it

            if (radiokhasmmaly.Checked == true)
            {
                lblovertime.Text = "المبلغ المخصوم";
            }
            else if (radiokhasmmaly.Checked == false)
            {
                lblovertime.Text = "عدد الايام المخصومه";
            }
        }

        private void radiohafez_CheckedChanged(object sender, EventArgs e)
        {
            //change labels whene change choose between it

            if (radiohafez.Checked == true)
            {
                lblovertime.Text = "المبلغ :";
            }
        }

        private void radiobadl_entekal_CheckedChanged(object sender, EventArgs e)
        {
            //change labels whene change choose between it

            if (radiobadl_entekal.Checked == true)
            {
                lblovertime.Text = "المبلغ";
            }
        }

        //add to absentsandkhosomat and employee_account
        private void btnsave_Click(object sender, EventArgs e)
        {
            string date = "", t = "";
            date = dtpdate.Value.ToString("yyyy-MM-dd");
            t = dtpdate.Value.ToString("HH-MM");
            //validations
            if (numericnumberofdays.Value <= 0)
            {
                MessageBox.Show("لايجب ان يكون عدد الايام اصغر من او تساوي صفر", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbxemloyeename.Text == "اختر موظف")
            {
                MessageBox.Show("من فضلك اختر موظف اولا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (radioabsents.Checked == false && radiokhasm.Checked == false && radioovertime.Checked == false && radiokhasmmaly.Checked == false && radiohafez.Checked == false && radiobadl_entekal.Checked == false)
            {
                MessageBox.Show("يجب ان تحدد عمليه اولا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //if you want to do khasm
            if (radiokhasm.Checked == true)
            {
                //insert khasm days absentsandkhosomat
                db.excutedata("insert into absentsandkhosomat values(" + txtorder_id.Text + "," + cbxemloyeename.SelectedValue + ",N'" + cbxemloyeename.Text + "'," + numericnumberofdays.Value + ",N'خصم',N'" + date + "',N'" + Properties.Settings.Default.branch_name + "',N'" + txtnotes.Text.Trim() + "')", "");
                //autonumber();
            }
            //if you want to do absent absentsandkhosomat
            else if (radioabsents.Checked == true)
            {
                //insert absent data
                db.excutedata("insert into absentsandkhosomat values(" + txtorder_id.Text + "," + cbxemloyeename.SelectedValue + ",N'" + cbxemloyeename.Text + "'," + numericnumberofdays.Value + ",N'غياب',N'" + date + "',N'" + Properties.Settings.Default.branch_name + "',N'" + txtnotes.Text.Trim() + "')", "");
                //autonumber();
            }
            //if you want to do overtime
            else if (radioovertime.Checked == true)
            {
                //insert overtime
                db.excutedata("insert into absentsandkhosomat values(" + txtorder_id.Text + "," + cbxemloyeename.SelectedValue + ",N'" + cbxemloyeename.Text + "'," + numericnumberofdays.Value + ",N'وقت اضافي',N'" + date + "',N'" + Properties.Settings.Default.branch_name + "',N'" + txtnotes.Text.Trim() + "')", "");
                //autonumber();
            }
            //if you want to do khasm money absentsandkhosomat
            else if (radiokhasmmaly.Checked == true)
            {
                //insert khasm money
                db.excutedata("insert into absentsandkhosomat values(" + txtorder_id.Text + "," + cbxemloyeename.SelectedValue + ",N'" + cbxemloyeename.Text + "'," + numericnumberofdays.Value + ",N'خصم مالي',N'" + date + "',N'" + Properties.Settings.Default.branch_name + "',N'" + txtnotes.Text.Trim() + "') ", "");
                //autonumber();
            }
            //if you want to do hafez absentsandkhosomat
            else if (radiohafez.Checked == true)
            {
                //insert hafez data
                db.excutedata("insert into absentsandkhosomat values(" + txtorder_id.Text + "," + cbxemloyeename.SelectedValue + ",N'" + cbxemloyeename.Text + "'," + numericnumberofdays.Value + ",N'حافز',N'" + date + "',N'" + Properties.Settings.Default.branch_name + "',N'" + txtnotes.Text.Trim() + "') ", "");
                //   autonumber();
            }
            //if you want to do badl transfer absentsandkhosomat
            else if (radiobadl_entekal.Checked == true)
            {
                //insert badl transefer data absentsandkhosomat
                db.excutedata("insert into absentsandkhosomat values(" + txtorder_id.Text + "," + cbxemloyeename.SelectedValue + ",N'" + cbxemloyeename.Text + "'," + numericnumberofdays.Value + ",N'بدل انتقالات',N'" + date + "',N'" + Properties.Settings.Default.branch_name + "',N'" + txtnotes.Text.Trim() + "') ", "");
                //autonumber();
            }

            tbl.Clear();
            tbl = db.readdata("select*from add_new_employee where emp_id=" + cbxemloyeename.SelectedValue + "", "");
            decimal salary = Convert.ToDecimal(tbl.Rows[0][2]);
            decimal total = 0;
            string description = "";
            //insert data of employee absent employee_account
            if (radioabsents.Checked == true)
            {
                description = "غياب" + " " + numericnumberofdays.Value + " " + "يوم";
                total = salary / 30;
                db.excutedata("insert into employee_account values(" + txtorder_id.Text + "," + cbxemloyeename.SelectedValue + ",N'" + cbxemloyeename.Text + "',N'" + description + "'," + total + "," + total + ",0,N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + date + "',N'" + description + "',N'" + t + "',0)", "تمت العمليه بنجاح");
                autonumber();
            }
            //insert data of employee khasm days employee_account
            else if (radiokhasm.Checked == true)
            {
                description = "خصم" + " " + numericnumberofdays.Value + " " + "يوم";
                total = total = salary / 30;
                db.excutedata("insert into employee_account values(" + txtorder_id.Text + "," + cbxemloyeename.SelectedValue + ",N'" + cbxemloyeename.Text + "',N'" + description + "'," + total + "," + total + ",0,N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + date + "',N'" + description + "',N'" + t + "',0)", "تمت العمليه بنجاح");
                autonumber();
            }
            //insert data of employee khasm money employee_account
            else if (radiokhasmmaly.Checked == true)
            {
                description = "خصم مالي";
                total = numericnumberofdays.Value;
                db.excutedata("insert into employee_account values(" + txtorder_id.Text + "," + cbxemloyeename.SelectedValue + ",N'" + cbxemloyeename.Text + "',N'" + description + "'," + total + "," + total + ",0,N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + date + "',N'" + description + "',N'" + t + "',0)", "تمت العمليه بنجاح");
                autonumber();
            }
            //insert data of employee overtime employee_account
            else if (radioovertime.Checked == true)
            {
                description = "اوفر تايم" + " " + numericnumberofdays.Value + " " + "يوم";
                total = (salary / 30);
                db.excutedata("insert into employee_account values(" + txtorder_id.Text + "," + cbxemloyeename.SelectedValue + ",N'" + cbxemloyeename.Text + "',N'" + description + "'," + total + ",0,"+total+",N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + date + "',N'" + description + "',N'" + t + "',0)", "تمت العمليه بنجاح");
                autonumber();
            }
            //insert data of employee badl transfer employee_account 
            else if (radiobadl_entekal.Checked == true)
            {
                description = "بدل انتقال";
                total = numericnumberofdays.Value;
                db.excutedata("insert into employee_account values(" + txtorder_id.Text + "," + cbxemloyeename.SelectedValue + ",N'" + cbxemloyeename.Text + "',N'" + description + "'," + total + ",0," + total + ",N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + date + "',N'" + description + "',N'" + t + "',0)", "تمت العمليه بنجاح");
                autonumber();


            }
            //insert hafez data to employee acount
            else if(radiohafez.Checked==true)
            {
                description = "حافز";
                total = numericnumberofdays.Value;
                db.excutedata("insert into employee_account values(" + txtorder_id.Text + "," + cbxemloyeename.SelectedValue + ",N'" + cbxemloyeename.Text + "',N'" + description + "'," + total + ",0," + total + ",N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + date + "',N'" + description + "',N'" + t + "',0)", "تمت العمليه بنجاح");
                autonumber();
            }

           
        }

        private void radioabsents_CheckedChanged(object sender, EventArgs e)
        {
            //change label text whene chooce between radios
            if (radioovertime.Checked == true)
            {
                lblovertime.Text = ":عدد ايام المخصومه ";
            }
            else if (radioovertime.Checked == false)
            {
                lblovertime.Text = ":عدد الايام المخصومه";
            }
        
    }

    private void radiokhasm_CheckedChanged(object sender, EventArgs e)
    {
            //change label text whene chooce between radios

            if (radiokhasm.Checked == true)
        {
            lblovertime.Text = ":عدد ايام المخصومه ";
        }
        else if (radiokhasm.Checked == false)
        {
            lblovertime.Text = ":عدد الايام المخصومه";
        }

    }
}

    
}
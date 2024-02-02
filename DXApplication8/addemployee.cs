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
    public partial class addemployee : DevExpress.XtraEditors.XtraForm
    {
        public addemployee()
        {
            InitializeComponent();
        }

        //call database class
        DataTable tbl = new DataTable();
        database db = new database();

        //call max id from add_new_employee table to create autonumber
       //autonumber
        private void autonumber()
        {
            tbl.Clear();
            //get last id in the table
            tbl = db.readdata("select max(emp_id)from add_new_employee", "");
            //check if this id in the table have data or null
            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                //if there not data in the table textbox=>id set =1

                txtemp_id.Text = "1";
            }
            else
            {
                //if the table have data get this number in cell id and set it +1
                txtemp_id.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }
            txtemp_name.Clear();
            txtnationalid.Clear();
            txtphone.Clear();
            txtaddress.Clear();
            numericsalary.Value = 0;
            checkactivation.Checked = true;
            //show data in datagridview 
            tbl.Clear();
            tbl = db.readdata("select emp_id as 'رقم الموظف' , emp_name as 'اسم الموظف', emp_salary as 'المرتب' , start_date as 'تاريخ بدايه العمل' , phone as 'رقم التليفون' , national_id as 'رقم البطاقه' , address as 'العنوان',activation as 'نشط ام لا'  from add_new_employee ", "");
            dgv.DataSource = tbl;
        }

        //collect all employee salary and show it in textbox=>txttotalemployeesalary
        private void totalemployeesalary()
        {
            try
            {
                //get all employee data where activition=1 only
                DataTable tbltotalemployeesalary = new DataTable();
                tbltotalemployeesalary = db.readdata("select *from add_new_employee where activation='1'", "");
                decimal total = 0;
                for (int i = 0; i <= tbltotalemployeesalary.Rows.Count - 1; i++)
                {
                    total += Convert.ToDecimal(tbltotalemployeesalary.Rows[i][2]);
                }
                txttotalemployeesalary.Text = total.ToString();
            }
            catch (Exception)
            {


            }
        }
        private void addemployee_Load(object sender, EventArgs e)
        {
            autonumber();
            dtpdateofadd.Text = DateTime.Now.ToShortDateString();

            btndelete.Enabled = false;
               //show data in datagridview 
            tbl.Clear();
            tbl = db.readdata("select emp_id as 'رقم الموظف' , emp_name as 'اسم الموظف', emp_salary as 'المرتب' , start_date as 'تاريخ بدايه العمل' , phone as 'رقم التليفون' , national_id as 'رقم البطاقه' , address as 'العنوان',activation as 'نشط ام لا'  from add_new_employee ", "");
            dgv.DataSource = tbl;
            totalemployeesalary();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            //add employee validation

            if (txtemp_name.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم الموظف اولا ", "تنبيه هام", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtnationalid.Text == "")
            {
                MessageBox.Show("من فضلك ادخل رقم بطاقه الموظف اولا  ", "تنبيه هام", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtphone.Text == "")
            {
                MessageBox.Show("من فضلك ادخل تليفون الموظف اولا  ", "تنبيه هام", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (numericsalary.Value <= 0)
            {
                MessageBox.Show("من فضلك ادخل راتب الموظف اولا  ", "تنبيه هام", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //formate date 
            string datetoday = "";
            datetoday = dtpdateofadd.Value.ToString("yyyy-MM-dd");
            try
            {
                //insert into add_new_ employee table
                db.excutedata("insert into add_new_employee values(" + txtemp_id.Text + ",N'" + txtemp_name.Text.Trim() + "'," + numericsalary.Value + ",'" + datetoday + "'," + txtphone.Text + "," + txtnationalid.Text + ",N'" + txtaddress.Text + "','true')", "تم الادخال بنجاح");
            }
            catch (Exception)
            {
            }
            autonumber();
            //call function who collect all employee salary
            totalemployeesalary();

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            //close form
            this.Close();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            autonumber();
        }


        string emp_activation;


        private void btnsave_Click(object sender, EventArgs e)
        {
            //update validation
            if (dgv.Rows.Count >= 1)
            {

                if (txtemp_name.Text == "")
                {
                    MessageBox.Show("من فضلك ادخل اسم الموظف اولا ", "تنبيه هام", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtnationalid.Text == "")
                {
                    MessageBox.Show("من فضلك ادخل رقم بطاقه الموظف اولا  ", "تنبيه هام", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtphone.Text == "")
                {
                    MessageBox.Show("من فضلك ادخل تليفون الموظف اولا  ", "تنبيه هام", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (numericsalary.Value <= 0)
                {
                    MessageBox.Show("من فضلك ادخل راتب الموظف اولا  ", "تنبيه هام", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (checkactivation.Checked == true)
                {
                    emp_activation = "true";
                }
                if (checkactivation.Checked == false)
                {
                    emp_activation = "false";
                }

                //get id of selected employee from datagridview
                int emp_id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                //get the date of the day
                string  dateoftoday = "";
                dateoftoday = dtpdateofadd.Value.ToString("yyyy-MM-dd");
                //update data of selected employee in datagridview
                tbl.Clear();
                db.excutedata("update add_new_employee set emp_name=N'" + txtemp_name.Text.Trim() + "' , emp_salary=" + numericsalary.Value + " , start_date=N'" + dateoftoday + "' , phone=" + txtphone.Text + " , national_id=" + txtnationalid.Text + " , address=N'" + txtaddress.Text + "',activation=N'" + emp_activation + "' where emp_id=" + emp_id+ "", "تم تعديل البيانات بنجاح");
                autonumber();
                //call sunction that collect all employee salary
                totalemployeesalary();
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            //search about employee dependinhg on the letters of his name
            tbl.Clear();
            tbl = db.readdata("select emp_id as 'رقم الموظف' , emp_name as 'اسم الموظف', emp_salary as 'المرتب' , start_date as 'تاريخ بدايه العمل' , phone as 'رقم التليفون' , national_id as 'رقم البطاقه' , address as 'العنوان',activation as 'نشط ام لا'  from add_new_employee where emp_name like N'%" + txtsearch.Text.Trim() + "%'", "");
            dgv.DataSource = tbl;
        }
    }

    
    
}
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
    public partial class employee_accounts : DevExpress.XtraEditors.XtraForm
    {
        public employee_accounts()
        {
            InitializeComponent();
        }
        //call database class
        DataTable tbl = new DataTable();
        database db = new database();

        //get the final salary after all discounts and make statement salary for selected employee
        private void totals()
        {
            decimal leh = 0, sadad = 0, final = 0;
            for(int i=0;i<=dgv.Rows.Count-1;i++)
            {
                leh += Convert.ToDecimal(dgv.Rows[i].Cells[4].Value);
                sadad += Convert.ToDecimal(dgv.Rows[i].Cells[5].Value);
            }
            final = (Convert.ToDecimal(txtsalary.Text) + sadad) - leh;
            txtborrowmoney.Text = leh.ToString();
            txttotal.Text = final.ToString();
        }
        //fill combobox with employee information id and name
        private void fillcbx()
        {
            cbxemployee.DataSource = db.readdata("select*from add_new_employee where activation=1", "");
            cbxemployee.DisplayMember = "emp_name";
            cbxemployee.ValueMember = "emp_id";
        }
        private void employee_accounts_Load(object sender, EventArgs e)
        {
            fillcbx();
            dtpfrom.Text = DateTime.Now.ToShortDateString();
            dtpto.Text = DateTime.Now.ToShortDateString();
            dtpkabddate.Text = DateTime.Now.ToShortDateString();
        }

        //search by written the employee name 
        private void txt_write_emp_TextChanged(object sender, EventArgs e)
        {
            if (radiosupname.Checked == true)
            {
                tbl.Clear();
                tbl = db.readdata("select emp_id as 'رقم الموظف',emp_name as 'اسم الموظف',emp_salary as 'الراتب',start_date as 'بدايه العمل',national_id as 'الرقم القوي',address as 'العنوان',activation as 'الحاله' from add_new_employee where emp_name like N'%" + txt_write_emp.Text.Trim() + "%'", "");
                dgv.DataSource = tbl;

               
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string dfrom = dtpfrom.Value.ToString("yyyy-MM-dd");
            string dto = dtpto.Value.ToString("yyyy-MM-dd");
            //saerch by selected employee from combobox
            if(radioempselection.Checked==true)
            {
                tbl.Clear();
                tbl = db.readdata("select order_id as 'رقم البيان',emp_name as 'الموظف',discription as 'البيان',total as 'الاجمالي',on_him as 'عليه',sadad as 'له',notes as 'ملاحظات',type as 'نوع العمليه',date as 'التاريخ',time as 'الوقت',user_name as 'المستخدم',branch_name as 'الفرع' from employee_account where emp_id="+cbxemployee.SelectedValue+"", "");
                dgv.DataSource = tbl;
                DataTable tblsalary = new DataTable();
                tblsalary.Clear();
                tblsalary = db.readdata("select*from add_new_employee where emp_id=" + cbxemployee.SelectedValue + "", "");
                txtsalary.Text = Convert.ToString(tblsalary.Rows[0][2]);
            }
            //get data for this employee by selected row in datagridview
            else if(radiosupname.Checked==true)
            {
                int emp_id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                tbl.Clear();
                tbl = db.readdata("select order_id as 'رقم البيان',emp_name as 'الموظف',discription as 'البيان',total as 'الاجمالي',on_him as 'عليه',sadad as 'له',notes as 'ملاحظات',type as 'نوع العمليه',date as 'التاريخ',time as 'الوقت',user_name as 'المستخدم',branch_name as 'الفرع' from employee_account where emp_id=" + emp_id + "", "");
                dgv.DataSource = tbl;
                DataTable tblsalary = new DataTable();
                tblsalary.Clear();
                tblsalary = db.readdata("select*from add_new_employee where emp_id=" + cbxemployee.SelectedValue + "", "");
                txtsalary.Text = Convert.ToString(tblsalary.Rows[0][2]);
            }
            //search between two dates to get the balance in this time
            else if(radiofatra.Checked==true)
            {

                tbl.Clear();
                tbl = db.readdata("select order_id as 'رقم البيان',emp_name as 'الموظف',discription as 'البيان',total as 'الاجمالي',on_him as 'عليه',sadad as 'له',notes as 'ملاحظات',type as 'نوع العمليه',date as 'التاريخ',time as 'الوقت',user_name as 'المستخدم',branch_name as 'الفرع' from employee_account where emp_id=" + cbxemployee.SelectedValue + " and convert(nvarchar,date,105)between N'"+dfrom+"' and N'"+dto+"'", "");
                dgv.DataSource = tbl;
                DataTable tblsalary = new DataTable();
                tblsalary.Clear();
                tblsalary = db.readdata("select*from add_new_employee where emp_id=" + cbxemployee.SelectedValue + "", "");
                txtsalary.Text = Convert.ToString(tblsalary.Rows[0][2]);
            }
            totals();
        }

        //get selected stoke for the user active in the program now
        int stoke_id = Properties.Settings.Default.stoke_id;
        private void btnsarfsalary_Click(object sender, EventArgs e)
        {
            if (radioempselection.Checked == true)
            {
                //check about the stoke if the is money for this statement or no
                DataTable tblstoke = new DataTable();
                tblstoke.Clear();
                tblstoke = db.readdata("select*from stoke_money where stoke_id=" + stoke_id + "", "");
                if(Convert.ToDecimal(tblstoke.Rows[0][1])<numircprice.Value)
                {
                    MessageBox.Show("من فضلك انتبه المبلغ المتواجد الان في الخزنه غير لكافي لصرف المرتب المكتوب حاليا ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (numircprice.Value == 0)
                {
                    MessageBox.Show("من فضلك ادخل المرتب اولا المرتب المنصرف الحالي يساوي 0؟!!!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                else
                {
                    //create autonumber for sand sarf to expense the salary of the employee
                    string t = dtpkabddate.Value.ToString("HH:MM");
                    string kabd_date = dtpkabddate.Value.ToString("yyyy-MM-dd");
                    int order_id;
                    tbl.Clear();
                    tbl = db.readdata("select*from sandat_id", "");
                    if (tbl.Rows.Count < 1)
                    {
                        db.excutedata("insert into sandat_id values(1000000)", "");
                    }
                    else if (tbl.Rows.Count >= 1)
                    {
                        db.excutedata("update sandat_id set sand_id=sand_id+1", "");
                    }
                    DataTable tblorder_id = new DataTable();
                    tblorder_id.Clear();
                    tblorder_id = db.readdata("select*from sandat_id", "");
                    order_id = Convert.ToInt32(tblorder_id.Rows[0][0]);

                    //insert data to employee acount 
                    string cust_name = cbxemployee.Text;
                    //get employee id
                    int cust_id = Convert.ToInt32(cbxemployee.SelectedValue);
                    string description33 = "قبض شهري للموظف" + " " + cust_name + " " + "سند رقم" + order_id;
                    // string discription33333 = "----صرف----";
                    db.excutedata("insert into employee_account values(" + order_id + "," + cust_id + ",N'" + cust_name + "',N'" + description33 + "'," + numircprice.Value + ",0," + numircprice.Value * -1 + ",N'',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + kabd_date + "',N'صرف مرتبات',N'" + t + "'," + order_id + ")", "");


                    //الخزنه
                    string description44 = " مسحوبات -صرف مرتب موظف" + " " + Convert.ToString(order_id) + " " + "للموظف" + Convert.ToString(cbxemployee.Text);
                    db.excutedata("update stoke_money set money=money-" + Convert.ToDecimal(numircprice.Value) + "where stoke_id=" + stoke_id + "", "");
                    db.excutedata("insert into stoke_withdrowal (stoke_id,money,date,name,type,notes,user_name,branch_name,order_id2)values(" + stoke_id + "," + numircprice.Value + ",'" + kabd_date + "',N'" + description44 + "'+N''+N'صرف مرتبات'+N''+N'" + cust_name + "',N'',N'',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',"+order_id+")", "تم التنفيذ بنجاح");

                    btnsearch_Click(null, null);
                }
                }
        }
    }
}
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
    public partial class employeeattendance : DevExpress.XtraEditors.XtraForm
    {
        public employeeattendance()
        {
            InitializeComponent();
        }

        DataTable tbl = new DataTable();
        database db = new database();

        private void fillcbx()
        {
            cbxemployee.DataSource = db.readdata("select*from add_new_employee where activation=1", "");
            cbxemployee.DisplayMember = "emp_name";
            cbxemployee.ValueMember = "emp_id";
        }

        private void autonumber()
        {
            txtsearch.Clear();
            txtnotes.Clear();
            
        }
        private void employeeattendance_Load(object sender, EventArgs e)
        {
            fillcbx();
            dtpdate.Text = DateTime.Now.ToShortDateString();
            dtptime.Text = DateTime.Now.ToShortTimeString();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (radioensraf.Checked == false && radioattend.Checked == false)
            {
                MessageBox.Show("من فضلك حدد اما اذا كان هذا حضور اما انصراف", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                string d = dtpdate.Value.ToString("yyyy-MM-dd");
                string t = dtptime.Value.ToString("HH:MM");
                string description = "";
                if (radioattend.Checked == true)
                {
                    description = "حضور";
                }
                else if (radioensraf.Checked == true)
                {
                    description = "انصراف";
                }

                db.excutedata("insert into employee_attendans(emp_id,emp_name,description,date,time,notes,user_name,branch_name) values(" + cbxemployee.SelectedValue + ",N'" + cbxemployee.Text + "',N'" + description + "',N'" + d + "',N'" + t + "',N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "')", "تم التسجيل");
                autonumber();
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readdata("select order_id as'رقم اليبان',emp_name as'اسم الموظف',description as'البيان',notes as'ملاحظات',date as'التاريخ',time as'الوقت',user_name as'المستخدم',branch_name as'الفرع' from employee_attendans where emp_name like N'%"+txtsearch.Text.Trim()+"%'", "");
            dgv.DataSource = tbl;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count >= 1)
            {
                if (radioensraf.Checked == false && radioattend.Checked == false)
                {
                    MessageBox.Show("من فضلك حدد اما اذا كان هذا حضور اما انصراف", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    int order_id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                    db.excutedata("delete from employee_attendans where order_id="+order_id+"", "");
                    string d = dtpdate.Value.ToString("yyyy-MM-dd");
                    string t = dtptime.Value.ToString("HH:MM");
                    string description = "";
                    if (radioattend.Checked == true)
                    {
                        description = "حضور";
                    }
                    else if (radioensraf.Checked == true)
                    {
                        description = "انصراف";
                    }

                    db.excutedata("insert into employee_attendans(emp_id,emp_name,description,date,time,notes,user_name,branch_name) values(" + cbxemployee.SelectedValue + ",N'" + cbxemployee.Text + "',N'" + description + "',N'" + d + "',N'" + t + "',N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "')", "تم التسجيل");
                    autonumber();
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count >= 1)
            {
                if (MessageBox.Show("هل انت متاكد من هذا الحذف ؟", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    int order_id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                    db.excutedata("delete from employee_attendans where order_id=" + order_id + "", "تم الحذف بنجاح");
                    autonumber();

                }
            }
        }
    }
}
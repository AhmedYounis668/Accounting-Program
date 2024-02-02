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
    public partial class customer_data : DevExpress.XtraEditors.XtraForm
    {
        public customer_data()
        {
            InitializeComponent();
        }

        //call database class
        DataTable tbl = new DataTable();
        database db = new database();

        //autonumber
        //get max id from customers able
        private void autonumber()
        {
            tbl = db.readdata("select max(cust_id)from customers", "");
            //validation to see if the table or cell id is null or not
            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                //if table null and id in table null set textbox of id =1
                txtcust_id.Text = "1";
            }
            else
            {
                //ele if the cell of id in the customer table not equal null set the value in this cell +1
                txtcust_id.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }
            //clear user data from tools in the form
            txtcust_name.Clear();
            txtphone.Clear();
            txtnotes.Clear();
            txtsearch.Clear();
            txtidentityid.Clear();
            txtaddress.Clear();

            //get data of customers and show it in the datagridview
            tbl.Clear();
            tbl = db.readdata("select cust_id as 'رقم العميل',cust_name as 'اسم العميل',phone as 'تليفون',address as 'العنوان',notes as 'ملاحظات',identity_id as 'رقم تعريفي اخر',gov as 'المحافظه',city as 'المدينه',user_name as 'المستخدم',branch as 'الفرع' from customers", "");
            dgv.DataSource = tbl;
        }
            private void customer_data_Load(object sender, EventArgs e)
        {
            autonumber();
            
        }

        private void tileItem5_ItemClick(object sender, TileItemEventArgs e)
        {
            autonumber();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            //search about customers by searching with the letter of his name
            tbl.Clear();
            tbl = db.readdata("select cust_id as 'رقم العميل',cust_name as 'اسم العميل',phone as 'تليفون',address as 'العنوان',notes as 'ملاحظات',identity_id as 'رقم تعريفي اخر',gov as 'المحافظه',city as 'المدينه',user_name as 'المستخدم',branch as 'الفرع' from customers where cust_name like N'%"+txtsearch.Text.Trim()+"%'", "");
            dgv.DataSource = tbl;
        }

        //insert
        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            //validation to add
            if(txtcust_name.Text=="")
            {
                MessageBox.Show("من فضلك ادخل اسم العميل اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(txtphone.Text=="")
            {
                MessageBox.Show("من فضلك ادخل تليفون العميل اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtaddress.Text =="")
            {
                MessageBox.Show("من فضلك ادخل عنوان العميل اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(cbx_gov.Text=="")
            {
                MessageBox.Show("من فضلك ادخل المحافظه اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(cbxcity.Text=="")
            {
                MessageBox.Show("من فضلك ادخل المدينه اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtidentityid.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اي رقم تعريفي  للمورد اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //activation
                int activation=1;
                if(checkactivation.Checked==true)
                {
                    activation = 1;
                }
                else if(checkactivation.Checked==false)
                {
                    activation = 0;
                }
                //insert data of customer in the customers table
                db.excutedata("insert into customers values("+txtcust_id.Text+",N'"+txtcust_name.Text.Trim()+"',N'"+txtphone.Text.Trim()+"',N'"+txtaddress.Text.Trim()+"',N'"+txtnotes.Text.Trim()+"',"+txtidentityid.Text.Trim()+",N'"+cbx_gov.Text.Trim()+"',N'"+cbxcity.Text.Trim()+"',N'"+Properties.Settings.Default.user_name+"',N'"+Properties.Settings.Default.branch_name+"',"+activation+")", "تم حفظ بيانات العميل بنجاح");
                autonumber();
            }
        }

        //update
        private void tileItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            //update customer data
            if(dgv.Rows.Count>=1)
            {
                int activation = 1;
                if (checkactivation.Checked == true)
                {
                    activation = 1;
                }
                else if (checkactivation.Checked == false)
                {
                    activation = 0;
                }
                //update customer data in the customers table
                db.excutedata("update customers set cust_name=N'"+dgv.CurrentRow.Cells[1].Value+"',phone=N'"+dgv.CurrentRow.Cells[2].Value+"',address=N'"+dgv.CurrentRow.Cells[3].Value+"',notes=N'"+dgv.CurrentRow.Cells[4].Value+"',identity_id=N'"+dgv.CurrentRow.Cells[5].Value+"',gov=N'"+dgv.CurrentRow.Cells[6].Value+"',city=N'"+dgv.CurrentRow.Cells[7].Value+"',branch=N'"+Properties.Settings.Default.branch_name+"',user_name=N'"+Properties.Settings.Default.user_name+ "',activation=" + activation+" where cust_id="+dgv.CurrentRow.Cells[0].Value+"", "تم تعديل بيانات العميل بنجاح");
                autonumber();
            }
        }

        private void tileItem4_ItemClick(object sender, TileItemEventArgs e)
        {
            //close this form
            this.Close();
        }

        private void tileItem3_ItemClick(object sender, TileItemEventArgs e)
        {
            
        }
    }
}
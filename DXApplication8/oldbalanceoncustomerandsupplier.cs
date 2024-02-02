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
    public partial class oldbalanceoncustomerandsupplier : DevExpress.XtraEditors.XtraForm
    {
        public oldbalanceoncustomerandsupplier()
        {
            InitializeComponent();
        }

        //call database class
        DataTable tbl = new DataTable();
        database db = new database();

        //autonumber
        private void autonumber()
        {

            try
            {
               //check if there is data for id or null
                tbl.Clear();
                tbl = db.readdata("select*from sandat_id", "");
                if (tbl.Rows.Count < 1)
                {
                    //if there is not data  of id
                    db.excutedata("insert into sandat_id values(1000000)", "");
                }
                else if (tbl.Rows.Count >= 1)
                {
                    //if there is  data of id
                    db.excutedata("update sandat_id set sand_id=sand_id+1", "");
                }
                //set the id in the textbox of id
                DataTable tblorder_id = new DataTable();
                tblorder_id.Clear();
                tblorder_id = db.readdata("select*from sandat_id", "");
                txtorder_id.Text = Convert.ToString(tblorder_id.Rows[0][0]);

                numericmoney.Value = 0;
                txtnotes.Clear();
                txtsearch.Clear();
                simpleButton3.Enabled = true;
                
            }
            catch (Exception) { }
        }
            private void oldbalanceoncustomerandsupplier_Load(object sender, EventArgs e)
        {
            autonumber();
            dtpdate.Text = DateTime.Now.ToShortDateString();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            //validation to search
            if(radiocustomer.Checked==false&&radiosupplier.Checked==false)
            {
                MessageBox.Show("من فضلك حدد عمليه اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //customer
           else if(radiocustomer.Checked==true)
            {
                tbl.Clear();
                tbl = db.readdata("select cust_id as 'رقم العميل',cust_name as 'اسم العميل',identity_id as'الرقم التعريفي'  from customers where cust_name like N'%"+txtsearch.Text.Trim()+"%'", "");
                dgv1.DataSource = tbl;
            }
            //supplier
            else if (radiosupplier.Checked == true)
            {
                tbl.Clear();
                tbl = db.readdata("select sup_id as 'رقم المورد',sup_name as 'اسم المورد',identity_id as'الرقم التعريفي'  from suppliers where sup_name like N'%" + txtsearch.Text.Trim() + "%'", "");
                dgv1.DataSource = tbl;
            }
        }

        //add
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (numericmoney.Value <= 0)
            {
                MessageBox.Show("من فضلك ادخل المبلغ اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string d = "", t = "";
                d = dtpdate.Value.ToString("yyyy-MM-dd");
                t = DateTime.Now.ToShortTimeString();
                //add old money on customer
                if (radiocustomer.Checked == true)
                {
                    if (dgv1.Rows.Count >= 1)
                    {
                        //customer
                        db.excutedata("insert into customer_account values(" + txtorder_id.Text + "," + dgv1.CurrentRow.Cells[0].Value + ",N'" + dgv1.CurrentRow.Cells[1].Value + "',N'رصيد سابق',N'',0,N''," + numericmoney.Value + "," + numericmoney.Value + "," + numericmoney.Value + ",0,N'',N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + d + "',N'رصيد سابق',N'" + t + "',"+txtorder_id.Text+")", "تم الادخال بنجاح");

                        autonumber();
                    }

                }
                //supplier --add old money on supplier
                if (radiosupplier.Checked == true)
                {
                    if (dgv1.Rows.Count >= 1)
                    {
                        //insert into supplier
                        db.excutedata("insert into supplier_account values(" + txtorder_id.Text + "," + dgv1.CurrentRow.Cells[0].Value + ",N'" + dgv1.CurrentRow.Cells[1].Value + "',N'رصيد سابق',N'',0," + numericmoney.Value + "," + numericmoney.Value + ",N'" + txtnotes.Text.Trim() + "'," + numericmoney.Value + ",0,0,N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + d + "',N'رصيد سابق',N'',"+txtorder_id.Text+")", "تم الادخال بنجاح");
                        autonumber();
                    }
                }
            }
        }

        //update text box id of the operation-->get data of supplier or customer
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                if (txtorderid_update.Text == "")
                {
                    MessageBox.Show("من فضلك ادخل رقم العمليه اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    //customer
                    if (radiocustomer.Checked == true)
                    {
                        tbl.Clear();
                        tbl = db.readdata("select order_id as 'رقم العمليه',cust_name as 'اسم العميل',on_him as 'الرصيد السابق' from customer_account where order_id=" +txtorderid_update.Text.Trim() + "", "");
                        dgv1.DataSource = tbl;
                        simpleButton3.Enabled = false;
                    }
                    //supplier
                    else if(radiosupplier.Checked==true)
                    {
                        tbl.Clear();
                        tbl = db.readdata("select order_id as 'رقم العمليه',sup_name as 'اسم العميل',leh as 'الرصيد السابق' from supplier_account where order_id=" + txtorderid_update.Text.Trim() + "", "");
                        dgv1.DataSource = tbl;
                        simpleButton3.Enabled = false;
                    }
                }
                }
        }

        //update the operation
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (dgv1.Rows.Count >= 1)
            {
                //update customer
                if (radiocustomer.Checked == true)
                {
                    db.excutedata("update  customer_account set on_him="+numericmoney.Value+ ",total=" + numericmoney.Value + ",totalorder=" + numericmoney.Value + " where order_id=" + dgv1.CurrentRow.Cells[0].Value+"", "تم التعديل بنجاح");
                }
                //update supplier
                else if(radiosupplier.Checked==true)
                {
                    db.excutedata("update supplier_account set leh=" + numericmoney.Value + ",total="+numericmoney.Value+",totalorder="+numericmoney.Value+" where order_id=" + dgv1.CurrentRow.Cells[0].Value + "", "تم التعديل بنجاح");

                }
                autonumber();
            }
        }
    }
}
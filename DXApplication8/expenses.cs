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
    public partial class expenses : DevExpress.XtraEditors.XtraForm
    {
        public expenses()
        {
            InitializeComponent();
        }
        //call database class
        DataTable tbl = new DataTable();
        database db = new database();
        //autonumber
        private void autonumber()
        {
            //select max id from expenses table
            tbl.Clear();
            tbl = db.readdata("select*from expenses_id", "");
            //if thee is not data insert id=1 and show it in textbox of id
            if (tbl.Rows.Count < 1)
            {
                db.excutedata("insert into expenses_id values(1)", "");
            }
            //if there is data update the value of id and stet the value+1
            else if (tbl.Rows.Count >= 1)
            {
                db.excutedata("update expenses_id set id=id+1", "");
            }
            //show the new id in textbox of id
            DataTable tblorder_id = new DataTable();
            tblorder_id.Clear();
            tblorder_id = db.readdata("select*from expenses_id", "");
            txtorder_id.Text = Convert.ToString(tblorder_id.Rows[0][0]);
        }
        //get the total of all expenses you want to do
        private void total()
        {
            decimal total = 0;
            for(int i=0;i<=dgv.Rows.Count-1;i++)
            {
                total += Convert.ToDecimal(dgv.Rows[i].Cells[4].Value);

            }
            txttotal.Text = total.ToString();
        }
        //get the id of stoke 
        int stoke_id = Convert.ToInt32(Properties.Settings.Default.stoke_id);
        //fill combo box withtypes of expenses
        private void fillcbx()
        {
            cbxdeserved_type.DataSource = db.readdata("select*from deserved_type ", "");
            cbxdeserved_type.DisplayMember = "type_name";
            cbxdeserved_type.ValueMember = "type_id";
        }


            private void expenses_Load(object sender, EventArgs e)
        {
            fillcbx();
            dtpdate.Text = DateTime.Now.ToShortDateString();
            autonumber();
            //get the total money of selected user stoke
            tbl.Clear();
            tbl = db.readdata("select*from stoke_money where stoke_id="+Properties.Settings.Default.stoke_id+"", "");
            lblbalancenow.Text = Convert.ToString(tbl.Rows[0][1]);
        }

        private void tileItem4_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Close();
        }
        //add expenses
        private void btndown_Click(object sender, EventArgs e)
        {
            //validations
            if(numircprice.Value==0)
            {
                MessageBox.Show("من فضلك ادخل المبلغ", "",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else if(cbxdeserved_type.Text=="")
            {
                MessageBox.Show("من فضلك حدد التاريخ اولا", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(Convert.ToDecimal(lblbalancenow.Text)==0)
            {
                MessageBox.Show("من فضلك تاكد من انه يوجد رصيد في الخزنه اولا", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //set the user data in variables
                int order_id = Convert.ToInt32(txtorder_id.Text);
                int expense_id = Convert.ToInt32(cbxdeserved_type.SelectedValue);
                string expense_name = cbxdeserved_type.Text;
                string d = dtpdate.Value.ToString("yyyy-MM-dd");
                string notes = txtnotes.Text;
                decimal money = numircprice.Value;

           
                //add the value of this variables in datagridview
                dgv.Rows.Add(1);
                int rowindex = dgv.Rows.Count - 1;

                dgv.Rows[rowindex].Cells[0].Value =order_id ;
                dgv.Rows[rowindex].Cells[1].Value = expense_id;
                dgv.Rows[rowindex].Cells[2].Value = expense_name;
                dgv.Rows[rowindex].Cells[3].Value = notes;
                dgv.Rows[rowindex].Cells[4].Value = money;

                dgv.Rows[rowindex].Cells[5].Value = d;
               
                dgv.Rows[rowindex].Cells[6].Value = dgv.Rows.Count;
                autonumber();
                total();
        
}


        }

        //delete selected row from datagridview
        private void tileItem3_ItemClick(object sender, TileItemEventArgs e)
        {
            try
            {
                if (dgv.Rows.Count >= 1)
                {
                    int index = dgv.SelectedRows[0].Index;
                    dgv.Rows.RemoveAt(index);

                    //clear selection of row in datagridview
                    dgv.ClearSelection();
                    dgv.FirstDisplayedScrollingRowIndex = dgv.Rows.Count - 1;
                    dgv.Rows[dgv.Rows.Count - 1].Selected = true;
                   
                }
                total();
                if(dgv.Rows.Count<1)
                {
                    txttotal.Text ="0";
                }

            }
            catch (Exception) { }
        }

        // else auto number to  get stoke money
        private void autonumber2()
        {
            dgv.Rows.Clear();
            numircprice.Value = 0;
            txtnotes.Clear();
            txttotal.Text = "0";
            tbl.Clear();
            tbl = db.readdata("select*from stoke_money where stoke_id=" + Properties.Settings.Default.stoke_id + "", "");
            lblbalancenow.Text = Convert.ToString(tbl.Rows[0][1]);

        }
        private void tileItem5_ItemClick(object sender, TileItemEventArgs e)
        {
            autonumber2();
            tbl.Clear();
            tbl = db.readdata("select*from stoke_money where stoke_id=" + Properties.Settings.Default.stoke_id + "", "");
            lblbalancenow.Text = Convert.ToString(tbl.Rows[0][1]);

        }

        //insert data in deserved table
        private void تن_ItemClick(object sender, TileItemEventArgs e)
        {
            //check the money on stoke
            string d = dtpdate.Value.ToString("yyyy-MM-dd");
            if (Convert.ToDecimal(lblbalancenow.Text) < Convert.ToDecimal(txttotal.Text))
            {
                MessageBox.Show("من فضلك تاكد من المبلغ الموجود في الخزنه اولا المبلغ المنصرف اكبر من المبلغ الموجود في الخزنه", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //insert all data that exist in datagridview on deserved table and stoke withdrowal
                if (dgv.Rows.Count >= 1)
                {
                    for (int i = 0; i <= dgv.Rows.Count - 1; i++)
                    {
                        //insert into deserved table
                        db.excutedata("insert into deserved values("+dgv.Rows[i].Cells[0].Value+","+ dgv.Rows[i].Cells[1].Value + ",N'"+ dgv.Rows[i].Cells[2].Value + "',"+dgv.Rows[i].Cells[4].Value+",N'"+ dgv.Rows[i].Cells[3].Value + "',N'"+ d + "',N'"+Properties.Settings.Default.user_name+"',N'"+Properties.Settings.Default.branch_name+"')", "");
                        //insert into stoke withdrowal
                        db.excutedata("insert into stoke_withdrowal(stoke_id,money,date,name,type,notes,user_name,branch_name)values(" + stoke_id + "," + dgv.Rows[i].Cells[4].Value + ",N'" + d + "',N'عمليه صرف رقم'+N' '+N'" + dgv.Rows[i].Cells[0].Value + "',N'مصروفات يوميه ..سحب مباشر من الخزنه',N'" + dgv.Rows[i].Cells[3].Value + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "')", "");
                    }
                    //update stoke money and mince the money from selected stoke
                    db.excutedata("update stoke_money set money=money-" + txttotal.Text + " where stoke_id=" + stoke_id + "", "");

                }

                autonumber2();
                autonumber();
                MessageBox.Show("تم الادخال بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
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
    public partial class transferproductsbetweenstores : DevExpress.XtraEditors.XtraForm
    {
        public transferproductsbetweenstores()
        {
            InitializeComponent();
        }

        //call database class
        DataTable tbl = new DataTable();
        database db = new database();
        //fill comboboxes with stores 
        private void fillcbx()
        {
            cbxstorefrom.DataSource = db.readdata("select *from stores", "");
            cbxstorefrom.DisplayMember ="store_name";
            cbxstorefrom.ValueMember = "store_id";

            cbxstoreto.DataSource = db.readdata("select *from stores", "");
            cbxstoreto.DisplayMember = "store_name";
            cbxstoreto.ValueMember = "store_id";
        }
        //autonumber
        private void autonumber()
        {
            //get the max order id in transfereproductsbetweenstores table
            tbl.Clear();
            tbl = db.readdata("select max(order_id)from transfereproductsbetweenstores where branch_name=N'" + Properties.Settings.Default.branch_name + "'", "");
            //when the cell of order id in the table null set textbox of id =1
            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                txtorderid.Text = "1";
                txteznnumber.Text = "1";
            }
            else
            {
                //when the cell of order id in this cells not equal null set the value of this cell+1 and show it in the textbox of order id
                txtorderid.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
                txteznnumber.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }

            numericqty.Value = 0;
            txtpronamesearch.Clear();
            dgv.Rows.Clear();
            cbxstorefrom.Text = "اختر مخزن";
            cbxstoreto.Text = "اختر مخزن";
            lblitemscount.Text = Convert.ToString(dgv.Rows.Count);
            txtnotes.Clear();
        }
        private void transferproductsbetweenstores_Load(object sender, EventArgs e)
        {
            lblbranchname.Text = Properties.Settings.Default.branch_name;
            lblusername.Text = Properties.Settings.Default.user_name;

            fillcbx();
            autonumber();
           
            dtpdate.Text = DateTime.Now.ToShortDateString();
        }

        private void tileItem4_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Close();
        }
        //search about product with his name or part of his name
        private void txtpronamesearch_TextChanged(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readdata("select product_id as 'رقم المنتج',product_name as 'اسم المنتج' from products where product_name like N'%"+txtpronamesearch.Text.Trim()+"%'", "");
            dgvproducts.DataSource = tbl;
        }

        //drag the selected product in datagridview
        private void btndown2_Click(object sender, EventArgs e)
        {
            //validation before drag
            if(numericqty.Value==0)
            {
                MessageBox.Show("من فضلك ادخل الكميه المحوله اولا", "خطا",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else if(cbxstorefrom.Text==cbxstoreto.Text)
            {
                MessageBox.Show("من فضلك حدد مخزنين مختلفين هناك تشابه في اختيار المخازن لايمكن نقل بضاعه الي نفس المخزن المحول اليه", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(numericqty.Value>Convert.ToDecimal(lblqtyavaliablefrom.Text))
            {
                MessageBox.Show("من فضلك ...الكميه المطلوب نقلها اكبر من الكميه الموجوده في المخزن المرسل اليه !!!!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dgvproducts.Rows.Count >= 1)
            {
                //get the data of selected product
                DataTable tblitems = new DataTable();
                tblitems.Clear();

                DataTable tblunit = new DataTable();
                tblunit.Clear();
                tblitems = db.readdata("select*from products where product_id=" + dgvproducts.CurrentRow.Cells[0].Value + "", "");



                //product id
                int pro_id = Convert.ToInt32(dgvproducts.CurrentRow.Cells[0].Value);
                if (tblitems.Rows.Count >= 1)
                {
                    string unit = "";
                    tblunit.Clear();
                    tblunit = db.readdata("select*from product_units where pro_id=" + pro_id + "", "");
                    if (tblunit.Rows.Count > 1)
                    {
                        DataTable tblunitcheck = new DataTable();
                        tblunitcheck.Clear();
                        tblunitcheck = db.readdata("select*from product_units where pro_id=" + pro_id + " and Qtyinunit>1", "");
                        unit = Convert.ToString(tblunitcheck.Rows[0][2]);
                    }
                    else if (tblunit.Rows.Count == 1)
                    {

                        unit = Convert.ToString(tblunit.Rows[0][2]);
                    }

                    string product_id = tblitems.Rows[0][0].ToString();
                    string product_name = tblitems.Rows[0][1].ToString();
                    string product_unit = unit;
                    decimal Qty = numericqty.Value;







                    //drag variables in datagridview

                    dgv.Rows.Add(1);
                    int rowindex = dgv.Rows.Count - 1;

                    dgv.Rows[rowindex].Cells[0].Value = product_id;
                    dgv.Rows[rowindex].Cells[1].Value = product_name;
                    dgv.Rows[rowindex].Cells[2].Value = product_unit;
                    dgv.Rows[rowindex].Cells[3].Value = Qty;
                    dgv.Rows[rowindex].Cells[4].Value = cbxstorefrom.SelectedValue;
                    dgv.Rows[rowindex].Cells[5].Value = cbxstorefrom.Text;
                    dgv.Rows[rowindex].Cells[6].Value = cbxstoreto.SelectedValue;
                    dgv.Rows[rowindex].Cells[7].Value = cbxstoreto.Text;
                    dgv.Rows[rowindex].Cells[9].Value = dgv.Rows.Count;
                    lblitemscount.Text = Convert.ToString(dgv.Rows.Count);
                }





            }

            }

        private void cbxstorefrom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //show qty in the selected store from -->transfere from
        private void cbxstorefrom_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (dgvproducts.Rows.Count >= 1)
                {
                    int pro_id = Convert.ToInt32(dgvproducts.CurrentRow.Cells[0].Value);

                    DataTable tblQty = new DataTable();
                    tblQty.Clear();
                    tblQty = db.readdata("select *from item_card where pro_id=" + pro_id + " and store_id=" + cbxstorefrom.SelectedValue + "", "");

                    decimal ward = 0, monsarf = 0, final = 0;
                    for (int i = 0; i <= tblQty.Rows.Count - 1; i++)
                    {
                        ward += Convert.ToDecimal(tblQty.Rows[i][8]);
                        monsarf += Convert.ToDecimal(tblQty.Rows[i][9]);
                    }
                    final += ward - monsarf;
                    if (tblQty.Rows.Count >= 1)
                    {
                        lblqtyavaliablefrom.Text = final.ToString();
                    }
                    else
                    {
                        MessageBox.Show("المخزن المحول منه لايوجد منه كميات للمنتج "+" "+dgvproducts.CurrentRow.Cells[1].Value, "تنبيه هااااام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                }
            }
            catch (Exception) { }
        }
        //show qty in the selected store from -->transfere to
        private void cbxstoreto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (dgvproducts.Rows.Count >= 1)
                {
                    int pro_id = Convert.ToInt32(dgvproducts.CurrentRow.Cells[0].Value);

                    DataTable tblQty = new DataTable();
                    tblQty.Clear();
                    tblQty = db.readdata("select *from item_card where pro_id=" + pro_id + " and store_id=" + cbxstoreto.SelectedValue + "", "");

                    decimal ward = 0, monsarf = 0, final = 0;
                    for (int i = 0; i <= tblQty.Rows.Count - 1; i++)
                    {
                        ward += Convert.ToDecimal(tblQty.Rows[i][8]);
                        monsarf += Convert.ToDecimal(tblQty.Rows[i][9]);
                    }
                    final += ward - monsarf;
                    if (tblQty.Rows.Count >= 1)
                    {
                        lblqtyavilableto.Text = final.ToString();
                    }
                   
                }
            }
            catch (Exception) { }
        }
        //add action
        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            if (dgv.Rows.Count >= 1)
            {
                string d = dtpdate.Value.ToString("yyyy-MM-dd");
                for (int i = 0; i <= dgv.Rows.Count - 1; i++)
                {
                    
                    ////وارد لمخزن
                    //string discription = "وارد من مخزن" + " " + Convert.ToString(dgv.Rows[i].Cells[5].Value) + "الي مخزن" + " " + Convert.ToString(dgv.Rows[i].Cells[7].Value) + " " + "بيان رقم" + txtorderid.Text;
                    //db.excutedata("insert into item_card values(" + dgv.Rows[i].Cells[0].Value + ",N'" + dgv.Rows[i].Cells[1].Value + "'," + dgv.Rows[i].Cells[6].Value + ",N'" + dgv.Rows[i].Cells[7].Value + "',N'" + d + "'," + dgv.Rows[i].Cells[3].Value + ",N'" + dgv.Rows[i].Cells[2].Value + "',N'" + discription + "'," + dgv.Rows[i].Cells[3].Value + ",0,0,N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + dgv.Rows[i].Cells[8].Value + "'," + txtorderid.Text + ",N'وارد')", "");
                    ////وارد للمخزن
                    decimal ward = 0, monsarf = 0, final = 0;
                    tbl.Clear();
                    tbl = db.readdata("select*from item_card where pro_id=" + dgv.Rows[i].Cells[0].Value + " and store_id=" + dgv.Rows[i].Cells[6].Value + "", "");
                    for (int x = 0; x <= tbl.Rows.Count - 1; x++)
                    {

                        ward += Convert.ToDecimal(tbl.Rows[x][8]);
                        monsarf += Convert.ToDecimal(tbl.Rows[x][9]);
                    }
                    final += (ward - monsarf)+Convert.ToDecimal(dgv.Rows[i].Cells[3].Value);
                    //db.excutedata("update item_card set balance="+final+" where store_id="+ dgv.Rows[i].Cells[6].Value + "", "");

                    //وارد لمخزن
                    string discription = "وارد من مخزن" +" "+ Convert.ToString(dgv.Rows[i].Cells[5].Value) +" "+ "الي مخزن" + " " + Convert.ToString(dgv.Rows[i].Cells[7].Value) + " " + "بيان رقم" + txtorderid.Text;
                    db.excutedata("insert into item_card values(" + dgv.Rows[i].Cells[0].Value + ",N'" + dgv.Rows[i].Cells[1].Value + "'," + dgv.Rows[i].Cells[6].Value + ",N'" + dgv.Rows[i].Cells[7].Value + "',N'" + d + "'," + dgv.Rows[i].Cells[3].Value + ",N'" + dgv.Rows[i].Cells[2].Value + "',N'" + discription + "'," + dgv.Rows[i].Cells[3].Value + ",0,"+final+",N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + dgv.Rows[i].Cells[8].Value + "'," + txtorderid.Text + ",N'وارد')", "");
                    //وارد للمخزن
                    //=========================================================================================
                    //=========================================================================================
                    


                    //منصرف لمخزن
                    string discription_monsarf = "منصرف من مخزن" +" "+ Convert.ToString(dgv.Rows[i].Cells[5].Value) +" " +"الي مخزن" + " " + Convert.ToString(dgv.Rows[i].Cells[7].Value) + " " + "بيان رقم" + txtorderid.Text;

                    //db.excutedata("insert into item_card values(" + dgv.Rows[i].Cells[0].Value + ",N'" + dgv.Rows[i].Cells[1].Value + "'," + dgv.Rows[i].Cells[4].Value + ",N'" + dgv.Rows[i].Cells[5].Value + "',N'" + d + "'," + dgv.Rows[i].Cells[3].Value + ",N'" + dgv.Rows[i].Cells[2].Value + "',N'" + discription_monsarf+ "',0," + dgv.Rows[i].Cells[3].Value + ",0,N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + dgv.Rows[i].Cells[8].Value + "'," + txtorderid.Text + ",N'منصرف')", "");

                    //منصرف للمخزن
                    decimal ward_monsarf = 0, monsarf_monsarf = 0, final_monsarf = 0;
                    tbl.Clear();
                    tbl = db.readdata("select*from item_card where pro_id=" + dgv.Rows[i].Cells[0].Value + " and store_id=" + dgv.Rows[i].Cells[4].Value + "", "");
                    for (int m = 0; m <= tbl.Rows.Count - 1; m++)
                    {

                        ward_monsarf += Convert.ToDecimal(tbl.Rows[m][8]);
                        monsarf_monsarf += Convert.ToDecimal(tbl.Rows[m][9]);
                    }
                    final_monsarf += (ward - monsarf)- Convert.ToDecimal(dgv.Rows[i].Cells[3].Value);
                    db.excutedata("insert into item_card values(" + dgv.Rows[i].Cells[0].Value + ",N'" + dgv.Rows[i].Cells[1].Value + "'," + dgv.Rows[i].Cells[4].Value + ",N'" + dgv.Rows[i].Cells[5].Value + "',N'" + d + "'," + dgv.Rows[i].Cells[3].Value + ",N'" + dgv.Rows[i].Cells[2].Value + "',N'" + discription_monsarf + "',0," + dgv.Rows[i].Cells[3].Value + ","+final_monsarf+",N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + dgv.Rows[i].Cells[8].Value + "'," + txtorderid.Text + ",N'منصرف')", "");


                    //ادخال في الجدول transfereproductsbetweenstores
                    db.excutedata("insert into transfereproductsbetweenstores values("+txtorderid.Text+","+txteznnumber.Text+","+dgv.Rows[i].Cells[0].Value+ ",N'" + dgv.Rows[i].Cells[1].Value + "'," + dgv.Rows[i].Cells[3].Value + ",N'" + dgv.Rows[i].Cells[2].Value + "'," + dgv.Rows[i].Cells[4].Value + ",N'" + dgv.Rows[i].Cells[5].Value + "'," + dgv.Rows[i].Cells[6].Value + ",N'" + dgv.Rows[i].Cells[7].Value + "',N'" + dgv.Rows[i].Cells[8].Value + "',N'"+txtnotes.Text.Trim()+"'," + dgv.Rows[i].Cells[9].Value + ",N'"+d+"',N'"+Properties.Settings.Default.user_name+"',N'"+Properties.Settings.Default.branch_name+"')", "");

                    //==============================================
                    //==تظبيط جدول المخازن بتاع products_Qtyinstore
                    decimal qty = Convert.ToDecimal(dgv.Rows[i].Cells[3].Value);
                    db.excutedata("update products_Qtyinstore set Qty=Qty-" + qty + " where store_id=" + dgv.Rows[i].Cells[4].Value + " and pro_id=" + dgv.Rows[i].Cells[0].Value + "", "");

                    DataTable tblchecktable = new DataTable();
                    tblchecktable.Clear();
                    tblchecktable = db.readdata("select*from products_Qtyinstore where pro_id="+dgv.Rows[i].Cells[0].Value+" and store_id="+dgv.Rows[i].Cells[6].Value+"", "");
                    if(tblchecktable.Rows.Count>=1)
                    {
                        db.excutedata("update products_Qtyinstore set Qty=Qty+" + qty + " where store_id=" + dgv.Rows[i].Cells[6].Value + " and pro_id=" + dgv.Rows[i].Cells[0].Value + "", "");

                    }
                    else if(tblchecktable.Rows.Count<1)
                    {
                        db.excutedata("insert into products_Qtyinstore values("+dgv.Rows[i].Cells[0].Value+",N'"+ dgv.Rows[i].Cells[1].Value + "',"+qty+","+ dgv.Rows[i].Cells[6].Value + ",N'"+ dgv.Rows[i].Cells[7].Value + "')", "");
                    }


                }
                autonumber();
                MessageBox.Show("تم التحويل بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void tileItem5_ItemClick(object sender, TileItemEventArgs e)
        {
            autonumber();
        }

        //change the id of action
        private void radiochangebillid_CheckedChanged(object sender, EventArgs e)
        {
            if (radiochangebillid.Checked == true)
            {
                panelchangebillid.Visible = true;
                tbl = db.readdata("select max(order_id)from transfereproductsbetweenstores where branch_name=N'" + Properties.Settings.Default.branch_name + "'", "");
                if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
                {
                    txtorder_idnow.Text = "1";
                }
                else
                {
                    txtorder_idnow.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
                }

            }
            else if (radiochangebillid.Checked == false)
            {
                panelchangebillid.Visible = false;

            }
        }

        private void btnchange_Click(object sender, EventArgs e)
        {
            label26.Text = "";
            txtorder_idnow.Text = (Convert.ToDecimal(txtorder_idnow.Text) + 1).ToString();
            txtorder_idnew.Text = (Convert.ToDecimal(txtorder_idnow.Text) + 1).ToString();
           
        }

        private void btnooook_Click(object sender, EventArgs e)
        {
            txtorderid.Text = txtorder_idnew.Text;
            panelchangebillid.Visible = false;
            radiochangebillid.Checked = false;
           
        }

        private void btncloooose_Click(object sender, EventArgs e)
        {
            panelchangebillid.Visible = false;
        }
        //delete row from datagridview
        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.Rows.Count >= 1)
                {
                    int index = dgv.SelectedRows[0].Index;
                    dgv.Rows.RemoveAt(index);
                    dgv.ClearSelection();
                    dgv.FirstDisplayedScrollingRowIndex = dgv.Rows.Count - 1;
                    dgv.Rows[dgv.Rows.Count - 1].Selected = true;
                }
                lblitemscount.Text = Convert.ToString(dgv.Rows.Count);
            }
            catch (Exception) { }
        }
    }
}
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
    public partial class sales : DevExpress.XtraEditors.XtraForm
    {
        public sales()
        {
            InitializeComponent();
        }

        //call database class
        database db = new database();
        DataTable tbl = new DataTable();

        //autonumber
        private void autonumber()
        {
           //get id

            tbl.Clear();
            tbl = db.readdata("select*from sandat_id", "");
            //insert id if the table of id is null
            if (tbl.Rows.Count < 1)
            {
                db.excutedata("insert into sandat_id values(1000000)", "");
            }
            //update id if the cell of id in the table is not null
            else if (tbl.Rows.Count >= 1)
            {
                db.excutedata("update sandat_id set sand_id=sand_id+1", "");
            }
            //show the id in the textbox of id
            DataTable tblorder_id = new DataTable();
            tblorder_id.Clear();
            tblorder_id = db.readdata("select*from sandat_id", "");
            txtorderid.Text = Convert.ToString(tblorder_id.Rows[0][0]);
            txtreturn_id.Text = Convert.ToString(tblorder_id.Rows[0][0]);

            tileItem1.Enabled = true;
            dgv.Rows.Clear();
            numircprice.Value = 0;
            txtnotes.Clear();
            txttotalbakey.Text = "0";
            txttotalmadfou3.Text = "0";
            txttotalorder.Text = "0";
            //show the id in the textbox of ezn number but check if there is the peremestion to user to add this manual or automatic
            if (Properties.Settings.Default.eznopen == true)
            {
                txteznnumber.Text = "";
            }
            else if (Properties.Settings.Default.eznopen == false)
            {
                txteznnumber.Text = txtorderid.Text;
                txteznnumber.Enabled = false;
            }

            simpleButton8.Enabled = true;
            btnupdate.Enabled = true;
            txtparcode.Focus();

        }
        //id of returns
        private void autonumberreturns()
        {
            if (radioreturns.Checked == true)
            {
                //validiation returns
               
                txttotalmadfou3.Text = "0.0";
                if (cbxchooseproduct.Text == "")
                {
                    MessageBox.Show("من فضلك قم بتعريف المنتجات وادخالها اولا قبل عمل اي فاتوره", "تنبيها هام جدااااا", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (cbxstore.Text == "")
                {
                    MessageBox.Show("من فضلك قم بتعريف المخازن وادخالها اولا قم عمل اي فاتوره", "تنبيها هام جدااااا", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (cbxmandoup.Text == "")
                {
                    MessageBox.Show("من فضلك قم بتعريف المناديب وادخالها اولا قم عمل اي فاتوره", "تنبيها هام جدااااا", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                //do this when the returns button checked is true
                txttotalbakey.Text = "0.0";
                txttotalorder.Text = "0.0";
                radioagel.Checked = false;
                radiocash.Checked = false;
                lblitemscount.Text = "0";
                radioreturns.Checked = true;
                tileItem7.Enabled = true;
                tileItem1.Enabled = false;
            }
        }
        //fill cbx depending on the user choose
        private void fillcbx()
        {
            cbxchooseproduct.DataSource = db.readdata("select*from products", "");
            cbxchooseproduct.DisplayMember = "product_name";
            cbxchooseproduct.ValueMember = "product_id";

            if (radiocustomer.Checked == true)
            {
                cbxcustomer.DataSource = db.readdata("select*from customers", "");
                cbxcustomer.DisplayMember = "cust_name";
                cbxcustomer.ValueMember = "cust_id";
            }
            else if (radiosupplier.Checked == true)
            {
                cbxcustomer.DataSource = db.readdata("select*from suppliers", "");
                cbxcustomer.DisplayMember = "sup_name";
                cbxcustomer.ValueMember = "sup_id";
            }
            else if (radioemployee.Checked == true)
            {

            }

            cbxmandoup.DataSource = db.readdata("select*from mandoup", "");
            cbxmandoup.DisplayMember = "mandoup_name";
            cbxmandoup.ValueMember = "mandoup_id";

            cbxstore.DataSource = db.readdata("select*from stores", "");
            cbxstore.DisplayMember = "store_name";
            cbxstore.ValueMember = "store_id";

        }
        private void tileItem6_ItemClick(object sender, TileItemEventArgs e)
        {
            //groupotherscreens.Visible = true;
            panel2.Visible = true;
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            groupotherscreens.Visible = false;
            
        }

        private void tileItem4_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Close();
        }
        //get the stoke id of the user
        int stoke_id = Properties.Settings.Default.stoke_id;
        private void sales_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.eznopen == true)
            {
                txteznnumber.Text = "";
            }
            else if (Properties.Settings.Default.eznopen == false)
            {
                txteznnumber.Text = txtorderid.Text;
                txteznnumber.Enabled = false;
            }
            autonumber();
            autonumberreturns();
            fillcbx();
            dtpdate.Text = DateTime.Now.ToShortDateString();

            dtptime.Text = DateTime.Now.ToShortTimeString();
            txtparcode.Focus();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            groupshowcustomerdetails.Visible = false;
        }

        private void btnshowcustomerdetails_Click(object sender, EventArgs e)
        {
            groupshowcustomerdetails.Visible = true;
        }
        //open form of store to add new store from sales form and reload data again
        private void btnaddstore_Click(object sender, EventArgs e)
        {
            ddnewstore frm = new ddnewstore();
            frm.ShowDialog();
            cbxstore.DataSource = db.readdata("select*from stores", "");
            cbxstore.DisplayMember = "store_name";
            cbxstore.ValueMember = "store_id";
        }
        //open form of mandoup to add new mandoup from sales form and reload data again
        private void btnaddmandoup_Click(object sender, EventArgs e)
        {
            mandoup frm = new mandoup();
            frm.ShowDialog();
            cbxmandoup.DataSource = db.readdata("select*from mandoup", "");
            cbxmandoup.DisplayMember = "mandoup_name";
            cbxmandoup.ValueMember = "mandoup_id";
        }
        //open form of customers,suppliers,employee to add new customers,suppliers,employee depending on the user choose from sales form and reload data again

        private void btncustomer_Click(object sender, EventArgs e)
        {
            if (radiocustomer.Checked == true)
            {
                customer_data frm = new customer_data();
                frm.ShowDialog();

                cbxcustomer.DataSource = db.readdata("select*from customers", "");
                cbxcustomer.DisplayMember = "cust_name";
                cbxcustomer.ValueMember = "cust_id";
            }
            else if (radiosupplier.Checked == true)
            {
                suppliers frm = new suppliers();
                frm.ShowDialog();

                cbxcustomer.DataSource = db.readdata("select*from suppliers", "");
                cbxcustomer.DisplayMember = "sup_name";
                cbxcustomer.ValueMember = "sup_id";
            }
            else if (radioemployee.Checked == true)
            {

            }
        }
        private void btndown_Click(object sender, EventArgs e)
        {
           //validation to choose the product
            if (cbxchooseproduct.Text == "اختر منتج")
            {
                MessageBox.Show("من فضلك اختر منتج اولا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbxstore.Text == "اختر مخزن")
            {
                MessageBox.Show("من فضلك اختر مخزن اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (radiogomla.Checked == false && radionosgomla.Checked == false && radiotagzaaa.Checked == false&&radiolastprice.Checked==false)
            {
                MessageBox.Show("من فضلك حدد اذا كان البيع للمنتج بسعر الجمله ام التجزئه اولا", "تنبيه");
                return;
            }
            else
            {
                //get the data of product selected
                DataTable tblitems = new DataTable();
                tblitems.Clear();
                //get the data of product unit
                DataTable tblunit = new DataTable();
                tblitems.Clear();
                //get the data of product selected
                tblitems = db.readdata("select *from products where product_id=" + cbxchooseproduct.SelectedValue + "", "");

                //if there is data to product selected
                if (tblitems.Rows.Count >= 1)
                {
                    //set the data on this variables

                    string product_id = tblitems.Rows[0][0].ToString();
                    string product_name = tblitems.Rows[0][1].ToString();
                    string Qty = "1";

                    string product_unit = tblitems.Rows[0][17].ToString();
                    decimal discount = 0;


                    //quantity of product
                    DataTable tblqty = new DataTable();
                    tblqty.Clear();
                    tblqty = db.readdata("select*from item_card where pro_id=" + cbxchooseproduct.SelectedValue + " and store_id=" + cbxstore.SelectedValue + "", "");
                    decimal ward = 0, monsarf = 0, final = 0;
                    for (int i = 0; i <= tblqty.Rows.Count - 1; i++)
                    {
                        ward += Convert.ToDecimal(tblqty.Rows[i][8]);
                        monsarf += Convert.ToDecimal(tblqty.Rows[i][9]);
                    }
                    final = ward - monsarf;
                    decimal qtyinstorenow = final;


                    //===============================================================================سعر الشراء
                    //get the purchase price
                    DataTable tblbuyprice = new DataTable();
                    tblbuyprice.Clear();
                    tblbuyprice = db.readdata("select*from buy_details where product_id=" + cbxchooseproduct.SelectedValue + " and unit_name=N'" + product_unit + "'", "");
                    decimal totalqty = 0, totalprices = 0;
                    for (int x = 0; x <= tblbuyprice.Rows.Count - 1; x++)
                    {
                        totalprices += Convert.ToDecimal(tblbuyprice.Rows[x][10]);
                        totalqty += Convert.ToDecimal(tblbuyprice.Rows[x][4]);
                    }
                    decimal buyprice = 0;
                    if (tblbuyprice.Rows.Count >= 1)
                    {
                        buyprice = totalprices / totalqty;
                    }
                    else
                    {
                        buyprice = 0;
                    }
                    //===============================================================================
                    //add the data on datagridview
                    //====================================================================
                    dgv.Rows.Add(1);

                    int rowindex = dgv.Rows.Count - 1;



                    dgv.Rows[rowindex].Cells[0].Value = product_id;
                    dgv.Rows[rowindex].Cells[1].Value = product_name;
                    dgv.Rows[rowindex].Cells[3].Value = Qty;

                    dgv.Rows[rowindex].Cells[2].Value = product_unit;
                    dgv.Rows[rowindex].Cells[8].Value = qtyinstorenow;
                    dgv.Rows[rowindex].Cells[9].Value = buyprice;

                    //get the units of product
                    tblunit = db.readdata("select * from product_units where pro_id = " + cbxchooseproduct.SelectedValue + "and unit_name = N'" + product_unit + "'", "");

                    //real sales price
                    decimal realprice = 0;
                    try
                    {
                        if (Convert.ToString(tblitems.Rows[0][12]) == "غير خاضع للضريبه")
                        {
                            if (radiogomla.Checked == true)
                            {
                                realprice = Convert.ToDecimal(tblitems.Rows[0][2]) / Convert.ToDecimal(tblunit.Rows[0][3]);
                            }
                            else if (radionosgomla.Checked == true)
                            {
                                realprice = Convert.ToDecimal(tblitems.Rows[0][3]) / Convert.ToDecimal(tblunit.Rows[0][3]);

                            }
                            else if (radiotagzaaa.Checked == true)
                            {
                                realprice = Convert.ToDecimal(tblitems.Rows[0][4]) / Convert.ToDecimal(tblunit.Rows[0][3]);

                            }
                            else if(radiolastprice.Checked==true)
                            {
                                realprice = Convert.ToDecimal(tblunit.Rows[0][4]) / Convert.ToDecimal(tblunit.Rows[0][3]);

                            }
                        }
                        //choose the price if gomla or nos gomla or tagziaa
                        else if ((Convert.ToString(tblitems.Rows[0][12]) == "خاضع للضريبه"))
                        {
                            decimal tax = (Convert.ToDecimal(tblitems.Rows[0][2]) / Convert.ToDecimal(tblunit.Rows[0][3])) * Convert.ToDecimal(tblitems.Rows[0][5]);
                            if (radiogomla.Checked == true)
                            {
                                realprice = (Convert.ToDecimal(tblitems.Rows[0][2]) / Convert.ToDecimal(tblunit.Rows[0][3])) + tax;
                            }
                            else if (radionosgomla.Checked == true)
                            {
                                realprice = Convert.ToDecimal(tblitems.Rows[0][3]) / Convert.ToDecimal(tblunit.Rows[0][3]) + tax;

                            }
                            else if (radiotagzaaa.Checked == true)
                            {
                                realprice = Convert.ToDecimal(tblitems.Rows[0][4]) / Convert.ToDecimal(tblunit.Rows[0][3]) + tax;

                            }
                            else if (radiolastprice.Checked == true)
                            {
                                realprice = Convert.ToDecimal(tblunit.Rows[0][4]) / Convert.ToDecimal(tblunit.Rows[0][3]);

                            }
                        }
                    }
                    catch (Exception) { }
                    //get the last sales price
                    decimal lastrealpricecost = Convert.ToDecimal(tblunit.Rows[0][4]) / Convert.ToDecimal(tblunit.Rows[0][3]);
                    if (lastrealpricecost<buyprice)
                    {
                        MessageBox.Show("سعر البيع لهذا المنتج اقل من سعر الشراء تاكد من بياناتك قبل الحفظ","تنبيه هااااام",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    if (lastrealpricecost == buyprice)
                    {
                        MessageBox.Show("سعر البيع لهذا المنتج يساوي سعر الشراء تاكد من بياناتك قبل الحفظ", "تنبيه هاااااام",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    dgv.Rows[rowindex].Cells[4].Value = Math.Round(realprice, 2);

                    decimal total = (Convert.ToDecimal(Qty) * Convert.ToDecimal(realprice)) - Convert.ToDecimal(discount);



                    //============================================================
                    dgv.Rows[rowindex].Cells[5].Value = discount;
                    dgv.Rows[rowindex].Cells[6].Value = Math.Round(total, 2);
                    dgv.Rows[rowindex].Cells[10].Value = dgv.Rows.Count;
                    dgv.Rows[rowindex].Cells[11].Value = cbxstore.Text;
                    dgv.Rows[rowindex].Cells[12].Value = cbxstore.SelectedValue;
                    dgv.Rows[rowindex].Cells[13].Value = Properties.Settings.Default.branch_name;


                    //get the total of all bill
                    decimal totalall = 0;
                    for (int i = 0; i <= dgv.Rows.Count - 1; i++)
                    {
                        totalall += Convert.ToDecimal(dgv.Rows[i].Cells[6].Value);
                        dgv.ClearSelection();
                        dgv.FirstDisplayedScrollingRowIndex = dgv.Rows.Count - 1;
                        dgv.Rows[dgv.Rows.Count - 1].Selected = true;
                    }
                    txttotalorder.Text = Math.Round(totalall, 2).ToString();
                    lblitemscount.Text = dgv.Rows.Count.ToString();

                }
            }
        }
        //delete the product from datagridview and calculate the total of all bill again
        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count >= 1)
            {
                int index = dgv.SelectedRows[0].Index;
                dgv.Rows.RemoveAt(index);

                if (dgv.Rows.Count <= 0)
                {
                    txttotalorder.Text = "0";
                }
                try
                {
                    decimal totalall = 0;
                    for (int i = 0; i <= dgv.Rows.Count - 1; i++)
                    {
                        totalall += Convert.ToDecimal(dgv.Rows[i].Cells[6].Value);
                    }
                    txttotalorder.Text = Math.Round(totalall, 2).ToString();
                    lblitemscount.Text = dgv.Rows.Count.ToString();
                    //clear selection of the row
                    dgv.ClearSelection();
                    dgv.FirstDisplayedScrollingRowIndex = dgv.Rows.Count - 1;
                    dgv.Rows[dgv.Rows.Count - 1].Selected = true;
                }
                catch (Exception)
                {
                }
            }
            txtparcode.Focus();
        }

        private void radiosupplier_CheckedChanged(object sender, EventArgs e)
        {
            //change the text of label depending on the user choose
            if (radiosupplier.Checked == true)
            {
                cbxcustomer.DataSource = db.readdata("select*from suppliers", "");
                cbxcustomer.DisplayMember = "sup_name";
                cbxcustomer.ValueMember = "sup_id";

                label3.Text = "اختر مورد :";
                numircprice.Enabled = true;
            }
            else if (radiocustomer.Checked == true)
            {
                fillcbx();

                label3.Text = "اختر عميل :";

            }
            else if (radioemployee.Checked == true)
            {
                label3.Text = "اختر موظف :";

            }
        }

        private void btnsearchforproducts_Click(object sender, EventArgs e)
        {

        }

        //search about product name by the letter of his name
        private void txtpronamesearch_TextChanged(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readdata("select product_id as 'رقم المنتج',product_name as 'اسم المنتج' from products where product_name like N'%" + txtpronamesearch.Text.Trim() + "%'", "");
            dgvproducts.DataSource = tbl;
        }

        //drag the product from the datagridview
        private void btndown2_Click(object sender, EventArgs e)
        {
            //validations

            if (cbxstore.Text == "اختر مخزن")
            {
                MessageBox.Show("من فضلك اختر مخزن اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (radiogomla.Checked == false && radionosgomla.Checked == false && radiotagzaaa.Checked == false&&radiolastprice.Checked==false)
            {
                MessageBox.Show("من فضلك حدد اذا كان البيع للمنتج بسعر الجمله ام التجزئه اولا", "تنبيه");
                return;
            }
            else
            {
                if (dgvproducts.Rows.Count >= 1)
                {
                    //to get the data of selected product
                    DataTable tblitems = new DataTable();
                    tblitems.Clear();
                    //to get the product unit of selected product
                    DataTable tblunit = new DataTable();
                    tblitems.Clear();
                    //to get the data of selected product on datagridview
                    tblitems = db.readdata("select *from products where product_id=" + dgvproducts.CurrentRow.Cells[0].Value + "", "");

                    if (tblitems.Rows.Count >= 1)
                    {

                        //set data of product in variables
                        string product_id = tblitems.Rows[0][0].ToString();
                        string product_name = tblitems.Rows[0][1].ToString();
                        string Qty = "1";

                        string product_unit = tblitems.Rows[0][17].ToString();
                        decimal discount = 0;

                        //insert data in item card
                        DataTable tblqty = new DataTable();
                        tblqty.Clear();
                        tblqty = db.readdata("select*from item_card where pro_id=" + dgvproducts.CurrentRow.Cells[0].Value + " and store_id=" + cbxstore.SelectedValue + "", "");
                        decimal ward = 0, monsarf = 0, final = 0;
                        for (int i = 0; i <= tblqty.Rows.Count - 1; i++)
                        {
                            ward += Convert.ToDecimal(tblqty.Rows[i][8]);
                            monsarf += Convert.ToDecimal(tblqty.Rows[i][9]);
                        }
                        final = ward - monsarf;
                        decimal qtyinstorenow = final;


                        //get last purchase price
                        //===============================================================================سعر الشراء
                        DataTable tblbuyprice = new DataTable();
                        tblbuyprice.Clear();
                        tblbuyprice = db.readdata("select*from buy_details where product_id=" + dgvproducts.CurrentRow.Cells[0].Value + "", "");
                        decimal totalqty = 0, totalprices = 0;
                        for (int x = 0; x <= tblbuyprice.Rows.Count - 1; x++)
                        {
                            totalprices += Convert.ToDecimal(tblbuyprice.Rows[x][10]);
                            totalqty += Convert.ToDecimal(tblbuyprice.Rows[x][4]);
                        }
                        decimal buyprice = totalprices / totalqty;
                        //====================================================================

                        //drag data in datagridview
                        dgv.Rows.Add(1);

                        int rowindex = dgv.Rows.Count - 1;



                        dgv.Rows[rowindex].Cells[0].Value = product_id;
                        dgv.Rows[rowindex].Cells[1].Value = product_name;
                        dgv.Rows[rowindex].Cells[3].Value = Qty;

                        dgv.Rows[rowindex].Cells[2].Value = product_unit;
                        dgv.Rows[rowindex].Cells[8].Value = qtyinstorenow;
                        dgv.Rows[rowindex].Cells[9].Value = buyprice;

                        //get units of product to drad the unit in datagridview
                        tblunit = db.readdata("select * from product_units where pro_id = " + dgvproducts.CurrentRow.Cells[0].Value + "and unit_name = N'" + product_unit + "'", "");

                        //get the real price of gomla and nos gomla and tagziaa
                        decimal realprice = 0;
                        try
                        {
                            if (Convert.ToString(tblitems.Rows[0][12]) == "غير خاضع للضريبه")
                            {
                                if (radiogomla.Checked == true)
                                {
                                    realprice = Convert.ToDecimal(tblitems.Rows[0][2]) / Convert.ToDecimal(tblunit.Rows[0][3]);
                                }
                                else if (radionosgomla.Checked == true)
                                {
                                    realprice = Convert.ToDecimal(tblitems.Rows[0][3]) / Convert.ToDecimal(tblunit.Rows[0][3]);

                                }
                                else if (radiotagzaaa.Checked == true)
                                {
                                    realprice = Convert.ToDecimal(tblitems.Rows[0][4]) / Convert.ToDecimal(tblunit.Rows[0][3]);

                                }
                                else if (radiolastprice.Checked == true)
                                {
                                    realprice = Convert.ToDecimal(tblunit.Rows[0][4]) / Convert.ToDecimal(tblunit.Rows[0][3]);

                                }
                            }
                            else if ((Convert.ToString(tblitems.Rows[0][12]) == "خاضع للضريبه"))
                            {
                                decimal tax = (Convert.ToDecimal(tblitems.Rows[0][2]) / Convert.ToDecimal(tblunit.Rows[0][3])) * Convert.ToDecimal(tblitems.Rows[0][5]);
                                if (radiogomla.Checked == true)
                                {
                                    realprice = (Convert.ToDecimal(tblitems.Rows[0][2]) / Convert.ToDecimal(tblunit.Rows[0][3])) + tax;
                                }
                                else if (radionosgomla.Checked == true)
                                {
                                    realprice = Convert.ToDecimal(tblitems.Rows[0][3]) / Convert.ToDecimal(tblunit.Rows[0][3]) + tax;

                                }
                                else if (radiotagzaaa.Checked == true)
                                {
                                    realprice = Convert.ToDecimal(tblitems.Rows[0][4]) / Convert.ToDecimal(tblunit.Rows[0][3]) + tax;

                                }
                                else if (radiolastprice.Checked == true)
                                {
                                    realprice = Convert.ToDecimal(tblunit.Rows[0][4]) / Convert.ToDecimal(tblunit.Rows[0][3]);

                                }
                            }
                        }
                        catch (Exception) { }

                        //get the cost of last sales price
                        decimal lastrealpricecost = Convert.ToDecimal(tblunit.Rows[0][4]) / Convert.ToDecimal(tblunit.Rows[0][3]);
                        if (lastrealpricecost < buyprice)
                        {
                            MessageBox.Show("سعر البيع لهذا المنتج اقل من سعر الشراء تاكد من بياناتك قبل الحفظ", "تنبيه هااااام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (lastrealpricecost == buyprice)
                        {
                            MessageBox.Show("سعر البيع لهذا المنتج يساوي سعر الشراء تاكد من بياناتك قبل الحفظ", "تنبيه هاااااام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }


                        dgv.Rows[rowindex].Cells[4].Value = Math.Round(realprice, 2);

                        decimal total = (Convert.ToDecimal(Qty) * Convert.ToDecimal(realprice)) - Convert.ToDecimal(discount);



                        //============================================================
                        dgv.Rows[rowindex].Cells[5].Value = discount;
                        dgv.Rows[rowindex].Cells[6].Value = Math.Round(total, 2);
                        dgv.Rows[rowindex].Cells[10].Value = dgv.Rows.Count;
                        dgv.Rows[rowindex].Cells[11].Value = cbxstore.Text;
                        dgv.Rows[rowindex].Cells[12].Value = cbxstore.SelectedValue;
                        dgv.Rows[rowindex].Cells[13].Value = Properties.Settings.Default.branch_name;




                        //get the total of all bill
                        decimal totalall = 0;
                        for (int i = 0; i <= dgv.Rows.Count - 1; i++)
                        {
                            totalall += Convert.ToDecimal(dgv.Rows[i].Cells[6].Value);
                            dgv.ClearSelection();
                            dgv.FirstDisplayedScrollingRowIndex = dgv.Rows.Count - 1;
                            dgv.Rows[dgv.Rows.Count - 1].Selected = true;
                        }
                        txttotalorder.Text = Math.Round(totalall, 2).ToString();
                        lblitemscount.Text = dgv.Rows.Count.ToString();
                        //cbxchooseproduct.Text = "اختر منتج";

                    }
                }
            }
        }

        private void txttotalmadfou3_TextChanged(object sender, EventArgs e)
        {
            try
            {



                decimal bakey = 0;
                bakey = Convert.ToDecimal(txttotalorder.Text) - Convert.ToDecimal(txttotalmadfou3.Text);
                txttotalbakey.Text = bakey.ToString();


            }
            catch (Exception) { }
        }

        //calculate the total after discount when enter enter on numeric 
        private void numircprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                decimal totalafterdiscount = 0;
                decimal total = 0;
                for (int i = 0; i <= dgv.Rows.Count - 1; i++)
                {
                    total += Convert.ToDecimal(dgv.Rows[i].Cells[6].Value);



                }
                totalafterdiscount += total - Convert.ToDecimal(numircprice.Text);


                txttotalorder.Text = totalafterdiscount.ToString();
                txttotalbakey.Text = (Convert.ToDecimal(txttotalmadfou3.Text) - totalafterdiscount).ToString();
            }
        }

        //change when choose
        private void radiocash_CheckedChanged(object sender, EventArgs e)
        {
            if (radiocash.Checked == true)
            {
                txttotalmadfou3.Text = txttotalorder.Text.ToString();
            }
        }

        private void radioagel_CheckedChanged(object sender, EventArgs e)
        {
            if (radioagel.Checked == true)
            {
                txttotalmadfou3.Text = "0.0";
                decimal bakey = 0;
                bakey = Convert.ToDecimal(txttotalorder.Text) - Convert.ToDecimal(txttotalmadfou3.Text);
                txttotalbakey.Text = bakey.ToString();

            }
        }

        //get the product by his parcode
        private void txtparcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {


                //validations
                if (txtparcode.Text == "")
                {
                    MessageBox.Show("من فضلك ادخل الباركود اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cbxstore.Text == "اختر مخزن")
                {
                    MessageBox.Show("من فضلك اختر مخزن اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (radiogomla.Checked == false && radionosgomla.Checked == false && radiotagzaaa.Checked == false&&radiolastprice.Checked==false)
                {
                    MessageBox.Show("من فضلك حدد اذا كان البيع للمنتج بسعر الجمله ام التجزئه اولا", "تنبيه");
                    return;
                }
                else
                {
                    //get the product data
                    DataTable tblitems = new DataTable();
                    tblitems.Clear();
                    //get the product units
                    DataTable tblunit = new DataTable();
                    tblitems.Clear();
                    //get the product data by his parcode
                    tblitems = db.readdata("select *from products where parcode=" + txtparcode.Text.Trim() + "", "");

                    //if there is data of product
                    if (tblitems.Rows.Count >= 1)
                    {

                        //set data on variables
                        string product_id = tblitems.Rows[0][0].ToString();
                        string product_name = tblitems.Rows[0][1].ToString();
                        string Qty = "1";

                        string product_unit = tblitems.Rows[0][17].ToString();
                        decimal discount = 0;


                        //insert data in item card to calculate the quantity
                        DataTable tblqty = new DataTable();
                        tblqty.Clear();
                        tblqty = db.readdata("select*from item_card where pro_id=" + tblitems.Rows[0][0] + " and store_id=" + cbxstore.SelectedValue + "", "");
                        decimal ward = 0, monsarf = 0, final = 0;
                        for (int i = 0; i <= tblqty.Rows.Count - 1; i++)
                        {
                            ward += Convert.ToDecimal(tblqty.Rows[i][8]);
                            monsarf += Convert.ToDecimal(tblqty.Rows[i][9]);
                        }
                        final = ward - monsarf;
                        decimal qtyinstorenow = final;


                        //===============================================================================سعر الشراء
                        //calcualte the purchase price
                        DataTable tblbuyprice = new DataTable();
                        tblbuyprice.Clear();
                        tblbuyprice = db.readdata("select*from buy_details where product_id=" + tblitems.Rows[0][0] + "", "");
                        decimal totalqty = 0, totalprices = 0;
                        for (int x = 0; x <= tblbuyprice.Rows.Count - 1; x++)
                        {
                            totalprices += Convert.ToDecimal(tblbuyprice.Rows[x][10]);
                            totalqty += Convert.ToDecimal(tblbuyprice.Rows[x][4]);
                        }
                        decimal buyprice = totalprices / totalqty;

                        //===============================================================================

                        //====================================================================
                        //drag the data in datagridview
                        dgv.Rows.Add(1);

                        int rowindex = dgv.Rows.Count - 1;

                        dgv.Rows[rowindex].Cells[0].Value = product_id;
                        dgv.Rows[rowindex].Cells[1].Value = product_name;
                        dgv.Rows[rowindex].Cells[3].Value = Qty;

                        dgv.Rows[rowindex].Cells[2].Value = product_unit;
                        dgv.Rows[rowindex].Cells[8].Value = qtyinstorenow;
                        dgv.Rows[rowindex].Cells[9].Value = buyprice;

                        //select the units of selected product

                        tblunit = db.readdata("select * from product_units where pro_id = " + tblitems.Rows[0][0] + "and unit_name = N'" + product_unit + "'", "");

                        //get the real price depending on gomla or nos gomla or tagziaa
                        decimal realprice = 0;
                        try
                        {
                            if (Convert.ToString(tblitems.Rows[0][12]) == "غير خاضع للضريبه")
                            {
                                if (radiogomla.Checked == true)
                                {
                                    realprice = Convert.ToDecimal(tblitems.Rows[0][2]) / Convert.ToDecimal(tblunit.Rows[0][3]);
                                }
                                else if (radionosgomla.Checked == true)
                                {
                                    realprice = Convert.ToDecimal(tblitems.Rows[0][3]) / Convert.ToDecimal(tblunit.Rows[0][3]);

                                }
                                else if (radiotagzaaa.Checked == true)
                                {
                                    realprice = Convert.ToDecimal(tblitems.Rows[0][4]) / Convert.ToDecimal(tblunit.Rows[0][3]);

                                }
                                else if (radiolastprice.Checked == true)
                                {
                                    realprice = Convert.ToDecimal(tblunit.Rows[0][4]) / Convert.ToDecimal(tblunit.Rows[0][3]);

                                }
                            }
                            else if ((Convert.ToString(tblitems.Rows[0][12]) == "خاضع للضريبه"))
                            {
                                decimal tax = (Convert.ToDecimal(tblitems.Rows[0][2]) / Convert.ToDecimal(tblunit.Rows[0][3])) * Convert.ToDecimal(tblitems.Rows[0][5]);
                                if (radiogomla.Checked == true)
                                {
                                    realprice = (Convert.ToDecimal(tblitems.Rows[0][2]) / Convert.ToDecimal(tblunit.Rows[0][3])) + tax;
                                }
                                else if (radionosgomla.Checked == true)
                                {
                                    realprice = Convert.ToDecimal(tblitems.Rows[0][3]) / Convert.ToDecimal(tblunit.Rows[0][3]) + tax;

                                }
                                else if (radiotagzaaa.Checked == true)
                                {
                                    realprice = Convert.ToDecimal(tblitems.Rows[0][4]) / Convert.ToDecimal(tblunit.Rows[0][3]) + tax;

                                }
                                else if (radiolastprice.Checked == true)
                                {
                                    realprice = Convert.ToDecimal(tblunit.Rows[0][4]) / Convert.ToDecimal(tblunit.Rows[0][3]);

                                }
                            }
                        }
                        catch (Exception) { }

                        //get the last cost of sales price
                        decimal lastrealpricecost = Convert.ToDecimal(tblunit.Rows[0][4]) / Convert.ToDecimal(tblunit.Rows[0][3]);
                        if (lastrealpricecost < buyprice)
                        {
                            MessageBox.Show("سعر البيع لهذا المنتج اقل من سعر الشراء تاكد من بياناتك قبل الحفظ", "تنبيه هااااام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (lastrealpricecost == buyprice)
                        {
                            MessageBox.Show("سعر البيع لهذا المنتج يساوي سعر الشراء تاكد من بياناتك قبل الحفظ", "تنبيه هاااااام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }


                        dgv.Rows[rowindex].Cells[4].Value = Math.Round(realprice, 2);

                        decimal total = (Convert.ToDecimal(Qty) * Convert.ToDecimal(realprice)) - Convert.ToDecimal(discount);



                        //============================================================
                        dgv.Rows[rowindex].Cells[5].Value = discount;
                        dgv.Rows[rowindex].Cells[6].Value = Math.Round(total, 2);
                        dgv.Rows[rowindex].Cells[10].Value = dgv.Rows.Count;
                        dgv.Rows[rowindex].Cells[11].Value = cbxstore.Text;
                        dgv.Rows[rowindex].Cells[12].Value = cbxstore.SelectedValue;
                        dgv.Rows[rowindex].Cells[13].Value = Properties.Settings.Default.branch_name;




                        //get the total of the bill
                        decimal totalall = 0;
                        for (int i = 0; i <= dgv.Rows.Count - 1; i++)
                        {
                            totalall += Convert.ToDecimal(dgv.Rows[i].Cells[6].Value);
                            dgv.ClearSelection();
                            dgv.FirstDisplayedScrollingRowIndex = dgv.Rows.Count - 1;
                            dgv.Rows[dgv.Rows.Count - 1].Selected = true;
                        }
                        txttotalorder.Text = Math.Round(totalall, 2).ToString();
                        lblitemscount.Text = dgv.Rows.Count.ToString();
                        //cbxchooseproduct.Text = "اختر منتج";

                    }
                }
                txtparcode.Text = "";
                txtparcode.Focus();
            }
        }

        private void radiochangebillid_CheckedChanged(object sender, EventArgs e)
        {
            if (radiochangebillid.Checked == true)
            {
                panelchangebillid.Visible = true;
                tbl = db.readdata("select*from sandat_id", "");
                if (tbl.Rows.Count < 1)
                {
                    db.excutedata("insert into sandat_id values(1000000)", "");
                }
                //if there is data set sandat_id= 1000000+1
                else if (tbl.Rows.Count >= 1)
                {
                    db.excutedata("update sandat_id set sand_id=sand_id+1", "");
                }
                //show id in the textbox of order id
                DataTable tblorder_id = new DataTable();
                tblorder_id.Clear();
                tblorder_id = db.readdata("select*from sandat_id", "");
                txtorder_idnow.Text = Convert.ToString(tblorder_id.Rows[0][0]);
            }
        }
        //change the order id and ezn number and returns number
        private void btnchange_Click(object sender, EventArgs e)
        {
            label26.Text = "";
            txtorder_idnow.Text = (Convert.ToDecimal(txtorder_idnow.Text) + 1).ToString();
            txtorder_idnew.Text = (Convert.ToDecimal(txtorder_idnow.Text) + 1).ToString();
            txtparcode.Focus();
        }

        //button to done change of the order id and ezn number and returns id to new order id
        private void btnooook_Click(object sender, EventArgs e)
        {

            txtorderid.Text = txtorder_idnew.Text;
            txtreturn_id.Text = txtorder_idnew.Text;
            txteznnumber.Text = txtorder_idnew.Text;

            panelchangebillid.Visible = false;
            radiochangebillid.Checked = false;
            txtparcode.Focus();
        }

        private void btncloooose_Click(object sender, EventArgs e)
        {
            panelchangebillid.Visible = false;
        }
        //change big unit of the product
        private void btnchangeunit_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count >= 1)
            {

                dgv.Enabled = false;
                groupchangeunit.Visible = true;
                lblpro_id.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
                lblpro_name.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
                lblunit_name.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value);

                //get the units of the product
                cbxunit.DataSource = db.readdata("select*from product_units where pro_id=" + dgv.CurrentRow.Cells[0].Value + "", "");
                cbxunit.DisplayMember = "unit_name";

            }

        }
        //chnge he price depending on the unit
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            decimal unit_price = 0;
            DataTable tblunitprice = new DataTable();
            tblunitprice.Clear();
            tblunitprice = db.readdata("select*from product_units where pro_id=" + lblpro_id.Text + " and unit_name=N'" + cbxunit.Text.Trim() + "'", "");
            unit_price = Convert.ToDecimal(tblunitprice.Rows[0][4]);
            dgv.CurrentRow.Cells[2].Value = cbxunit.Text;
            dgv.CurrentRow.Cells[4].Value = unit_price;
            groupchangeunit.Visible = false;
            dgv.Enabled = true;

            dgv.CurrentRow.Cells[9].Value = Convert.ToString(tblunitprice.Rows[0][5]);



        }

        private void dgv_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        //change data and update it from any change happen datagridview
        private void dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            decimal discount = 0, purchase_price = 0, Qty = 0;

           
            try
            {

                int index = dgv.SelectedRows[0].Index;
                //get discount and qty and purchase price
                discount = Convert.ToDecimal(dgv.Rows[index].Cells[5].Value);
                purchase_price = Convert.ToDecimal(dgv.Rows[index].Cells[4].Value);
                Qty = Convert.ToDecimal(dgv.Rows[index].Cells[3].Value);

                //calculate the total of product
                decimal total = 0;
                total = (Qty * purchase_price) - discount;

                dgv.Rows[index].Cells[6].Value = total;

                //calculate the total of all bill again
                decimal totalorder = 0;
                for (int i = 0; i <= dgv.Rows.Count - 1; i++)
                {
                    totalorder += Convert.ToDecimal(dgv.Rows[i].Cells[6].Value);
                }
                txttotalorder.Text = Math.Round(totalorder, 2).ToString();
                decimal bakey = Convert.ToDecimal(txttotalmadfou3.Text) - Convert.ToDecimal(txttotalorder.Text);
                txttotalbakey.Text = bakey.ToString();
            }

            catch (Exception)
            {


            }
        }

        //printing
        private void print()
        {
            //get the branch name open
            string branch_name = Properties.Settings.Default.branch_name;
            //print 8cm
            if (Properties.Settings.Default.salesprintkind == "8cm")
            {

                try
                {
                    int id = Convert.ToInt32(txtorderid.Text);

                    DataTable tblprint = new DataTable();
                    tblprint.Clear();
                    //quary of the printing
                    tblprint = db.readdata("select order_id as 'رقم الفاتوره',products.product_name as 'اسم المنتج',customer.cust_name as'اسم العميل',sales_details.Qty as 'الكميه',price as 'السعر',discount as 'الخصم',total as 'الاجمالي',madfou3 as 'المدفوع',bakey as 'الباقي',totalorder as 'الاجمالي الكلي',unit as 'الوحده',sales_details.tax_value as 'الضريبه',price_tax as 'السعر بعد الضريبه',sales_details.user_name as 'اسم المستخدم',time as 'الوقت',sales_details.date as 'التاريخ',type as 'نوع الفاتوره',sales_details.branch_name as 'الفرع',sales_details.total_on_customer as 'اجمالي اللي عليه' from products,sales_details,customer where sales_details.product_id=products.product_id and sales_details.cust_id=customer.cust_id and sales_details.order_id=" + id + " and sales_details.branch_name=N'" + branch_name + "'", "");
                    printing frm = new printing();
                    frm.crystalReportViewer1.RefreshReport();

                }
                catch (Exception) { }
            }
            //print A4
            else if (Properties.Settings.Default.salesprintkind == "A4")
            {
                try
                {
                    int id = Convert.ToInt32(txtorderid.Text);
                    DataTable tblprint = new DataTable();
                    tblprint.Clear();
                    //quary of the printing
                    tblprint = db.readdata("select settingprinting_bills.logo as 'اللوجو',settingprinting_bills.name as 'اسم الشركه',settingprinting_bills.address as 'العنوان',settingprinting_bills.phone1 as 'فون1',settingprinting_bills.phone2 as'فون2',settingprinting_bills.phone3 as'فون3',settingprinting_bills.discription as 'الوصف',settingprinting_bills.commerical_re as'السجل التجاري',settingprinting_bills.tax_re as'التسجيل الضريبي', sales_details.order_id as 'رقم الفاتوره',order_ezn as 'رقم الاذن',pro_name as 'اسم المنتج',Qty as 'الكميه',price_tax as 'السعر',discountonallorder as 'الخصم الكلي',total as 'الاجمالي',totalorder as 'الاجمالي الكلي',unit as 'الوحده',time as 'الوقت',sales_details.user_name as 'المستخدم',sales_details.branch_name as 'الفرع',sales_details.date as 'التاريخ',type as 'نوع الاوردر',notes_item as 'ملاحظه صنف',sales_details.notes as 'ملاحظه عامه', store_name as 'المخزن',mandoup_name as 'المندوب',sales_details.billfor as 'فاتوره ل',sales_details_money.madfou3 as'المدفوع',sales_details_money.person_name as 'اسم الشخص',sales_details_money.totalonhim as 'اجمالي اللي علي الشخص',sales_details_money.branch_name as 'الفرع في الجدول التاني sales_money' from sales_details,settingprinting_bills,sales_details_money where   sales_details.order_id=sales_details_money.order_id  and sales_details.order_id=" + txtorderid.Text+" and sales_details.branch_name=N'"+Properties.Settings.Default.branch_name+"' and sales_details_money.branch_name=sales_details.branch_name", "");
                    //printing form
                    printing frm = new printing();
                    frm.crystalReportViewer1.RefreshReport();
                    //report form
                   sales_print rpt = new sales_print();
                    rpt.SetDatabaseLogon("", "", Properties.Settings.Default.servername, Properties.Settings.Default.databasename);
                    rpt.SetDataSource(tblprint);
                    //parameters
                    rpt.SetParameterValue("id", id);
                    rpt.SetParameterValue("branch_name", branch_name);
                    rpt.SetParameterValue("branch_name_money", branch_name);

                    frm.crystalReportViewer1.ReportSource = rpt;
                    frm.ShowDialog();
                    //System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                    //rpt.PrintOptions.PrinterName = Properties.Settings.Default.printername;
                    //rpt.PrintToPrinter(1, true, 0, 0);
                }
                catch (Exception) { }




            }
        }
        private void tileItem5_ItemClick(object sender, TileItemEventArgs e)
        {
            autonumber();
            radioreturns.Checked = false;
        }

        //add bill
        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            //validations
            if (radiocustomer.Checked == false && radiosupplier.Checked == false && radioemployee.Checked == false)
            {
                MessageBox.Show("من فضلك حدد عمليه اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(cbxcustomer.Text=="")
            {
                MessageBox.Show("من فضلك اختر لمن هذه الفاتره ولاتترك اسم الخانه فارغ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            if (radiocustomer.Checked == true)
            {
                if (radioagel.Checked == false && radiocash.Checked == false)
                {
                    MessageBox.Show("من فضلك اختر اما اذا كانت الفاتوره كاش ام اجل اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (radioagel.Checked == true && Convert.ToDecimal(txttotalmadfou3.Text) >= Convert.ToDecimal(txttotalorder.Text))
                {
                    MessageBox.Show("خطا", "من فضلك تاكد من بيانات الفاتوره انت تريد حفظ فاتوره اجل وقمت بدفع اجمالي مبلغ الفاتوره بالكامل انت تعامل الفاتوره معامله كاش الان ....", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (radiocash.Checked == true && Convert.ToDecimal(txttotalmadfou3.Text) < Convert.ToDecimal(txttotalorder.Text))
                {
                    MessageBox.Show("خطا", "من فضلك تاكد من بيانات الفاتوره انت تريد حفظ فاتوره كاش وقمت بدفع  مبلغ اقل من اجمالي مبلغ الفاتوره  انت تعامل الفاتوره معامله اجل الان ....", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (Convert.ToDecimal(txttotalmadfou3.Text) == 0)
                {
                    if (MessageBox.Show("هل انت متاكد من ان المبلغ المدفوع يساوي صفر 0", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    {
                        return;
                    }
                }

                if (txteznnumber.Text == "")
                {
                    MessageBox.Show("من فضلك ادخل رقم الاذن اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                
                string d = dtpdate.Value.ToString("yyyy-MM-dd");
                string type = "";
                if (radioagel.Checked == true)
                {
                    type = "اجل";
                }
                else if (radiocash.Checked == true)
                {
                    type = "كاش";
                }
                string t = DateTime.Now.ToString("HH:MM");
                string billfor = "عميل";
                //ادخال في جدول ال sales
                //get the data of customer account
                DataTable tbltotalonhim = new DataTable();
                tbltotalonhim.Clear();
                tbltotalonhim = db.readdata("select*from customer_account where cust_id=" + cbxcustomer.SelectedValue + "", "");
                decimal totalonhim = 0, onhim = 0, sadad = 0;
                for (int y = 0; y <= tbltotalonhim.Rows.Count - 1; y++)
                {
                    onhim += Convert.ToDecimal(tbltotalonhim.Rows[y][9]);
                    sadad += Convert.ToDecimal(tbltotalonhim.Rows[y][10]);
                }
                totalonhim = onhim - sadad;
                //insrt the bill in sales and sales details table
                db.excutedata("insert into sales values(" + txtorderid.Text + "," + txteznnumber.Text + "," + cbxcustomer.SelectedValue + "," + numircprice.Value + "," + txttotalorder.Text + ",0,N'" + Properties.Settings.Default.user_name + "',N'" + t + "',N'" + d + "',N'" + type + "',N'" + Properties.Settings.Default.branch_name + "',N'" + txtnotes.Text.Trim() + "',N'" + cbxstore.Text + "'," + cbxstore.SelectedValue + "," + cbxmandoup.SelectedValue + ",N'" + cbxmandoup.Text + "',N'عميل'," + lblitemscount.Text + ")", "");
                db.excutedata("insert into sales_details_money values("+txtorderid.Text+",N'"+cbxcustomer.Text+"',"+txttotalmadfou3.Text+","+totalonhim+",N'"+billfor+"',N'"+Properties.Settings.Default.branch_name+"')", "");
                for (int i = 0; i <= dgv.Rows.Count - 1; i++)
                {
                    //ادخال في جدول الsaeles_details
                    db.excutedata("insert into sales_details values(" + txtorderid.Text + "," + txteznnumber.Text + "," + dgv.Rows[i].Cells[0].Value + ",N'" + dgv.Rows[i].Cells[1].Value + "'," + cbxcustomer.SelectedValue + "," + dgv.Rows[i].Cells[3].Value + "," + dgv.Rows[i].Cells[4].Value + "," + dgv.Rows[i].Cells[5].Value + "," + numircprice.Value + "," + dgv.Rows[i].Cells[6].Value + "," + txttotalorder.Text + ",N'" + dgv.Rows[i].Cells[2].Value + "',0," + dgv.Rows[i].Cells[4].Value + ",N'" + Properties.Settings.Default.user_name + "',N'" + t + "',N'" + d + "',N'" + type + "',N'" + Properties.Settings.Default.branch_name + "',N'" + dgv.Rows[i].Cells[7].Value + "',N'" + txtnotes.Text.Trim() + "'," + dgv.Rows[i].Cells[10].Value + ",N'" + dgv.Rows[i].Cells[11].Value + "'," + dgv.Rows[i].Cells[12].Value + "," + cbxmandoup.SelectedValue + ",N'" + cbxmandoup.Text.Trim() + "',N'" + billfor + "'," + lblitemscount.Text + "," + dgv.Rows[i].Cells[8].Value + "," + dgv.Rows[i].Cells[9].Value + ")", "");


                    DataTable tblsmallunitupdateprice = new DataTable();
                    tblsmallunitupdateprice.Clear();
                    tblsmallunitupdateprice = db.readdata("select*from product_units where pro_id=" + dgv.Rows[i].Cells[0].Value + " and unit_name=N'" + dgv.Rows[i].Cells[2].Value + "'", "");

                    //تعديل سعر الصنف للسعر الجديد
                    string unit_name = Convert.ToString(dgv.Rows[i].Cells[2].Value);
                    db.excutedata("update product_units set unitpricesales="+ dgv.Rows[i].Cells[4].Value + " where pro_id="+dgv.Rows[i].Cells[0].Value+" and unit_name=N'"+unit_name+"' ", "");
                    //=======================================================
                    DataTable tblsmallqty = new DataTable();
                    tblsmallqty.Clear();
                    tblsmallqty = db.readdata("select*from products where product_id=" + dgv.Rows[i].Cells[0].Value + "", "");


                    decimal smallqty = Convert.ToDecimal(tblsmallqty.Rows[0][25]);

                    //real qty by unit that choosed
                    decimal realqty = 0;
                    if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3]) > 1)
                    {
                        realqty += Convert.ToDecimal(dgv.Rows[i].Cells[3].Value);
                    }
                    else if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3]) == 1)
                    {
                        realqty += Convert.ToDecimal(dgv.Rows[i].Cells[3].Value) * smallqty;
                    }
                    //ادخال في جدول ال items_card
                    string discription = "منصرف من عمليه بيع للعميل " + " " + cbxcustomer.Text + " " + "عمليه رقم" + " " + txtorderid.Text;
                    db.excutedata("insert into item_card values(" + dgv.Rows[i].Cells[0].Value + ",N'" + dgv.Rows[i].Cells[1].Value + "'," + dgv.Rows[i].Cells[12].Value + ",N'" + dgv.Rows[i].Cells[11].Value + "',N'" + d + "'," + realqty + ",N'" + dgv.Rows[i].Cells[2].Value + "',N'" + discription + "',0," + realqty + ",0,N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + txtnotes.Text.Trim() + "'," + txtorderid.Text + ",N'منصرف')", "");

                    //تعديل الكميات
                    db.excutedata("update products_Qty set Qty=Qty-" + realqty + " where pro_id=" + dgv.Rows[i].Cells[0].Value + "", "");
                    DataTable tblchecktable1 = new DataTable();
                    tblchecktable1.Clear();
                    tblchecktable1 = db.readdata("select*from products_Qtyinstore where pro_id=" + dgv.Rows[i].Cells[0].Value + " and store_id=" + dgv.Rows[i].Cells[12].Value + "", "");
                    if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3]) > 1)
                    {
                        if (tblchecktable1.Rows.Count >= 1)
                        {
                            //update quantity in products_Qtyinstore if there is data
                            db.excutedata("update products_Qtyinstore set Qty=Qty-" + dgv.Rows[i].Cells[3].Value + " where pro_id=" + dgv.Rows[i].Cells[0].Value + " and store_id=" + dgv.Rows[i].Cells[12].Value + "", "");
                        }
                        //if there is no data insert the quantity in products_Qtyinstore
                        else if (tblchecktable1.Rows.Count < 1)
                        {
                            db.excutedata("insert into products_Qtyinstore values(" + dgv.Rows[i].Cells[0].Value + ",N'" + dgv.Rows[i].Cells[1].Value + "'," + Convert.ToDecimal(dgv.Rows[i].Cells[3].Value) * -1 + "," + dgv.Rows[i].Cells[12].Value + ",N'" + dgv.Rows[i].Cells[11].Value + "')", "");
                        }
                    }
                    else if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3]) == 1)
                    {
                        if (tblchecktable1.Rows.Count >= 1)
                        {
                            db.excutedata("update products_Qtyinstore set Qty=Qty-" + realqty + " where pro_id=" + dgv.Rows[i].Cells[0].Value + " and store_id=" + dgv.Rows[i].Cells[12].Value + "", "");
                        }
                        else if (tblchecktable1.Rows.Count < 1)
                        {
                            db.excutedata("insert into products_Qtyinstore values(" + dgv.Rows[i].Cells[0].Value + ",N'" + dgv.Rows[i].Cells[1].Value + "'," + realqty * -1 + "," + dgv.Rows[i].Cells[12].Value + ",N'" + dgv.Rows[i].Cells[11].Value + "')", "");

                        }
                    }

                    //حساب العميل
                    db.excutedata("insert into customer_account values(" + txtorderid.Text + "," + cbxcustomer.SelectedValue + ",N'" + cbxcustomer.Text + "',N'" + discription + "',N'" + dgv.Rows[i].Cells[1].Value + "'," + dgv.Rows[i].Cells[3].Value + ",N'" + dgv.Rows[i].Cells[2].Value + "'," + dgv.Rows[i].Cells[6].Value + "," + txttotalorder.Text + "," + dgv.Rows[i].Cells[6].Value + ",0,N'" + dgv.Rows[i].Cells[7].Value + "',N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + d + "',N'" + type + "',N'" + t + "'," + txtorderid.Text + ")", "");


                }
                //خصم
                if (numircprice.Value != 0)
                {
                    db.excutedata("insert into customer_account values(" + txtorderid.Text + "," + cbxcustomer.SelectedValue + ",N'" + cbxcustomer.Text + "',N'خصم',N'-',0,N'-'," + numircprice.Value + "," + numircprice.Value + ",0," + numircprice.Value + ",N'',N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + d + "',N'" + type + "',N'" + t + "'," + txtorderid.Text + ")", "");

                }

                string discription2 = "[سداد] من عمليه بيع للعميل]" + " " + cbxcustomer.Text + " " + "عمليه رقم" + " " + txtorderid.Text;
                if (Convert.ToDecimal(txttotalmadfou3.Text) > 0)
                {
                    //customer account
                    db.excutedata("insert into customer_account values(" + txtorderid.Text + "," + cbxcustomer.SelectedValue + ",N'" + cbxcustomer.Text + "',N'" + discription2 + "',N'',0,N''," + txttotalmadfou3.Text + "," + txttotalmadfou3.Text + ",0," + txttotalmadfou3.Text + ",N'',N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + d + "',N'" + type + "',N'" + t + "'," + txtorderid.Text + ")", "");
                    //الخزنه
                    //stoke insert
                    db.excutedata("insert into stoke_insert (stoke_id,money,date,name,type,notes,user_name,branch_name,order_id2) values(" + stoke_id + "," + txttotalmadfou3.Text + ",'" + d + "',N'" + discription2 + "',N'عمليه بيع',N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "'," + txtorderid.Text + ")", "");
                    //get the money of user stoke
                    tbl.Clear();
                    tbl = db.readdata("select*from stoke_money where stoke_id=" + stoke_id + "", "");
                    if (tbl.Rows.Count >= 1)
                    {

                        //update money if there is data
                        db.excutedata("update stoke_money set money=money+" + txttotalmadfou3.Text + " where stoke_id=" + stoke_id + "", "");
                    }
                    else if (tbl.Rows.Count < 1)
                    {
                        //insert money if tere is no data
                        db.excutedata("insert into stoke_money values(" + stoke_id + "," + txttotalmadfou3.Text + ")", "");
                    }
                }

            }
        

            //suppliers bill
            else if (radiosupplier.Checked == true)
            {
                //validations
                //===================================================================
                if (radioagel.Checked == false && radiocash.Checked == false)
                {
                    MessageBox.Show("من فضلك اختر اما اذا كانت الفاتوره كاش ام اجل اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (radioagel.Checked == true && Convert.ToDecimal(txttotalmadfou3.Text) >= Convert.ToDecimal(txttotalorder.Text))
                {
                    MessageBox.Show("خطا", "من فضلك تاكد من بيانات الفاتوره انت تريد حفظ فاتوره اجل وقمت بدفع اجمالي مبلغ الفاتوره بالكامل انت تعامل الفاتوره معامله كاش الان ....", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (radiocash.Checked == true && Convert.ToDecimal(txttotalmadfou3.Text) < Convert.ToDecimal(txttotalorder.Text))
                {
                    MessageBox.Show("خطا", "من فضلك تاكد من بيانات الفاتوره انت تريد حفظ فاتوره كاش وقمت بدفع  مبلغ اقل من اجمالي مبلغ الفاتوره  انت تعامل الفاتوره معامله اجل الان ....", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (Convert.ToDecimal(txttotalmadfou3.Text) == 0)
                {
                    if (MessageBox.Show("هل انت متاكد من ان المبلغ المدفوع يساوي صفر 0", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    {
                        return;
                    }
                }

                if (txteznnumber.Text == "")
                {
                    MessageBox.Show("من فضلك ادخل رقم الاذن اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }


                //=====================================================================

               

                decimal order_id = Convert.ToDecimal(txtorderid.Text) + Convert.ToDecimal(100000);
                string discriptionsupplier = "فاتوره مبيعات للمورد" + " " + cbxcustomer.Text + " " + "عمليه مبيعات رقم" + " " + txtorderid.Text;

                string d = dtpdate.Value.ToString("yyyy-MM-dd");
                string t = dtptime.Value.ToString("HH-MM");
                string type = "";
                if (radioagel.Checked == true)
                {
                    type = "اجل";
                }
                else if (radiocash.Checked == true)
                {
                    type = "كاش";
                }
                string billforsupplier = "مورد";
                //ادخال في جدول ال sales

                //insert data in sales table
                db.excutedata("insert into sales values(" + txtorderid.Text + "," + txteznnumber.Text + "," + cbxcustomer.SelectedValue + "," + numircprice.Value + "," + txttotalorder.Text + ",0,N'" + Properties.Settings.Default.user_name + "',N'" + t + "',N'" + d + "',N'" + type + "',N'" + Properties.Settings.Default.branch_name + "',N'" + txtnotes.Text.Trim() + "',N'" + cbxstore.Text + "'," + cbxstore.SelectedValue + "," + cbxmandoup.SelectedValue + ",N'" + cbxmandoup.Text + "',N'" + billforsupplier + "'," + lblitemscount.Text + ")", "");

                //get the data of supplier
                DataTable tbltotalonhim = new DataTable();
                tbltotalonhim.Clear();
                tbltotalonhim = db.readdata("select*from supplier_account where sup_id=" + cbxcustomer.SelectedValue + "", "");
                decimal totalonhim = 0, onhim = 0, sadad = 0;
                for (int y = 0; y <= tbltotalonhim.Rows.Count - 1; y++)
                {
                    onhim += Convert.ToDecimal(tbltotalonhim.Rows[y][9]);
                    sadad += Convert.ToDecimal(tbltotalonhim.Rows[y][10]);
                }
                totalonhim = onhim - sadad;
                //insert data in sales details
                db.excutedata("insert into sales_details_money values(" + txtorderid.Text + ",N'" + cbxcustomer.Text + "'," + txttotalmadfou3.Text + "," + totalonhim + ",N'" + billforsupplier + "',N'" + Properties.Settings.Default.branch_name + "')", "");
         

                    for (int i = 0; i <= dgv.Rows.Count - 1; i++)
                {
                    //ادخال في جدول الsaeles_details
                    db.excutedata("insert into sales_details values(" + txtorderid.Text + "," + txteznnumber.Text + "," + dgv.Rows[i].Cells[0].Value + ",N'" + dgv.Rows[i].Cells[1].Value + "'," + cbxcustomer.SelectedValue + "," + dgv.Rows[i].Cells[3].Value + "," + dgv.Rows[i].Cells[4].Value + "," + dgv.Rows[i].Cells[5].Value + "," + numircprice.Value + "," + dgv.Rows[i].Cells[6].Value + "," + txttotalorder.Text + ",N'" + dgv.Rows[i].Cells[2].Value + "',0," + dgv.Rows[i].Cells[4].Value + ",N'" + Properties.Settings.Default.user_name + "',N'" + t + "',N'" + d + "',N'" + type + "',N'" + Properties.Settings.Default.branch_name + "',N'" + dgv.Rows[i].Cells[7].Value + "',N'" + txtnotes.Text.Trim() + "'," + dgv.Rows[i].Cells[10].Value + ",N'" + dgv.Rows[i].Cells[11].Value + "'," + dgv.Rows[i].Cells[12].Value + "," + cbxmandoup.SelectedValue + ",N'" + cbxmandoup.Text.Trim() + "',N'" + billforsupplier + "'," + lblitemscount.Text + "," + dgv.Rows[i].Cells[8].Value + "," + dgv.Rows[i].Cells[9].Value + ")", "");


                    DataTable tblsmallunitupdateprice = new DataTable();
                    tblsmallunitupdateprice.Clear();
                    tblsmallunitupdateprice = db.readdata("select*from product_units where pro_id=" + dgv.Rows[i].Cells[0].Value + " and unit_name=N'" + dgv.Rows[i].Cells[2].Value + "'", "");

                    //تعديل سعر الصنف للسعر الجديد
                    string unit_name = Convert.ToString(dgv.Rows[i].Cells[2].Value);
                    db.excutedata("update product_units set unitpricesales=" + dgv.Rows[i].Cells[4].Value + " where pro_id=" + dgv.Rows[i].Cells[0].Value + " and unit_name=N'" + unit_name + "' ", "");
                    //=======================================================
                    //caculate the  qty depending on the selected unit
                    DataTable tblsmallqty = new DataTable();
                    tblsmallqty.Clear();
                    tblsmallqty = db.readdata("select*from products where product_id=" + dgv.Rows[i].Cells[0].Value + "", "");

                    //small unit
                    decimal smallqty = Convert.ToDecimal(tblsmallqty.Rows[0][25]);

                    decimal realqty = 0;
                    if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3]) > 1)
                    {
                        realqty += Convert.ToDecimal(dgv.Rows[i].Cells[3].Value);
                    }
                    else if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3]) == 1)
                    {
                        realqty += Convert.ToDecimal(dgv.Rows[i].Cells[3].Value) * smallqty;
                    }
                    //ادخال في جدول ال items_card
                    string discription = "منصرف من عمليه بيع للمورد " + " " + cbxcustomer.Text + " " + "عمليه رقم" + " " + txtorderid.Text;
                    db.excutedata("insert into item_card values(" + dgv.Rows[i].Cells[0].Value + ",N'" + dgv.Rows[i].Cells[1].Value + "'," + dgv.Rows[i].Cells[12].Value + ",N'" + dgv.Rows[i].Cells[11].Value + "',N'" + d + "'," + realqty + ",N'" + dgv.Rows[i].Cells[2].Value + "',N'" + discription + "',0," + realqty + ",0,N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + txtnotes.Text.Trim() + "'," + txtorderid.Text + ",N'منصرف')", "");

                    //تعديل الكميات
                    db.excutedata("update products_Qty set Qty=Qty-" + realqty + " where pro_id=" + dgv.Rows[i].Cells[0].Value + "", "");
                    DataTable tblchecktable1 = new DataTable();
                    tblchecktable1.Clear();
                    tblchecktable1 = db.readdata("select*from products_Qtyinstore where pro_id=" + dgv.Rows[i].Cells[0].Value + " and store_id=" + dgv.Rows[i].Cells[12].Value + "", "");
                    if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3]) > 1)
                    {
                        if (tblchecktable1.Rows.Count >= 1)
                        {
                            //check if there is qty of the product---> update it
                            db.excutedata("update products_Qtyinstore set Qty=Qty-" + dgv.Rows[i].Cells[3].Value + " where pro_id=" + dgv.Rows[i].Cells[0].Value + " and store_id=" + dgv.Rows[i].Cells[12].Value + "", "");
                        }
                        //check if there is no qty of the product insert the qty-->insert
                        else if (tblchecktable1.Rows.Count < 1)
                        {
                            db.excutedata("insert into products_Qtyinstore values(" + dgv.Rows[i].Cells[0].Value + ",N'" + dgv.Rows[i].Cells[1].Value + "'," + Convert.ToDecimal(dgv.Rows[i].Cells[3].Value) * -1 + "," + dgv.Rows[i].Cells[12].Value + ",N'" + dgv.Rows[i].Cells[11].Value + "')", "");
                        }
                    }
                    //big unit calc the qty by the big unit
                    else if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3]) == 1)
                    {
                        if (tblchecktable1.Rows.Count >= 1)
                        {
                            db.excutedata("update products_Qtyinstore set Qty=Qty-" + realqty + " where pro_id=" + dgv.Rows[i].Cells[0].Value + " and store_id=" + dgv.Rows[i].Cells[12].Value + "", "");
                        }
                        else if (tblchecktable1.Rows.Count < 1)
                        {
                            db.excutedata("insert into products_Qtyinstore values(" + dgv.Rows[i].Cells[0].Value + ",N'" + dgv.Rows[i].Cells[1].Value + "'," + realqty * -1 + "," + dgv.Rows[i].Cells[12].Value + ",N'" + dgv.Rows[i].Cells[11].Value + "')", "");

                        }
                    }

                    //حساب المود
                    db.excutedata("insert into supplier_account values(" + order_id + "," + cbxcustomer.SelectedValue + ",N'" + cbxcustomer.Text.Trim() + "',N'" + discriptionsupplier + "',N'" + dgv.Rows[i].Cells[1].Value + "'," + dgv.Rows[i].Cells[3].Value + "," + dgv.Rows[i].Cells[6].Value + "," + txttotalorder.Text + ",N'" + txtnotes.Text.Trim() + "',0," + dgv.Rows[i].Cells[6].Value + ",0,N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + d + "',N'فاتوره مبيعات',N'" + dgv.Rows[i].Cells[2].Value + "'," + txtorderid.Text + ")", "");

                }
                //خصم
                if (numircprice.Value != 0)
                {
                    db.excutedata("insert into supplier_account values(" + order_id + "," + cbxcustomer.SelectedValue + ",N'" + cbxcustomer.Text.Trim() + "',N'خصم',N'-',0," + numircprice.Value + "," + numircprice.Value + ",N'" + txtnotes.Text.Trim() + "'," + numircprice.Value + ",0,0,N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + d + "',N'فاتوره مبيعات',N'-'," + txtorderid.Text + ")", "");
                }



                //الخزنه
                string discription2 = "فاتوره مبيعات للمورد" + " " + cbxcustomer.Text + " " + " " + "فاتوره رقم" + txtorderid.Text;
                if (radiocash.Checked == true)
                {
                    db.excutedata("insert into stoke_insert (stoke_id,money,date,name,type,notes,user_name,branch_name,order_id) values(" + stoke_id + "," + txttotalmadfou3.Text + ",'" + d + "',N'" + discription2 + "',N'عمليه بيع',N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "'," + txtorderid.Text + ")", "");
                    tbl.Clear();
                    tbl = db.readdata("select*from stoke_money where stoke_id=" + stoke_id + "", "");
                    if (tbl.Rows.Count >= 1)
                    {

                        //stoke mony
                        db.excutedata("update stoke_money set money=money+" + txttotalmadfou3.Text + " where stoke_id=" + stoke_id + "", "");
                    }
                    else if (tbl.Rows.Count < 1)
                    {
                        db.excutedata("insert into stoke_money values(" + stoke_id + "," + txttotalmadfou3.Text + ")", "");
                    }
                }
                else if (radioagel.Checked == true && Convert.ToDecimal(txttotalmadfou3.Text) > 0)
                {
                    db.excutedata("insert into stoke_insert (stoke_id,money,date,name,type,notes,user_name,branch_name,order_id2) values(" + stoke_id + "," + txttotalmadfou3.Text + ",'" + d + "',N'" + discription2 + "',N'عمليه بيع',N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "'," + txtorderid.Text + ")", "");
                    tbl.Clear();
                    tbl = db.readdata("select*from stoke_money where stoke_id=" + stoke_id + "", "");
                    if (tbl.Rows.Count >= 1)
                    {


                        db.excutedata("update stoke_money set money=money+" + txttotalmadfou3.Text + " where stoke_id=" + stoke_id + "", "");
                    }
                    else if (tbl.Rows.Count < 1)
                    {
                        db.excutedata("insert into stoke_money values(" + stoke_id + "," + txttotalmadfou3.Text + ")", "");
                    }
                }
            }

            //فاتوره لموظف-------------------------------------
            else if (radioemployee.Checked == true)
            {
                //===================================================================
                if (radioagel.Checked == false && radiocash.Checked == false)
                {
                    MessageBox.Show("من فضلك اختر اما اذا كانت الفاتوره كاش ام اجل اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (radioagel.Checked == true && Convert.ToDecimal(txttotalmadfou3.Text) >= Convert.ToDecimal(txttotalorder.Text))
                {
                    MessageBox.Show("خطا", "من فضلك تاكد من بيانات الفاتوره انت تريد حفظ فاتوره اجل وقمت بدفع اجمالي مبلغ الفاتوره بالكامل انت تعامل الفاتوره معامله كاش الان ....", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (radiocash.Checked == true && Convert.ToDecimal(txttotalmadfou3.Text) < Convert.ToDecimal(txttotalorder.Text))
                {
                    MessageBox.Show("خطا", "من فضلك تاكد من بيانات الفاتوره انت تريد حفظ فاتوره كاش وقمت بدفع  مبلغ اقل من اجمالي مبلغ الفاتوره  انت تعامل الفاتوره معامله اجل الان ....", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (Convert.ToDecimal(txttotalmadfou3.Text) == 0)
                {
                    if (MessageBox.Show("هل انت متاكد من ان المبلغ المدفوع يساوي صفر 0", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    {
                        return;
                    }
                }

                if (txteznnumber.Text == "")
                {
                    MessageBox.Show("من فضلك ادخل رقم الاذن اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }


                //=====================================================================

                // if (dgv.Rows.Count > 1)
                //{

                decimal order_id_emp = Convert.ToDecimal(txtorderid.Text) + Convert.ToDecimal(100000);
                string discription_emp = "فاتوره مبيعات لموظف" + " " + cbxcustomer.Text + " " + "عمليه مبيعات رقم" + " " + txtorderid.Text;

                string d_emp = dtpdate.Value.ToString("yyyy-MM-dd");
                string t_emp = dtptime.Value.ToString("HH-MM");
                string type_emp = "";
                if (radioagel.Checked == true)
                {
                    type_emp = "اجل";
                }
                else if (radiocash.Checked == true)
                {
                    type_emp = "كاش";
                }
                string billforemployee = "موظف";
                //ادخال في جدول ال sales


                db.excutedata("insert into sales values(" + txtorderid.Text + "," + txteznnumber.Text + "," + cbxcustomer.SelectedValue + "," + numircprice.Value + "," + txttotalorder.Text + ",0,N'" + Properties.Settings.Default.user_name + "',N'" + t_emp + "',N'" + d_emp + "',N'" + type_emp + "',N'" + Properties.Settings.Default.branch_name + "',N'" + txtnotes.Text.Trim() + "',N'" + cbxstore.Text + "'," + cbxstore.SelectedValue + "," + cbxmandoup.SelectedValue + ",N'" + cbxmandoup.Text + "',N'" + billforemployee + "'," + lblitemscount.Text + ")", "");


                DataTable tbltotalonhim = new DataTable();
                tbltotalonhim.Clear();
                tbltotalonhim = db.readdata("select*from employee_account where emp_id=" + cbxcustomer.SelectedValue + "", "");
                decimal totalonhim = 0, onhim = 0, sadad = 0;
                for (int y = 0; y <= tbltotalonhim.Rows.Count - 1; y++)
                {
                    onhim += Convert.ToDecimal(tbltotalonhim.Rows[y][5]);
                    sadad += Convert.ToDecimal(tbltotalonhim.Rows[y][6]);
                }
                totalonhim = onhim - sadad;

              //  db.excutedata("insert into sales values(" + txtorderid.Text + "," + txteznnumber.Text + "," + cbxcustomer.SelectedValue + "," + numircprice.Value + "," + txttotalorder.Text + ",0,N'" + Properties.Settings.Default.user_name + "',N'" + t + "',N'" + d + "',N'" + type + "',N'" + Properties.Settings.Default.branch_name + "',N'" + txtnotes.Text.Trim() + "',N'" + cbxstore.Text + "'," + cbxstore.SelectedValue + "," + cbxmandoup.SelectedValue + ",N'" + cbxmandoup.Text + "',N'عميل'," + lblitemscount.Text + ")", "");
                db.excutedata("insert into sales_details_money values(" + txtorderid.Text + ",N'" + cbxcustomer.Text + "'," + txttotalmadfou3.Text + "," + totalonhim + ",N'" + billforemployee + "',N'" + Properties.Settings.Default.branch_name + "')", "");
              
                    for (int i = 0; i <= dgv.Rows.Count - 1; i++)
                {
                    //ادخال في جدول الsaeles_details
                    db.excutedata("insert into sales_details values(" + txtorderid.Text + "," + txteznnumber.Text + "," + dgv.Rows[i].Cells[0].Value + ",N'" + dgv.Rows[i].Cells[1].Value + "'," + cbxcustomer.SelectedValue + "," + dgv.Rows[i].Cells[3].Value + "," + dgv.Rows[i].Cells[4].Value + "," + dgv.Rows[i].Cells[5].Value + "," + numircprice.Value + "," + dgv.Rows[i].Cells[6].Value + "," + txttotalorder.Text + ",N'" + dgv.Rows[i].Cells[2].Value + "',0," + dgv.Rows[i].Cells[4].Value + ",N'" + Properties.Settings.Default.user_name + "',N'" + t_emp + "',N'" + d_emp + "',N'" + type_emp + "',N'" + Properties.Settings.Default.branch_name + "',N'" + dgv.Rows[i].Cells[7].Value + "',N'" + txtnotes.Text.Trim() + "'," + dgv.Rows[i].Cells[10].Value + ",N'" + dgv.Rows[i].Cells[11].Value + "'," + dgv.Rows[i].Cells[12].Value + "," + cbxmandoup.SelectedValue + ",N'" + cbxmandoup.Text.Trim() + "',N'" + billforemployee + "'," + lblitemscount.Text + "," + dgv.Rows[i].Cells[8].Value + "," + dgv.Rows[i].Cells[9].Value + ")", "");


                    DataTable tblsmallunitupdateprice = new DataTable();
                    tblsmallunitupdateprice.Clear();
                    tblsmallunitupdateprice = db.readdata("select*from product_units where pro_id=" + dgv.Rows[i].Cells[0].Value + " and unit_name=N'" + dgv.Rows[i].Cells[2].Value + "'", "");

                    //تعديل سعر الصنف للسعر الجديد
                    string unit_name = Convert.ToString(dgv.Rows[i].Cells[2].Value);
                    db.excutedata("update product_units set unitpricesales=" + dgv.Rows[i].Cells[4].Value + " where pro_id=" + dgv.Rows[i].Cells[0].Value + " and unit_name=N'" + unit_name + "' ", "");
                    //=======================================================

                    DataTable tblsmallqty = new DataTable();
                    tblsmallqty.Clear();
                    tblsmallqty = db.readdata("select*from products where product_id=" + dgv.Rows[i].Cells[0].Value + "", "");


                    decimal smallqty = Convert.ToDecimal(tblsmallqty.Rows[0][25]);

                    decimal realqty = 0;
                    if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3]) > 1)
                    {
                        realqty += Convert.ToDecimal(dgv.Rows[i].Cells[3].Value);
                    }
                    else if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3]) == 1)
                    {
                        realqty += Convert.ToDecimal(dgv.Rows[i].Cells[3].Value) * smallqty;
                    }
                    //ادخال في جدول ال items_card
                    //        string discription_empp = "منصرف من عمليه بيع لموظف " + " " + cbxcustomer.Text + " " + "عمليه رقم" + " " + txtorderid.Text;
                    string discription_empp = "فاتوره مبيعات لموظف" + " " + cbxcustomer.Text + " " + "عمليه مبيعات رقم" + " " + txtorderid.Text + " " + Convert.ToString(dgv.Rows[i].Cells[1].Value) + " " + Convert.ToInt32(dgv.Rows[i].Cells[3].Value) + Convert.ToString(Convert.ToString(dgv.Rows[i].Cells[2].Value));


                    db.excutedata("insert into item_card values(" + dgv.Rows[i].Cells[0].Value + ",N'" + dgv.Rows[i].Cells[1].Value + "'," + dgv.Rows[i].Cells[12].Value + ",N'" + dgv.Rows[i].Cells[11].Value + "',N'" + d_emp + "'," + realqty + ",N'" + dgv.Rows[i].Cells[2].Value + "',N'" + discription_emp + "',0," + realqty + ",0,N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + txtnotes.Text.Trim() + "'," + txtorderid.Text + ",N'منصرف')", "");

                    db.excutedata("insert into employee_account values(" + order_id_emp + "," + cbxcustomer.SelectedValue + ",N'" + cbxcustomer.Text.Trim() + "',N'" + discription_empp + "'," + dgv.Rows[i].Cells[6].Value + "," + dgv.Rows[i].Cells[6].Value + ",0,N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + d_emp + "',N'فاتوره بيع',N'" + t_emp + "'," + txtorderid.Text + ")", "");

                    //تعديل الكميات
                    db.excutedata("update products_Qty set Qty=Qty-" + realqty + " where pro_id=" + dgv.Rows[i].Cells[0].Value + "", "");
                    DataTable tblchecktable1 = new DataTable();
                    tblchecktable1.Clear();
                    tblchecktable1 = db.readdata("select*from products_Qtyinstore where pro_id=" + dgv.Rows[i].Cells[0].Value + " and store_id=" + dgv.Rows[i].Cells[12].Value + "", "");
                    if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3]) > 1)
                    {
                        if (tblchecktable1.Rows.Count >= 1)
                        {

                            db.excutedata("update products_Qtyinstore set Qty=Qty-" + dgv.Rows[i].Cells[3].Value + " where pro_id=" + dgv.Rows[i].Cells[0].Value + " and store_id=" + dgv.Rows[i].Cells[12].Value + "", "");
                        }
                        else if (tblchecktable1.Rows.Count < 1)
                        {
                            db.excutedata("insert into products_Qtyinstore values(" + dgv.Rows[i].Cells[0].Value + ",N'" + dgv.Rows[i].Cells[1].Value + "'," + Convert.ToDecimal(dgv.Rows[i].Cells[3].Value) * -1 + "," + dgv.Rows[i].Cells[12].Value + ",N'" + dgv.Rows[i].Cells[11].Value + "')", "");
                        }
                    }
                    else if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3]) == 1)
                    {
                        if (tblchecktable1.Rows.Count >= 1)
                        {
                            db.excutedata("update products_Qtyinstore set Qty=Qty-" + realqty + " where pro_id=" + dgv.Rows[i].Cells[0].Value + " and store_id=" + dgv.Rows[i].Cells[12].Value + "", "");
                        }
                        else if (tblchecktable1.Rows.Count < 1)
                        {
                            db.excutedata("insert into products_Qtyinstore values(" + dgv.Rows[i].Cells[0].Value + ",N'" + dgv.Rows[i].Cells[1].Value + "'," + realqty * -1 + "," + dgv.Rows[i].Cells[12].Value + ",N'" + dgv.Rows[i].Cells[11].Value + "')", "");

                        }
                    }


                }

                //الخزنه
                string discription_emppp = "فاتوره مبيعات لموظف" + " " + cbxcustomer.Text + " " + " " + "فاتوره رقم" + txtorderid.Text;
                // string discription_emp = "فاتوره مبيعات لموظف" + " " + cbxcustomer.Text + " " + "عمليه مبيعات رقم" + " " + txtorderid.Text + " " + Convert.ToString(dgv.Rows[i].Cells[1].Value);

                //cash
                if (radiocash.Checked == true)
                {
                    db.excutedata("insert into stoke_insert (stoke_id,money,date,name,type,notes,user_name,branch_name,order_id2) values(" + stoke_id + "," + txttotalmadfou3.Text + ",'" + d_emp + "',N'" + discription_emppp + "',N'عمليه بيع',N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "'," + txtorderid.Text + ")", "");
                    tbl.Clear();
                    tbl = db.readdata("select*from stoke_money where stoke_id=" + stoke_id + "", "");
                    if (tbl.Rows.Count >= 1)
                    {

                        //stoke money
                        db.excutedata("update stoke_money set money=money+" + txttotalmadfou3.Text + " where stoke_id=" + stoke_id + "", "");
                    }
                    else if (tbl.Rows.Count < 1)
                    {
                        db.excutedata("insert into stoke_money values(" + stoke_id + "," + txttotalmadfou3.Text + ")", "");
                    }
                }
              //agel and pay money from employee
                else if (radioagel.Checked == true && Convert.ToDecimal(txttotalmadfou3.Text) > 0)
                {
                    //insert into stoke insert
                    db.excutedata("insert into stoke_insert (stoke_id,money,date,name,type,notes,user_name,branch_name,order_id2) values(" + stoke_id + "," + txttotalmadfou3.Text + ",'" + d_emp + "',N'" + discription_emppp + "',N'عمليه بيع',N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "'," + txtorderid.Text + ")", "");
                    tbl.Clear();
                    tbl = db.readdata("select*from stoke_money where stoke_id=" + stoke_id + "", "");
                    //if there is data in stoke money update it
                    if (tbl.Rows.Count >= 1)
                    {


                        db.excutedata("update stoke_money set money=money+" + txttotalmadfou3.Text + " where stoke_id=" + stoke_id + "", "");
                    }
                    //if there is no data in stoke money insert it
                    else if (tbl.Rows.Count < 1)
                    {
                        db.excutedata("insert into stoke_money values(" + stoke_id + "," + txttotalmadfou3.Text + ")", "");
                    }
                }
                //}


            }

           


                MessageBox.Show("تم حفظ الفاتوره بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            int data = 0;
            if (Properties.Settings.Default.printername == "")
            {
                MessageBox.Show("من فضلك وصل الطابعه وقم باختيارها اولا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                data = Convert.ToInt32(db.readdata("select count(name)from settingprinting_bills", "").Rows[0][0]);
            }
            catch (Exception)
            { }
            if (data <= 0)
            {
                MessageBox.Show("من فضلك ادخل بيانات الفاتوره اولا في شاشه اعدادات البرنامج", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           //for (int i = 0; i <= Properties.Settings.Default.salesprintnum - 1; i++)
            //{
                print();
           // }
            autonumber();

        }
        private void tileItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            tileItem1.Enabled = false;
            panelupdate.Visible = true;
            simpleButton8.Enabled = false;
        }

        //get the data of bill by the id
        private void txtbillid_KeyPress(object sender, KeyPressEventArgs e)
        {
            int row20 = 0;
            if (e.KeyChar == 13)
            {
                if (txtbillid.Text == "")
                {
                    MessageBox.Show("من فضلك ادخل رقم الفاتوره التي تريد تعديلها ثم قم بالضغط علي زر انتر", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //sales table and the bill
                DataTable tblsales = new DataTable();
                tblsales.Clear();
                tblsales = db.readdata("select*from sales_details where order_id=" + txtbillid.Text.Trim() + " and branch_name=N'" + Properties.Settings.Default.branch_name + "'", "");
                if (tblsales.Rows.Count < 1)
                {
                    MessageBox.Show("لايوجد فاتوره بهذا الرقم", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                { 
                //check if the bill for supplier or customer or employee
                    if (Convert.ToString(tblsales.Rows[0][26]) == "مورد")
                    {
                        radiosupplier.Checked = true;
                    }
                    else if (Convert.ToString(tblsales.Rows[0][26]) == "عميل")
                    {
                        radiocustomer.Checked = true;


                    }
                    else if (Convert.ToString(tblsales.Rows[0][26]) == "موظف")
                    {
                        radioemployee.Checked = true;
                    }
                    //check if the bill cash or agel
                    if (Convert.ToString(tblsales.Rows[0][17]) == "اجل")
                    {
                        radioagel.Checked = true;
                    }
                    else if (Convert.ToString(tblsales.Rows[0][17]) == "كاش")
                    {
                        radiocash.Checked = true;
                    }
                    //show data on the form tools
                    txtorderid.Text = tblsales.Rows[row20][0].ToString();
                    txteznnumber.Text = tblsales.Rows[row20][1].ToString();
                    numircprice.Value = Convert.ToDecimal(tblsales.Rows[row20][8]);
                    lblsup_id.Text = tblsales.Rows[row20][4].ToString();
                    lbltotalselectedbill.Text = tblsales.Rows[row20][10].ToString();

                    //get the total after discount and total
                    decimal totalafterdiscount = 0;
                    decimal total = 0;
                    for (int i = 0; i <= dgv.Rows.Count - 1; i++)
                    {
                        total += Convert.ToDecimal(dgv.Rows[i].Cells[6].Value);



                    }
                    totalafterdiscount += total - Convert.ToDecimal(numircprice.Text);

                    //============================================================
                    //total of all bill
                    txttotalorder.Text = totalafterdiscount.ToString();


                    decimal totaloldbill = Convert.ToDecimal(tblsales.Rows[row20][10]) - Convert.ToDecimal(tblsales.Rows[row20][8]);
                    
                    DataTable tbltotalbeforebill = new DataTable();
                    tbltotalbeforebill.Clear();
                    tbltotalbeforebill = db.readdata("select*from customer_account where order_id<" + txtorderid.Text + " and cust_id=" + lblsup_id.Text + "", "");

                    decimal totalmoney = 0, totalsadad = 0, final = 0;
                    for (int a = 0; a <= tbltotalbeforebill.Rows.Count - 1; a++)
                    {
                        totalmoney += Convert.ToDecimal(tbltotalbeforebill.Rows[a][9]);
                        totalsadad += Convert.ToDecimal(tbltotalbeforebill.Rows[a][10]);

                    }
                    final += totalmoney - totalsadad;
                    lbltotalbeforeupdate.Text = final.ToString();
                    //=========================================================================

                    //drag the items of the bill into datagridview to update 
                    dgv.Rows.Clear();
                    if (tblsales.Rows.Count > 0)
                    {
                        foreach (DataRow row in tblsales.Rows)
                        {
                            dgv.Rows.Add(1);

                            int rowindex = dgv.Rows.Count - 1;

                            dgv.Rows[rowindex].Cells[0].Value = row[2];
                            dgv.Rows[rowindex].Cells[1].Value = row[3];
                            dgv.Rows[rowindex].Cells[2].Value = row[11];
                            dgv.Rows[rowindex].Cells[3].Value = row[5];
                            dgv.Rows[rowindex].Cells[4].Value = row[6];
                            dgv.Rows[rowindex].Cells[5].Value = row[7];
                            dgv.Rows[rowindex].Cells[6].Value = row[9];
                            dgv.Rows[rowindex].Cells[7].Value = row[19];


                            dgv.Rows[rowindex].Cells[8].Value = row[28];
                            dgv.Rows[rowindex].Cells[9].Value = row[29];
                            dgv.Rows[rowindex].Cells[10].Value = row[21];
                            dgv.Rows[rowindex].Cells[11].Value = row[22];
                            dgv.Rows[rowindex].Cells[12].Value = row[23];
                            dgv.Rows[rowindex].Cells[14].Value = row[5];


                        }
                        lblitemscount.Text = Convert.ToString(dgv.Rows.Count);

                        try
                        {



                            decimal bakey = 0,totalorder=0;
                            totalorder += Convert.ToDecimal(txttotalorder.Text) - Convert.ToDecimal(numircprice.Value);
                            txttotalorder.Text = totalorder.ToString();
                            bakey = Convert.ToDecimal(txttotalorder.Text) - Convert.ToDecimal(txttotalmadfou3.Text);
                            txttotalbakey.Text = bakey.ToString();


                        }
                        catch (Exception) { }
                    }

                }
            }

        }

        //update  bill
        private void btnupdate_Click(object sender, EventArgs e)
        {
            
            if (cbxcustomer.Text == "")
            {
                MessageBox.Show("من فضلك اختر عميل اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (dgv.Rows.Count < 1)
            {
                MessageBox.Show("من فضلك اكمل بيانات الفاتوره اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txteznnumber.Text == "")
            {

                MessageBox.Show("من فضلك ادخل رقم اذن الفاتوره اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else if (cbxmandoup.Text == "")
            {
                MessageBox.Show("من فضلك اختر مندوب اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (radioagel.Checked == false && radiocash.Checked == false)
            {
                MessageBox.Show("من فضلك اختر اما اذا كانت الفاتوره كاش ام اجل", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        
    
            
                else
                {
                if (MessageBox.Show("هل انت متاكد من تعديل الفاتوره", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                    //validations
                    tbl.Clear();
                    tbl = db.readdata("select*from sales_details where order_id=" + txtorderid.Text + " and branch_name=N'" + Properties.Settings.Default.branch_name + "'", "");
                    string billty120 = "";
                    billty120 = Convert.ToString(tbl.Rows[0][26]);
                    if (billty120=="عميل"&&radiocustomer.Checked==false)
                    {
                        MessageBox.Show("من فضلك تاكد من بياناتك هذه الفاتوره لعميل وليس لمورد او موظف", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if(billty120=="مورد"&&radiosupplier.Checked==false)
                    {
                        MessageBox.Show("من فضلك تاكد من بياناتك هذه الفاتوره لمورد وليس لعميل او موظف", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if(billty120=="موظف"&&radioemployee.Checked==false)
                    {
                        MessageBox.Show("من فضلك تاكد من بياناتك هذه الفاتوره لموظف وليس لعميل او مورد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    //delete the bill from the tables
                    db.excutedata("delete from sales where order_id=" + txtorderid.Text + " and branch_name=N'" + Properties.Settings.Default.branch_name + "'", "");
                        db.excutedata("delete from sales_details where order_id=" + txtorderid.Text + " and branch_name=N'" + Properties.Settings.Default.branch_name + "'", "");
                        db.excutedata("delete from item_card where order_id=" + txtorderid.Text + " and branch_name=N'" + Properties.Settings.Default.branch_name + "' and type=N'منصرف'", "");
                    db.excutedata("delete from sales_details_money where order_id="+txtorderid.Text+" and branch_name=N'"+Properties.Settings.Default.branch_name+"'", "");

                    decimal totalonhim111 = 0, onhim111 = 0, sadad111 = 0;


                    if (radiocustomer.Checked == true)
                        {
                            db.excutedata("delete from customer_account where order_id2=" + txtorderid.Text + " and branch_name=N'" + Properties.Settings.Default.branch_name + "' ", "");

                        DataTable tbltotalonhim = new DataTable();
                        tbltotalonhim.Clear();
                        tbltotalonhim = db.readdata("select*from customer_account where cust_id=" + cbxcustomer.SelectedValue + "", "");
                        for (int y = 0; y <= tbltotalonhim.Rows.Count - 1; y++)
                        {
                            onhim111 += Convert.ToDecimal(tbltotalonhim.Rows[y][9]);
                            sadad111 += Convert.ToDecimal(tbltotalonhim.Rows[y][10]);
                        }
                        totalonhim111 = onhim111 - sadad111;

                    }
                    else if(radiosupplier.Checked==true)
                        {
                            db.excutedata("delete from supplier_account where  order_id2=" + txtorderid.Text + " and branch_name=N'" + Properties.Settings.Default.branch_name + "' ", "");
                        DataTable tbltotalonhim = new DataTable();
                        tbltotalonhim.Clear();
                        tbltotalonhim = db.readdata("select*from supplier_account where sup_id=" + cbxcustomer.SelectedValue + "", "");
                        for (int y = 0; y <= tbltotalonhim.Rows.Count - 1; y++)
                        {
                            onhim111 += Convert.ToDecimal(tbltotalonhim.Rows[y][9]);
                            sadad111 += Convert.ToDecimal(tbltotalonhim.Rows[y][10]);
                        }
                        totalonhim111 = onhim111 - sadad111;
                    }
                    else if(radioemployee.Checked==true)
                        {
                            db.excutedata("delete from employee_account where  order_id2=" + txtorderid.Text + " and branch_name=N'" + Properties.Settings.Default.branch_name + "'", "");
                        DataTable tbltotalonhim = new DataTable();
                        tbltotalonhim.Clear();
                        tbltotalonhim = db.readdata("select*from employee_account where emp_id=" + cbxcustomer.SelectedValue + "", "");
                        for (int y = 0; y <= tbltotalonhim.Rows.Count - 1; y++)
                        {
                            onhim111 += Convert.ToDecimal(tbltotalonhim.Rows[y][9]);
                            sadad111 += Convert.ToDecimal(tbltotalonhim.Rows[y][10]);
                        }
                        totalonhim111 = onhim111 - sadad111;
                    }



                        //======================================================
                        string billtype = "";
                        if (radioagel.Checked == true)
                        {
                            billtype = "اجل";
                        }
                        else if (radiocash.Checked == true)
                        {
                            billtype = "كاش";

                        }
                        string d = dtpdate.Value.ToString("yyyy-MM-dd");
                        string t = dtptime.Text;
                        string discriptionupdate = "منصرف من فاتوره مبيعات للعميل" + " " + cbxcustomer.Text + " " + "فاتوره رقم" + txtorderid.Text;

                        //insert into sales
                        //جدول ال sales
                        db.excutedata("insert into sales values(" + txtorderid.Text.Trim() + "," + txteznnumber.Text.Trim() + "," + cbxcustomer.SelectedValue + "," + numircprice.Value + "," + txttotalorder.Text + ",0,N'" + Properties.Settings.Default.user_name + "',N'" + t + "',N'" + d + "',N'" + billtype + "',N'" + Properties.Settings.Default.branch_name + "',N'" + txtnotes.Text.Trim() + "','" + cbxstore.Text.Trim() + "'," + cbxstore.SelectedValue + "," + cbxmandoup.SelectedValue + ",N'" + cbxmandoup.Text.Trim() + "',N'عميل'," + lblitemscount.Text + ")", "");

                    db.excutedata("insert into sales_details_money values(" + txtorderid.Text + ",N'" + cbxcustomer.Text + "'," + txttotalmadfou3.Text + "," + totalonhim111 + ",N'" + billtype + "',N'" + Properties.Settings.Default.branch_name + "')", "");


                    for (int i = 0; i <= dgv.Rows.Count - 1; i++)
                        {
                            decimal totalmoney55 = 0, sadad = 0, balance55 = 0;

                            DataTable tbloldmoney = new DataTable();
                            tbloldmoney.Clear();
                            tbloldmoney = db.readdata("select*from customer_account where cust_id=" + lblsup_id.Text + " and order_id<=" + txtorderid.Text + "", "");
                            for (int x = 0; x <= tbloldmoney.Rows.Count - 1; x++)
                            {


                                totalmoney55 += Convert.ToDecimal(tbloldmoney.Rows[x][9]);
                                sadad += Convert.ToDecimal(tbloldmoney.Rows[x][10]);
                            }
                            try
                            {
                                balance55 += (totalmoney55 + Convert.ToDecimal(dgv.Rows[i].Cells[6].Value)) - sadad;
                            }
                            catch (Exception) { }

                            //insert into sales_details
                            //db.excutedata("insert into sales_details values(" + txtorderid.Text.Trim() + "," + txteznnumber.Text + ","+dgv+"," + cbxsupplier.SelectedValue + "," + dgv.Rows[i].Cells[0].Value + "," + dgv.Rows[i].Cells[3].Value + ",N'" + d + "',N'" + Properties.Settings.Default.user_name + "'," + dgv.Rows[i].Cells[4].Value + "," + dgv.Rows[i].Cells[5].Value + "," + numircprice.Value + "," + dgv.Rows[i].Cells[6].Value + "," + txttotalorder.Text + "," + Properties.Settings.Default.taxvalue + "," + dgv.Rows[i].Cells[4].Value + ",N'" + dtptime.Text + "',N'" + dgv.Rows[i].Cells[2].Value + "',N'" + billtype + "',N'" + Properties.Settings.Default.branch_name + "',N'" + dgv.Rows[i].Cells[7].Value + "',N'" + txtnotes.Text.Trim() + "'," + cbxmandoup.SelectedValue + ",N'" + cbxmandoup.Text.Trim() + "'," + dgv.Rows[i].Cells[8].Value + "," + dgv.Rows[i].Cells[10].Value + "," + lblitemscount.Text + ",N'" + dgv.Rows[i].Cells[9].Value + "',N'" + dgv.Rows[i].Cells[1].Value + "')", "");
                            db.excutedata("insert into sales_details values(" + txtorderid.Text + "," + txteznnumber.Text + "," + dgv.Rows[i].Cells[0].Value + ",N'" + dgv.Rows[i].Cells[1].Value + "'," + cbxcustomer.SelectedValue + "," + dgv.Rows[i].Cells[3].Value + "," + dgv.Rows[i].Cells[4].Value + "," + dgv.Rows[i].Cells[5].Value + "," + numircprice.Value + "," + dgv.Rows[i].Cells[6].Value + "," + txttotalorder.Text + ",N'" + dgv.Rows[i].Cells[2].Value + "',0," + dgv.Rows[i].Cells[4].Value + ",N'" + Properties.Settings.Default.user_name + "',N'" + t + "',N'" + d + "',N'" + billtype + "',N'" + Properties.Settings.Default.branch_name + "',N'" + dgv.Rows[i].Cells[7].Value + "',N'" + txtnotes.Text.Trim() + "'," + dgv.Rows[i].Cells[10].Value + ",N'" + dgv.Rows[i].Cells[11].Value + "'," + dgv.Rows[i].Cells[12].Value + "," + cbxmandoup.SelectedValue + ",N'" + cbxmandoup.Text.Trim() + "',N'عميل'," + lblitemscount.Text + "," + dgv.Rows[i].Cells[8].Value + "," + dgv.Rows[i].Cells[9].Value + ")", "");

                            //====================================================

                            //جدول الكميات products_qty

                            DataTable tblsmallqty = new DataTable();

                            tblsmallqty.Clear();
                            tblsmallqty = db.readdata("select*from products where product_id=" + dgv.Rows[i].Cells[0].Value + "", "");


                            decimal smallqty = Convert.ToDecimal(tblsmallqty.Rows[0][25]);
                            //===============================================
                            //insert into item card

                            DataTable tblfinaltotalqtycash = new DataTable();
                            tblfinaltotalqtycash.Clear();
                            tblfinaltotalqtycash = db.readdata("select*from item_card where pro_id=" + dgv.Rows[i].Cells[0].Value + "", "");
                            decimal totalward = 0, totalmosarf = 0, balance = 0, realqty = 0;
                            for (int q = 0; q <= tblfinaltotalqtycash.Rows.Count - 1; q++)
                            {
                                totalward += Convert.ToDecimal(tblfinaltotalqtycash.Rows[q][8]);
                                totalmosarf += Convert.ToDecimal(tblfinaltotalqtycash.Rows[q][9]);


                            }
                            if (tblfinaltotalqtycash.Rows.Count >= 1)
                            {
                                balance += (totalward - realqty) - totalmosarf;
                            }
                            else if (tblfinaltotalqtycash.Rows.Count < 1)
                            {
                                balance += realqty;
                            }
                            //db.excutedata("insert into item_card values(" + dgv.Rows[i].Cells[0].Value + ",N'" + dgv.Rows[i].Cells[1].Value + "'," + dgv.Rows[i].Cells[10].Value + ",N'" + dgv.Rows[i].Cells[9].Value + "',N'" + d + "'," + realqty + ",N'" + dgv.Rows[i].Cells[2].Value + "',N'" + discriptionupdate + "'," + realqty + ",0," + balance + ",N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + dgv.Rows[i].Cells[7].Value + "'," + txtorderid.Text + ",N'وارد')", "");
                            //===============================================================================================================================================================================
                            //update product_Qty
                            //================================================================================================================
                            DataTable tblsmallunitupdateprice = new DataTable();
                            tblsmallunitupdateprice.Clear();
                            tblsmallunitupdateprice = db.readdata("select*from product_units where pro_id=" + dgv.Rows[i].Cells[0].Value + " and unit_name=N'" + dgv.Rows[i].Cells[2].Value + "'", "");

                            //ارجاع الكميه
                            if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3]) > 1)
                            {
                                realqty = Convert.ToDecimal(dgv.Rows[i].Cells[3].Value);
                            }
                            else if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3]) == 1)
                            {
                                realqty = Convert.ToDecimal(dgv.Rows[i].Cells[3].Value) * smallqty;
                            }

                            db.excutedata("insert into item_card values(" + dgv.Rows[i].Cells[0].Value + ",N'" + dgv.Rows[i].Cells[1].Value + "'," + dgv.Rows[i].Cells[12].Value + ",N'" + dgv.Rows[i].Cells[11].Value + "',N'" + d + "'," + realqty + ",N'" + dgv.Rows[i].Cells[2].Value + "',N'" + discriptionupdate + "',0," + realqty + "," + balance + ",N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + dgv.Rows[i].Cells[7].Value + "'," + txtorderid.Text + ",N'منصرف')", "");

                            //----------------------------
                            decimal realqty2 = 0;
                            if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3]) > 1)
                            {
                                realqty2 = Convert.ToDecimal(dgv.Rows[i].Cells[14].Value);
                            }
                            else if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3]) == 1)
                            {
                                realqty2 = Convert.ToDecimal(dgv.Rows[i].Cells[14].Value) * smallqty;
                            }
                            db.excutedata("update products_Qty set Qty=Qty+" + realqty2 + " where pro_id=" + dgv.Rows[i].Cells[0].Value + " ", "");

                            DataTable tblchecktable = new DataTable();
                            tblchecktable.Clear();
                            tblchecktable = db.readdata("select*from products_Qtyinstore where pro_id=" + dgv.Rows[i].Cells[0].Value + " and store_id=" + dgv.Rows[i].Cells[12].Value + "", "");
                            if (tblchecktable.Rows.Count >= 1)
                            {
                                db.excutedata("update products_Qtyinstore set Qty=Qty+" + realqty2 + " where pro_id=" + dgv.Rows[i].Cells[0].Value + " and store_id=" + dgv.Rows[i].Cells[12].Value + "", "");

                            }
                            else if (tblchecktable.Rows.Count < 1)
                            {
                                db.excutedata("insert into products_Qtyinstore values (" + dgv.Rows[i].Cells[0].Value + ",N'" + dgv.Rows[i].Cells[1].Value + "'," + realqty2 + "," + dgv.Rows[i].Cells[12].Value + ",N'" + dgv.Rows[i].Cells[11].Value + "')", "");
                            }
                            //====================================================

                            decimal newrealqty = 0;
                            //ادخال الكميه الجديده
                            if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3]) > 1)
                            {
                                newrealqty += Convert.ToDecimal(dgv.Rows[i].Cells[3].Value);
                            }
                            else if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3]) == 1)
                            {
                                newrealqty += Convert.ToDecimal(dgv.Rows[i].Cells[3].Value) * smallqty;
                            }
                            //product qty
                            db.excutedata("update products_Qty set Qty=Qty-" + newrealqty + " where pro_id=" + dgv.Rows[i].Cells[0].Value + " ", "");

                        //=========================================================
                        //products_Qtyinstore if there is data -->update
                        if (tblchecktable.Rows.Count >= 1)
                            {
                                db.excutedata("update products_Qtyinstore set Qty=Qty-" + newrealqty + " where pro_id=" + dgv.Rows[i].Cells[0].Value + " and store_id=" + dgv.Rows[i].Cells[12].Value + "", "");

                            }
                        //products_Qtyinstore --> if ther is no data -->insert
                        else if (tblchecktable.Rows.Count < 1)
                            {
                                db.excutedata("insert into products_Qtyinstore values (" + dgv.Rows[i].Cells[0].Value + ",N'" + dgv.Rows[i].Cells[1].Value + "'," + newrealqty + "," + dgv.Rows[i].Cells[12].Value + ",N'" + dgv.Rows[i].Cells[11].Value + "')", "");
                            }
                            //===============================================================================================================================================
                            //=====================================================================================================================================================================
                            //insert into customer_account

                            string discription = "منصرف من فاتوره مبيعات للعميل" + " " + cbxcustomer.Text + " " + "فاتوره رقم" + txtorderid.Text;

                            if (radiocustomer.Checked == true)
                            {
                                db.excutedata("insert into customer_account values(" + txtorderid.Text + "," + cbxcustomer.SelectedValue + ",N'" + cbxcustomer.Text + "',N'" + discription + "',N'" + dgv.Rows[i].Cells[1].Value + "'," + dgv.Rows[i].Cells[3].Value + ",N'" + dgv.Rows[i].Cells[2].Value + "'," + dgv.Rows[i].Cells[6].Value + "," + txttotalorder.Text + "," + dgv.Rows[i].Cells[6].Value + ",0,N'" + dgv.Rows[i].Cells[7].Value + "',N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + d + "',N'" + billtype + "',N'" + t + "',"+txtorderid.Text+")", "");
                            }
                            else if(radiosupplier.Checked==true)
                            {
                                string billtype2 = "فاتوره مبيعات";
                                string descriptionsup= "فاتوره مبيعات للمورد" + " " + cbxcustomer.Text + " " + "فاتوره رقم" + txtorderid.Text;
                                db.excutedata("insert into supplier_account values(" + txtorderid.Text + "," + cbxcustomer.SelectedValue + ",N'" + cbxcustomer.Text + "',N'" + descriptionsup + "',N'" + dgv.Rows[i].Cells[1].Value + "'," + dgv.Rows[i].Cells[3].Value + "," + dgv.Rows[i].Cells[6].Value + "," + txttotalorder.Text + ",N'" + dgv.Rows[i].Cells[7].Value + "',0," +dgv.Rows[i].Cells[6].Value  + ",0,N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + d + "',N'" + billtype2 + "',N'" +dgv.Rows[i].Cells[2].Value+ "',"+txtorderid.Text+")", "");
                            }
                            else if(radioemployee.Checked==true)
                            {
                                
                                string billtype2 = "فاتوره مبيعات";
                                string descriptionemp = "فاتوره مبيعات للموظف" + " " + cbxcustomer.Text + " " + "فاتوره رقم" + txtorderid.Text+" "+" منتج"+" "+Convert.ToString(dgv.Rows[i].Cells[1].Value)+" "+"بكميه"+Convert.ToInt32(dgv.Rows[i].Cells[3].Value)+" "+Convert.ToString(dgv.Rows[i].Cells[2].Value);
                                db.excutedata("insert into employee_account values(" + txtorderid.Text + "," + cbxcustomer.SelectedValue + ",N'" + cbxcustomer.Text + "',N'" + descriptionemp + "'," + dgv.Rows[i].Cells[6].Value + ","+dgv.Rows[i].Cells[6].Value+",0,N'" + dgv.Rows[i].Cells[7].Value + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + d + "',N'" + billtype2 + "',N'" + t + "',"+txtorderid.Text+")", "");
                            }

                        }

                    //supplier account
                    //السداد
                    //خصم
                    if (numircprice.Value != 0&&radiocustomer.Checked==true)
                    {
                        db.excutedata("insert into customer_account values(" + txtorderid.Text + "," + cbxcustomer.SelectedValue + ",N'" + cbxcustomer.Text + "',N'خصم',N'-',0,N'-'," + numircprice.Value + "," + numircprice.Value + ",0," + numircprice.Value + ",N'',N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + d + "',N'" + billtype + "',N'" + t + "'," + txtorderid.Text + ")", "");

                    }
                    if (numircprice.Value != 0 && radiosupplier.Checked == true)
                    {
                        db.excutedata("insert into supplier_account values(" + txtorderid.Text + "," + cbxcustomer.SelectedValue + ",N'" + cbxcustomer.Text + "',N'خصم',N'-',0," + numircprice.Value + "," + numircprice.Value + ",N'"+txtnotes.Text.Trim()+"'," + numircprice.Value + ",0,0,N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + d + "',N'" + billtype + "',N'-'," + txtorderid.Text + ")", "");

                    }
               

                    string discription2 = "[سداد] من عمليه بيع للعميل]" + " " + cbxcustomer.Text + " " + "عمليه رقم" + " " + txtorderid.Text;
                    if (Convert.ToDecimal(txttotalmadfou3.Text) > 0)
                    {
                        if (radiocustomer.Checked == true)
                        {
                            db.excutedata("insert into customer_account values(" + txtorderid.Text + "," + cbxcustomer.SelectedValue + ",N'" + cbxcustomer.Text + "',N'" + discription2 + "',N'',0,N''," + txttotalmadfou3.Text + "," + txttotalmadfou3.Text + ",0," + txttotalmadfou3.Text + ",N'',N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + d + "',N'" + billtype + "',N'" + t + "'," + txtorderid.Text + ")", "");
                        }
                       if(radiosupplier.Checked==true)
                        {
                            string discriptionsup = "[سداد] من عمليه بيع للمورد]" + " " + cbxcustomer.Text + " " + "عمليه رقم" + " " + txtorderid.Text;

                            db.excutedata("insert into supplier_account values(" + txtorderid.Text + "," + cbxcustomer.SelectedValue + ",N'" + cbxcustomer.Text + "',N'" + discriptionsup + "',N'',0," + txttotalmadfou3.Text + "," + txttotalmadfou3.Text + ",N'"+txtnotes.Text.Trim()+"'," + txttotalmadfou3.Text + ",0,0,N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + d + "',N'" + billtype + "',N'-'," + txtorderid.Text + ")", "");

                        }
                         if(radioemployee.Checked==true)
                        {
                            string discriptionemp = "[سداد] من عمليه بيع للموظف]" + " " + cbxcustomer.Text + " " + "عمليه رقم" + " " + txtorderid.Text;

                            db.excutedata("insert into employee_account values(" + txtorderid.Text + "," + cbxcustomer.SelectedValue + ",N'" + cbxcustomer.Text + "',N'" + discriptionemp + "'," + txttotalmadfou3.Text + ",0," + txttotalmadfou3.Text + ",N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + d + "',N'" + billtype + "',N'" + t + "'," + txtorderid.Text + ")", "");

                        }
                    }

                        //الخزنه

                        DataTable tblupdatestoke = new DataTable();
                         tblupdatestoke.Clear();
                        tblupdatestoke = db.readdata("select*from stoke_insert where order_id2=" + txtorderid.Text + " and branch_name=N'" + Properties.Settings.Default.branch_name + "'", "");
                    decimal oldmoney = 0;
                    if (tblupdatestoke.Rows.Count>=1)
                    {
                        oldmoney = Convert.ToDecimal(tblupdatestoke.Rows[0][2]);

                    }
                    else
                    {
                        oldmoney = 0;
                    }
                    if (tblupdatestoke.Rows.Count >= 1)
                    {
                        db.excutedata("update stoke_insert set money=" + txttotalmadfou3.Text + " where order_id2=" + txtorderid.Text + " and branch_name=N'" + Properties.Settings.Default.branch_name + "'", "");
                    }
                    else
                    {
                        string type = "";
                        if(radiocustomer.Checked==true)
                        {
                            type = "عميل";
                        }
                        else if(radiosupplier.Checked==true)
                        {
                            type = "مورد";
                        }
                        else if(radioemployee.Checked==true)
                        {
                            type = "موظف";
                        }
                        string description2 = "بعد التعديل-فاتوره مبيعات رقم" + " " + txtorderid.Text + " " +" "+type+" "+ cbxcustomer.Text; 
                        db.excutedata("insert into stoke_insert (stoke_id,money,date,name,type,notes,user_name,branch_name,order_id2) values(" + stoke_id + "," + txttotalmadfou3.Text + ",'" + d + "',N'" + description2 + "',N'عمليه بيع',N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "'," + txtorderid.Text + ")", "");

                    }
                    decimal finalmoney = Convert.ToDecimal(txttotalmadfou3.Text);
                        db.excutedata("update stoke_money set money=money-" + oldmoney + " where stoke_id=" + Properties.Settings.Default.stoke_id + "", "");
                        db.excutedata("update stoke_money set money=money+" +finalmoney  + " where stoke_id=" + Properties.Settings.Default.stoke_id + "", "");


                    //================================================================================================



                    MessageBox.Show("تم تنفيذ العمليه بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    print();
                    tileItem1.Enabled = true;
                        panelupdate.Visible = false;
                        autonumber();

                    //}
                }
            }
            

        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            panelupdate.Visible = false;
            tileItem1.Enabled = true;
            autonumber();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            panelupdate.Visible = false;
        }

        private void cbxmandoup_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        //get the balance of customer or supplier depending on the choose of user
        private void cbxcustomer_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //customer
            if (radiocustomer.Checked == true)
            {


                tbl.Clear();
                tbl = db.readdata("select*from customer_account where cust_id=" + cbxcustomer.SelectedValue + "", "");
                decimal onhim = 0, sadad = 0, final = 0;
                for (int i = 0; i <= tbl.Rows.Count - 1; i++)
                {
                    onhim += Convert.ToDecimal(tbl.Rows[i][9]);
                    sadad += Convert.ToDecimal(tbl.Rows[i][10]);
                }
                final += onhim - sadad;
                lbloldbalance.Text = final.ToString();

            }
            //supplier
            else if (radiosupplier.Checked == true)
            {
                tbl.Clear();
                tbl = db.readdata("select*from supplier_account where sup_id=" + cbxcustomer.SelectedValue + "", "");
                decimal onhim = 0, sadad = 0, final = 0;
                for (int i = 0; i <= tbl.Rows.Count - 1; i++)
                {
                    onhim += Convert.ToDecimal(tbl.Rows[i][9]);
                    sadad += Convert.ToDecimal(tbl.Rows[i][10]);
                }
                final += onhim - sadad;
                lbloldbalance.Text = final.ToString();
            }
            else if (radioemployee.Checked == true)
            {

            }
        }

        private void tileItem7_ItemClick(object sender, TileItemEventArgs e)
        {
            if (radioreturns.Checked == true)
            {
                string d = dtpdate.Value.ToString("yyyy-MM-dd");
                string t = dtptime.Text;

                //check the stoke money if there is money or not

                tbl.Clear();
                tbl = db.readdata("select*from stoke_money where stoke_id=" + stoke_id + "", "");


                if (Convert.ToDecimal(txttotalmadfou3.Text) > Convert.ToDecimal(tbl.Rows[0][1]))
                {
                    MessageBox.Show("الخزنه المبلغ الموجود بها غير كافي لاتمام عمليه المرتجع", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }


                if (dgv.Rows.Count >= 1)
                {
                    //جدول ال returns
                    db.excutedata("insert into returns_sales values(" + txtreturn_id.Text.Trim() + "," + cbxcustomer.SelectedValue + ",N'" + d + "',N'" + Properties.Settings.Default.user_name + "'," + numircprice.Value + "," + txttotalorder.Text + ",N'" + t + "',N'" + Properties.Settings.Default.branch_name + "',N'" + txtnotes.Text.Trim() + "'," + dgv.CurrentRow.Cells[10].Value + "," + lblitemscount.Text + ",N'" + dgv.CurrentRow.Cells[9].Value + "')", "");

                    
                    string type = "";
                    if (radioagel.Checked == true)
                    {
                        type = "اجل";
                    }
                    else if (radiocash.Checked == true)
                    {
                        type = "كاش";
                    }

                    for (int i = 0; i <= dgv.Rows.Count - 1; i++)
                    {
                        db.excutedata("insert into return_details_sales values(" + txtreturn_id.Text.Trim() + "," + cbxcustomer.SelectedValue + "," + dgv.Rows[i].Cells[0].Value + "," + dgv.Rows[i].Cells[3].Value + ",N'" + d + "',N'" + Properties.Settings.Default.user_name + "'," + dgv.Rows[i].Cells[4].Value + "," + dgv.Rows[i].Cells[5].Value + "," + numircprice.Value + "," + dgv.Rows[i].Cells[6].Value + "," + txttotalorder.Text + "," + Properties.Settings.Default.taxvalue + "," + dgv.Rows[i].Cells[4].Value + ",N'" + dtptime.Text + "',N'" + dgv.Rows[i].Cells[2].Value + "',N'" + Properties.Settings.Default.branch_name + "',N'" + dgv.Rows[i].Cells[7].Value + "',N'" + txtnotes.Text.Trim() + "'," + dgv.Rows[i].Cells[10].Value + "," + dgv.Rows[i].Cells[12].Value + "," + lblitemscount.Text + ",N'" + dgv.Rows[i].Cells[11].Value + "',N'" + dgv.Rows[i].Cells[1].Value + "')", "");


                        //الكميات
                        //جدول products_Qty

                        DataTable tblsmallunitupdateprice = new DataTable();
                        tblsmallunitupdateprice.Clear();
                        tblsmallunitupdateprice = db.readdata("select*from product_units where pro_id=" + dgv.Rows[i].Cells[0].Value + " and unit_name=N'" + dgv.Rows[i].Cells[2].Value + "'", "");


                        DataTable tblsmallqty = new DataTable();
                        tblsmallqty.Clear();
                        tblsmallqty = db.readdata("select*from products where product_id=" + dgv.Rows[i].Cells[0].Value + "", "");


                        decimal smallqty = Convert.ToDecimal(tblsmallqty.Rows[0][25]);

                        decimal realqty = 0;
                        if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3]) > 1)
                        {
                            realqty += Convert.ToDecimal(dgv.Rows[i].Cells[3].Value);
                        }
                        else if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3]) == 1)
                        {
                            realqty += Convert.ToDecimal(dgv.Rows[i].Cells[3].Value) * smallqty;
                        }
                        db.excutedata("update products_Qty set Qty=Qty+" + realqty + " where pro_id=" + dgv.Rows[i].Cells[0].Value + "", "");

                        //جدول products_Qtyinstore
                        db.excutedata("update products_Qtyinstore set Qty=Qty+" + realqty + " where pro_id=" + dgv.Rows[i].Cells[0].Value + " and store_id=" + dgv.Rows[i].Cells[12].Value + "", "");



                        //item_card
                        string discription = "وارد مرتجع من عمليه بيع للعميل  " + " " + cbxcustomer.Text + " " + "عمليه رقم" + " " + txtorderid.Text;
                        db.excutedata("insert into item_card values(" + dgv.Rows[i].Cells[0].Value + ",N'" + dgv.Rows[i].Cells[1].Value + "'," + dgv.Rows[i].Cells[12].Value + ",N'" + dgv.Rows[i].Cells[11].Value + "',N'" + d + "'," + realqty + ",N'" + dgv.Rows[i].Cells[2].Value + "',N'" + discription + "'," + realqty + ",0,0,N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + txtnotes.Text.Trim() + "'," + txtorderid.Text + ",N'منصرف')", "");


                        string discription2 = " مرتجع من عمليه بيع للعميل  " + " " + cbxcustomer.Text + " " + "عمليه رقم" + " " + txtorderid.Text;

                        //customer_account
                        if (radiocustomer.Checked == true)
                        {
                            db.excutedata("insert into customer_account values(" + txtreturn_id.Text+ "," + cbxcustomer.SelectedValue + ",N'" + cbxcustomer.Text + "',N'" + discription2 + "',N'" + dgv.Rows[i].Cells[1].Value + "'," + dgv.Rows[i].Cells[3].Value + ",N'" + dgv.Rows[i].Cells[2].Value + "'," + dgv.Rows[i].Cells[6].Value + "," + txttotalorder.Text + ",0," + dgv.Rows[i].Cells[6].Value + ",N'" + dgv.Rows[i].Cells[7].Value + "',N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + d + "',N'" + type + "',N'" + t + "'," + txtorderid.Text + ")", "");
                        }
                        else if (radiosupplier.Checked == true)
                        {
                            string descriptionsup = "وارد مرتجع من عمليه بيع للمورد  " + " " + cbxcustomer.Text + " " + "عمليه رقم" + " " + txtorderid.Text;
                            db.excutedata("insert into supplier_account values(" + txtreturn_id.Text + "," + cbxcustomer.SelectedValue + ",N'" + cbxcustomer.Text + "',N'" + descriptionsup + "',N'" + dgv.Rows[i].Cells[1].Value + "'," + dgv.Rows[i].Cells[3].Value + "," + dgv.Rows[i].Cells[6].Value + "," + txttotalorder.Text + ",N'" + txtnotes.Text.Trim() + "'," + dgv.Rows[i].Cells[6].Value + ",0,0,N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + d + "',N'" + type + "',N'" + dgv.Rows[i].Cells[2].Value + "'," + txtorderid.Text + ")", "");

                        }
                        else if (radioemployee.Checked == true)
                        {
                            string descriptionemp = "وارد مرتجع من عمليه بيع للموظف  " + " " + cbxcustomer.Text + " " + "عمليه رقم" + " " + txtorderid.Text;
                            db.excutedata("insert into employee_account values(" + txtreturn_id.Text + "," + cbxcustomer.SelectedValue + ",N'" + cbxcustomer.Text + "',N'" + descriptionemp + "'," + dgv.Rows[i].Cells[6].Value + "," + dgv.Rows[i].Cells[6].Value + ",0,N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + d + "',N'" + type + "',N'" + t + "'," + txtorderid.Text + ")", "");

                        }

                    }
                    //خصم
                    if (numircprice.Value != 0 && radiocustomer.Checked == true)
                    {
                        db.excutedata("insert into customer_account values(" + txtreturn_id.Text + "," + cbxcustomer.SelectedValue + ",N'" + cbxcustomer.Text + "',N'خصم',N'-',0,N'-'," + numircprice.Value + "," + numircprice.Value + "," + numircprice.Value + ",0,N'',N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + d + "',N'" + type + "',N'" + t + "'," + txtorderid.Text + ")", "");

                    }
                    else if (numircprice.Value != 0 && radiosupplier.Checked == true)
                    {
                        //string descriptionsup = "وارد مرتجع من عمليه بيع للمورد  " + " " + cbxcustomer.Text + " " + "عمليه رقم" + " " + txtorderid.Text;
                        db.excutedata("insert into supplier_account values(" + txtreturn_id.Text + "," + cbxcustomer.SelectedValue + ",N'" + cbxcustomer.Text + "',N'خصم',N'-',0," + numircprice.Value + "," + numircprice.Value + ",N'" + txtnotes.Text.Trim() + "',0," + numircprice.Value + ",0,N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + d + "',N'" + type + "',N'-'," + txtorderid.Text + ")", "");

                    }
                   


                    //الخزنه

                    tbl.Clear();
                    tbl = db.readdata("select*from stoke_money where stoke_id=" + stoke_id + "", "");
                    if (tbl.Rows.Count >= 1)
                    {


                        db.excutedata("update stoke_money set money=money-" + txttotalmadfou3.Text + " where stoke_id=" + stoke_id + "", "");
                    }
                    else if (tbl.Rows.Count < 1)
                    {
                        db.excutedata("insert into stoke_money values(" + stoke_id + "," + txttotalmadfou3.Text + ")", "");
                    }
                    string discription3 = " مرتجع من عمليه بيع للعميل  " + " " + cbxcustomer.Text + " " + "عمليه رقم" + " " + txtorderid.Text;
                    if (Convert.ToDecimal(txttotalmadfou3.Text) != 0)
                    {
                        db.excutedata("insert into stoke_withdrowal (stoke_id,money,date,name,type,notes,user_name,branch_name,order_id2)values(" + stoke_id + "," + txttotalmadfou3.Text + ",N'" + d + "',N'" + discription3 + "',N'مرتجع بيع',N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "'," + txtorderid.Text + ")", "");
                    }
                    MessageBox.Show("تمتم عمليه المرتجع بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    autonumber();
                    autonumberreturns();
                    radioreturns.Checked = false;
                }
            }

        }
        //radio returns
        private void radioreturns_CheckedChanged(object sender, EventArgs e)
        {
            autonumberreturns();
            tileItem7.Enabled = true;
            tileItem1.Enabled = false;
            radioreturns.Checked = true;
        }

        //radio customer
        private void radiocustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (radioemployee.Checked == true)
            {
                cbxcustomer.DataSource = db.readdata("select*from customers", "");
                cbxcustomer.DisplayMember = "cust_name";
                cbxcustomer.ValueMember = "cust_id";

                label3.Text = "اختر عميل :";
                numircprice.Enabled = false;
            }
            numircprice.Enabled = true;
        }

        //radio employee
        private void radioemployee_CheckedChanged(object sender, EventArgs e)
        {
            if (radioemployee.Checked == true)
            {
                cbxcustomer.DataSource = db.readdata("select*from add_new_employee", "");
                cbxcustomer.DisplayMember = "emp_name";
                cbxcustomer.ValueMember = "emp_id";

                label3.Text = "اختر موظف :";
                numircprice.Enabled = false;
            }
        }

        //delete bill
        private void simpleButton8_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من حذف الفاتوره", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //delete data from sales sales details and item card and sales details mony
                db.excutedata("delete from sales where order_id=" + txtorderid.Text + " and branch_name=N'" + Properties.Settings.Default.branch_name + "'", "");
                db.excutedata("delete from sales_details where order_id=" + txtorderid.Text + " and branch_name=N'" + Properties.Settings.Default.branch_name + "'", "");
                db.excutedata("delete from item_card where order_id=" + txtorderid.Text + " and branch_name=N'" + Properties.Settings.Default.branch_name + "' and type=N'منصرف'", "");
                db.excutedata("delete from sales_details_money where order_id="+txtorderid.Text+" and branch_name=N'"+Properties.Settings.Default.branch_name+"'", "");


                //delete the bill if customer supplier employee
                if (radiocustomer.Checked == true)
                {
                    db.excutedata("delete from customer_account where order_id2=" + txtorderid.Text + " and branch_name=N'" + Properties.Settings.Default.branch_name + "'", "");
                }
                else if (radiosupplier.Checked == true)
                {
                    db.excutedata("delete from supplier_account where  order_id2=" + txtorderid.Text + " and branch_name=N'" + Properties.Settings.Default.branch_name + "' ", "");
                }
                else if (radioemployee.Checked == true)
                {
                    db.excutedata("delete from employee_account where  order_id2=" + txtorderid.Text + " and branch_name=N'" + Properties.Settings.Default.branch_name + "'", "");
                }
                for (int i = 0; i <= dgv.Rows.Count - 1; i++)
                {
                    decimal totalmoney55 = 0, sadad = 0, balance55 = 0;
                    //get the data from customer account and update it
                    DataTable tbloldmoney = new DataTable();
                    tbloldmoney.Clear();
                    tbloldmoney = db.readdata("select*from customer_account where cust_id=" + lblsup_id.Text + " and order_id<=" + txtorderid.Text + "", "");
                    for (int x = 0; x <= tbloldmoney.Rows.Count - 1; x++)
                    {


                        totalmoney55 += Convert.ToDecimal(tbloldmoney.Rows[x][9]);
                        sadad += Convert.ToDecimal(tbloldmoney.Rows[x][10]);
                    }
                    try
                    {
                        balance55 += (totalmoney55 + Convert.ToDecimal(dgv.Rows[i].Cells[6].Value)) - sadad;
                    }
                    catch (Exception) { }

                    
                    //====================================================

                    //جدول الكميات products_qty

                    DataTable tblsmallqty = new DataTable();

                    tblsmallqty.Clear();
                    tblsmallqty = db.readdata("select*from products where product_id=" + dgv.Rows[i].Cells[0].Value + "", "");

                    //smal unit to change qty
                    decimal smallqty = Convert.ToDecimal(tblsmallqty.Rows[0][25]);
                    //===============================================
                    //insert into item card

                    DataTable tblfinaltotalqtycash = new DataTable();
                    tblfinaltotalqtycash.Clear();
                    tblfinaltotalqtycash = db.readdata("select*from item_card where pro_id=" + dgv.Rows[i].Cells[0].Value + "", "");
                    decimal totalward = 0, totalmosarf = 0, balance = 0, realqty = 0;
                    for (int q = 0; q <= tblfinaltotalqtycash.Rows.Count - 1; q++)
                    {
                        totalward += Convert.ToDecimal(tblfinaltotalqtycash.Rows[q][8]);
                        totalmosarf += Convert.ToDecimal(tblfinaltotalqtycash.Rows[q][9]);


                    }
                    if (tblfinaltotalqtycash.Rows.Count >= 1)
                    {
                        balance += (totalward - realqty) - totalmosarf;
                    }
                    else if (tblfinaltotalqtycash.Rows.Count < 1)
                    {
                        balance += realqty;
                    }
                    //===============================================================================================================================================================================
                    //update product_Qty
                    //================================================================================================================
                    DataTable tblsmallunitupdateprice = new DataTable();
                    tblsmallunitupdateprice.Clear();
                    tblsmallunitupdateprice = db.readdata("select*from product_units where pro_id=" + dgv.Rows[i].Cells[0].Value + " and unit_name=N'" + dgv.Rows[i].Cells[2].Value + "'", "");

                    //ارجاع الكميه
                    if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3]) > 1)
                    {
                        realqty = Convert.ToDecimal(dgv.Rows[i].Cells[3].Value);
                    }
                    else if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3]) == 1)
                    {
                        realqty = Convert.ToDecimal(dgv.Rows[i].Cells[3].Value) * smallqty;
                    }

                    //real qty
                    //----------------------------
                    decimal realqty2 = 0;
                    if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3]) > 1)
                    {
                        realqty2 = Convert.ToDecimal(dgv.Rows[i].Cells[14].Value);
                    }
                    else if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3]) == 1)
                    {
                        realqty2 = Convert.ToDecimal(dgv.Rows[i].Cells[14].Value) * smallqty;
                    }
                    //update product qty
                    db.excutedata("update products_Qty set Qty=Qty+" + realqty2 + " where pro_id=" + dgv.Rows[i].Cells[0].Value + " ", "");

                    DataTable tblchecktable = new DataTable();
                    tblchecktable.Clear();
                    tblchecktable = db.readdata("select*from products_Qtyinstore where pro_id=" + dgv.Rows[i].Cells[0].Value + " and store_id=" + dgv.Rows[i].Cells[12].Value + "", "");
                    if (tblchecktable.Rows.Count >= 1)
                    {
                        
                        db.excutedata("update products_Qtyinstore set Qty=Qty+" + realqty2 + " where pro_id=" + dgv.Rows[i].Cells[0].Value + " and store_id=" + dgv.Rows[i].Cells[12].Value + "", "");

                    }
                    else if (tblchecktable.Rows.Count < 1)
                    {
                        db.excutedata("insert into products_Qtyinstore values (" + dgv.Rows[i].Cells[0].Value + ",N'" + dgv.Rows[i].Cells[1].Value + "'," + realqty2 + "," + dgv.Rows[i].Cells[12].Value + ",N'" + dgv.Rows[i].Cells[11].Value + "')", "");
                    }
                    //====================================================
                    //الخزنه

                    DataTable tblupdatestoke = new DataTable();
                    tblupdatestoke.Clear();
                    tblupdatestoke = db.readdata("select*from stoke_insert where order_id2=" + txtorderid.Text + " and branch_name=N'" + Properties.Settings.Default.branch_name + "'", "");

                    decimal oldmoney = 0;
                    if(tblupdatestoke.Rows.Count>=1)
                    {
                         oldmoney = Convert.ToDecimal(tblupdatestoke.Rows[0][2]);
                    }
                    else
                    {
                        oldmoney = 0;
                    }
                    //delete the old operation and update stoke money
                    db.excutedata("delete from stoke_insert   where order_id2=" + txtorderid.Text + " and branch_name=N'" + Properties.Settings.Default.branch_name + "'", "");
                    db.excutedata("update stoke_money set money=money-" + oldmoney + " where stoke_id=" + Properties.Settings.Default.stoke_id + "", "");

                    MessageBox.Show("تم حذف الفاتوره بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    autonumber();
                }
            }
                }

        private void tileItem3_ItemClick(object sender, TileItemEventArgs e)
        {
            panelupdate.Visible = true;
            btnupdate.Enabled = false;
        }

        private void txttotalbakey_TextChanged(object sender, EventArgs e)
        {

        }

        private void tileItem8_ItemClick(object sender, TileItemEventArgs e)
        {
            customer_accounts frm = new customer_accounts();
            frm.ShowDialog();
        }

        private void tileItem10_ItemClick(object sender, TileItemEventArgs e)
        {
            supplier_account frm = new supplier_account();
            frm.ShowDialog();
        }

        private void tileItem11_ItemClick(object sender, TileItemEventArgs e)
        {
            employee_accounts frm = new employee_accounts();
            frm.ShowDialog();
        }

        private void tileItem9_ItemClick(object sender, TileItemEventArgs e)
        {
            sand_kabd frm = new sand_kabd();
            frm.ShowDialog();
        }

        private void tileItem12_ItemClick(object sender, TileItemEventArgs e)
        {
            sand_sarf frm = new sand_sarf();
            frm.ShowDialog();
        }

        private void tileItem13_ItemClick(object sender, TileItemEventArgs e)
        {
            item_cardscreen frm = new item_cardscreen();
            frm.ShowDialog();
        }

        private void tileItem14_ItemClick(object sender, TileItemEventArgs e)
        {
            sales_reports frm = new sales_reports();
            frm.ShowDialog();
        }

        private void tileItem15_ItemClick(object sender, TileItemEventArgs e)
        {
            transferproductsbetweenstores frm = new transferproductsbetweenstores();
            frm.ShowDialog();
        }

        private void tileItem16_ItemClick(object sender, TileItemEventArgs e)
        {
            returns_sales_reports frm = new returns_sales_reports();
            frm.ShowDialog();
        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }
    }
    }
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
    public partial class buy : DevExpress.XtraEditors.XtraForm
    {
        public buy()
        {
            InitializeComponent();
        }

        //call databse class
        DataTable tbl = new DataTable();
        database db = new database();
        private void autonumber()
        {
            //create autonumber from table called sandat_id that table made to generete id for purchases and sales and reurns(sales,purchases)
            tbl.Clear();
            tbl = db.readdata("select*from sandat_id", "");
            //if there is not data insert into this table  sandat_id=1000000
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
            txtorderid.Text = Convert.ToString(tblorder_id.Rows[0][0]);
            txtreturn_id.Text = Convert.ToString(tblorder_id.Rows[0][0]);
            txteznnumber.Text = Convert.ToString(tblorder_id.Rows[0][0]);

            ////returns autonumber
            if (radioreturns.Checked == true)
            {
         
        
            dgv.Rows.Clear();
            txttotalmadfou3.Text = "0.0";
                DataTable tblcheckproducts = new DataTable();
                tblcheckproducts.Clear();
                tblcheckproducts = db.readdata("select*from products", "");
                if(tblcheckproducts.Rows.Count<1)
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
            txttotalbakey.Text = "0.0";
            txttotalorder.Text = "0.0";
            radioagel.Checked = false;
            radiocash.Checked = false;
            lblitemscount.Text = "0";
            radioreturns.Checked = true;
            tileItem7.Enabled = true;
            tileItem1.Enabled = false;
            simpleButton4.Enabled = true;
            btnupdate.Enabled = true;
            txtnotes.Text = "";
        }
    

            //===================================================================
            dgv.Rows.Clear();
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
            txttotalbakey.Text = "0.0";
            txttotalorder.Text = "0.0";
            radioagel.Checked = false;
            radiocash.Checked = false;
            lblitemscount.Text = "0";
            radioreturns.Checked = false;
            tileItem7.Enabled = false;
            tileItem1.Enabled = true;
            txtnotes.Text = "";

        }

        //fill combobox of products , mandoup , stores ,suppliers ,units
        private void fillcbx()
        {
            cbxchooseproduct.DataSource = db.readdata("select*from products", "");
            cbxchooseproduct.DisplayMember = "product_name";
            cbxchooseproduct.ValueMember = "product_id";

            cbxmandoup.DataSource = db.readdata("select*from mandoup", "");
            cbxmandoup.DisplayMember = "mandoup_name";
            cbxmandoup.ValueMember = "mandoup_id";

            cbxstore.DataSource = db.readdata("select*from stores", "");
            cbxstore.DisplayMember = "store_name";
            cbxstore.ValueMember = "store_id";

            cbxsupplier.DataSource = db.readdata("select*from suppliers", "");
            cbxsupplier.DisplayMember = "sup_name";
            cbxsupplier.ValueMember = "sup_id";

            cbxunit.DataSource = db.readdata("select*from units", "");
            cbxunit.DisplayMember = "unit_name";
            cbxunit.ValueMember = "unit_id";

        }
        //get id of user stoke
        int stoke_id = Properties.Settings.Default.stoke_id;

        //print purchase bill
        private void print()
        {
            //get the branch selected
            string branch_name = Properties.Settings.Default.branch_name;
            //check if the printing A4 or 8cm paper and size
            //printing A4
            if (Properties.Settings.Default.purchasesprintkind == "A4")
            {
                try
                {
                    //id of bill
                    int order_id = Convert.ToInt32(txtorderid.Text);
                    DataTable tblprint = new DataTable();
                    tblprint.Clear();
                    tblprint = db.readdata("select settingprinting_bills.logo as'اللوجو',settingprinting_bills.name as'اسم الشركه',settingprinting_bills.address as'العنوان',settingprinting_bills.phone1 as'تليفون1',settingprinting_bills.phone2 as'تليفون2',settingprinting_bills.phone3 as'تليفون3',settingprinting_bills.commerical_re as'الرقم التجاري',settingprinting_bills.tax_re as'الرقم الضريبي',buy_details.order_id as'رقم الفاتوره',ezn_id as'رقم الاذن',suppliers.sup_name as'اسم المورد',products.product_name as'المنتج',buy_details.Qty as'الكميه',buy_details.date as'التاريخ',buy_details.user_name as'المستخدم',buy_details.price_tax as'المبلغ',buy_details.discountontotalorder as'الخصم الكلي',buy_details.total as'الاجمالي',buy_details.totalorder as'الاجمالي الكلي',buy_details.unit_name as'الوحده',buy_details.type as'نوع الفاتوره',buy_details.branch_name as'الفرع',buy_details.notes_item as'ملاحظه صنف',buy_details.notes as'ملاحظات عامه',buy_details.mandoup_name as'المندوب',buy_details.store_name as'المخزن',buy_details_money.madfou3 as'المدفوع'  from buy_details,suppliers,settingprinting_bills,products,buy_details_money where buy_details.product_id=products.product_id and suppliers.sup_id=buy_details.sup_id and buy_details.order_id=buy_details_money.order_id and buy_details.order_id="+order_id+" and buy_details.branch_name=N'"+branch_name+"' and buy_details.branch_name=buy_details_money.branch_name", "");
                    //printing form
                    printing frm = new printing();
                    frm.crystalReportViewer1.RefreshReport();

                    //report of crystal report printing
                   buy_print rpt = new buy_print();
                    rpt.SetDatabaseLogon("", "", Properties.Settings.Default.servername, Properties.Settings.Default.databasename);
                    //Quary
                    rpt.SetDataSource(tblprint);
                    //parameters
                    rpt.SetParameterValue("order_id", order_id);
                    rpt.SetParameterValue("branch_name", branch_name);
                    frm.crystalReportViewer1.ReportSource = rpt;
                    frm.ShowDialog();
                    //System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                    //rpt.PrintOptions.PrinterName = Properties.Settings.Default.printername;
                    //rpt.PrintToPrinter(1, true, 0, 0);
                }
                catch (Exception) { }
            }
           

        }
    

        private void buy_Load(object sender, EventArgs e)
        {
            dtpdate.Text = DateTime.Now.ToShortDateString();
            autonumber();
            fillcbx();
        }

        private void btnaddstore_Click(object sender, EventArgs e)
        { 
            //open stores form to add new store and rload data again after close this form
            ddnewstore frm = new ddnewstore();
            frm.ShowDialog();
            cbxstore.DataSource = db.readdata("select*from stores", "");
            cbxstore.DisplayMember = "store_name";
            cbxstore.ValueMember = "store_id";
        }

        private void btnaddmandoup_Click(object sender, EventArgs e)
        {          
            //open mandoup form to add new mandoup and rload data again after close this form
            mandoup frm = new mandoup();
            frm.ShowDialog();
            cbxmandoup.DataSource = db.readdata("select*from mandoup", "");
            cbxmandoup.DisplayMember = "mandoup_name";
            cbxmandoup.ValueMember = "mandoup_id";
        }

        private void btncustomer_Click(object sender, EventArgs e)
        {
            //open suppliers form to add new supplier and rload data again after close this form
            suppliers frm = new suppliers();
            frm.ShowDialog();

            cbxsupplier.DataSource = db.readdata("select*from suppliers", "");
            cbxsupplier.DisplayMember = "sup_name";
            cbxsupplier.ValueMember = "sup_id";
        }

        private void txtpronamesearch_TextChanged(object sender, EventArgs e)
        {
            //search about product depending on letter of his name
            tbl.Clear();
            tbl = db.readdata("select product_id as 'رقم المنتج',product_name as 'اسم المنتج'from products where product_name like N'%" + txtpronamesearch.Text.Trim() + "%'", "");
            dgvproducts.DataSource = tbl;
        }

        //drag product from combobox of products

        private void btndown_Click(object sender, EventArgs e)
        {
            //drag the selected product
            //validation before drag
            if (cbxchooseproduct.SelectedIndex < 0)
            {
                MessageBox.Show("من فضلك ادخل المنتجات اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cbxsupplier.SelectedIndex < 0)
            {
                MessageBox.Show("من فضلك ادخل الموردين  اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cbxstore.SelectedIndex < 0)
            {
                MessageBox.Show("من فضلك ادخل المخازن اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cbxmandoup.SelectedIndex < 0)
            {
                MessageBox.Show("من فضلك ادخل الناديب اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //get data of products
            DataTable tblitems = new DataTable();
            tblitems.Clear();
            //get prices
            DataTable tblprice = new DataTable();
            tblprice.Clear();
            //get units of selected product
            DataTable tblunit = new DataTable();
            tblunit.Clear();
            //get the data of selected product in combo box of products
            tblitems = db.readdata("select*from products where product_id=" + cbxchooseproduct.SelectedValue + "", "");




            //check of there is products or not and if there is products
            if (tblitems.Rows.Count >= 1)
            {

                //get data of selected product to show it in the datagridview
                string product_id = tblitems.Rows[0][0].ToString();
                string product_name = tblitems.Rows[0][1].ToString();
                string product_unit = tblitems.Rows[0][19].ToString();
                decimal Qty = 1;



                decimal discount = 0;

                //Add data of product in datagridview
                dgv.Rows.Add(1);
                int rowindex = dgv.Rows.Count - 1;

                dgv.Rows[rowindex].Cells[0].Value = product_id;
                dgv.Rows[rowindex].Cells[1].Value = product_name;
                dgv.Rows[rowindex].Cells[2].Value = product_unit;
                dgv.Rows[rowindex].Cells[3].Value = Qty;
                dgv.Rows[rowindex].Cells[8].Value = dgv.Rows.Count;
                dgv.Rows[rowindex].Cells[9].Value = cbxstore.Text;
                dgv.Rows[rowindex].Cells[10].Value = cbxstore.SelectedValue;
                dgv.Rows[rowindex].Cells[11].Value = Properties.Settings.Default.branch_name;

                //select the units of selected product
                tblunit = db.readdata("select*from product_units where pro_id=" + tblitems.Rows[0][0] + "and unit_name=N'" + product_unit + "'", "");
                //select the p[rices of product
                string product_price = tblunit.Rows[0][5].ToString();


                decimal realprice = 0;
                try
                {


                    //get the real price
                    realprice = Convert.ToDecimal(product_price);

                }
                catch (Exception) { }
                //get totl of the quantity of the product
                decimal total = Convert.ToDecimal(Qty) * Convert.ToDecimal(realprice);
                dgv.Rows[rowindex].Cells[4].Value = Math.Round(realprice, 2);
                dgv.Rows[rowindex].Cells[5].Value = discount;
                dgv.Rows[rowindex].Cells[6].Value = Math.Round(total, 2);

                //get the total of all bill and show it in the textbox of total order
                decimal totalorder = 0;
                for (int i = 0; i <= dgv.Rows.Count - 1; i++)
                {
                    totalorder += Convert.ToDecimal(dgv.Rows[i].Cells[6].Value);
                    dgv.ClearSelection();
                    dgv.FirstDisplayedScrollingRowIndex = dgv.Rows.Count - 1;
                    dgv.Rows[dgv.Rows.Count - 1].Selected = true;
                }
                txttotalorder.Text = Math.Round(totalorder, 2).ToString();
                //count of products in datagridview
                lblitemscount.Text = dgv.Rows.Count.ToString();

            }
        }

        //drag product from datagridview of products
        private void btndown2_Click(object sender, EventArgs e)
        {
            //drag the selected product
            //validation before drag

            if (dgvproducts.Rows.Count >= 1)
            {
                if (cbxchooseproduct.SelectedIndex < 0)
                {
                    MessageBox.Show("من فضلك ادخل المنتجات اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (cbxsupplier.SelectedIndex < 0)
                {
                    MessageBox.Show("من فضلك ادخل الموردين  اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (cbxstore.SelectedIndex < 0)
                {
                    MessageBox.Show("من فضلك ادخل المخازن اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (cbxmandoup.SelectedIndex < 0)
                {
                    MessageBox.Show("من فضلك ادخل الناديب اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                //get data of products
                DataTable tblitems = new DataTable();
                tblitems.Clear();
                //get prices
                DataTable tblprice = new DataTable();
                tblprice.Clear();
                //get units of selected product
                DataTable tblunit = new DataTable();
                tblunit.Clear();
                //get the data of selected product in datagridview of products
                tblitems = db.readdata("select*from products where product_id=" + dgvproducts.CurrentRow.Cells[0].Value + "", "");

                //check of there is products or not and if there is products
                if (tblitems.Rows.Count >= 1)
                {
                    //get data and set it in variables

                    string product_id = tblitems.Rows[0][0].ToString();
                    string product_name = tblitems.Rows[0][1].ToString();
                    string product_unit = tblitems.Rows[0][19].ToString();
                    decimal Qty = 1;
                    
                    decimal discount = 0;

                    //add data that set in variables in product datagridview
                    dgv.Rows.Add(1);
                    int rowindex = dgv.Rows.Count - 1;

                    dgv.Rows[rowindex].Cells[0].Value = product_id;
                    dgv.Rows[rowindex].Cells[1].Value = product_name;
                    dgv.Rows[rowindex].Cells[2].Value = product_unit;
                    dgv.Rows[rowindex].Cells[3].Value = Qty;
                    dgv.Rows[rowindex].Cells[8].Value = dgv.Rows.Count;
                    dgv.Rows[rowindex].Cells[9].Value = cbxstore.Text;
                    dgv.Rows[rowindex].Cells[10].Value = cbxstore.SelectedValue;
                    dgv.Rows[rowindex].Cells[11].Value = Properties.Settings.Default.branch_name;

                    //get units of product
                    tblunit = db.readdata("select*from product_units where pro_id=" + tblitems.Rows[0][0] + "and unit_name=N'" + product_unit + "'", "");

                    string product_price = tblunit.Rows[0][5].ToString();


                    decimal realprice = 0;
                    try
                    {
                        //real price
                        realprice = Convert.ToDecimal(product_price);


                    }
                    catch (Exception) { }
                    //get totl of the quantity of the product
                    decimal total = Convert.ToDecimal(Qty) * Convert.ToDecimal(realprice);
                    dgv.Rows[rowindex].Cells[4].Value = Math.Round(realprice, 2);
                    dgv.Rows[rowindex].Cells[5].Value = discount;
                    dgv.Rows[rowindex].Cells[6].Value = Math.Round(total, 2);

                    //get the total of all bill and show it in the textbox of total order
                    decimal totalorder = 0;
                    for (int i = 0; i <= dgv.Rows.Count - 1; i++)
                    {
                        totalorder += Convert.ToDecimal(dgv.Rows[i].Cells[6].Value);
                        dgv.ClearSelection();
                        dgv.FirstDisplayedScrollingRowIndex = dgv.Rows.Count - 1;
                        dgv.Rows[dgv.Rows.Count - 1].Selected = true;
                    }
                    txttotalorder.Text = Math.Round(totalorder, 2).ToString();
                    //count of products in datagridview
                    lblitemscount.Text = dgv.Rows.Count.ToString();

                }
            }

        }

        //delete product from datagridview that shown bill
        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.Rows.Count >= 1)
                {
                    int index = dgv.SelectedRows[0].Index;
                    dgv.Rows.RemoveAt(index);

                    if (dgv.Rows.Count <= 0)
                    {
                        txttotalorder.Text = "0";
                    }
                    //calculate order after deleting the row
                    decimal totalorder = 0;
                    for (int i = 0; i <= dgv.Rows.Count - 1; i++)
                    {
                        totalorder += Convert.ToDecimal(dgv.Rows[i].Cells[6].Value);
                    }
                    txttotalorder.Text = Math.Round(totalorder, 2).ToString();
                    lblitemscount.Text = dgv.Rows.Count.ToString();
                    dgv.ClearSelection();
                    dgv.FirstDisplayedScrollingRowIndex = dgv.Rows.Count - 1;
                    dgv.Rows[dgv.Rows.Count - 1].Selected = true;
                }
                //focus on parcode textbox
                txtparcode.Focus();

            }
            catch (Exception) { }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //change unit in datagrid view  from this panal
            decimal unit_price = 0;
            DataTable tblunitprice = new DataTable();
            tblunitprice.Clear();
            tblunitprice = db.readdata("select*from product_units where pro_id=" + lblpro_id.Text + " and unit_name=N'" + cbxunit.Text.Trim() + "'", "");
            unit_price = Convert.ToDecimal(tblunitprice.Rows[0][5]);
            dgv.CurrentRow.Cells[2].Value = cbxunit.Text;
            dgv.CurrentRow.Cells[4].Value = unit_price;
            groupchangeunit.Visible = false;
            dgv.Enabled = true;
        }

        private void btnchangeunit_Click(object sender, EventArgs e)
        {
            //change big unit
            if (dgv.Rows.Count >= 1)
            {

                dgv.Enabled = false;
                groupchangeunit.Visible = true;
                lblpro_id.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
                lblpro_name.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
                lblunit_name.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value);

                cbxunit.DataSource = db.readdata("select*from product_units where pro_id=" + dgv.CurrentRow.Cells[0].Value + "", "");

            }
        }

        private void dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //change data from datagridview and set it again after change
            //discount
            decimal discount = 0, purchase_price = 0, Qty = 0;


            try
            {
                //selected row
                int index = dgv.SelectedRows[0].Index;

                //discount
                discount = Convert.ToDecimal(dgv.Rows[index].Cells[5].Value);
                //purchase price
                purchase_price = Convert.ToDecimal(dgv.Rows[index].Cells[4].Value);
                Qty = Convert.ToDecimal(dgv.Rows[index].Cells[3].Value);

                //total one product selected
                decimal total = 0;
                total = (Qty * purchase_price) - discount;

                //set total in selected row
                dgv.Rows[index].Cells[6].Value = total;

                //total order
                decimal totalorder = 0;
                for (int i = 0; i <= dgv.Rows.Count - 1; i++)
                {
                    totalorder += Convert.ToDecimal(dgv.Rows[i].Cells[6].Value);
                }
                txttotalorder.Text = Math.Round(totalorder, 2).ToString();
                //the best of order
                decimal bakey = Convert.ToDecimal(txttotalmadfou3.Text) - Convert.ToDecimal(txttotalorder.Text);
                txttotalbakey.Text = bakey.ToString();
            }

            catch (Exception)
            {


            }
        }

        private void txtdiscountontotal_TextChanged(object sender, EventArgs e)
        {
        }

        private void numircprice_ValueChanged(object sender, EventArgs e)
        {


        }

        private void numircprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //create discount on all bill or total order
            if (e.KeyChar == 13)
            {
                decimal totalafterdiscount = 0;
                decimal total = 0;
                //looping in datagridview to get total
                for (int i = 0; i <= dgv.Rows.Count - 1; i++)
                {
                    total += Convert.ToDecimal(dgv.Rows[i].Cells[6].Value);

                }
                // total after discount
                totalafterdiscount += total - Convert.ToDecimal(numircprice.Text);   
                //set total all order after discount
                txttotalorder.Text = totalafterdiscount.ToString();

                try
                {
                    
                    decimal bakey = 0;
                    bakey = Convert.ToDecimal(txttotalorder.Text) - Convert.ToDecimal(txttotalmadfou3.Text);
                    txttotalbakey.Text = bakey.ToString();


                }
                catch (Exception) { }
            }
        }

        private void tileItem5_ItemClick(object sender, TileItemEventArgs e)
        {
            autonumber();
        }

        //parcode
        private void txtparcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            //chooce product depending on parcode
            if (e.KeyChar == 13)
            {
                //validation parcode if null
                if (txtparcode.Text == "")
                {
                    MessageBox.Show("من فضلك ادخل باركود المنتج اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                else
                {

                    //validation on product that entered its parcode
                    if (cbxchooseproduct.SelectedIndex < 0)
                    {
                        MessageBox.Show("من فضلك ادخل المنتجات اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (cbxsupplier.SelectedIndex < 0)
                    {
                        MessageBox.Show("من فضلك ادخل الموردين  اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (cbxstore.SelectedIndex < 0)
                    {
                        MessageBox.Show("من فضلك ادخل المخازن اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (cbxmandoup.SelectedIndex < 0)
                    {
                        MessageBox.Show("من فضلك ادخل المناديب اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    //get data of products
                    DataTable tblitems = new DataTable();
                    tblitems.Clear();
                    //get prices
                    DataTable tblprice = new DataTable();
                    tblprice.Clear();
                    //get units of selected product

                    DataTable tblunit = new DataTable();
                    tblunit.Clear();
                    //get data of selected product depending on parcode
                    tblitems = db.readdata("select*from products where parcode=N'" + txtparcode.Text + "'", "");

                    //if the product table have data do that code
                    if (tblitems.Rows.Count >= 1)
                    {
                        //set the data of product on variables
                        string product_id = tblitems.Rows[0][0].ToString();
                        string product_name = tblitems.Rows[0][1].ToString();
                        string product_unit = tblitems.Rows[0][19].ToString();
                        decimal Qty = 1;

                        decimal discount = 0;

                        //add product data that set in variables in datagridview of product
                        dgv.Rows.Add(1);
                        int rowindex = dgv.Rows.Count - 1;

                        dgv.Rows[rowindex].Cells[0].Value = product_id;
                        dgv.Rows[rowindex].Cells[1].Value = product_name;
                        dgv.Rows[rowindex].Cells[2].Value = product_unit;
                        dgv.Rows[rowindex].Cells[3].Value = Qty;
                        dgv.Rows[rowindex].Cells[8].Value = dgv.Rows.Count;
                        dgv.Rows[rowindex].Cells[9].Value = cbxstore.Text;
                        dgv.Rows[rowindex].Cells[10].Value = cbxstore.SelectedValue;
                        dgv.Rows[rowindex].Cells[11].Value = Properties.Settings.Default.branch_name;

                        //get product unit of selected product
                        tblunit = db.readdata("select*from product_units where pro_id=" + tblitems.Rows[0][0] + "and unit_name=N'" + product_unit + "'", "");

                        string product_price = tblunit.Rows[0][5].ToString();


                        decimal realprice = 0;
                        try
                        {
                            //set real price
                            realprice = Convert.ToDecimal(product_price);
                            

                        }
                        catch (Exception) { }
                        //set total of selected product Qty*price
                        decimal total = Convert.ToDecimal(Qty) * Convert.ToDecimal(realprice);
                        dgv.Rows[rowindex].Cells[4].Value = Math.Round(realprice, 2);
                        //discount
                        dgv.Rows[rowindex].Cells[5].Value = discount;
                        //total
                        dgv.Rows[rowindex].Cells[6].Value = Math.Round(total, 2);

                        //total of all bill
                        decimal totalorder = 0;
                        for (int i = 0; i <= dgv.Rows.Count - 1; i++)
                        {
                            totalorder += Convert.ToDecimal(dgv.Rows[i].Cells[6].Value);
                            //clear selection from datagridview and select last row in datagridview 
                            dgv.ClearSelection();
                            dgv.FirstDisplayedScrollingRowIndex = dgv.Rows.Count - 1;
                            dgv.Rows[dgv.Rows.Count - 1].Selected = true;
                        }
                        //total of the bill 
                        txttotalorder.Text = Math.Round(totalorder, 2).ToString();
                        //count of products that shown in datagridview
                        lblitemscount.Text = dgv.Rows.Count.ToString();

                    }
                }
                //clear the text in parcode text and focus on
                 txtparcode.Clear();
                txtparcode.Focus();
            }
            txtparcode.Focus();


        }

        //change bill_id
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
            else if (radiochangebillid.Checked == false)
            {
                panelchangebillid.Visible = false;

            }
        }

        //button generate the new order id
        private void btnchange_Click(object sender, EventArgs e)
        {
            //set the new  order id in text order id and change the order number
            label26.Text = "";
            //order id now
            txtorder_idnow.Text = (Convert.ToDecimal(txtorder_idnow.Text) + 1).ToString();
            //order id new
            txtorder_idnew.Text = (Convert.ToDecimal(txtorder_idnow.Text) + 1).ToString();
            //ezn number change else 
            txteznnumber.Text = (Convert.ToDecimal(txtorder_idnow.Text) + 1).ToString();
            //focus on parcode again
            txtparcode.Focus();
        }

        //button done the new order id that generated
        private void btnooook_Click(object sender, EventArgs e)
        {
            //done the change of order id and close the panel of change
            txtorderid.Text = txtorder_idnew.Text;
            txtreturn_id.Text = txtorder_idnew.Text;
            txteznnumber.Text = txtorder_idnew.Text;

            panelchangebillid.Visible = false;
            radiochangebillid.Checked = false;
            txtparcode.Focus();
        }

        //button close the panel that mae order id changed
        private void btncloooose_Click(object sender, EventArgs e)
        {
            panelchangebillid.Visible = false;
        }

        //save the bill
        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            //check if there is the same order id
            //validations to save

            if (txtorderid.Text == "")
            {
                MessageBox.Show("من فضلك يجب ان يكون الفاتوره لها idبرجاء التواصل مع الدعم الفني", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dgv.Rows.Count >= 1)
            {
                if (cbxsupplier.Text == "")
                {
                    MessageBox.Show("من فضلك اختر مورد اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                if (radiocash.Checked == false && radioagel.Checked == false)
                {
                    MessageBox.Show("من فضلك اختر اذا كانت العمليه كاش ام اجل", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (Convert.ToDecimal(txttotalmadfou3.Text) == 0)
                {
                    if (MessageBox.Show("هل انت متاكد من ان المدفوع يساوي صفر من فضلك تاكد وتاكد ان المبلغ المتبقي صحيح", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        return;
                    }
                }
                if (Convert.ToDecimal(txttotalmadfou3.Text) > Convert.ToDecimal(txttotalorder.Text))
                {
                    MessageBox.Show("انت تقوم بدفع مبلغ اكبر من المبلغ المطلوب راجع بياناتك اولا من فضلك", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //الخزنه

               //check if the bill have the money of the total bill or not before save the order
                DataTable tblstoke = new DataTable();
                decimal stoke_money = 0;
                tblstoke.Clear();
                tblstoke = db.readdata("select*from stoke_money where stoke_id=" + stoke_id + "", "");
                //get the money of the selected stoke
                stoke_money = Convert.ToDecimal(tblstoke.Rows[0][1]);

                //validation of the money of stoke 
                if (Convert.ToDecimal(txttotalmadfou3.Text) > Convert.ToDecimal(stoke_money))

                {
                    MessageBox.Show("اجمالي الخزنه غير كافي لاجراء العمليه", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    // if the bill cash or agel
                    string billtype = "";
                    if (radioagel.Checked == true)
                    {
                        billtype = "اجل";
                    }
                    else if (radiocash.Checked == true)
                    {
                        billtype = "كاش";

                    }
                    //set formate date and time
                    string d = dtpdate.Value.ToString("yyyy-MM-dd");
                    string t = dtptime.Text;

                    if (txteznnumber.Text == "")
                    {
                        txteznnumber.Text = txtorderid.Text.ToString();
                    }
                    //كاش
                    //if order cash
                    if (radiocash.Checked == true)
                    {
                        if (Convert.ToDecimal(txttotalmadfou3.Text) < Convert.ToDecimal(txttotalorder.Text))
                        {
                            MessageBox.Show("انت مختار دفع الفاتوره كاش  والمبلغ المدفوع اقل من اجمالي الفاتوره  راجع بياناتك", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        //جدول ال buy
                        db.excutedata("insert into buy values(" + txtorderid.Text.Trim() + "," + txteznnumber.Text.Trim() + "," + cbxsupplier.SelectedValue + ",N'" + d + "',N'" + Properties.Settings.Default.user_name + "'," + numircprice.Value + "," + txttotalorder.Text + ",N'" + t + "',N'" + billtype + "',N'" + Properties.Settings.Default.branch_name + "',N'" + txtnotes.Text.Trim() + "'," + cbxmandoup.SelectedValue + ",N'" + cbxmandoup.Text + "'," + dgv.CurrentRow.Cells[10].Value + "," + lblitemscount.Text + ",N'" + dgv.CurrentRow.Cells[9].Value + "')", "");

                        decimal discount = 0;
                        //جدول ال buy_details
                        for (int i = 0; i <= dgv.Rows.Count - 1; i++)
                        {
                            db.excutedata("insert into buy_details values(" + txtorderid.Text.Trim() + "," + txteznnumber.Text + "," + cbxsupplier.SelectedValue + "," + dgv.Rows[i].Cells[0].Value + "," + dgv.Rows[i].Cells[3].Value + ",N'" + d + "',N'" + Properties.Settings.Default.user_name + "'," + dgv.Rows[i].Cells[4].Value + "," + dgv.Rows[i].Cells[5].Value + "," + numircprice.Value + "," + dgv.Rows[i].Cells[6].Value + "," + txttotalorder.Text + "," + Properties.Settings.Default.taxvalue + "," + dgv.Rows[i].Cells[4].Value + ",N'" + dtptime.Text + "',N'" + dgv.Rows[i].Cells[2].Value + "',N'" + billtype + "',N'" + Properties.Settings.Default.branch_name + "',N'" + dgv.Rows[i].Cells[7].Value + "',N'" + txtnotes.Text.Trim() + "'," + cbxmandoup.SelectedValue + ",N'" + cbxmandoup.Text.Trim() + "'," + dgv.Rows[i].Cells[8].Value + "," + dgv.Rows[i].Cells[10].Value + "," + lblitemscount.Text + ",N'" + dgv.Rows[i].Cells[9].Value + "',N'" + dgv.Rows[i].Cells[1].Value + "')", "");


                            //جدول الوحدات وسعر الوحدات
                            DataTable tblsmallunitupdateprice = new DataTable();
                            tblsmallunitupdateprice.Clear();
                            tblsmallunitupdateprice = db.readdata("select*from product_units where pro_id=" + dgv.Rows[i].Cells[0].Value + "", "");
                            //سعر الوحده
                            if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3]) > 1)
                            {
                                db.excutedata("update product_units set unitpricecost=" + dgv.Rows[i].Cells[4].Value + " where pro_id=" + tblsmallunitupdateprice.Rows[0][0] + "and Qtyinunit>1", "");
                                db.excutedata("update product_units set unitpricecost=" + Convert.ToDecimal(dgv.Rows[i].Cells[4].Value) * Convert.ToDecimal(tbl.Rows[0][25]) + " where pro_id=" + tblsmallunitupdateprice.Rows[0][0] + "and Qtyinunit==1", "");

                            }
                            if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3]) == 1)
                            {
                                tbl.Clear();
                                tbl = db.readdata("select*from products where product_id=" + dgv.Rows[i].Cells[0].Value + "", "");
                                db.excutedata("update product_units set unitpricecost=" + Convert.ToDecimal(dgv.Rows[i].Cells[4].Value) + " where pro_id=" + dgv.Rows[i].Cells[0].Value + " and Qtyinunit=1", "");
                                db.excutedata("update product_units set unitpricecost=" + Convert.ToDecimal(dgv.Rows[i].Cells[4].Value) / Convert.ToDecimal(tbl.Rows[0][25]) + " where pro_id=" + tblsmallunitupdateprice.Rows[0][0] + "and Qtyinunit>1", "");

                            }


                            //============================================================================
                            //============================================================================

                            //جدول الكميات products_qty

                            DataTable tblsmallqty = new DataTable();

                            tblsmallqty.Clear();
                            tblsmallqty = db.readdata("select*from products where product_id=" + dgv.Rows[i].Cells[0].Value + "", "");


                            decimal smallqty = Convert.ToDecimal(tblsmallqty.Rows[0][25]);
                            if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3]) > 1)
                            {
                                db.excutedata("update products_Qty set qty=qty+" + dgv.Rows[i].Cells[3].Value + " where pro_id=" + dgv.Rows[i].Cells[0].Value + "", "");
                            }
                            else if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3]) == 1)
                            {
                                db.excutedata("update products_Qty set qty=qty+" + Convert.ToDecimal(dgv.Rows[i].Cells[3].Value) * smallqty + " where pro_id=" + dgv.Rows[i].Cells[0].Value + "", "");

                            }
                            //=============================================================================


                            //Quantity of products
                            //=================================================================================
                            //=============================================================================
                            //==============================================================================
                            decimal realqty = 0;
                            if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3]) > 1)
                            {
                                realqty = Convert.ToDecimal(dgv.Rows[i].Cells[3].Value);
                            }
                            else if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3]) == 1)
                            {
                                realqty = Convert.ToDecimal(dgv.Rows[i].Cells[3].Value) * smallqty;
                            }

                            //update quanjtity of product in store
                            //=============================================================
                            //==============================================================
                            DataTable tblchecktable1 = new DataTable();
                            tblchecktable1.Clear();
                            tblchecktable1 = db.readdata("select*from products_Qtyinstore where pro_id=" + dgv.Rows[i].Cells[0].Value + " and store_id=" + dgv.Rows[i].Cells[10].Value + "", "");
                            if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3]) > 1)
                            {
                                //check if the unit big unit or small unit and update depending on real qty and real unit
                                if (tblchecktable1.Rows.Count >= 1)
                                {

                                    db.excutedata("update products_Qtyinstore set Qty=Qty+" + dgv.Rows[i].Cells[3].Value + " where pro_id=" + dgv.Rows[i].Cells[0].Value + " and store_id=" + dgv.Rows[i].Cells[10].Value + "", "");
                                }
                                else if (tblchecktable1.Rows.Count < 1)
                                {
                                    db.excutedata("insert into products_Qtyinstore values(" + dgv.Rows[i].Cells[0].Value + ",N'" + dgv.Rows[i].Cells[1].Value + "'," + dgv.Rows[i].Cells[3].Value + "," + dgv.Rows[i].Cells[10].Value + ",N'" + dgv.Rows[i].Cells[9].Value + "')", "");
                                }
                            }
                            else if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3]) == 1)
                            {
                                if (tblchecktable1.Rows.Count >= 1)
                                {
                                    db.excutedata("update products_Qtyinstore set Qty=Qty+" + realqty + " where pro_id=" + dgv.Rows[i].Cells[0].Value + " and store_id=" + dgv.Rows[i].Cells[10].Value + "", "");
                                }
                                else if (tblchecktable1.Rows.Count < 1)
                                {
                                    db.excutedata("insert into products_Qtyinstore values(" + dgv.Rows[i].Cells[0].Value + ",N'" + dgv.Rows[i].Cells[1].Value + "'," + realqty + "," + dgv.Rows[i].Cells[10].Value + ",N'" + dgv.Rows[i].Cells[9].Value + "')", "");

                                }

                            }
                            //===========================================================
                            //============================================================
                            string discription = "وارد من فاتوره مشتريات رقم" + Convert.ToString(txtorderid.Text) + " " + "-مورد" + " " + Convert.ToString(cbxsupplier.Text);

                            //insert description and data of bill in store to make item card ward monsarf and total quantiy
                            DataTable tblfinaltotalqtycash = new DataTable();
                            tblfinaltotalqtycash.Clear();
                            tblfinaltotalqtycash = db.readdata("select*from item_card where pro_id=" + dgv.Rows[i].Cells[0].Value + "", "");
                            decimal totalward = 0, totalmosarf = 0, balance = 0;
                            for (int q = 0; q <= tblfinaltotalqtycash.Rows.Count - 1; q++)
                            {
                                totalward += Convert.ToDecimal(tblfinaltotalqtycash.Rows[q][8]);
                                totalmosarf += Convert.ToDecimal(tblfinaltotalqtycash.Rows[q][9]);


                            }
                            if (tblfinaltotalqtycash.Rows.Count >= 1)
                            {
                                balance += (totalward + realqty) - totalmosarf;
                            }
                            else if (tblfinaltotalqtycash.Rows.Count < 1)
                            {
                                balance += realqty;
                            }
                            //item card
                            db.excutedata("insert into item_card values(" + dgv.Rows[i].Cells[0].Value + ",N'" + dgv.Rows[i].Cells[1].Value + "'," + dgv.Rows[i].Cells[10].Value + ",N'" + dgv.Rows[i].Cells[9].Value + "',N'" + d + "'," + realqty + ",N'" + dgv.Rows[i].Cells[2].Value + "',N'" + discription + "'," + realqty + ",0," + balance + ",N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + dgv.Rows[i].Cells[7].Value + "'," + txtorderid.Text + ",N'وارد')", "");

                            //===============================================================================================
                            
                            //suppliers accountحساب المورد
                            decimal totalmoney = 0, totalsadad = 0, balancemoney = 0;
                            DataTable tblsupplieraccount = new DataTable();
                            tblsupplieraccount.Clear();
                            tblsupplieraccount = db.readdata("select*from supplier_account where sup_id=" + cbxsupplier.SelectedValue + "", "");


                            for (int s = 0; s <= tblsupplieraccount.Rows.Count - 1; s++)
                            {
                                totalmoney += Convert.ToDecimal(tblsupplieraccount.Rows[s][6]);
                                totalsadad += Convert.ToDecimal(tblsupplieraccount.Rows[s][10]);
                            }
                            if (tblsupplieraccount.Rows.Count >= 1)
                            {


                                balancemoney += ((totalmoney + (Convert.ToDecimal(dgv.Rows[i].Cells[6].Value)) - totalsadad));
                            }
                            else if (tblsupplieraccount.Rows.Count < 1)
                            {
                                balancemoney += Convert.ToDecimal(dgv.Rows[i].Cells[6].Value);
                            }
                            db.excutedata("insert into supplier_account values(" + txtorderid.Text + "," + cbxsupplier.SelectedValue + ",N'" + cbxsupplier.Text + "',N'" + discription + "',N'" + dgv.Rows[i].Cells[1].Value + "'," + dgv.Rows[i].Cells[3].Value + "," + dgv.Rows[i].Cells[6].Value + "," + txttotalorder.Text + ",N'" + txtnotes.Text + "'," + Convert.ToDecimal(dgv.Rows[i].Cells[6].Value) + ",0," + balancemoney + ",N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + d + "',N'فاتوره',N'" + dgv.Rows[i].Cells[2].Value + "'," + txtorderid.Text + ")", "");

                            discount += Convert.ToDecimal(dgv.Rows[i].Cells[5].Value);
                        }
                        if (discount > 0 && Convert.ToDecimal(numircprice.Value) == 0)
                        {
                            discount += discount;
                        }
                        else if (discount == 0 && numircprice.Value != 0)
                        {
                            discount += Convert.ToDecimal(numircprice.Value);
                        }
                        //discount
                        //==================================الخصم
                        //================================================================================================================
                        decimal totalmoney3 = 0, totalsadad3 = 0, balancemoney3 = 0;
                        DataTable tblsupplieraccount3 = new DataTable();
                        tblsupplieraccount3.Clear();
                        tblsupplieraccount3 = db.readdata("select*from supplier_account where sup_id=" + cbxsupplier.SelectedValue + "", "");


                        for (int a = 0; a <= tblsupplieraccount3.Rows.Count - 1; a++)
                        {
                            totalmoney3 += Convert.ToDecimal(tblsupplieraccount3.Rows[a][6]);
                            totalsadad3 += Convert.ToDecimal(tblsupplieraccount3.Rows[a][10]);
                        }
                        if (tblsupplieraccount3.Rows.Count >= 1)
                        {


                            balancemoney3 += (totalmoney3 - ((Convert.ToDecimal(discount)) + totalsadad3));
                        }
                        else if (tblsupplieraccount3.Rows.Count < 1)
                        {
                            balancemoney3 += Convert.ToDecimal(discount);
                        }

                        if (numircprice.Value > 0)
                        {
                            decimal zero3 = 0;
                            string discription3 = "خصم من الفاتوره رقم " + Convert.ToString(txtorderid.Text) + " " + "-مورد" + " " + Convert.ToString(cbxsupplier.Text);
                            //insert data on supplier account to make supplier statement
                            db.excutedata("insert into supplier_account values(" + txtorderid.Text + "," + cbxsupplier.SelectedValue + ",N'" + cbxsupplier.Text + "',N'" + discription3 + "',N'خصم'," + zero3 + "," + zero3 + "," + discount + ",N'خصم'," + zero3 + "," + discount + "," + balancemoney3 + ",N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + d + "',N'خصم',N'-'," + txtorderid.Text + ")", "");
                        }



                        //================================================================================================================
                        //===================================السداد
                        //the money paid to supplier
                        decimal totalmoney2 = 0, totalsadad2 = 0, balancemoney2 = 0;
                        DataTable tblsupplieraccount2 = new DataTable();
                        tblsupplieraccount2.Clear();
                        tblsupplieraccount2 = db.readdata("select*from supplier_account where sup_id=" + cbxsupplier.SelectedValue + "", "");


                        for (int f = 0; f <= tblsupplieraccount2.Rows.Count - 1; f++)
                        {
                            totalmoney2 += Convert.ToDecimal(tblsupplieraccount2.Rows[f][6]);
                            totalsadad2 += Convert.ToDecimal(tblsupplieraccount2.Rows[f][10]);
                        }
                        if (tblsupplieraccount2.Rows.Count >= 1)
                        {


                            balancemoney2 += (totalmoney2 - ((Convert.ToDecimal(txttotalmadfou3.Text)) + totalsadad2));
                        }
                        else if (tblsupplieraccount2.Rows.Count < 1)
                        {
                            balancemoney2 += Convert.ToDecimal(txttotalmadfou3.Text);
                        }


                        decimal zero = 0;
                        string discription2 = "سداد نقدي لفاتوره مشتريات كاش فاتوره رقم" + Convert.ToString(txtorderid.Text) + " " + "-مورد" + " " + Convert.ToString(cbxsupplier.Text);
                        db.excutedata("insert into supplier_account values(" + txtorderid.Text + "," + cbxsupplier.SelectedValue + ",N'" + cbxsupplier.Text + "',N'" + discription2 + "',N'سداد نقدي'," + zero + "," + zero + "," + txttotalmadfou3.Text + ",N'سداد نقدي'," + zero + "," + txttotalmadfou3.Text + "," + balancemoney2 + ",N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + d + "',N'سداد',N'-'," + txtorderid.Text + ")", "");
                        string order_id = "فاتوره رقم" + " " + Convert.ToString(txtorderid.Text);
                        //سحب الفلوس في الخزنه
                        db.excutedata("insert into stoke_withdrowal(stoke_id,money,date,name,type,notes,user_name,branch_name,order_id2) values(" + stoke_id + "," + txttotalmadfou3.Text.Trim() + ",N'" + d + "',N'" + order_id + "',N' عمليه شراءمن '+N' '+N'" + cbxsupplier.Text + "',N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "'," + txtorderid.Text + ")", "");
                        db.excutedata("update stoke_money set money=money-" + txttotalmadfou3.Text.Trim() + " where stoke_id=" + stoke_id + "", "");

                    }

                    //================================================================================================================================================================
                    //================================================================================================================================================================

                    //////////////////////////////////////////////اجل
                    if (radioagel.Checked == true)
                    {
                        if (Convert.ToDecimal(txttotalmadfou3.Text) > Convert.ToDecimal(txttotalorder.Text))
                        {
                            MessageBox.Show("انت مختار دفع الفاتوره اجل والمبلغ المدفوع اكبر  من اجمالي الفاتوره  راجع بياناتك", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else if (Convert.ToDecimal(txttotalmadfou3.Text) == Convert.ToDecimal(txttotalorder.Text))
                        {
                            MessageBox.Show("انت مختار دفع الفاتوره اجل والمبلغ المدفوع يساوي  اجمالي الفاتوره  راجع بياناتك", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        //جدول ال buy
                        db.excutedata("insert into buy values(" + txtorderid.Text.Trim() + "," + txteznnumber.Text.Trim() + "," + cbxsupplier.SelectedValue + ",N'" + d + "',N'" + Properties.Settings.Default.user_name + "'," + numircprice.Value + "," + txttotalorder.Text + ",N'" + t + "',N'" + billtype + "',N'" + Properties.Settings.Default.branch_name + "',N'" + txtnotes.Text.Trim() + "'," + cbxmandoup.SelectedValue + ",N'" + cbxmandoup.Text + "'," + dgv.CurrentRow.Cells[10].Value + "," + lblitemscount.Text + ",N'" + dgv.CurrentRow.Cells[9].Value + "')", "");
                        decimal discount2 = 0;
                        //جدول ال buy_details
                        for (int i = 0; i <= dgv.Rows.Count - 1; i++)
                        {
                            discount2 += Convert.ToDecimal(dgv.Rows[i].Cells[5].Value);
                            //insert into buy details
                            db.excutedata("insert into buy_details values(" + txtorderid.Text.Trim() + "," + txteznnumber.Text + "," + cbxsupplier.SelectedValue + "," + dgv.Rows[i].Cells[0].Value + "," + dgv.Rows[i].Cells[3].Value + ",N'" + d + "',N'" + Properties.Settings.Default.user_name + "'," + dgv.Rows[i].Cells[4].Value + "," + dgv.Rows[i].Cells[5].Value + "," + numircprice.Value + "," + dgv.Rows[i].Cells[6].Value + "," + txttotalorder.Text + "," + Properties.Settings.Default.taxvalue + "," + dgv.Rows[i].Cells[4].Value + ",N'" + dtptime.Text + "',N'" + dgv.Rows[i].Cells[2].Value + "',N'" + billtype + "',N'" + Properties.Settings.Default.branch_name + "',N'" + dgv.Rows[i].Cells[7].Value + "',N'" + txtnotes.Text.Trim() + "'," + cbxmandoup.SelectedValue + ",N'" + cbxmandoup.Text.Trim() + "'," + dgv.Rows[i].Cells[8].Value + "," + dgv.Rows[i].Cells[10].Value + "," + lblitemscount.Text + ",N'" + dgv.Rows[i].Cells[9].Value + "',N'" + dgv.Rows[i].Cells[1].Value + "')", "");

                            //جدول الوحدات وسعر الوحدات

                            DataTable tblsmallunitupdateprice = new DataTable();
                            tblsmallunitupdateprice.Clear();
                            tblsmallunitupdateprice = db.readdata("select*from product_units where pro_id=" + dgv.Rows[i].Cells[0].Value + "", "");

                            if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3]) > 1)
                            {
                                //update units
                                db.excutedata("update product_units set unitpricecost=" + dgv.Rows[i].Cells[4].Value + " where pro_id=" + tblsmallunitupdateprice.Rows[0][0] + "and Qtyinunit>1", "");
                                db.excutedata("update product_units set unitpricecost=" + Convert.ToDecimal(dgv.Rows[i].Cells[4].Value)* Convert.ToDecimal(tbl.Rows[0][25]) + " where pro_id=" + tblsmallunitupdateprice.Rows[0][0] + "and Qtyinunit==1", "");

                            }
                            if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3])== 1)
                            {
                                tbl.Clear();
                                tbl = db.readdata("select*from products where product_id=" + dgv.Rows[i].Cells[0].Value + "", "");
                                db.excutedata("update product_units set unitpricecost=" + Convert.ToDecimal(dgv.Rows[i].Cells[4].Value) + " where pro_id=" + dgv.Rows[i].Cells[0].Value + " and Qtyinunit=1", "");
                                db.excutedata("update product_units set unitpricecost=" + Convert.ToDecimal(dgv.Rows[i].Cells[4].Value) / Convert.ToDecimal(tbl.Rows[0][25]) + " where pro_id=" + tblsmallunitupdateprice.Rows[0][0] + "and Qtyinunit>1", "");

                            }


                            //============================================================================

                            //جدول الكميات products_qty

                            DataTable tblsmallqtyagel = new DataTable();

                            tblsmallqtyagel.Clear();
                            tblsmallqtyagel = db.readdata("select*from products where product_id=" + dgv.Rows[i].Cells[0].Value + "", "");


                            decimal smallqtyagel = Convert.ToDecimal(tblsmallqtyagel.Rows[0][25]);

                            if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3]) > 1)
                            {
                                db.excutedata("update products_Qty set qty=qty+" + dgv.Rows[i].Cells[3].Value + " where pro_id=" + dgv.Rows[i].Cells[0].Value + "", "");
                            }
                            else if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3]) == 1)
                            {
                                db.excutedata("update products_Qty set qty=qty+" + Convert.ToDecimal(dgv.Rows[i].Cells[3].Value) * smallqtyagel + " where pro_id=" + dgv.Rows[i].Cells[0].Value + "", "");

                            }

                            //=======================================جدول الكميات بتاع المخازن
                            decimal realqty2 = 0;
                            if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3]) > 1)
                            {
                                realqty2 = Convert.ToDecimal(dgv.Rows[i].Cells[3].Value);
                            }
                            else if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3]) == 1)
                            {
                                realqty2 = Convert.ToDecimal(dgv.Rows[i].Cells[3].Value) * smallqtyagel;
                            }

                            DataTable tblchecktable = new DataTable();
                            tblchecktable.Clear();
                            tblchecktable = db.readdata("select*from products_Qtyinstore where pro_id=" + dgv.Rows[i].Cells[0].Value + " and store_id=" + dgv.Rows[i].Cells[10].Value + "", "");
                            if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3]) > 1)
                            {
                                if (tblchecktable.Rows.Count >= 1)
                                {

                                    db.excutedata("update products_Qtyinstore set Qty=Qty+" + realqty2 + " where pro_id=" + dgv.Rows[i].Cells[0].Value + " and store_id=" + dgv.Rows[i].Cells[10].Value + "", "");
                                }
                                else if (tblchecktable.Rows.Count < 1)
                                {
                                    db.excutedata("insert into products_Qtyinstore values(" + dgv.Rows[i].Cells[0].Value + ",N'" + dgv.Rows[i].Cells[1].Value + "'," + realqty2 + "," + dgv.Rows[i].Cells[10].Value + ",N'" + dgv.Rows[i].Cells[9].Value + "')", "");
                                }
                            }
                            else if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3]) == 1)
                            {
                                if (tblchecktable.Rows.Count >= 1)
                                {
                                    db.excutedata("update products_Qtyinstore set Qty=Qty+" + realqty2 + " where pro_id=" + dgv.Rows[i].Cells[0].Value + " and store_id=" + dgv.Rows[i].Cells[10].Value + "", "");
                                }
                                else if (tblchecktable.Rows.Count < 1)
                                {
                                    db.excutedata("insert into products_Qtyinstore values(" + dgv.Rows[i].Cells[0].Value + ",N'" + dgv.Rows[i].Cells[1].Value + "'," + realqty2 + "," + dgv.Rows[i].Cells[10].Value + ",N'" + dgv.Rows[i].Cells[9].Value + "')", "");

                                }
                            }
                            //=============================================================================
                            //==============================================================================
                            decimal realqty = 0;
                            if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3]) > 1)
                            {
                                realqty = Convert.ToDecimal(dgv.Rows[i].Cells[3].Value);
                            }
                            else if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3]) == 1)
                            {
                                realqty = Convert.ToDecimal(dgv.Rows[i].Cells[3].Value) * smallqtyagel;
                            }
                            string discription = "وارد من فاتوره مشتريات رقم" + Convert.ToString(txtorderid.Text) + " " + "-مورد" + " " + Convert.ToString(cbxsupplier.Text);


                            DataTable tblfinaltotalqty = new DataTable();
                            tblfinaltotalqty.Clear();
                            tblfinaltotalqty = db.readdata("select*from item_card where pro_id=" + dgv.Rows[i].Cells[0].Value + "", "");
                            decimal totalward = 0, totalmosarf = 0, balance = 0;
                            for (int q = 0; q <= tblfinaltotalqty.Rows.Count - 1; q++)
                            {
                                totalward += Convert.ToDecimal(tblfinaltotalqty.Rows[q][8]);
                                totalmosarf += Convert.ToDecimal(tblfinaltotalqty.Rows[q][9]);


                            }
                            if (tblfinaltotalqty.Rows.Count >= 1)
                            {
                                balance += (totalward + realqty) - totalmosarf;
                            }
                            else if (tblfinaltotalqty.Rows.Count < 1)
                            {
                                balance += realqty;
                            }
                            //insert data on item card
                            db.excutedata("insert into item_card values(" + dgv.Rows[i].Cells[0].Value + ",N'" + dgv.Rows[i].Cells[1].Value + "'," + dgv.Rows[i].Cells[10].Value + ",N'" + dgv.Rows[i].Cells[9].Value + "',N'" + d + "'," + realqty + ",N'" + dgv.Rows[i].Cells[2].Value + "',N'" + discription + "'," + realqty + ",0," + balance + ",N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + dgv.Rows[i].Cells[7].Value + "'," + txtorderid.Text + ",N'وارد')", "");
                            //===================================================================================================
                            //=================================================================================================
                            //حساب المورد suppliers
                            decimal totalmoney = 0, totalsadad = 0, balancemoney = 0;
                            DataTable tblsupplieraccount = new DataTable();
                            tblsupplieraccount.Clear();
                            tblsupplieraccount = db.readdata("select*from supplier_account where sup_id=" + cbxsupplier.SelectedValue + "", "");


                            for (int s = 0; s <= tblsupplieraccount.Rows.Count - 1; s++)
                            {
                                totalmoney += Convert.ToDecimal(tblsupplieraccount.Rows[s][6]);
                                totalsadad += Convert.ToDecimal(tblsupplieraccount.Rows[s][10]);
                            }
                            if (tblsupplieraccount.Rows.Count >= 1)
                            {


                                balancemoney += ((totalmoney + (Convert.ToDecimal(dgv.Rows[i].Cells[6].Value)) - totalsadad));
                            }
                            else if (tblsupplieraccount.Rows.Count < 1)
                            {
                                balancemoney += Convert.ToDecimal(dgv.Rows[i].Cells[6].Value);
                            }

                            db.excutedata("insert into supplier_account values(" + txtorderid.Text + "," + cbxsupplier.SelectedValue + ",N'" + cbxsupplier.Text + "',N'" + discription + "',N'" + dgv.Rows[i].Cells[1].Value + "'," + dgv.Rows[i].Cells[3].Value + "," + dgv.Rows[i].Cells[6].Value + "," + txttotalorder.Text + ",N'" + txtnotes.Text + "'," + Convert.ToDecimal(dgv.Rows[i].Cells[6].Value) + ",0," + balancemoney + ",N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + d + "',N'فاتوره',N'" + dgv.Rows[i].Cells[2].Value + "'," + txtorderid.Text + ")", "");

                            discount2 += Convert.ToDecimal(dgv.Rows[i].Cells[5].Value);

                        }


                        if (discount2 == 0 && numircprice.Value > 0)
                        {
                            discount2 += Convert.ToDecimal(numircprice.Value);
                        }
                        //==================================الخصم
                        //================================================================================================================
                        decimal totalmoney3 = 0, totalsadad3 = 0, balancemoney3 = 0;
                        DataTable tblsupplieraccount3 = new DataTable();
                        tblsupplieraccount3.Clear();
                        tblsupplieraccount3 = db.readdata("select*from supplier_account where sup_id=" + cbxsupplier.SelectedValue + "", "");


                        for (int a = 0; a <= tblsupplieraccount3.Rows.Count - 1; a++)
                        {
                            totalmoney3 += Convert.ToDecimal(tblsupplieraccount3.Rows[a][6]);
                            totalsadad3 += Convert.ToDecimal(tblsupplieraccount3.Rows[a][10]);
                        }
                        if (tblsupplieraccount3.Rows.Count >= 1)
                        {


                            balancemoney3 += (totalmoney3 - ((Convert.ToDecimal(discount2)) + totalsadad3));
                        }
                        else if (tblsupplieraccount3.Rows.Count < 1)
                        {
                            balancemoney3 += Convert.ToDecimal(discount2);
                        }
                        decimal zero3 = 0;
                        string discription3 = "خصم من الفاتوره رقم " + Convert.ToString(txtorderid.Text) + " " + "-مورد" + " " + Convert.ToString(cbxsupplier.Text);

                        //if pay money for supplier
                        if (numircprice.Value > 0)
                        {
                            //insert money in supplier account
                            db.excutedata("insert into supplier_account values(" + txtorderid.Text + "," + cbxsupplier.SelectedValue + ",N'" + cbxsupplier.Text + "',N'" + discription3 + "',N'خصم'," + zero3 + "," + zero3 + "," + discount2 + ",N'خصم'," + zero3 + "," + discount2 + "," + balancemoney3 + ",N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + d + "',N'خصم',N'-'," + txtorderid.Text + ")", "");
                        }



                        //================================================================================================================
                        //سداد

                        decimal totalmoney4 = 0, totalsadad4 = 0, balancemoney4 = 0;
                        DataTable tblsupplieraccount4 = new DataTable();
                        tblsupplieraccount4.Clear();
                        tblsupplieraccount4 = db.readdata("select*from supplier_account where sup_id=" + cbxsupplier.SelectedValue + "", "");


                        for (int f = 0; f <= tblsupplieraccount4.Rows.Count - 1; f++)
                        {
                            totalmoney4 += Convert.ToDecimal(tblsupplieraccount4.Rows[f][6]);
                            totalsadad4 += Convert.ToDecimal(tblsupplieraccount4.Rows[f][10]);
                        }
                        if (tblsupplieraccount4.Rows.Count >= 1)
                        {


                            balancemoney4 += (totalmoney4 - ((Convert.ToDecimal(txttotalmadfou3.Text)) + totalsadad4));
                        }
                        else if (tblsupplieraccount4.Rows.Count < 1)
                        {
                            balancemoney4 += Convert.ToDecimal(txttotalmadfou3.Text);
                        }

                        if (Convert.ToDecimal(txttotalmadfou3.Text) > 0)
                        {
                            string discription4 = "سداد مع الفاتوره رقم " + Convert.ToString(txtorderid.Text) + " " + "-مورد" + " " + Convert.ToString(cbxsupplier.Text);

                            db.excutedata("insert into supplier_account values(" + txtorderid.Text + "," + cbxsupplier.SelectedValue + ",N'" + cbxsupplier.Text + "',N'" + discription4 + "',N'سداد'," + zero3 + "," + zero3 + "," + txttotalmadfou3.Text + ",N'سداد'," + zero3 + "," + txttotalmadfou3.Text + "," + balancemoney4 + ",N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + d + "',N'سداد',N'-'," + txtorderid.Text + ")", "");

                        }
                        string order_id = "فاتوره رقم" + " " + Convert.ToString(txtorderid.Text);
                        //سحب الفلوس في الخزنه
                        if (Convert.ToDecimal(txttotalmadfou3.Text) > 0)
                        {
                            db.excutedata("insert into stoke_withdrowal(stoke_id,money,date,name,type,notes,user_name,branch_name,order_id2) values(" + stoke_id + "," + txttotalmadfou3.Text.Trim() + ",N'" + d + "',N'" + order_id + "',N' عمليه شراءمن '+N' '+N'" + cbxsupplier.Text + "',N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "'," + txtorderid.Text + ")", "");
                            db.excutedata("update stoke_money set money=money-" + txttotalmadfou3.Text.Trim() + " where stoke_id=" + stoke_id + "", "");
                        }
                        //================================================================================================================================================================
                        //================================================================================================================================================================


                    }

                    //insert data in buy details
                    db.excutedata("insert into buy_details_money values("+txtorderid.Text+","+txttotalmadfou3.Text+",N'"+Properties.Settings.Default.branch_name+"')", "");
                        
                    
                    MessageBox.Show("تم حفظ البيانات بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    //check the data of printer and printing
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
                        {
                        }
                        if (data <= 0)
                        {
                            MessageBox.Show("من فضلك ادخل بيانات الفاتوره اولا في شاشه اعدادات البرنامج", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                       
                        //printing
                            print();
                       //get new bill
                        autonumber();
                }
            }
        }

        private void radiocash_CheckedChanged(object sender, EventArgs e)
        {
            //change if radio cash set the total of the order automatic
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

        private void txttotalorder_TextChanged(object sender, EventArgs e)
        {
            if (radiocash.Checked == true)
            {
                txttotalmadfou3.Text = txttotalorder.Text.ToString();
            }
            else if (radioagel.Checked == true)
            {
                txttotalmadfou3.Text = "0.0";
            }
        }

        private void txttotalbakey_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttotalmadfou3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //get the baky of the order
                decimal bakey = 0;
                bakey = Convert.ToDecimal(txttotalorder.Text) - Convert.ToDecimal(txttotalmadfou3.Text);
                txttotalbakey.Text = bakey.ToString();


            }
            catch (Exception) { }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            panelupdate.Visible = false;
            tileItem1.Enabled = true;
            autonumber();
        }

        private void tileItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            tileItem1.Enabled = false;
            panelupdate.Visible = true;
            
            simpleButton4.Enabled = false;
            btnupdate.Enabled = true;
        }

        //update the bill
        private void txtbillid_KeyPress(object sender, KeyPressEventArgs e)
        {
            int row20 = 0;
            //validation of the bill and show bill data when set the order id
            if (e.KeyChar == 13)
            {
                if (txtbillid.Text == "")
                {
                    MessageBox.Show("من فضلك ادخل رقم الفاتوره التي تريد تعديلها ثم قم بالضغط علي زر انتر", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else
                {
                    //get the data of bill selected
                    DataTable tblbuy = new DataTable();
                    tblbuy.Clear();
                    tblbuy = db.readdata("select*from buy_details where order_id=" + txtbillid.Text.Trim() + " and branch_name=N'" + Properties.Settings.Default.branch_name + "'", "");

                    if (tblbuy.Rows.Count >= 1)
                    {


                        if (Convert.ToString(tblbuy.Rows[0][16]) == "اجل")

                        {
                            radioagel.Checked = true;
                        }
                        else if (Convert.ToString(tblbuy.Rows[0][16]) == "كاش")
                        {
                            radiocash.Checked = true;
                        }
                        //show data in the tools of the form
                        txtorderid.Text = tblbuy.Rows[row20][0].ToString();
                        txteznnumber.Text = tblbuy.Rows[row20][1].ToString();
                        numircprice.Value = Convert.ToDecimal(tblbuy.Rows[row20][9]);
                        lblsup_id.Text = tblbuy.Rows[row20][2].ToString();
                        lbltotalselectedbill.Text = tblbuy.Rows[row20][11].ToString();

                        decimal totalafterdiscount = 0;
                        decimal total = 0;
                        for (int i = 0; i <= dgv.Rows.Count - 1; i++)
                        {
                            total += Convert.ToDecimal(dgv.Rows[i].Cells[6].Value);

                        }
                        totalafterdiscount += total - Convert.ToDecimal(numircprice.Text);

                        //============================================================
                        txttotalorder.Text = totalafterdiscount.ToString();

                        decimal totaloldbill = Convert.ToDecimal(tblbuy.Rows[row20][11]) - Convert.ToDecimal(tblbuy.Rows[row20][9]);


                        DataTable tbltotalbeforebill = new DataTable();
                        tbltotalbeforebill.Clear();
                        tbltotalbeforebill = db.readdata("select*from supplier_account where order_id<" + txtorderid.Text + " and sup_id=" + lblsup_id.Text + "", "");

                        decimal totalmoney = 0, totalsadad = 0, final = 0;
                        for (int a = 0; a <= tbltotalbeforebill.Rows.Count - 1; a++)
                        {
                            totalmoney += Convert.ToDecimal(tbltotalbeforebill.Rows[a][9]);
                            totalsadad += Convert.ToDecimal(tbltotalbeforebill.Rows[a][10]);

                        }
                        final += totalmoney - totalsadad;
                        lbltotalbeforeupdate.Text = final.ToString();
                        //=========================================================================

                        //show data in the datagridview 
                        dgv.Rows.Clear();
                        if (tblbuy.Rows.Count > 0)
                        {
                            foreach (DataRow row in tblbuy.Rows)
                            {
                                dgv.Rows.Add(1);

                                int rowindex = dgv.Rows.Count - 1;

                                dgv.Rows[rowindex].Cells[0].Value = row[3];
                                dgv.Rows[rowindex].Cells[1].Value = row[26];
                                dgv.Rows[rowindex].Cells[2].Value = row[15];
                                dgv.Rows[rowindex].Cells[3].Value = row[4];
                                dgv.Rows[rowindex].Cells[4].Value = row[13];
                                dgv.Rows[rowindex].Cells[5].Value = row[8];
                                dgv.Rows[rowindex].Cells[6].Value = row[10];
                                dgv.Rows[rowindex].Cells[7].Value = row[18];
                                dgv.Rows[rowindex].Cells[8].Value = row[22];
                                dgv.Rows[rowindex].Cells[9].Value = row[25];
                                dgv.Rows[rowindex].Cells[10].Value = row[23];
                                dgv.Rows[rowindex].Cells[11].Value = row[17];
                                dgv.Rows[rowindex].Cells[12].Value = row[4];


                            }
                            lblitemscount.Text = Convert.ToString(dgv.Rows.Count);
                            decimal bakey = 0, totalorder = 0;


                            totalorder += Convert.ToDecimal(txttotalorder.Text) - Convert.ToDecimal(numircprice.Value);
                            txttotalorder.Text = totalorder.ToString();

                            bakey = Convert.ToDecimal(txttotalorder.Text) - Convert.ToDecimal(txttotalmadfou3.Text);
                            txttotalbakey.Text = bakey.ToString();

                        }
                        try
                        {

                        }
                        catch (Exception) { }
                    }
                    else
                    {
                        MessageBox.Show("لايوجد فاتوره بهذا الرقم", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }


            }

        }

        //button update bill
        private void btnupdate_Click(object sender, EventArgs e)
        {
            //validation to update bill
            if (cbxsupplier.Text == "")
            {
                MessageBox.Show("من فضلك اختر مورد اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                //delete data of bill from buy , buy details , item card ,buy details money tables , supplier acount
                if (MessageBox.Show("هل انت متاكد من تعديل الفاتوره", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    db.excutedata("delete from buy where order_id=" + txtorderid.Text + " and branch_name=N'" + Properties.Settings.Default.branch_name + "'", "");
                    db.excutedata("delete from buy_details where order_id=" + txtorderid.Text + " and branch_name=N'" + Properties.Settings.Default.branch_name + "'", "");
                    db.excutedata("delete from item_card where order_id=" + txtorderid.Text + " and branch_name=N'" + Properties.Settings.Default.branch_name + "' and type=N'وارد'", "");
                    db.excutedata("delete from buy_details_money where order_id=" + txtorderid.Text + " and branch_name=N'" + Properties.Settings.Default.branch_name + "'", "");
                    db.excutedata("delete from supplier_account where order_id=" + txtorderid.Text + " and branch_name=N'" + Properties.Settings.Default.branch_name + "'", "");

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
                    string discriptionupdate = "وارد فاتوره مشتريات من المورد" + " " + cbxsupplier.Text +" "+ "فاتوره رقم" + txtorderid.Text;

                    //insert into buy , buy details
                    //جدول ال buy
                    db.excutedata("insert into buy values(" + txtorderid.Text.Trim() + "," + txteznnumber.Text.Trim() + "," + cbxsupplier.SelectedValue + ",N'" + d + "',N'" + Properties.Settings.Default.user_name + "'," + numircprice.Value + "," + txttotalorder.Text + ",N'" + t + "',N'" + billtype + "',N'" + Properties.Settings.Default.branch_name + "',N'" + txtnotes.Text.Trim() + "'," + cbxmandoup.SelectedValue + ",N'" + cbxmandoup.Text + "'," + dgv.CurrentRow.Cells[10].Value + "," + lblitemscount.Text + ",N'" + dgv.CurrentRow.Cells[9].Value + "')", "");
                    db.excutedata("insert into buy_details_money values("+txtorderid.Text+","+txttotalmadfou3.Text+",N'"+Properties.Settings.Default.branch_name+"')", "");

                    //get the total order of the bill after update in the form
                    for (int i = 0; i <= dgv.Rows.Count - 1; i++)
                    {
                        decimal totalmoney55 = 0, sadad = 0, balance55 = 0;

                        DataTable tbloldmoney = new DataTable();
                        tbloldmoney.Clear();
                        tbloldmoney = db.readdata("select*from supplier_account where sup_id=" + lblsup_id.Text + " and order_id<=" + txtorderid.Text + "", "");
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

                        //insert into buy_details
                        db.excutedata("insert into buy_details values(" + txtorderid.Text.Trim() + "," + txteznnumber.Text + "," + cbxsupplier.SelectedValue + "," + dgv.Rows[i].Cells[0].Value + "," + dgv.Rows[i].Cells[3].Value + ",N'" + d + "',N'" + Properties.Settings.Default.user_name + "'," + dgv.Rows[i].Cells[4].Value + "," + dgv.Rows[i].Cells[5].Value + "," + numircprice.Value + "," + dgv.Rows[i].Cells[6].Value + "," + txttotalorder.Text + "," + Properties.Settings.Default.taxvalue + "," + dgv.Rows[i].Cells[4].Value + ",N'" + dtptime.Text + "',N'" + dgv.Rows[i].Cells[2].Value + "',N'" + billtype + "',N'" + Properties.Settings.Default.branch_name + "',N'" + dgv.Rows[i].Cells[7].Value + "',N'" + txtnotes.Text.Trim() + "'," + cbxmandoup.SelectedValue + ",N'" + cbxmandoup.Text.Trim() + "'," + dgv.Rows[i].Cells[8].Value + "," + dgv.Rows[i].Cells[10].Value + "," + lblitemscount.Text + ",N'" + dgv.Rows[i].Cells[9].Value + "',N'" + dgv.Rows[i].Cells[1].Value + "')", "");

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
                            balance += (totalward + realqty) - totalmosarf;
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

                        db.excutedata("insert into item_card values(" + dgv.Rows[i].Cells[0].Value + ",N'" + dgv.Rows[i].Cells[1].Value + "'," + dgv.Rows[i].Cells[10].Value + ",N'" + dgv.Rows[i].Cells[9].Value + "',N'" + d + "'," + realqty + ",N'" + dgv.Rows[i].Cells[2].Value + "',N'" + discriptionupdate + "'," + realqty + ",0," + balance + ",N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + dgv.Rows[i].Cells[7].Value + "'," + txtorderid.Text + ",N'وارد')", "");

                        //----------------------------
                        decimal realqty2 = 0;
                        if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3]) > 1)
                        {
                            realqty2 = Convert.ToDecimal(dgv.Rows[i].Cells[12].Value);
                        }
                        else if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3]) == 1)
                        {
                            realqty2 = Convert.ToDecimal(dgv.Rows[i].Cells[12].Value) * smallqty;
                        }
                        db.excutedata("update products_Qty set Qty=Qty-" + realqty2 + " where pro_id=" + dgv.Rows[i].Cells[0].Value + " ", "");

                        DataTable tblchecktable = new DataTable();
                        tblchecktable.Clear();
                        tblchecktable = db.readdata("select*from products_Qtyinstore where pro_id=" + dgv.Rows[i].Cells[0].Value + " and store_id=" + dgv.Rows[i].Cells[10].Value + "", "");
                        if (tblchecktable.Rows.Count >= 1)
                        {
                            db.excutedata("update products_Qtyinstore set Qty=Qty-" + realqty2 + " where pro_id=" + dgv.Rows[i].Cells[0].Value + " and store_id=" + dgv.Rows[i].Cells[10].Value + "", "");

                        }
                        else if (tblchecktable.Rows.Count < 1)
                        {
                            db.excutedata("isert into products_Qtyinstore values (" + dgv.Rows[i].Cells[0].Value + ",N'" + dgv.Rows[i].Cells[1].Value + "'," + realqty2 + "," + dgv.Rows[i].Cells[10].Value + ",N'" + dgv.Rows[i].Cells[9].Value + "')", "");
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

                        db.excutedata("update products_Qty set Qty=Qty+" + newrealqty + " where pro_id=" + dgv.Rows[i].Cells[0].Value + " ", "");

                        //=========================================================
                        if (tblchecktable.Rows.Count >= 1)
                        {
                            db.excutedata("update products_Qtyinstore set Qty=Qty+" + newrealqty + " where pro_id=" + dgv.Rows[i].Cells[0].Value + " and store_id=" + dgv.Rows[i].Cells[10].Value + "", "");

                        }
                        else if (tblchecktable.Rows.Count < 1)
                        {
                            db.excutedata("insert into products_Qtyinstore values (" + dgv.Rows[i].Cells[0].Value + ",N'" + dgv.Rows[i].Cells[1].Value + "'," + newrealqty + "," + dgv.Rows[i].Cells[10].Value + ",N'" + dgv.Rows[i].Cells[9].Value + "')", "");
                        }
                        //===============================================================================================================================================
                        //=====================================================================================================================================================================
                        //insert into supplier_account
                        db.excutedata("insert into supplier_account values(" + txtorderid.Text + "," + cbxsupplier.SelectedValue + ",N'" + cbxsupplier.Text + "',N'" + discriptionupdate + "',N'" + dgv.Rows[i].Cells[1].Value + "'," + dgv.Rows[i].Cells[3].Value + "," + dgv.Rows[i].Cells[6].Value + "," + txttotalorder.Text + ",N'" + txtnotes.Text + "'," + Convert.ToDecimal(dgv.Rows[i].Cells[6].Value) + ",0," + balance55 + ",N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + d + "',N'فاتوره',N'" + dgv.Rows[i].Cells[2].Value + "'," + txtorderid.Text + ")", "");
                    }
                    //خصم
                    if (numircprice.Value != 0)
                    {
                        db.excutedata("insert into supplier_account values(" + txtorderid.Text + "," + cbxsupplier.SelectedValue + ",N'" + cbxsupplier.Text + "',N'خصم',N'-',0," + numircprice.Value + "," + numircprice.Value + ",N'" + txtnotes.Text + "',0," + numircprice.Value + ",0,N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + d + "',N'فاتوره',N'-'," + txtorderid.Text + ")", "");

                    }
                    decimal sadadtotal = 0;
                    DataTable tblupdatebalanceafterbill = new DataTable();
                    tblupdatebalanceafterbill.Clear();
                    tblupdatebalanceafterbill = db.readdata("select*from supplier_account where order_id>" + txtorderid.Text + " and sup_id=" + lblsup_id.Text + " ", "");
                    for (int u = 0; u <= tblupdatebalanceafterbill.Rows.Count - 1; u++)
                    {
                        sadadtotal += Convert.ToDecimal(tblupdatebalanceafterbill.Rows[u][10]);
                    }

                    decimal diffrent = 0;

                    diffrent += (Convert.ToDecimal(txttotalorder.Text) - Convert.ToDecimal(lbltotalselectedbill.Text));
                    DataTable tblupdate = new DataTable();
                    tblupdate.Clear();
                    tblupdate = db.readdata("select*from supplier_account where order_id>" + txtorderid.Text + " and sup_id=" + lblsup_id.Text + "", "");
                   

                    db.excutedata("update supplier_account set balance=balance+" + diffrent + "  where order_id>" + txtorderid.Text + " and sup_id=" + lblsup_id.Text + " and type=N'فاتوره'", "");
                   
                    //سداد
                    if (Convert.ToDecimal(txttotalmadfou3.Text) > 0)
                    {


                        string descriptionsadad = "[سداد] من فاتوره مشتريات للمورد]" + " " + cbxsupplier.Text + " " + "فاتوره رقم" + txtorderid.Text;
                        db.excutedata("insert into supplier_account values(" + txtorderid.Text + "," + cbxsupplier.SelectedValue + ",N'" + cbxsupplier.Text + "',N'" + descriptionsadad + "',N'-',0," + txttotalmadfou3.Text + "," + txttotalmadfou3.Text + ",N'" + txtnotes.Text + "',0," + txttotalmadfou3.Text + ",0,N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + d + "',N'سداد فاتوره',N'-'," + txtorderid.Text + ")", "");
                    }
                    //================================================================================================
                    //الخزنه
                    DataTable tblupdatestoke = new DataTable();
                    tblupdatestoke.Clear();
                    tblupdatestoke = db.readdata("select*from stoke_withdrowal where order_id2=" + txtorderid.Text + " and branch_name=N'" + Properties.Settings.Default.branch_name + "'", "");
                    decimal oldmoney = 0;
                    if (tblupdatestoke.Rows.Count >= 1)
                    {
                        oldmoney = Convert.ToDecimal(tblupdatestoke.Rows[0][2]);
                    }
                    else if (tblupdatestoke.Rows.Count < 1)
                    {
                        oldmoney = 0;
                    }
                    if (tblupdatestoke.Rows.Count >= 1)
                    {
                        //update data in stoke withdrowal
                        db.excutedata("update stoke_withdrowal set money=" + txttotalmadfou3.Text + " where order_id2=" + txtorderid.Text + " and branch_name=N'" + Properties.Settings.Default.branch_name + "'", "");
                    }
                    else if (tblupdatestoke.Rows.Count < 1)
                    {
                        //insert data in stoke withdrowal
                        string description = "سداد عمليه شراء من المورد" + " " + cbxsupplier.Text + " " + "فاتوره رقم" + txtorderid.Text;
                        db.excutedata("insert into stoke_withdrowal(stoke_id,money,date,name,type,notes,user_name,branch_name,order_id2) values(" + stoke_id + "," + txttotalmadfou3.Text.Trim() + ",N'" + d + "',N'" + description + "',N' عمليه شراءمن '+N' '+N'" + cbxsupplier.Text + "',N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "'," + txtorderid.Text + ")", "");
                    }
                    //update stoke money
                    decimal finalmoney = Convert.ToDecimal(txttotalmadfou3.Text);
                    db.excutedata("update stoke_money set money=money+" + oldmoney + " where stoke_id=" + Properties.Settings.Default.stoke_id + "", "");
                    db.excutedata("update stoke_money set money=money-" + finalmoney + " where stoke_id=" + Properties.Settings.Default.stoke_id + "", "");


                    //print the bill after updating
                    print();
                    tileItem1.Enabled = true;
                    //close the panel of update
                    panelupdate.Visible = false;
                    autonumber();


                }
            }


        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            panelupdate.Visible = false;
        }

        private void tileItem6_ItemClick(object sender, TileItemEventArgs e)
        {
            panel2.Visible = true;
        }

        private void tileItem7_ItemClick(object sender, TileItemEventArgs e)
        {
            if (txtorderid.Text == "")
            {
                MessageBox.Show("من فضلك يجب ان يكون الفاتوره لها idبرجاء التواصل مع الدعم الفني", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtreturn_id.Text == "")
            {
                MessageBox.Show("هناك خطا في رقم البيان التسلسلي من فضلك اخطر الدعم الفني", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dgv.Rows.Count >= 1)
            {
                if (cbxsupplier.Text == "")
                {
                    MessageBox.Show("من فضلك اختر مورد اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                //set format of date and time
                string d = dtpdate.Value.ToString("yyyy-MM-dd");
                string t = dtptime.Text;

                //جدول ال buy_details and returns 
                db.excutedata("insert into returns values(" + txtreturn_id.Text.Trim() + "," + cbxsupplier.SelectedValue + ",N'" + d + "',N'" + Properties.Settings.Default.user_name + "'," + numircprice.Value + "," + txttotalorder.Text + ",N'" + t + "',N'" + Properties.Settings.Default.branch_name + "',N'" + txtnotes.Text.Trim() + "'," + dgv.CurrentRow.Cells[10].Value + "," + lblitemscount.Text + ",N'" + dgv.CurrentRow.Cells[9].Value + "')", "");

                decimal discount = 0;
                //جدول ال buy_details
                for (int i = 0; i <= dgv.Rows.Count - 1; i++)
                {
                    //insert into returns
                    db.excutedata("insert into return_details values(" + txtreturn_id.Text.Trim() + "," + cbxsupplier.SelectedValue + "," + dgv.Rows[i].Cells[0].Value + "," + dgv.Rows[i].Cells[3].Value + ",N'" + d + "',N'" + Properties.Settings.Default.user_name + "'," + dgv.Rows[i].Cells[4].Value + "," + dgv.Rows[i].Cells[5].Value + "," + numircprice.Value + "," + dgv.Rows[i].Cells[6].Value + "," + txttotalorder.Text + "," + Properties.Settings.Default.taxvalue + "," + dgv.Rows[i].Cells[4].Value + ",N'" + dtptime.Text + "',N'" + dgv.Rows[i].Cells[2].Value + "',N'" + Properties.Settings.Default.branch_name + "',N'" + dgv.Rows[i].Cells[7].Value + "',N'" + txtnotes.Text.Trim() + "'," + dgv.Rows[i].Cells[8].Value + "," + dgv.Rows[i].Cells[10].Value + "," + lblitemscount.Text + ",N'" + dgv.Rows[i].Cells[9].Value + "',N'" + dgv.Rows[i].Cells[1].Value + "')", "");


                    //جدول الوحدات وسعر الوحدات

                    DataTable tblsmallunitupdateprice = new DataTable();
                    tblsmallunitupdateprice.Clear();
                    tblsmallunitupdateprice = db.readdata("select*from product_units where pro_id=" + dgv.Rows[i].Cells[0].Value + " and unit_name=N'" + dgv.Rows[i].Cells[2].Value + "'", "");

                    if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3]) > 1)
                    {
                        db.excutedata("update product_units set unitpricecost=" + dgv.Rows[i].Cells[4].Value + " where pro_id=" + tblsmallunitupdateprice.Rows[0][0] + "", "");

                        tbl.Clear();
                        tbl = db.readdata("select*from products where product_id=" + dgv.Rows[i].Cells[0].Value + "", "");
                        db.excutedata("update product_units set unitpricecost=" + Convert.ToDecimal(dgv.Rows[i].Cells[4].Value) * Convert.ToDecimal(tbl.Rows[0][25]) + " where pro_id=" + dgv.Rows[i].Cells[0].Value + " and Qtyinunit=1", "");

                        //============================================================================


                    }
                    //============================================================================

                    //جدول الكميات products_qty

                    DataTable tblsmallqty = new DataTable();

                    tblsmallqty.Clear();
                    tblsmallqty = db.readdata("select*from products where product_id=" + dgv.Rows[i].Cells[0].Value + "", "");


                    decimal smallqty = Convert.ToDecimal(tblsmallqty.Rows[0][25]);
                    if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3]) > 1)
                    {
                        db.excutedata("update products_Qty set qty=qty-" + dgv.Rows[i].Cells[3].Value + " where pro_id=" + dgv.Rows[i].Cells[0].Value + "", "");
                        db.excutedata("update products_Qtyinstore set qty=qty-" + dgv.Rows[i].Cells[3].Value + " where pro_id=" + dgv.Rows[i].Cells[0].Value + " and store_id=" + dgv.Rows[i].Cells[10].Value + "", "");

                    }
                    else if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3]) == 1)
                    {
                        db.excutedata("update products_Qty set qty=qty-" + Convert.ToDecimal(dgv.Rows[i].Cells[3].Value) * smallqty + " where pro_id=" + dgv.Rows[i].Cells[0].Value + "", "");
                        db.excutedata("update products_Qtyinstore set qty=qty-" + Convert.ToDecimal(dgv.Rows[i].Cells[3].Value) * smallqty + " where pro_id=" + dgv.Rows[i].Cells[0].Value + " and store_id=" + dgv.Rows[i].Cells[10].Value + "", "");

                    }
                    //=============================================================================


                    //=============================================================================
                    //==============================================================================
                    //update data in item card
                    decimal realqty = 0;
                    if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3]) > 1)
                    {
                        realqty = Convert.ToDecimal(dgv.Rows[i].Cells[3].Value);
                    }
                    else if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3]) == 1)
                    {
                        realqty = Convert.ToDecimal(dgv.Rows[i].Cells[3].Value) * smallqty;
                    }
                    string discription = "مرتجع  فاتوره مشتريات رقم" + Convert.ToString(txtorderid.Text) + " " + "-مورد" + " " + Convert.ToString(cbxsupplier.Text);


                    DataTable tblfinaltotalqtycash = new DataTable();
                    tblfinaltotalqtycash.Clear();
                    tblfinaltotalqtycash = db.readdata("select*from item_card where pro_id=" + dgv.Rows[i].Cells[0].Value + "", "");
                    decimal totalward = 0, totalmosarf = 0, balance = 0;
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
                    db.excutedata("insert into item_card values(" + dgv.Rows[i].Cells[0].Value + ",N'" + dgv.Rows[i].Cells[1].Value + "'," + dgv.Rows[i].Cells[10].Value + ",N'" + dgv.Rows[i].Cells[9].Value + "',N'" + d + "'," + realqty + ",N'" + dgv.Rows[i].Cells[2].Value + "',N'" + discription + "',0," + realqty + "," + balance + ",N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + dgv.Rows[i].Cells[7].Value + "'," + txtorderid.Text + ",N'وارد')", "");

                    //===============================================================================================
                    //حساب المورد
                    decimal totalmoney = 0, totalsadad = 0, balancemoney = 0;
                    DataTable tblsupplieraccount = new DataTable();
                    tblsupplieraccount.Clear();
                    tblsupplieraccount = db.readdata("select*from supplier_account where sup_id=" + cbxsupplier.SelectedValue + "", "");


                    for (int s = 0; s <= tblsupplieraccount.Rows.Count - 1; s++)
                    {
                        totalmoney += Convert.ToDecimal(tblsupplieraccount.Rows[s][6]);
                        totalsadad += Convert.ToDecimal(tblsupplieraccount.Rows[s][10]);
                    }
                    if (tblsupplieraccount.Rows.Count >= 1)
                    {


                        balancemoney += ((totalmoney + (Convert.ToDecimal(dgv.Rows[i].Cells[6].Value)) - totalsadad));
                    }
                    else if (tblsupplieraccount.Rows.Count < 1)
                    {
                        balancemoney += Convert.ToDecimal(dgv.Rows[i].Cells[6].Value);
                    }
                    db.excutedata("insert into supplier_account values(" + txtorderid.Text + "," + cbxsupplier.SelectedValue + ",N'" + cbxsupplier.Text + "',N'" + discription + "',N'" + dgv.Rows[i].Cells[1].Value + "'," + dgv.Rows[i].Cells[3].Value + "," + dgv.Rows[i].Cells[6].Value + "," + txttotalorder.Text + ",N'" + txtnotes.Text + "',0," + Convert.ToDecimal(dgv.Rows[i].Cells[6].Value) + "," + balancemoney + ",N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + d + "',N'مرتجع',N'" + dgv.Rows[i].Cells[2].Value + "',"+txtorderid.Text+")", "");

                    discount += Convert.ToDecimal(dgv.Rows[i].Cells[5].Value);
                }
                if (discount > 0 && Convert.ToDecimal(numircprice.Value) == 0)
                {
                    discount += discount;
                }
                else if (discount == 0 && numircprice.Value != 0)
                {
                    discount += Convert.ToDecimal(numircprice.Value);
                }

                //==================================الخصم
                //================================================================================================================
                decimal totalmoney3 = 0, totalsadad3 = 0, balancemoney3 = 0;
                DataTable tblsupplieraccount3 = new DataTable();
                tblsupplieraccount3.Clear();
                tblsupplieraccount3 = db.readdata("select*from supplier_account where sup_id=" + cbxsupplier.SelectedValue + "", "");


                for (int a = 0; a <= tblsupplieraccount3.Rows.Count - 1; a++)
                {
                    totalmoney3 += Convert.ToDecimal(tblsupplieraccount3.Rows[a][6]);
                    totalsadad3 += Convert.ToDecimal(tblsupplieraccount3.Rows[a][10]);
                }
                if (tblsupplieraccount3.Rows.Count >= 1)
                {


                    balancemoney3 += (totalmoney3 - ((Convert.ToDecimal(discount)) + totalsadad3));
                }
                else if (tblsupplieraccount3.Rows.Count < 1)
                {
                    balancemoney3 += Convert.ToDecimal(discount);
                }

                if (numircprice.Value > 0)
                {
                    decimal zero3 = 0;
                    string discription3 = "خصم من الفاتوره المرتجع رقم " + Convert.ToString(txtorderid.Text) + " " + "-مورد" + " " + Convert.ToString(cbxsupplier.Text);

                    db.excutedata("insert into supplier_account values(" + txtorderid.Text + "," + cbxsupplier.SelectedValue + ",N'" + cbxsupplier.Text + "',N'" + discription3 + "',N'خصم'," + zero3 + "," + zero3 + "," + discount + ",N'خصم'," + zero3 + "," + discount + "," + balancemoney3 + ",N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + d + "',N'خصم',N'-',"+txtorderid.Text+")", "");
                }



                //================================================================================================================
                //===================================السداد

                decimal totalmoney2 = 0, totalsadad2 = 0, balancemoney2 = 0;
                DataTable tblsupplieraccount2 = new DataTable();
                tblsupplieraccount2.Clear();
                tblsupplieraccount2 = db.readdata("select*from supplier_account where sup_id=" + cbxsupplier.SelectedValue + "", "");


                for (int f = 0; f <= tblsupplieraccount2.Rows.Count - 1; f++)
                {
                    totalmoney2 += Convert.ToDecimal(tblsupplieraccount2.Rows[f][6]);
                    totalsadad2 += Convert.ToDecimal(tblsupplieraccount2.Rows[f][10]);
                }
                if (tblsupplieraccount2.Rows.Count >= 1)
                {


                    balancemoney2 += (totalmoney2 - ((Convert.ToDecimal(txttotalmadfou3.Text)) + totalsadad2));
                }
                else if (tblsupplieraccount2.Rows.Count < 1)
                {
                    balancemoney2 += Convert.ToDecimal(txttotalmadfou3.Text);
                }

                MessageBox.Show("تم المرتجع بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                autonumber();
              
            }

        }

        private void radioreturns_CheckedChanged(object sender, EventArgs e)
        {
            tileItem7.Enabled = true;
            tileItem1.Enabled = false;
        }

        //delete bill
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            //delete data from buy , buy_details , item card , buy details money , supplier account
            if (MessageBox.Show("هل انت متاكد من حذف الفاتوره", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                db.excutedata("delete from buy where order_id=" + txtorderid.Text + " and branch_name=N'" + Properties.Settings.Default.branch_name + "'", "");
                db.excutedata("delete from buy_details where order_id=" + txtorderid.Text + " and branch_name=N'" + Properties.Settings.Default.branch_name + "'", "");
                db.excutedata("delete from item_card where order_id=" + txtorderid.Text + " and branch_name=N'" + Properties.Settings.Default.branch_name + "' and type=N'وارد'", "");
                db.excutedata("delete from buy_details_money where order_id="+txtorderid.Text+" and branch_name=N'"+Properties.Settings.Default.branch_name+"'", "");
                db.excutedata("delete from supplier_account where order_id=" + txtorderid.Text + " and branch_name=N'" + Properties.Settings.Default.branch_name + "'", "");

                //======================================================
              
                string d = dtpdate.Value.ToString("yyyy-MM-dd");
                string t = dtptime.Text;
                string discriptionupdate = "وارد فاتوره مشتريات من المورد" + " " + cbxsupplier.Text + "فاتوره رقم" + txtorderid.Text;

                //insert into buy
                //جدول ال buy
                
                for (int i = 0; i <= dgv.Rows.Count - 1; i++)
                {
                    decimal totalmoney55 = 0, sadad = 0, balance55 = 0;

                    DataTable tbloldmoney = new DataTable();
                    tbloldmoney.Clear();
                    tbloldmoney = db.readdata("select*from supplier_account where sup_id=" + lblsup_id.Text + " and order_id<=" + txtorderid.Text + "", "");
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
                        balance += (totalward + realqty) - totalmosarf;
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


                    //----------------------------
                    decimal realqty2 = 0;
                    if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3]) > 1)
                    {
                        realqty2 = Convert.ToDecimal(dgv.Rows[i].Cells[12].Value);
                    }
                    else if (Convert.ToDecimal(tblsmallunitupdateprice.Rows[0][3]) == 1)
                    {
                        realqty2 = Convert.ToDecimal(dgv.Rows[i].Cells[12].Value) * smallqty;
                    }
                    db.excutedata("update products_Qty set Qty=Qty-" + realqty2 + " where pro_id=" + dgv.Rows[i].Cells[0].Value + " ", "");

                    DataTable tblchecktable = new DataTable();
                    tblchecktable.Clear();
                    tblchecktable = db.readdata("select*from products_Qtyinstore where pro_id=" + dgv.Rows[i].Cells[0].Value + " and store_id=" + dgv.Rows[i].Cells[10].Value + "", "");
                    if (tblchecktable.Rows.Count >= 1)
                    {
                        db.excutedata("update products_Qtyinstore set Qty=Qty-" + realqty2 + " where pro_id=" + dgv.Rows[i].Cells[0].Value + " and store_id=" + dgv.Rows[i].Cells[10].Value + "", "");

                    }
                    else if (tblchecktable.Rows.Count < 1)
                    {
                        db.excutedata("isert into products_Qtyinstore values (" + dgv.Rows[i].Cells[0].Value + ",N'" + dgv.Rows[i].Cells[1].Value + "'," + realqty2 + "," + dgv.Rows[i].Cells[10].Value + ",N'" + dgv.Rows[i].Cells[9].Value + "')", "");
                    }
                    //====================================================
                    /////////////////////////////////////////////////////////////الخزنه
                    DataTable tblupdatestoke = new DataTable();
                    tblupdatestoke.Clear();
                    tblupdatestoke = db.readdata("select*from stoke_withdrowal where order_id2=" + txtorderid.Text + " and branch_name=N'" + Properties.Settings.Default.branch_name + "'", "");
                    decimal oldmoney = 0;
                    if (tblupdatestoke.Rows.Count >= 1)
                    {
                        oldmoney = Convert.ToDecimal(tblupdatestoke.Rows[0][2]);
                    }
                    else
                    {
                        oldmoney = 0;
                    }
                   
                    //delete operation from stoke withdrowal
                    db.excutedata("delete from stoke_withdrowal where order_id2="+txtorderid.Text+" and branch_name=N'"+Properties.Settings.Default.branch_name+"'", "");
                    decimal finalmoney = Convert.ToDecimal(txttotalmadfou3.Text);
                    db.excutedata("update stoke_money set money=money+" + oldmoney + " where stoke_id=" + Properties.Settings.Default.stoke_id + "", "");



                    MessageBox.Show("تم تنفيذ العمليه بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    autonumber();
                }
            }
        }

        private void tileItem3_ItemClick(object sender, TileItemEventArgs e)
        {
            panelupdate.Visible = true;
            simpleButton4.Enabled = true;
            btnupdate.Enabled = false;
        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
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
            buy_returns_report frm = new buy_returns_report();
            frm.ShowDialog();

        }

        private void txtparcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void tileItem4_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Close();
        }
    }

    }
    

    


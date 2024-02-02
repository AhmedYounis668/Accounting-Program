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
    public partial class addproduct : DevExpress.XtraEditors.XtraForm
    {
        public addproduct()
        {
            InitializeComponent();
        }

        //call database class
        DataTable tbl = new DataTable();
        database db = new database();

        //set public row=0 to search 
        int row = 0;

        //make func called show to use it in search
        private void show()
        {
            //get all data from products table and make validation on this table to see if this table have data or now
            tbl = db.readdata("select*from products", "");
            if (tbl.Rows.Count <= 0)
            {
                MessageBox.Show("لايوجد بيانات  لهذه الشاشه", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //if table have data show it in the tools of the form
                try
                {
                    txtpro_id.Text = tbl.Rows[row][0].ToString();
                    txtpro_name.Text = tbl.Rows[row][1].ToString();
                    numericgomla_price.Value = Convert.ToDecimal(tbl.Rows[row][2]);
                    numericnosgomla.Value = Convert.ToDecimal(tbl.Rows[row][3]);
                    numerictagziaaa.Value = Convert.ToDecimal(tbl.Rows[row][4]);
                    numerictax.Value = Convert.ToDecimal(tbl.Rows[row][5]);

                    txtparcode.Text = tbl.Rows[row][9].ToString();
                    numerichadtalb.Value = Convert.ToDecimal(tbl.Rows[row][10]);
                    numericpremissiondiscount.Value = Convert.ToDecimal(tbl.Rows[row][11]);
                    cbxgroup_name.Text = (tbl.Rows[row][14]).ToString();

                    numericqtyinmain.Value= Convert.ToDecimal(tbl.Rows[row][25]);
                    cbxbigunit.Text = tbl.Rows[row][15].ToString();
                    cbxsalesunit.Text = tbl.Rows[row][17].ToString();
                    cbxbuyunit.Text = tbl.Rows[row][19].ToString();

                    //get units of the selected product
                    DataTable tblbuypriceforbigunit = new DataTable();
                    tblbuypriceforbigunit.Clear();
                    tblbuypriceforbigunit = db.readdata("select*from product_units where pro_id="+txtpro_id.Text+" and Qtyinunit=1", "");

                    //get the purchase price of the product depending on the unit

                    numericbuyprice.Value = Convert.ToDecimal(tblbuypriceforbigunit.Rows[row][5]);
                    try
                    {
                        numericsmalluniteprice.Value = numerictagziaaa.Value / numericqtyinmain.Value;
                    }
                    catch {};
                        if (tbl.Rows[row][12].ToString() == "خاضع للضريبه")
                    {
                        checktaxes.Checked = true;
                    }
                    else if (tbl.Rows[row][12].ToString() == "غير خاضع للضريبه")
                    {
                        checktaxes.Checked = false;
                    }
                   
                }
                catch (Exception)
                {
                }

                //show the units of product in datagridview of units
                DataTable tblunits = new DataTable();
                tblunits.Clear();
                tblunits = db.readdata("select*from product_units where pro_id=" + txtpro_id.Text.Trim() + "", "");
                dgvunits.Rows.Clear();
                if (tblunits.Rows.Count > 0)
                {
                    foreach (DataRow row in tblunits.Rows)
                    {
                        dgvunits.Rows.Add(1);
                        int rowindex = dgvunits.Rows.Count - 1;
                        dgvunits.Rows[rowindex].Cells[0].Value = row[2];
                        dgvunits.Rows[rowindex].Cells[1].Value = row[3];
                        dgvunits.Rows[rowindex].Cells[2].Value = row[4];
                        dgvunits.Rows[rowindex].Cells[3].Value = row[5];

                    }

                }
         
            }

        }


        //=============================================================================

       
            //search with parcode of selected product
            private void parcodeshow()
            {

                tbl = db.readdata("select*from products where parcode="+txtparcodesearch.Text.Trim()+"", "");
                if (tbl.Rows.Count <= 0)
                {
                    MessageBox.Show("لايوجد بيانات  لهذه الشاشه", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                try
                {
                    txtpro_id.Text = tbl.Rows[row][0].ToString();
                    txtpro_name.Text = tbl.Rows[row][1].ToString();
                    numericgomla_price.Value = Convert.ToDecimal(tbl.Rows[row][2]);
                    numericnosgomla.Value = Convert.ToDecimal(tbl.Rows[row][3]);
                    numerictagziaaa.Value = Convert.ToDecimal(tbl.Rows[row][4]);
                    numerictax.Value = Convert.ToDecimal(tbl.Rows[row][5]);

                    txtparcode.Text = tbl.Rows[row][9].ToString();
                    numerichadtalb.Value = Convert.ToDecimal(tbl.Rows[row][10]);
                    numericpremissiondiscount.Value = Convert.ToDecimal(tbl.Rows[row][11]);
                    cbxgroup_name.Text = (tbl.Rows[row][14]).ToString();

                    cbxbigunit.Text = tbl.Rows[row][15].ToString();
                    cbxsalesunit.Text = tbl.Rows[row][17].ToString();
                    cbxbuyunit.Text = tbl.Rows[row][19].ToString();
                    numericbuyprice.Value = Convert.ToDecimal(tbl.Rows[row][24]);
                    if (tbl.Rows[row][12].ToString() == "خاضع للضريبه")
                    {
                        checktaxes.Checked = true;
                    }
                    else if (tbl.Rows[row][12].ToString() == "غير خاضع للضريبه")
                    {
                        checktaxes.Checked = false;
                    }
                }

                catch (Exception)
                {
                }
                //show the units of product in datagridview of units

                DataTable tblunits = new DataTable();
                    tblunits.Clear();
                    tblunits = db.readdata("select*from product_units where pro_id=" + txtpro_id.Text.Trim() + "", "");
                    dgvunits.Rows.Clear();
                    if (tblunits.Rows.Count > 0)
                    {
                        foreach (DataRow row in tblunits.Rows)
                        {
                            dgvunits.Rows.Add(1);
                            int rowindex = dgvunits.Rows.Count - 1;
                            dgvunits.Rows[rowindex].Cells[0].Value = row[2];
                            dgvunits.Rows[rowindex].Cells[1].Value = row[3];
                            dgvunits.Rows[rowindex].Cells[2].Value = row[4];
                            dgvunits.Rows[rowindex].Cells[3].Value = row[5];

                        }

                    }
        

            }

        }

       //call max id from products table to create autonumber

        private void autonumber()
        {
            //get last id in the table

            tbl = db.readdata("select max(product_id)from products", "");
                //check if this id in the table have data or null
            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                //if there not data in the table textbox=>id set =1

                txtpro_id.Text = "1";
            }
            else
            {
                //if the table have data get this number in cell id and set it +1

                txtpro_id.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }
            //clear data from the toolbox in the form
            dgvunits.Rows.Clear();
            numericbuyprice.Value = 0;
            numerichadtalb.Value = 0;
            numericqtyinmain.Value = 0;
            numericsmallcostprice.Value = 0;
            numericsmalluniteprice.Value = 0;
            txtpro_name.Clear();
            numericgomla_price.Value = 0;
            numerichadtalb.Value = 0;
            numericqtyinmain.Value = 0;
            numerictagziaaa.Value = 0;
            numericsmalluniteprice.Value = 0;
            numericnosgomla.Value = 0;
            txtnotes.Clear();
            txtparcode.Clear();
            txtparcodesearch.Clear();
            txtsearchwithpro_name.Clear();
            txtpro_name.Focus();
            numerictax.Value = 0;
            checktaxes.Checked = false;
        }

        //fill comboboxes =>groups units products
        private void fillcbx()
        {
            cbxgroup_name.DataSource = db.readdata("select*from groups", "");
            cbxgroup_name.DisplayMember = "group_name";
            cbxgroup_name.ValueMember = "group_id";

            cbxbigunit.DataSource = db.readdata("select*from units", "");
            cbxbigunit.DisplayMember = "unit_name";
            cbxbigunit.ValueMember = "unit_id";

            cbxbuyunit.DataSource = db.readdata("select*from units", "");
            cbxbuyunit.DisplayMember = "unit_name";
            cbxbuyunit.ValueMember = "unit_id";

            cbxsalesunit.DataSource = db.readdata("select*from units", "");
            cbxsalesunit.DisplayMember = "unit_name";
            cbxsalesunit.ValueMember = "unit_id";

            cbxsmallunit.DataSource = db.readdata("select*from units", "");
            cbxsmallunit.DisplayMember = "unit_name";
            cbxsmallunit.ValueMember = "unit_id";

            cbxproducts.DataSource = db.readdata("select*from products", "");
            cbxproducts.DisplayMember = "product_name";
            cbxproducts.ValueMember = "product_id";
        }


        private void tileItem3_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void addproduct_Load(object sender, EventArgs e)
        {
            dtprecorddate.Text = DateTime.Now.ToShortDateString();
            dtpfinishdate.Text = DateTime.Now.ToShortDateString();
            autonumber();
            fillcbx();
        }

        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            //validation to add new product
            if (txtpro_name.Text == "")
            {
                MessageBox.Show("ادخل اسم المنتج من فضلك", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cbxgroup_name.SelectedIndex < 0)
            {
                MessageBox.Show("قم ياضافه التصنيفات ثم قم باختيار تصنيف من فضلك ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cbxbuyunit.SelectedIndex < 0)
            {
                MessageBox.Show("قم ياضافه الوحدات ثم قم باختيار وحده شراء تظهر كوحده بدائيه في شاشه المشتريات من فضلك ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cbxsalesunit.SelectedIndex < 0)
            {
                MessageBox.Show("قم ياضافه الوحدات ثم قم باختيار وحده بيع تظهر كوحده بدائيه في شاشه المبيعات من فضلك ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cbxbigunit.SelectedIndex < 0)
            {
                MessageBox.Show("قم ياضافه الوحدات ثم قم باختيار وحده اكبر وحده في التعامل من فضلك ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cbxsmallunit.SelectedIndex < 0)
            {
                MessageBox.Show("قم ياضافه الوحدات ثم قم باختيار وحده تكون اصغر  وحده في التعامل او كوحده ثانيه من فضلك ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtparcode.Text == "")
            {
                MessageBox.Show("قم ياضافه باركود للمنتج من فضلك ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Convert.ToDecimal(numericgomla_price.Value) <= 0)
            {
                MessageBox.Show("سعر بيع الجمله لايجب ان يساوي صفر ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Convert.ToDecimal(numericnosgomla.Value) <= 0)
            {
                MessageBox.Show("سعر بيع النص جمله لايجب ان يساوي صفر ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Convert.ToDecimal(numerictagziaaa.Value) <= 0)
            {
                MessageBox.Show("سعر بيع التجزئه لايجب ان يساوي صفر ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (numericbuyprice.Value <= 0)
            {
                MessageBox.Show("سعر الشراء لايجب ان يساوي صفر ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (numerictagziaaa.Value < numericbuyprice.Value)
            {
                MessageBox.Show("لايجب ان يكون سعر البيع بالتجزئه اصغر من سعر الشراء", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (numericgomla_price.Value < numericbuyprice.Value)
            {
                MessageBox.Show("لايجب ان يكون سعر البيع بالجمله اصغر من سعر الشراء", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (numericnosgomla.Value < numericbuyprice.Value)
            {
                MessageBox.Show("لايجب ان يكون سعر البيع بالنص جمله اصغر من سعر الشراء", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(checktaxes.Checked==true)
            {
                checktaxes.Checked = false;
                numerictax.Value= 0;
            }
            else
            {
                decimal gomlapriceaftertax = Convert.ToDecimal(numericgomla_price.Value) * Convert.ToDecimal(numerictax.Value) + numericgomla_price.Value;
                decimal nosgomlapriceaftertax = Convert.ToDecimal(numericnosgomla.Value) * Convert.ToDecimal(numerictax.Value) + numericnosgomla.Value;
                decimal tagzaaaftertax = Convert.ToDecimal(numericgomla_price.Value) * Convert.ToDecimal(numerictax.Value) + numerictagziaaa.Value;

                string is_tax = "غير خاضع للضريبه";
                if (checktaxes.Checked == true)
                {
                    is_tax = "خاضع للضريبه";
                }

                //set formate dates
                string d = dtprecorddate.Value.ToString("yyyy-MM-dd");
                string sal7iafinished = dtpfinishdate.Value.ToString("yyyy-MM-dd");

                //insert data of new product in products table
                db.excutedata("insert into products values(" + txtpro_id.Text + ",N'" + txtpro_name.Text.Trim() + "'," + numericgomla_price.Value + "," + numericnosgomla.Value + "," + numerictagziaaa.Value + "," + numerictax.Value + "," + gomlapriceaftertax + "," + nosgomlapriceaftertax + "," + tagzaaaftertax + ",N'" + txtparcode.Text.Trim() + "'," + numerichadtalb.Value + "," + numericpremissiondiscount.Value + ",N'" + is_tax + "'," + cbxgroup_name.SelectedValue + ",N'" + cbxgroup_name.Text.Trim() + "',N'" + cbxbigunit.Text.Trim() + "'," + cbxbigunit.SelectedValue + ",N'" + cbxsalesunit.Text.Trim() + "'," + cbxsalesunit.SelectedValue + ",N'" + cbxbuyunit.Text.Trim() + "'," + cbxbuyunit.SelectedValue + ",N'" + d + "',N'" + txtnotes.Text.Trim() + "',N'" + sal7iafinished + "',1," +numericqtyinmain.Value + ")", "");

                //insert big unit of new product in product_units table
                db.excutedata("insert into product_units values(" + txtpro_id.Text.Trim() + ",N'" + txtpro_name.Text.Trim() + "',N'" + cbxbigunit.Text.Trim() + "',1," + numerictagziaaa.Value + "," + numericbuyprice.Value + ",N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "')", "");

                //set small units of new product in product_units table
                for (int i = 0; i <= dgvunits.Rows.Count - 1; i++)
                {
                    db.excutedata("insert into product_units values(" + txtpro_id.Text.Trim() + ",N'" + txtpro_name.Text.Trim() + "',N'" + dgvunits.Rows[i].Cells[0].Value + "'," + dgvunits.Rows[i].Cells[1].Value + "," + dgvunits.Rows[i].Cells[2].Value + "," + dgvunits.Rows[i].Cells[3].Value + ",N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "')", "");
                }

                //=========================================اضافه المنتج بتعريفه لاول مره في جدول products_Qty
                db.excutedata("insert into products_Qty values("+txtpro_id.Text+",N'"+txtpro_name.Text.Trim()+"',0)", "");
                MessageBox.Show("تم الحفظ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //reloade comboboxer another once
                fillcbx();

            }
            autonumber();
        }

        private void txtpro_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cbxgroup_name.Focus();
            }
        }

        private void cbxgroup_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cbxsalesunit.Focus();
            }
        }

        private void cbxbuyunit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtparcode.Focus();
            }
        }

        private void cbxbuyunit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtparcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                numerichadtalb.Focus();
            }
        }

        private void numerichadtalb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cbxbigunit.Focus();
            }
        }

        private void cbxbigunit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cbxsmallunit.Focus();
            }
        }

        private void cbxsmallunit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                numericqtyinmain.Focus();
            }
        }

        private void numericqtyinmain_KeyPress(object sender, KeyPressEventArgs e)
        {
            //when press enter
            if (e.KeyChar == 13)
            {
                numericsmalluniteprice.Value = numerictagziaaa.Value / numericqtyinmain.Value;
                numericsmallcostprice.Value = numericbuyprice.Value / numericqtyinmain.Value;
                numericsmalluniteprice.Focus();
            }
        }

        private void btnaddunit_KeyPress(object sender, KeyPressEventArgs e)
        {
            //when pree enter 
            if (e.KeyChar == 13)
            {
                btnaddunit_Click(null, null);
                txtnotes.Focus();

            }
        }

        private void btnaddunit_Click(object sender, EventArgs e)
        {
            //validation to add units in datagridview =>units
            if(dgvunits.Rows.Count==2)
            {
                MessageBox.Show("لايمكن اضافه اكثر من 2 وحده فقط للصنف الواحد", "تنبيه هام", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Convert.ToInt32(cbxbigunit.SelectedValue) == Convert.ToInt32(cbxsmallunit.SelectedValue))
            {
                MessageBox.Show("لايمكن ان تكون الوحده الصغري مثل الوحده الكبري", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (numericqtyinmain.Value <= 0)
            {
                MessageBox.Show("لايجب ان تكون الكميه للوحده الصغري اصغر من او تساوي صفر", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (numericsmalluniteprice.Value <= 0)
            {
                MessageBox.Show("لايجب ان يكون سعر الوحده اصغر من او يساوي صفر", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //attention if the small units you want to add added once befor or not
            for (int i = 0; i <= dgvunits.Rows.Count - 1; i++)
            {
                if (cbxsmallunit.Text == Convert.ToString(dgvunits.Rows[i].Cells[0].Value))
                {
                    MessageBox.Show("هذه الوحده تم اضافتها من قبل", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            //attention if the big units you want to add added once befor or not

            for (int i = 0; i <= dgvunits.Rows.Count - 1; i++)
            {
                if ( cbxbigunit.Text == Convert.ToString(dgvunits.Rows[i].Cells[0].Value).ToString())
                {
                    MessageBox.Show("هذه الوحده الكبري تمت اضافتها من قبل وموجوده بالفعل", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            //down the data in datagridview =>units

            dgvunits.Rows.Add(1);
            int rowindex1 = dgvunits.Rows.Count - 1;

            dgvunits.Rows[rowindex1].Cells[0].Value = cbxsmallunit.Text;
            dgvunits.Rows[rowindex1].Cells[1].Value = numericqtyinmain.Value;
            dgvunits.Rows[rowindex1].Cells[2].Value = numericsmalluniteprice.Value;
            dgvunits.Rows[rowindex1].Cells[3].Value = numericsmallcostprice.Value;
        
    }


        private void numericgomla_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                numericnosgomla.Focus();
            }
        }

        private void numericnosgomla_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                numerictagziaaa.Focus();
            }
        }

        private void btnaddgroup_Click(object sender, EventArgs e)
        {
            //open form groups to add new group from this form and reload the data in combobox  whene close the form
            groups frm = new groups();
            frm.ShowDialog();
            cbxgroup_name.DataSource = db.readdata("select*from groups", "");
            cbxgroup_name.DisplayMember = "group_name";
            cbxgroup_name.ValueMember = "group_id";

           
        }

        private void btnaddunits_Click(object sender, EventArgs e)
        {
            //open form units to add new unit from this form and reload the data in combobox  whene close the form

            units frm = new units();
            frm.ShowDialog();
            cbxsmallunit.DataSource = db.readdata("select*from units", "");
            cbxsmallunit.DisplayMember = "unit_name";
            cbxsmallunit.ValueMember = "unit_id";

            cbxsalesunit.DataSource = db.readdata("select*from units", "");
            cbxsalesunit.DisplayMember = "unit_name";
            cbxsalesunit.ValueMember = "unit_id";

            cbxbuyunit.DataSource = db.readdata("select*from units", "");
            cbxbuyunit.DisplayMember = "unit_name";
            cbxbuyunit.ValueMember = "unit_id";

            cbxbigunit.DataSource = db.readdata("select*from units", "");
            cbxbigunit.DisplayMember = "unit_name";
            cbxbigunit.ValueMember = "unit_id";


        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void numericsmalluniteprice_ValueChanged(object sender, EventArgs e)
        {
           
    }

        private void numericqtyinmain_ValueChanged(object sender, EventArgs e)
        {
            //get the price of small unit and show it in numericsmalluniteprice
            try
            {
                numericsmalluniteprice.Value = numerictagziaaa.Value / numericqtyinmain.Value;
            }
            catch (Exception) { }

            

        }

        private void numericbuyprice_ValueChanged(object sender, EventArgs e)
        {
            if (numericqtyinmain.Value <= 0)
            {
                MessageBox.Show("من فضلك ادخل عدد القطع المتواجده داخل الوحده الرئيسيه اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                numericsmallcostprice.Value = numericbuyprice.Value / numericqtyinmain.Value;
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnnew_ItemClick(object sender, TileItemEventArgs e)
        {
            autonumber();
            fillcbx();
        }

        private void btnupdate_ItemClick(object sender, TileItemEventArgs e)
        {
            //validation to update data of selected product
            if (txtpro_name.Text == "")
            {
                MessageBox.Show("ادخل اسم المنتج من فضلك", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cbxgroup_name.SelectedIndex < 0)
            {
                MessageBox.Show("قم ياضافه التصنيفات ثم قم باختيار تصنيف من فضلك ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cbxbuyunit.SelectedIndex < 0)
            {
                MessageBox.Show("قم ياضافه الوحدات ثم قم باختيار وحده شراء تظهر كوحده بدائيه في شاشه المشتريات من فضلك ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cbxsalesunit.SelectedIndex < 0)
            {
                MessageBox.Show("قم ياضافه الوحدات ثم قم باختيار وحده بيع تظهر كوحده بدائيه في شاشه المبيعات من فضلك ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cbxbigunit.SelectedIndex < 0)
            {
                MessageBox.Show("قم ياضافه الوحدات ثم قم باختيار وحده اكبر وحده في التعامل من فضلك ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cbxsmallunit.SelectedIndex < 0)
            {
                MessageBox.Show("قم ياضافه الوحدات ثم قم باختيار وحده تكون اصغر  وحده في التعامل او كوحده ثانيه من فضلك ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtparcode.Text == "")
            {
                MessageBox.Show("قم ياضافه باركود للمنتج من فضلك ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Convert.ToDecimal(numericgomla_price.Value) <= 0)
            {
                MessageBox.Show("سعر بيع الجمله لايجب ان يساوي صفر ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Convert.ToDecimal(numericnosgomla.Value) <= 0)
            {
                MessageBox.Show("سعر بيع النص جمله لايجب ان يساوي صفر ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Convert.ToDecimal(numerictagziaaa.Value) <= 0)
            {
                MessageBox.Show("سعر بيع التجزئه لايجب ان يساوي صفر ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (numericbuyprice.Value <= 0)
            {
                MessageBox.Show("سعر الشراء لايجب ان يساوي صفر ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (numerictagziaaa.Value < numericbuyprice.Value)
            {
                MessageBox.Show("لايجب ان يكون سعر البيع بالتجزئه اصغر من سعر الشراء", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (numericgomla_price.Value < numericbuyprice.Value)
            {
                MessageBox.Show("لايجب ان يكون سعر البيع بالجمله اصغر من سعر الشراء", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (numericnosgomla.Value < numericbuyprice.Value)
            {
                MessageBox.Show("لايجب ان يكون سعر البيع بالنص جمله اصغر من سعر الشراء", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (checktaxes.Checked == true)
            {
                checktaxes.Checked = false;
                numerictax.Value =0;
            }
            else if(numericqtyinmain.Value<1)
            {
                MessageBox.Show("من فضلك ادخل عدد القطع داخل الوحده الرئيسيه", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //delete this product from products table and delete thier units from product_units table
                db.excutedata("delete from products where product_id=" + txtpro_id.Text + "", "");
                db.excutedata("delete from product_units where pro_id=" + txtpro_id.Text + "", "");

                //تعديل اسم المنتج في جميع الجداول
                //=========================================================================================
                //===========================================================================================
                db.excutedata("update buy_details set pro_name=N'"+txtpro_name.Text.Trim()+"' where product_id="+txtpro_id.Text+"", "");
                db.excutedata("update item_card set pro_name=N'" + txtpro_name.Text.Trim() + "' where pro_id=" + txtpro_id.Text + "", "");
                db.excutedata("update products_Qty set pro_name=N'" + txtpro_name.Text.Trim() + "' where pro_id=" + txtpro_id.Text + "", "");
                db.excutedata("update return_details set pro_name=N'" + txtpro_name.Text.Trim() + "' where product_id=" + txtpro_id.Text + "", "");
                db.excutedata("update product_units set pro_name=N'" + txtpro_name.Text.Trim() + "' where pro_id=" + txtpro_id.Text + "", "");


                //======================================================================================================
                //========================================================================================================


                decimal gomlapriceaftertax = Convert.ToDecimal(numericgomla_price.Value) * Convert.ToDecimal(numerictax.Value) + numericgomla_price.Value;
                decimal nosgomlapriceaftertax = Convert.ToDecimal(numericnosgomla.Value) * Convert.ToDecimal(numerictax.Value) + numericnosgomla.Value;
                decimal tagzaaaftertax = Convert.ToDecimal(numericgomla_price.Value) * Convert.ToDecimal(numerictax.Value) + numerictagziaaa.Value;

                string is_tax = "غير خاضع للضريبه";
                if (checktaxes.Checked == true)
                {
                    is_tax = "خاضع للضريبه";
                }

                //set formate date
                string d = dtprecorddate.Value.ToString("yyyy-MM-dd");
                string sal7iafinished = dtpfinishdate.Value.ToString("yyyy-MM-dd");

                //insert new data of product in products table
                db.excutedata("insert into products values(" + txtpro_id.Text + ",N'" + txtpro_name.Text.Trim() + "'," + numericgomla_price.Value + "," + numericnosgomla.Value + "," + numerictagziaaa.Value + "," + numerictax.Value + "," + gomlapriceaftertax + "," + nosgomlapriceaftertax + "," + tagzaaaftertax + ",N'" + txtparcode.Text.Trim() + "'," + numerichadtalb.Value + "," + numericpremissiondiscount.Value + ",N'" + is_tax + "'," + cbxgroup_name.SelectedValue + ",N'" + cbxgroup_name.Text.Trim() + "',N'" + cbxbigunit.Text.Trim() + "'," + cbxbigunit.SelectedValue + ",N'" + cbxsalesunit.Text.Trim() + "'," + cbxsalesunit.SelectedValue + ",N'" + cbxbuyunit.Text.Trim() + "'," + cbxbuyunit.SelectedValue + ",N'" + d + "',N'" + txtnotes.Text.Trim() + "',N'" + sal7iafinished + "',1," + numericqtyinmain.Value + ")", "");

                //insert big unit of product in productsunits table
                 db.excutedata("insert into product_units values(" + txtpro_id.Text.Trim() + ",N'" + txtpro_name.Text.Trim() + "',N'" + cbxbigunit.Text.Trim() + "',1," + numerictagziaaa.Value + "," + numericbuyprice.Value + ",N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "')", "");

                //insert small units of product in productsunits table
                for (int i = 0; i <= dgvunits.Rows.Count - 1; i++)
                {
                    db.excutedata("insert into product_units values(" + txtpro_id.Text.Trim() + ",N'" + txtpro_name.Text.Trim() + "',N'" + dgvunits.Rows[i].Cells[0].Value + "'," + dgvunits.Rows[i].Cells[1].Value + "," + dgvunits.Rows[i].Cells[2].Value + "," + dgvunits.Rows[i].Cells[3].Value + ",N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "')", "");
                }

                MessageBox.Show("تم الحفظ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fillcbx();
            }
            autonumber();
            }

        private void btnlast_Click(object sender, EventArgs e)
        {
            DataTable tblshow = new DataTable();
            tblshow.Clear();
            tblshow = db.readdata("select count(product_id)from products", "");
            row = Convert.ToInt32(tblshow.Rows[0][0]) - 1;
            show();
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            row = 0;
            show();
        }

        private void btnremoveunit_Click(object sender, EventArgs e)
        {
            if (dgvunits.Rows.Count >= 1)
            {
                dgvunits.Rows.RemoveAt(dgvunits.CurrentCell.RowIndex);
            }

        }

        private void txtsearchwithpro_name_TextChanged(object sender, EventArgs e)
        {
            //search on the product by the letter of his name
            DataTable tblsearchwithpro_name = new DataTable();
            tblsearchwithpro_name.Clear();
            tblsearchwithpro_name = db.readdata("select product_id as 'رقم المنتج',product_name as 'اسم المنتج',salesprice_tax_gomla as 'سعر جمله',salesprice_tax_nosgomla as 'سعر نص جمله',salesprice_tax_tagzaaaa as'سعر تجزئه', tax_value as 'الضريبه',parcode as 'الباركود',minQty as 'حد الطلب',is_tax as 'هل خاضع للضريبه ؟',group_name as 'التصنيف' from products where products.product_name like N'%" + txtsearchwithpro_name.Text.Trim()+"%'", "");
            dgv.DataSource = tblsearchwithpro_name;
        }

        //arrow back to show data in the tools of the forms and get previous product
        private void btnback_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readdata("select count(product_id)from products", "");
            if (row == 0)
            {
                row = Convert.ToInt32(tbl.Rows[0][0]) - 1;
                show();
            }
            else
            {
                row--;
                show();

            }
        }

        //arrow next to show data in the tools of the forms and get next product

        private void btnnext_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readdata("select count(product_id)from products", "");
            if (Convert.ToInt32(tbl.Rows[0][0]) - 1 == row)
            {
                row = 0;
                show();
            }
            else
            {
                row++;
                show();
            }
        }

        //search with parcode of  the product
        private void txtparcodesearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                parcodeshow();
                txtparcodesearch.Clear();
            }
        }

        //choose the product from combobox and search on it from the combobox
        private void cbxproducts_SelectionChangeCommitted(object sender, EventArgs e)
        {
           

                tbl = db.readdata("select*from products where product_name=N'"+cbxproducts.Text.Trim()+"'", "");
                if (tbl.Rows.Count <= 0)
                {
                    MessageBox.Show("لايوجد بيانات  لهذه الشاشه", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        txtpro_id.Text = tbl.Rows[row][0].ToString();
                        txtpro_name.Text = tbl.Rows[row][1].ToString();
                        numericgomla_price.Value = Convert.ToDecimal(tbl.Rows[row][2]);
                        numericnosgomla.Value = Convert.ToDecimal(tbl.Rows[row][3]);
                        numerictagziaaa.Value = Convert.ToDecimal(tbl.Rows[row][4]);
                        numerictax.Value = Convert.ToDecimal(tbl.Rows[row][5]);

                        txtparcode.Text = tbl.Rows[row][9].ToString();
                        numerichadtalb.Value = Convert.ToDecimal(tbl.Rows[row][10]);
                        numericpremissiondiscount.Value = Convert.ToDecimal(tbl.Rows[row][11]);
                        cbxgroup_name.Text = (tbl.Rows[row][14]).ToString();

                        cbxbigunit.Text = tbl.Rows[row][15].ToString();
                        cbxsalesunit.Text = tbl.Rows[row][17].ToString();
                        cbxbuyunit.Text = tbl.Rows[row][19].ToString();
                        numericbuyprice.Value = Convert.ToDecimal(tbl.Rows[row][24]);
                        if (tbl.Rows[row][12].ToString() == "خاضع للضريبه")
                        {
                            checktaxes.Checked = true;
                        }
                        else if (tbl.Rows[row][12].ToString() == "غير خاضع للضريبه")
                        {
                            checktaxes.Checked = false;
                        }
                        
                    }
                    catch (Exception)
                    {
                    }


                //show units of selected product on datagridview of product units

                    DataTable tblunits = new DataTable();
                    tblunits.Clear();
                    tblunits = db.readdata("select*from product_units where pro_id=" + txtpro_id.Text.Trim() + "", "");
                    dgvunits.Rows.Clear();
                    if (tblunits.Rows.Count > 0)
                    {
                        foreach (DataRow row in tblunits.Rows)
                        {
                            dgvunits.Rows.Add(1);
                            int rowindex = dgvunits.Rows.Count - 1;
                            dgvunits.Rows[rowindex].Cells[0].Value = row[2];
                            dgvunits.Rows[rowindex].Cells[1].Value = row[3];
                            dgvunits.Rows[rowindex].Cells[2].Value = row[4];
                            dgvunits.Rows[rowindex].Cells[3].Value = row[5];

                        }

                    }
               

                }

     
        }

        private void numerictagziaaa_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                numericsmalluniteprice.Value = numerictagziaaa.Value / numericqtyinmain.Value;
            }
            catch (Exception) { }
            }

        private void txtpro_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpro_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
    }
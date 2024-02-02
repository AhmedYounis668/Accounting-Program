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
    public partial class item_cardscreen : DevExpress.XtraEditors.XtraForm
    {
        public item_cardscreen()
        {
            InitializeComponent();
        }
        //call database class
        DataTable tbl = new DataTable();
        database db = new database();

        //fill combobox with stores
        private void fillcbx()
        {
            cbxstore.DataSource = db.readdata("select*from stores", "");
            cbxstore.DisplayMember = "store_name";
            cbxstore.ValueMember = "store_id";
        }
        //search about product name
        private void txtitem_TextChanged(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readdata("select product_id as 'رقم المنتج',product_name as 'اسم المنتج' from products where product_name like N'%"+txtitem.Text.Trim()+"%'", "");
            dgvproducts.DataSource = tbl;
        }
        //search 
        private void btnsearch_Click(object sender, EventArgs e)
        {
            if(radioallitemsinselectedstore.Checked==false&&radioselectediteminselectedstore.Checked==false)
            {
                MessageBox.Show("من فضلك حدد عمليه اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(dgvproducts.Rows.Count>=1)
            {
                //search about one product in selected store
                int pro_id = Convert.ToInt32(dgvproducts.CurrentRow.Cells[0].Value);
                if(radioselectediteminselectedstore.Checked==true)
                {
                    tbl.Clear();
                    tbl = db.readdata("select pro_id as 'رقم المنتج',pro_name as 'اسم المنتج',store_name as 'المخزن',date as 'التاريخ',Qty as 'الكميه',description as 'البيان',ward as 'الوارد',monsarf as 'المنصرف',user_name as 'المستخدم', branch_name as 'الفرع' from item_card where store_id="+cbxstore.SelectedValue+" and pro_id="+pro_id+"", "");
                    dgv.DataSource = tbl;

                    //calculate the quantity
                    decimal ward = 0,monsarf = 0,final = 0;
                    for(int i=0;i<=dgv.Rows.Count-1;i++)
                    {
                        ward+= Convert.ToDecimal(dgv.Rows[i].Cells[6].Value);
                        monsarf+= Convert.ToDecimal(dgv.Rows[i].Cells[7].Value);
                    }
                    final = ward - monsarf;
                    txtward.Text = ward.ToString();
                    txtmonsarf.Text = monsarf.ToString();
                    txtbalance.Text = final.ToString();
                   
                }
              
            }
            //search about all products in the selected store
           if (radioallitemsinselectedstore.Checked == true)
            {
                tbl.Clear();
                tbl = db.readdata("select pro_id as 'رقم المنتج',pro_name as 'اسم المنتج',Qty as 'الكميه',store_name as 'المخزن' from products_Qtyinstore where store_id=" + cbxstore.SelectedValue + " ", "");
                dgv.DataSource = tbl;
                txtmonsarf.Text = "0";
                txtward.Text = "0";
                txtbalance.Text = "0";
            }
        }

        private void item_cardscreen_Load(object sender, EventArgs e)
        {
            fillcbx();
        }

        //search about the quantity only of the proeducts in all stores
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readdata(" select pro_id as 'رقم المنتج', pro_name as 'اسم المنتج',Qty as 'الكميه' from products_Qty ", "");

            dgv.DataSource = tbl;
            txtmonsarf.Text = "0";
            txtward.Text = "0";
            txtbalance.Text = "0";

        }
        //totals quantity in selected store
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (cbxstore.Text != "")
            {
                tbl.Clear();
                tbl = db.readdata("select SUM(ward) as 'الوارد',sum (monsarf) as 'المنصرف',SUM(ward)-sum (monsarf) as 'المتبقي',item_card.pro_id as 'رقم الصنف',(select products.product_name  from products where products.product_id=item_card.pro_id)as 'اسم الصنف' from item_card  where store_id=" + cbxstore.SelectedValue + "  group by(item_card.pro_id)  ", "");
                dgv.DataSource = tbl;
            }
            else
            {
                MessageBox.Show("من فضلك حدد المخزن اولا", "خطا",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
        }
    }
}
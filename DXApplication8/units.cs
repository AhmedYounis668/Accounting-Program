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
    public partial class units : DevExpress.XtraEditors.XtraForm
    {
        public units()
        {
            InitializeComponent();
        }
        //call database class
        database db = new database();
        DataTable tbl = new DataTable();

        //autonumber
        private void autonumber()
        {
         //get the max id from units  
                tbl = db.readdata("select max(unit_id)from units", "");
            //if there is no data or the cell of id in nthe unit table is null set textbox of id=1
                if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
                {
                    txtunitnumber.Text = "1";
                }
                else
                {
                //if there is data in the cell id in table set the value of id=value+1 and show it in textbox of id
                  txtunitnumber.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
                }
            txtunitname.Clear();
            tbl.Clear();
            //swho data of units in datagridview
            tbl=db.readdata("select unit_id as 'رقم الوحده',unit_name as 'اسم الوحده' from units", "");
            dgv.DataSource = tbl;
            txtunitname.Focus();
            }
        private void units_Load(object sender, EventArgs e)
        {
            autonumber();

        }
        //add unit
        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            if(txtunitname.Text=="")
            {
                MessageBox.Show("من فضلك ادخل اسم الوحده اولا قبل الحفظ","خطا",MessageBoxButtons.OK,MessageBoxIcon.Error);

                return;
            }
            else
            {
                //insert unit
                db.excutedata("insert into units values("+txtunitnumber.Text+",N'"+txtunitname.Text.Trim()+"')", "تم الحفظ بنجاح");
                autonumber();
            }
        }

        private void tileItem4_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Close();
        }
 //update unit
        private void tileItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            if (txtunitname.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم الوحده اولا قبل الحفظ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            else
            {
                //updates in all tables that have this units
                db.excutedata("update units set unit_name=N'"+txtunitname.Text.Trim()+"' where unit_id="+dgv.CurrentRow.Cells[0].Value+"", "");
                db.excutedata("update buy_details set  unit_name=N'" + txtunitname.Text.Trim() + "' where unit_name=N'" + dgv.CurrentRow.Cells[1].Value+"'", "");
                db.excutedata("update item_card set  unit_name=N'" + txtunitname.Text.Trim() + "' where unit_name=N'" + dgv.CurrentRow.Cells[1].Value + "'", "");
                db.excutedata("update product_units set  unit_name=N'" + txtunitname.Text.Trim() + "' where unit_name=N'" + dgv.CurrentRow.Cells[1].Value + "'", "");
                db.excutedata("update return_details set  unit_name=N'" + txtunitname.Text.Trim() + "' where unit_name=N'" + dgv.CurrentRow.Cells[1].Value + "'", "");
                db.excutedata("update supplier_account set  unit=N'" + txtunitname.Text.Trim() + "' where unit=N'" + dgv.CurrentRow.Cells[1].Value + "'", "");
                db.excutedata("update products set main_unitname=N'"+txtunitname.Text.Trim()+"'   where main_unitid="+txtunitnumber.Text+"", "");
                db.excutedata("update products set sales_unitname=N'" + txtunitname.Text.Trim() + "'   where sales_unit_id=" + txtunitnumber.Text + "", "");
                db.excutedata("update products set buy_unitname=N'" + txtunitname.Text.Trim() + "'   where buy_unit_id=" + txtunitnumber.Text + "", "");

                MessageBox.Show("تم التعديل بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

                autonumber();
            }
        }

        //delete selected unit
        private void tileItem3_ItemClick(object sender, TileItemEventArgs e)
        {
            if (dgv.Rows.Count >= 1)
            {
                if (MessageBox.Show("هل انت متاكد من حذف الوحده", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.excutedata("delete from units where unit_id=" + dgv.CurrentRow.Cells[0].Value + "", "تم الحذف بنجاح");
                }
            }
        }
    }
}
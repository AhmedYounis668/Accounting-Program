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
    public partial class ddnewstore : DevExpress.XtraEditors.XtraForm
    {
        public ddnewstore()
        {
            InitializeComponent();
        }
        //call database class
        database db = new database();
        DataTable tbl = new DataTable();

        //autonumber
        private void autonumber()
        {
           // Select max id from store table
            tbl = db.readdata("select max(store_id)from stores", "");
            //check if cell of id in this table null or not
            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
               // if the cell of id null set textbox of id =1
               txtstore_id.Text = "1";
            }
            else
            {
                //else if this cell not null set the value of this cell=value+1 and set it in the textbox of id
                txtstore_id.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }
            //clear user data from form tools
            txtstorename.Clear();
            //get data of stores and show it in datagridview
            tbl.Clear();
            tbl = db.readdata("select store_id as 'رقم المخزن',store_name as 'اسم المخزن' from stores", "");
            dgv.DataSource = tbl;
            txtstorename.Focus();
        }

        private void tileItem4_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Close();
        }

        private void ddnewstore_Load(object sender, EventArgs e)
        {
            autonumber();
        }
        //insert
        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            if(txtstorename.Text=="")
            {
                MessageBox.Show("من فضلك ادخل اسم المخزن قبل الاضافه اولا", "خطا",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else
            {
                //insert store data
                db.excutedata("insert into stores values("+txtstore_id.Text+",N'"+txtstorename.Text.Trim()+"')", "تم الحفظ بنجاح");
                autonumber();
            }
        }
        //update 
        private void tileItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            if (dgv.Rows.Count >= 1)
            {
                if (txtstorename.Text == "")
                {
                    MessageBox.Show("من فضلك ادخل اسم المخزن قبل الاضافه اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    //update data of stores on all tables 
                    //update stores table
                    db.excutedata("update stores set store_name=N'" + txtstorename.Text.Trim() + "' where store_id=" +dgv.CurrentRow.Cells[0].Value + "", "");
                    //update item_card table
                    db.excutedata("update item_card set store_name=N'"+txtstorename.Text.Trim()+"' where store_id="+txtstore_id.Text+"", "");
                    //update buy_details
                    db.excutedata("update buy_details set store_name=N'" + txtstorename.Text.Trim() + "' where store_id=" + txtstore_id.Text + "", "");
                    //update returns_details table
                    db.excutedata("update return_details set store_name=N'" + txtstorename.Text.Trim() + "' where store_id=" + txtstore_id.Text + "", "");
                    //update returns table
                    db.excutedata("update returns set store_name=N'" + txtstorename.Text.Trim() + "' where store_id=" + txtstore_id.Text + "", "");
                    //update buy table
                    db.excutedata("update buy set store_name=N'" + txtstorename.Text.Trim() + "' where store_id=" + txtstore_id.Text + "", "");
                    MessageBox.Show("تم التعديل بنجاح", "تاكيد",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    autonumber();
                }
            }
        }
        //delete
        private void tileItem3_ItemClick(object sender, TileItemEventArgs e)
        {
            //delete the selection row from table
            if (dgv.Rows.Count >= 1)
            {

                db.excutedata("delete from stores where store_id="+dgv.CurrentRow.Cells[0].Value+"", "تم الحذف بنجاح");
                autonumber();
               
            }
        }
    }
}
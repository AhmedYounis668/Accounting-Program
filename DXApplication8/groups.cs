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
    public partial class groups : DevExpress.XtraEditors.XtraForm
    {
        public groups()
        {
            InitializeComponent();
        }
        //call database class
        DataTable tbl = new DataTable();
        database db = new database();
        //autonumber
        private void autonumber()
        {
            //get max id from groups table
            tbl = db.readdata("select max(group_id)from groups", "");
            //check if this id in the table have data or null
            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                //if there not data in the table textbox=>id set =1

                txtgroup_id.Text = "1";
            }
            else
            {
                //if the table have data get this number in cell id and set it +1

                txtgroup_id.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }
            txtgroup_name.Clear();
            //get data of groups and show it in datagridview
            tbl.Clear();
            tbl = db.readdata("select group_id as 'رقم القسم',group_name as 'اسم القسم' from groups", "");
            dgv.DataSource = tbl;
            txtgroup_name.Focus();
        }
        private void groups_Load(object sender, EventArgs e)
        {
            autonumber();
        }

        //add data
        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            if(txtgroup_name.Text=="")
            {
                MessageBox.Show("من فضلك ادخل اسم القسم اولا قبل الحفظ", "خطا",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else
            {
                //insert data in groups table
                db.excutedata("insert into groups values("+txtgroup_id.Text+",N'"+txtgroup_name.Text.Trim()+"')", "تم الحفظ بنجاح");
                autonumber();
            }
        }

        private void tileItem4_ItemClick(object sender, TileItemEventArgs e)
        {
            //close form
            this.Close();
        }

        //delete group
        private void tileItem3_ItemClick(object sender, TileItemEventArgs e)
        {
            if(dgv.Rows.Count>=1)
            {
                if(MessageBox.Show("هل انت متاكد من حذف القسم","تاكيد",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
                {
                    //delete
                    db.excutedata("delete from groups where group_id="+dgv.CurrentRow.Cells[0].Value+"", "تم الحذف بنجاح");
                    autonumber();
                }
            }
        }

        //update group in table from selected row in datagridview
        private void tileItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            if (dgv.Rows.Count >= 1)
            {
                if (txtgroup_name.Text == "")
                {
                    MessageBox.Show("من فضلك ادخل اسم القسم اولا قبل التعديل", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    //update
                    db.excutedata("update groups set group_name=N'" + txtgroup_name.Text.Trim() + "' where group_id=" + dgv.CurrentRow.Cells[0].Value + "", "تم التعديل بنجاح");
                    autonumber();
                }
            }
        }
    }
}
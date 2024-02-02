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
    public partial class suppliers : DevExpress.XtraEditors.XtraForm
    {
        public suppliers()
        {
            InitializeComponent();
        }
        //call database class
        DataTable tbl = new DataTable();
        database db = new database();
        //autonumber
        private void autonumber()
        {
            //get max id from suppliers data
            tbl = db.readdata("select max(sup_id)from suppliers", "");
            //if there is no data set textbox of id=1
            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                txtsup_id.Text = "1";
            }
            else
            {
                //if there is data set textbox of id =value +1
                txtsup_id.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }
            txtsup_name.Clear();
            txtaddress.Clear();
            txtidentityid.Clear();
            txtphone.Clear();
            txtsearch.Clear();
            txtnotes.Clear();
            //show the supplier data on datagridview
            tbl.Clear();
            tbl = db.readdata("select sup_id as 'رقم المورد',sup_name as'اسم المورد',phone as 'تليفون',address as 'العنوان',notes as 'ملاحظات',identity_id as'رقم تعريفي اخر',gov as 'المحافظه',city as 'المدينه',user_name as 'المستخدم',branch as 'الفرع'  from suppliers", "");
            dgv.DataSource = tbl;
        }


            private void suppliers_Load(object sender, EventArgs e)
        {
            autonumber();
        }

        private void tileItem4_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Close();
        }

        private void tileItem5_ItemClick(object sender, TileItemEventArgs e)
        {
            autonumber();
        }

        //insert supplier data
        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            //validations
            if(txtsup_name.Text=="")
            {
                MessageBox.Show("من فضلك ادخل اسم المورد اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(txtaddress.Text=="")
            {
                MessageBox.Show("من فضلك ادخل عنوان المورد اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(txtphone.Text=="")
            {
                MessageBox.Show("من فضلك ادخل تليفون المورد اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(txtidentityid.Text=="")
            {
                MessageBox.Show("من فضلك ادخل اي رقم تعريفي  للمورد اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //insert into supplier
                db.excutedata("insert into suppliers values("+txtsup_id.Text+",N'"+txtsup_name.Text.Trim()+"',N'"+txtphone.Text.Trim()+"',N'"+txtaddress.Text.Trim()+"',N'"+txtnotes.Text.Trim()+"',"+txtidentityid.Text.Trim()+",N'"+cbx_gov.Text.Trim()+"',N'"+cbxcity.Text.Trim()+"',N'"+Properties.Settings.Default.user_name+"',N'"+Properties.Settings.Default.branch_name+"')", "تم حفظ بيانات المورد بنجاح");
                autonumber();
            }
        }
        //search about suppliers
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readdata("select sup_id as 'رقم المورد',sup_name as'اسم المورد',phone as 'تليفون',address as 'العنوان',notes as 'ملاحظات',identity_id as'رقم تعريفي اخر',gov as 'المحافظه',city as 'المدينه',user_name as 'المستخدم',branch as 'الفرع'  from suppliers where sup_name like N'%"+txtsearch.Text.Trim()+"%'", "");
            dgv.DataSource = tbl;
        }
        //update supplier data
        private void tileItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            if(dgv.Rows.Count>=1)
            {
                db.excutedata("update suppliers set sup_name=N'"+dgv.CurrentRow.Cells[1].Value+"',phone=N'"+ dgv.CurrentRow.Cells[2].Value + "',address=N'"+ dgv.CurrentRow.Cells[3].Value + "',notes=N'"+ dgv.CurrentRow.Cells[4].Value + "',identity_id="+ dgv.CurrentRow.Cells[5].Value + ",gov=N'"+ dgv.CurrentRow.Cells[6].Value + "',city=N'"+ dgv.CurrentRow.Cells[7].Value + "',user_name=N'"+Properties.Settings.Default.user_name+"',branch=N'"+Properties.Settings.Default.branch_name+"' where sup_id="+dgv.CurrentRow.Cells[0].Value+"", "تم تعديل بيانات المورد بنجاح");
                autonumber();
            }
        }
    }
}
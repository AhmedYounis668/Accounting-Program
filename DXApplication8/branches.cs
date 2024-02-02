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
    public partial class branches : DevExpress.XtraEditors.XtraForm
    {
        public branches()
        {
            InitializeComponent();
        }
        //call database class
        DataTable tbl = new DataTable();
        database db = new database();

        //call max id from branches table to create autonumber

        private void autonumber()
            {
            //get last id in the table

            tbl = db.readdata("select max(branch_id)from branches", "");
                //check if this id in the table have data or null
            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                //if there not data in the table textbox=>id set =1

                txtbranch_id.Text = "1";
            }
            else
            {
                //if the table have data get this number in cell id and set it +1

                txtbranch_id.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }
            txtbranch_name.Clear();
            txtaddress.Clear();
            txtphine1.Clear();
            txtphone2.Clear();
            txtnotes.Clear();

            //show data of branches in datagridview
            tbl.Clear();
            tbl = db.readdata("select branch_id as 'رقم الفرع',branch_name as 'اسم الفرع',phone1 as 'تليفون1',phone2 as 'تليفون2',address as 'العنوان',notes as 'ملاحظات' ,gov as 'المحافظه',city as 'المدينه' from branches", "");
            dgv.DataSource = tbl;
        }
          

        private void txtbranch_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if user press enter
            if (e.KeyChar == 13)
            {
                txtphine1.Focus();
            }
        }

        private void branches_Load(object sender, EventArgs e)
        {
            autonumber();

        }

        private void tileItem5_ItemClick(object sender, TileItemEventArgs e)
        {
            autonumber();
        }

        private void tileItem4_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Close();
        }

        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            //validation to add
            if(txtbranch_name.Text=="")
            {
                MessageBox.Show("من فضلك ادخل اسم للفرع", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(txtphine1.Text=="")
            {
                MessageBox.Show("من فضلك ادخل تليفون1 للفرع", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(txtphone2.Text=="")
            {
                MessageBox.Show("من فضلك ادخل تليفون2 للفرع", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //insert data in branches table
                db.excutedata("insert into branches values("+txtbranch_id.Text+",N'"+txtbranch_name.Text.Trim()+"',N'"+txtphine1.Text.Trim()+"',N'"+txtphone2.Text.Trim()+"',N'"+txtaddress.Text.Trim()+"',N'"+txtnotes.Text.Trim()+ "',N'" + cbx_gov.Text.Trim() + "',N'" + cbxcity.Text.Trim()+"',N'"+Properties.Settings.Default.user_name+"',N'"+Properties.Settings.Default.branch_name+"')", "تم حفظ بيانات الفرع ىبنجاح");
                autonumber();
            }
        }

        private void tileItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            //update data of branches depending on datagridview and data shown in it
            if(dgv.Rows.Count>=1)
            {
                db.excutedata("update branches set branch_name=N'"+dgv.CurrentRow.Cells[1].Value+"',phone1=N'"+dgv.CurrentRow.Cells[2].Value+"',phone2=N'"+dgv.CurrentRow.Cells[3].Value+"',address=N'"+dgv.CurrentRow.Cells[4].Value+"',notes=N'"+dgv.CurrentRow.Cells[5].Value+"',gov=N'"+dgv.CurrentRow.Cells[6].Value+"',city=N'"+dgv.CurrentRow.Cells[7].Value+"' where branch_id="+dgv.CurrentRow.Cells[0].Value+"", "تم تعديل بيانات الفرع بنجاح");
                autonumber();
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            //search about brand depending on letter of his name
            tbl.Clear();
            tbl = db.readdata("select branch_id as 'رقم الفرع',branch_name as 'اسم الفرع',phone1 as 'تليفون1',phone2 as 'تليفون2',address as 'العنوان',notes as 'ملاحظات' ,gov as 'المحافظه',city as 'المدينه',user_name N'المستخدم الذي قام ب العمليه' from branches where branch_name like N'%"+txtsearch.Text.Trim()+"%'", "");
            dgv.DataSource = tbl;
        }
    }
}
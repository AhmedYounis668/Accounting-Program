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
    public partial class mandoup : DevExpress.XtraEditors.XtraForm
    {
        public mandoup()
        {
            InitializeComponent();
        }
        //call database class
        DataTable tbl = new DataTable();
        database db = new database();
        //autonumber
        private void autonumber()
        {
            //select max id from mandoup table
            tbl = db.readdata("select max(mandoup_id)from mandoup", "");
            //check if the table have data or null
            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                //if the the id cell null set the textbox of id=1
                txtmandoup_id.Text = "1";
            }
            else
            {
                //if the cell of id not null get the value of the cid cell and add on it 1
                txtmandoup_id.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }
            txtmandoup_name.Clear();
            txtphone1.Clear();
            txtphone2.Clear();

            //get all data of the table and show it in the datagridview
            tbl.Clear();
            tbl = db.readdata("select mandoup_id as 'رقم المندوب',mandoup_name as'اسم المندوب',phone1 as 'تليفون1',phone2 as 'تليفون2',notes as 'ملاحظات',gov as 'المحافظه',city as 'المدينه' from mandoup", "");
            dgv.DataSource = tbl;

            txtmandoup_name.Focus();
        }
        private void mandoup_Load(object sender, EventArgs e)
        {
            autonumber();
        }

        private void tileItem5_ItemClick(object sender, TileItemEventArgs e)
        {
            autonumber();
        }
        //add
        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            //validation to add
            if(txtmandoup_name.Text=="")
            {
                MessageBox.Show("من فضلك ادخل اسم المندوب اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(txtphone1.Text=="")
            {
                MessageBox.Show("من فضلك ادخل تليفون1 للمندوب اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(txtphone2.Text=="")
            {
                MessageBox.Show("من فضلك ادخل تليفون2 للمندوب اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //insert 
                db.excutedata("insert into mandoup values("+txtmandoup_id.Text+",N'"+txtmandoup_name.Text.Trim()+"',N'"+txtphone1.Text.Trim()+"',N'"+txtphone2.Text.Trim()+"',N'"+txtnotes.Text.Trim()+ "',N'" + cbx_gov.Text.Trim() + "',N'" + cbxcity.Text.Trim()+"',N'"+Properties.Settings.Default.user_name+"',N'"+Properties.Settings.Default.branch_name+"')", "تم حفظ بيانات المندوب بنجاح");
                autonumber();
            }
        }

        private void tileItem4_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Close();
        }
        //update
        private void tileItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            if(dgv.Rows.Count>=1)
            {
                //update
                db.excutedata("update mandoup set mandoup_name=N'"+dgv.CurrentRow.Cells[1].Value+"',phone1=N'"+dgv.CurrentRow.Cells[2].Value+"',phone2=N'"+dgv.CurrentRow.Cells[3].Value+"',notes=N'"+dgv.CurrentRow.Cells[4].Value+"',city=N'"+cbx_gov.Text.Trim()+"',gov=N'"+cbxcity.Text.Trim()+"' where mandoup_id="+dgv.CurrentRow.Cells[0].Value+" ", "تم تعديل بيانات المندوب بنجاح");
                autonumber();
            }
        }

        private void txtmandoup_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                txtphone1.Focus();
            }
        }

        private void txtphone1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtphone2.Focus();
            }
        }

        private void txtphone2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtnotes.Focus();
            }
        }
        //search
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            //search about one mandoup by the letter of his name
            tbl.Clear();
            tbl = db.readdata("select mandoup_id as 'رقم المندوب',mandoup_name as'اسم المندوب',phone1 as 'تليفون1',phone2 as 'تليفون2',notes as 'ملاحظات',gov as 'المحافظه',city as 'المدينه',user_name as 'من قام بالاضافه',branch_name as 'الفرع' from mandoup where mandoup_name like N'%"+txtsearch.Text.Trim()+"'", "");
            dgv.DataSource = tbl;
        }
    }
}
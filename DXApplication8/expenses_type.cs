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
    public partial class expenses_type : DevExpress.XtraEditors.XtraForm
    {
        public expenses_type()
        {
            InitializeComponent();
        }
        //call database class
        DataTable tbl = new DataTable();
        database db = new database();


        //auto number 
        private void autonumber()
        {
            //get the max id from deserved type table
            tbl = db.readdata("select max(type_id)from deserved_type", "");
            //check if the cell of id is null or not if null set textbox of id=1
            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                txttypenumber.Text = "1";
            }
            else
            {
                //else if not null set the textbox of id equal the value of max id +1 and 
                txttypenumber.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }
            txttypename.Clear();
            //get data of expenses type and show in datagridview
            tbl.Clear();
            tbl = db.readdata("select type_id as 'رقم النوع',type_name as 'اسم المصروف',notes as 'ملاحظات' from deserved_type", "");
            dgv.DataSource = tbl;
           txttypename.Focus();
        }
        private void tileItem4_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Close();
        }

        private void expenses_type_Load(object sender, EventArgs e)
        {
            autonumber();
        }

        //add type
        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            if(txttypename.Text=="")
            {
                MessageBox.Show("من فضلك ادخل اسم المصروف ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //insert type name in deserved_type table
                db.excutedata("insert into deserved_type values("+txttypenumber.Text+",N'"+txttypename.Text.Trim()+"',N'"+txtnotes.Text.Trim()+"',N'"+Properties.Settings.Default.user_name+"',N'"+Properties.Settings.Default.branch_name+"')", "تم الادخال");
                autonumber();
            }
        }

        //search about the type and show in datagridview
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readdata("select type_id as 'رقم النوع',type_name as 'اسم المصروف',notes as 'ملاحظات' from deserved_type where type_name like N'%"+txttypename.Text.Trim()+"%'", "");
            dgv.DataSource = tbl;
        }

        //update the type that selected in datagridview
        private void tileItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            if(dgv.Rows.Count>=1)
            {
                db.excutedata("update deserved_type set type_name=N'"+dgv.CurrentRow.Cells[1].Value+"',notes=N'"+dgv.CurrentRow.Cells[2].Value+"' where type_id="+txttypenumber.Text+"", "");
                autonumber();
            }
        }
    }
}
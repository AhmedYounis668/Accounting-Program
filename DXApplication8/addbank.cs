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
    public partial class addbank : DevExpress.XtraEditors.XtraForm
    {
        public addbank()
        {
            InitializeComponent();
        }

        //call class database
        DataTable tbl = new DataTable();
        database db = new database();

        //call max id from bankes table to create autonumber
        private void autonumber()
        {
            //get last id in the table
            tbl = db.readdata("select max(bank_id)from bankes", "");
            //check if this id in the table have data or null
            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                //if there not data in the table textbox=>id set =1
                txtbankid.Text = "1";
            }
            else
            {
                //if the table have data get this number in cell id and set it +1
                txtbankid.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }
            txtbankname.Clear();
            tbl.Clear();
            //get data and show it in datagridview
            tbl = db.readdata("select bank_id as 'رقم الخزنه',bank_name as 'اسم الخزنه',notes as 'ملاحظات',user_name as 'اسم المستخدم',branch_name as 'الفرع' from bankes", "");
            dgv.DataSource = tbl;
            txtnotes.Clear();
            txtbankname.Focus();
        }
        private void tileItem4_ItemClick(object sender, TileItemEventArgs e)
        {
            //to close window
            this.Close();
        }

        private void addbank_Load(object sender, EventArgs e)
        {
            dtp.Text = DateTime.Now.ToShortDateString();
            autonumber();
        }

        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            //validations
            tbl.Clear();
            tbl = db.readdata("select*from bankes where bank_id=" + txtbankid.Text + "", "");
            if (tbl.Rows.Count >= 1)
            {
                MessageBox.Show("هذا الرقم التسلسلي مستخدم من قبل", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string d = dtp.Value.ToString("yyyy-MM-dd");
            if (txtbankname.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم البنك", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //=====================================================
            else
            {
                //insert data to bankes table
                db.excutedata("insert into bankes values(" + txtbankid.Text + ",N'" + txtbankname.Text.Trim() + "',N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + d + "')", "تم الحفظ بنجاح");
                //autonumber after insert to clear data from the tools in the form
                autonumber();
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        { 
            //get data from bankes table to search about it
            tbl.Clear();
            tbl = db.readdata("select bank_id as 'رقم البنك',bank_name as 'اسم البنك',notes as 'ملاحظات',user_name as 'اسم المستخدم',branch_name as 'الفرع' from bankes where bank_name like N'%"+txtsearch.Text.Trim()+"%'", "");
            dgv.DataSource = tbl;
        }

        private void tileItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            //update data depending on the data shown in datagridview
            if(dgv.Rows.Count>=1)
            {
                db.excutedata("update bankes set bank_name=N'"+dgv.CurrentRow.Cells[1].Value+"' where bank_id="+dgv.CurrentRow.Cells[0].Value+"", "تم التعديل بنجاح");
                autonumber();
            }
        }
    }
}
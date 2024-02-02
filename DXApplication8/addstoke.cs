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
    public partial class addstoke : DevExpress.XtraEditors.XtraForm
    {
        public addstoke()
        {
            InitializeComponent();
        }

        //call database class
        DataTable tbl = new DataTable();
        database db = new database();


            //call max id from products table to create autonumber
        private void autonumber()
        {
            //get last id in the table

            tbl = db.readdata("select max(stoke_id)from stokes", "");
            //check if this id in the table have data or null

            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                //if there not data in the table textbox=>id set =1

                txtstoke_id.Text = "1";
            }
            else
            {
                //if the table have data get this number in cell id and set it +1

                txtstoke_id.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }
            txtstoke_name.Clear();
            //get data of stokes and show it in the datagridview
            tbl.Clear();
            tbl = db.readdata("select stoke_id as 'رقم الخزنه',stoke_name as 'اسم الخزنه',notes as 'ملاحظات',user_name as 'اسم المستخدم',branch_name as 'الفرع' from stokes", "");
            dgv.DataSource = tbl;
            txtnotes.Clear();
            txtstoke_name.Focus();
        }
        private void addstoke_Load(object sender, EventArgs e)
        {
            //set formate date
            dtp.Text = DateTime.Now.ToShortDateString();
            autonumber();
        }

        private void tileItem4_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Close();
        }

        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            //validation of stokes to add
            tbl.Clear();
            tbl = db.readdata("select*from stokes where stoke_id="+txtstoke_id.Text+"", "");
            if(tbl.Rows.Count>=1)
            {
                MessageBox.Show("", "تم اضافه خزنه بنفس الرقم التسلسلي الموجود هل انت تريد عمل تحديث اذا كنت تريد تحديث اضغط علي  زر update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //formate date
            string d = dtp.Value.ToString("yyyy-MM-dd");
            if(txtstoke_name.Text=="")
            {
                MessageBox.Show("من فضلك ادخل اسم الخزنه اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //insert data in stokes
                db.excutedata("insert into stokes values("+txtstoke_id.Text+",N'"+txtstoke_name.Text.Trim()+"',N'"+Properties.Settings.Default.user_name+"',N'"+Properties.Settings.Default.branch_name+"',N'"+txtnotes.Text.Trim()+"',N'"+d+"')", "تم حفظ الخزنه بنجاح");
                autonumber();
            }
        }

        private void tileItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            //update data of stokes
            if(dgv.Rows.Count>=1)
            {
                db.excutedata("update stokes set stoke_name=N'"+dgv.CurrentRow.Cells[1].Value+"' where stoke_id="+dgv.CurrentRow.Cells[0].Value+" ", "تم تعديل الخزنه بنجاح");
               
                autonumber();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //search about data depending on letter ofv his name
            tbl.Clear();
            tbl = db.readdata("select stoke_id as 'رقم الخزنه',stoke_name as 'اسم الخزنه',notes as 'ملاحظات',user_name as 'اسم المستخدم',branch_name as 'الفرع' from stokes where stoke_name like N'%"+textBox1.Text.Trim()+"%'", "");
            dgv.DataSource = tbl;
        }
    }
}
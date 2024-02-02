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
    public partial class transfer_products_between_store_report : DevExpress.XtraEditors.XtraForm
    {
        public transfer_products_between_store_report()
        {
            InitializeComponent();
        }

        database db = new database();
        DataTable tbl = new DataTable();

        private void fillcbx()
        {
            cbxproduct.DataSource = db.readdata("select*from products", "");
            cbxproduct.DisplayMember = "product_name";
            cbxproduct.ValueMember = "product_id";

            cbxstore1.DataSource = db.readdata("select*from branches", "");
            cbxstore1.DisplayMember = "branch_name";
            cbxstore1.ValueMember = "branch_id";

            cbxstoreto.DataSource = db.readdata("select*from branches", "");
            cbxstoreto.DisplayMember = "branch_name";
            cbxstoreto.ValueMember = "branch_id";
        }
        private void transfer_products_between_store_report_Load(object sender, EventArgs e)
        {
            fillcbx();
            dtpfrom.Text = DateTime.Now.ToShortDateString();
            dtpto.Text = DateTime.Now.ToShortDateString();

        }

        private void total()
        {
            decimal totalmoney = 0;

            for (int i = 0; i <= dgv.Rows.Count - 1;i ++)
            {
                totalmoney += Convert.ToDecimal(dgv.Rows[i].Cells[3].Value);
            }
            lblqty.Text = totalmoney.ToString();
        }
            private void btnsearch_Click(object sender, EventArgs e)
        {
            string dfrom = "", dto = "";
            dfrom = dtpfrom.Value.ToString("yyyy-MM-dd");
            dto = dtpto.Value.ToString("yyyy-MM-dd");
            if (radiofromstoretostore.Checked == true)
            {
                if (cbxstore1.Text == cbxstoreto.Text)
                {
                    MessageBox.Show("من فضلك حدد مخزننين مختلفين", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    tbl.Clear();
                    tbl = db.readdata("select order_id as'رقم العمليه',ezn_number as'رقم الاذن',pro_name as'اسم المنتج',Qty as'الكميه',unit as'الوحده',store_name_from as'محول من مخزن',store_name_to as'محول الي مخزن',notes as'ملاحظات',date as'التاريخ',user_name as'المستخدم',branch_name as'الفرع' from transfereproductsbetweenstores where store_id_from=" + cbxstore1.SelectedValue + " and store_id_to=" + cbxstoreto.SelectedValue + " and convert(nvarchar,date,105)between N'" + dfrom + "' and N'" + dto + "'", "");
                    dgv.DataSource = tbl;
                }
            }
            else if (radioalltransferes.Checked == true)
            {
                tbl.Clear();
                tbl = db.readdata("select order_id as'رقم العمليه',ezn_number as'رقم الاذن',pro_name as'اسم المنتج',Qty as'الكميه',unit as'الوحده',store_name_from as'محول من مخزن',store_name_to as'محول الي مخزن',notes as'ملاحظات',date as'التاريخ',user_name as'المستخدم',branch_name as'الفرع' from transfereproductsbetweenstores where  convert(nvarchar,date,105)between N'" + dfrom + "' and N'" + dto + "'", "");
                dgv.DataSource = tbl;
            }
            else if (radiotransfereoneproduct.Checked == true)
            {
                tbl.Clear();
                tbl = db.readdata("select order_id as'رقم العمليه',ezn_number as'رقم الاذن',pro_name as'اسم المنتج',Qty as'الكميه',unit as'الوحده',store_name_from as'محول من مخزن',store_name_to as'محول الي مخزن',notes as'ملاحظات',date as'التاريخ',user_name as'المستخدم',branch_name as'الفرع' from transfereproductsbetweenstores where pro_id=" + cbxproduct.SelectedValue + "  and convert(nvarchar,date,105)between N'" + dfrom + "' and N'" + dto + "'", "");
                dgv.DataSource = tbl;
            }
            total();
        }
    }
}
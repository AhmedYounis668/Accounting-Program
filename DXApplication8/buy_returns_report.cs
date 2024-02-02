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
    public partial class buy_returns_report : DevExpress.XtraEditors.XtraForm
    {
        public buy_returns_report()
        {
            InitializeComponent();
        }

        //call database class
        DataTable tbl = new DataTable();
        database db = new database();
        //fill combobox of branches
        private void fillcbx()
        {
            cbxbranchname.DataSource = db.readdata("select*from branches", "");
            cbxbranchname.DisplayMember = "branch_name";
            cbxbranchname.ValueMember = "branch_id";
        }
        private void buy_returns_report_Load(object sender, EventArgs e)
        {
            dtpfrom.Text = DateTime.Now.ToShortDateString();
            dtpto.Text = DateTime.Now.ToShortDateString();
            fillcbx();
        }

        //make func to get total of purchases returns
        private void total()
        {
            //set formate date
            string dfrom = "", dto = "";
            dfrom = dtpfrom.Value.ToString("yyyy-MM-dd");
            dto = dtpto.Value.ToString("yyyy-MM-dd");
            DataTable tbltotal = new DataTable();
            tbltotal.Clear();
            tbltotal = db.readdata("select*from returns where convert(nvarchar,date,105)between N'" + dfrom + "' and N'" + dto + "' and branch_name=N'" + cbxbranchname.Text.Trim() + "'", "");
            decimal total = 0;
            for (int i = 0; i <= tbltotal.Rows.Count - 1; i++)
            {
                total += Convert.ToDecimal(tbltotal.Rows[i][5]);
            }
            txttotalreturns.Text = total.ToString();
        }
        //buton to search about purchases returns data
        private void btnsearch_Click(object sender, EventArgs e)
        {
            string from = "", to = "";
            from = dtpfrom.Value.ToString("yyyy-MM-dd");
            to = dtpto.Value.ToString("yyyy-MM-dd");
            tbl.Clear();
            tbl = db.readdata("select order_id as 'رقم البيان',suppliers.sup_name as 'المورد',products.product_name as 'اسم المنتج',Qty as 'الكميه',unit_name as 'الوحده',return_details.price_tax as 'السعر',total as 'الاجمالي',totalorder as 'الاجمالي الكلي',discountontotalorder as 'الخصم',notes_item as 'ملاحظات صنف',return_details.notes as 'ملاحظات',store_name as'المخزن',branch_name as'الفرع',return_details.user_name as 'المستخدم' from return_details,suppliers,products where return_details.sup_id=suppliers.sup_id and products.product_id=return_details.product_id and convert(nvarchar,return_details.date,105)between N'"+from+"' and N'"+to+"' and branch_name=N'"+cbxbranchname.Text.Trim()+"' ", "");
            dgv.DataSource = tbl;
            total();
        }
    }
}
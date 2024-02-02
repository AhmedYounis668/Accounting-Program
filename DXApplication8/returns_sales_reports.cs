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
    public partial class returns_sales_reports : DevExpress.XtraEditors.XtraForm
    {
        public returns_sales_reports()
        {
            InitializeComponent();
        }
        //call database class
        DataTable tbl = new DataTable();
        database db = new database();

        //fill combobox with branches
        private void fillcbx()
        {
            cbxbranchname.DataSource = db.readdata("select*from branches", "");
            cbxbranchname.DisplayMember = "branch_name";
            cbxbranchname.ValueMember = "branch_id";
        }
        private void returns_sales_reports_Load(object sender, EventArgs e)
        {
            dtpfrom.Text = DateTime.Now.ToShortDateString();
            dtpto.Text = DateTime.Now.ToShortDateString();
            fillcbx();
       }

        //calculate the total of sales returns  bills
        private void total()
        {
            string dfrom = "", dto = "";
            dfrom = dtpfrom.Value.ToString("yyyy-MM-dd");
            dto = dtpto.Value.ToString("yyyy-MM-dd");
             DataTable tbltotal = new DataTable();
            tbltotal.Clear();
            tbltotal = db.readdata("select*from returns_sales where convert(nvarchar,date,105)between N'"+dfrom+"' and N'"+dto+"' and branch_name=N'"+cbxbranchname.Text.Trim()+"'", "");
            decimal total = 0;
            for(int i=0;i<=tbltotal.Rows.Count-1;i++)
            {
                total += Convert.ToDecimal(tbltotal.Rows[i][5]);
            }
            txttotalreturns.Text = total.ToString();
        }
        //search about the sales returns bills between deferent time
        private void btnsearch_Click(object sender, EventArgs e)
        {
            string dfrom = "", dto = "";
            dfrom = dtpfrom.Value.ToString("yyyy-MM-dd");
            dto = dtpto.Value.ToString("yyyy-MM-dd");
            tbl.Clear();
            tbl = db.readdata("select return_details_sales.date as 'تاريخ المرتجع',return_details_sales.time as 'الوقت', order_id as 'رقم البيان',customers.cust_name as 'العميل',pro_name as 'اسم المنتج',Qty as 'الكميه',unit_name as 'الوحده',price_tax as 'السعر',total as 'الاجمالي',discountontotalorder as 'الخصم الكلي',totalorder as 'الاجمالي الكلي',return_details_sales.branch_name as 'الفرع',return_details_sales.user_name as 'المستخدم',notes_item as 'ملاحظات صنف',return_details_sales.notes as 'ملاحظات عامه',store_name as 'المخزن' from return_details_sales,customers where return_details_sales.cust_id=customers.cust_id and convert(nvarchar,return_details_sales.date,105)between N'"+dfrom+"' and N'"+dto+"' and branch_name=N'"+cbxbranchname.Text.Trim()+"'", "");
            dgv.DataSource = tbl;
            total();
        }
    }
}
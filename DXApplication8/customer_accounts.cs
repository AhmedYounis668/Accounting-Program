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
    public partial class customer_accounts : DevExpress.XtraEditors.XtraForm
    {
        public customer_accounts()
        {
            InitializeComponent();
        }
        //call database class
        DataTable tbl = new DataTable();
        database db = new database();
        //fill combobox of suppliers
        private void fillcbx()
        {
            cbxcustomer.DataSource = db.readdata("select*from customers", "");
            cbxcustomer.DisplayMember = "cust_name";
            cbxcustomer.ValueMember = "cust_id";

        }
        private void customer_accounts_Load(object sender, EventArgs e)
        {
            dtpfrom.Text = DateTime.Now.ToShortDateString();
            dtpto.Text = DateTime.Now.ToShortDateString();
            fillcbx();
        }

        private void txt_write_customer_TextChanged(object sender, EventArgs e)
        {
            //get the customer acount by writining customer name
            if(radiocustname.Checked==true)
            {
                
                tbl.Clear();
                tbl = db.readdata("select cust_id as 'رقم العميل',cust_name as 'اسم العميل', phone as 'التليفون',address as 'العنوان',notes as 'ملاحظات',identity_id as 'الرقم التعريفي' from customers where cust_name like N'%"+txt_write_customer.Text.Trim()+"%'", "");
                dgv.DataSource = tbl;
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string dfrom = "", dto = "";
            dfrom = dtpfrom.Value.ToString("yyyy-MM-dd");
            dto = dtpto.Value.ToString("yyyy-MM-dd");
            //get data of all customer account 
            if (radiocustomerall.Checked == true)
            {

                tbl.Clear();
                tbl = db.readdata("select SUM(on_him) as 'له',sum (sadad) as 'سداد',SUM(on_him)-sum (sadad) as 'المتبقي',customer_account.cust_id as 'رقم العميل',(select customers.cust_name  from customers where customers.cust_id=customer_account.cust_id)as 'اسم العميل' from customer_account group by(customer_account.cust_id)   ", "");
                dgv.DataSource = tbl;

                decimal total = 0;
                for (int i = 0; i <= dgv.Rows.Count - 1; i++)
                {
                    total += Convert.ToDecimal(dgv.Rows[i].Cells[2].Value);
                }
                txttotal.Text = total.ToString();
            }

            //get data of selected customer
            else if (radioselectone.Checked == true)
            {
                tbl.Clear();
                tbl = db.readdata("select order_id as 'رقم البيان',cust_name as 'اسم العميل',discription as 'البيا--------ن',pro_name as 'الصنف',Qty as 'الكميه',unit_name as 'الوحده',total as 'الاجمالي',totalorder as 'الاجمالي الكلي',date as 'التاريخ',on_him as 'عليه',sadad as 'السداد',notes as 'ملاحظات',user_name as 'المستخدم',branch_name as 'الفرع',type as 'النوع' from customer_account where cust_id=" + cbxcustomer.SelectedValue + " order by date", "");
                dgv.DataSource = tbl;

                decimal aleh = 0, sadad = 0, final = 0;
                for (int i = 0; i <= dgv.Rows.Count - 1; i++)
                {
                    aleh += Convert.ToDecimal(dgv.Rows[i].Cells[9].Value);
                    sadad += Convert.ToDecimal(dgv.Rows[i].Cells[10].Value);
                }
                final += aleh - sadad;
                txttotal.Text = final.ToString();
            }
            //get data o0f customer account by customer name
            else if (radiocustname.Checked == true)
            {
                if (dgv.Rows.Count >= 1)
                {
                    int cust_id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                    tbl.Clear();
                    tbl = db.readdata("select order_id as 'رقم البيان',cust_name as 'اسم العميل',discription as 'البيا--------ن',pro_name as 'الصنف',Qty as 'الكميه',unit_name as 'الوحده',total as 'الاجمالي',totalorder as 'الاجمالي الكلي',date as 'التاريخ',on_him as 'عليه',sadad as 'السداد',notes as 'ملاحظات',user_name as 'المستخدم',branch_name as 'الفرع',type as 'النوع' from customer_account where cust_id= " + cust_id + " order by date", "");
                    dgv.DataSource = tbl;


                    decimal aleh = 0, sadad = 0, final = 0;
                    for (int i = 0; i <= dgv.Rows.Count - 1; i++)
                    {
                        aleh += Convert.ToDecimal(dgv.Rows[i].Cells[9].Value);
                        sadad += Convert.ToDecimal(dgv.Rows[i].Cells[10].Value);
                    }
                    final += aleh - sadad;
                    txttotal.Text = final.ToString();
                }
            }
            //get customer account by date
            else if (radiofatra.Checked == true)
            {
                tbl.Clear();
                tbl = db.readdata("select order_id as 'رقم البيان',cust_name as 'اسم العميل',discription as 'البيان',pro_name as 'الصنف',Qty as 'الكميه',unit_name as 'الوحده',total as 'الاجمالي',totalorder as 'الاجمالي الكلي',date as 'التاريخ',on_him as 'عليه',sadad as 'السداد',notes as 'ملاحظات',user_name as 'المستخدم',branch_name as 'الفرع',type as 'النوع' from customer_account where cust_id=" + cbxcustomer.SelectedValue + " and convert(nvarchar,date,105)between N'" + dfrom + "' and N'" + dto + "'order by date", "");
                dgv.DataSource = tbl;

                decimal aleh = 0, sadad = 0, final = 0;
                for (int i = 0; i <= dgv.Rows.Count - 1; i++)
                {
                    aleh += Convert.ToDecimal(dgv.Rows[i].Cells[9].Value);
                    sadad += Convert.ToDecimal(dgv.Rows[i].Cells[10].Value);
                }
                final += aleh - sadad;
                txttotal.Text = final.ToString();
            
            }
        
        }

        //delete sadad from this account
        private void btndeleteselectedsadad_Click(object sender, EventArgs e)
        {
            if(dgv.Rows.Count>=1)
            {
                if (MessageBox.Show("-تنبيه الخزنه لم تتاثر ب اي شي وهذا السداد لم يصرف من الخزنه الا بعمليه سحب من المستخدم ----هل انت متاكد من مسح هذا السداد؟", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //insert deleted sadad into sandat detleted
                    string type = "سند قبض محذوف";
                    int order_id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                    db.excutedata("insert into sandat_deleted values("+dgv.CurrentRow.Cells[0].Value+",N'"+dgv.CurrentRow.Cells[1].Value+"',N'"+Properties.Settings.Default.user_name+"',N'"+Properties.Settings.Default.branch_name+"',"+dgv.CurrentRow.Cells[10].Value+",N'"+type+"',N'عميل')", "");
                    //delete this sand from customer customer , sand kabd , stoke insert
                    db.excutedata("delete from customer_account where order_id=" + order_id + " and type=N'سداد'", "تم مسح السداد المحدد بنجاح والخزنه لم تتاثر ب اي شي");
                    db.excutedata("delete from sand_kabd where order_id="+order_id+"", "");
                    db.excutedata("delete from stoke_insert where order_id="+order_id+"", "");
                    //get search after deleteing
                    btnsearch_Click(null, null);
                }
            }
        }

        //get all sandat deleted
        private void btnsandat_deleted_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readdata("select order_id as 'رقم السند',person_name as 'اسم المورد',user_name as 'المستخدم',branch as 'الفرع',money as 'المبلخ',type as 'ملحوظه',type2 as 'سند محذوف ل' from sandat_deleted where type2=N'عميل'", "");
            dgv.DataSource = tbl;
        }

        private void btnsearchbranchses_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        //get the details of data of bill selected 
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count >= 1)
            {
                int order_id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                tbl.Clear();
                tbl = db.readdata("select order_id as 'رقم الفاتوره',pro_id as 'رقم الصنف',pro_name as 'اسم الصنف',customers.cust_name as 'اسم العميل',Qty as 'الكميه',unit as 'الوحده',price as 'السعر',discountonallorder as 'الخصم',total as 'الاجمالي',totalorder as 'الاجمالي الكلي',date as 'التاريخ',branch_name as 'الفرع',sales_details.user_name as 'المستخدم',mandoup_name as 'المندوب',store_name as 'المخزن'from sales_details,customers where sales_details.cust_id=customers.cust_id and order_id="+order_id+"", "");
                dgv1.DataSource = tbl;
                panel1.Visible = true;

            }
            }

        //printing the bill
        private void btnprint_Click(object sender, EventArgs e)
        {
            if (radioselectone.Checked == true && cbxcustomer.Text != "")
            {
                try
                {
                    //customer id
                    int cust_id = Convert.ToInt32(cbxcustomer.SelectedValue);
                    //quary
                    DataTable tblprint = new DataTable();
                    tblprint.Clear();
                    tblprint = db.readdata("select settingprinting_bills.logo as 'اللوجو',settingprinting_bills.name as 'اسم الشركه',settingprinting_bills.address as 'العنوان',settingprinting_bills.discription as 'جمله',settingprinting_bills.phone1 as 'فون1',settingprinting_bills.phone2 as'فون2',settingprinting_bills.phone3 as 'فون3',settingprinting_bills.commerical_re as 'الرقم التجاري',settingprinting_bills.tax_re as 'الرقم الضريبي',order_id as 'رقم البيان',cust_id as 'رقم العميل',cust_name as 'اسم العميل',customer_account.discription as 'البيان',pro_name as 'الصنف',Qty as'الكميه', unit_name as 'الوحده',total as'الاجمالي', totalorder as'الاجمالي الكلي',on_him as'عليه',sadad as 'السداد',note_items as'ملاحظه صنف',notes as 'ملاحظات عامه',user_name as 'المستخدم',branch_name as'الفرع',date as'التاريخ' from customer_account,settingprinting_bills where cust_id=" + cust_id + " order by date", "");
                    //open printing form
                    printing frm = new printing();
                    frm.crystalReportViewer1.RefreshReport();

                    //open report
                    customer_account_print rpt = new customer_account_print();
                    rpt.SetDatabaseLogon("", "", Properties.Settings.Default.servername, Properties.Settings.Default.databasename);
                    rpt.SetDataSource(tblprint);
                    //parameters
                    rpt.SetParameterValue("cust_id", cust_id);

                    frm.crystalReportViewer1.ReportSource = rpt;
                    frm.ShowDialog();
                    //System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                    //rpt.PrintOptions.PrinterName = Properties.Settings.Default.printername;
                    //rpt.PrintToPrinter(1, true, 0, 0);
                }
                catch (Exception) { }
            }
            else
            {
                MessageBox.Show("من فضلك حدد العميل اولا ثم اختاره", "خطا في استعراض البيانات",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
        }

        //deleting old mony الرصيد السابق
        private void btndeleteoldmoney_Click(object sender, EventArgs e)
        {
            if(dgv.Rows.Count>=1)
            {
                int order_id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                db.excutedata("delete from customer_account where order_id="+order_id+" ", "تم الحذف بنجاح");
            }
        }
    }
}
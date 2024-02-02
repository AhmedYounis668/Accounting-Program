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
    public partial class buy_reports : DevExpress.XtraEditors.XtraForm
    {
        public buy_reports()
        {
            InitializeComponent();
        }
        //call class database
        DataTable tbl = new DataTable();
        database db = new database();

        //fill combobox of branches and suppliers
        private void fillcbx()
        {
            cbxsuppliers.DataSource = db.readdata("select*from suppliers ", "");
            cbxsuppliers.DisplayMember = "sup_name";
            cbxsuppliers.ValueMember = "sup_id";

            cbxbranchname.DataSource = db.readdata("select*from branches", "");
            cbxbranchname.DisplayMember = "branch_name";
            cbxbranchname.ValueMember = "branch_id";
        }
        private void buy_reports_Load(object sender, EventArgs e)
        {
            fillcbx();
            string from = dtpfrom.Value.ToString("yyyy-MM-dd");
            string to = dtpto.Value.ToString("yyyy-MM-dd");


        }

        //total of report
        private void total()
        {
            decimal totalmoney = 0;
            for(int i=0;i<=dgv.Rows.Count-1;i++)
            {
                totalmoney += Convert.ToDecimal(dgv.Rows[i].Cells[9].Value)- Convert.ToDecimal(dgv.Rows[i].Cells[8].Value);
            }
            txttotalpurchases.Text = totalmoney.ToString();
        }

        //search about suppliers in datagridview with the lettter of his name
        private void txtsupname_TextChanged(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readdata("select sup_id as 'رقم المورد',sup_name as 'اسم المورد' from suppliers where sup_name like N'%"+txtsupname.Text.Trim()+"%'", "");
            dgvsearchforproducts.DataSource = tbl;
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            //set formate date
            string from = "", to = "";
            from = dtpfrom.Value.ToString("yyyy-MM-dd");
            to = dtpto.Value.ToString("yyyy-MM-dd");
            if(radioallsupplier.Checked==false&&radioonesupplier.Checked==false&&radiosuppname.Checked==false&&radiosearchwithproduct_name.Checked==false)
            {
                MessageBox.Show("من فضلك حدد عمليه اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //select operation to search
                //search about all bill for all suppliers
                if (radioallsupplier.Checked == true)
                {
                    tbl.Clear();
                    tbl = db.readdata("select order_id as 'رقم الفاتوره',ezn_id as 'رقم الاذن',suppliers.sup_name as 'المورد',products.product_name as 'اسم المنتج',buy_details.Qty as 'الكميه',unit_name as 'الوحده',price_tax as 'السعر',discount as 'خصم صنف',discountontotalorder as 'الخصم ع اجمالي الفاتوره',total as 'القيمه',totalorder as 'الاجمالي الكلي',buy_details.date as 'التاريخ',time as 'الوقت',notes_item as 'ملاحظات ع الصنف',buy_details.notes as 'ملاحظات عامه',type as 'نوع الفاتوره',mandoup_name as 'المندوب',buy_details.user_name as 'المستخدم',store_name as 'المخزن' ,branch_name as 'الفرع'from buy_details,suppliers,products where buy_details.sup_id=suppliers.sup_id and buy_details.product_id=products.product_id and convert(nvarchar,buy_details.date,105)between N'" + from + "' and N'" + to + "'", "");
                    dgv.DataSource = tbl;
                }
                //search about all bills for one suppliers
                else if (radioonesupplier.Checked == true)
                {
                    tbl.Clear();
                    tbl = db.readdata("select order_id as 'رقم الفاتوره',ezn_id as 'رقم الاذن',suppliers.sup_name as 'المورد',products.product_name as 'اسم المنتج',buy_details.Qty as 'الكميه',unit_name as 'الوحده',price_tax as 'السعر',discount as 'خصم صنف',discountontotalorder as 'الخصم ع اجمالي الفاتوره',total as 'القيمه',totalorder as 'الاجمالي الكلي',buy_details.date as 'التاريخ',time as 'الوقت',notes_item as 'ملاحظات ع الصنف',buy_details.notes as 'ملاحظات عامه',type as 'نوع الفاتوره',mandoup_name as 'المندوب',buy_details.user_name as 'المستخدم',store_name as 'المخزن' ,branch_name as 'الفرع'from buy_details,suppliers,products where buy_details.sup_id=suppliers.sup_id and buy_details.product_id=products.product_id and convert(nvarchar,buy_details.date,105)between N'" + from + "' and N'" + to + "' and buy_details.sup_id=" + cbxsuppliers.SelectedValue + "", "");
                    dgv.DataSource = tbl;
                }
                //search about bills of one suuppliers by search of name of suppliers
                else if (radiosuppname.Checked == true)
                {
                    if (dgvsearchforproducts.Rows.Count >= 1)
                    {
                        int sup_id = Convert.ToInt32(dgvsearchforproducts.CurrentRow.Cells[0].Value);
                        tbl.Clear();
                        tbl = db.readdata("select order_id as 'رقم الفاتوره',ezn_id as 'رقم الاذن',suppliers.sup_name as 'المورد',products.product_name as 'اسم المنتج',buy_details.Qty as 'الكميه',unit_name as 'الوحده',price_tax as 'السعر',discount as 'خصم صنف',discountontotalorder as 'الخصم ع اجمالي الفاتوره',total as 'القيمه',totalorder as 'الاجمالي الكلي',buy_details.date as 'التاريخ',time as 'الوقت',notes_item as 'ملاحظات ع الصنف',buy_details.notes as 'ملاحظات عامه',type as 'نوع الفاتوره',mandoup_name as 'المندوب',buy_details.user_name as 'المستخدم',store_name as 'المخزن' ,branch_name as 'الفرع'from buy_details,suppliers,products where buy_details.sup_id=suppliers.sup_id and buy_details.product_id=products.product_id and convert(nvarchar,buy_details.date,105)between N'" + from + "' and N'" + to + "' and buy_details.sup_id=" + sup_id + "", "");
                        dgv.DataSource = tbl;
                    }
                }
                //search about pruchases of selected product
                else if (radiosearchwithproduct_name.Checked == true)
                {
                    if (dgvsearchforproducts.Rows.Count >= 1)
                    {
                        int pro_id = Convert.ToInt32(dgvsearchforproducts.CurrentRow.Cells[0].Value);
                        tbl.Clear();
                        tbl = db.readdata("select order_id as 'رقم الفاتوره',ezn_id as 'رقم الاذن',suppliers.sup_name as 'المورد',products.product_name as 'اسم المنتج',buy_details.Qty as 'الكميه',unit_name as 'الوحده',price_tax as 'السعر',discount as 'خصم صنف',discountontotalorder as 'الخصم ع اجمالي الفاتوره',total as 'القيمه',totalorder as 'الاجمالي الكلي',buy_details.date as 'التاريخ',time as 'الوقت',notes_item as 'ملاحظات ع الصنف',buy_details.notes as 'ملاحظات عامه',type as 'نوع الفاتوره',mandoup_name as 'المندوب',buy_details.user_name as 'المستخدم',store_name as 'المخزن' ,branch_name as 'الفرع'from buy_details,suppliers,products where buy_details.sup_id=suppliers.sup_id and buy_details.product_id=products.product_id and convert(nvarchar,buy_details.date,105)between N'" + from + "' and N'" + to + "' and buy_details.product_id=" + pro_id+ "", "");
                        
                        dgv.DataSource = tbl;
                    }
                }
                total();
            }
        }

        //search about one bill by id of this bill
        private void txtnoofbills_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if user enter the id of the bill and enter press
            if (e.KeyChar == 13)
            {
                //validations
                if (txtnoofbills.Text == "")
                {
                    MessageBox.Show("من فضلك ادخل رقم الفاتوره اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if(checknomberofbill.Checked==false)
                {
                    MessageBox.Show("من فضلك حدد عمليه البحث اولا --اضغط علامه صح علي بحث برقم الفاتوره", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    //get data and show it in datagridview
                    tbl.Clear();
                    tbl = db.readdata("select order_id as 'رقم الفاتوره',ezn_id as 'رقم الاذن',suppliers.sup_name as 'المورد',products.product_name as 'اسم المنتج',buy_details.Qty as 'الكميه',unit_name as 'الوحده',price_tax as 'السعر',discount as 'خصم صنف',discountontotalorder as 'الخصم ع اجمالي الفاتوره',total as 'القيمه',totalorder as 'الاجمالي الكلي',buy_details.date as 'التاريخ',time as 'الوقت',notes_item as 'ملاحظات ع الصنف',buy_details.notes as 'ملاحظات عامه',type as 'نوع الفاتوره',mandoup_name as 'المندوب',store_name as 'المخزن' ,branch_name as 'الفرع'from buy_details,suppliers,products where buy_details.sup_id=suppliers.sup_id and buy_details.product_id=products.product_id and order_id="+txtnoofbills.Text+"", "");
                    dgv.DataSource = tbl;
                    total();
                }
            }
        }

        //if user enter the ezn number
        private void txtsearchwithezn_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if user enter the ezn number and press enter
            if (e.KeyChar == 13)
            {
                //validation
                if (txtsearchwithezn.Text == "")
                {
                    MessageBox.Show("من فضلك ادخل رقم الفاتوره اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (checkezn.Checked == false)
                {
                    MessageBox.Show(" من فضلك حدد عمليه البحث اولا --اضغط علامه صح علي بحث برقم الاذن", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    //get data and show it in datagridview
                    tbl.Clear();
                    tbl = db.readdata("select order_id as 'رقم الفاتوره',ezn_id as 'رقم الاذن',suppliers.sup_name as 'المورد',products.product_name as 'اسم المنتج',buy_details.Qty as 'الكميه',unit_name as 'الوحده',price_tax as 'السعر',discount as 'خصم صنف',discountontotalorder as 'الخصم ع اجمالي الفاتوره',total as 'القيمه',totalorder as 'الاجمالي الكلي',buy_details.date as 'التاريخ',time as 'الوقت',notes_item as 'ملاحظات ع الصنف',buy_details.notes as 'ملاحظات عامه',type as 'نوع الفاتوره',mandoup_name as 'المندوب',store_name as 'المخزن' ,branch_name as 'الفرع'from buy_details,suppliers,products where buy_details.sup_id=suppliers.sup_id and buy_details.product_id=products.product_id and buy_details.ezn_id=" + txtsearchwithezn.Text + "", "");
                    dgv.DataSource = tbl;
                    total();
                }
            }
        }

        //search about product by the letter of the product name
        private void txtpronamesearch_TextChanged(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readdata("select product_id as 'رقم المنتج',product_name as 'اسم المنتج' from products where product_name like N'%"+txtpronamesearch.Text.Trim()+"%'", "");
            dgvsearchforproducts.DataSource = tbl;
        }

        private void btnsearchbranchses_Click(object sender, EventArgs e)
        {
            string from = "", to = "";
            from = dtpfrom.Value.ToString("yyyy-MM-dd");
            to = dtpto.Value.ToString("yyyy-MM-dd");
            //search by branch name about all suppliers bill
            if (radioallsuppliersinselectedbranch.Checked == true)
            {
                tbl.Clear();
                tbl = db.readdata("select order_id as 'رقم الفاتوره',ezn_id as 'رقم الاذن',suppliers.sup_name as 'المورد',products.product_name as 'اسم المنتج',buy_details.Qty as 'الكميه',unit_name as 'الوحده',price_tax as 'السعر',discount as 'خصم صنف',discountontotalorder as 'الخصم ع اجمالي الفاتوره',total as 'القيمه',totalorder as 'الاجمالي الكلي',buy_details.date as 'التاريخ',time as 'الوقت',notes_item as 'ملاحظات ع الصنف',buy_details.notes as 'ملاحظات عامه',type as 'نوع الفاتوره',mandoup_name as 'المندوب',buy_details.user_name as 'المستخدم',store_name as 'المخزن' ,branch_name as 'الفرع'from buy_details,suppliers,products where buy_details.sup_id=suppliers.sup_id and buy_details.product_id=products.product_id and convert(nvarchar,buy_details.date,105)between N'" + from + "' and N'" + to + "' and buy_details.branch_name=N'"+cbxbranchname.Text+"'", "");
                dgv.DataSource = tbl;
            }
            //search about one suppliers in selected branch
            else if (radiosupplierselectedinbranchselected.Checked == true)
            {
                tbl.Clear();
                tbl = db.readdata("select order_id as 'رقم الفاتوره',ezn_id as 'رقم الاذن',suppliers.sup_name as 'المورد',products.product_name as 'اسم المنتج',buy_details.Qty as 'الكميه',unit_name as 'الوحده',price_tax as 'السعر',discount as 'خصم صنف',discountontotalorder as 'الخصم ع اجمالي الفاتوره',total as 'القيمه',totalorder as 'الاجمالي الكلي',buy_details.date as 'التاريخ',time as 'الوقت',notes_item as 'ملاحظات ع الصنف',buy_details.notes as 'ملاحظات عامه',type as 'نوع الفاتوره',mandoup_name as 'المندوب',buy_details.user_name as 'المستخدم',store_name as 'المخزن' ,branch_name as 'الفرع'from buy_details,suppliers,products where buy_details.sup_id=suppliers.sup_id and buy_details.product_id=products.product_id and convert(nvarchar,buy_details.date,105)between N'" + from + "' and N'" + to + "' and buy_details.sup_id=" + cbxsuppliers.SelectedValue + " and buy_details.branch_name=N'"+cbxbranchname.Text+"'", "");
                dgv.DataSource = tbl;
               
            }
            total();
            
        }

        //printing
        private void btnprintsellected_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count >= 1)
            {
                //select branch
                string branch_name = Convert.ToString(dgv.CurrentRow.Cells[19].Value);
                //select the printing A4 option
                if (Properties.Settings.Default.purchasesprintkind == "A4")
                {
                    try
                    {
                        //bill id
                        int order_id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                        //Quary
                        DataTable tblprint = new DataTable();
                        tblprint.Clear();
                        tblprint = db.readdata("select settingprinting_bills.logo as'اللوجو',settingprinting_bills.name as'اسم الشركه',settingprinting_bills.address as'العنوان',settingprinting_bills.phone1 as'تليفون1',settingprinting_bills.phone2 as'تليفون2',settingprinting_bills.phone3 as'تليفون3',settingprinting_bills.commerical_re as'الرقم التجاري',settingprinting_bills.tax_re as'الرقم الضريبي',buy_details.order_id as'رقم الفاتوره',ezn_id as'رقم الاذن',suppliers.sup_name as'اسم المورد',products.product_name as'المنتج',buy_details.Qty as'الكميه',buy_details.date as'التاريخ',buy_details.user_name as'المستخدم',buy_details.price_tax as'المبلغ',buy_details.discountontotalorder as'الخصم الكلي',buy_details.total as'الاجمالي',buy_details.totalorder as'الاجمالي الكلي',buy_details.unit_name as'الوحده',buy_details.type as'نوع الفاتوره',buy_details.branch_name as'الفرع',buy_details.notes_item as'ملاحظه صنف',buy_details.notes as'ملاحظات عامه',buy_details.mandoup_name as'المندوب',buy_details.store_name as'المخزن',buy_details_money.madfou3 as'المدفوع'  from buy_details,suppliers,settingprinting_bills,products,buy_details_money where buy_details.product_id=products.product_id and suppliers.sup_id=buy_details.sup_id and buy_details.order_id=buy_details_money.order_id and buy_details.order_id=" + order_id + " and buy_details.branch_name=N'" + branch_name + "' and buy_details.branch_name=buy_details_money.branch_name", "");
                        //printing form
                        printing frm = new printing();
                        frm.crystalReportViewer1.RefreshReport();
                        //report
                        buy_print rpt = new buy_print();
                        rpt.SetDatabaseLogon("", "", Properties.Settings.Default.servername, Properties.Settings.Default.databasename);
                        rpt.SetDataSource(tblprint);
                        //parameters
                        rpt.SetParameterValue("order_id", order_id);
                        rpt.SetParameterValue("branch_name", branch_name);
                        frm.crystalReportViewer1.ReportSource = rpt;
                        frm.ShowDialog();
                        //System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                        //rpt.PrintOptions.PrinterName = Properties.Settings.Default.printername;
                        //rpt.PrintToPrinter(1, true, 0, 0);
                    }
                    catch (Exception) { }
                }
            }
        }
    }
}
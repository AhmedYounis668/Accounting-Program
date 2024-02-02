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
    public partial class sales_reports : DevExpress.XtraEditors.XtraForm
    {
        public sales_reports()
        {
            InitializeComponent();
        }
        //call database class
        DataTable tbl = new DataTable();
        database db = new database();

        //fil combobox with data
        private void fillcbx()
        {
            cbxcustomer.DataSource = db.readdata("select*from customers", "");
            cbxcustomer.DisplayMember = "cust_name";
            cbxcustomer.ValueMember = "cust_id";

            cbxbranchname.DataSource = db.readdata("select*from branches", "");
            cbxbranchname.DisplayMember = "branch_name";
            cbxbranchname.ValueMember = "branch_id";

            if(radiosuppliers.Checked==true)
            {
                cbxsupandemp.DataSource = db.readdata("select*from suppliers", "");
                cbxsupandemp.DisplayMember = "sup_name";
                cbxsupandemp.ValueMember = "sup_id";
            }
            else if(radioemployeesupplier.Checked==true)
            {
                cbxsupandemp.DataSource = db.readdata("select*from add_new_employee", "");
                cbxsupandemp.DisplayMember = "emp_name";
                cbxsupandemp.ValueMember = "emp_id";
            }
        }

        //get the total of bills
        private void total()
        {
            string dfrom = "", dto = "";
            decimal discount = 0;
            dfrom = dtpfrom.Value.ToString("yyyy-MM-dd");
            dto = dtpto.Value.ToString("yyyy-MM-dd");
            DataTable tbldiscount = new DataTable();
            tbldiscount.Clear();
            tbldiscount = db.readdata("select*from sales where convert(nvarchar,date,105)between N'"+dfrom+"' and N'"+dto+"'", "");
            for(int d=0;d<=tbldiscount.Rows.Count-1;d++)
            {
                discount += Convert.ToDecimal(tbldiscount.Rows[d][3]);
            }
            decimal final = 0;
            for(int i = 0;i <= dgv.Rows.Count - 1;i++)
            {
                final +=Convert.ToDecimal (dgv.Rows[i].Cells[8].Value);
            }
            txttotalsales.Text = (final - discount).ToString();
        }
        //get the total of selected customer
        private void totalonecustomer()
        {
            string dfrom = "", dto = "";
            decimal discount = 0;
            dfrom = dtpfrom.Value.ToString("yyyy-MM-dd");
            dto = dtpto.Value.ToString("yyyy-MM-dd");
            DataTable tbldiscount = new DataTable();
            tbldiscount.Clear();
            tbldiscount = db.readdata("select*from sales where convert(nvarchar,date,105)between N'" + dfrom + "' and N'" + dto + "' and cust_id="+cbxcustomer.SelectedValue+"", "");
            for (int d = 0; d <= tbldiscount.Rows.Count - 1; d++)
            {
                discount += Convert.ToDecimal(tbldiscount.Rows[d][3]);
            }
            decimal final = 0;
            for (int i = 0; i <= dgv.Rows.Count - 1; i++)
            {
                final += Convert.ToDecimal(dgv.Rows[i].Cells[8].Value);
            }
            txttotalsales.Text = (final - discount).ToString();
        }

        //اجماليات الفروع
        private void totalbranches()
        {
            string dfrom = "", dto = "";
            decimal discount = 0;
            dfrom = dtpfrom.Value.ToString("yyyy-MM-dd");
            dto = dtpto.Value.ToString("yyyy-MM-dd");
            DataTable tbldiscount = new DataTable();
            tbldiscount.Clear();
            tbldiscount = db.readdata("select*from sales where convert(nvarchar,date,105)between N'" + dfrom + "' and N'" + dto + "' and branch_name=N'"+cbxbranchname.Text+"'", "");
            for (int d = 0; d <= tbldiscount.Rows.Count - 1; d++)
            {
                discount += Convert.ToDecimal(tbldiscount.Rows[d][3]);
            }
            decimal final = 0;
            for (int i = 0; i <= dgv.Rows.Count - 1; i++)
            {
                final += Convert.ToDecimal(dgv.Rows[i].Cells[8].Value);
            }
            txttotalsales.Text = (final - discount).ToString();
        }
        //total customer in selected branch
        private void totalonecustomerbranches()
        {
            string dfrom = "", dto = "";
            decimal discount = 0;
            dfrom = dtpfrom.Value.ToString("yyyy-MM-dd");
            dto = dtpto.Value.ToString("yyyy-MM-dd");
            DataTable tbldiscount = new DataTable();
            tbldiscount.Clear();
            tbldiscount = db.readdata("select*from sales where convert(nvarchar,date,105)between N'" + dfrom + "' and N'" + dto + "' and cust_id=" + cbxcustomer.SelectedValue + " and branch_name=N'"+cbxbranchname.Text+"'", "");
            for (int d = 0; d <= tbldiscount.Rows.Count - 1; d++)
            {
                discount += Convert.ToDecimal(tbldiscount.Rows[d][3]);
            }
            decimal final = 0;
            for (int i = 0; i <= dgv.Rows.Count - 1; i++)
            {
                final += Convert.ToDecimal(dgv.Rows[i].Cells[8].Value);
            }
            txttotalsales.Text = (final - discount).ToString();
        }
        private void sales_reports_Load(object sender, EventArgs e)
        {
            dtpfrom.Text = DateTime.Now.ToShortDateString();
            dtpto.Text = DateTime.Now.ToShortDateString();
            fillcbx();
        }

        private void txtpronamesearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        //search by customer name
        private void txtcustname_TextChanged(object sender, EventArgs e)
        {
            if (radiocustname.Checked == true)
            {
                tbl.Clear();
                tbl = db.readdata("select cust_id as 'رقم العميل',cust_name as 'اسم العميل',phone as 'التليفون',identity_id as 'الرقم التعريفي' from customers where cust_name like N'%" + txtcustname.Text.Trim() + "%'", "");
                dgvsearchforproducts.DataSource = tbl;
            }
        }
        //search with customer name in combobox
        private void txtpro_name_TextChanged(object sender, EventArgs e)
        {
            if (radiopro_name.Checked == true)
            {
                tbl.Clear();
                tbl = db.readdata("select product_id as 'رقم المنتج',product_name as 'اسم المنتج' from products where product_name like N'%" +txtpro_name.Text.Trim() + "%'", "");
                dgvsearchforproducts.DataSource = tbl;
            }
        }

        //search
        private void btnsearch_Click(object sender, EventArgs e)
        {
            string dfrom = "", dto = "";
            dfrom = dtpfrom.Value.ToString("yyyy-MM-dd");
            dto = dtpto.Value.ToString("yyyy-MM-dd");
            //search about all customers 
            if(radioallcustomer.Checked==true)
            {
                tbl.Clear();
                tbl = db.readdata("select sales_details.order_id as 'رقم الفاتوره',order_ezn as 'رقم الاذن',sales_details_money.person_name as 'فاتوره ل',pro_name as 'اسم المنتج',Qty as 'الكميه',unit as 'الوحده',price_tax as 'السعر',discountonallorder as 'الخصم الكلي',total as 'اجمالي الصنف',totalorder as 'الاجمالي الكلي',sales_details.user_name as 'المستخدم',date as 'بتاريخ',time as 'الوقت', type as 'نوع الفاتوره',sales_details.branch_name as 'الفرع',notes_item as 'ملحوظه صنف',sales_details.notes as 'ملاحظات',mandoup_name as 'المندوب',sales_details.billfor as 'فاتوره ل-عميل/مورد/موظف',countofitems as 'عدد الاصناف',row_number as 'رقم الصف' from sales_details,sales_details_money where sales_details.order_id=sales_details_money.order_id and convert (Nvarchar,sales_details.date,105)between N'"+dfrom+"' and N'"+dto+"'", "");
                dgv.DataSource = tbl;
                total();
            }
            //search about selected customer
            else if(radioonecustomer.Checked==true)
            {
                tbl.Clear();
                tbl = db.readdata("select sales_details.order_id as 'رقم الفاتوره',order_ezn as 'رقم الاذن',customers.cust_name as 'اسم العميل',pro_name as 'اسم المنتج',Qty as 'الكميه',unit as 'الوحده',price_tax as 'السعر',discountonallorder as 'الخصم الكلي',total as 'اجمالي الصنف',totalorder as 'الاجمالي الكلي',sales_details.user_name as 'المستخدم',date as 'بتاريخ',time as 'الوقت', type as 'نوع الفاتوره',sales_details.branch_name as 'الفرع',notes_item as 'ملحوظه صنف',sales_details.notes as 'ملاحظات',mandoup_name as 'المندوب',sales_details.billfor as 'فاتوره ل-عميل/مورد/موظف',countofitems as 'عدد الاصناف',row_number as 'رقم الصف' from sales_details,customers where sales_details.cust_id=customers.cust_id and sales_details.cust_id=" + cbxcustomer.SelectedValue+ " and billfor=N'عميل' and convert (Nvarchar,sales_details.date,105)between N'" + dfrom + "' and N'" + dto + "'", "");
                dgv.DataSource = tbl;
                totalonecustomer();
            }
            //search with all suppliers
            else if(radiosuppliers.Checked==true)
            {
                tbl.Clear();
                tbl = db.readdata("select sales_details.order_id as 'رقم الفاتوره',order_ezn as 'رقم الاذن',suppliers.sup_name as 'اسم المورد',pro_name as 'اسم المنتج',Qty as 'الكميه',unit as 'الوحده',price_tax as 'السعر',discountonallorder as 'الخصم الكلي',total as 'اجمالي الصنف',totalorder as 'الاجمالي الكلي',sales_details.user_name as 'المستخدم',date as 'بتاريخ',time as 'الوقت', type as 'نوع الفاتوره',sales_details.branch_name as 'الفرع',notes_item as 'ملحوظه صنف',sales_details.notes as 'ملاحظات',mandoup_name as 'المندوب',sales_details.billfor as 'فاتوره ل-عميل/مورد/موظف',countofitems as 'عدد الاصناف',row_number as 'رقم الصف' from sales_details,suppliers where sales_details.cust_id=suppliers.sup_id and sales_details.cust_id=" + cbxsupandemp.SelectedValue + " and billfor=N'مورد' and convert (Nvarchar,sales_details.date,105)between N'" + dfrom + "' and N'" + dto + "'", "");
                dgv.DataSource = tbl;
                totalonecustomer();
            }
            //search with all employees
            else if(radioemployeesupplier.Checked==true)
            {
                tbl.Clear();
                tbl = db.readdata("select sales_details.order_id as 'رقم الفاتوره',order_ezn as 'رقم الاذن',add_new_employee.emp_name as 'اسم المورد',pro_name as 'اسم المنتج',Qty as 'الكميه',unit as 'الوحده',price_tax as 'السعر',discountonallorder as 'الخصم الكلي',total as 'اجمالي الصنف',totalorder as 'الاجمالي الكلي',sales_details.user_name as 'المستخدم',date as 'بتاريخ',time as 'الوقت', type as 'نوع الفاتوره',sales_details.branch_name as 'الفرع',notes_item as 'ملحوظه صنف',sales_details.notes as 'ملاحظات',mandoup_name as 'المندوب',sales_details.billfor as 'فاتوره ل-عميل/مورد/موظف',countofitems as 'عدد الاصناف',row_number as 'رقم الصف' from sales_details,add_new_employee where sales_details.cust_id=add_new_employee.emp_id and sales_details.cust_id=" + cbxsupandemp.SelectedValue + " and billfor=N'موظف' and convert (Nvarchar,sales_details.date,105)between N'" + dfrom + "' and N'" + dto + "'", "");
                dgv.DataSource = tbl;
                totalonecustomer();
            }
            //search with customer name
            else if(radiocustname.Checked==true)
            {
                if (dgvsearchforproducts.Rows.Count >= 1)
                {
                    int cust_id = Convert.ToInt32(dgvsearchforproducts.CurrentRow.Cells[0].Value);
                    tbl.Clear();
                    tbl = db.readdata("select sales_details.order_id as 'رقم الفاتوره',order_ezn as 'رقم الاذن',customers.cust_name as 'اسم العميل',pro_name as 'اسم المنتج',Qty as 'الكميه',unit as 'الوحده',price_tax as 'السعر',discountonallorder as 'الخصم الكلي',total as 'اجمالي الصنف',totalorder as 'الاجمالي الكلي',sales_details.user_name as 'المستخدم',date as 'بتاريخ',time as 'الوقت', type as 'نوع الفاتوره',sales_details.branch_name as 'الفرع',notes_item as 'ملحوظه صنف',sales_details.notes as 'ملاحظات',mandoup_name as 'المندوب',sales_details.billfor as 'فاتوره ل-عميل/مورد/موظف',countofitems as 'عدد الاصناف',row_number as 'رقم الصف' from sales_details,customers where sales_details.cust_id=customers.cust_id and sales_details.cust_id=" + cust_id + "  and billfor=N'عميل' and convert (Nvarchar,sales_details.date,105)between N'" + dfrom + "' and N'" + dto + "'", "");
                    dgv.DataSource = tbl;
                    totalonecustomer();
                }
                }
            else if(radiopro_name.Checked==true)
            {
                //tbl.Clear();
                //tbl = db.readdata("", "");
                //dgv.DataSource = tbl;

            }
        }
        //search with number of the bill
        private void txtnoofbills_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtnoofbills.Text == "")
                {
                    MessageBox.Show("من فضلك ادخل رقم الفاتوره اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (checknomberofbill.Checked == true)
                    {
                        tbl.Clear();
                        tbl = db.readdata("select order_id as 'رقم الفاتوره',order_ezn as 'رقم الاذن',customers.cust_name as 'اسم العميل',pro_name as 'اسم المنتج',Qty as 'الكميه',unit as 'الوحده',price_tax as 'السعر',discountonallorder as 'الخصم الكلي',total as 'اجمالي الصنف',totalorder as 'الاجمالي الكلي',sales_details.user_name as 'المستخدم',date as 'بتاريخ',time as 'الوقت', type as 'نوع الفاتوره',sales_details.branch_name as 'الفرع',notes_item as 'ملحوظه صنف',sales_details.notes as 'ملاحظات',mandoup_name as 'المندوب',billfor as 'فاتوره ل-عميل/مورد/موظف',countofitems as 'عدد الاصناف',row_number as 'رقم الصف' from sales_details,customers where sales_details.cust_id=customers.cust_id and sales_details.order_id=" + txtnoofbills.Text.Trim()+ "", "");
                        dgv.DataSource = tbl;
                    }
                }
            }
        }

        //search with number of ezn
        private void txtsearchwithezn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtsearchwithezn.Text == "")
                {
                    MessageBox.Show("من فضلك ادخل رقم الاذن اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (checkezn.Checked == true)
                    {
                        tbl.Clear();
                        tbl = db.readdata("select order_id as 'رقم الفاتوره',order_ezn as 'رقم الاذن',customers.cust_name as 'اسم العميل',pro_name as 'اسم المنتج',Qty as 'الكميه',unit as 'الوحده',price_tax as 'السعر',discountonallorder as 'الخصم الكلي',total as 'اجمالي الصنف',totalorder as 'الاجمالي الكلي',sales_details.user_name as 'المستخدم',date as 'بتاريخ',time as 'الوقت', type as 'نوع الفاتوره',sales_details.branch_name as 'الفرع',notes_item as 'ملحوظه صنف',sales_details.notes as 'ملاحظات',mandoup_name as 'المندوب',billfor as 'فاتوره ل-عميل/مورد/موظف',countofitems as 'عدد الاصناف',row_number as 'رقم الصف' from sales_details,customers where sales_details.cust_id=customers.cust_id and sales_details.order_ezn=" + txtsearchwithezn.Text.Trim() + "", "");
                        dgv.DataSource = tbl;
                    }
                }
            }
        }

        //search with branches
        private void btnsearchbranchses_Click(object sender, EventArgs e)
        {

            if (cbxbranchname.Text == "")
            {
                MessageBox.Show("من فضلك ادخل الفروع اولا لايوجد ولا فرع متاح حاليا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string dfrom = "", dto = "";
            dfrom = dtpfrom.Value.ToString("yyyy-MM-dd");
            dto = dtpto.Value.ToString("yyyy-MM-dd");
            //all custmer in all branches
            if (radioallcustomersinselectedbranch.Checked == true)
            {
               
                tbl.Clear();
                //tbl = db.readdata("select order_id as 'رقم الفاتوره',order_ezn as 'رقم الاذن',customers.cust_name as 'اسم العميل',pro_name as 'اسم المنتج',Qty as 'الكميه',unit as 'الوحده',price_tax as 'السعر',discountonallorder as 'الخصم الكلي',total as 'اجمالي الصنف',totalorder as 'الاجمالي الكلي',sales_details.user_name as 'المستخدم',date as 'بتاريخ',time as 'الوقت', type as 'نوع الفاتوره',sales_details.branch_name as 'الفرع',notes_item as 'ملحوظه صنف',sales_details.notes as 'ملاحظات',mandoup_name as 'المندوب',billfor as 'فاتوره ل-عميل/مورد/موظف',countofitems as 'عدد الاصناف',row_number as 'رقم الصف' from sales_details,customers where sales_details.cust_id=customers.cust_id and convert (Nvarchar,sales_details.date,105)between N'" + dfrom + "' and N'" + dto + "' and sales_details.branch_name=N'"+cbxbranchname.Text.Trim()+"'", "");
                tbl = db.readdata("select sales_details.order_id as 'رقم الفاتوره',order_ezn as 'رقم الاذن',sales_details_money.person_name as 'فاتوره ل',pro_name as 'اسم المنتج',Qty as 'الكميه',unit as 'الوحده',price_tax as 'السعر',discountonallorder as 'الخصم الكلي',total as 'اجمالي الصنف',totalorder as 'الاجمالي الكلي',sales_details.user_name as 'المستخدم',date as 'بتاريخ',time as 'الوقت', type as 'نوع الفاتوره',sales_details.branch_name as 'الفرع',notes_item as 'ملحوظه صنف',sales_details.notes as 'ملاحظات',mandoup_name as 'المندوب',sales_details.billfor as 'فاتوره ل-عميل/مورد/موظف',countofitems as 'عدد الاصناف',row_number as 'رقم الصف' from sales_details,sales_details_money where sales_details.order_id=sales_details_money.order_id and convert (Nvarchar,sales_details.date,105)between N'" + dfrom + "' and N'" + dto + "' and sales_details.branch_name=N'" + cbxbranchname.Text.Trim() + "'", "");
                dgv.DataSource = tbl;
                totalbranches();
            }
            //selected customer in selected branch
            else if (radiocustomerselectedinbranchselected.Checked == true)
            {
                if (cbxcustomer.Text == "")
                {
                    MessageBox.Show("من فضلك اختار العميل اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                tbl.Clear();
                tbl = db.readdata("select order_id as 'رقم الفاتوره',order_ezn as 'رقم الاذن',customers.cust_name as 'اسم العميل',pro_name as 'اسم المنتج',Qty as 'الكميه',unit as 'الوحده',price_tax as 'السعر',discountonallorder as 'الخصم الكلي',total as 'اجمالي الصنف',totalorder as 'الاجمالي الكلي',sales_details.user_name as 'المستخدم',date as 'بتاريخ',time as 'الوقت', type as 'نوع الفاتوره',sales_details.branch_name as 'الفرع',notes_item as 'ملحوظه صنف',sales_details.notes as 'ملاحظات',mandoup_name as 'المندوب',billfor as 'فاتوره ل-عميل/مورد/موظف',countofitems as 'عدد الاصناف',row_number as 'رقم الصف' from sales_details,customers where sales_details.cust_id=customers.cust_id and sales_details.cust_id=" + cbxcustomer.SelectedValue + " and billfor=N'عميل' and convert (Nvarchar,sales_details.date,105)between N'" + dfrom + "' and N'" + dto + "' and sales_details.branch_name=N'"+cbxbranchname.Text.Trim()+"'", "");
                dgv.DataSource = tbl;
                totalonecustomerbranches();
            }
            //selected supplier in branches
            else if (radiosupplierselectioninbranch.Checked == true)
            {
                if (cbxsupandemp.Text == "")
                {
                    MessageBox.Show("من فضلك قم باختيار المورد اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                tbl.Clear();
                tbl = db.readdata("select sales_details.order_id as 'رقم الفاتوره',order_ezn as 'رقم الاذن',suppliers.sup_name as 'اسم المورد',pro_name as 'اسم المنتج',Qty as 'الكميه',unit as 'الوحده',price_tax as 'السعر',discountonallorder as 'الخصم الكلي',total as 'اجمالي الصنف',totalorder as 'الاجمالي الكلي',sales_details.user_name as 'المستخدم',date as 'بتاريخ',time as 'الوقت', type as 'نوع الفاتوره',sales_details.branch_name as 'الفرع',notes_item as 'ملحوظه صنف',sales_details.notes as 'ملاحظات',mandoup_name as 'المندوب',sales_details.billfor as 'فاتوره ل-عميل/مورد/موظف',countofitems as 'عدد الاصناف',row_number as 'رقم الصف' from sales_details,suppliers where sales_details.cust_id=suppliers.sup_id and sales_details.cust_id=" + cbxsupandemp.SelectedValue + " and billfor=N'مورد' and convert (Nvarchar,sales_details.date,105)between N'" + dfrom + "' and N'" + dto + "' and sales_details.branch_name=N'"+cbxbranchname.Text.Trim()+"'", "");
                dgv.DataSource = tbl;
                totalonecustomer();
            }
            //employee selected in branch selected else
            else if (radioemployeeselectioninbranchselection.Checked == true)
            {
                 if(cbxsupandemp.Text=="")
            {
                MessageBox.Show("من فضلك اختر الموظف اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                tbl.Clear();
                tbl = db.readdata("select sales_details.order_id as 'رقم الفاتوره',order_ezn as 'رقم الاذن',add_new_employee.emp_name as 'اسم المورد',pro_name as 'اسم المنتج',Qty as 'الكميه',unit as 'الوحده',price_tax as 'السعر',discountonallorder as 'الخصم الكلي',total as 'اجمالي الصنف',totalorder as 'الاجمالي الكلي',sales_details.user_name as 'المستخدم',date as 'بتاريخ',time as 'الوقت', type as 'نوع الفاتوره',sales_details.branch_name as 'الفرع',notes_item as 'ملحوظه صنف',sales_details.notes as 'ملاحظات',mandoup_name as 'المندوب',sales_details.billfor as 'فاتوره ل-عميل/مورد/موظف',countofitems as 'عدد الاصناف',row_number as 'رقم الصف' from sales_details,add_new_employee where sales_details.cust_id=add_new_employee.emp_id and sales_details.cust_id=" + cbxsupandemp.SelectedValue + " and billfor=N'موظف' and convert (Nvarchar,sales_details.date,105)between N'" + dfrom + "' and N'" + dto + "' and sales_details.branch_name=N'" + cbxbranchname.Text.Trim() + "'", "");
                dgv.DataSource = tbl;
                totalonecustomer();
            }
        }

        private void radiosuppliers_CheckedChanged(object sender, EventArgs e)
        {
            fillcbx();
        }

        private void radioemployeesupplier_CheckedChanged(object sender, EventArgs e)
        {
            fillcbx();
        }

        //printing the bill
        private void btnprintsellected_Click(object sender, EventArgs e)
        {

            if(dgv.Rows.Count>=1)
            { 
            string branch_name =Convert.ToString(dgv.CurrentRow.Cells[14].Value);
                if (Properties.Settings.Default.salesprintkind == "8cm")
                {

                    try
                    {
                        int id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);

                        DataTable tblprint = new DataTable();
                        tblprint.Clear();
                        tblprint = db.readdata("select order_id as 'رقم الفاتوره',products.product_name as 'اسم المنتج',customer.cust_name as'اسم العميل',sales_details.Qty as 'الكميه',price as 'السعر',discount as 'الخصم',total as 'الاجمالي',madfou3 as 'المدفوع',bakey as 'الباقي',totalorder as 'الاجمالي الكلي',unit as 'الوحده',sales_details.tax_value as 'الضريبه',price_tax as 'السعر بعد الضريبه',sales_details.user_name as 'اسم المستخدم',time as 'الوقت',sales_details.date as 'التاريخ',type as 'نوع الفاتوره',sales_details.branch_name as 'الفرع',sales_details.total_on_customer as 'اجمالي اللي عليه' from products,sales_details,customer where sales_details.product_id=products.product_id and sales_details.cust_id=customer.cust_id and sales_details.order_id=" + id + " and sales_details.branch_name=N'" + branch_name + "'", "");
                        printing frm = new printing();
                        frm.crystalReportViewer1.RefreshReport();

                     
                    }
                    catch (Exception) { }
                }
                //print A4
                else if (Properties.Settings.Default.salesprintkind == "A4")
                {
                    try
                    {
                        int id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                        DataTable tblprint = new DataTable();
                        //quary
                        tblprint.Clear();
                        tblprint = db.readdata("select settingprinting_bills.logo as 'اللوجو',settingprinting_bills.name as 'اسم الشركه',settingprinting_bills.address as 'العنوان',settingprinting_bills.phone1 as 'فون1',settingprinting_bills.phone2 as'فون2',settingprinting_bills.phone3 as'فون3',settingprinting_bills.discription as 'الوصف',settingprinting_bills.commerical_re as'السجل التجاري',settingprinting_bills.tax_re as'التسجيل الضريبي', sales_details.order_id as 'رقم الفاتوره',order_ezn as 'رقم الاذن',pro_name as 'اسم المنتج',Qty as 'الكميه',price_tax as 'السعر',discountonallorder as 'الخصم الكلي',total as 'الاجمالي',totalorder as 'الاجمالي الكلي',unit as 'الوحده',time as 'الوقت',sales_details.user_name as 'المستخدم',sales_details.branch_name as 'الفرع',sales_details.date as 'التاريخ',type as 'نوع الاوردر',notes_item as 'ملاحظه صنف',sales_details.notes as 'ملاحظه عامه', store_name as 'المخزن',mandoup_name as 'ملاحظه عامه',sales_details.billfor as 'فاتوره ل',sales_details_money.madfou3 as'المدفوع',sales_details_money.person_name as 'اسم الشخص',sales_details_money.totalonhim as 'اجمالي اللي علي الشخص',sales_details_money.branch_name as 'الفرع في الجدول التاني sales_money' from sales_details,settingprinting_bills,sales_details_money where   sales_details.order_id=sales_details_money.order_id  and sales_details.order_id=" + id + " and sales_details.branch_name=N'" + Properties.Settings.Default.branch_name + "' and sales_details_money.branch_name=sales_details.branch_name", "");
                        printing frm = new printing();
                        frm.crystalReportViewer1.RefreshReport();
                        //report form
                        sales_print rpt = new sales_print();
                        rpt.SetDatabaseLogon("", "", Properties.Settings.Default.servername, Properties.Settings.Default.databasename);
                        rpt.SetDataSource(tblprint);
                        //parameters
                        rpt.SetParameterValue("id", id);
                        rpt.SetParameterValue("branch_name", branch_name);
                        rpt.SetParameterValue("branch_name_money", branch_name);

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
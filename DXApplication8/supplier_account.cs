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
    public partial class supplier_account : DevExpress.XtraEditors.XtraForm
    {
        public supplier_account()
        {
            InitializeComponent();
        }

        //call database class
        DataTable tbl = new DataTable();
        database db = new database();

        //fill combobox with suppliers
        private void fillcb()
        {
            cbxsuppliers.DataSource = db.readdata("select*from suppliers", "");
            cbxsuppliers.DisplayMember = "sup_name";
            cbxsuppliers.ValueMember = "sup_id";
        }

        //get total money on supplier
        private void total()
        {
            decimal totalmoney = 0,totalsadad = 0,finalbalance=0;
            for(int i=0;i<=dgv.Rows.Count-1;i++)
            {
                totalmoney += Convert.ToDecimal(dgv.Rows[i].Cells[6].Value);
                totalsadad+= Convert.ToDecimal(dgv.Rows[i].Cells[7].Value);
            }
            finalbalance += totalmoney - totalsadad;
            txttotal.Text = finalbalance.ToString();
        }
        private void supplier_account_Load(object sender, EventArgs e)
        {
            dtpfrom.Text = DateTime.Now.ToShortDateString();
            dtpto.Text = DateTime.Now.ToShortDateString();
            fillcb();
        }
        //saerch
        private void btnsearch_Click(object sender, EventArgs e)
        {
            string from = "", to = "";
            from = dtpfrom.Value.ToString("yyyy-MM-dd");
            to = dtpto.Value.ToString("yyyy-MM-dd");
            if (radioselectone.Checked == false && radiosupplierall.Checked == false && radiosupname.Checked == false&&radiofatra.Checked==false)
            {
                MessageBox.Show("من فضلك حدد العمليه", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //search about one supplier
            else if(radioselectone.Checked==true)
            {
                tbl.Clear();
                tbl = db.readdata("select order_id as'رقم البيان' ,sup_name as 'اسم المورد',description as 'البيان',pro_name as 'الصنف',Qty as 'الكميه',total as 'الاجمالي',leh as 'ليه',sadad as 'السداد',date as 'التاريخ',unit as 'الوحده',notes as 'ملاحظات',type as '-',user_name as'المستخدم',branch_name as 'الفرع' from supplier_account where sup_id=" + cbxsuppliers.SelectedValue+" order by date", "");
                dgv.DataSource = tbl;
                total();
            }
            //search about all suppliers
            else if(radiosupplierall.Checked==true)
            {
                tbl.Clear();
                tbl = db.readdata("select SUM(leh) as 'له',sum (sadad) as 'سداد',supplier_account.sup_id as 'رقم المورد',(select suppliers.sup_name  from suppliers where suppliers.sup_id=supplier_account.sup_id)as 'اسم المورد' from supplier_account group by(supplier_account.sup_id)   ", "");
                dgv.DataSource = tbl;

                //total
                decimal total = 0;
                for(int i=0;i<=dgv.Rows.Count-1;i++)
                {
                    total += Convert.ToDecimal(dgv.Rows[i].Cells[2].Value);
                }
                txttotal.Text = total.ToString();
            }
            //search by sup name or part of his name
            else if(radiosupname.Checked==true)
            {
                int sup_id =Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                tbl.Clear();
                tbl = db.readdata("select order_id as'رقم البيان' ,sup_name as 'اسم المورد',description as 'البيان',pro_name as 'الصنف',Qty as 'الكميه',total as 'الاجمالي',leh as 'ليه',sadad as 'السداد',date as 'التاريخ',unit as 'الوحده',notes as 'ملاحظات',type as '-',user_name as'المستخدم',branch_name as 'الفرع' from supplier_account where sup_id=" + sup_id+ " order by date", "");
                dgv.DataSource = tbl;
                total();
            }
            //search with difreence dates -->two dates
            else if(radiofatra.Checked==true)
            {
                tbl.Clear();
                tbl = db.readdata("select order_id as'رقم البيان' ,sup_name as 'اسم المورد',description as 'البيان',pro_name as 'الصنف',Qty as 'الكميه',total as 'الاجمالي',leh as 'ليه',sadad as 'السداد',date as 'التاريخ',unit as 'الوحده',notes as 'ملاحظات',type as '-',user_name as'المستخدم',branch_name as 'الفرع' from supplier_account where sup_id=" + cbxsuppliers.SelectedValue + " and convert(Nvarchar,date,105)between N'"+from+"' and N'"+to+"' order by date", "");
                dgv.DataSource = tbl;
                total();
            }
        }
        //write supplier name to search about it
        private void txt_write_supplier_TextChanged(object sender, EventArgs e)
        {
            if(radiosupname.Checked==true)
            {
                tbl.Clear();
                tbl = db.readdata("select sup_id as 'رقم المورد',sup_name as 'اسم المورد',phone as 'التليفون',address as 'العنوان',notes as 'ملاحظات',identity_id as 'الرقم التعريفي',branch as 'الفرع' from suppliers where sup_name like N'%"+txt_write_supplier.Text.Trim()+"%'", "");
                dgv.DataSource = tbl;
            }
        }

        //delete the bill from supplier account
        private void btndeletebill_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count >= 1)
            {
                int order_id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                db.excutedata("delete from supplier_account where order_id=" + order_id + " ", "تم الحذف بنجاح");
                btnsearch_Click(null, null);
            }

        }

        //delete sand from supplier account in insert it in deleted sandat
        private void btndeleteselectedsadad_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count >= 1)
            {
                if (MessageBox.Show("هل انت متاكد من مسح السداد المحدد", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    //sandat deleted
                    db.excutedata("insert into sandat_deleted values(" + dgv.CurrentRow.Cells[0].Value + ",N'" + dgv.CurrentRow.Cells[1].Value + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "'," + dgv.CurrentRow.Cells[7].Value + ",N'سند صرف محذوف',N'مورد')", "");
                    //delete from supplier account
                    db.excutedata("delete from supplier_account where order_id=" + dgv.CurrentRow.Cells[0].Value + "", "");
                    //delete from sand sarf 
                    db.excutedata("delete from sand_sarf where order_id=" + dgv.CurrentRow.Cells[0].Value + "", "تم الحذف");
                    //reload the data
                    btnsearch_Click(null, null);
                }
            }
        }

        //search about sandat deleted
        private void btnsandat_deleted_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readdata("select order_id as 'رقم السند',person_name as 'اسم المورد',user_name as 'المستخدم',branch as 'الفرع',money as 'المبلخ',type as 'ملحوظه',type2 as 'سند محذوف ل' from sandat_deleted where type2=N'مورد'", "");
            dgv.DataSource = tbl;
        }

        private void btnsearchbranchses_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        //search about bill -->details bill
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count >= 1)
            {
                panel1.Visible = true;
                int id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                DataTable tblbilldetails = new DataTable();
                tblbilldetails.Clear();
                tblbilldetails = db.readdata("select order_id as 'رقم الفاتوره',ezn_id as 'رقم الاذن',suppliers.sup_name as 'المورد',products.product_name as 'اسم المنتج',buy_details.Qty as 'الكميه',unit_name as 'الوحده',price_tax as 'السعر',discount as 'خصم صنف',discountontotalorder as 'الخصم ع اجمالي الفاتوره',total as 'القيمه',totalorder as 'الاجمالي الكلي',buy_details.date as 'التاريخ',time as 'الوقت',notes_item as 'ملاحظات ع الصنف',buy_details.notes as 'ملاحظات عامه',type as 'نوع الفاتوره',mandoup_name as 'المندوب',store_name as 'المخزن' ,branch_name as 'الفرع'from buy_details,suppliers,products where buy_details.sup_id=suppliers.sup_id and buy_details.product_id=products.product_id and order_id=" +id + "", "");
                dgv1.DataSource = tblbilldetails;
            }
        }
        //print statement account
        private void btnprint_Click(object sender, EventArgs e)
        {
            if (radioselectone.Checked == true && cbxsuppliers.Text != "")
            {
                try
                {
                    int sup_id = Convert.ToInt32(cbxsuppliers.SelectedValue);
                    DataTable tblprint = new DataTable();
                    tblprint.Clear();
                    tblprint = db.readdata("select settingprinting_bills.logo as 'اللوجو',settingprinting_bills.name as 'اسم الشركه',settingprinting_bills.address as 'العنوان',settingprinting_bills.phone1 as 'فون1',settingprinting_bills.phone2 as'فون2',settingprinting_bills.phone3 as'فون3',settingprinting_bills.discription as 'الوصف',settingprinting_bills.commerical_re as'السجل التجاري',settingprinting_bills.tax_re as'التسجيل الضريبي', order_id as'رقم البيان',sup_id as'رقم المورد',sup_name as'اسم المورد',supplier_account.description as'البيان',pro_name as'الصنف',Qty as'الكميه',total as'الاجمالي',totalorder as'الاجمالي الكلي',notes as'ملاحظات',leh as'ليه',sadad as'السداد',user_name as'المستخدم',branch_name as'الفرع',date as'التاريخ',type as'نوع العمليه',unit as'الوحده' from supplier_account,settingprinting_bills where sup_id="+sup_id+" order by date", "");
                    printing frm = new printing();
                    frm.crystalReportViewer1.RefreshReport();

                    supplier_account_print rpt = new supplier_account_print();
                    rpt.SetDatabaseLogon("", "", Properties.Settings.Default.servername, Properties.Settings.Default.databasename);
                    rpt.SetDataSource(tblprint);
                    rpt.SetParameterValue("sup_id", sup_id);

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
                MessageBox.Show("من فضلك حدد العميل اولا ثم اختاره", "خطا في استعراض البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
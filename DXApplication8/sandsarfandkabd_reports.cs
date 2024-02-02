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
    public partial class sandsarfandkabd_reports : DevExpress.XtraEditors.XtraForm
    {
        public sandsarfandkabd_reports()
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
        private void sandsarfandkabd_reports_Load(object sender, EventArgs e)
        {
            fillcbx();
            dtpfrom.Text = DateTime.Now.ToShortDateString();
            dtpto.Text = DateTime.Now.ToShortDateString();
        }

        //get the total of sandat
        private void total()
        {
            decimal total = 0;
            for(int i=0;i<=dgv.Rows.Count-1;i++)
            {
                total += Convert.ToDecimal(dgv.Rows[i].Cells[4].Value);
            }
            txttotaleda3.Text = total.ToString();
        }
        //search
        private void btnsearch_Click(object sender, EventArgs e)
        {
            string dfrom = "", dto = "";
            dfrom = dtpfrom.Value.ToString("yyyy-MM-dd");
            dto = dtpto.Value.ToString("yyyy-MM-dd");
            if(radiosandatkabd.Checked==false&&radiosandatsarf.Checked==false)
            {
                MessageBox.Show("من فضلك حدد عمليه اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //sandat kabd
            else if(radiosandatkabd.Checked==true)
            {
                tbl.Clear();
                tbl = db.readdata("select order_id as 'رقم البيان',type as 'العمليه ل',person_name as 'استلام المبلغ من السيد',date as 'التاريخ',money as 'المبلغ',notes as 'ملاحظات',user_name as 'المستخدم',branch as 'الفرع',time as 'الوقت' from sand_kabd where branch=N'"+cbxbranchname.Text.Trim()+"' and convert(nvarchar,date,105)between N'"+dfrom+"' and N'"+dto+"'", "");
                dgv.DataSource = tbl;
                total();
            }
            //sandat sarf
            else if(radiosandatsarf.Checked==true)
            {
                tbl.Clear();
                tbl = db.readdata(" select order_id as 'رقم البيان',type as 'العمليه ل',person_name as 'صرف المبلغ الي السيد',date as 'التاريخ',money as 'المبلغ',notes as 'ملاحظات',user_name as 'المستخدم',branch as 'الفرع' from sand_sarf where branch =N'" + cbxbranchname.Text.Trim() + "' and convert(nvarchar,date,105)between N'"+dfrom+"' and N'"+dto+"'", "");
                dgv.DataSource = tbl;
                total();
            }
        }
        //printing sand kabd
        private void btnprint_Click(object sender, EventArgs e)
        {
            if(radiosandatkabd.Checked==true)
            {
               
                    try
                    {
                    //get id of operation or row
                        int order_id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                        string branch_name = Convert.ToString(dgv.CurrentRow.Cells[7].Value);
                        DataTable tblprint =
                        //quary
                        new DataTable();
                        tblprint.Clear();
                        tblprint = db.readdata("select settingprinting_bills.logo as'اللوجو',settingprinting_bills.name as'اسم الشركه',settingprinting_bills.address as'العنوان',settingprinting_bills.phone1 as'تليفون1',settingprinting_bills.phone2 as'تليفون2',settingprinting_bills.phone3 as'تليفون3',settingprinting_bills.commerical_re as'الرقم التجاري',settingprinting_bills.tax_re as'الرقم الضريبي',order_id as 'رقم السند',type as 'نوع السند',person_name as'اسم الشخص',money as'المبلغ',date as'التاريخ',notes as'ملاحظات',user_name as'المستخدم',branch as'الفرع' from sand_kabd,settingprinting_bills where order_id=" + order_id + " and branch=N'" + Properties.Settings.Default.branch_name + "' ", "");
                        printing frm = new printing();
                        frm.crystalReportViewer1.RefreshReport();
                    //report form
                        sand_kabd_print rpt = new sand_kabd_print();
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
            //printing sand sarf
            else if(radiosandatsarf.Checked==true)
            {
                try
                {
                    int order_id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                    string branch_name = Convert.ToString(dgv.CurrentRow.Cells[7].Value);
                    DataTable tblprint = new DataTable();
                    tblprint.Clear();
                    tblprint = db.readdata("select settingprinting_bills.logo as'اللوجو',settingprinting_bills.name as'اسم الشركه',settingprinting_bills.address as'العنوان',settingprinting_bills.phone1 as'تليفون1',settingprinting_bills.phone2 as'تليفون2',settingprinting_bills.phone3 as'تليفون3',settingprinting_bills.commerical_re as'الرقم التجاري',settingprinting_bills.tax_re as'الرقم الضريبي',order_id as 'رقم السند',type as 'نوع السند',person_name as'اسم الشخص',money as'المبلغ',date as'التاريخ',notes as'ملاحظات',user_name as'المستخدم',branch as'الفرع' from sand_sarf,settingprinting_bills where order_id=" + order_id + " and branch=N'" + Properties.Settings.Default.branch_name + "' ", "");
                    printing frm = new printing();
                    frm.crystalReportViewer1.RefreshReport();

                    sand_sarf_print rpt = new sand_sarf_print();
                    rpt.SetDatabaseLogon("", "", Properties.Settings.Default.servername, Properties.Settings.Default.databasename);
                    rpt.SetDataSource(tblprint);
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
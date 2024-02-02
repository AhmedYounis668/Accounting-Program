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
    public partial class expenses_report : DevExpress.XtraEditors.XtraForm
    {
        public expenses_report()
        {
            InitializeComponent();
        }
        //call database class
        DataTable tbl = new DataTable();
        database db = new database();
        //fill combobox with branches and expenses types
        private void fillcbx()
        {
            cbxbranches.DataSource = db.readdata("select*from branches ", "");
            cbxbranches.DisplayMember = "branch_name";
            cbxbranches.ValueMember = "branch_id";

            cbxtypes.DataSource = db.readdata("select*from deserved_type ", "");
            cbxtypes.DisplayMember = "type_name";
            cbxtypes.ValueMember = "type_id";
        }

        private void expenses_report_Load(object sender, EventArgs e)
        {
            dtpfrom.Text = DateTime.Now.ToShortDateString();
            dtpto.Text = DateTime.Now.ToShortDateString();
            fillcbx();
        }
        //search button
        private void btnsearch_Click(object sender, EventArgs e)
        {
            //set date formate
            string dfrom = "", dto = "";
            dfrom = dtpfrom.Value.ToString("yyyy-MM-dd");
            dto = dtpto.Value.ToString("yyyy-MM-dd");
            //get all expenses search 
            if (radioallexpenses.Checked == true)
            {
                tbl.Clear();
                tbl = db.readdata("select deserved_id as 'رقم العمليه',type_name as 'البيان',money as 'المبلغ',notes as 'ملاحظات',date as 'التاريخ',user_name as 'المستخدم',branch_name as 'الفرع' from deserved where convert(nvarchar,date,105) between N'" + dfrom + "' and N'" + dto + "' ", "");
                dgv.DataSource = tbl;
            }
            //get all expenses search in all branches
            else if (radioallexpensesbranches.Checked == true)
            {
                tbl.Clear();
                tbl = db.readdata("select deserved_id as 'رقم العمليه',type_name as 'البيان',money as 'المبلغ',notes as 'ملاحظات',date as 'التاريخ',user_name as 'المستخدم',branch_name as 'الفرع' from deserved where convert(nvarchar,date,105) between N'" + dfrom + "' and N'" + dto + "' and branch_name=N'" + cbxbranches.Text + "'", "");
                dgv.DataSource = tbl;
            }
            //get the expenses of the type selected
            else if (radiotypeselected.Checked == true)
            {
                tbl.Clear();
                tbl = db.readdata("select deserved_id as 'رقم العمليه',type_name as 'البيان',money as 'المبلغ',notes as 'ملاحظات',date as 'التاريخ',user_name as 'المستخدم',branch_name as 'الفرع' from deserved where convert(nvarchar,date,105) between N'" + dfrom + "' and N'" + dto + "' and deserved_type_id=" + cbxtypes.SelectedValue + "", "");
                dgv.DataSource = tbl;
            }
            //get the expenses type selected in selected branch
            else if (radioselectedexpensesbranches.Checked == true)
            {
                tbl.Clear();
                tbl = db.readdata("select deserved_id as 'رقم العمليه',type_name as 'البيان',money as 'المبلغ',notes as 'ملاحظات',date as 'التاريخ',user_name as 'المستخدم',branch_name as 'الفرع' from deserved where convert(nvarchar,date,105) between N'" + dfrom + "' and N'" + dto + "' and deserved_type_id=" + cbxtypes.SelectedValue + " and branch_name=N'" + cbxbranches.Text + "'", "");
                dgv.DataSource = tbl;
            }
            //get type expense that selected in datagridview
            else if (radiopartoftyepeexpenses.Checked == true)
            {
                if (dgvsearchfortypes.Rows.Count >= 1)
                {
                    string type_name = "";
                    type_name = Convert.ToString(dgvsearchfortypes.CurrentRow.Cells[1].Value);
                    tbl.Clear();
                    tbl = db.readdata("select deserved_id as 'رقم العمليه',type_name as 'البيان',money as 'المبلغ',notes as 'ملاحظات',date as 'التاريخ',user_name as 'المستخدم',branch_name as 'الفرع' from deserved where convert(nvarchar,date,105) between N'" + dfrom + "' and N'" + dto + "' and type_name=N'" + type_name + "'", "");
                    dgv.DataSource = tbl;
                }
            }

        }

        //get all expenses between two dates in the branch opend
        private void btnallexpensesinbranchopennow_Click(object sender, EventArgs e)
        {
            string dfrom = "", dto = "";
            dfrom = dtpfrom.Value.ToString("yyyy-MM-dd");
            dto = dtpto.Value.ToString("yyyy-MM-dd");
            tbl.Clear();
            tbl = db.readdata("select deserved_id as 'رقم العمليه',type_name as 'البيان',money as 'المبلغ',notes as 'ملاحظات',date as 'التاريخ',user_name as 'المستخدم',branch_name as 'الفرع' from deserved where convert(nvarchar,date,105) between N'" + dfrom + "' and N'" + dto + "' and branch_name=N'"+Properties.Settings.Default.branch_name+"'", "");
            dgv.DataSource = tbl;
        }
        //get one type selected in branch open
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string dfrom = "", dto = "";
            dfrom = dtpfrom.Value.ToString("yyyy-MM-dd");
            dto = dtpto.Value.ToString("yyyy-MM-dd");
            tbl.Clear();
            tbl = db.readdata("select deserved_id as 'رقم العمليه',type_name as 'البيان',money as 'المبلغ',notes as 'ملاحظات',date as 'التاريخ',user_name as 'المستخدم',branch_name as 'الفرع' from deserved where convert(nvarchar,date,105) between N'" + dfrom + "' and N'" + dto + "' and branch_name=N'" + Properties.Settings.Default.branch_name + "' and deserved_type_id="+cbxtypes.SelectedValue+"", "");
            dgv.DataSource = tbl;
        }

        private void txtsearchoftype_TextChanged(object sender, EventArgs e)
        {
            if (radiopartoftyepeexpenses.Checked == true)
            {
//search with the part of type name and get data

                tbl.Clear();
                tbl = db.readdata("select type_id as 'رقم النوع',type_name as 'اسم النوع',notes as 'ملاحظات' from deserved_type where type_name like N'%" +txtsearchoftype.Text.Trim()+ "%'", "");
                dgvsearchfortypes.DataSource = tbl;
            }
            
        }
    }
}
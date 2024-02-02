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
    public partial class sand_sarf : DevExpress.XtraEditors.XtraForm
    {
        public sand_sarf()
        {
            InitializeComponent();
        }

        //call databse class
        database db = new database();
        DataTable tbl = new DataTable();

        //autonumber
            private void autonumber()
            {
            //get the id of sand

            tbl.Clear();
                tbl = db.readdata("select*from sandat_id", "");
            //if there is no data set the textbox of id =1
            if (tbl.Rows.Count < 1)
                {
                    db.excutedata("insert into sandat_id values(1000000)", "");
                }
                else if (tbl.Rows.Count >= 1)
                {
                //if there is data set the value of data +1 and set it in the textbox of id
                db.excutedata("update sandat_id set sand_id=sand_id+1", "");
                }
                DataTable tblorder_id = new DataTable();
                tblorder_id.Clear();
                tblorder_id = db.readdata("select*from sandat_id", "");
                txtorder_id.Text = Convert.ToString(tblorder_id.Rows[0][0]);

            lblmoney.Text = "0";
            lblperson_id.Text = "0";
            lblpersonname.Text = "-";
            numircprice.Value = 0;
            txtnotes.Clear();

        }
        //get the id of user stoke
        int stoke_id = Properties.Settings.Default.stoke_id;
        private void sand_sarf_Load(object sender, EventArgs e)
        {
            autonumber();
            dtp.Text = DateTime.Now.ToShortDateString();
            dtp.Text = DateTime.Now.ToShortTimeString();
            dtpfrom.Text = DateTime.Now.ToShortDateString();
            dtpto.Text = DateTime.Now.ToShortDateString();
        }

        //search about data of supplier or customer or employee depending on the user choose
        private void txtpersonnamesearch_TextChanged(object sender, EventArgs e)
        {
            if(radiosarftocustomer.Checked==false&&radiosarftoemployee.Checked==false&&radiosarftosupplier.Checked==false)
            {
                MessageBox.Show("من فضلك حدد عمليه اولا ---من المنصرف له مورد ام-عميل-ام -موظف", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                    
            }
            //supplier
            else if(radiosarftosupplier.Checked==true)
            {
                tbl.Clear();
                tbl = db.readdata("select sup_id as 'رقم المورد',sup_name as 'اسم المورد',identity_id as 'الرقم التعريفي' from suppliers where sup_name like N'%"+txtpersonnamesearch.Text.Trim()+"%'", "");
                dgvperson.DataSource = tbl;
            }
            //customer
            else if(radiosarftocustomer.Checked==true)
            {
                tbl.Clear();
                tbl = db.readdata("select cust_id as 'رقم العميل',cust_name as 'اسم العميل',identity_id as 'الرقم التعريفي' from customers where cust_name like N'%" + txtpersonnamesearch.Text.Trim() + "%'", "");
                dgvperson.DataSource = tbl;
            }
            //employee
            else if(radiosarftoemployee.Checked==true)
            {
                tbl.Clear();
                tbl = db.readdata("select emp_id as 'رقم الموظف',emp_name as 'اسم الموظف',activation as 'نشط ام لا' from add_new_employee where emp_name like N'%" + txtpersonnamesearch.Text.Trim() + "%'", "");
                dgvperson.DataSource = tbl;

            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        //drag the data that user choosed and calculate the amount of mony on the person
        private void btndown_Click(object sender, EventArgs e)
        {
            if(dgvperson.Rows.Count>=1)
            {
                if(numircprice.Value>0)
                {
                    lblmoney.Text = Convert.ToDecimal(numircprice.Value).ToString();
                    int person_id = 0;
                    person_id=Convert.ToInt32(dgvperson.CurrentRow.Cells[0].Value);
                    lblperson_id.Text = person_id.ToString();
                   lblpersonname.Text = Convert.ToString(dgvperson.CurrentRow.Cells[1].Value);

                    decimal leh = 0, sadad = 0, final = 0;
                    DataTable tbltotalall = new DataTable();
                    tbltotalall.Clear();
                    //money on customer
                    if (radiosarftocustomer.Checked == true)
                    {
                        int cust_id = Convert.ToInt32(dgvperson.CurrentRow.Cells[0].Value);
                        tbltotalall = db.readdata("select*from customer_account where cust_id=" + cust_id + "", "");
                        for (int i = 0; i <= tbltotalall.Rows.Count - 1; i++)
                        {
                            leh += Convert.ToDecimal(tbltotalall.Rows[i][9]);
                            sadad += Convert.ToDecimal(tbltotalall.Rows[i][10]);


                        }
                        final = (leh - sadad) + numircprice.Value;
                        lbltotalall.Text = final.ToString();
                    }
                    //money on supplier
                    else if (radiosarftosupplier.Checked == true)
                    {
                        int sup_id = Convert.ToInt32(dgvperson.CurrentRow.Cells[0].Value);
                        tbltotalall = db.readdata("select*from supplier_account where sup_id=" + sup_id + "", "");
                        for (int i = 0; i <= tbltotalall.Rows.Count - 1; i++)
                        {
                            leh += Convert.ToDecimal(tbltotalall.Rows[i][9]);
                            sadad += Convert.ToDecimal(tbltotalall.Rows[i][10]);


                        }
                        final = (leh - sadad) - numircprice.Value;
                        lbltotalall.Text = final.ToString();
                    }
                    //money on employee
                    else if (radiosarftoemployee.Checked == true)
                    {
                        int emp_id = Convert.ToInt32(dgvperson.CurrentRow.Cells[0].Value);
                        tbltotalall = db.readdata("select*from employee_account where emp_id=" + emp_id + "", "");
                        for (int i = 0; i <= tbltotalall.Rows.Count - 1; i++)
                        {
                            leh += Convert.ToDecimal(tbltotalall.Rows[i][5]);
                            sadad += Convert.ToDecimal(tbltotalall.Rows[i][6]);


                        }
                        final = (leh - sadad) + numircprice.Value;
                        lbltotalall.Text = final.ToString();
                    }

                }
            }
            else
            {
                MessageBox.Show("من فضلك ادخل البيانات صحيحه تاكد من المبلغ المدخل وتاكد من اختيا الشخص المنصرف له", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void tileItem4_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Close();
        }
        //printing
        private void print()
        {
            try
            {
                //get he id of operation
                int order_id = Convert.ToInt32(txtorder_id.Text);
                string branch_name = Properties.Settings.Default.branch_name;
                DataTable tblprint = new DataTable();
                tblprint.Clear();
                //quary
                tblprint = db.readdata("select settingprinting_bills.logo as'اللوجو',settingprinting_bills.name as'اسم الشركه',settingprinting_bills.address as'العنوان',settingprinting_bills.phone1 as'تليفون1',settingprinting_bills.phone2 as'تليفون2',settingprinting_bills.phone3 as'تليفون3',settingprinting_bills.commerical_re as'الرقم التجاري',settingprinting_bills.tax_re as'الرقم الضريبي',order_id as 'رقم السند',type as 'نوع السند',person_name as'اسم الشخص',money as'المبلغ',date as'التاريخ',notes as'ملاحظات',user_name as'المستخدم',branch as'الفرع' from sand_sarf,settingprinting_bills where order_id=" + order_id + " and branch=N'" + Properties.Settings.Default.branch_name + "' ", "");
                printing frm = new printing();
                frm.crystalReportViewer1.RefreshReport();
                //report form 
                sand_sarf_print rpt = new sand_sarf_print();
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
        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            if(lblmoney.Text=="0")
            {
                MessageBox.Show("من فضلك قم بتحدد المبلغ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(lblperson_id.Text=="0")
            {
                MessageBox.Show("من فضلك قم باختيار الشخص", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(lblpersonname.Text=="-")
            {
                MessageBox.Show("من فضلك قم باختيار الشخص", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           //check if there is money on the stoke or not
                decimal stoke_money = 0;
                tbl.Clear();
                tbl = db.readdata("select*from stoke_money where stoke_id=" + stoke_id + "", "");
                stoke_money = Convert.ToDecimal(tbl.Rows[0][1]);
                if (Convert.ToDecimal(lblmoney.Text) > stoke_money)

                {
                    MessageBox.Show("اجمالي الخزنه غير كافي للصرف ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
            { 
               
                decimal zero = 0;
                string type="";
                //customer
                if(radiosarftocustomer.Checked==true)
                {
                    type = "عميل";
                }
                //employee
                else if(radiosarftoemployee.Checked==true)
                {
                    type = "موظف";
                }
                //supplier
                else if(radiosarftosupplier.Checked==true)
                {
                    type = "مورد";
                }

                string d = dtp.Value.ToString("yyyy-MM-dd");
                string t = dtp.Value.ToString("HH:MM");

                //if user choose supplier
                if (radiosarftosupplier.Checked == true)
                {


                    //ادخال البيانات في صفحه المورد
                    string description = "سند صرف للمورد" + " " + lblpersonname.Text + " " + "سند رقم" + txtorder_id.Text;
                  //  string d = dtp.Value.ToString("yyyy-MM-dd");
                    tbl.Clear();
                    tbl = db.readdata("select*from supplier_account where sup_id="+lblperson_id.Text+"", "");
                    //get the total on supplier
                    decimal leh = 0, sadad = 0, final = 0,balance=0;
                    for (int i=0;i<=tbl.Rows.Count-1;i++)
                    {
                        leh += Convert.ToDecimal(tbl.Rows[i][9]);
                        sadad+= Convert.ToDecimal(tbl.Rows[i][10]);
                    }
                    final += (leh - sadad);
                    balance += final - Convert.ToDecimal(lblmoney.Text);

                    //*supplier account
                    db.excutedata("insert into supplier_account values(" + txtorder_id.Text + "," + lblperson_id.Text + ",N'"+lblpersonname.Text+"',N'"+description+"',N'-',"+zero+","+lblmoney.Text+","+lblmoney.Text+",N'سند صرف',"+zero+","+lblmoney.Text+","+balance+",N'"+Properties.Settings.Default.user_name+"',N'"+Properties.Settings.Default.branch_name+"',N'"+d+"',N'سداد',N'-',"+txtorder_id.Text+")", "");

                    //ادخال البيانات في جدول sand_sarf
                    db.excutedata("insert into sand_sarf values("+txtorder_id.Text+",N'"+type+"',"+Convert.ToInt32(lblperson_id.Text)+",N'"+lblpersonname.Text+"',"+Convert.ToDecimal(lblmoney.Text)+",N'"+d+"',N'"+txtnotes.Text.Trim()+"',N'"+Properties.Settings.Default.user_name+"',N'"+Properties.Settings.Default.branch_name+"')", "تم التنفيذ بنجاح");

                    //الخزنه
                    string order_id = " مسحوبات -سند صرف رقم" + " " + Convert.ToString(txtorder_id.Text)+"للمورد"+" "+lblpersonname.Text;
                    db.excutedata("update stoke_money set money=money-" + Convert.ToDecimal(lblmoney.Text) + "where stoke_id=" + stoke_id + "", "");
                    db.excutedata("insert into stoke_withdrowal (stoke_id,money,date,name,type,notes,user_name,branch_name)values(" + stoke_id + "," + lblmoney.Text + ",'" + d + "',N'سند صرف ل'+N''+N'"+type+"'+N''+N'" +lblpersonname.Text  + "',N'"+order_id+"',N'" +txtnotes.Text.Trim()+ "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "')", "");
                  
                        //autonumber();
                }
                //صرف لعميل
                else if(radiosarftocustomer.Checked==true)
                {
                    string description33 = "سند صرف للعميل" + " " + lblpersonname.Text + " " + "سند رقم" + txtorder_id.Text;
                    string discription33333 = "----صرف----";
                    //customer account
                    db.excutedata("insert into customer_account values(" + txtorder_id.Text + "," + lblperson_id.Text + ",N'" + lblpersonname.Text + "',N'"+description33+"',N'"+discription33333+"'," + zero + ",N'-'," + lblmoney.Text + "," + lblmoney.Text + ","+lblmoney.Text+"," + zero + ",N'-',N'"+txtnotes.Text.Trim()+"',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + d + "',N'سداد',N'"+t+"',"+txtorder_id.Text+")", "");

                    //ادخال البيانات في جدول sand_sarf
                    db.excutedata("insert into sand_sarf values(" + txtorder_id.Text + ",N'" + type + "'," + Convert.ToInt32(lblperson_id.Text) + ",N'" + lblpersonname.Text + "'," + Convert.ToDecimal(lblmoney.Text) + ",N'" + d + "',N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "')", "");

                    //الخزنه
                    string order_id = " مسحوبات -سند صرف رقم" + " " + Convert.ToString(txtorder_id.Text) + " " +" للعميل"+ lblpersonname.Text;
                    db.excutedata("update stoke_money set money=money-" + Convert.ToDecimal(lblmoney.Text) + "where stoke_id=" + stoke_id + "", "");
                    db.excutedata("insert into stoke_withdrowal (stoke_id,money,date,name,type,notes,user_name,branch_name)values(" + stoke_id + "," + lblmoney.Text + ",'" + d + "',N'سند صرف لعميل'+N''+N'" + type + "'+N''+N'" + lblpersonname.Text + "',N'" + order_id + "',N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "')", "تم التنفيذ بنجاح");

//                    autonumber();
                }

                //صرف لموظف
                else if(radiosarftoemployee.Checked==true)
                {
                    string description33 = "سند صرف للموظف" + " " + lblpersonname.Text + " " + "سند رقم" + txtorder_id.Text;
                    db.excutedata("insert into employee_account values(" + txtorder_id.Text + "," + lblperson_id.Text + ",N'" + lblpersonname.Text + "',N'" + description33 + "'," + lblmoney.Text + "," + lblmoney.Text + ",0,N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + d + "',N'سند صرف',N'" + t + "',"+txtorder_id.Text+")", "");

                    //ادخال البيانات في جدول sand_sarf
                    db.excutedata("insert into sand_sarf values(" + txtorder_id.Text + ",N'" + type + "'," + Convert.ToInt32(lblperson_id.Text) + ",N'" + lblpersonname.Text + "'," + Convert.ToDecimal(lblmoney.Text) + ",N'" + d + "',N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "')", "");

                    //الخزنه
                    string order_id = " مسحوبات -سند صرف رقم" + " " + Convert.ToString(txtorder_id.Text)+" "+"للموظف"+lblpersonname.Text;
                    db.excutedata("update stoke_money set money=money-" + Convert.ToDecimal(lblmoney.Text) + "where stoke_id=" + stoke_id + "", "");
                    db.excutedata("insert into stoke_withdrowal (stoke_id,money,date,name,type,notes,user_name,branch_name)values(" + stoke_id + "," + lblmoney.Text + ",'" + d + "',N'سند صرف لموظف'+N''+N'" + type + "'+N''+N'" + lblpersonname.Text + "',N'" + order_id + "',N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "')", "تم التنفيذ بنجاح");

                }
                print();
                autonumber();
            }
           
        }
        //search
        private void btnsearch_Click(object sender, EventArgs e)
        {
            //search between diffrence date
            if (radiofatra.Checked == true)
            {
                string from = "", to = "";
                from = dtpfrom.Value.ToString("yyyy-MM-dd");
                to = dtpto.Value.ToString("yyyy-MM-dd");
                tbl.Clear();
                tbl = db.readdata("select order_id as 'رقم البيان',type as 'نوع البيان',person_name as 'المستفيد',money as 'المبلغ',date as 'التاريخ',notes as 'ملاحظات',user_name as'المستخدم',branch as'الفرع' from sand_sarf where convert(nvarchar,date,105)between N'" + from + "' and N'" + to + "'", "");
                dgvsearch.DataSource = tbl;
            }
            //search with the sand number
            else if(radiosandnumbersearch.Checked==true)
            {
                
                tbl.Clear();
                tbl = db.readdata("select order_id as 'رقم البيان',type as 'نوع البيان',person_name as 'المستفيد',money as 'المبلغ',date as 'التاريخ',notes as 'ملاحظات',user_name as'المستخدم',branch as'الفرع' from sand_sarf where order_id="+txtsandnumbersearch.Text.Trim()+"", "");
                dgvsearch.DataSource = tbl;
            }
        }

        private void radiosarftosupplier_CheckedChanged(object sender, EventArgs e)
        {

        }

        //delete sand
        private void tileItem3_ItemClick(object sender, TileItemEventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من حذف هذا السداد ؟", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (dgvsearch.Rows.Count >= 1)
                {
                    string sarfto = Convert.ToString(dgvsearch.CurrentRow.Cells[1].Value);
                    int order_id = Convert.ToInt32(dgvsearch.CurrentRow.Cells[0].Value);
                    decimal money = Convert.ToDecimal(dgvsearch.CurrentRow.Cells[3].Value);
                    if (sarfto == "عميل")
                    {
                        db.excutedata("delete from customer_account where order_id=" + order_id + "", "");

                    }
                    else if (sarfto == "مورد")
                    {
                        db.excutedata("delete from supplier_account where order_id=" + order_id + "", "");

                    }
                    else if (sarfto == "موظف")
                    {
                        db.excutedata("delete from employee_account where order_id=" + order_id + "", "");

                    }
                    db.excutedata("delete from stoke_withdrowal where order_id2=" + order_id + "", "");
                    db.excutedata("update stoke_money set money=money+" + money + " where stoke_id=" + Properties.Settings.Default.stoke_id + "", "");
                    db.excutedata("delete from sand_sarf where order_id=" + order_id + "", "");
                    MessageBox.Show("تم تنفيذ العمليه بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
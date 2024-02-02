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
    public partial class sand_kabd : DevExpress.XtraEditors.XtraForm
    {
        public sand_kabd()
        {
            InitializeComponent();
        }
       // call database class
        DataTable tbl = new DataTable();
        database db = new database();

        //autonumber
        private void autonumber()
        {
            //get the id of sand
            tbl.Clear();
            tbl = db.readdata("select*from sandat_id", "");
            //if there is no data set the textbox of id =1
            if(tbl.Rows.Count<1)
            {
                db.excutedata("insert into sandat_id values(1000000)", "");
            }
            //if there is data set the value of data +1 and set it in the textbox of id
            else if(tbl.Rows.Count>=1)
            {
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
        private void sand_kabd_Load(object sender, EventArgs e)
        {
            autonumber();
            dtp.Text = DateTime.Now.ToShortDateString();
            dtp.Text = DateTime.Now.ToShortTimeString();
            dtpsearch.Text = DateTime.Now.ToShortDateString();
            dtpto.Text = DateTime.Now.ToShortDateString();
        }
        //search about the supplier or customer or employee
        private void txtpersonnamesearch_TextChanged(object sender, EventArgs e)
        {
            //validations
            if (radiocustomer.Checked == false && radioemployee.Checked == false && radiosupplier.Checked == false)
            {
                MessageBox.Show("من فضلك حدد عمليه اولا ---من المقبوض منه  مورد ام-عميل-ام -موظف", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

                //customer
            }
            else if (radiocustomer.Checked == true)
            {
                tbl.Clear();
                tbl = db.readdata("select cust_id as 'رقم العميل',cust_name as 'اسم العميل',identity_id as 'الرقم التعريفي' from customers where cust_name like N'%" + txtpersonnamesearch.Text.Trim() + "%'", "");
                dgvperson.DataSource = tbl;
            }
            //supplier
            else if(radiosupplier.Checked==true)
            {
                tbl.Clear();
                tbl = db.readdata("select sup_id as 'رقم المورد',sup_name as 'اسم المورد',identity_id as 'الرقم التعريفي' from suppliers where sup_name like N'%" + txtpersonnamesearch.Text.Trim() + "%'", "");
                dgvperson.DataSource = tbl;
            }
            //employee
            else if(radioemployee.Checked==true)
            {
                tbl.Clear();
                tbl = db.readdata("select emp_id as 'رقم الموظف',emp_name as 'اسم الموظف',activation as 'نشط ام لا' from add_new_employee where emp_name like N'%"+txtpersonnamesearch.Text.Trim()+"%'", "");
                dgvperson.DataSource = tbl;
            }
        }
        //drag the data
        private void btndown_Click(object sender, EventArgs e)
        {
            if (dgvperson.Rows.Count >= 1)
            {
                if (numircprice.Value > 0)
                {
                    //set the selection data into the labels and tools to validate it
                    lblmoney.Text = Convert.ToDecimal(numircprice.Value).ToString();
                    int person_id = 0;
                    person_id = Convert.ToInt32(dgvperson.CurrentRow.Cells[0].Value);
                    lblperson_id.Text = person_id.ToString();
                    lblpersonname.Text = Convert.ToString(dgvperson.CurrentRow.Cells[1].Value);
                    decimal leh = 0, sadad = 0, final = 0;
                    DataTable tbltotalall = new DataTable();
                    tbltotalall.Clear();
                    //if customers selection get the total money on it
                    if (radiocustomer.Checked == true)
                    {
                        int cust_id = Convert.ToInt32(dgvperson.CurrentRow.Cells[0].Value);
                        tbltotalall = db.readdata("select*from customer_account where cust_id="+cust_id+"", "");
                        for(int i=0;i<=tbltotalall.Rows.Count-1;i++)
                        {
                            leh += Convert.ToDecimal(tbltotalall.Rows[i][9]);
                           sadad+= Convert.ToDecimal(tbltotalall.Rows[i][10]);


                        }
                        final = (leh - sadad)-numircprice.Value;
                        lbltotalall.Text = final.ToString();
                    }
                    //if supplier selection get the total money on it
                    else if (radiosupplier.Checked==true)
                    {
                        int sup_id = Convert.ToInt32(dgvperson.CurrentRow.Cells[0].Value);
                        tbltotalall = db.readdata("select*from supplier_account where sup_id=" + sup_id + "", "");
                        for (int i = 0; i <= tbltotalall.Rows.Count - 1; i++)
                        {
                            leh += Convert.ToDecimal(tbltotalall.Rows[i][9]);
                            sadad += Convert.ToDecimal(tbltotalall.Rows[i][10]);


                        }
                        final = (leh - sadad) + numircprice.Value;
                        lbltotalall.Text = final.ToString();
                    }
                    //if employee selection get the total money on it
                    else if (radioemployee.Checked==true)
                    {
                        int emp_id = Convert.ToInt32(dgvperson.CurrentRow.Cells[0].Value);
                        tbltotalall = db.readdata("select*from employee_account where emp_id=" + emp_id + "", "");
                        for (int i = 0; i <= tbltotalall.Rows.Count - 1; i++)
                        {
                            leh += Convert.ToDecimal(tbltotalall.Rows[i][5]);
                            sadad += Convert.ToDecimal(tbltotalall.Rows[i][6]);


                        }
                        final = (leh - sadad) - numircprice.Value;
                        lbltotalall.Text = final.ToString();
                    }
                    }

            }
            else
            {
                MessageBox.Show("من فضلك ادخل البيانات صحيحه تاكد من المبلغ المدخل وتاكد من اختيار الشخص المقبوض له", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //pinting
        private void print()
        {
            try
            {
                //get the id of the operation
                int order_id = Convert.ToInt32(txtorder_id.Text);
                string branch_name = Properties.Settings.Default.branch_name;
                //quary
                DataTable tblprint = new DataTable();
                tblprint.Clear();
                tblprint = db.readdata("select settingprinting_bills.logo as'اللوجو',settingprinting_bills.name as'اسم الشركه',settingprinting_bills.address as'العنوان',settingprinting_bills.phone1 as'تليفون1',settingprinting_bills.phone2 as'تليفون2',settingprinting_bills.phone3 as'تليفون3',settingprinting_bills.commerical_re as'الرقم التجاري',settingprinting_bills.tax_re as'الرقم الضريبي',order_id as 'رقم السند',type as 'نوع السند',person_name as'اسم الشخص',money as'المبلغ',date as'التاريخ',notes as'ملاحظات',user_name as'المستخدم',branch as'الفرع' from sand_kabd,settingprinting_bills where order_id=" + order_id + " and branch=N'"+Properties.Settings.Default.branch_name+"' ", "");
                printing frm = new printing();
                frm.crystalReportViewer1.RefreshReport();
                //report form
                sand_kabd_print rpt = new sand_kabd_print();
                rpt.SetDatabaseLogon("", "", Properties.Settings.Default.servername, Properties.Settings.Default.databasename);
                rpt.SetDataSource(tblprint);
                //set parameters
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
        //save operation
        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            //set date formate
            string d = "", type = "", t = "";
            d = dtp.Value.ToString("yyyy-MM-dd");
            t = dtp.Value.ToString("HH-MM");
            type = "سداد";
            //validations
            if (lblmoney.Text == "0")
            {
                MessageBox.Show("من فضلك قم بتحدد المبلغ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (lblperson_id.Text == "0")
            {
                MessageBox.Show("من فضلك قم باختيار الشخص", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (lblpersonname.Text == "-")
            {
                MessageBox.Show("من فضلك قم باختيار الشخص", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //if user choose customer or suppliers or employee
                string typesand = "";
                if (radiocustomer.Checked == true)
                {
                    typesand = "عميل";
                }
                else if (radiosupplier.Checked == true)
                {
                    typesand = "مورد";
                }
                else if (radioemployee.Checked == true)
                {
                    typesand = "موظف";
                }
                //customer
                if (radiocustomer.Checked == true)
                {
                    //insert into customer account
                    string description = "سداد نقدي من العميل" + " " + lblpersonname.Text + "عمليه سند ىرقم" + txtorder_id.Text;
                    db.excutedata("insert into customer_account values("+txtorder_id.Text+","+lblperson_id.Text+",N'"+lblpersonname.Text+"',N'"+description+"',N'-',0,N'-',"+lblmoney.Text+","+lblmoney.Text+",0,"+lblmoney.Text+",N'',N'"+txtnotes.Text+"',N'"+Properties.Settings.Default.user_name+"',N'"+Properties.Settings.Default.branch_name+"',N'"+d+"',N'"+type+"',N'"+t+"',"+txtorder_id.Text+")", "");

                    //ادخال السند نفسه في sand_kabd
                   //insert sand to sand_kabd
                    db.excutedata("insert into sand_kabd values("+txtorder_id.Text+",N'"+typesand+"',"+lblperson_id.Text+",N'"+lblpersonname.Text+"',"+lblmoney.Text+",N'"+d+"',N'"+txtnotes.Text.Trim()+"',N'"+Properties.Settings.Default.user_name+"',N'"+Properties.Settings.Default.branch_name+"',N'"+t+"')", "");
                    //الخزنه
                    db.excutedata("update stoke_money set money=money+"+lblmoney.Text+" where stoke_id="+stoke_id+"", "");
                    db.excutedata("insert into stoke_insert(stoke_id,money,date,name,type,notes,user_name,branch_name,order_id2) values ("+stoke_id+","+lblmoney.Text+",N'"+d+"',N'"+description+"',N'"+type+"',N'"+txtnotes.Text+"',N'"+Properties.Settings.Default.user_name+"',N'"+Properties.Settings.Default.branch_name+"',"+txtorder_id.Text+")", "");

                    MessageBox.Show("تم الاستقبال بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //قبض من موردsuppliers
                else if(radiosupplier.Checked==true)
                {
                    string description = "قبض من المورد" + " " + lblpersonname.Text + "عمليه قبض ىرقم" + txtorder_id.Text;
                    string discrption2 = "----قبض----";
                    //supplier account
                    db.excutedata("insert into supplier_account values(" + txtorder_id.Text + "," + lblperson_id.Text + ",N'" + lblpersonname.Text + "',N'" + description + "',N'"+discrption2+"',0," + lblmoney.Text + "," + lblmoney.Text + ",N'"+txtnotes.Text+"'," + lblmoney.Text + ",0,0,N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + d + "',N'" + type + "',N'-',"+txtorder_id.Text+")", "");
                    
                    //ادخال السند نفسه في sand_kabd

                    db.excutedata("insert into sand_kabd values(" + txtorder_id.Text + ",N'" + typesand + "'," + lblperson_id.Text + ",N'" + lblpersonname.Text + "'," + lblmoney.Text + ",N'" + d + "',N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + t + "')", "");
                    //الخزنه
                    db.excutedata("update stoke_money set money=money+" + lblmoney.Text + " where stoke_id=" + stoke_id + "", "");
                    db.excutedata("insert into stoke_insert(stoke_id,money,date,name,type,notes,user_name,branch_name,order_id2) values (" + stoke_id + "," + lblmoney.Text + ",N'" + d + "',N'" + description + "',N'" + type + "',N'" + txtnotes.Text + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',"+txtorder_id.Text+")", "");

                    MessageBox.Show("تم الاستقبال بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //قبض من موظف
                else if(radioemployee.Checked==true)
                {
                    string description = "قبض من الموظف" + " " + lblpersonname.Text + "عمليه قبض ىرقم" + txtorder_id.Text;
                   // string discrption2 = "----قبض----";
                   //employee account
                    db.excutedata("insert into employee_account values(" + txtorder_id.Text + "," + lblperson_id.Text + ",N'" + lblpersonname.Text + "',N'" + description + "',0,0," + lblmoney.Text + ",N'" + txtnotes.Text + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + d + "',N'" + type + "',N'"+t+"',"+txtorder_id.Text+")", "");

                    //ادخال السند نفسه في sand_kabd

                    db.excutedata("insert into sand_kabd values(" + txtorder_id.Text + ",N'" + typesand + "'," + lblperson_id.Text + ",N'" + lblpersonname.Text + "'," + lblmoney.Text + ",N'" + d + "',N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'" + t + "')", "");
                    //الخزنه
                    db.excutedata("update stoke_money set money=money+" + lblmoney.Text + " where stoke_id=" + stoke_id + "", "");
                    db.excutedata("insert into stoke_insert(stoke_id,money,date,name,type,notes,user_name,branch_name,order_id2) values (" + stoke_id + "," + lblmoney.Text + ",N'" + d + "',N'" + description + "',N'" + type + "',N'" + txtnotes.Text + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',"+txtorder_id.Text+")", "");

                    MessageBox.Show("تم الاستقبال بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                print();
                autonumber();

            }
        }
        //search
        private void btnchange_Click(object sender, EventArgs e)
        {
            //search by two dates diffrent
            if (radiofatra.Checked == true)
            {
                string from = "", to = "";
                from = dtpsearch.Value.ToString("yyyy-MM-dd");
                to = dtpto.Value.ToString("yyyy-MM-dd");
                tbl.Clear();
                tbl = db.readdata("select order_id as'رقم البيان',type as 'بيان ل',person_name as 'قبض من',money as 'المبلغ',date as'التاريخ',notes as 'ملاحظات',user_name as 'المستخدم',branch as'الفرع',time as 'الوقن' from sand_kabd where convert(nvarchar,date,105)between N'" + from + "' and N'" + to + "'", "");
                dgv.DataSource = tbl;
            }
            //search with the number of sand

            else if(radiosandnumbersearch.Checked==true)
            {
                if(txtsandnumbersearch.Text=="")
                {
                    MessageBox.Show("من فضلك ادخل رقم السند اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    tbl.Clear();
                    tbl = db.readdata("select order_id as'رقم البيان',type as 'بيان ل',person_name as 'قبض من',money as 'المبلغ',date as'التاريخ',notes as 'ملاحظات',user_name as 'المستخدم',branch as'الفرع',time as 'الوقن' from sand_kabd where order_id="+txtsandnumbersearch.Text.Trim()+"", "");
                    dgv.DataSource = tbl;
                }
            }
        }

        private void tileItem2_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        //delete the sand
        private void tileItem3_ItemClick(object sender, TileItemEventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من حذف هذا السداد ؟", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (dgv.Rows.Count >= 1)
                {
                    //select the money and order id of sand and sand from to can delete
                    string kabdfrom = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
                    int order_id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                    decimal money = Convert.ToDecimal(dgv.CurrentRow.Cells[3].Value);
                    //customer
                    if (kabdfrom == "عميل")
                    {
                        db.excutedata("delete from customer_account where order_id=" + order_id + "", "");

                    }
                    //supplier
                    else if (kabdfrom == "مورد")
                    {
                        db.excutedata("delete from supplier_account where order_id=" + order_id + "", "");

                    }
                    //employee
                    else if (kabdfrom == "موظف")
                    {
                        db.excutedata("delete from employee_account where order_id=" + order_id + "", "");

                    }
                    //delete from stoke insert
                    db.excutedata("delete from stoke_insert where order_id2=" + order_id + "", "");
                    //update from stoke money
                    db.excutedata("update stoke_money set money=money-" + money + " where stoke_id=" + Properties.Settings.Default.stoke_id + "", "");
                    //delete from sand kabd
                    db.excutedata("delete from sand_kabd where order_id=" + order_id + "", "");
                    MessageBox.Show("تم تنفيذ العمليه بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
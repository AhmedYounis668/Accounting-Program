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
    public partial class transferefrombanktokhaznaandother : DevExpress.XtraEditors.XtraForm
    {
        public transferefrombanktokhaznaandother()
        {
            InitializeComponent();
        }

        DataTable tbl = new DataTable();
        database db = new database();

        private void fillcbx()
        {
            cbxkhaznaname.DataSource = db.readdata("select*from stokes", "");
            cbxkhaznaname.DisplayMember = "stoke_name";
            cbxkhaznaname.ValueMember = "stoke_id";

            cbxbank_name.DataSource = db.readdata("select*from bankes", "");
            cbxbank_name.DisplayMember = "bank_name";
            cbxbank_name.ValueMember = "bank_id";
        }
        private void transferefrombanktokhaznaandother_Load(object sender, EventArgs e)
        {
            dtpdate.Text = DateTime.Now.ToShortDateString();
            fillcbx();
            cbxbank_name.Text = "اختر بنك";
            cbxkhaznaname.Text = "اختر خزنه";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            string d = "";
            d = dtpdate.Value.ToString("yyyy-MM-dd");
            if(radioconvertfrom_bank_to_khazna.Checked==false&&radioconvertfrom_khazna_to_bank.Checked==false)
            {
                MessageBox.Show("من فضلك حدد عمليه اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
          if(cbxkhaznaname.Text=="اختر خزنه")
            {
                MessageBox.Show("من فضلك اختر الخزنه اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
          if(cbxbank_name.Text=="اختر بنك")
            {
                MessageBox.Show("من فضلك اختر البنك اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(lbltotalbanknow.Text== ".............")
            {
                MessageBox.Show("من فضلك اختر البنك اولا", "خطا",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if(lbltotal_khaznanow.Text== ".............")
            {
                MessageBox.Show("من فضلك اختر الخزنه اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (numericconvertfromto.Value <= 0)
            {
                MessageBox.Show("لايجب ان يكون المبلغ المحول اقل من او يساوي صفر ....من فضلك تاكد من بياناتك", "تنبيه هام", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (numericconvertfromto.Value > Convert.ToDecimal(lbltotal_khaznanow.Text))
            {
                MessageBox.Show("القيمه المراد تحويلها اكبر من القيمه الموجوده في الخزنه الاولي -الخزنه المحول منها- ....من فضلك تاكد من بياناتك", "تنبيه هام !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtnameofmasaoul.Text == "")
            {

                MessageBox.Show("من فضلك ادخل اسم المسؤل عن هذا التحويل اولا", "تنبيه هام", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txttransferenumber.Text == "")
            {

                MessageBox.Show("من فضلك ادخل رقم التحويل", "تنبيه هام", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (radioconvertfrom_khazna_to_bank.Checked == true)
            {
                if (numericconvertfromto.Value > Convert.ToDecimal(lbltotal_khaznanow.Text))
                {
                    MessageBox.Show("من فضلك انتبه المبلغ الموجود في الخزنه المحدده غير كافي للمبلغ المطلوب سحبه", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {

                    string type = "تحويل من الخزنه الي البنك خزنه" + " " + cbxkhaznaname.Text + " " + "الي بنك" + " " + cbxbank_name.Text;
                    db.excutedata("update stoke_money set money=money-" + numericconvertfromto.Value + "where stoke_id=" + cbxkhaznaname.SelectedValue + "", "");
                    db.excutedata("update bank_money set money=money+" + numericconvertfromto.Value + "where bank_id=" + cbxbank_name.SelectedValue + "", "");
                    db.excutedata("insert into bank_insert (bank_id,money,date,name,type,notes,user_name,branch_name)values(" + cbxbank_name.SelectedValue + "," + numericconvertfromto.Value + ",'" + d + "',N'" + txtnameofmasaoul.Text + "',N'" + type + "',N'" + txtnotes.Text + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "')", "");

                    db.excutedata("insert into stoke_withdrowal (stoke_id,money,date,name,type,notes,user_name,branch_name)values(" + cbxkhaznaname.SelectedValue + "," + numericconvertfromto.Value + ",'" + d + "',N'" + txtnameofmasaoul.Text + "',N'" + type + "',N'" + txtnotes.Text + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "')", "");
                    db.excutedata("insert into  stoke_andbank_transfere(transfrom,transto,money,date,type,notes,name,user_name,branch_name,typeoperation,transnumber) values(" + cbxkhaznaname.SelectedValue + "," + cbxbank_name.SelectedValue + "," + numericconvertfromto.Value + ",'" + d + "',N'" + type + "',N'" + txtnotes.Text + "',N'" + txtnameofmasaoul.Text + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'تحويل من الخزنه'," + txttransferenumber.Text.Trim() + ")", "تم التحويل بنجاح");

                    txttransferenumber.Clear();
                    txtnameofmasaoul.Clear();
                    txtnotes.Clear();
                    radioconvertfrom_bank_to_khazna.Checked = false;
                    radioconvertfrom_khazna_to_bank.Checked = false;
                    cbxbank_name.Text = "اختر بنك";
                    cbxkhaznaname.Text = "اختر خزنه";
                    lbltotal_khaznanow.Text = ".............";
                    lbltotalbanknow.Text = ".............";
                }
            }
            else if (radioconvertfrom_bank_to_khazna.Checked == true)
            {
                if (numericconvertfromto.Value > Convert.ToDecimal(lbltotalbanknow.Text))
                {
                    MessageBox.Show("من فضلك انتبه المبلغ الموجود في البنك المحدد غير كافي للمبلغ المطلوب سحبه", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    string typeee = "تحويل من البنك الي الخزنه بنك" + " " + cbxbank_name.Text + " " + "الي خزنه" + " " + cbxkhaznaname.Text;

                    db.excutedata("update bank_money set money=money-" + numericconvertfromto.Value + " where bank_id=" + cbxbank_name.SelectedValue + "", "");
                    db.excutedata("update stoke_money set money=money+" + numericconvertfromto.Value + "where stoke_id=" + cbxkhaznaname.SelectedValue + "", "");
                    db.excutedata("insert into stoke_insert(stoke_id,money,date,name,type,notes,user_name,branch_name) values(" + cbxkhaznaname.SelectedValue + "," + numericconvertfromto.Value + ",N'" + d + "',N'" + txtnameofmasaoul.Text + "',N'" + typeee + "',N'" + txtnotes.Text + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "')", "");
                    
                    db.excutedata("insert into bank_withdrowal (bank_id,bank_money,money,date,name,type,notes,user_name,branch_name)values(" + cbxbank_name.SelectedValue + ","+lbltotalbanknow.Text+"," + numericconvertfromto.Value + ",N'" + d + "',N'" + txtnameofmasaoul.Text + "',N'" + typeee + "',N'" + txtnotes.Text + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "')", "");
                  
                    db.excutedata("insert into  stoke_andbank_transfere(transfrom,transto,money,date,type,notes,name,user_name,branch_name,typeoperation,transnumber) values(" + cbxbank_name.SelectedValue + "," + cbxkhaznaname.SelectedValue + "," + numericconvertfromto.Value + ",N'" + d + "',N'" + typeee + "',N'" + txtnotes.Text + "',N'" + txtnameofmasaoul.Text + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "',N'تحويل من البنك'," + txttransferenumber.Text.Trim() + ")", "تم التحويل بنجاح");

                    txttransferenumber.Clear();
                    txtnameofmasaoul.Clear();
                    txtnotes.Clear();
                    radioconvertfrom_bank_to_khazna.Checked = false;
                    radioconvertfrom_khazna_to_bank.Checked = false;
                    cbxbank_name.Text = "اختر بنك";
                    cbxkhaznaname.Text = "اختر خزنه";
                    lbltotal_khaznanow.Text = ".............";
                    lbltotalbanknow.Text = ".............";
                }
            }

            //  stoke_andbank_transfere
        }

        private void cbxkhaznaname_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readdata("select*from stoke_money where stoke_id=" + cbxkhaznaname.SelectedValue + "", "");
            if (tbl.Rows.Count <= 0)
            {
                db.excutedata("insert into stoke_money values(" + cbxkhaznaname.SelectedValue + ",'0')", "");
                tbl = db.readdata("select*from stoke_money where stoke_id=" + cbxkhaznaname.SelectedValue + "", "");

            }
            if (Convert.ToDecimal(tbl.Rows[0][1]) <= 0)
            {
                lbltotal_khaznanow.Text = Convert.ToDecimal(tbl.Rows[0][1]).ToString();
            }
            else if (Convert.ToDecimal(tbl.Rows[0][1]) >= 1)
            {
                lbltotal_khaznanow.Text = Convert.ToDecimal(tbl.Rows[0][1]).ToString();
            }
        }

        private void cbxbank_name_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readdata("select*from bank_money where bank_id=" + cbxbank_name.SelectedValue + "", "");
            if (tbl.Rows.Count <= 0)
            {
                db.excutedata("insert into bank_money values(" +cbxbank_name.SelectedValue + ",'0')", "");
                tbl = db.readdata("select*from bank_money where bank_id=" + cbxbank_name.SelectedValue + "", "");

            }
            if (Convert.ToDecimal(tbl.Rows[0][1]) <= 0)
            {
                lbltotalbanknow.Text = Convert.ToDecimal(tbl.Rows[0][1]).ToString();
            }
            else if (Convert.ToDecimal(tbl.Rows[0][1]) >= 1)
            {
                lbltotalbanknow.Text = Convert.ToDecimal(tbl.Rows[0][1]).ToString();
            }
        }
    }
}
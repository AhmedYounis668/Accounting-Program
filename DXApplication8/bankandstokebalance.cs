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
    public partial class bankandstokebalance : DevExpress.XtraEditors.XtraForm
    {
        public bankandstokebalance()
        {
            InitializeComponent();
        }
        //call database class
        DataTable tbl = new DataTable();
        database db = new database();

        //fill comboboxes of stokes and bankes
        private void fillcbx()
        {
            //stokes
            cbxstkes.DataSource = db.readdata("select*from stokes", "");
            cbxstkes.DisplayMember = "stoke_name";
            cbxstkes.ValueMember = "stoke_id";

            //bankes
            cbxbankes.DataSource = db.readdata("select* from bankes", "");
            cbxbankes.DisplayMember = "bank_name";
            cbxbankes.ValueMember = "bank_id";
        }
        private void bankandstokebalance_Load(object sender, EventArgs e)
        {
          
            fillcbx();
            cbxstkes.Text = "اختر خزنه";
            cbxbankes.Text = "اختر بنك";

        }

        //when chooce stokes show the balance of selected stokes
        private void cbxstkes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(cbxstkes.Text== "اختر خزنه")
            {
                MessageBox.Show("من فضلك اختر خزن اولا","خطا",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            tbl.Clear();
            tbl = db.readdata("select*from stoke_money where stoke_id="+cbxstkes.SelectedValue+"", "");

            lbltotalbalancestoke.Text = Convert.ToString(tbl.Rows[0][1]);


        }

        //whene cjhooce bank show the balance of selected bank
        private void cbxbankes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(cbxbankes.Text=="اختر بنك")
            {
                MessageBox.Show("من فضلك اختر بنك اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tbl.Clear();
            tbl = db.readdata("select*from bank_money where bank_id=" + cbxstkes.SelectedValue + "", "");

            lbltotalbalancebank.Text = Convert.ToString(tbl.Rows[0][1]);
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            //search abut data depending on the operation selected bank or stoke
            DataTable tblsearch = new DataTable();
            tblsearch.Clear();
            if (radiobankes.Checked==false&&radiostokes.Checked==false)
            {
                MessageBox.Show("من فضلك حدد عمليه اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
               //stokes
                if(radiostokes.Checked==true)
                {
                    tblsearch = db.readdata("select  stokes.stoke_id as'رقم الخزنه',stokes.stoke_name as'اسم الخزنه',money as'الاجمالي في الخزنه' from stoke_money,stokes where stokes.stoke_id=stoke_money.stoke_id", "");
                    dgv.DataSource = tblsearch;
                }
                //bankes
                else if(radiobankes.Checked==true)
                {
                    tblsearch = db.readdata("select bankes.bank_id as'رقم البنك',bankes.bank_name as'اسم البنك',money as'الاجمالي في البنك' from bank_money,bankes where bankes.bank_id=bank_money.bank_id", "");
                    dgv.DataSource = tblsearch;
                }
            }
        }
    }
}
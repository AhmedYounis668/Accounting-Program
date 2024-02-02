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
    public partial class transferfromkhaznatokhazna : DevExpress.XtraEditors.XtraForm
    {
        public transferfromkhaznatokhazna()
        {
            InitializeComponent();
        }

        //call database class
        DataTable tbl = new DataTable();
        database db = new database();

        //fill comboboxes with stokes
        private void fillcbx()
        {
            cbxstoketransfere_from.DataSource = db.readdata("select*from stokes ", "");
            cbxstoketransfere_from.DisplayMember = "stoke_name";
            cbxstoketransfere_from.ValueMember = "stoke_id";

           cbxstoketransfere_to.DataSource = db.readdata("select*from stokes ", "");
           cbxstoketransfere_to.DisplayMember = "stoke_name";
           cbxstoketransfere_to.ValueMember = "stoke_id";


        }

        private void transferfromkhaznatokhazna_Load(object sender, EventArgs e)
        {
            dtpdate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            fillcbx();
        }

        private void tileItem4_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Close();
        }

        //drag data in datagridview
        private void btndown_Click(object sender, EventArgs e)
        {
            //validations before drag
            if (cbxstoketransfere_from.Text == cbxstoketransfere_to.Text)
            {
                MessageBox.Show("من فضلك انتبه انت تقوم بعمل تحويل الي نفس الخزنه ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(numircprice.Value==0)
            {
                MessageBox.Show("من فضلك ادخل المبلغ المحول", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //get data of stokes selected
                DataTable tblstokefrom = new DataTable();
                tblstokefrom.Clear();

                tblstokefrom = db.readdata("select*from stokes where stoke_id=" + cbxstoketransfere_from.SelectedValue + "", "");

                DataTable tblstoketo = new DataTable();
                tblstoketo.Clear();
                tblstoketo = db.readdata("select*from stokes where stoke_id=" + cbxstoketransfere_to.SelectedValue + "", "");



                if (tblstokefrom.Rows.Count >= 1)
                {
                    if (tblstoketo.Rows.Count >= 1)
                    {

                        int stokefrom_id = Convert.ToInt32(tblstokefrom.Rows[0][0]);
                        string stokefrom_name = tblstokefrom.Rows[0][1].ToString();
                        int stoketo_id = Convert.ToInt32(tblstoketo.Rows[0][0]);
                        string stoketo_name = tblstoketo.Rows[0][1].ToString();
                        decimal money = numircprice.Value;

                        string d = dtpdate.Value.ToString("yyyy-MM-dd");
                        //decimal balance1 = 0;
                        //decimal balance2 = 0;

                       
                        //drag variables into datagridview


                        dgv.Rows.Add(1);
                        int rowindex = dgv.Rows.Count - 1;

                        dgv.Rows[rowindex].Cells[0].Value = stokefrom_id;
                        dgv.Rows[rowindex].Cells[1].Value = stokefrom_name;
                        dgv.Rows[rowindex].Cells[2].Value = money;
                        dgv.Rows[rowindex].Cells[3].Value = stoketo_id;
                        dgv.Rows[rowindex].Cells[4].Value = stoketo_name;

                        dgv.Rows[rowindex].Cells[6].Value = d;
                        //dgv.Rows[rowindex].Cells[7].Value = balance1;
                        //dgv.Rows[rowindex].Cells[8].Value = balance2;
                        dgv.Rows[rowindex].Cells[7].Value = dgv.Rows.Count;
                    }
                }
            }
        }

        private void tileItem5_ItemClick(object sender, TileItemEventArgs e)
        {
            dgv.Rows.Clear();
            txtnotes.Clear();

        }

        //action add
        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            if (dgv.Rows.Count >= 1)
            {
                for (int i = 0; i <= dgv.Rows.Count - 1; i++)
                {
                    string type = "تحويل من الخزنه"+" " + Convert.ToString(dgv.Rows[i].Cells[1].Value)+"الي الخزنه"+" "+Convert.ToString(dgv.Rows[i].Cells[4].Value);
                   
                    db.excutedata("insert into transferebetweenstokes(stokefrom_id,stokefrom_name,money,stoketo_id,stoketo_name,date,row_nomber,note_row,notes,user_name,branch_name) values(" + dgv.Rows[i].Cells[0].Value + ",N'" + dgv.Rows[i].Cells[1].Value + "',"+dgv.Rows[i].Cells[2].Value+","+dgv.Rows[i].Cells[3].Value+",N'"+ dgv.Rows[i].Cells[4].Value + "',N'"+ dgv.Rows[i].Cells[6].Value + "',"+ dgv.Rows[i].Cells[7].Value + ",N'"+ dgv.Rows[i].Cells[5].Value + "',N'"+txtnotes.Text.Trim()+"',N'"+Properties.Settings.Default.user_name+"',N'"+Properties.Settings.Default.branch_name+"')", "");
                    db.excutedata("insert into stoke_insert(stoke_id,money,date,name,type,notes,user_name,branch_name) values(" + dgv.Rows[i].Cells[3].Value + "," + dgv.Rows[i].Cells[2].Value + ",N'"+ dgv.Rows[i].Cells[6].Value + "',N'"+type+"',N'" + type + "',N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "',N'" + Properties.Settings.Default.branch_name + "')", "");
                    db.excutedata("insert into stoke_withdrowal(stoke_id,money,date,name,type,notes,user_name,branch_name) values("+ dgv.Rows[i].Cells[0].Value + ","+ dgv.Rows[i].Cells[2].Value + ",N'"+ dgv.Rows[i].Cells[6].Value + "',N'"+type+"',N'"+type+"',N'"+txtnotes.Text.Trim()+"',N'"+Properties.Settings.Default.user_name+"',N'"+Properties.Settings.Default.branch_name+"')", "");
                    db.excutedata("update stoke_money set money=money+"+dgv.Rows[i].Cells[2].Value+" where stoke_id="+ dgv.Rows[i].Cells[3].Value + "", "");
                    db.excutedata("update stoke_money set money=money-" + dgv.Rows[i].Cells[2].Value + " where stoke_id=" + dgv.Rows[i].Cells[0].Value + "", "");

                }
                MessageBox.Show("تم التحويل", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv.Rows.Clear();
                txtnotes.Clear();
            }
        }

        //delete row from datagridview
        private void tileItem3_ItemClick(object sender, TileItemEventArgs e)
        {
            try
            {
                if (dgv.Rows.Count >= 1)
                {
                    int index = dgv.SelectedRows[0].Index;
                    dgv.Rows.RemoveAt(index);

                   
                    dgv.ClearSelection();
                    dgv.FirstDisplayedScrollingRowIndex = dgv.Rows.Count - 1;
                    dgv.Rows[dgv.Rows.Count - 1].Selected = true;
                }

            }
            catch (Exception) { }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using System.Drawing.Printing;
using System.Data.SqlClient;

namespace DXApplication8
{
    public partial class program_setting : DevExpress.XtraEditors.XtraForm
    {
        public program_setting()
        {
            InitializeComponent();
        }
        //call database class
        DataTable tbl = new DataTable();
        database db = new database();

        //عرض الطابعات الموصله بالجهاز
        //====================================================================================
        private void showprinters()
        {
            string printer_name = "";
            for (int i = 0; i <= PrinterSettings.InstalledPrinters.Count - 1; i++)
            {
                printer_name = PrinterSettings.InstalledPrinters[i];
                cbxprinter.Items.Add(printer_name);
            }
            if (Properties.Settings.Default.printername == "")
                cbxprinter.SelectedIndex = 0;
            else
                cbxprinter.Text = Properties.Settings.Default.printername;
        }
        //save the selected printer
        private void btnsaveprinter_Click(object sender, EventArgs e)
        {
            if (cbxprinter.Text == "")
            {
                MessageBox.Show("من فضلك اختر طابعه اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Properties.Settings.Default.printername = cbxprinter.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("تم حفظ الطابعه بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        //show the data when the form load
        private void program_setting_Load(object sender, EventArgs e)
        {
            showprinters();
            showdata();
        }


        //عرض بيانات الفاتوره
        //=================================================
        private void showdata()
        {
            tbl.Clear();
            tbl = db.readdata("select*from settingprinting_bills", "");
            if (tbl.Rows.Count >= 1)
            {
                txtshopename.Text = tbl.Rows[0][1].ToString();
                txtshopaddress.Text = tbl.Rows[0][2].ToString();
                txtdescription.Text = tbl.Rows[0][3].ToString();
                txtphone1.Text = tbl.Rows[0][4].ToString();
                txtphone2.Text = tbl.Rows[0][5].ToString();
                txtphone3.Text = tbl.Rows[0][6].ToString();
                txttax_re.Text = tbl.Rows[0][7].ToString();
                txtcomerical_re.Text = tbl.Rows[0][8].ToString();

            }
            try
            {
                //show the logo
                byte[] byteimage = new byte[0];
                byteimage = (byte[])(tbl.Rows[0][0]);
                MemoryStream memoryStream = new MemoryStream(byteimage);
                picturelogo.BackgroundImageLayout = ImageLayout.Stretch;
                picturelogo.BackgroundImage = Image.FromStream(memoryStream);
            }
            catch (Exception)
            {

            }
        }

        //=========================================



        //داله حفظ الصوره واسترجعها
        private void saveimage(string stmt, string paramitername, string Message)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.\;Initial Catalog=bigbos_tradind;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(stmt, conn);

            FileStream filestream = new FileStream(picturepath, FileMode.Open, FileAccess.Read);
            byte[] bytestream = new byte[filestream.Length];
            filestream.Read(bytestream, 0, bytestream.Length);
            filestream.Close();

            SqlParameter parameter = new SqlParameter(paramitername, SqlDbType.VarBinary, bytestream.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, bytestream);
            cmd.Parameters.Add(parameter);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            if (Message != "")
            {
                MessageBox.Show(Message, "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //save the data of the bill
        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (picturepath == "")
                {
                    MessageBox.Show("من فضلك اختر لوجو للمكان", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //get the data of the bill
                tbl.Clear();
                tbl = db.readdata("select*from settingprinting_bills", "");
                //check if there is data or not 
                //if there is  data
                if (tbl.Rows.Count >= 1)
                {

                    //update the data of the bill
                    saveimage("update settingprinting_bills set logo=@logo,name=N'" + txtshopename.Text + "',address=N'" + txtshopaddress.Text + "',discription=N'" + txtdescription.Text.Trim() + "',phone1=" + txtphone1.Text.Trim() + ",phone2=" + txtphone2.Text.Trim() + ",phone3="+txtphone3.Text.Trim()+",tax_re=N'"+txttax_re.Text.Trim()+"',commerical_re=N'"+txtcomerical_re.Text.Trim()+"'", "@logo", "تم التعديل بنجاح");
                }
                else
                {
                    //ifthere is not data
                    saveimage("insert into settingprinting_bills values(@logo,N'" + txtshopename.Text + "',N'" + txtshopaddress.Text + "',N'" + txtdescription.Text + "'," + txtphone1.Text + "," + txtphone2.Text + ","+txtphone3.Text.Trim()+",N'"+txttax_re.Text.Trim()+"',N'"+txtcomerical_re.Text.Trim()+"')", "@logo", "تم الادخال بنجاح");
                }
                //the path of logo
                picturepath = "";
            }
            catch (Exception) { }
        }
        //the path of logo
        string picturepath = "";

        //btn open form to chooce logo from the pc
        private void btnchooselogo_Click(object sender, EventArgs e)
        {

            OpenFileDialog openfiledialog = new OpenFileDialog();
            openfiledialog.Filter = "all files(*.*)|*.*";
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                picturepath = openfiledialog.FileName.ToString();
                picturelogo.Image = null;
                picturelogo.ImageLocation = picturepath;

            }
        }
        //button to delete the logo chooced
        private void btndeletelogo_Click(object sender, EventArgs e)
        {
            picturelogo.BackgroundImage = null;
            picturelogo.Image = null;
            picturepath = "";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
           

        }
    }
    }

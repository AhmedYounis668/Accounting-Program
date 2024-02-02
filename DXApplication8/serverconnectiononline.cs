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
    public partial class serverconnectiononline : DevExpress.XtraEditors.XtraForm
    {
        public serverconnectiononline()
        {
            InitializeComponent();
        }
        //save data in puplic variables
        private void btnsave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.servername = txtservername.Text.Trim();
            Properties.Settings.Default.databasename = txtdatabasename.Text.Trim();
            Properties.Settings.Default.databaseusername = txtusername.Text.Trim();
            Properties.Settings.Default.databasepassword = txtpassword.Text.Trim();
            Properties.Settings.Default.Save();

            if (checkdontshow.Checked == false)
            {
                Properties.Settings.Default.updateconnecttoserver = false;
            }
            else if (checkdontshow.Checked == true)
            {
                Properties.Settings.Default.updateconnecttoserver = true;
            }

            if (MessageBox.Show("هل انت متاكد من البيانات المدخله من فضلك تاكد من البيانات قبل الضغط علي زر Yes", "تنبيه هاااااااام", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                MessageBox.Show("تم حفظ البيانات بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //show data saved before sin variables when form load
        private void serverconnectiononline_Load(object sender, EventArgs e)
        {
            txtservername.Text = Properties.Settings.Default.servername;
            txtdatabasename.Text = Properties.Settings.Default.databasename;
            txtusername.Text = Properties.Settings.Default.databaseusername;
            txtpassword.Text = Properties.Settings.Default.databasepassword;

            if (Properties.Settings.Default.updateconnecttoserver == false)
            {
                checkdontshow.Checked = false;
            }
            else if (Properties.Settings.Default.updateconnecttoserver == true)
            {
                checkdontshow.Checked = true;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;


namespace DXApplication8
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        database db = new database();
        DataTable tbl = new DataTable();
        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ddnewstore frm = new ddnewstore();
            frm.ShowDialog();

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            units frm = new units();
            frm.ShowDialog();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groups frm = new groups();
            frm.ShowDialog();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            addproduct frm = new addproduct();
            frm.ShowDialog();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            branches frm = new branches();
            frm.ShowDialog();
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            sales frm = new sales();
            frm.ShowDialog();
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mandoup frm = new mandoup();
            frm.ShowDialog();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            customer_data frm = new customer_data();
            frm.ShowDialog();
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            suppliers frm = new suppliers();
            frm.ShowDialog();

        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            buy frm = new buy();
            frm.ShowDialog();

        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            supplier_account frm = new supplier_account();
            frm.ShowDialog();
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            addstoke frm = new addstoke();
            frm.ShowDialog();
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            addbank frm = new addbank();
            frm.ShowDialog();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            sand_kabd frm = new sand_kabd();
            frm.ShowDialog();
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            eda3in_khazna frm = new eda3in_khazna();
            frm.ShowDialog();
        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bank_insert frm = new bank_insert();
            frm.ShowDialog();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            sand_sarf frm = new sand_sarf();
            frm.ShowDialog();
        }

        private void barButtonItem31_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            buy_reports frm = new buy_reports();
            frm.ShowDialog();

        }

        private void barButtonItem29_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            withdrowalfromkhazna frm = new withdrowalfromkhazna();
            frm.ShowDialog();
        }

        private void barButtonItem30_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            withdrowalfrombank frm = new withdrowalfrombank();
            frm.ShowDialog();

        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            customer_accounts frm = new customer_accounts();
            frm.ShowDialog();
        }

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            transferfromkhaznatokhazna frm = new transferfromkhaznatokhazna();
            frm.ShowDialog();
        }

        private void barButtonItem41_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            expenses_type frm = new expenses_type();
            frm.ShowDialog();
        }

        private void barButtonItem42_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            expenses frm = new expenses();
            frm.ShowDialog();
        }

        private void barButtonItem43_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            expenses_report frm = new expenses_report();
            frm.ShowDialog();
        }

        private void barButtonItem25_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            transferfrombanktobank frm = new transferfrombanktobank();
            frm.ShowDialog();
        }

        private void barButtonItem28_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            transferefrombanktokhaznaandother frm = new transferefrombanktokhaznaandother();
            frm.ShowDialog();
        }

        private void barButtonItem32_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            transferproductsbetweenstores frm = new transferproductsbetweenstores();
            frm.ShowDialog();
        }

        private void barButtonItem54_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            item_cardscreen frm = new item_cardscreen();
            frm.ShowDialog();
        }

        private void barButtonItem36_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem40_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            employee_accounts frm = new employee_accounts();
            frm.ShowDialog();
        }

        private void barButtonItem37_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            employeeattendance frm = new employeeattendance();
            frm.ShowDialog();
        }

        private void barButtonItem44_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            sales_reports frm = new sales_reports();
            frm.ShowDialog();
        }

        private void barButtonItem45_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            reb7h frm = new reb7h();
            frm.ShowDialog();
        }

        private void barButtonItem55_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            returns_sales_reports frm = new returns_sales_reports();
            frm.ShowDialog();
        }

        private void barButtonItem56_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            buy_returns_report frm = new buy_returns_report();
            frm.ShowDialog();
        }

        private void barButtonItem47_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            eda3in_khazna_report frm = new eda3in_khazna_report();
            frm.ShowDialog();
        }

        private void barButtonItem48_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            withdrowalfromstokereport frm = new withdrowalfromstokereport();
            frm.ShowDialog();
        }

        private void barButtonItem49_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            transferebetweenstokes_reports frm = new transferebetweenstokes_reports();
            frm.ShowDialog();
        }

        private void barButtonItem52_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            eda3inbank_report frm = new eda3inbank_report();
            frm.ShowDialog();

        }

        private void barButtonItem53_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            withdrowalfrombank_report frm = new withdrowalfrombank_report();
            frm.ShowDialog();
        }

        private void barButtonItem51_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            transferefrombanktoanother_reports frm = new transferefrombanktoanother_reports();
            frm.ShowDialog();
        }

        private void barButtonItem26_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            sandsarfandkabd_reports frm = new sandsarfandkabd_reports();
            frm.ShowDialog();
        }

        private void barButtonItem50_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            stokeandbank_transfere_reports frm = new stokeandbank_transfere_reports();
            frm.ShowDialog();
        }

        private void barButtonItem57_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            oldbalanceoncustomerandsupplier frm = new oldbalanceoncustomerandsupplier();
            frm.ShowDialog();
        }

        private void barButtonItem58_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            oldbalanceoncustomerandsupplier frm = new oldbalanceoncustomerandsupplier();
            frm.ShowDialog();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem39_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            addemployee frm = new addemployee();
            frm.ShowDialog();
        }

        private void barButtonItem38_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            employeeabsentsanddiscount frm = new employeeabsentsanddiscount();
            frm.ShowDialog();
        }
        //take buckup
        private void barButtonItem59_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
               
                string d = string.Empty;
                d = DateTime.Now.Date.ToString("dd-MM-yyyy");
                SaveFileDialog open = new SaveFileDialog();
                open.Filter = "backup files (*.back)|*.back";
                open.FileName = "Big-Bos__Trading backup_" + d;

                if (open.ShowDialog() == DialogResult.OK)
                {
                    db.excutedata("backup database bigbos_tradind To disk='" + open.FileName + "'", "تم اخذ نسخه احتياطيه");
                }
                
            }

            catch (Exception)
            { }
        }
        //backup
        private void barButtonItem60_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Server server = new Server(Properties.Settings.Default.servername);
            Microsoft.SqlServer.Management.Smo.Database db = server.Databases["bigbos_tradind"];
            if (db != null)
            {
                server.KillAllProcesses(db.Name);

            }
            Restore restore = new Restore();
            restore.Database = db.Name;
            restore.Action = RestoreActionType.Database;
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "backup files (*.back)|*.back";
            if (open.ShowDialog() == DialogResult.OK)
            {
                restore.Devices.AddDevice(open.FileName, DeviceType.File);
                restore.ReplaceDatabase = true;
                restore.NoRecovery = false;
                restore.SqlRestore(server);
                MessageBox.Show("تم استرجاع النسخه الاحتياطيه بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            program_setting frm = new program_setting();
            frm.ShowDialog();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            sal7iat_users frm = new sal7iat_users();
            frm.ShowDialog();
        }

        private void barButtonItem61_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //get selected stoke nand show it in bar static
            DataTable tblstokes = new DataTable();
            tblstokes.Clear();
            tblstokes = db.readdata("select*from stokes where stoke_id="+Properties.Settings.Default.stoke_id+"", "");
            if(tblstokes.Rows.Count>=1)
            {
                barStaticItem3.Caption = Convert.ToString(tblstokes.Rows[0][1]);

            }
            //user name
            barStaticItem2.Caption = "اسم المستخدم|" + " " + Properties.Settings.Default.user_name;
            //branch
            barStaticItem1.Caption = "الفرع|" + " " + Properties.Settings.Default.branch_name;

            tbl.Clear();
           tbl= db.readdata("select*from stokes where stoke_id="+Properties.Settings.Default.stoke_id+"", "");
            //date
            barStaticItem4.Caption = "التاريخ|" + " " + DateTime.Now.ToString("yyyy-MM-dd");

        }

        private void barButtonItem33_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            transfer_products_between_store_report frm = new transfer_products_between_store_report();
            frm.ShowDialog();
        }

        private void barButtonItem67_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bankandstokebalance frm = new bankandstokebalance();
            frm.ShowDialog();
        }
    }
    }
        
    


    
        
    


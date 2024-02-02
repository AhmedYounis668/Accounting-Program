using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace DXApplication8
{
    class database
    {
      //  SqlConnection conn = new SqlConnection(@"Data Source="+Properties.Settings.Default.servername+";Initial Catalog="+Properties.Settings.Default.databasename+";user id="+Properties.Settings.Default.databaseusername+";password="+Properties.Settings.Default.databasepassword+"");

            //connection string with sql server database
         SqlConnection conn = new SqlConnection(@"Data Source=.\;Initial Catalog=bigbos_tradind;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();






        //select , search to read data from tables and show it to users
        public DataTable readdata(string stmt, string Message)


        {
            DataTable tbl = new DataTable();
            try
            {
                // connection
                cmd.Connection = conn;
                //statement (quary)
                cmd.CommandText = stmt;
                //open connection
                conn.Open();
                //run quary and get data
                tbl.Load(cmd.ExecuteReader());
                //close connection
                conn.Close();

                if (Message != "")
                {
                    MessageBox.Show(Message, "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return tbl;

        }

        //excute to insert and update and delete data from tables
        public bool excutedata(string stmt, string message)
        {
            try
            {
                // connection
                cmd.Connection = conn;
                //statement (quary)
                cmd.CommandText = stmt;
                //open connection
                conn.Open();
                //run quary
                cmd.ExecuteNonQuery();
                //close connection
                conn.Close();

                if (message != "")
                {
                    MessageBox.Show(message, "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }


        }

    }
}

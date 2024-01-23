using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    internal class DBconnection
    {

        public string sqlStr="";
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public void Thucthi(string sql)
        {
            try
            {
                conn.Open();
                string sqlStr = sql;

                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)

                {
                    MessageBox.Show(" thanh cong ");

                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("that bai" + exc);
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable Load(string sql)
        {
            try
            {
                conn.Open();
                string sqlStr = sql;
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dtSinhvien = new DataTable();
                adapter.Fill(dtSinhvien);
                return dtSinhvien;


            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
    }

}

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
    internal class GiaoVien
    {
        string Ten;
        string Diachi;
        string Cmnd;
        String Ngaysinh;
        public GiaoVien() { }

        public GiaoVien(string Ten, string Diachi, string Cmnd, string Ngaysinh)
        {
            this.Ten = Ten;
            this.Diachi = Diachi;
            this.Ngaysinh = Ngaysinh;
            this.Cmnd = Cmnd;
        }
    }

    class GiaoVienDao
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public void ThemGs(string Ten, string Diachi, string Cmnd, string Ngaysinh)
        {
            try
            {
                Hocsinh hs = new Hocsinh(Ten, Diachi, Cmnd, Ngaysinh);
                conn.Open();
                string sqlStr = string.Format("insert into GiaoVien(Ten,Diachi,Cmnd,Ngaysinh) Values ('{0}','{1}','{2}','{3}')", hs.Ten, hs.Diachi, hs.Cmnd, hs.Ngaysinh);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)

                {
                    MessageBox.Show("them thanh cong ");

                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("them tb " + exc);
            }
            finally
            {
                conn.Close();
            }
        }


        public void XoaGS(string CMND)
        {
            try
            {
                conn.Open();

                string sqlStr = string.Format("delete from GiaoVien where Cmnd='{0}'", CMND);

                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)

                {
                    MessageBox.Show("xoa thanh cong ");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("xoa tb " + exc);
            }
            finally
            {
                conn.Close();
            }
        }
        public void SuaGS(string Ten, string Diachi, string Cmnd, string Ngaysinh)
        {
            try
            {
                Hocsinh hs = new Hocsinh(Ten, Diachi, Cmnd, Ngaysinh);
                conn.Open();
                string sqlStr = string.Format("update GiaoVien SET Ten='{0}' ,Diachi='{1}' ,Ngaysinh='{3}' Where Cmnd = '{2}'", hs.Ten, hs.Diachi, hs.Cmnd, hs.Ngaysinh);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)

                {
                    MessageBox.Show("them thanh cong ");

                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("them tb " + exc);
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable LoadHS()
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("select * from Hocsinh");
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

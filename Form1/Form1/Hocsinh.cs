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


    internal class Hocsinh:Object
    {
        public Hocsinh(string Ten,string Diachi,string Cmnd,string Ngaysinh) : base(Ten, Diachi, Cmnd, Ngaysinh)
        { }
    }
    class HocsinhDao :Object
    {
        DBconnection dBconnection=new DBconnection();
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

        public void Thucthi(Hocsinh hs, string sql)
        {

            string sqlStr = string.Format(sql, hs.Ten, hs.Diachi, hs.Cmnd, hs.Ngaysinh);
            dBconnection.Thucthi(sqlStr);
        }
        public  void ThemHs(Hocsinh hs)
        {
            string sqlStr = string.Format("insert into Hocsinh(Ten,Diachi,Cmnd,Ngaysinh) Values ('{0}','{1}','{2}','{3}')", hs.Ten, hs.Diachi, hs.Cmnd, hs.Ngaysinh);
            Thucthi(hs,sqlStr);
        }


        public void XoaHS(Hocsinh hs)
        {
          
            string sqlStr = string.Format("delete from Hocsinh where Cmnd='{0}'", hs.Cmnd);
            Thucthi(hs,sqlStr);
        }
        public void SuaHS(Hocsinh hs)
        {
            string sqlStr = string.Format("update Hocsinh SET Ten='{0}' ,Diachi='{1}' ,Ngaysinh='{3}' Where Cmnd = '{2}'", hs.Ten, hs.Diachi, hs.Cmnd, hs.Ngaysinh);
            Thucthi(hs, sqlStr);

        }
        public DataTable LoadHS()
        {
            string sqlStr = string.Format("select * from Hocsinh");
            DataTable dtSinhvien = new DataTable();
            dtSinhvien = dBconnection.Load(sqlStr);
            return dtSinhvien;

        }
    }
}

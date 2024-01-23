using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Form1
{
    internal class Object
    {
        public string Ten { get => Ten; set => Ten = value; }
        public string Diachi{ get => Diachi; set => Diachi = value; }
        public string Cmnd{ get => Cmnd; set => Cmnd = value; }
        public string Ngaysinh{ get => Ngaysinh; set => Ngaysinh = value; }

        public Object()
        {
        }
        public Object(string Ten, string Diachi, string Cmnd, string Ngaysinh)
        {
            this.Ten = Ten;
            this.Diachi = Diachi;
            this.Ngaysinh = Ngaysinh;
            this.Cmnd = Cmnd;
        }

        class Dao
        {
            DBconnection dBconnection = new DBconnection();
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

            public virtual void Thucthi(Object hs, string sql)
            {
            }
            public virtual void Them(Object hs)
            {

            }


            public virtual void Xoa(Object hs)
            {

            }
            public virtual void Sua(Object hs)
            {
           

            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Form1
{

    public partial class Form1 : Form
    {
        

        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public Form1()
        {
            InitializeComponent();
        }
        public int ID=0;
        private void Form1_Load(object sender, EventArgs e)
        {
            HocsinhDao hsdao = new HocsinhDao();
            gvThongtinHS.DataSource = hsdao.LoadHS();

        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            Hocsinh hs = new Hocsinh(txtHovaten.Text, txtDiachi.Text, txtCMND.Text, datetime_FormHS.Value.ToString());
            HocsinhDao hsdao =new HocsinhDao();
            hsdao.ThemHs(hs);
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            Hocsinh hs = new Hocsinh(txtHovaten.Text, txtDiachi.Text, txtCMND.Text, datetime_FormHS.Value.ToString());
            HocsinhDao hsdao = new HocsinhDao();
            hsdao.XoaHS(hs);
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            Hocsinh hs = new Hocsinh(txtHovaten.Text, txtDiachi.Text, txtCMND.Text, datetime_FormHS.Value.ToString());
            HocsinhDao hsdao = new HocsinhDao();
            hsdao.SuaHS(hs);
        }

     

        private void GvThongtinHS_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = gvThongtinHS.Rows[e.RowIndex];
            txtHovaten.Text = Convert.ToString(row.Cells["Ten"].Value.ToString().Trim());
            txtDiachi.Text = Convert.ToString(row.Cells["Diachi"].Value.ToString().Trim());
            txtCMND.Text = Convert.ToString(row.Cells["Cmnd"].Value.ToString().Trim());
            datetime_FormHS.Value = Convert.ToDateTime(row.Cells["Ngaysinh"].Value);
        }

        private void btn_F5_Click(object sender, EventArgs e)
        {
            HocsinhDao hsdao = new HocsinhDao();
            gvThongtinHS.DataSource = hsdao.LoadHS();
        }
    }

}

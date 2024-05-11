using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sieu_Thi_Mini_C_
{
    public partial class frmQuanLyKhoHang : Form
    {
        private string getRole;
        private string taikhoan;
        private string password;

        public frmQuanLyKhoHang()
        {
            InitializeComponent();
        }
        private Form mainForm;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        public frmQuanLyKhoHang(Form form ,string getRole, string taikhoan, string password)
        {
            InitializeComponent();
            this.getRole = getRole;
            this.taikhoan = taikhoan;
            this.password = password;
            mainForm = form;
        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            frmHangHoa frmHangHoa = new frmHangHoa();
            frmHangHoa.ShowDialog();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            frmNhapHang frmNhapHang = new frmNhapHang();
            frmNhapHang.ShowDialog();
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            frmNhaCungCap frmNhaCungCap = new frmNhaCungCap();
            frmNhaCungCap.ShowDialog();
        }

        private void btnT_Click(object sender, EventArgs e)
        {
         this.Close();

          
        }

        private void frmQuanLyKhoHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (getRole == "Thủ kho") { mainForm.Show(); }
        }

        private void frmQuanLyKhoHang_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "select tennv from bangthongtinnhanvien where username='" + taikhoan + "' and Password='" + password + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            string ten = (string)cmd.ExecuteScalar();
            label2.Text = getRole + ":" + ten;

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnTraHang_Click(object sender, EventArgs e)
        {
            frm_trahang frm_Trahang = new frm_trahang();
            frm_Trahang.ShowDialog();
            this.Close();
        }
    }
}

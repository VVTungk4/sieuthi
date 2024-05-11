using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sieu_Thi_Mini_C_
{
    public partial class frmMain : Form
    {
        private string getRole,taikhoan,password;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        public frmMain()
        {
            InitializeComponent();
        }
        private Form mainForm;
        public frmMain(Form form,string getRole,string taikhoan,string password)
        {
            InitializeComponent();
            this.getRole = getRole;
            this.taikhoan = taikhoan;
            this.password= password;
            mainForm = form;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "select tennv from bangthongtinnhanvien where username='" + taikhoan + "' and Password='" + password + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            string ten =(string)cmd.ExecuteScalar();
            label1.Text = getRole+":"+ten;
            this.WindowState = FormWindowState.Maximized;

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void btnBanhang_Click(object sender, EventArgs e)
        {
            if (getRole == "Admin")
            {
            frmBanhang formBanhang = new frmBanhang(this, getRole, taikhoan, password);
            formBanhang.Show();
            this.Hide();
            }
            else
            {
            frmBanhang formBanhang = new frmBanhang();
            formBanhang.Show();
            }
          
        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            frmNhanVien nhanVien = new frmNhanVien();
            nhanVien.ShowDialog();
           
        }

        private void btnKhachhang_Click(object sender, EventArgs e)
        {
            frmKhachHang khachHang = new frmKhachHang();
            khachHang.ShowDialog();
            
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            frmQuanLyKhoHang quanlykhohang = new frmQuanLyKhoHang();
            quanlykhohang.ShowDialog();
            
            
        }

        private void btnDoanhthu_Click(object sender, EventArgs e)
        {
           frm_Doanhthu frm_Doanhthu = new frm_Doanhthu();
            frm_Doanhthu.ShowDialog();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
        //    mainForm.Show();

        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            frmThongke frmThongke = new frmThongke();
            frmThongke.ShowDialog();
          
        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDangNhap frmDangNhap = new frmDangNhap();
            frmDangNhap.ShowDialog();
            
        }
    }
}

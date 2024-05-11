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
using System.Configuration;
using System.Drawing.Text;
using System.Net.NetworkInformation;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Sieu_Thi_Mini_C_
{
    public partial class frmNhaCungCap : Form
    {
        //Thiet lap bien toan cuc
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        public frmNhaCungCap()
        {
            InitializeComponent();
        }
        private void load_dgv()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "select* from bangnhacungcap";
            SqlCommand cmd = new SqlCommand(sql, con);
            //tao doi tuong data adapter de lay du lieu
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            //do du lieu tu da va database
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            //Hien thi
            dgv_thongtin.DataSource = tb;
            dgv_thongtin.Refresh();
            txtTenncc.Text = dgv_thongtin.Rows[0].Cells["Tenncc"].Value.ToString();
        }
        private void dgv_thongtin_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtMancc.Text = dgv_thongtin.Rows[i].Cells[0].Value.ToString();
            txtTenncc.Text = dgv_thongtin.Rows[i].Cells[1].Value.ToString();
            txtDiachi.Text = dgv_thongtin.Rows[i].Cells[2].Value.ToString();
            txtSdt.Text = dgv_thongtin.Rows[i].Cells[3].Value.ToString();
            txtMancc.Enabled = false;
        }
        private void dgv_thongtin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private bool Check(string p_mancc)
        {
            //b2.ket noi database
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            //b3 tao doi tuong command de kiem tra
            string sql = "select count(*) from bangnhacungcap where mancc='" + p_mancc + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            int kq = (int)cmd.ExecuteScalar();
            cmd.Dispose();
            con.Close();
            return kq > 0;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
        }
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            //kiem tra day du du lieu
            if (string.IsNullOrEmpty(txtMancc.Text) || string.IsNullOrEmpty(txtTenncc.Text) || string.IsNullOrEmpty(txtDiachi.Text)
              || string.IsNullOrEmpty(txtSdt.Text) )
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!", "Thông báo");
                return;
            }

            //Lay du lieu tu cac control dua vao bien
            string p_mancc = txtMancc.Text.Trim();
            string p_tenncc = txtTenncc.Text.Trim();
            string p_diachi = txtDiachi.Text.Trim();
            string p_sdt = txtSdt.Text.Trim();

            if (Check(p_mancc))
            {
                MessageBox.Show("Mã nhà cung cấp đã tồn tại !", "Thông báo");
                txtMancc.Focus();
                return;
            }
            //b1 ket noi database
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            //b2 toi doi tuong cmd thuc hien truy van
            string sql = "Insert bangnhacungcap values (@mancc,@tenncc,@diachi,@sdt)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@mancc", SqlDbType.NVarChar, 50).Value = p_mancc;
            cmd.Parameters.Add("@tenncc", SqlDbType.NVarChar, 50).Value = p_tenncc;
            cmd.Parameters.Add("@diachi", SqlDbType.NVarChar, 50).Value = p_diachi;
            cmd.Parameters.Add("@sdt", SqlDbType.NVarChar, 50).Value = p_sdt;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("Thêm mới thành công!");
            load_dgv();
            txtMancc.Enabled = true;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMancc.Text) || string.IsNullOrEmpty(txtTenncc.Text) || string.IsNullOrEmpty(txtDiachi.Text)
             || string.IsNullOrEmpty(txtSdt.Text))
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!", "Thông báo");
                return;
            }
            //b1 lay du lieu tu cac control dua vao bien

            string p_mancc = txtMancc.Text.Trim();
            string p_tenncc = txtTenncc.Text.Trim();
            string p_diachi = txtDiachi.Text.Trim();
            string p_sdt = txtSdt.Text.Trim();

            //b2 ket noi den database
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            //b3 tao doi tuong cmd de thuc hien sua du lieu
            string sql = "Update bangnhacungcap set mancc=N'" + p_mancc + "',tenncc=N'" + p_tenncc + "',diachi=N'" + p_diachi + "',sdt=N'" + p_sdt + "' where mancc=N'" + p_mancc + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("Sửa hoàn tất !","Thông báo");
            txtMancc.Enabled = false;
            load_dgv();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //b1 lay du lieu tu control
            string p_mancc = txtMancc.Text.Trim();

            //n2 ket noi den database
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            //b3 tao doi tuong cmd de thuc hien xoa du lieu
            string sql = "Delete bangnhacungcap where mancc='" + p_mancc + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();//giaiphong bo nho
            con.Close();//ngatketnoi
            MessageBox.Show("Xoa thanh cong !","Thông báo");
            load_dgv();
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            load_dgv();
            txtMancc.Enabled = true;
            this.WindowState = FormWindowState.Maximized;
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }



        //click mở form tương ứng
        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            frmHangHoa frmHangHoa = new frmHangHoa();
            frmHangHoa.ShowDialog();
            this.Close();
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {

        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            frmNhapHang frmNhapHang = new frmNhapHang();
            frmNhapHang.ShowDialog();
            this.Close();
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            txtMancc.Enabled = true;
            txtMancc.Clear();
            txtDiachi.Clear();
            txtTenncc.Clear();
            txtSdt.Clear();
            dgv_thongtin.Refresh();
        }

        private void txtSdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '\b')
            {
                e.Handled = false;
            }
        }

        private void btnLoaiHang_Click(object sender, EventArgs e)
        {
            frm_trahang frmLoai = new frm_trahang();
            frmLoai.ShowDialog();
            this.Close();
        }
    }
}

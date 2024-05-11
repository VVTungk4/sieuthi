
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sieu_Thi_Mini_C_
{
    public partial class frmNhapHang : Form
    {
        //thietlap bien toan cuc
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        public frmNhapHang()
        {
            InitializeComponent();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void load_lst_tenhang()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
           string p_nhomhang = cbo_nhomhang.SelectedItem.ToString().Trim();
            string sql = "select * from banghanghoa where nhomhang= N'"+p_nhomhang+"' ";
            SqlCommand cmd = new SqlCommand(sql, con);
            //tao doi tuong data adapter de lay du lieu
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            //do du lieu tu da va database
            DataTable tb = new DataTable();
            da.Fill(tb);
            // cmd.Dispose();
            con.Close();
            //
            DataRow dr = tb.NewRow();
            dr["mahh"] = "";
            dr["tenhang"] = "---- Chọn tên hàng ----";
            tb.Rows.InsertAt(dr, 0);
            //hien thi tb vao lst
            lst_dshh.DataSource = tb;
            lst_dshh.DisplayMember = "tenhang";
            lst_dshh.ValueMember = "mahh";
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            string nhomhang = "Select distinct nhomhang from banghanghoa";
            SqlCommand cmd = new SqlCommand(nhomhang, con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

            DataTable da = new DataTable();
            dataAdapter.Fill(da);
            foreach (DataRow row in da.Rows[0].Table.Rows)
            {
                cbo_nhomhang.Items.Add(row["nhomhang"].ToString());
            }
       
        }

        private void cbo_nhomhang_SelectedIndexChanged(object sender, EventArgs e)
        {

            load_lst_tenhang();

        }
      
        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            frmHangHoa frmHangHoa = new frmHangHoa();
            frmHangHoa.ShowDialog();
            this.Close();
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            frmNhaCungCap frmNhaCungCap = new frmNhaCungCap();  
            frmNhaCungCap.ShowDialog();
            this.Close();
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoaiHang_Click(object sender, EventArgs e)
        {
            frm_trahang frm_Trahang = new frm_trahang();    
            frm_Trahang.ShowDialog();
            this.Close();
        }  
        private void lst_dshh_SelectedValueChanged(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string p_mahh = lst_dshh.SelectedValue.ToString();
            string sql = "Select mahh,tenhang,gianhap from banghanghoa where mahh=N'" + p_mahh + "'";
            DataTable current_data = (DataTable)dgv_thongtin.DataSource;
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
          //  dgv_thongtin.DataSource = dt;
            cmd.ExecuteNonQuery();
            for (int i = 0; i < dgv_thongtin.RowCount - 1; i++)
            {
                if (p_mahh == dgv_thongtin.Rows[i].Cells["mahh"].Value.ToString())
                {
                    MessageBox.Show("Bạn đã nhập mặt hàng này, vui lòng không chọn lại", "Thông báo");
                    return;
                }
            }
            if (current_data == null)
            {
                current_data = new DataTable();
            }
            current_data.Merge(dt);
            dgv_thongtin.DataSource = current_data;
            dgv_thongtin.Refresh();
          
        }

        private void dgv_thongtin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dgv_thongtin.Rows.Count - 1)
            {
                return;
            }
            if (e.ColumnIndex == dgv_thongtin.Columns["dgv_btnXoa"].Index && e.RowIndex >= 0)
            {
                dgv_thongtin.Rows.RemoveAt(dgv_thongtin.CurrentRow.Index);
                return;
            }
            for (int i = 0; i < dgv_thongtin.Rows.Count; ++i)
            {
                int p_dongia = Convert.ToInt32(dgv_thongtin.Rows[i].Cells["dongia"].Value);
                int p_soluongg = Convert.ToInt32(dgv_thongtin.Rows[i].Cells["soluong"].Value);
                int p_thanhtien = p_dongia * p_soluongg;
                dgv_thongtin.Rows[i].Cells["thanhtien"].Value = p_thanhtien;
            }


        }
        private void capnhatsoluong(string p_mahh, int soluongmoi)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string p_soluong = "Select soluong from banghanghoa where mahh='" + p_mahh + "' ";
            string sql = " Update banghanghoa set soluong=@soluong where mahh='"+p_mahh+"'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlCommand sl= new SqlCommand(p_soluong, con);
            // int soluongcu = Convert.ToInt32(sl.ExecuteScalar());
            int soluongcu = (int)sl.ExecuteScalar();
            int soluong = soluongcu + soluongmoi;
            cmd.Parameters.Add("@soluong", SqlDbType.Int).Value = soluong;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        private void btnLuuphieu_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            for (int i = 0; i < dgv_thongtin.RowCount - 1; i++)
            {
                string p_mahh= dgv_thongtin.Rows[i].Cells["mahh"].Value.ToString();
                int soluongmoi= Convert.ToInt32(dgv_thongtin.Rows[i].Cells["soluong"].Value);                
                    capnhatsoluong(p_mahh,soluongmoi);
            }
            MessageBox.Show("Cap nhat thanh cong!","Thong bao");
        }
    }
}

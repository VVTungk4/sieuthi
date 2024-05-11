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
using System.Drawing.Text;
using System.Net.NetworkInformation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Web.UI.WebControls;
using System.Data.Common;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Diagnostics;

namespace Sieu_Thi_Mini_C_
{
    public partial class frmThongke : Form
    {
        public frmThongke()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        private void frmThongke_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            thongke();
            thongkecoban();
        }
        private void thongke()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            string sql = "SELECT mahh, tenhh, SUM(thanhtien) AS TONGTHANHTIEN, SUM(soluong) AS TONGSOLUONG  FROM banghoadonchitiet WHERE ngay = @date GROUP BY mahh, tenhh ORDER BY TONGSOLUONG ASC";
            
            SqlCommand cmd = new SqlCommand(sql,con);
            cmd.Parameters.Add("@date", date);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            dgv_thongtin.DataSource = dt;
            con.Close();


           
        }
        private void thongkecoban()
        {


            string date = DateTime.Now.ToString("yyyy-MM-dd");
            // Khai báo biến để lưu giữ số lượng bán cao nhất và tên hàng hóa tương ứng
            int maxsoluongban = int.MinValue;
            string tenhhmax = "";

            // Duyệt qua tất cả các dòng trong bảng hàng hoá
            foreach (DataGridViewRow row in dgv_thongtin.Rows)
            {
                // Lấy giá trị số lượng bán từ cột "tenhh"
                int soluongban = Convert.ToInt32(row.Cells["soluongban"].Value);

                // So sánh và cập nhật nếu số lượng bán hiện tại lớn hơn số lượng bán cao nhất
                if (soluongban > maxsoluongban)
                {
                    maxsoluongban = soluongban;
                    tenhhmax = row.Cells["tenhh"].Value.ToString();
                }
            }

            // Gán tên hàng hóa có số lượng bán cao nhất vào textbox
            txt_banchay.Text = tenhhmax;




            // Khai báo biến để lưu giữ số lượng bán cao nhất và tên hàng hóa tương ứng
            int minsoluongban = int.MaxValue;
            string tenhhmin = "";

            // Duyệt qua tất cả các dòng trong bảng hàng hoá
            foreach (DataGridViewRow row in dgv_thongtin.Rows)
            {
                // Lấy giá trị số lượng bán từ cột "tenhh"
                int soluongban = Convert.ToInt32(row.Cells["soluongban"].Value);
                if (soluongban == 0)
                {
                    soluongban = 1;
                }
                // So sánh và cập nhật nếu số lượng bán hiện tại lớn hơn số lượng bán cao nhất
                if (soluongban < minsoluongban)
                {
                    minsoluongban = soluongban;
                    tenhhmin = row.Cells["tenhh"].Value.ToString();
                }
            }

            // Gán tên hàng hóa có số lượng bán cao nhất vào textbox
            txt_banit.Text = tenhhmin;








            //
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "Select tenhang from banghanghoa where soluong < 50";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            lst_danhsach.DataSource = dt;
            lst_danhsach.DisplayMember = "tenhang";


        }

        private void btnT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

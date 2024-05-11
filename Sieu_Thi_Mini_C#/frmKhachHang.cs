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
using e_excel = Microsoft.Office.Interop.Excel;

namespace Sieu_Thi_Mini_C_
{
    public partial class frmKhachHang : Form
    {
        //thietlap bien toan cuc
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            load_dgv();
            this.WindowState = FormWindowState.Maximized;

        }

        private void txtDiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void load_dgv()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "select* from bangkhachhang";
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
        }
        private bool Check(string p_makh)
        {
            //b2.ket noi database
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            //b3 tao doi tuong command de kiem tra
            string sql = "select count(*) from bangkhachhang where makh='" + p_makh + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            int kq = (int)cmd.ExecuteScalar();
            cmd.Dispose();
            con.Close();
            return kq > 0;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            //kiem tra day du du lieu
            if (string.IsNullOrEmpty(txtMakh.Text) || string.IsNullOrEmpty(txtTenkh.Text) || string.IsNullOrEmpty(txtCccd.Text)
              || string.IsNullOrEmpty(txtSdt.Text) || string.IsNullOrEmpty(txtDiachi.Text) || string.IsNullOrEmpty(txtDiem.Text)
              || string.IsNullOrEmpty(txtNamganbo.Text))
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!", "Thông báo");
                return;
            }
            //laay du lieu tu control dua vao bien
            string p_makh = txtMakh.Text.Trim();
            string p_tenkh = txtTenkh.Text.Trim();
            string p_cccd = txtCccd.Text.Trim();
            string p_diachi = txtDiachi.Text.Trim();
            string p_sdt = txtSdt.Text.Trim();
         
            string p_diem = txtDiem.Text.Trim();
            DateTime p_ngaytao=date_ngaytao.Value;  
            string p_namganbo= txtNamganbo.Text.Trim();
            //
            if (Check(p_makh))
            {
                MessageBox.Show("Mã khách hàng đã tồn tại !", "Thông báo");
                txtMakh.Focus();
                return;
            }
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            //b2 toi doi tuong cmd thuc hien truy van
            string sql = "Insert bangkhachhang values (@makh,@tenkh,@cccd,@diachi,@sdt,@diem,@ngaytao,@namganbo)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@makh", SqlDbType.NVarChar, 50).Value = p_makh;
            cmd.Parameters.Add("@tenkh", SqlDbType.NVarChar, 50).Value = p_tenkh;
            cmd.Parameters.Add("@cccd", SqlDbType.NVarChar, 50).Value = p_cccd;
            cmd.Parameters.Add("@diachi", SqlDbType.NVarChar, 50).Value = p_diachi;
            cmd.Parameters.Add("@sdt", SqlDbType.NVarChar, 50).Value = p_sdt;
           
            cmd.Parameters.Add("@diem", SqlDbType.Int).Value = p_diem;    
            cmd.Parameters.Add("@ngaytao",SqlDbType.Date ).Value = p_ngaytao;
            cmd.Parameters.Add("@namganbo", SqlDbType.Int).Value = p_namganbo;

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("Thêm mới thành công!", "Thông báo");
            load_dgv();
            txtMakh.Enabled = true;


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //kiem tra day du du lieu
            if (string.IsNullOrEmpty(txtMakh.Text) || string.IsNullOrEmpty(txtTenkh.Text) || string.IsNullOrEmpty(txtCccd.Text)
              || string.IsNullOrEmpty(txtSdt.Text) || string.IsNullOrEmpty(txtDiachi.Text) || string.IsNullOrEmpty(txtDiem.Text)
              || string.IsNullOrEmpty(txtNamganbo.Text))
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!", "Thông báo");
                return;
            }
            //b1 lay du lieu tu cac control dua vao bien
            string p_makh = txtMakh.Text.Trim();
            string p_tenkh = txtTenkh.Text.Trim();
            string p_cccd = txtCccd.Text.Trim();

            string p_diachi = txtDiachi.Text.Trim();
            string p_sdt = txtSdt.Text.Trim();
           
            string p_diem = txtDiem.Text.Trim();
            string p_ngaytao=date_ngaytao.Text.Trim();
            string p_namganbo = txtNamganbo.Text.Trim();

            //b2 ket noi den database
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            //b3 tao doi tuong cmd de thuc hien sua du lieu
            string sql = "Update bangkhachhang set tenkh=@tenkh,cccd=@cccd,diachi=@diachi,sdt=@sdt,diem=@diem,ngaytao=@ngaytao,namganbo=@namganbo where makh=@makh";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@makh", SqlDbType.NVarChar, 50).Value = p_makh;
            cmd.Parameters.Add("@tenkh", SqlDbType.NVarChar, 50).Value = p_tenkh;
            cmd.Parameters.Add("@cccd", SqlDbType.NVarChar, 50).Value = p_cccd;

            cmd.Parameters.Add("@diachi", SqlDbType.NVarChar, 50).Value = p_diachi;
            cmd.Parameters.Add("@sdt", SqlDbType.NVarChar, 50).Value = p_sdt;
            
            cmd.Parameters.Add("@diem", SqlDbType.Int).Value = p_diem;
            cmd.Parameters.Add("@ngaytao", SqlDbType.Date).Value = p_ngaytao;
            cmd.Parameters.Add("@namganbo",SqlDbType.Int).Value=p_namganbo;
            //
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("Sửa hoàn tất !", "Thông báo");
            txtMakh.Enabled = false;
            load_dgv();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //b1 lay du lieu tu control
            string p_makh = txtMakh.Text.Trim();

            //n2 ket noi den database
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            //b3 tao doi tuong cmd de thuc hien xoa du lieu
            string sql = "Delete bangkhachhang where makh='" + p_makh + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();//giaiphong bo nho
            con.Close();//ngatketnoi
            MessageBox.Show("Xoá thành công!","Thông báo");
            load_dgv();
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            txtMakh.Enabled = true;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    (control as TextBox).Text = string.Empty;
                }
            }
            
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            //b3 Tao doi tuong command de lay du lieu tu bang nxb
            string sql = "select * from bangkhachhang";
            SqlCommand cmd = new SqlCommand(sql, con);

            //b4 tao doi tuong dataAdapter de lay ket qua tu command
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            //b5 do du lieu tu dataAdapter vao datatable
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            //B6 XUẤT DỮ LIỆU TỪ tb SANG file EXCEL
            ExportExcel(tb, "THÔNG TIN KHÁCH HÀNG THÂN THIẾT");
        }
        private void ExportExcel(DataTable tb, string sheetname)
        {
            //Tạo các đối tượng Excel

            e_excel.Application oExcel = new e_excel.Application();
            e_excel.Workbooks oBooks;
            e_excel.Sheets oSheets;
            e_excel.Workbook oBook;
            e_excel.Worksheet oSheet;
            //Tạo mới một Excel WorkBook 
            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            oBook = (e_excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (e_excel.Worksheet)oSheets.get_Item(1);
            oSheet.Name = sheetname;
            // Tạo phần đầu nếu muốn

            e_excel.Range head = oSheet.get_Range("A1", "H1");
            head.MergeCells = true;//trộn nhiều ô thành 1 ô
            head.Value2 = "DANH SÁCH THÔNG TIN KHÁCH HÀNG THÂN THIẾT";
            head.Font.Bold = true;//chữ đậm
            head.Font.Name = "Tahoma";//font
            head.Font.Size = "16";//cỡ chữ
            head.HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;//căn giữa
                                                                       // Tạo tiêu đề cột 
            e_excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "MÃ KH";//TÊN CỘT
            cl1.ColumnWidth = 15;//ĐỘ RỘNG CỘT
            e_excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "TÊN KH";
            cl2.ColumnWidth = 25.0;
            e_excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "CCCD";
            cl3.ColumnWidth = 20.0;

            e_excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "ĐỊA CHỈ";
            cl4.ColumnWidth = 30.0;
            e_excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "SĐT";
            cl5.ColumnWidth = 20.0;

            e_excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "ĐIỂM";//TÊN CỘT
            cl6.ColumnWidth = 20;//ĐỘ RỘNG CỘT

            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl7.Value2 = "NGÀY TẠO";
            cl7.ColumnWidth = 15.0;
            Microsoft.Office.Interop.Excel.Range cl7_1 = oSheet.get_Range("G4", "G1000");
            cl7_1.Columns.NumberFormat = "dd/mm/yyyy";

            e_excel.Range cl8 = oSheet.get_Range("H3", "H3");
            cl8.Value2 = "NĂM GẮN BÓ";
            cl8.ColumnWidth = 25.0;

           

            //Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            //cl6.Value2 = "NGÀY THI";
            //cl6.ColumnWidth = 15.0;
            //Microsoft.Office.Interop.Excel.Range cl6_1 = oSheet.get_Range("F4", "F1000");
            //cl6_1.Columns.NumberFormat = "dd/mm/yyyy";

            e_excel.Range rowHead = oSheet.get_Range("A3", "H3");
            rowHead.Font.Bold = true;
            // Kẻ viền
            rowHead.Borders.LineStyle = e_excel.Constants.xlSolid;
            // Thiết lập màu nền
            rowHead.Interior.ColorIndex = 15;
            rowHead.HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;
            // Tạo mảng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,
            // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.
            object[,] arr = new object[tb.Rows.Count, tb.Columns.Count];
            //Chuyển dữ liệu từ DataTable vào mảng đối tượng
            for (int r = 0; r < tb.Rows.Count; r++)//CHẠY DÒNG
            {
                DataRow dr = tb.Rows[r];
                for (int c = 0; c < tb.Columns.Count; c++)//CHẠY CỘT
                {
                    if (c == 4)
                        arr[r, c] = "'" + dr[c].ToString();
                    else
                        arr[r, c] = dr[c];
                }
            }
            //Thiết lập vùng điền dữ liệu
            int rowStart = 4;
            int columnStart = 1;
            int rowEnd = rowStart + tb.Rows.Count - 1;
            int columnEnd = tb.Columns.Count;
            // Ô bắt đầu điền dữ liệu
            e_excel.Range c1 = (e_excel.Range)oSheet.Cells[rowStart, columnStart];
            // Ô kết thúc điền dữ liệu
            e_excel.Range c2 = (e_excel.Range)oSheet.Cells[rowEnd, columnEnd];
            // Lấy về vùng điền dữ liệu
            e_excel.Range range = oSheet.get_Range(c1, c2);
            //Điền dữ liệu vào vùng đã thiết lập
            range.Value2 = arr;
            // Kẻ viền
            range.Borders.LineStyle = e_excel.Constants.xlSolid;
            // Căn giữa cột STT
            e_excel.Range c3 = (e_excel.Range)oSheet.Cells[rowEnd, columnStart];
            e_excel.Range c4 = oSheet.get_Range(c1, c3);
            oSheet.get_Range(c3, c4).HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_thongtin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtMakh.Text = dgv_thongtin.Rows[i].Cells[0].Value.ToString();
            txtTenkh.Text = dgv_thongtin.Rows[i].Cells[1].Value.ToString();
            txtCccd.Text = dgv_thongtin.Rows[i].Cells[2].Value.ToString();
            txtDiachi.Text = dgv_thongtin.Rows[i].Cells[3].Value.ToString();
            txtSdt.Text = dgv_thongtin.Rows[i].Cells[4].Value.ToString();
           
            txtDiem.Text = dgv_thongtin.Rows[i].Cells[5].Value.ToString();
            date_ngaytao.Text = dgv_thongtin.Rows[i].Cells[6].Value.ToString();
            txtNamganbo.Text = dgv_thongtin.Rows[i].Cells[7].Value.ToString();
            txtMakh.Enabled=false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSdt_TextChanged(object sender, EventArgs e)
        {

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

        private void txtDiem_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNamganbo_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}

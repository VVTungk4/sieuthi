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
    public partial class frmNhanVien : Form
    {
        //thietlap bien toan cuc
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        public frmNhanVien()
        {
            InitializeComponent();
        }
        private void load_dgv()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "select* from bangthongtinnhanvien";
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

        private void dgv_thongtin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtManv.Text = dgv_thongtin.Rows[i].Cells[0].Value.ToString();
            txtTennv.Text = dgv_thongtin.Rows[i].Cells[1].Value.ToString();
            cboGIoitinh.Text = dgv_thongtin.Rows[i].Cells[2].Value.ToString();
            date_ngaysinh.Text = dgv_thongtin.Rows[i].Cells[3].Value.ToString();
            txtSdt.Text = dgv_thongtin.Rows[i].Cells[4].Value.ToString();
            txtDiachi.Text = dgv_thongtin.Rows[i].Cells[5].Value.ToString();
            txtEmail.Text = dgv_thongtin.Rows[i].Cells[6].Value.ToString();
            txtUsername.Text = dgv_thongtin.Rows[i].Cells[7].Value.ToString();
            txtPassword.Text = dgv_thongtin.Rows[i].Cells[8].Value.ToString();
            cboQuyen.Text = dgv_thongtin.Rows[i].Cells[9].Value.ToString();
            date_ngaybd.Text = dgv_thongtin.Rows[i].Cells[10].Value.ToString();
            date_ngaykt.Text = dgv_thongtin.Rows[i].Cells[11].Value.ToString();
            cbotrangthai.Text = dgv_thongtin.Rows[i].Cells[12].Value.ToString();
            txtLuong.Text = dgv_thongtin.Rows[i].Cells[13].Value.ToString();
            txtManv.Enabled = false;
        }
        private bool Check(string p_manv)
        {
            //b2.ket noi database
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            //b3 tao doi tuong command de kiem tra
            string sql = "select count(*) from bangthongtinnhanvien where manv='" + p_manv + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            int kq = (int)cmd.ExecuteScalar();
            cmd.Dispose();
            con.Close();
            return kq > 0;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {

            //kiem tra xem da nhap du du lieu vao chua
            if (string.IsNullOrEmpty(txtManv.Text) || string.IsNullOrEmpty(txtTennv.Text) || string.IsNullOrEmpty(cboGIoitinh.Text)
               || string.IsNullOrEmpty(date_ngaysinh.Text) || string.IsNullOrEmpty(txtSdt.Text) || string.IsNullOrEmpty(txtDiachi.Text)
               || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text)
               || string.IsNullOrEmpty(cboQuyen.Text) || string.IsNullOrEmpty(date_ngaybd.Text) || string.IsNullOrEmpty(date_ngaykt.Text)
               || string.IsNullOrEmpty(cbotrangthai.Text) || string.IsNullOrEmpty(txtLuong.Text))
            {
                MessageBox.Show("Chưa nhập đủ thông tin!", "Thông báo");
                return;
            }
            //lay du lieu tu control dua vao bien
            string p_mnv=txtManv.Text.Trim();
            string p_tennv=txtTennv.Text.Trim();
            string p_gioitinh=cboGIoitinh.Text.Trim();
            DateTime p_ngaysinh = date_ngaysinh.Value;
            string p_sdt=txtSdt.Text.Trim();
            string p_diachi=txtDiachi.Text.Trim();
            string p_email=txtEmail.Text.Trim();
            string p_username=txtUsername.Text.Trim();
            string p_password=txtPassword.Text.Trim();
            string p_cboquyen=cboQuyen.Text.Trim();
            DateTime p_ngaybd = date_ngaybd.Value;
            DateTime p_ngaynv = date_ngaykt.Value;
            string p_trangthai=cbotrangthai.Text.Trim();
            int p_luong=int.Parse(txtLuong.Text.Trim());

            //
            if (Check(p_mnv))
            {
                MessageBox.Show("Mã nhân viên đã tồn tại !");
                txtManv.Focus();
                return;
            }
            //b1 ket noi database
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            //b2 toi doi tuong cmd thuc hien truy van
            string sql = "Insert bangthongtinnhanvien values (@manv,@tennv,@gioitinh,@ngaysinh,@sdt,@diachi,@email,@username,@password,@maquyen,@ngayvaolam,@ngaynghiviec,@trangthaitaikhoan,@luong)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@manv", SqlDbType.NVarChar, 50).Value = p_mnv;
            cmd.Parameters.Add("@tennv", SqlDbType.NVarChar, 50).Value = p_tennv;
            cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar, 50).Value = p_gioitinh;
            cmd.Parameters.Add("@ngaysinh", SqlDbType.Date).Value = p_ngaysinh;

            cmd.Parameters.Add("@sdt", SqlDbType.NVarChar, 50).Value = p_sdt;
            cmd.Parameters.Add("@diachi", SqlDbType.NVarChar, 50).Value = p_diachi;
            cmd.Parameters.Add("@email", SqlDbType.NVarChar, 50).Value = p_email;
            cmd.Parameters.Add("@username", SqlDbType.NVarChar, 50).Value = p_username;
            cmd.Parameters.Add("@password", SqlDbType.NVarChar, 50).Value = p_password;
            cmd.Parameters.Add("@maquyen", SqlDbType.NVarChar, 50).Value = p_cboquyen;

            cmd.Parameters.Add("@ngayvaolam", SqlDbType.Date).Value = p_ngaybd;
            cmd.Parameters.Add("@ngaynghiviec", SqlDbType.Date).Value = p_ngaynv;
            cmd.Parameters.Add("@trangthaitaikhoan", SqlDbType.NVarChar, 50).Value = p_trangthai;
            cmd.Parameters.Add("@luong", SqlDbType.Int).Value = p_luong;

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("Thêm mới thành công!","Thông báo");
            load_dgv();
            txtManv.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
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

            e_excel.Range head = oSheet.get_Range("A1", "N1");
            head.MergeCells = true;//trộn nhiều ô thành 1 ô
            head.Value2 = "DANH SÁCH THÔNG TIN NHÂN VIÊN";
            head.Font.Bold = true;//chữ đậm
            head.Font.Name = "Tahoma";//font
            head.Font.Size = "16";//cỡ chữ
            head.HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;//căn giữa
                                                                       // Tạo tiêu đề cột 
            e_excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "MÃ NV";//TÊN CỘT
            cl1.ColumnWidth = 15;//ĐỘ RỘNG CỘT
            e_excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "TÊN NV";
            cl2.ColumnWidth = 25.0;
            e_excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "GIỚI TÍNH";
            cl3.ColumnWidth = 8.0;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "NGÀY SINH";
            cl4.ColumnWidth = 10.0;
            Microsoft.Office.Interop.Excel.Range cl4_1 = oSheet.get_Range("D4", "D1000");
            cl4_1.Columns.NumberFormat = "dd/mm/yyyy";
            cl4.ColumnWidth = 15.0;
            e_excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "SĐT";
            cl5.ColumnWidth = 15.0;
            e_excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "ĐỊA CHỈ";
            cl6.ColumnWidth = 20.0;

            e_excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl7.Value2 = "EMAIL";//TÊN CỘT
            cl7.ColumnWidth = 25;//ĐỘ RỘNG CỘT

            e_excel.Range cl8 = oSheet.get_Range("H3", "H3");
            cl8.Value2 = "USERNAME";
            cl8.ColumnWidth = 15.0;

            e_excel.Range cl9 = oSheet.get_Range("I3", "I3");
            cl9.Value2 = "PASSWORD";
            cl9.ColumnWidth = 15.0;
            e_excel.Range cl10 = oSheet.get_Range("J3", "J3");
            cl10.Value2 = "CHỨC VỤ";
            cl10.ColumnWidth = 15.0;
            //
            Microsoft.Office.Interop.Excel.Range cl11 = oSheet.get_Range("K3", "K3");
            cl11.Value2 = "NGÀY VÀO LÀM ";
            cl11.ColumnWidth = 15.0;
            Microsoft.Office.Interop.Excel.Range cl11_1 = oSheet.get_Range("K4", "K1000");
            cl11_1.Columns.NumberFormat = "dd/mm/yyyy";
            //
            Microsoft.Office.Interop.Excel.Range cl12= oSheet.get_Range("L3", "L3");
            cl12.Value2 = "NGÀY NGHỈ VIỆC";
            cl12.ColumnWidth = 15.0;
            Microsoft.Office.Interop.Excel.Range cl12_1 = oSheet.get_Range("L4", "L1000");
            cl12_1.Columns.NumberFormat = "dd/mm/yyyy";

            //
            e_excel.Range cl13 = oSheet.get_Range("M3", "M3");
            cl13.Value2 = "TT TÀI KHOẢN";
            cl13.ColumnWidth = 15.0;
            e_excel.Range cl14 = oSheet.get_Range("N3", "N3");
            cl14.Value2 = "LƯƠNG";
            cl14.ColumnWidth = 15.0;

            //Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            //cl6.Value2 = "NGÀY THI";
            //cl6.ColumnWidth = 15.0;
            //Microsoft.Office.Interop.Excel.Range cl6_1 = oSheet.get_Range("F4", "F1000");
            //cl6_1.Columns.NumberFormat = "dd/mm/yyyy";

            e_excel.Range rowHead = oSheet.get_Range("A3", "N3");
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
            //
            oSheet.get_Range(c1, c2).HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            //b1 Lay du lieu tu cac control dua vao bien
           

            //B2 ket noi den db
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            //b3 Tao doi tuong command de lay du lieu tu bang nxb
            string sql = "select * from bangthongtinnhanvien" ;
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
            ExportExcel(tb, "THÔNG TIN NHÂN VIÊN");
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            load_dgv();
            this.WindowState = FormWindowState.Maximized;

        }
        private void btnLammoi_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            txtManv.Enabled= true;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    (control as TextBox).Text=string.Empty;
                }
            }
            cboGIoitinh.SelectedItem = null;
            cboQuyen.SelectedItem = null;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtManv.Text) || string.IsNullOrEmpty(txtTennv.Text) || string.IsNullOrEmpty(cboGIoitinh.Text)
               || string.IsNullOrEmpty(date_ngaysinh.Text) || string.IsNullOrEmpty(txtSdt.Text) || string.IsNullOrEmpty(txtDiachi.Text)
               || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text)
               || string.IsNullOrEmpty(cboQuyen.Text) || string.IsNullOrEmpty(date_ngaybd.Text) || string.IsNullOrEmpty(date_ngaykt.Text)
               || string.IsNullOrEmpty(cbotrangthai.Text) || string.IsNullOrEmpty(txtLuong.Text))
            {
                MessageBox.Show("Chưa nhập đủ thông tin!", "Thông báo");
                return;
            }
            //b1 lay du lieu tu cac control dua vao bien
            string p_mnv = txtManv.Text.Trim();
            string p_tennv = txtTennv.Text.Trim();
            string p_gioitinh = cboGIoitinh.Text.Trim();
            DateTime p_ngaysinh = date_ngaysinh.Value;
            string p_sdt = txtSdt.Text.Trim();
            string p_diachi = txtDiachi.Text.Trim();
            string p_email = txtEmail.Text.Trim();
            string p_username = txtUsername.Text.Trim();
            string p_password = txtPassword.Text.Trim();
            string p_cboquyen = cboQuyen.Text.Trim();
            DateTime p_ngaybatdau =date_ngaybd.Value;
            DateTime p_ngayketthuc = date_ngaykt.Value;
            string p_trangthai = cbotrangthai.Text.Trim();
            int p_luong = int.Parse(txtLuong.Text.Trim());

            //b2 ket noi den database
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            //b3 tao doi tuong cmd de thuc hien sua du lieu
            string sql = "Update bangthongtinnhanvien set tennv=@tennv,gioitinh=@gioitinh,ngaysinh=@ngaysinh,sdt=@sdt,diachi=@diachi,email=@email,username=@username,password=@password,maquyen=@maquyen,ngayvaolam=@ngayvaolam,ngaynghiviec=@ngaynghiviec,trangthaitaikhoan=@trangthaitaikhoan,luong=@luong where manv=@manv";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@manv", SqlDbType.NVarChar, 50).Value = p_mnv;
            cmd.Parameters.Add("@tennv", SqlDbType.NVarChar, 50).Value = p_tennv;
            cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar, 50).Value = p_gioitinh;
            cmd.Parameters.Add("@ngaysinh", SqlDbType.Date).Value = p_ngaysinh;

            cmd.Parameters.Add("@sdt", SqlDbType.NVarChar, 50).Value = p_sdt;
            cmd.Parameters.Add("@diachi", SqlDbType.NVarChar, 50).Value = p_diachi;
            cmd.Parameters.Add("@email", SqlDbType.NVarChar, 50).Value = p_email;
            cmd.Parameters.Add("@username", SqlDbType.NVarChar, 50).Value = p_username;
            cmd.Parameters.Add("@password", SqlDbType.NVarChar, 50).Value = p_password;
            cmd.Parameters.Add("@maquyen", SqlDbType.NVarChar, 50).Value = p_cboquyen;

            cmd.Parameters.Add("@ngayvaolam", SqlDbType.Date).Value = p_ngaybatdau;
            cmd.Parameters.Add("@ngaynghiviec", SqlDbType.Date).Value = p_ngayketthuc;
            cmd.Parameters.Add("@trangthaitaikhoan", SqlDbType.NVarChar, 50).Value = p_trangthai;
            cmd.Parameters.Add("@luong",SqlDbType.Int).Value = p_luong;
            //
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("Sửa hoàn tất !","Thông báo");
            txtManv.Enabled = false;
            load_dgv();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //b1 lay du lieu tu control
            string p_manv = txtManv.Text.Trim();

            //n2 ket noi den database
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            //b3 tao doi tuong cmd de thuc hien xoa du lieu
            string sql = "Delete bangthongtinnhanvien where manv='" + p_manv + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();//giaiphong bo nho
            con.Close();//ngatketnoi
            MessageBox.Show("Xoa thanh cong !", "Thông báo");
            load_dgv();
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

        private void txtLuong_KeyPress(object sender, KeyPressEventArgs e)
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

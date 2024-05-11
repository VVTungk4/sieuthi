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
    public partial class frmHangHoa : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        public frmHangHoa()
        {
            InitializeComponent();
        }
        private void load_dgv()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "select* from banghanghoa";
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

        private void textVat_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void load_cbo_ncc()
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
            //
            DataRow dr = tb.NewRow();
            dr["mancc"] = "";
            dr["tenncc"] = "---- Chọn nhà cung cấp ----";
            tb.Rows.InsertAt(dr, 0);
            //hien thi tb vao combobox
            cbo_nhacc.DataSource = tb;
            cbo_nhacc.DisplayMember = "tenncc";
            cbo_nhacc.ValueMember = "mancc";
        }
        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            load_dgv();
            this.WindowState = FormWindowState.Maximized;
            load_cbo_ncc();
        }

        private void txtTrangthai_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private bool Check(string p_mahh)
        {
            //b2.ket noi database
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            //b3 tao doi tuong command de kiem tra
            string sql = "select count(*) from banghanghoa where mahh='" + p_mahh + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            int kq = (int)cmd.ExecuteScalar();
            cmd.Dispose();
            con.Close();
            return kq > 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //kiem tra trang thai nhap du lieu

            if (string.IsNullOrEmpty(txtMahh.Text) || string.IsNullOrEmpty(txtTenhh.Text) || string.IsNullOrEmpty(cbo_nhomhang.Text) 
                || string.IsNullOrEmpty(txtXuatxu.Text) || string.IsNullOrEmpty(txtGianhap.Text) || string.IsNullOrEmpty(txtGiaban.Text)
                || string.IsNullOrEmpty(txtDvt.Text) || cbo_nhacc.Text== "---- Chọn nhà cung cấp ----" || string.IsNullOrEmpty(txt_mavach.Text)
                || string.IsNullOrEmpty(txtSoluong.Text) || string.IsNullOrEmpty(txtVAT.Text)) 
            {
                MessageBox.Show("Chưa nhập đủ thông tin!","Thông báo");
                return;
            }
            //lay du lieu tu control dua vao bien
            string p_mahh = txtMahh.Text.Trim();
            string p_tenhh = txtTenhh.Text.Trim();
            string p_nhomhang = cbo_nhomhang.Text.Trim();
            string p_xuatxu = txtXuatxu.Text.Trim();

            int p_gianhap = int.Parse(txtGianhap.Text.Trim());
            int p_giaban = int.Parse(txtGiaban.Text.Trim());

            string p_dvt = txtDvt.Text.Trim();
            string p_nhacc = cbo_nhacc.Text.Trim();
            string p_mavach = txt_mavach.Text.Trim();

           
            int p_soluong = int.Parse(txtSoluong.Text.Trim());
            float p_vat = float.Parse(txtVAT.Text.Trim());

            DateTime p_nsx = date_nsx.Value;
            DateTime p_hsd = date_hsd.Value;
            //
            if (Check(p_mahh))
            {
                MessageBox.Show("Mã hàng hóa đã tồn tại !", "Thông báo");
                txtMahh.Focus();
                return;
            }
            //b1 ket noi database
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            //b2 toi doi tuong cmd thuc hien truy van
            string sql = "Insert banghanghoa values (@mahh,@tenhang,@nhomhang,@xuatxu,@gianhap,@giaban,@donvitinh,@nhacungcap,@mavach,@soluong,@vat, @NSX, @HSD)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@mahh", SqlDbType.NVarChar, 50).Value = p_mahh;
            cmd.Parameters.Add("@tenhang", SqlDbType.NVarChar, 50).Value = p_tenhh;
            cmd.Parameters.Add("@nhomhang", SqlDbType.NVarChar, 50).Value = p_nhomhang;
            cmd.Parameters.Add("@xuatxu", SqlDbType.NVarChar, 50).Value = p_xuatxu;

            cmd.Parameters.Add("@gianhap", SqlDbType.Int).Value = p_gianhap;
            cmd.Parameters.Add("@giaban", SqlDbType.Int).Value = p_giaban;
            cmd.Parameters.Add("@donvitinh", SqlDbType.NVarChar, 50).Value = p_dvt;
            cmd.Parameters.Add("@nhacungcap", SqlDbType.NVarChar, 50).Value = p_nhacc;
            cmd.Parameters.Add("@mavach", SqlDbType.NVarChar, 50).Value = p_mavach;
            
            cmd.Parameters.Add("@soluong", SqlDbType.Int).Value = p_soluong;
            cmd.Parameters.Add("@vat", SqlDbType.Float).Value = p_vat;

            cmd.Parameters.Add("@NSX", SqlDbType.Date).Value = p_nsx;
            cmd.Parameters.Add("@HSD", SqlDbType.Date).Value = p_hsd;

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("Thêm mới thành công!", "Thông báo");
            load_dgv();
            txtMahh.Enabled = true;
        }

        private void dgv_thongtin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtMahh.Text = dgv_thongtin.Rows[i].Cells[0].Value.ToString();
            txtTenhh.Text = dgv_thongtin.Rows[i].Cells[1].Value.ToString();
            cbo_nhomhang.Text = dgv_thongtin.Rows[i].Cells[2].Value.ToString();
            txtXuatxu.Text = dgv_thongtin.Rows[i].Cells[3].Value.ToString();
            txtGianhap.Text = dgv_thongtin.Rows[i].Cells[4].Value.ToString();
            txtGiaban.Text = dgv_thongtin.Rows[i].Cells[5].Value.ToString();
            txtDvt.Text = dgv_thongtin.Rows[i].Cells[6].Value.ToString();
            cbo_nhacc.Text = dgv_thongtin.Rows[i].Cells[7].Value.ToString();
            txt_mavach.Text = dgv_thongtin.Rows[i].Cells[8].Value.ToString();
           
            txtSoluong.Text = dgv_thongtin.Rows[i].Cells[9].Value.ToString();
           
            txtVAT.Text = dgv_thongtin.Rows[i].Cells[10].Value.ToString();
            date_nsx.Text = dgv_thongtin.Rows[i].Cells[11].Value.ToString();
            date_hsd.Text = dgv_thongtin.Rows[i].Cells[12].Value.ToString();
            txtMahh.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //kiem tra xem da nhap du du lieu vao chua
            if (string.IsNullOrEmpty(txtMahh.Text) || string.IsNullOrEmpty(txtTenhh.Text) || string.IsNullOrEmpty(cbo_nhomhang.Text)
               || string.IsNullOrEmpty(txtXuatxu.Text) || string.IsNullOrEmpty(txtGianhap.Text) || string.IsNullOrEmpty(txtGiaban.Text)
               || string.IsNullOrEmpty(txtDvt.Text) || cbo_nhacc.Text == "---- Chọn nhà cung cấp ----" || string.IsNullOrEmpty(txt_mavach.Text)
               || string.IsNullOrEmpty(txtSoluong.Text) || string.IsNullOrEmpty(txtVAT.Text))
            {
                MessageBox.Show("Chưa nhập đủ thông tin!", "Thông báo");
                return;
            }

            //b1 lay du lieu tu cac control dua vao bien
            string p_mahh = txtMahh.Text.Trim();
            string p_tenhh = txtTenhh.Text.Trim();
            string p_nhomhang = cbo_nhomhang.Text.Trim();
            string p_xuatxu = txtXuatxu.Text.Trim();
            int p_gianhap = int.Parse(txtGianhap.Text.Trim());
            int p_giaban = int.Parse(txtGiaban.Text.Trim());
            string p_dvt = txtDvt.Text.Trim();
            string p_nhacc = cbo_nhacc.Text.Trim();
            string p_mavach = txt_mavach.Text.Trim();
            int p_soluong = int.Parse(txtSoluong.Text.Trim());   
            float p_vat = float.Parse(txtVAT.Text.Trim());
            DateTime p_nsx = date_nsx.Value;
            DateTime p_hsd = date_hsd.Value;


            //b2 ket noi den database
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            //b3 tao doi tuong cmd de thuc hien sua du lieu
            string sql = "Update banghanghoa set tenhang=@tenhang,nhomhang=@nhomhang,xuatxu=@xuatxu,gianhap=@gianhap,giaban=@giaban,donvitinh=@donvitinh,nhacungcap=@nhacungcap,mavach=@mavach,soluong=@soluong,vat=@vat, NSX=@NSX ,HSD=@HSD where mahh='"+p_mahh+"'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@mahh", SqlDbType.NVarChar, 50).Value = p_mahh;
            cmd.Parameters.Add("@tenhang", SqlDbType.NVarChar, 50).Value = p_tenhh;
            cmd.Parameters.Add("@nhomhang", SqlDbType.NVarChar, 50).Value = p_nhomhang;
            cmd.Parameters.Add("@xuatxu", SqlDbType.NVarChar, 50).Value = p_xuatxu;

            cmd.Parameters.Add("@gianhap", SqlDbType.Int).Value = p_gianhap;
            cmd.Parameters.Add("@giaban", SqlDbType.Int).Value = p_giaban;
            cmd.Parameters.Add("@donvitinh", SqlDbType.NVarChar, 50).Value = p_dvt;
            cmd.Parameters.Add("@nhacungcap", SqlDbType.NVarChar, 50).Value = p_nhacc;
            cmd.Parameters.Add("@mavach", SqlDbType.NVarChar, 50).Value = p_mavach;

            cmd.Parameters.Add("@soluong", SqlDbType.Int).Value = p_soluong;
          
            cmd.Parameters.Add("@vat", SqlDbType.Float).Value = p_vat;
            cmd.Parameters.Add("@NSX", SqlDbType.Date).Value = p_nsx;
            cmd.Parameters.Add("@HSD", SqlDbType.Date).Value = p_hsd;



            //

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("Sửa hoàn tất !","Thông báo");
            txtMahh.Enabled = false;
            load_dgv();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //b1 lay du lieu tu control
            string p_mahh = txtMahh.Text.Trim();

            //n2 ket noi den database
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            //b3 tao doi tuong cmd de thuc hien xoa du lieu
            string sql = "Delete banghanghoa where mahh='" + p_mahh + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();//giaiphong bo nho
            con.Close();//ngatketnoi
            MessageBox.Show("Xoa thanh cong !");
            load_dgv();
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            txtMahh.Enabled = true;
            

            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    (control as TextBox).Text = string.Empty;
                }
            }
            cbo_nhacc.Text = "---- Chọn nhà cung cấp ----";
            cbo_nhomhang.Text = null;
           
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
            string sql = "select * from banghanghoa";
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
            ExportExcel(tb, "THÔNG TIN HÀNG HÓA");
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

            e_excel.Range head = oSheet.get_Range("A1", "L1");
            head.MergeCells = true;//trộn nhiều ô thành 1 ô
            head.Value2 = "DANH SÁCH THÔNG TIN HÀNG HÓA ";
            head.Font.Bold = true;//chữ đậm
            head.Font.Name = "Tahoma";//font
            head.Font.Size = "16";//cỡ chữ
            head.HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;//căn giữa
                                                                       // Tạo tiêu đề cột 
            e_excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "MÃ HH";//TÊN CỘT
            cl1.ColumnWidth = 20;//ĐỘ RỘNG CỘT
            e_excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "TÊN HH";
            cl2.ColumnWidth = 25.0;
            e_excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "NHÓM HÀNG";
            cl3.ColumnWidth = 20.0;

            e_excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "XUẤT XỨ";
            cl4.ColumnWidth = 20.0;

            e_excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "GIÁ NHẬP";
            cl5.ColumnWidth = 30.0;
            e_excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "GIÁ BÁN";
            cl6.ColumnWidth = 30.0;

            e_excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl7.Value2 = "ĐƠN VỊ TÍNH";//TÊN CỘT
            cl7.ColumnWidth = 25;//ĐỘ RỘNG CỘT
            e_excel.Range cl8 = oSheet.get_Range("H3", "H3");
            cl8.Value2 = "NHÀ CUNG CẤP";
            cl8.ColumnWidth = 25.0;

            e_excel.Range cl9 = oSheet.get_Range("I3", "I3");
            cl9.Value2 = "MÃ VẠCH";
            cl9.ColumnWidth = 25.0;
            e_excel.Range cl10 = oSheet.get_Range("J3", "J3");
            cl10.Value2 = "SỐ LƯỢNG";
            cl10.ColumnWidth = 30.0;
            
            e_excel.Range cl12 = oSheet.get_Range("K3", "K3");
            cl12.Value2 = "VAT";
            cl12.ColumnWidth = 20.0;
            e_excel.Range cl13 = oSheet.get_Range("L3", "L3");
            cl13.Value2 = "NSX";
            cl13.ColumnWidth = 20.0;
            e_excel.Range cl11 = oSheet.get_Range("M3", "M3");
            cl11.Value2 = "HSD";
            cl11.ColumnWidth = 20.0;


            //Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            //cl6.Value2 = "NGÀY THI";
            //cl6.ColumnWidth = 15.0;
            //Microsoft.Office.Interop.Excel.Range cl6_1 = oSheet.get_Range("F4", "F1000");
            //cl6_1.Columns.NumberFormat = "dd/mm/yyyy";

            e_excel.Range rowHead = oSheet.get_Range("A3", "M3");
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

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            frmNhaCungCap frm  =new frmNhaCungCap();
            frm.ShowDialog();
            this.Close();
        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {

        }

        private void txtGianhap_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtGiaban_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtVAT_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            if(e.KeyChar == '.')
            {
                e.Handled=false;
            }
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            frmNhapHang frmNhapHang = new frmNhapHang();
                frmNhapHang.ShowDialog();
            this.Close();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            //b1 Lay du lieu tu cac control dua vao bien
            string p_mahh = txtMahh.Text.Trim();
            string p_tenhh = txtTenhh.Text.Trim();
            string p_nhomhang = cbo_nhomhang.Text.Trim();
            string p_xuatxu = txtXuatxu.Text.Trim();

           

            string p_dvt = txtDvt.Text.Trim();
            string p_nhacc = cbo_nhacc.Text.Trim();
            string p_mavach = txt_mavach.Text.Trim();


            //int p_soluong = int.Parse(txtSoluong.Text.Trim());
            //int p_trangthaiban = int.Parse(cbo_trangthai.Text.Trim());
           // float p_vat = float.Parse(txtVAT.Text.Trim());

            //B2 ket noi den db
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            //b3 Tao doi tuong command de lay du lieu tu bang nxb
            string sql = "select * from banghanghoa where mahh like N'%" + p_mahh + "%' and tenhang like N'%" + p_tenhh + "%' " +
                "and nhomhang like N'%" + p_nhomhang + "%' and xuatxu like N'%" + p_xuatxu + "%' " +
               // "and gianhap like N'%" + p_gianhap + "%' and giaban like N'%" + p_giaban + "%'" +  
                "and donvitinh like N'%" + p_dvt + "%'  and nhacungcap like N'%" + p_nhacc + "%'  " +
                "and mavach like N'%" + p_mavach  + "%' ";
            SqlCommand cmd = new SqlCommand(sql,con);

            //b4 tao doi tuong dataAdapter de lay ket qua tu command
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            //b5 do du lieu tu dataAdapter vao datatable
            DataTable datatb = new DataTable();
            da.Fill(datatb);
            cmd.Dispose();
            con.Close();
            //b6 hien thi datatable len datagridview
            dgv_thongtin.DataSource = datatb;
            dgv_thongtin.Refresh();
        }

        private void btnLoaiHang_Click(object sender, EventArgs e)
        {
            frm_trahang frm_Trahang = new frm_trahang();
            frm_Trahang.ShowDialog();
            this.Close();
        }
    }

}

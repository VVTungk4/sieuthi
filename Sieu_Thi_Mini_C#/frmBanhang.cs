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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Web.UI.WebControls;
using System.Data.Common;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Diagnostics;

namespace Sieu_Thi_Mini_C_
{
    public partial class frmBanhang : Form
    {
        private Form mainForm;
        // Thiết lập biến toàn cục
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        public frmBanhang()
        {
            InitializeComponent();
        }
        public frmBanhang(Form form, string getRole, string taikhoan, string password)
        {
            InitializeComponent();
            this.getRole = getRole;
            this.taikhoan = taikhoan;
            this.password = password;
            mainForm = form;
        }
        
        private void load_dgv()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "select* from banghoadon";
            SqlCommand cmd = new SqlCommand(sql, con);
            //tao doi tuong data adapter de lay du lieu
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            //do du lieu tu da va database
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
        }
       private void btnkiemtra_Click(object sender, EventArgs e)
        {
            string p_mavach = txt_mahh.Text.Trim();
            string tenhang = "Select mahh,tenhang,giaban,vat from banghanghoa where mavach=N'" + p_mavach + "'";
          //DataTable current_data = (DataTable)dgv_thongtin.DataSource;
            SqlCommand cmd = new SqlCommand(tenhang, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            txt_mahh.Text = null;
        }

        private void dgv_thongtin_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            if (e.RowIndex == dgv_thongtin.Rows.Count - 1)
            {
                return;
            }
            if (e.ColumnIndex == dgv_thongtin.Columns["dgv_xoahang"].Index && e.RowIndex >= 0)
            {
                dgv_thongtin.Rows.RemoveAt(dgv_thongtin.CurrentRow.Index);
                return;
            }
            if (e.ColumnIndex == dgv_thongtin.Columns["dgv_tangsl"].Index && e.RowIndex >= 0)
            {
                int p_soluong = Convert.ToInt32(dgv_thongtin.CurrentRow.Cells["dgv_soluong"].Value);


                string p_tenhang = dgv_thongtin.CurrentRow.Cells["dgv_tenhh"].Value.ToString();

                string sql = "Select soluong from banghanghoa where tenhang=N'" + p_tenhang + "'";

                SqlCommand cmd = new SqlCommand(sql, con);
                int p_soluongmax = (int)cmd.ExecuteScalar();
                if (p_soluong == p_soluongmax)
                {
                    MessageBox.Show("Số lượng trong kho đã đạt giới hạn, vui lòng nhập thêm hàng", "Thông báo");
                    return;
                }
                p_soluong++;

                dgv_thongtin.CurrentRow.Cells["dgv_soluong"].Value = p_soluong;

            }

            if (e.ColumnIndex == dgv_thongtin.Columns["dgv_giamsl"].Index && e.RowIndex >= 0)
            {
                int p_soluong = Convert.ToInt32(dgv_thongtin.CurrentRow.Cells[2].Value);
                p_soluong--;
                if (p_soluong <= 0)
                {
                    return;
                }
                dgv_thongtin.CurrentRow.Cells[2].Value = p_soluong;


            }
            for (int i = 0; i < dgv_thongtin.Rows.Count; ++i)
            {
                int p_dongia = Convert.ToInt32(dgv_thongtin.Rows[i].Cells["dgv_dongia"].Value);
                int p_soluongg = Convert.ToInt32(dgv_thongtin.Rows[i].Cells["dgv_soluong"].Value);
                int p_thanhtien = p_dongia * p_soluongg;
                dgv_thongtin.Rows[i].Cells["dgv_thanhtien"].Value = p_thanhtien;
            }
            float sum = 0; float vat = 0;
            for (int i = 0; i < dgv_thongtin.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgv_thongtin.Rows[i].Cells["dgv_thanhtien"].Value);
            }
            for (int i = 0; i < dgv_thongtin.Rows.Count; ++i)
            {
                vat += (Convert.ToSingle(dgv_thongtin.Rows[i].Cells["dgv_thanhtien"].Value) * Convert.ToSingle(dgv_thongtin.Rows[i].Cells["dgv_vat"].Value));
            }
            txt_tienhang.Text = sum.ToString();
            txt_vat.Text = vat.ToString();
            txt_thanhtoan.Text = (float.Parse(txt_vat.Text) + float.Parse(txt_tienhang.Text)).ToString();
        }
        private void btnT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            if (getRole == "Nhân viên")
            {
                MessageBox.Show("Bạn không đủ quyền","Thông báo");
                    return;
            }
            frmHangHoa frmHangHoa = new frmHangHoa();
            frmHangHoa.ShowDialog();
        }
        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            if (getRole == "Nhân viên")
            {
                MessageBox.Show("Bạn không đủ quyền","Thông báo");
                    return;
            }
            frmNhaCungCap frmncc = new frmNhaCungCap();
            frmncc.ShowDialog();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {   if(getRole=="Nhân viên")
            {
                MessageBox.Show("Bạn không đủ quyền","Thông báo");
                    return;
            }
            frmNhapHang frmnhaphang = new frmNhapHang();
            frmnhaphang.ShowDialog();
        }

        private List<int> randomList = new List<int>();
        private string getRole;
        private string taikhoan;
        private string password;    
        private void load_cbo_tenhang()
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
            //
            DataRow dr = tb.NewRow();
            dr["mahh"] = "";
            dr["tenhang"] = "------- Chọn tên hàng hóa -------";
            tb.Rows.InsertAt(dr, 0);
            //hien thi tb vao combobox
            cbo_nhomhang.DataSource = tb;
            cbo_nhomhang.DisplayMember = "tenhang";
            cbo_nhomhang.ValueMember = "mahh";
        }
      
        private void formBanhang_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            //

               if (con.State == ConnectionState.Closed)
               {
                   con.Open();
               }
            //b3 tao doi tuong command de kiem tra
              string hd = "SELECT MAX(sohd) FROM banghoadonchitiet ";
                 SqlCommand cmdd = new SqlCommand(hd, con);
               int max = Convert.ToInt32(cmdd.ExecuteScalar());     
               int shd = max +1; 
               cmdd.Dispose();
               con.Close();
               txt_shd.Text=shd.ToString();
            //
            
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "select tennv from bangthongtinnhanvien where username='" + taikhoan + "' and Password='" + password + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            string ten = (string)cmd.ExecuteScalar();
            label7.Text = getRole + ":" + ten;
            //them thoi gian hien hanh
            lbn_tgian.Text = DateTime.Now.ToString("dd/MM/yyyy");
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
            //them cbo + lst
            load_cbo_tenhang();
            // Bật thuộc tính ReadOnly của ComboBox
            cbo_nhomhang.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private void cbo_nhomhang_SelectedValueChanged(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string p_mahh = cbo_nhomhang.SelectedValue.ToString();         
                string sql = "Select mahh,tenhang,giaban,vat from banghanghoa where mahh=N'" + p_mahh + "'";
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
                if (p_mahh == dgv_thongtin.Rows[i].Cells["dgv_mahh"].Value.ToString())
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
           
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbn_tgian.Text= DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void btnLammoiphieu_Click(object sender, EventArgs e)
        {
            // Xóa tất cả các dòng trong datagridview
            for (int i = dgv_thongtin.Rows.Count - 2; i >= 0; i--)
            {
                // Xóa dòng khỏi datagridview
                dgv_thongtin.Rows.RemoveAt(i);
                // Xóa dòng khỏi cơ sở dữ liệu nếu cần
                // ...
                txt_tiendua.Text = null;
                txt_tienhang.Text = null;
                txt_vat.Text = null;
                txt_thanhtoan.Text = null;
            }
            
            formBanhang_Load (sender, e);
        }

        private void btnXuatHang_Click(object sender, EventArgs e)
        {
            frm_trahang frm_Trahang = new frm_trahang();
            frm_Trahang.ShowDialog(this);
        }

        private void ExportExcel(DataTable tb, string sheetname)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "select tennv from bangthongtinnhanvien where username='" + taikhoan + "' and Password='" + password + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            string ten = (string)cmd.ExecuteScalar();
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

            e_excel.Range head = oSheet.get_Range("A1", "D1");
            head.MergeCells = true;//trộn nhiều ô thành 1 ô
            head.Value2 = "DANH SÁCH THÔNG TIN HÓA ĐƠN";
            head.Font.Bold = true;//chữ đậm
            head.Font.Name = "Tahoma";//font
            head.Font.Size = "16";//cỡ chữ
            head.HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;//căn giữa
                                                                       // Tạo tiêu đề cột 
            e_excel.Range sohd = oSheet.get_Range("A2", "D2");
            sohd.MergeCells = true;//trộn nhiều ô thành 1 ô
            sohd.Value2 = "HÓA ĐƠN " + txt_shd.Text.Trim();
            sohd.Font.Size = "13";//cỡ chữ
            sohd.HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;
            //
            e_excel.Range tenkh = oSheet.get_Range("A3", "D3");
            tenkh.MergeCells = true;//trộn nhiều ô thành 1 ô
            tenkh.Value2 = "Khách hàng: " + txt_tenkh.Text.Trim();
            tenkh.Font.Size = "13";//cỡ chữ
           // tenkh.HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;
            //
             e_excel.Range tennv = oSheet.get_Range("A4", "D4");
            tennv.MergeCells = true;//trộn nhiều ô thành 1 ô
            tennv.Value2 = "Nhân viên: " + ten;
            tennv.Font.Size = "13";//cỡ chữ
            //
            e_excel.Range ngay = oSheet.get_Range("A5", "D5");
            ngay.MergeCells = true;//trộn nhiều ô thành 1 ô
            ngay.Value2 = "Ngày: " + DateTime.Now;
            ngay.Font.Size = "13";//cỡ chữ
            //
            e_excel.Range cl1 = oSheet.get_Range("A6", "A6");
            cl1.Value2 = "TÊN HÀNG";//TÊN CỘT
            cl1.ColumnWidth = 25;//ĐỘ RỘNG CỘT
            e_excel.Range cl2 = oSheet.get_Range("B6", "B6");
            cl2.Value2 = "SL";
            cl2.ColumnWidth = 8.0;
            e_excel.Range cl3 = oSheet.get_Range("C6", "C6");
            cl3.Value2 = "ĐƠN GIÁ";
            cl3.ColumnWidth = 15.0;
            e_excel.Range cl4 = oSheet.get_Range("D6", "D6");
            cl4.Value2 = "THÀNH TIỀN";
            cl4.ColumnWidth = 15.0;
           



            //Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            //cl6.Value2 = "NGÀY THI";
            //cl6.ColumnWidth = 15.0;
            //Microsoft.Office.Interop.Excel.Range cl6_1 = oSheet.get_Range("F4", "F1000");
            //cl6_1.Columns.NumberFormat = "dd/mm/yyyy";

            e_excel.Range rowHead = oSheet.get_Range("A6", "D6");
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
                    arr[r, c] = dr[c];
                }
            }
            //Thiết lập vùng điền dữ liệu
            int rowStart = 7;
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
            //
            // Kẻ viền
            range.Borders.LineStyle = e_excel.Constants.xlSolid;
            // Căn giữa cột STT
            e_excel.Range c3 = (e_excel.Range)oSheet.Cells[rowEnd, columnStart];
            e_excel.Range c4 = oSheet.get_Range(c1, c3);
            oSheet.get_Range(c3, c4).HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;
            //
            oSheet.get_Range(c1, c2).HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;

        }
        private void formBanhang_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (getRole == "Nhân viên") { mainForm.Show(); }
            mainForm.Show();
        }
        private void capnhatsoluong(string p_mahh, int soluongmoi)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string p_soluong = "Select soluong from banghanghoa where mahh='" + p_mahh + "' ";
            string sql = " Update banghanghoa set soluong=@soluong where mahh='" + p_mahh + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlCommand sl = new SqlCommand(p_soluong, con);
            // int soluongcu = Convert.ToInt32(sl.ExecuteScalar());
            int soluongcu = (int)sl.ExecuteScalar();
            if (soluongcu == 0)
            {
                MessageBox.Show("Hàng trong kho đã hết, vui lòng nhập thêm hàng !");
                return;
            }
            int soluong = soluongcu - soluongmoi;
            cmd.Parameters.Add("@soluong", SqlDbType.Int).Value = soluong;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        private void luu(string p_shd, string tenhang, int sl, int dongia, int thanhtien, string ngay, string mahh)
        {  
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }         
            string p_ngay = DateTime.Now.ToString("yyyy-MM-dd");
            string sql = "Insert banghoadonchitiet values ( @sohd,@tenhh, @soluong, @dongia, @thanhtien, '"+p_ngay+"',@mahh )";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@sohd", SqlDbType.Int).Value = p_shd;
            cmd.Parameters.Add("@tenhh", SqlDbType.NVarChar, 50).Value = tenhang;
            cmd.Parameters.Add("@soluong", SqlDbType.Int).Value = sl;
            cmd.Parameters.Add("@dongia", SqlDbType.Int).Value = dongia;
            cmd.Parameters.Add("@thanhtien", SqlDbType.Int).Value = thanhtien;
            cmd.Parameters.Add("@mahh",SqlDbType.NVarChar,50 ).Value = mahh;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        private void btn_inhoadon_Click(object sender, EventArgs e)
        {
            string p_shd = txt_shd.Text.Trim();
            //
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "select tenhh, soluong, dongia, thanhtien from banghoadonchitiet where sohd = '"+p_shd+"' ";
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
            ExportExcel(tb, "BẢNG HÓA ĐƠN CHI TIẾT");
        }

        
        List<int> list_thanhtien = new List<int>();

        //

        private void xulybanghoadonngay()
        {
            string ngay = DateTime.Now.ToString("yyyy-MM-dd");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "SELECT COUNT(*) FROM bangdoanhthutheongay WHERE ngay = @ngay";
            SqlCommand cmd= new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@ngay", ngay);

            //
            string doanhthungay1 = "SELECT SUM(thanhtien) FROM banghoadonchitiet WHERE ngay = '" + ngay + "' GROUP BY ngay";

            SqlCommand dthu = new SqlCommand(doanhthungay1, con);
            int doanhthucu = (int)dthu.ExecuteScalar();
            int doanhthungay = doanhthucu + Convert.ToInt32(txt_thanhtoan.Text);
            //
            int dem = Convert.ToInt32(cmd.ExecuteScalar());
           // textBox1.Text = dem.ToString();
            if (dem > 0)
            {
                cmd.CommandText = "UPDATE bangdoanhthutheongay SET doanhthungay = @doanhthungay WHERE ngay = @date";
                cmd.Parameters.AddWithValue("@date", ngay);
                cmd.Parameters.AddWithValue("@doanhthungay", doanhthungay);
                cmd.ExecuteNonQuery();
              //  Console.WriteLine("Đã cập nhật doanh thu cho ngày " + ngay.ToString("dd/MM/yyyy"));
            }
            // Nếu không, thì thêm mới doanh thu
            else
            {
                cmd.CommandText = "INSERT INTO bangdoanhthutheongay (ngay, doanhthungay) VALUES (@date1, @doanhthungay)";
                cmd.Parameters.AddWithValue("@date1", ngay);
                cmd.Parameters.AddWithValue("@doanhthungay", doanhthungay);
                cmd.ExecuteNonQuery();
              //  Console.WriteLine("Đã thêm mới doanh thu cho ngày " + date.ToString("dd/MM/yyyy"));
            }

        }
     
        private void btn_luu_Click(object sender, EventArgs e)
        {
             string ngay = DateTime.Now.ToString("yyyy-MM-dd");
          //  string ngay = "2023-12-26";
            string p_shd = txt_shd.Text.Trim();
            
            //int thanhtien =int.Parse( txt_thanhtoan.Text.Trim()); 
            for (int i = 0; i < dgv_thongtin.Rows.Count -1 ; i++)
            {
                string tenhang = dgv_thongtin.Rows[i].Cells["dgv_tenhh"].Value.ToString();
                int sl = int.Parse(dgv_thongtin.Rows[i].Cells["dgv_soluong"].Value.ToString());
                int dongia = int.Parse(dgv_thongtin.Rows[i].Cells["dgv_dongia"].Value.ToString());
                int thanhtien = int.Parse(dgv_thongtin.Rows[i].Cells["dgv_thanhtien"].Value.ToString());
                string mahh= dgv_thongtin.Rows[i].Cells["dgv_mahh"].Value.ToString();
                
                //
                luu(p_shd, tenhang, sl, dongia, thanhtien, ngay, mahh);
            }
            for (int i = 0; i < dgv_thongtin.RowCount - 1; i++)
            {
                string p_mahh = dgv_thongtin.Rows[i].Cells["dgv_mahh"].Value.ToString();
                int soluongmoi = Convert.ToInt32(dgv_thongtin.Rows[i].Cells["dgv_soluong"].Value);
                capnhatsoluong(p_mahh, soluongmoi);
            }
         //   MessageBox.Show("Cap nhat thanh cong!", "Thong bao");
            MessageBox.Show("Save","Thông báo");
            //
              xulybanghoadonngay(); 
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string p_mavach = txt_mahh.Text.Trim();
            string tenhang = "Select mahh,tenhang,giaban,vat from banghanghoa where mavach=N'" + p_mavach + "'";
            DataTable current_data = (DataTable)dgv_thongtin.DataSource;
            SqlCommand cmd = new SqlCommand(tenhang, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            if (current_data == null)
            {
                current_data = new DataTable();
            }
            current_data.Merge(tb);
            dgv_thongtin.DataSource = current_data;
            txt_mahh.Text = null;
        }

    }
}








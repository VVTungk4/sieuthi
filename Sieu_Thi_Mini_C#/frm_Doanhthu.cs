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
//using ZedGraph;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Sieu_Thi_Mini_C_
{
    public partial class frm_Doanhthu : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        public frm_Doanhthu()
        {
            InitializeComponent();
        }

        private void frm_Doanhthu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sieuthimini_DataSET.doanhthu' table. You can move, or remove it, as needed.
            //  this.doanhthuTableAdapter.Fill(this.sieuthimini_DataSET.doanhthu);
            this.WindowState = FormWindowState.Maximized;//
                                                         // GraphPane myPane = zedGraphControl1.GraphPane;

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "Select * from bangdoanhthutheongay";
             //SELECT SUM(doanhthu) FROM banghoadontheongay WHERE customer_id = 1;
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            cmd.Dispose();
            con.Close();
            //MessageBox.Show("Thành công !");
            chartDoanhthu.ChartAreas["ChartArea1"].AxisX.Title = "Ngày";

            chartDoanhthu.ChartAreas["ChartArea1"].AxisY.Title = "Doanh thu";
            //Lấy tất cả các ngày trong SQL
           //chartDoanhthu.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            //
            //chartDoanhthu.Series["Doanh thu"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                chartDoanhthu.Series["Doanh thu"].Points.AddXY(dt.Rows[i]["ngay"], dt.Rows[i]["doanhthungay"]);
            }
        }


        private void xulybanghoadonngay()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string p_ngay = DateTime.Now.ToString("yyyy-MM-dd");
          //  string p_ngay = "2023-12-27";

            // float p_doanhthungay=float.Parse(txt_thanhtoan.Text.Trim());
            string doanhthungay = "Select Sum(thanhtien) from banghoadonchitiet where ngay='" + p_ngay + "'";

              SqlCommand dthu = new SqlCommand(doanhthungay, con);
             int doanhthu = (int)dthu.ExecuteScalar();
            
          
                if (p_ngay == DateTime.Now.ToString("yyyy-MM-dd"))
            {
                string sql = "Update bangdoanhthutheongay set ngay=@ngay, doanhthungay=@doanhthungay where ngay='"+p_ngay+"'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@ngay", SqlDbType.Date).Value = p_ngay;
                cmd.Parameters.Add("@doanhthungay", SqlDbType.Int).Value = doanhthu;
                cmd.ExecuteNonQuery();
            }
            else
            {

                string sql = "Insert bangdoanhthutheongay values (@ngay, @doanhthungay)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@ngay", SqlDbType.Date).Value = p_ngay;
                cmd.Parameters.Add("@doanhthungay", SqlDbType.Int).Value = doanhthu;
                cmd.ExecuteNonQuery();
            }

        }
        private void loadbieudo()
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            xulybanghoadonngay();
            this.Close();
            frm_Doanhthu frm_Doanhthu= new frm_Doanhthu();
            frm_Doanhthu.ShowDialog();
            this.Close();
           // frm_Doanhthu_Load(sender, e);
        }
    }
}
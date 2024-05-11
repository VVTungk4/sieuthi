namespace Sieu_Thi_Mini_C_
{
    partial class frm_trahang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_trahang));
            this.dgv_thongtin = new System.Windows.Forms.DataGridView();
            this.dgv_btnXoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgv_mahh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_tenhh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_tientralai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_lydo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnT = new System.Windows.Forms.Button();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.btnLoaiHang = new System.Windows.Forms.Button();
            this.btnNhaCungCap = new System.Windows.Forms.Button();
            this.btnHangHoa = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lst_dshh = new System.Windows.Forms.ListBox();
            this.btnLammoiphieu = new System.Windows.Forms.Button();
            this.txt_matrahang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_xacnhan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongtin)).BeginInit();
            this.grb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_thongtin
            // 
            this.dgv_thongtin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thongtin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_btnXoa,
            this.dgv_mahh,
            this.dgv_tenhh,
            this.dgv_soluong,
            this.dgv_dongia,
            this.dgv_tientralai,
            this.dgv_lydo});
            this.dgv_thongtin.Location = new System.Drawing.Point(335, 176);
            this.dgv_thongtin.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_thongtin.Name = "dgv_thongtin";
            this.dgv_thongtin.RowHeadersWidth = 51;
            this.dgv_thongtin.RowTemplate.Height = 24;
            this.dgv_thongtin.Size = new System.Drawing.Size(852, 525);
            this.dgv_thongtin.TabIndex = 1;
            this.dgv_thongtin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_thongtin_CellClick);
            // 
            // dgv_btnXoa
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "x";
            this.dgv_btnXoa.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_btnXoa.HeaderText = "Xoá";
            this.dgv_btnXoa.MinimumWidth = 6;
            this.dgv_btnXoa.Name = "dgv_btnXoa";
            this.dgv_btnXoa.Width = 50;
            // 
            // dgv_mahh
            // 
            this.dgv_mahh.DataPropertyName = "mahh";
            this.dgv_mahh.HeaderText = "Mã HH";
            this.dgv_mahh.MinimumWidth = 6;
            this.dgv_mahh.Name = "dgv_mahh";
            this.dgv_mahh.Width = 125;
            // 
            // dgv_tenhh
            // 
            this.dgv_tenhh.DataPropertyName = "tenhang";
            this.dgv_tenhh.HeaderText = "Tên hàng";
            this.dgv_tenhh.MinimumWidth = 6;
            this.dgv_tenhh.Name = "dgv_tenhh";
            this.dgv_tenhh.Width = 125;
            // 
            // dgv_soluong
            // 
            this.dgv_soluong.DataPropertyName = "soluong";
            this.dgv_soluong.HeaderText = "SL trả";
            this.dgv_soluong.MinimumWidth = 6;
            this.dgv_soluong.Name = "dgv_soluong";
            this.dgv_soluong.Width = 125;
            // 
            // dgv_dongia
            // 
            this.dgv_dongia.DataPropertyName = "giaban";
            this.dgv_dongia.HeaderText = "Đơn giá";
            this.dgv_dongia.MinimumWidth = 6;
            this.dgv_dongia.Name = "dgv_dongia";
            this.dgv_dongia.Width = 80;
            // 
            // dgv_tientralai
            // 
            this.dgv_tientralai.HeaderText = "Tiền trả lại";
            this.dgv_tientralai.MinimumWidth = 6;
            this.dgv_tientralai.Name = "dgv_tientralai";
            this.dgv_tientralai.Width = 80;
            // 
            // dgv_lydo
            // 
            this.dgv_lydo.HeaderText = "Lý do trả hàng";
            this.dgv_lydo.MinimumWidth = 6;
            this.dgv_lydo.Name = "dgv_lydo";
            this.dgv_lydo.Width = 200;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Lavender;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(501, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(477, 76);
            this.label12.TabIndex = 56;
            this.label12.Text = "QUẢN LÝ TRẢ HÀNG\r\n ------------------------";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grb1
            // 
            this.grb1.BackColor = System.Drawing.Color.Lavender;
            this.grb1.Controls.Add(this.pictureBox1);
            this.grb1.Controls.Add(this.btnT);
            this.grb1.Controls.Add(this.btnNhapHang);
            this.grb1.Controls.Add(this.btnLoaiHang);
            this.grb1.Controls.Add(this.btnNhaCungCap);
            this.grb1.Controls.Add(this.btnHangHoa);
            this.grb1.Location = new System.Drawing.Point(42, 31);
            this.grb1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grb1.Name = "grb1";
            this.grb1.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grb1.Size = new System.Drawing.Size(272, 766);
            this.grb1.TabIndex = 57;
            this.grb1.TabStop = false;
            this.grb1.Text = "Quản lý kho hàng";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sieu_Thi_Mini_C_.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(20, 53);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // btnT
            // 
            this.btnT.Location = new System.Drawing.Point(44, 653);
            this.btnT.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(198, 61);
            this.btnT.TabIndex = 47;
            this.btnT.Text = "Thoát";
            this.btnT.UseVisualStyleBackColor = true;
            this.btnT.Click += new System.EventHandler(this.btnT_Click);
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.Location = new System.Drawing.Point(44, 545);
            this.btnNhapHang.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(198, 61);
            this.btnNhapHang.TabIndex = 45;
            this.btnNhapHang.Text = "Nhập Hàng";
            this.btnNhapHang.UseVisualStyleBackColor = true;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // btnLoaiHang
            // 
            this.btnLoaiHang.Location = new System.Drawing.Point(44, 439);
            this.btnLoaiHang.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnLoaiHang.Name = "btnLoaiHang";
            this.btnLoaiHang.Size = new System.Drawing.Size(198, 61);
            this.btnLoaiHang.TabIndex = 44;
            this.btnLoaiHang.Text = "Trả hàng";
            this.btnLoaiHang.UseVisualStyleBackColor = true;
            // 
            // btnNhaCungCap
            // 
            this.btnNhaCungCap.Location = new System.Drawing.Point(44, 329);
            this.btnNhaCungCap.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnNhaCungCap.Name = "btnNhaCungCap";
            this.btnNhaCungCap.Size = new System.Drawing.Size(198, 61);
            this.btnNhaCungCap.TabIndex = 43;
            this.btnNhaCungCap.Text = "Nhà Cung Cấp";
            this.btnNhaCungCap.UseVisualStyleBackColor = true;
            this.btnNhaCungCap.Click += new System.EventHandler(this.btnNhaCungCap_Click);
            // 
            // btnHangHoa
            // 
            this.btnHangHoa.Location = new System.Drawing.Point(44, 208);
            this.btnHangHoa.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnHangHoa.Name = "btnHangHoa";
            this.btnHangHoa.Size = new System.Drawing.Size(198, 61);
            this.btnHangHoa.TabIndex = 42;
            this.btnHangHoa.Text = "Hàng Hóa";
            this.btnHangHoa.UseVisualStyleBackColor = true;
            this.btnHangHoa.Click += new System.EventHandler(this.btnHangHoa_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lst_dshh);
            this.groupBox3.Location = new System.Drawing.Point(1195, 176);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox3.Size = new System.Drawing.Size(298, 525);
            this.groupBox3.TabIndex = 59;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách hàng hóa";
            // 
            // lst_dshh
            // 
            this.lst_dshh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lst_dshh.FormattingEnabled = true;
            this.lst_dshh.ItemHeight = 20;
            this.lst_dshh.Location = new System.Drawing.Point(24, 39);
            this.lst_dshh.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lst_dshh.Name = "lst_dshh";
            this.lst_dshh.Size = new System.Drawing.Size(252, 464);
            this.lst_dshh.TabIndex = 0;
            this.lst_dshh.SelectedValueChanged += new System.EventHandler(this.lst_dshh_SelectedValueChanged);
            // 
            // btnLammoiphieu
            // 
            this.btnLammoiphieu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLammoiphieu.Image = ((System.Drawing.Image)(resources.GetObject("btnLammoiphieu.Image")));
            this.btnLammoiphieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLammoiphieu.Location = new System.Drawing.Point(1028, 708);
            this.btnLammoiphieu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLammoiphieu.Name = "btnLammoiphieu";
            this.btnLammoiphieu.Size = new System.Drawing.Size(159, 37);
            this.btnLammoiphieu.TabIndex = 62;
            this.btnLammoiphieu.Text = "Làm Mới Phiếu";
            this.btnLammoiphieu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLammoiphieu.UseVisualStyleBackColor = true;
            this.btnLammoiphieu.Click += new System.EventHandler(this.btnLammoiphieu_Click);
            // 
            // txt_matrahang
            // 
            this.txt_matrahang.BackColor = System.Drawing.Color.White;
            this.txt_matrahang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_matrahang.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_matrahang.Location = new System.Drawing.Point(709, 121);
            this.txt_matrahang.Name = "txt_matrahang";
            this.txt_matrahang.Size = new System.Drawing.Size(219, 30);
            this.txt_matrahang.TabIndex = 64;
            this.txt_matrahang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(563, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 25);
            this.label6.TabIndex = 63;
            this.label6.Text = "Mã trả hàng";
            // 
            // btn_xacnhan
            // 
            this.btn_xacnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_xacnhan.Location = new System.Drawing.Point(677, 724);
            this.btn_xacnhan.Name = "btn_xacnhan";
            this.btn_xacnhan.Size = new System.Drawing.Size(112, 44);
            this.btn_xacnhan.TabIndex = 60;
            this.btn_xacnhan.Text = "Xác nhận";
            this.btn_xacnhan.UseVisualStyleBackColor = true;
            this.btn_xacnhan.Click += new System.EventHandler(this.btn_xacnhan_Click);
            // 
            // frm_trahang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1881, 1008);
            this.Controls.Add(this.txt_matrahang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLammoiphieu);
            this.Controls.Add(this.btn_xacnhan);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grb1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgv_thongtin);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_trahang";
            this.Text = "frm_trahang";
            this.Load += new System.EventHandler(this.frm_trahang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongtin)).EndInit();
            this.grb1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_thongtin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.Button btnLoaiHang;
        private System.Windows.Forms.Button btnNhaCungCap;
        private System.Windows.Forms.Button btnHangHoa;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lst_dshh;
        private System.Windows.Forms.Button btnLammoiphieu;
        private System.Windows.Forms.TextBox txt_matrahang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewButtonColumn dgv_btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_mahh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_tenhh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_tientralai;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_lydo;
        private System.Windows.Forms.Button btn_xacnhan;
    }
}
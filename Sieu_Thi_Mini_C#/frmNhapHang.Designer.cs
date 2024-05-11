namespace Sieu_Thi_Mini_C_
{
    partial class frmNhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapHang));
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnT = new System.Windows.Forms.Button();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.btnTraHang = new System.Windows.Forms.Button();
            this.btnNhaCungCap = new System.Windows.Forms.Button();
            this.btnHangHoa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_thongtin = new System.Windows.Forms.DataGridView();
            this.dgv_btnXoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.mahh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenhh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lst_dshh = new System.Windows.Forms.ListBox();
            this.cbo_nhomhang = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuyphieu = new System.Windows.Forms.Button();
            this.btnLuuphieu = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.grb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongtin)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb1
            // 
            this.grb1.BackColor = System.Drawing.Color.Lavender;
            this.grb1.Controls.Add(this.pictureBox1);
            this.grb1.Controls.Add(this.btnT);
            this.grb1.Controls.Add(this.btnNhapHang);
            this.grb1.Controls.Add(this.btnTraHang);
            this.grb1.Controls.Add(this.btnNhaCungCap);
            this.grb1.Controls.Add(this.btnHangHoa);
            this.grb1.Location = new System.Drawing.Point(13, 23);
            this.grb1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grb1.Name = "grb1";
            this.grb1.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grb1.Size = new System.Drawing.Size(272, 820);
            this.grb1.TabIndex = 42;
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
            this.btnNhapHang.Location = new System.Drawing.Point(44, 430);
            this.btnNhapHang.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(198, 61);
            this.btnNhapHang.TabIndex = 45;
            this.btnNhapHang.Text = "Nhập Hàng";
            this.btnNhapHang.UseVisualStyleBackColor = true;
            // 
            // btnTraHang
            // 
            this.btnTraHang.Location = new System.Drawing.Point(44, 539);
            this.btnTraHang.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnTraHang.Name = "btnTraHang";
            this.btnTraHang.Size = new System.Drawing.Size(198, 61);
            this.btnTraHang.TabIndex = 44;
            this.btnTraHang.Text = "Trả Hàng";
            this.btnTraHang.UseVisualStyleBackColor = true;
            this.btnTraHang.Click += new System.EventHandler(this.btnLoaiHang_Click);
            // 
            // btnNhaCungCap
            // 
            this.btnNhaCungCap.Location = new System.Drawing.Point(44, 321);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_thongtin);
            this.groupBox1.Location = new System.Drawing.Point(324, 103);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(777, 562);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hàng nhập";
            // 
            // dgv_thongtin
            // 
            this.dgv_thongtin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thongtin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_btnXoa,
            this.mahh,
            this.tenhh,
            this.soluong,
            this.dongia,
            this.thanhtien});
            this.dgv_thongtin.Location = new System.Drawing.Point(19, 25);
            this.dgv_thongtin.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_thongtin.Name = "dgv_thongtin";
            this.dgv_thongtin.RowHeadersWidth = 51;
            this.dgv_thongtin.RowTemplate.Height = 24;
            this.dgv_thongtin.Size = new System.Drawing.Size(736, 525);
            this.dgv_thongtin.TabIndex = 0;
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
            // mahh
            // 
            this.mahh.DataPropertyName = "mahh";
            this.mahh.HeaderText = "MaHH";
            this.mahh.MinimumWidth = 6;
            this.mahh.Name = "mahh";
            this.mahh.Width = 125;
            // 
            // tenhh
            // 
            this.tenhh.DataPropertyName = "tenhang";
            this.tenhh.HeaderText = "Ten Hang Hoa";
            this.tenhh.MinimumWidth = 6;
            this.tenhh.Name = "tenhh";
            this.tenhh.Width = 125;
            // 
            // soluong
            // 
            this.soluong.HeaderText = "So Luong";
            this.soluong.MinimumWidth = 6;
            this.soluong.Name = "soluong";
            this.soluong.Width = 125;
            // 
            // dongia
            // 
            this.dongia.DataPropertyName = "gianhap";
            this.dongia.HeaderText = "Đơn giá";
            this.dongia.MinimumWidth = 6;
            this.dongia.Name = "dongia";
            this.dongia.Width = 125;
            // 
            // thanhtien
            // 
            this.thanhtien.DataPropertyName = "thanhtien";
            this.thanhtien.HeaderText = "Thanh tien";
            this.thanhtien.MinimumWidth = 6;
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.Width = 125;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lst_dshh);
            this.groupBox3.Controls.Add(this.cbo_nhomhang);
            this.groupBox3.Location = new System.Drawing.Point(1121, 103);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox3.Size = new System.Drawing.Size(443, 548);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách hàng hóa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(8, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 50;
            this.label1.Text = "Chọn nhóm hàng";
            // 
            // lst_dshh
            // 
            this.lst_dshh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lst_dshh.FormattingEnabled = true;
            this.lst_dshh.ItemHeight = 20;
            this.lst_dshh.Location = new System.Drawing.Point(35, 88);
            this.lst_dshh.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lst_dshh.Name = "lst_dshh";
            this.lst_dshh.Size = new System.Drawing.Size(342, 444);
            this.lst_dshh.TabIndex = 0;
            this.lst_dshh.SelectedValueChanged += new System.EventHandler(this.lst_dshh_SelectedValueChanged);
            // 
            // cbo_nhomhang
            // 
            this.cbo_nhomhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_nhomhang.FormattingEnabled = true;
            this.cbo_nhomhang.Location = new System.Drawing.Point(168, 44);
            this.cbo_nhomhang.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbo_nhomhang.Name = "cbo_nhomhang";
            this.cbo_nhomhang.Size = new System.Drawing.Size(180, 28);
            this.cbo_nhomhang.TabIndex = 49;
            this.cbo_nhomhang.SelectedIndexChanged += new System.EventHandler(this.cbo_nhomhang_SelectedIndexChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(1428, 686);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(103, 50);
            this.btnThoat.TabIndex = 43;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuyphieu
            // 
            this.btnHuyphieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyphieu.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyphieu.Image")));
            this.btnHuyphieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyphieu.Location = new System.Drawing.Point(1289, 686);
            this.btnHuyphieu.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuyphieu.Name = "btnHuyphieu";
            this.btnHuyphieu.Size = new System.Drawing.Size(105, 50);
            this.btnHuyphieu.TabIndex = 44;
            this.btnHuyphieu.Text = "Hủy Phiếu";
            this.btnHuyphieu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuyphieu.UseVisualStyleBackColor = true;
            // 
            // btnLuuphieu
            // 
            this.btnLuuphieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuphieu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuphieu.Image")));
            this.btnLuuphieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuphieu.Location = new System.Drawing.Point(1128, 686);
            this.btnLuuphieu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuuphieu.Name = "btnLuuphieu";
            this.btnLuuphieu.Size = new System.Drawing.Size(105, 50);
            this.btnLuuphieu.TabIndex = 45;
            this.btnLuuphieu.Text = "Lưu Phiếu";
            this.btnLuuphieu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuphieu.UseVisualStyleBackColor = true;
            this.btnLuuphieu.Click += new System.EventHandler(this.btnLuuphieu_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Lavender;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(522, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(477, 76);
            this.label12.TabIndex = 55;
            this.label12.Text = "QUẢN LÝ NHẬP HÀNG\r\n ------------------------";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1823, 905);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuyphieu);
            this.Controls.Add(this.btnLuuphieu);
            this.Controls.Add(this.grb1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhapHang";
            this.Text = "Nhap Hang";
            this.Load += new System.EventHandler(this.frmNhapHang_Load);
            this.grb1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongtin)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.Button btnTraHang;
        private System.Windows.Forms.Button btnNhaCungCap;
        private System.Windows.Forms.Button btnHangHoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuyphieu;
        private System.Windows.Forms.Button btnLuuphieu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_thongtin;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lst_dshh;
        private System.Windows.Forms.ComboBox cbo_nhomhang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewButtonColumn dgv_btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhh;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
    }
}
namespace Sieu_Thi_Mini_C_
{
    partial class frmHangHoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHangHoa));
            this.txtDvt = new System.Windows.Forms.TextBox();
            this.txtGiaban = new System.Windows.Forms.TextBox();
            this.txtGianhap = new System.Windows.Forms.TextBox();
            this.txtXuatxu = new System.Windows.Forms.TextBox();
            this.txtTenhh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMahh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVAT = new System.Windows.Forms.TextBox();
            this.txt_mavach = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.NhaCC = new System.Windows.Forms.Label();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnT = new System.Windows.Forms.Button();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.btnTrahang = new System.Windows.Forms.Button();
            this.btnNhaCungCap = new System.Windows.Forms.Button();
            this.btnHangHoa = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgv_thongtin = new System.Windows.Forms.DataGridView();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenhh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nhomhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gianhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donvitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhacungcap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mavach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dinhmuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbo_nhomhang = new System.Windows.Forms.ComboBox();
            this.cbo_nhacc = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThongke = new System.Windows.Forms.Button();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.txt_hsd = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.date_nsx = new System.Windows.Forms.DateTimePicker();
            this.date_hsd = new System.Windows.Forms.DateTimePicker();
            this.grb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongtin)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDvt
            // 
            this.txtDvt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDvt.Location = new System.Drawing.Point(817, 334);
            this.txtDvt.Margin = new System.Windows.Forms.Padding(4);
            this.txtDvt.Name = "txtDvt";
            this.txtDvt.Size = new System.Drawing.Size(222, 26);
            this.txtDvt.TabIndex = 22;
            // 
            // txtGiaban
            // 
            this.txtGiaban.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaban.Location = new System.Drawing.Point(817, 255);
            this.txtGiaban.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiaban.Name = "txtGiaban";
            this.txtGiaban.Size = new System.Drawing.Size(222, 26);
            this.txtGiaban.TabIndex = 23;
            this.txtGiaban.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaban_KeyPress);
            // 
            // txtGianhap
            // 
            this.txtGianhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGianhap.Location = new System.Drawing.Point(817, 177);
            this.txtGianhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtGianhap.Name = "txtGianhap";
            this.txtGianhap.Size = new System.Drawing.Size(222, 26);
            this.txtGianhap.TabIndex = 24;
            this.txtGianhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGianhap_KeyPress);
            // 
            // txtXuatxu
            // 
            this.txtXuatxu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXuatxu.Location = new System.Drawing.Point(434, 402);
            this.txtXuatxu.Margin = new System.Windows.Forms.Padding(4);
            this.txtXuatxu.Name = "txtXuatxu";
            this.txtXuatxu.Size = new System.Drawing.Size(198, 26);
            this.txtXuatxu.TabIndex = 25;
            // 
            // txtTenhh
            // 
            this.txtTenhh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenhh.Location = new System.Drawing.Point(434, 258);
            this.txtTenhh.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenhh.Name = "txtTenhh";
            this.txtTenhh.Size = new System.Drawing.Size(198, 26);
            this.txtTenhh.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(697, 337);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Đơn vị tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(697, 255);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Giá bán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(697, 179);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Giá nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(333, 405);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Xuất xứ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(332, 333);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nhóm hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(329, 261);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tên HH";
            // 
            // txtMahh
            // 
            this.txtMahh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMahh.Location = new System.Drawing.Point(434, 181);
            this.txtMahh.Margin = new System.Windows.Forms.Padding(4);
            this.txtMahh.Multiline = true;
            this.txtMahh.Name = "txtMahh";
            this.txtMahh.Size = new System.Drawing.Size(198, 22);
            this.txtMahh.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 182);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mã HH";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1103, 400);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "VAT";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtVAT
            // 
            this.txtVAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVAT.Location = new System.Drawing.Point(1230, 394);
            this.txtVAT.Margin = new System.Windows.Forms.Padding(4);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.Size = new System.Drawing.Size(173, 26);
            this.txtVAT.TabIndex = 30;
            this.txtVAT.TextChanged += new System.EventHandler(this.textVat_TextChanged);
            this.txtVAT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVAT_KeyPress);
            // 
            // txt_mavach
            // 
            this.txt_mavach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mavach.Location = new System.Drawing.Point(1230, 173);
            this.txt_mavach.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mavach.Name = "txt_mavach";
            this.txt_mavach.Size = new System.Drawing.Size(173, 26);
            this.txt_mavach.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1106, 179);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Mã vạch";
            // 
            // NhaCC
            // 
            this.NhaCC.AutoSize = true;
            this.NhaCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhaCC.Location = new System.Drawing.Point(697, 405);
            this.NhaCC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NhaCC.Name = "NhaCC";
            this.NhaCC.Size = new System.Drawing.Size(112, 20);
            this.NhaCC.TabIndex = 32;
            this.NhaCC.Text = "Nhà cung cấp";
            // 
            // txtSoluong
            // 
            this.txtSoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoluong.Location = new System.Drawing.Point(1230, 229);
            this.txtSoluong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(173, 26);
            this.txtSoluong.TabIndex = 40;
            this.txtSoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoluong_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1106, 232);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 20);
            this.label11.TabIndex = 38;
            this.label11.Text = "Số lượng";
            // 
            // grb1
            // 
            this.grb1.BackColor = System.Drawing.Color.Lavender;
            this.grb1.Controls.Add(this.pictureBox3);
            this.grb1.Controls.Add(this.btnT);
            this.grb1.Controls.Add(this.btnNhapHang);
            this.grb1.Controls.Add(this.btnTrahang);
            this.grb1.Controls.Add(this.btnNhaCungCap);
            this.grb1.Controls.Add(this.btnHangHoa);
            this.grb1.Location = new System.Drawing.Point(13, 27);
            this.grb1.Margin = new System.Windows.Forms.Padding(4);
            this.grb1.Name = "grb1";
            this.grb1.Padding = new System.Windows.Forms.Padding(4);
            this.grb1.Size = new System.Drawing.Size(297, 737);
            this.grb1.TabIndex = 41;
            this.grb1.TabStop = false;
            this.grb1.Text = "Quản lý kho hàng";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Sieu_Thi_Mini_C_.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(17, 24);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(266, 78);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 52;
            this.pictureBox3.TabStop = false;
            // 
            // btnT
            // 
            this.btnT.Location = new System.Drawing.Point(40, 597);
            this.btnT.Margin = new System.Windows.Forms.Padding(4);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(198, 61);
            this.btnT.TabIndex = 47;
            this.btnT.Text = "Thoát";
            this.btnT.UseVisualStyleBackColor = true;
            this.btnT.Click += new System.EventHandler(this.btnT_Click);
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.Location = new System.Drawing.Point(40, 367);
            this.btnNhapHang.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(198, 61);
            this.btnNhapHang.TabIndex = 45;
            this.btnNhapHang.Text = "Nhập Hàng";
            this.btnNhapHang.UseVisualStyleBackColor = true;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // btnTrahang
            // 
            this.btnTrahang.Location = new System.Drawing.Point(40, 487);
            this.btnTrahang.Margin = new System.Windows.Forms.Padding(4);
            this.btnTrahang.Name = "btnTrahang";
            this.btnTrahang.Size = new System.Drawing.Size(198, 61);
            this.btnTrahang.TabIndex = 44;
            this.btnTrahang.Text = "Trả hàng";
            this.btnTrahang.UseVisualStyleBackColor = true;
            this.btnTrahang.Click += new System.EventHandler(this.btnLoaiHang_Click);
            // 
            // btnNhaCungCap
            // 
            this.btnNhaCungCap.Location = new System.Drawing.Point(40, 240);
            this.btnNhaCungCap.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhaCungCap.Name = "btnNhaCungCap";
            this.btnNhaCungCap.Size = new System.Drawing.Size(198, 61);
            this.btnNhaCungCap.TabIndex = 43;
            this.btnNhaCungCap.Text = "Nhà Cung Cấp";
            this.btnNhaCungCap.UseVisualStyleBackColor = true;
            this.btnNhaCungCap.Click += new System.EventHandler(this.btnNhaCungCap_Click);
            // 
            // btnHangHoa
            // 
            this.btnHangHoa.Location = new System.Drawing.Point(40, 115);
            this.btnHangHoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnHangHoa.Name = "btnHangHoa";
            this.btnHangHoa.Size = new System.Drawing.Size(198, 61);
            this.btnHangHoa.TabIndex = 42;
            this.btnHangHoa.Text = "Hàng Hóa";
            this.btnHangHoa.UseVisualStyleBackColor = true;
            this.btnHangHoa.Click += new System.EventHandler(this.btnHangHoa_Click);
            // 
            // dgv_thongtin
            // 
            this.dgv_thongtin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thongtin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNCC,
            this.Tenhh,
            this.Nhomhang,
            this.SDT,
            this.gianhap,
            this.giaban,
            this.donvitinh,
            this.nhacungcap,
            this.mavach,
            this.dinhmuc,
            this.vat,
            this.NSX,
            this.HSD});
            this.dgv_thongtin.Location = new System.Drawing.Point(333, 447);
            this.dgv_thongtin.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_thongtin.Name = "dgv_thongtin";
            this.dgv_thongtin.RowHeadersWidth = 51;
            this.dgv_thongtin.RowTemplate.Height = 24;
            this.dgv_thongtin.Size = new System.Drawing.Size(1079, 332);
            this.dgv_thongtin.TabIndex = 42;
            this.dgv_thongtin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_thongtin_CellClick);
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "mahh";
            this.MaNCC.HeaderText = "Mã HH";
            this.MaNCC.MinimumWidth = 6;
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.Width = 125;
            // 
            // Tenhh
            // 
            this.Tenhh.DataPropertyName = "tenhang";
            this.Tenhh.HeaderText = "Tên HH";
            this.Tenhh.MinimumWidth = 6;
            this.Tenhh.Name = "Tenhh";
            this.Tenhh.Width = 125;
            // 
            // Nhomhang
            // 
            this.Nhomhang.DataPropertyName = "nhomhang";
            this.Nhomhang.HeaderText = "Nhóm hàng";
            this.Nhomhang.MinimumWidth = 6;
            this.Nhomhang.Name = "Nhomhang";
            this.Nhomhang.Width = 125;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "xuatxu";
            this.SDT.HeaderText = "Xuất xứ";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.Width = 125;
            // 
            // gianhap
            // 
            this.gianhap.DataPropertyName = "gianhap";
            this.gianhap.HeaderText = "Giá nhập";
            this.gianhap.MinimumWidth = 6;
            this.gianhap.Name = "gianhap";
            this.gianhap.Width = 125;
            // 
            // giaban
            // 
            this.giaban.DataPropertyName = "giaban";
            this.giaban.HeaderText = "Giá bán";
            this.giaban.MinimumWidth = 6;
            this.giaban.Name = "giaban";
            this.giaban.Width = 125;
            // 
            // donvitinh
            // 
            this.donvitinh.DataPropertyName = "donvitinh";
            this.donvitinh.HeaderText = "Đơn vị tính";
            this.donvitinh.MinimumWidth = 6;
            this.donvitinh.Name = "donvitinh";
            this.donvitinh.Width = 125;
            // 
            // nhacungcap
            // 
            this.nhacungcap.DataPropertyName = "nhacungcap";
            this.nhacungcap.HeaderText = "Nhà cung cấp";
            this.nhacungcap.MinimumWidth = 6;
            this.nhacungcap.Name = "nhacungcap";
            this.nhacungcap.Width = 125;
            // 
            // mavach
            // 
            this.mavach.DataPropertyName = "mavach";
            this.mavach.HeaderText = "Mã vạch";
            this.mavach.MinimumWidth = 6;
            this.mavach.Name = "mavach";
            this.mavach.Width = 125;
            // 
            // dinhmuc
            // 
            this.dinhmuc.DataPropertyName = "soluong";
            this.dinhmuc.HeaderText = "Số lượng";
            this.dinhmuc.MinimumWidth = 6;
            this.dinhmuc.Name = "dinhmuc";
            this.dinhmuc.Width = 125;
            // 
            // vat
            // 
            this.vat.DataPropertyName = "vat";
            this.vat.HeaderText = "VAT";
            this.vat.MinimumWidth = 6;
            this.vat.Name = "vat";
            this.vat.Width = 125;
            // 
            // NSX
            // 
            this.NSX.DataPropertyName = "NSX";
            this.NSX.HeaderText = "NSX";
            this.NSX.MinimumWidth = 6;
            this.NSX.Name = "NSX";
            this.NSX.Width = 125;
            // 
            // HSD
            // 
            this.HSD.DataPropertyName = "HSD";
            this.HSD.HeaderText = "HSD";
            this.HSD.MinimumWidth = 6;
            this.HSD.Name = "HSD";
            this.HSD.Width = 125;
            // 
            // cbo_nhomhang
            // 
            this.cbo_nhomhang.FormattingEnabled = true;
            this.cbo_nhomhang.Items.AddRange(new object[] {
            "Thực phẩm",
            "Văn phòng phẩm",
            "Mặt hàng tiêu dùng"});
            this.cbo_nhomhang.Location = new System.Drawing.Point(435, 336);
            this.cbo_nhomhang.Name = "cbo_nhomhang";
            this.cbo_nhomhang.Size = new System.Drawing.Size(198, 26);
            this.cbo_nhomhang.TabIndex = 43;
            // 
            // cbo_nhacc
            // 
            this.cbo_nhacc.FormattingEnabled = true;
            this.cbo_nhacc.Items.AddRange(new object[] {
            "Thực phẩm",
            "Văn phòng phẩm",
            "Mặt hàng tiêu dùng"});
            this.cbo_nhacc.Location = new System.Drawing.Point(817, 402);
            this.cbo_nhacc.Name = "cbo_nhacc";
            this.cbo_nhacc.Size = new System.Drawing.Size(222, 26);
            this.cbo_nhacc.TabIndex = 43;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Lavender;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(588, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(477, 76);
            this.label12.TabIndex = 54;
            this.label12.Text = "QUẢN LÝ KHO HÀNG\r\n ------------------------";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(1264, 107);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(113, 50);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThongke
            // 
            this.btnThongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongke.Image = ((System.Drawing.Image)(resources.GetObject("btnThongke.Image")));
            this.btnThongke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongke.Location = new System.Drawing.Point(1092, 107);
            this.btnThongke.Margin = new System.Windows.Forms.Padding(4);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(130, 50);
            this.btnThongke.TabIndex = 10;
            this.btnThongke.Text = "Thống Kê";
            this.btnThongke.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThongke.UseVisualStyleBackColor = true;
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // btnLammoi
            // 
            this.btnLammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLammoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLammoi.Image")));
            this.btnLammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLammoi.Location = new System.Drawing.Point(781, 107);
            this.btnLammoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(109, 50);
            this.btnLammoi.TabIndex = 11;
            this.btnLammoi.Text = "Làm Mới";
            this.btnLammoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(630, 107);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(113, 50);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(483, 107);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(113, 50);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(333, 107);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(113, 50);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(946, 107);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(119, 50);
            this.btn_timkiem.TabIndex = 56;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // txt_hsd
            // 
            this.txt_hsd.AutoSize = true;
            this.txt_hsd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hsd.Location = new System.Drawing.Point(1103, 343);
            this.txt_hsd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_hsd.Name = "txt_hsd";
            this.txt_hsd.Size = new System.Drawing.Size(46, 20);
            this.txt_hsd.TabIndex = 29;
            this.txt_hsd.Text = "HSD";
            this.txt_hsd.Click += new System.EventHandler(this.label8_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1103, 287);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 20);
            this.label13.TabIndex = 29;
            this.label13.Text = "NSX";
            this.label13.Click += new System.EventHandler(this.label8_Click);
            // 
            // date_nsx
            // 
            this.date_nsx.CustomFormat = "dd-MM-yyyy";
            this.date_nsx.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_nsx.Location = new System.Drawing.Point(1230, 283);
            this.date_nsx.Name = "date_nsx";
            this.date_nsx.Size = new System.Drawing.Size(173, 24);
            this.date_nsx.TabIndex = 57;
            // 
            // date_hsd
            // 
            this.date_hsd.CustomFormat = "dd-MM-yyyy";
            this.date_hsd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_hsd.Location = new System.Drawing.Point(1230, 336);
            this.date_hsd.Name = "date_hsd";
            this.date_hsd.Size = new System.Drawing.Size(173, 24);
            this.date_hsd.TabIndex = 57;
            // 
            // frmHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1732, 892);
            this.Controls.Add(this.date_hsd);
            this.Controls.Add(this.date_nsx);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbo_nhacc);
            this.Controls.Add(this.cbo_nhomhang);
            this.Controls.Add(this.dgv_thongtin);
            this.Controls.Add(this.grb1);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_mavach);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.NhaCC);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_hsd);
            this.Controls.Add(this.txtVAT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDvt);
            this.Controls.Add(this.txtGiaban);
            this.Controls.Add(this.txtGianhap);
            this.Controls.Add(this.txtXuatxu);
            this.Controls.Add(this.txtTenhh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMahh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThongke);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHangHoa";
            this.Text = "Hang Hoa";
            this.Load += new System.EventHandler(this.frmHangHoa_Load);
            this.grb1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongtin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThongke;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtDvt;
        private System.Windows.Forms.TextBox txtGiaban;
        private System.Windows.Forms.TextBox txtGianhap;
        private System.Windows.Forms.TextBox txtXuatxu;
        private System.Windows.Forms.TextBox txtTenhh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMahh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtVAT;
        private System.Windows.Forms.TextBox txt_mavach;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label NhaCC;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox grb1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.Button btnTrahang;
        private System.Windows.Forms.Button btnNhaCungCap;
        private System.Windows.Forms.Button btnHangHoa;
        private System.Windows.Forms.DataGridView dgv_thongtin;
        private System.Windows.Forms.ComboBox cbo_nhomhang;
        private System.Windows.Forms.ComboBox cbo_nhacc;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Label txt_hsd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker date_nsx;
        private System.Windows.Forms.DateTimePicker date_hsd;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenhh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nhomhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn gianhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaban;
        private System.Windows.Forms.DataGridViewTextBoxColumn donvitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhacungcap;
        private System.Windows.Forms.DataGridViewTextBoxColumn mavach;
        private System.Windows.Forms.DataGridViewTextBoxColumn dinhmuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn vat;
        private System.Windows.Forms.DataGridViewTextBoxColumn NSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn HSD;
    }
}
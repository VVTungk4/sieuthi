namespace Sieu_Thi_Mini_C_
{
    partial class frmThongke
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
            this.dgv_thongtin = new System.Windows.Forms.DataGridView();
            this.mahh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenhh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doanhthumathang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lst_danhsach = new System.Windows.Forms.ListBox();
            this.txt_banit = new System.Windows.Forms.TextBox();
            this.txt_banchay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongtin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_thongtin
            // 
            this.dgv_thongtin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thongtin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahh,
            this.tenhh,
            this.soluongban,
            this.doanhthumathang});
            this.dgv_thongtin.Location = new System.Drawing.Point(39, 154);
            this.dgv_thongtin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgv_thongtin.Name = "dgv_thongtin";
            this.dgv_thongtin.RowHeadersWidth = 51;
            this.dgv_thongtin.RowTemplate.Height = 24;
            this.dgv_thongtin.Size = new System.Drawing.Size(638, 550);
            this.dgv_thongtin.TabIndex = 0;
            // 
            // mahh
            // 
            this.mahh.DataPropertyName = "mahh";
            this.mahh.HeaderText = "Mã HH";
            this.mahh.MinimumWidth = 6;
            this.mahh.Name = "mahh";
            this.mahh.Width = 125;
            // 
            // tenhh
            // 
            this.tenhh.DataPropertyName = "tenhh";
            this.tenhh.HeaderText = "Tên HH";
            this.tenhh.MinimumWidth = 6;
            this.tenhh.Name = "tenhh";
            this.tenhh.Width = 125;
            // 
            // soluongban
            // 
            this.soluongban.DataPropertyName = "TONGSOLUONG";
            this.soluongban.HeaderText = "Sl bán";
            this.soluongban.MinimumWidth = 6;
            this.soluongban.Name = "soluongban";
            this.soluongban.Width = 125;
            // 
            // doanhthumathang
            // 
            this.doanhthumathang.DataPropertyName = "TONGTHANHTIEN";
            this.doanhthumathang.HeaderText = "Doanh thu mặt hàng";
            this.doanhthumathang.MinimumWidth = 6;
            this.doanhthumathang.Name = "doanhthumathang";
            this.doanhthumathang.Width = 150;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sieu_Thi_Mini_C_.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(39, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Lavender;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(411, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(803, 90);
            this.label12.TabIndex = 56;
            this.label12.Text = "THỐNG KÊ HÀNG HÓA BÁN RA TRONG NGÀY\r\n ------------------------";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(30, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 19);
            this.label1.TabIndex = 57;
            this.label1.Text = "Mặt hàng bán chạy nhất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(30, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 19);
            this.label2.TabIndex = 57;
            this.label2.Text = "Mặt hàng sắp hết (Tồn kho < 50) ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(30, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 19);
            this.label3.TabIndex = 57;
            this.label3.Text = "Mặt hàng bán ít nhất";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lst_danhsach);
            this.groupBox1.Controls.Add(this.txt_banit);
            this.groupBox1.Controls.Add(this.txt_banchay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(715, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 550);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê cơ bản";
            // 
            // lst_danhsach
            // 
            this.lst_danhsach.FormattingEnabled = true;
            this.lst_danhsach.ItemHeight = 19;
            this.lst_danhsach.Location = new System.Drawing.Point(34, 228);
            this.lst_danhsach.Name = "lst_danhsach";
            this.lst_danhsach.Size = new System.Drawing.Size(435, 289);
            this.lst_danhsach.TabIndex = 59;
            // 
            // txt_banit
            // 
            this.txt_banit.Location = new System.Drawing.Point(229, 132);
            this.txt_banit.Name = "txt_banit";
            this.txt_banit.Size = new System.Drawing.Size(240, 26);
            this.txt_banit.TabIndex = 58;
            // 
            // txt_banchay
            // 
            this.txt_banchay.Location = new System.Drawing.Point(229, 65);
            this.txt_banchay.Name = "txt_banchay";
            this.txt_banchay.Size = new System.Drawing.Size(240, 26);
            this.txt_banchay.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Lavender;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(78, 725);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(547, 47);
            this.label4.TabIndex = 59;
            this.label4.Text = "HÀNG HÓA BÁN RA TRONG NGÀY";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnT
            // 
            this.btnT.Location = new System.Drawing.Point(885, 725);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(176, 54);
            this.btnT.TabIndex = 60;
            this.btnT.Text = "Thoát";
            this.btnT.UseVisualStyleBackColor = true;
            this.btnT.Click += new System.EventHandler(this.btnT_Click);
            // 
            // frmThongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 798);
            this.Controls.Add(this.btnT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgv_thongtin);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "frmThongke";
            this.Load += new System.EventHandler(this.frmThongke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongtin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_thongtin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lst_danhsach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_banit;
        private System.Windows.Forms.TextBox txt_banchay;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhh;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongban;
        private System.Windows.Forms.DataGridViewTextBoxColumn doanhthumathang;
    }
}
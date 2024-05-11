namespace Sieu_Thi_Mini_C_
{
    partial class frm_Doanhthu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartDoanhthu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhthu)).BeginInit();
            this.SuspendLayout();
            // 
            // chartDoanhthu
            // 
            this.chartDoanhthu.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.WideDownwardDiagonal;
            this.chartDoanhthu.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Bottom;
            chartArea1.Name = "ChartArea1";
            this.chartDoanhthu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDoanhthu.Legends.Add(legend1);
            this.chartDoanhthu.Location = new System.Drawing.Point(61, 61);
            this.chartDoanhthu.Name = "chartDoanhthu";
            this.chartDoanhthu.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BorderColor = System.Drawing.Color.Lavender;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            series1.IsValueShownAsLabel = true;
            series1.LabelBorderColor = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Doanh thu";
            this.chartDoanhthu.Series.Add(series1);
            this.chartDoanhthu.Size = new System.Drawing.Size(1294, 639);
            this.chartDoanhthu.TabIndex = 2;
            this.chartDoanhthu.Text = "chart1";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(1122, 727);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 3;
            this.guna2Button1.Text = "Cập nhật";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Lavender;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(293, 713);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(708, 76);
            this.label12.TabIndex = 58;
            this.label12.Text = "BIỂU ĐỒ THỐNG KÊ DOANH THU\r\n ------------------------";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_Doanhthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 798);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.chartDoanhthu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_Doanhthu";
            this.Text = "frm_Doanhthu";
            this.Load += new System.EventHandler(this.frm_Doanhthu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhthu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhthu;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label12;
    }
}
namespace DBMS_FINAL_PROJECT.QL_TAICHINH
{
    partial class FORM_QL_TAI_CHINH
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Thong_Ke = new System.Windows.Forms.Button();
            this.dtp_Ngay_Cuoi = new System.Windows.Forms.DateTimePicker();
            this.dtp_Ngay_Dau = new System.Windows.Forms.DateTimePicker();
            this.chart_Thu_Chi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Thu_Chi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Thu_Chi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Thu_Chi)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(720, 473);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Đến ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 473);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Từ ngày:";
            // 
            // btn_Thong_Ke
            // 
            this.btn_Thong_Ke.BackColor = System.Drawing.Color.Lime;
            this.btn_Thong_Ke.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thong_Ke.ForeColor = System.Drawing.Color.Blue;
            this.btn_Thong_Ke.Location = new System.Drawing.Point(467, 455);
            this.btn_Thong_Ke.Name = "btn_Thong_Ke";
            this.btn_Thong_Ke.Size = new System.Drawing.Size(185, 52);
            this.btn_Thong_Ke.TabIndex = 19;
            this.btn_Thong_Ke.Text = "Thống kê";
            this.btn_Thong_Ke.UseVisualStyleBackColor = false;
            // 
            // dtp_Ngay_Cuoi
            // 
            this.dtp_Ngay_Cuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Ngay_Cuoi.Location = new System.Drawing.Point(805, 469);
            this.dtp_Ngay_Cuoi.Name = "dtp_Ngay_Cuoi";
            this.dtp_Ngay_Cuoi.Size = new System.Drawing.Size(291, 27);
            this.dtp_Ngay_Cuoi.TabIndex = 18;
            // 
            // dtp_Ngay_Dau
            // 
            this.dtp_Ngay_Dau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Ngay_Dau.Location = new System.Drawing.Point(98, 468);
            this.dtp_Ngay_Dau.Name = "dtp_Ngay_Dau";
            this.dtp_Ngay_Dau.Size = new System.Drawing.Size(294, 27);
            this.dtp_Ngay_Dau.TabIndex = 17;
            // 
            // chart_Thu_Chi
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_Thu_Chi.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_Thu_Chi.Legends.Add(legend1);
            this.chart_Thu_Chi.Location = new System.Drawing.Point(6, 17);
            this.chart_Thu_Chi.Name = "chart_Thu_Chi";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_Thu_Chi.Series.Add(series1);
            this.chart_Thu_Chi.Size = new System.Drawing.Size(556, 350);
            this.chart_Thu_Chi.TabIndex = 16;
            this.chart_Thu_Chi.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(763, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Bảng thông kê thu chi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(114, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Biểu đồ thống kê thu chi";
            // 
            // dgv_Thu_Chi
            // 
            this.dgv_Thu_Chi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Thu_Chi.Location = new System.Drawing.Point(568, 17);
            this.dgv_Thu_Chi.Name = "dgv_Thu_Chi";
            this.dgv_Thu_Chi.RowHeadersWidth = 51;
            this.dgv_Thu_Chi.RowTemplate.Height = 24;
            this.dgv_Thu_Chi.Size = new System.Drawing.Size(568, 350);
            this.dgv_Thu_Chi.TabIndex = 13;
            // 
            // FORM_QL_TAI_CHINH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 524);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Thong_Ke);
            this.Controls.Add(this.dtp_Ngay_Cuoi);
            this.Controls.Add(this.dtp_Ngay_Dau);
            this.Controls.Add(this.chart_Thu_Chi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Thu_Chi);
            this.Name = "FORM_QL_TAI_CHINH";
            this.Text = "FORM_QL_TAI_CHINH";
            ((System.ComponentModel.ISupportInitialize)(this.chart_Thu_Chi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Thu_Chi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Thong_Ke;
        private System.Windows.Forms.DateTimePicker dtp_Ngay_Cuoi;
        private System.Windows.Forms.DateTimePicker dtp_Ngay_Dau;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Thu_Chi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Thu_Chi;
    }
}
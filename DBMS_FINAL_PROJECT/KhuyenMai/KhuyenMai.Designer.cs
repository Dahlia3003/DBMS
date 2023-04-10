namespace DBMS_FINAL_PROJECT.KhuyenMai
{
    partial class KhuyenMai
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
            this.panelStatus = new System.Windows.Forms.Panel();
            this.radioHD = new System.Windows.Forms.RadioButton();
            this.radioKHD = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbNgayketthuc = new System.Windows.Forms.Label();
            this.DTNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lbNgayBatDau = new System.Windows.Forms.Label();
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.lbGiaTri = new System.Windows.Forms.Label();
            this.txbTen = new System.Windows.Forms.TextBox();
            this.lbTen = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.BtnRequest = new System.Windows.Forms.Button();
            this.lbDSKM = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelStatus
            // 
            this.panelStatus.Controls.Add(this.radioHD);
            this.panelStatus.Controls.Add(this.radioKHD);
            this.panelStatus.Location = new System.Drawing.Point(-84, 266);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(359, 113);
            this.panelStatus.TabIndex = 112;
            // 
            // radioHD
            // 
            this.radioHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioHD.Location = new System.Drawing.Point(16, 10);
            this.radioHD.Name = "radioHD";
            this.radioHD.Size = new System.Drawing.Size(229, 40);
            this.radioHD.TabIndex = 15;
            this.radioHD.TabStop = true;
            this.radioHD.Text = "Hoạt động";
            this.radioHD.UseVisualStyleBackColor = true;
            // 
            // radioKHD
            // 
            this.radioKHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioKHD.Location = new System.Drawing.Point(16, 57);
            this.radioKHD.Name = "radioKHD";
            this.radioKHD.Size = new System.Drawing.Size(229, 40);
            this.radioKHD.TabIndex = 16;
            this.radioKHD.TabStop = true;
            this.radioKHD.Text = "Không hoạt động";
            this.radioKHD.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(90, 162);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(185, 30);
            this.dateTimePicker1.TabIndex = 111;
            // 
            // lbNgayketthuc
            // 
            this.lbNgayketthuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayketthuc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbNgayketthuc.Location = new System.Drawing.Point(-88, 162);
            this.lbNgayketthuc.Name = "lbNgayketthuc";
            this.lbNgayketthuc.Size = new System.Drawing.Size(171, 30);
            this.lbNgayketthuc.TabIndex = 110;
            this.lbNgayketthuc.Text = "Ngày kết thúc";
            // 
            // DTNgaySinh
            // 
            this.DTNgaySinh.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTNgaySinh.Location = new System.Drawing.Point(90, 121);
            this.DTNgaySinh.Name = "DTNgaySinh";
            this.DTNgaySinh.Size = new System.Drawing.Size(185, 30);
            this.DTNgaySinh.TabIndex = 109;
            // 
            // lbNgayBatDau
            // 
            this.lbNgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayBatDau.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbNgayBatDau.Location = new System.Drawing.Point(-88, 121);
            this.lbNgayBatDau.Name = "lbNgayBatDau";
            this.lbNgayBatDau.Size = new System.Drawing.Size(171, 30);
            this.lbNgayBatDau.TabIndex = 108;
            this.lbNgayBatDau.Text = "Ngày bắt đầu";
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDiaChi.Location = new System.Drawing.Point(89, 209);
            this.txbDiaChi.Multiline = true;
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(186, 33);
            this.txbDiaChi.TabIndex = 107;
            // 
            // lbGiaTri
            // 
            this.lbGiaTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiaTri.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbGiaTri.Location = new System.Drawing.Point(-88, 209);
            this.lbGiaTri.Name = "lbGiaTri";
            this.lbGiaTri.Size = new System.Drawing.Size(171, 30);
            this.lbGiaTri.TabIndex = 106;
            this.lbGiaTri.Text = "Giá trị khuyến mãi";
            // 
            // txbTen
            // 
            this.txbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTen.Location = new System.Drawing.Point(89, 74);
            this.txbTen.Multiline = true;
            this.txbTen.Name = "txbTen";
            this.txbTen.Size = new System.Drawing.Size(186, 33);
            this.txbTen.TabIndex = 105;
            // 
            // lbTen
            // 
            this.lbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTen.Location = new System.Drawing.Point(-88, 74);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(171, 30);
            this.lbTen.TabIndex = 104;
            this.lbTen.Text = "Tên khuyến mãi";
            // 
            // txbID
            // 
            this.txbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID.Location = new System.Drawing.Point(89, 27);
            this.txbID.Multiline = true;
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(186, 33);
            this.txbID.TabIndex = 103;
            // 
            // lbID
            // 
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbID.Location = new System.Drawing.Point(-88, 27);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(171, 30);
            this.lbID.TabIndex = 102;
            this.lbID.Text = "ID";
            // 
            // BtnRequest
            // 
            this.BtnRequest.BackColor = System.Drawing.Color.Orange;
            this.BtnRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRequest.ForeColor = System.Drawing.Color.White;
            this.BtnRequest.Location = new System.Drawing.Point(528, 373);
            this.BtnRequest.Name = "BtnRequest";
            this.BtnRequest.Size = new System.Drawing.Size(146, 50);
            this.BtnRequest.TabIndex = 101;
            this.BtnRequest.Text = "Refresh";
            this.BtnRequest.UseVisualStyleBackColor = false;
            // 
            // lbDSKM
            // 
            this.lbDSKM.BackColor = System.Drawing.Color.Maroon;
            this.lbDSKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDSKM.ForeColor = System.Drawing.Color.Transparent;
            this.lbDSKM.Location = new System.Drawing.Point(305, 27);
            this.lbDSKM.Name = "lbDSKM";
            this.lbDSKM.Size = new System.Drawing.Size(584, 30);
            this.lbDSKM.TabIndex = 100;
            this.lbDSKM.Text = "DANH SÁCH KHUYẾN MÃI";
            this.lbDSKM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(305, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(584, 289);
            this.dataGridView1.TabIndex = 99;
            // 
            // KhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(990, 450);
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbNgayketthuc);
            this.Controls.Add(this.DTNgaySinh);
            this.Controls.Add(this.lbNgayBatDau);
            this.Controls.Add(this.txbDiaChi);
            this.Controls.Add(this.lbGiaTri);
            this.Controls.Add(this.txbTen);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.BtnRequest);
            this.Controls.Add(this.lbDSKM);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KhuyenMai";
            this.Text = "KhuyenMai";
            this.panelStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.RadioButton radioHD;
        private System.Windows.Forms.RadioButton radioKHD;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbNgayketthuc;
        private System.Windows.Forms.DateTimePicker DTNgaySinh;
        private System.Windows.Forms.Label lbNgayBatDau;
        private System.Windows.Forms.TextBox txbDiaChi;
        private System.Windows.Forms.Label lbGiaTri;
        private System.Windows.Forms.TextBox txbTen;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Button BtnRequest;
        private System.Windows.Forms.Label lbDSKM;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
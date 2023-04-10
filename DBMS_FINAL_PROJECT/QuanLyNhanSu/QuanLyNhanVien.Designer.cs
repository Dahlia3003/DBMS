namespace DBMS_FINAL_PROJECT.QuanLyNhanSu
{
    partial class QuanLyNhanVien
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
            this.LbFind = new System.Windows.Forms.Label();
            this.txbFind = new System.Windows.Forms.TextBox();
            this.cbxFind = new System.Windows.Forms.ComboBox();
            this.GridViewQLNS = new System.Windows.Forms.DataGridView();
            this.txbLoaiNhanVien = new System.Windows.Forms.TextBox();
            this.lbLoaiNhanVien = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.PnInformation = new System.Windows.Forms.Panel();
            this.txbLuongCoBan = new System.Windows.Forms.TextBox();
            this.lbLuongCoBan = new System.Windows.Forms.Label();
            this.DTNgayLam = new System.Windows.Forms.DateTimePicker();
            this.lbNgayLam = new System.Windows.Forms.Label();
            this.panelGioiTinh = new System.Windows.Forms.Panel();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.DTNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.txbTen = new System.Windows.Forms.TextBox();
            this.lbTen = new System.Windows.Forms.Label();
            this.txbHo = new System.Windows.Forms.TextBox();
            this.lbHo = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.PnQLNS = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewQLNS)).BeginInit();
            this.PnInformation.SuspendLayout();
            this.panelGioiTinh.SuspendLayout();
            this.PnQLNS.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbFind
            // 
            this.LbFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbFind.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbFind.Location = new System.Drawing.Point(538, 28);
            this.LbFind.Name = "LbFind";
            this.LbFind.Size = new System.Drawing.Size(195, 30);
            this.LbFind.TabIndex = 85;
            this.LbFind.Text = "Tìm kiếm theo ";
            this.LbFind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbFind
            // 
            this.txbFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbFind.Location = new System.Drawing.Point(741, 61);
            this.txbFind.Name = "txbFind";
            this.txbFind.Size = new System.Drawing.Size(305, 30);
            this.txbFind.TabIndex = 84;
            // 
            // cbxFind
            // 
            this.cbxFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxFind.FormattingEnabled = true;
            this.cbxFind.Items.AddRange(new object[] {
            "ID",
            "First Name",
            "Last Name",
            "Phone",
            "Falcuty"});
            this.cbxFind.Location = new System.Drawing.Point(538, 61);
            this.cbxFind.Name = "cbxFind";
            this.cbxFind.Size = new System.Drawing.Size(195, 33);
            this.cbxFind.TabIndex = 83;
            // 
            // GridViewQLNS
            // 
            this.GridViewQLNS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewQLNS.Location = new System.Drawing.Point(535, 120);
            this.GridViewQLNS.Name = "GridViewQLNS";
            this.GridViewQLNS.RowHeadersWidth = 51;
            this.GridViewQLNS.RowTemplate.Height = 24;
            this.GridViewQLNS.Size = new System.Drawing.Size(668, 373);
            this.GridViewQLNS.TabIndex = 81;
            // 
            // txbLoaiNhanVien
            // 
            this.txbLoaiNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLoaiNhanVien.Location = new System.Drawing.Point(198, 8);
            this.txbLoaiNhanVien.Multiline = true;
            this.txbLoaiNhanVien.Name = "txbLoaiNhanVien";
            this.txbLoaiNhanVien.Size = new System.Drawing.Size(258, 33);
            this.txbLoaiNhanVien.TabIndex = 87;
            // 
            // lbLoaiNhanVien
            // 
            this.lbLoaiNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiNhanVien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbLoaiNhanVien.Location = new System.Drawing.Point(20, 8);
            this.lbLoaiNhanVien.Name = "lbLoaiNhanVien";
            this.lbLoaiNhanVien.Size = new System.Drawing.Size(171, 30);
            this.lbLoaiNhanVien.TabIndex = 86;
            this.lbLoaiNhanVien.Text = "Loại nhân viên";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(20, 450);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(144, 50);
            this.btnAdd.TabIndex = 85;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.Orange;
            this.BtnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.ForeColor = System.Drawing.Color.White;
            this.BtnEdit.Location = new System.Drawing.Point(188, 450);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(146, 50);
            this.BtnEdit.TabIndex = 84;
            this.BtnEdit.Text = "Sửa";
            this.BtnEdit.UseVisualStyleBackColor = false;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(188, 506);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(146, 50);
            this.btnPrint.TabIndex = 83;
            this.btnPrint.Text = "In";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Red;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(20, 506);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(144, 50);
            this.btnRemove.TabIndex = 82;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // PnInformation
            // 
            this.PnInformation.Controls.Add(this.txbLoaiNhanVien);
            this.PnInformation.Controls.Add(this.lbLoaiNhanVien);
            this.PnInformation.Controls.Add(this.btnAdd);
            this.PnInformation.Controls.Add(this.BtnEdit);
            this.PnInformation.Controls.Add(this.btnPrint);
            this.PnInformation.Controls.Add(this.btnRemove);
            this.PnInformation.Controls.Add(this.txbLuongCoBan);
            this.PnInformation.Controls.Add(this.lbLuongCoBan);
            this.PnInformation.Controls.Add(this.DTNgayLam);
            this.PnInformation.Controls.Add(this.lbNgayLam);
            this.PnInformation.Controls.Add(this.panelGioiTinh);
            this.PnInformation.Controls.Add(this.DTNgaySinh);
            this.PnInformation.Controls.Add(this.lbGioiTinh);
            this.PnInformation.Controls.Add(this.lbNgaySinh);
            this.PnInformation.Controls.Add(this.txbDiaChi);
            this.PnInformation.Controls.Add(this.lbDiaChi);
            this.PnInformation.Controls.Add(this.txbTen);
            this.PnInformation.Controls.Add(this.lbTen);
            this.PnInformation.Controls.Add(this.txbHo);
            this.PnInformation.Controls.Add(this.lbHo);
            this.PnInformation.Controls.Add(this.txbID);
            this.PnInformation.Controls.Add(this.lbID);
            this.PnInformation.Location = new System.Drawing.Point(43, 20);
            this.PnInformation.Name = "PnInformation";
            this.PnInformation.Size = new System.Drawing.Size(486, 578);
            this.PnInformation.TabIndex = 80;
            // 
            // txbLuongCoBan
            // 
            this.txbLuongCoBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLuongCoBan.Location = new System.Drawing.Point(198, 393);
            this.txbLuongCoBan.Multiline = true;
            this.txbLuongCoBan.Name = "txbLuongCoBan";
            this.txbLuongCoBan.Size = new System.Drawing.Size(258, 33);
            this.txbLuongCoBan.TabIndex = 81;
            // 
            // lbLuongCoBan
            // 
            this.lbLuongCoBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLuongCoBan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbLuongCoBan.Location = new System.Drawing.Point(20, 406);
            this.lbLuongCoBan.Name = "lbLuongCoBan";
            this.lbLuongCoBan.Size = new System.Drawing.Size(171, 30);
            this.lbLuongCoBan.TabIndex = 80;
            this.lbLuongCoBan.Text = "Lương cơ bản";
            // 
            // DTNgayLam
            // 
            this.DTNgayLam.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTNgayLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTNgayLam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTNgayLam.Location = new System.Drawing.Point(198, 354);
            this.DTNgayLam.Name = "DTNgayLam";
            this.DTNgayLam.Size = new System.Drawing.Size(258, 30);
            this.DTNgayLam.TabIndex = 79;
            // 
            // lbNgayLam
            // 
            this.lbNgayLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayLam.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbNgayLam.Location = new System.Drawing.Point(20, 354);
            this.lbNgayLam.Name = "lbNgayLam";
            this.lbNgayLam.Size = new System.Drawing.Size(171, 30);
            this.lbNgayLam.TabIndex = 78;
            this.lbNgayLam.Text = "Ngày vào làm";
            // 
            // panelGioiTinh
            // 
            this.panelGioiTinh.Controls.Add(this.radioMale);
            this.panelGioiTinh.Controls.Add(this.radioFemale);
            this.panelGioiTinh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelGioiTinh.Location = new System.Drawing.Point(197, 294);
            this.panelGioiTinh.Name = "panelGioiTinh";
            this.panelGioiTinh.Size = new System.Drawing.Size(258, 36);
            this.panelGioiTinh.TabIndex = 76;
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMale.Location = new System.Drawing.Point(9, 6);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(65, 24);
            this.radioMale.TabIndex = 13;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Nam";
            this.radioMale.UseVisualStyleBackColor = true;
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioFemale.Location = new System.Drawing.Point(146, 6);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(51, 24);
            this.radioFemale.TabIndex = 14;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Nữ";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // DTNgaySinh
            // 
            this.DTNgaySinh.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTNgaySinh.Location = new System.Drawing.Point(198, 243);
            this.DTNgaySinh.Name = "DTNgaySinh";
            this.DTNgaySinh.Size = new System.Drawing.Size(258, 30);
            this.DTNgaySinh.TabIndex = 77;
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioiTinh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbGioiTinh.Location = new System.Drawing.Point(20, 291);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(171, 30);
            this.lbGioiTinh.TabIndex = 75;
            this.lbGioiTinh.Text = "Giới tính";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgaySinh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbNgaySinh.Location = new System.Drawing.Point(20, 243);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(171, 30);
            this.lbNgaySinh.TabIndex = 74;
            this.lbNgaySinh.Text = "Ngày sinh";
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDiaChi.Location = new System.Drawing.Point(197, 196);
            this.txbDiaChi.Multiline = true;
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(258, 33);
            this.txbDiaChi.TabIndex = 73;
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbDiaChi.Location = new System.Drawing.Point(20, 196);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(171, 30);
            this.lbDiaChi.TabIndex = 72;
            this.lbDiaChi.Text = "Địa chỉ";
            // 
            // txbTen
            // 
            this.txbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTen.Location = new System.Drawing.Point(197, 146);
            this.txbTen.Multiline = true;
            this.txbTen.Name = "txbTen";
            this.txbTen.Size = new System.Drawing.Size(258, 33);
            this.txbTen.TabIndex = 69;
            // 
            // lbTen
            // 
            this.lbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTen.Location = new System.Drawing.Point(20, 146);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(171, 30);
            this.lbTen.TabIndex = 68;
            this.lbTen.Text = "Tên";
            // 
            // txbHo
            // 
            this.txbHo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbHo.Location = new System.Drawing.Point(197, 97);
            this.txbHo.Multiline = true;
            this.txbHo.Name = "txbHo";
            this.txbHo.Size = new System.Drawing.Size(258, 33);
            this.txbHo.TabIndex = 67;
            // 
            // lbHo
            // 
            this.lbHo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbHo.Location = new System.Drawing.Point(20, 97);
            this.lbHo.Name = "lbHo";
            this.lbHo.Size = new System.Drawing.Size(171, 30);
            this.lbHo.TabIndex = 66;
            this.lbHo.Text = "Họ";
            // 
            // txbID
            // 
            this.txbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID.Location = new System.Drawing.Point(197, 48);
            this.txbID.Multiline = true;
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(258, 33);
            this.txbID.TabIndex = 65;
            // 
            // lbID
            // 
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbID.Location = new System.Drawing.Point(20, 48);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(171, 30);
            this.lbID.TabIndex = 64;
            this.lbID.Text = "ID";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Lime;
            this.btnFind.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(1054, 60);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(149, 33);
            this.btnFind.TabIndex = 82;
            this.btnFind.Text = "Tìm kiếm";
            this.btnFind.UseVisualStyleBackColor = false;
            // 
            // PnQLNS
            // 
            this.PnQLNS.Controls.Add(this.LbFind);
            this.PnQLNS.Controls.Add(this.txbFind);
            this.PnQLNS.Controls.Add(this.cbxFind);
            this.PnQLNS.Controls.Add(this.btnFind);
            this.PnQLNS.Controls.Add(this.GridViewQLNS);
            this.PnQLNS.Controls.Add(this.PnInformation);
            this.PnQLNS.Location = new System.Drawing.Point(-234, -91);
            this.PnQLNS.Name = "PnQLNS";
            this.PnQLNS.Size = new System.Drawing.Size(1268, 633);
            this.PnQLNS.TabIndex = 82;
            // 
            // QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PnQLNS);
            this.Name = "QuanLyNhanVien";
            this.Text = "QuanLyNhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.GridViewQLNS)).EndInit();
            this.PnInformation.ResumeLayout(false);
            this.PnInformation.PerformLayout();
            this.panelGioiTinh.ResumeLayout(false);
            this.panelGioiTinh.PerformLayout();
            this.PnQLNS.ResumeLayout(false);
            this.PnQLNS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LbFind;
        public System.Windows.Forms.TextBox txbFind;
        public System.Windows.Forms.ComboBox cbxFind;
        private System.Windows.Forms.DataGridView GridViewQLNS;
        private System.Windows.Forms.TextBox txbLoaiNhanVien;
        private System.Windows.Forms.Label lbLoaiNhanVien;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Panel PnInformation;
        private System.Windows.Forms.TextBox txbLuongCoBan;
        private System.Windows.Forms.Label lbLuongCoBan;
        private System.Windows.Forms.DateTimePicker DTNgayLam;
        private System.Windows.Forms.Label lbNgayLam;
        private System.Windows.Forms.Panel panelGioiTinh;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.DateTimePicker DTNgaySinh;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.TextBox txbDiaChi;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.TextBox txbTen;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.TextBox txbHo;
        private System.Windows.Forms.Label lbHo;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label lbID;
        public System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Panel PnQLNS;
    }
}
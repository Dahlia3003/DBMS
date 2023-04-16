namespace DBMS_FINAL_PROJECT.QL_CALAM
{
    partial class Form_TaoLichlamviec
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_Tao = new System.Windows.Forms.Button();
            this.comboBox_buoi = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_Toi_den = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_toi_tu = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_chieu_den = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_chieu_tu = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_sang_den = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_sang_tu = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_ngay_den = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_ngay_tu = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_Den = new System.Windows.Forms.Label();
            this.label_Tu = new System.Windows.Forms.Label();
            this.label_Toi = new System.Windows.Forms.Label();
            this.label_Chieu = new System.Windows.Forms.Label();
            this.label_Sang = new System.Windows.Forms.Label();
            this.label_Buoi = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 48);
            this.label1.TabIndex = 30;
            this.label1.Text = "Phân quyền: Quản Lý\r\nChọn tạo từ ngày đến ngày, không tạo trùng, \r\nchọn buổi sau " +
    "đó, các timepicker mới sáng lên, mặt định là không thể nhập, readonly\r\n";
            // 
            // button_Tao
            // 
            this.button_Tao.Location = new System.Drawing.Point(52, 290);
            this.button_Tao.Name = "button_Tao";
            this.button_Tao.Size = new System.Drawing.Size(75, 23);
            this.button_Tao.TabIndex = 29;
            this.button_Tao.Text = "Khởi tạo";
            this.button_Tao.UseVisualStyleBackColor = true;
            this.button_Tao.Click += new System.EventHandler(this.button_Tao_Click);
            // 
            // comboBox_buoi
            // 
            this.comboBox_buoi.FormattingEnabled = true;
            this.comboBox_buoi.Items.AddRange(new object[] {
            "Sáng",
            "Chiều",
            "Tối"});
            this.comboBox_buoi.Location = new System.Drawing.Point(114, 134);
            this.comboBox_buoi.Name = "comboBox_buoi";
            this.comboBox_buoi.Size = new System.Drawing.Size(121, 24);
            this.comboBox_buoi.TabIndex = 28;
            this.comboBox_buoi.SelectedIndexChanged += new System.EventHandler(this.comboBox_buoi_SelectedIndexChanged);
            // 
            // dateTimePicker_Toi_den
            // 
            this.dateTimePicker_Toi_den.Enabled = false;
            this.dateTimePicker_Toi_den.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_Toi_den.Location = new System.Drawing.Point(396, 247);
            this.dateTimePicker_Toi_den.Name = "dateTimePicker_Toi_den";
            this.dateTimePicker_Toi_den.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker_Toi_den.ShowUpDown = true;
            this.dateTimePicker_Toi_den.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_Toi_den.TabIndex = 26;
            // 
            // dateTimePicker_toi_tu
            // 
            this.dateTimePicker_toi_tu.Enabled = false;
            this.dateTimePicker_toi_tu.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_toi_tu.Location = new System.Drawing.Point(140, 246);
            this.dateTimePicker_toi_tu.Name = "dateTimePicker_toi_tu";
            this.dateTimePicker_toi_tu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker_toi_tu.ShowUpDown = true;
            this.dateTimePicker_toi_tu.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_toi_tu.TabIndex = 25;
            // 
            // dateTimePicker_chieu_den
            // 
            this.dateTimePicker_chieu_den.Enabled = false;
            this.dateTimePicker_chieu_den.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_chieu_den.Location = new System.Drawing.Point(396, 222);
            this.dateTimePicker_chieu_den.Name = "dateTimePicker_chieu_den";
            this.dateTimePicker_chieu_den.ShowUpDown = true;
            this.dateTimePicker_chieu_den.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_chieu_den.TabIndex = 24;
            // 
            // dateTimePicker_chieu_tu
            // 
            this.dateTimePicker_chieu_tu.Enabled = false;
            this.dateTimePicker_chieu_tu.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_chieu_tu.Location = new System.Drawing.Point(140, 221);
            this.dateTimePicker_chieu_tu.Name = "dateTimePicker_chieu_tu";
            this.dateTimePicker_chieu_tu.ShowUpDown = true;
            this.dateTimePicker_chieu_tu.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_chieu_tu.TabIndex = 23;
            // 
            // dateTimePicker_sang_den
            // 
            this.dateTimePicker_sang_den.Enabled = false;
            this.dateTimePicker_sang_den.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_sang_den.Location = new System.Drawing.Point(396, 190);
            this.dateTimePicker_sang_den.Name = "dateTimePicker_sang_den";
            this.dateTimePicker_sang_den.ShowUpDown = true;
            this.dateTimePicker_sang_den.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_sang_den.TabIndex = 22;
            // 
            // dateTimePicker_sang_tu
            // 
            this.dateTimePicker_sang_tu.Enabled = false;
            this.dateTimePicker_sang_tu.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_sang_tu.Location = new System.Drawing.Point(140, 189);
            this.dateTimePicker_sang_tu.Name = "dateTimePicker_sang_tu";
            this.dateTimePicker_sang_tu.ShowUpDown = true;
            this.dateTimePicker_sang_tu.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_sang_tu.TabIndex = 21;
            // 
            // dateTimePicker_ngay_den
            // 
            this.dateTimePicker_ngay_den.Location = new System.Drawing.Point(448, 94);
            this.dateTimePicker_ngay_den.Name = "dateTimePicker_ngay_den";
            this.dateTimePicker_ngay_den.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_ngay_den.TabIndex = 20;
            // 
            // dateTimePicker_ngay_tu
            // 
            this.dateTimePicker_ngay_tu.Location = new System.Drawing.Point(90, 93);
            this.dateTimePicker_ngay_tu.Name = "dateTimePicker_ngay_tu";
            this.dateTimePicker_ngay_tu.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_ngay_tu.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Từ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Từ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Từ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(359, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Đến";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(359, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Đến";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(359, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Đến";
            // 
            // label_Den
            // 
            this.label_Den.AutoSize = true;
            this.label_Den.Location = new System.Drawing.Point(339, 99);
            this.label_Den.Name = "label_Den";
            this.label_Den.Size = new System.Drawing.Size(31, 16);
            this.label_Den.TabIndex = 12;
            this.label_Den.Text = "Đến";
            // 
            // label_Tu
            // 
            this.label_Tu.AutoSize = true;
            this.label_Tu.Location = new System.Drawing.Point(42, 98);
            this.label_Tu.Name = "label_Tu";
            this.label_Tu.Size = new System.Drawing.Size(23, 16);
            this.label_Tu.TabIndex = 11;
            this.label_Tu.Text = "Từ";
            // 
            // label_Toi
            // 
            this.label_Toi.AutoSize = true;
            this.label_Toi.Location = new System.Drawing.Point(49, 246);
            this.label_Toi.Name = "label_Toi";
            this.label_Toi.Size = new System.Drawing.Size(27, 16);
            this.label_Toi.TabIndex = 10;
            this.label_Toi.Text = "Tối";
            // 
            // label_Chieu
            // 
            this.label_Chieu.AutoSize = true;
            this.label_Chieu.Location = new System.Drawing.Point(42, 220);
            this.label_Chieu.Name = "label_Chieu";
            this.label_Chieu.Size = new System.Drawing.Size(41, 16);
            this.label_Chieu.TabIndex = 9;
            this.label_Chieu.Text = "Chiều";
            // 
            // label_Sang
            // 
            this.label_Sang.AutoSize = true;
            this.label_Sang.Location = new System.Drawing.Point(42, 189);
            this.label_Sang.Name = "label_Sang";
            this.label_Sang.Size = new System.Drawing.Size(42, 16);
            this.label_Sang.TabIndex = 8;
            this.label_Sang.Text = "Sáng:";
            // 
            // label_Buoi
            // 
            this.label_Buoi.AutoSize = true;
            this.label_Buoi.Location = new System.Drawing.Point(42, 137);
            this.label_Buoi.Name = "label_Buoi";
            this.label_Buoi.Size = new System.Drawing.Size(34, 16);
            this.label_Buoi.TabIndex = 16;
            this.label_Buoi.Text = "Buổi";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Location = new System.Drawing.Point(42, 59);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(130, 16);
            this.label_title.TabIndex = 7;
            this.label_title.Text = "TẠO LỊCH LÀM VIỆC";
            // 
            // Form_TaoLichlamviec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Tao);
            this.Controls.Add(this.comboBox_buoi);
            this.Controls.Add(this.dateTimePicker_Toi_den);
            this.Controls.Add(this.dateTimePicker_toi_tu);
            this.Controls.Add(this.dateTimePicker_chieu_den);
            this.Controls.Add(this.dateTimePicker_chieu_tu);
            this.Controls.Add(this.dateTimePicker_sang_den);
            this.Controls.Add(this.dateTimePicker_sang_tu);
            this.Controls.Add(this.dateTimePicker_ngay_den);
            this.Controls.Add(this.dateTimePicker_ngay_tu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_Den);
            this.Controls.Add(this.label_Tu);
            this.Controls.Add(this.label_Toi);
            this.Controls.Add(this.label_Chieu);
            this.Controls.Add(this.label_Sang);
            this.Controls.Add(this.label_Buoi);
            this.Controls.Add(this.label_title);
            this.Name = "Form_TaoLichlamviec";
            this.Text = "Form_TaoLichlamviec";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Tao;
        private System.Windows.Forms.ComboBox comboBox_buoi;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Toi_den;
        private System.Windows.Forms.DateTimePicker dateTimePicker_toi_tu;
        private System.Windows.Forms.DateTimePicker dateTimePicker_chieu_den;
        private System.Windows.Forms.DateTimePicker dateTimePicker_chieu_tu;
        private System.Windows.Forms.DateTimePicker dateTimePicker_sang_den;
        private System.Windows.Forms.DateTimePicker dateTimePicker_sang_tu;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ngay_den;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ngay_tu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_Den;
        private System.Windows.Forms.Label label_Tu;
        private System.Windows.Forms.Label label_Toi;
        private System.Windows.Forms.Label label_Chieu;
        private System.Windows.Forms.Label label_Sang;
        private System.Windows.Forms.Label label_Buoi;
        private System.Windows.Forms.Label label_title;
    }
}
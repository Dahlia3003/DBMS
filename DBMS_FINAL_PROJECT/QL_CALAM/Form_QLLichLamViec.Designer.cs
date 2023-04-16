namespace DBMS_FINAL_PROJECT.QL_CALAM
{
    partial class Form_QLLichLamViec
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
            this.texBox_Ngay = new System.Windows.Forms.TextBox();
            this.comboBox_Thang = new System.Windows.Forms.ComboBox();
            this.comboBox_Nam = new System.Windows.Forms.ComboBox();
            this.button_XoaLoc = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.label_Ngay = new System.Windows.Forms.Label();
            this.label_Thang = new System.Windows.Forms.Label();
            this.label_Nam = new System.Windows.Forms.Label();
            this.label_Title_Lich_lam_viec = new System.Windows.Forms.Label();
            this.dataGridView_Lich_lam_viec = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Lich_lam_viec)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1255, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 48);
            this.label1.TabIndex = 20;
            this.label1.Text = "Phân quyền: Quản lý\r\n\r\nBảng này hiển thị các ca làm và tên nhân viên phụ trách ca" +
    " theo bộ lọc\r\n";
            // 
            // texBox_Ngay
            // 
            this.texBox_Ngay.Location = new System.Drawing.Point(602, 43);
            this.texBox_Ngay.Name = "texBox_Ngay";
            this.texBox_Ngay.Size = new System.Drawing.Size(100, 22);
            this.texBox_Ngay.TabIndex = 19;
            // 
            // comboBox_Thang
            // 
            this.comboBox_Thang.FormattingEnabled = true;
            this.comboBox_Thang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBox_Thang.Location = new System.Drawing.Point(393, 41);
            this.comboBox_Thang.Name = "comboBox_Thang";
            this.comboBox_Thang.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Thang.TabIndex = 17;
            // 
            // comboBox_Nam
            // 
            this.comboBox_Nam.FormattingEnabled = true;
            this.comboBox_Nam.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.comboBox_Nam.Location = new System.Drawing.Point(184, 44);
            this.comboBox_Nam.Name = "comboBox_Nam";
            this.comboBox_Nam.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Nam.TabIndex = 18;
            // 
            // button_XoaLoc
            // 
            this.button_XoaLoc.Location = new System.Drawing.Point(831, 44);
            this.button_XoaLoc.Name = "button_XoaLoc";
            this.button_XoaLoc.Size = new System.Drawing.Size(140, 23);
            this.button_XoaLoc.TabIndex = 16;
            this.button_XoaLoc.Text = "Xóa bộ lọc";
            this.button_XoaLoc.UseVisualStyleBackColor = true;
            this.button_XoaLoc.Click += new System.EventHandler(this.button_XoaLoc_Click);
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(727, 45);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 23);
            this.button_search.TabIndex = 15;
            this.button_search.Text = "Lọc";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // label_Ngay
            // 
            this.label_Ngay.AutoSize = true;
            this.label_Ngay.Location = new System.Drawing.Point(549, 44);
            this.label_Ngay.Name = "label_Ngay";
            this.label_Ngay.Size = new System.Drawing.Size(46, 16);
            this.label_Ngay.TabIndex = 12;
            this.label_Ngay.Text = "Ngày: ";
            // 
            // label_Thang
            // 
            this.label_Thang.AutoSize = true;
            this.label_Thang.Location = new System.Drawing.Point(338, 44);
            this.label_Thang.Name = "label_Thang";
            this.label_Thang.Size = new System.Drawing.Size(49, 16);
            this.label_Thang.TabIndex = 13;
            this.label_Thang.Text = "Tháng:";
            // 
            // label_Nam
            // 
            this.label_Nam.AutoSize = true;
            this.label_Nam.Location = new System.Drawing.Point(139, 45);
            this.label_Nam.Name = "label_Nam";
            this.label_Nam.Size = new System.Drawing.Size(39, 16);
            this.label_Nam.TabIndex = 14;
            this.label_Nam.Text = "Năm:";
            // 
            // label_Title_Lich_lam_viec
            // 
            this.label_Title_Lich_lam_viec.AutoSize = true;
            this.label_Title_Lich_lam_viec.Location = new System.Drawing.Point(9, 45);
            this.label_Title_Lich_lam_viec.Name = "label_Title_Lich_lam_viec";
            this.label_Title_Lich_lam_viec.Size = new System.Drawing.Size(99, 16);
            this.label_Title_Lich_lam_viec.TabIndex = 10;
            this.label_Title_Lich_lam_viec.Text = "LỊCH LÀM VIỆC";
            // 
            // dataGridView_Lich_lam_viec
            // 
            this.dataGridView_Lich_lam_viec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Lich_lam_viec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Lich_lam_viec.Location = new System.Drawing.Point(12, 88);
            this.dataGridView_Lich_lam_viec.Name = "dataGridView_Lich_lam_viec";
            this.dataGridView_Lich_lam_viec.RowHeadersVisible = false;
            this.dataGridView_Lich_lam_viec.RowHeadersWidth = 51;
            this.dataGridView_Lich_lam_viec.RowTemplate.Height = 24;
            this.dataGridView_Lich_lam_viec.Size = new System.Drawing.Size(1662, 466);
            this.dataGridView_Lich_lam_viec.TabIndex = 9;
            // 
            // Form_QLLichLamViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1714, 610);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.texBox_Ngay);
            this.Controls.Add(this.comboBox_Thang);
            this.Controls.Add(this.comboBox_Nam);
            this.Controls.Add(this.button_XoaLoc);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.label_Ngay);
            this.Controls.Add(this.label_Thang);
            this.Controls.Add(this.label_Nam);
            this.Controls.Add(this.label_Title_Lich_lam_viec);
            this.Controls.Add(this.dataGridView_Lich_lam_viec);
            this.Name = "Form_QLLichLamViec";
            this.Text = "Form_QLLichLamViec";
            this.Load += new System.EventHandler(this.Form_QLLichLamViec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Lich_lam_viec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox texBox_Ngay;
        private System.Windows.Forms.ComboBox comboBox_Thang;
        private System.Windows.Forms.ComboBox comboBox_Nam;
        private System.Windows.Forms.Button button_XoaLoc;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Label label_Ngay;
        private System.Windows.Forms.Label label_Thang;
        private System.Windows.Forms.Label label_Nam;
        private System.Windows.Forms.Label label_Title_Lich_lam_viec;
        private System.Windows.Forms.DataGridView dataGridView_Lich_lam_viec;
    }
}
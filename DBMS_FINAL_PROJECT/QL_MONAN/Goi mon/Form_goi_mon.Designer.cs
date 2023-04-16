namespace DBMS_FINAL_PROJECT.QL_MONAN.Goi_mon
{
    partial class Form_goi_mon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_goi_mon));
            this.button_Loc = new System.Windows.Forms.Button();
            this.lable_Bo_loc = new System.Windows.Forms.Label();
            this.comboBox_loai_mon = new System.Windows.Forms.ComboBox();
            this.button_XuatHoaDon = new System.Windows.Forms.Button();
            this.dataGridView_mon_da_chon = new System.Windows.Forms.DataGridView();
            this.dataGridView_ds_mon = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label_mon_da_chon = new System.Windows.Forms.Label();
            this.label_Title = new System.Windows.Forms.Label();
            this.button_xoaLoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_mon_da_chon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ds_mon)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Loc
            // 
            this.button_Loc.Location = new System.Drawing.Point(259, 66);
            this.button_Loc.Name = "button_Loc";
            this.button_Loc.Size = new System.Drawing.Size(75, 23);
            this.button_Loc.TabIndex = 19;
            this.button_Loc.Text = "Lọc";
            this.button_Loc.UseVisualStyleBackColor = true;
            this.button_Loc.Click += new System.EventHandler(this.button_Loc_Click);
            // 
            // lable_Bo_loc
            // 
            this.lable_Bo_loc.AutoSize = true;
            this.lable_Bo_loc.Location = new System.Drawing.Point(40, 68);
            this.lable_Bo_loc.Name = "lable_Bo_loc";
            this.lable_Bo_loc.Size = new System.Drawing.Size(45, 16);
            this.lable_Bo_loc.TabIndex = 18;
            this.lable_Bo_loc.Text = "Bộ lọc";
            // 
            // comboBox_loai_mon
            // 
            this.comboBox_loai_mon.FormattingEnabled = true;
            this.comboBox_loai_mon.Items.AddRange(new object[] {
            "Ga ran",
            "Burger",
            "Mon mi",
            "Mon com",
            "Trang mieng",
            "Nuoc uong"});
            this.comboBox_loai_mon.Location = new System.Drawing.Point(120, 65);
            this.comboBox_loai_mon.Name = "comboBox_loai_mon";
            this.comboBox_loai_mon.Size = new System.Drawing.Size(121, 24);
            this.comboBox_loai_mon.TabIndex = 17;
            // 
            // button_XuatHoaDon
            // 
            this.button_XuatHoaDon.Location = new System.Drawing.Point(966, 112);
            this.button_XuatHoaDon.Name = "button_XuatHoaDon";
            this.button_XuatHoaDon.Size = new System.Drawing.Size(151, 23);
            this.button_XuatHoaDon.TabIndex = 16;
            this.button_XuatHoaDon.Text = "Xuất hóa đơn";
            this.button_XuatHoaDon.UseVisualStyleBackColor = true;
            this.button_XuatHoaDon.Click += new System.EventHandler(this.button_XuatHoaDon_Click);
            // 
            // dataGridView_mon_da_chon
            // 
            this.dataGridView_mon_da_chon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_mon_da_chon.Location = new System.Drawing.Point(515, 112);
            this.dataGridView_mon_da_chon.Name = "dataGridView_mon_da_chon";
            this.dataGridView_mon_da_chon.RowHeadersWidth = 51;
            this.dataGridView_mon_da_chon.RowTemplate.Height = 24;
            this.dataGridView_mon_da_chon.Size = new System.Drawing.Size(392, 419);
            this.dataGridView_mon_da_chon.TabIndex = 12;
            this.dataGridView_mon_da_chon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_mon_da_chon_CellDoubleClick);
            // 
            // dataGridView_ds_mon
            // 
            this.dataGridView_ds_mon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ds_mon.Location = new System.Drawing.Point(23, 112);
            this.dataGridView_ds_mon.Name = "dataGridView_ds_mon";
            this.dataGridView_ds_mon.RowHeadersWidth = 51;
            this.dataGridView_ds_mon.RowTemplate.Height = 24;
            this.dataGridView_ds_mon.Size = new System.Drawing.Size(392, 419);
            this.dataGridView_ds_mon.TabIndex = 13;
            this.dataGridView_ds_mon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ds_mon_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 534);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1496, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label_mon_da_chon
            // 
            this.label_mon_da_chon.AutoSize = true;
            this.label_mon_da_chon.Location = new System.Drawing.Point(400, 9);
            this.label_mon_da_chon.Name = "label_mon_da_chon";
            this.label_mon_da_chon.Size = new System.Drawing.Size(1347, 96);
            this.label_mon_da_chon.TabIndex = 10;
            this.label_mon_da_chon.Text = resources.GetString("label_mon_da_chon.Text");
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Location = new System.Drawing.Point(20, 22);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(64, 16);
            this.label_Title.TabIndex = 11;
            this.label_Title.Text = "GỌI MÓN";
            // 
            // button_xoaLoc
            // 
            this.button_xoaLoc.Location = new System.Drawing.Point(349, 66);
            this.button_xoaLoc.Name = "button_xoaLoc";
            this.button_xoaLoc.Size = new System.Drawing.Size(75, 23);
            this.button_xoaLoc.TabIndex = 19;
            this.button_xoaLoc.Text = "Xóa lọc";
            this.button_xoaLoc.UseVisualStyleBackColor = true;
            this.button_xoaLoc.Click += new System.EventHandler(this.button_xoaLoc_Click);
            // 
            // Form_goi_mon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1709, 615);
            this.Controls.Add(this.button_xoaLoc);
            this.Controls.Add(this.button_Loc);
            this.Controls.Add(this.lable_Bo_loc);
            this.Controls.Add(this.comboBox_loai_mon);
            this.Controls.Add(this.button_XuatHoaDon);
            this.Controls.Add(this.dataGridView_mon_da_chon);
            this.Controls.Add(this.dataGridView_ds_mon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_mon_da_chon);
            this.Controls.Add(this.label_Title);
            this.Name = "Form_goi_mon";
            this.Text = "Form_goi_mon";
            this.Load += new System.EventHandler(this.Form_goi_mon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_mon_da_chon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ds_mon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Loc;
        private System.Windows.Forms.Label lable_Bo_loc;
        private System.Windows.Forms.ComboBox comboBox_loai_mon;
        private System.Windows.Forms.Button button_XuatHoaDon;
        private System.Windows.Forms.DataGridView dataGridView_mon_da_chon;
        private System.Windows.Forms.DataGridView dataGridView_ds_mon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_mon_da_chon;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Button button_xoaLoc;
    }
}
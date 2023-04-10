namespace DBMS_FINAL_PROJECT.QL_HOADON
{
    partial class FORM_QL_HOA_DON
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
            this.btn_Thong_Ke_Hoa_Don = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_Cuoi = new System.Windows.Forms.DateTimePicker();
            this.dtp_Dau = new System.Windows.Forms.DateTimePicker();
            this.dgv_Hoa_Don_Da_Xuat = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hoa_Don_Da_Xuat)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Thong_Ke_Hoa_Don
            // 
            this.btn_Thong_Ke_Hoa_Don.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thong_Ke_Hoa_Don.Location = new System.Drawing.Point(308, 428);
            this.btn_Thong_Ke_Hoa_Don.Name = "btn_Thong_Ke_Hoa_Don";
            this.btn_Thong_Ke_Hoa_Don.Size = new System.Drawing.Size(205, 39);
            this.btn_Thong_Ke_Hoa_Don.TabIndex = 11;
            this.btn_Thong_Ke_Hoa_Don.Text = "Thống kê";
            this.btn_Thong_Ke_Hoa_Don.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(429, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Đến ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Từ ngày:";
            // 
            // dtp_Cuoi
            // 
            this.dtp_Cuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Cuoi.Location = new System.Drawing.Point(518, 387);
            this.dtp_Cuoi.Name = "dtp_Cuoi";
            this.dtp_Cuoi.Size = new System.Drawing.Size(297, 27);
            this.dtp_Cuoi.TabIndex = 8;
            // 
            // dtp_Dau
            // 
            this.dtp_Dau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Dau.Location = new System.Drawing.Point(124, 388);
            this.dtp_Dau.Name = "dtp_Dau";
            this.dtp_Dau.Size = new System.Drawing.Size(293, 27);
            this.dtp_Dau.TabIndex = 7;
            // 
            // dgv_Hoa_Don_Da_Xuat
            // 
            this.dgv_Hoa_Don_Da_Xuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Hoa_Don_Da_Xuat.Location = new System.Drawing.Point(-2, 12);
            this.dgv_Hoa_Don_Da_Xuat.Name = "dgv_Hoa_Don_Da_Xuat";
            this.dgv_Hoa_Don_Da_Xuat.RowHeadersWidth = 51;
            this.dgv_Hoa_Don_Da_Xuat.RowTemplate.Height = 24;
            this.dgv_Hoa_Don_Da_Xuat.Size = new System.Drawing.Size(850, 346);
            this.dgv_Hoa_Don_Da_Xuat.TabIndex = 6;
            // 
            // FORM_QL_HOA_DON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 506);
            this.Controls.Add(this.btn_Thong_Ke_Hoa_Don);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_Cuoi);
            this.Controls.Add(this.dtp_Dau);
            this.Controls.Add(this.dgv_Hoa_Don_Da_Xuat);
            this.Name = "FORM_QL_HOA_DON";
            this.Text = "FORM_QL_HOA_DON";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hoa_Don_Da_Xuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Thong_Ke_Hoa_Don;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_Cuoi;
        private System.Windows.Forms.DateTimePicker dtp_Dau;
        private System.Windows.Forms.DataGridView dgv_Hoa_Don_Da_Xuat;
    }
}
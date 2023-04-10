namespace DBMS_FINAL_PROJECT.QL_HOADON
{
    partial class FORM_XUAT_HOA_DON
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
            this.cb_Khuyen_Mai = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Hoa_Don = new System.Windows.Forms.DataGridView();
            this.btn_Thanh_Toan = new System.Windows.Forms.Button();
            this.btn_Xoa_Hoa_Don = new System.Windows.Forms.Button();
            this.btn_Sua_Hoa_Don = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hoa_Don)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_Khuyen_Mai
            // 
            this.cb_Khuyen_Mai.ForeColor = System.Drawing.Color.Gray;
            this.cb_Khuyen_Mai.FormattingEnabled = true;
            this.cb_Khuyen_Mai.Location = new System.Drawing.Point(162, 379);
            this.cb_Khuyen_Mai.Name = "cb_Khuyen_Mai";
            this.cb_Khuyen_Mai.Size = new System.Drawing.Size(482, 24);
            this.cb_Khuyen_Mai.TabIndex = 19;
            this.cb_Khuyen_Mai.Text = "Chọn khuyến mãi";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(344, 411);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 30);
            this.textBox1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tổng tiền:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_Hoa_Don
            // 
            this.dgv_Hoa_Don.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Hoa_Don.Location = new System.Drawing.Point(162, 11);
            this.dgv_Hoa_Don.Name = "dgv_Hoa_Don";
            this.dgv_Hoa_Don.RowHeadersWidth = 51;
            this.dgv_Hoa_Don.RowTemplate.Height = 24;
            this.dgv_Hoa_Don.Size = new System.Drawing.Size(482, 362);
            this.dgv_Hoa_Don.TabIndex = 16;
            // 
            // btn_Thanh_Toan
            // 
            this.btn_Thanh_Toan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thanh_Toan.Location = new System.Drawing.Point(162, 501);
            this.btn_Thanh_Toan.Name = "btn_Thanh_Toan";
            this.btn_Thanh_Toan.Size = new System.Drawing.Size(482, 41);
            this.btn_Thanh_Toan.TabIndex = 15;
            this.btn_Thanh_Toan.Text = "Thanh toán và xuất hóa đơn";
            this.btn_Thanh_Toan.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa_Hoa_Don
            // 
            this.btn_Xoa_Hoa_Don.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa_Hoa_Don.Location = new System.Drawing.Point(162, 452);
            this.btn_Xoa_Hoa_Don.Name = "btn_Xoa_Hoa_Don";
            this.btn_Xoa_Hoa_Don.Size = new System.Drawing.Size(202, 43);
            this.btn_Xoa_Hoa_Don.TabIndex = 14;
            this.btn_Xoa_Hoa_Don.Text = "Xóa hóa đơn";
            this.btn_Xoa_Hoa_Don.UseVisualStyleBackColor = true;
            // 
            // btn_Sua_Hoa_Don
            // 
            this.btn_Sua_Hoa_Don.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua_Hoa_Don.Location = new System.Drawing.Point(446, 452);
            this.btn_Sua_Hoa_Don.Name = "btn_Sua_Hoa_Don";
            this.btn_Sua_Hoa_Don.Size = new System.Drawing.Size(198, 43);
            this.btn_Sua_Hoa_Don.TabIndex = 13;
            this.btn_Sua_Hoa_Don.Text = "Sửa hóa đơn";
            this.btn_Sua_Hoa_Don.UseVisualStyleBackColor = true;
            // 
            // FORM_XUAT_HOA_DON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 552);
            this.Controls.Add(this.cb_Khuyen_Mai);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Hoa_Don);
            this.Controls.Add(this.btn_Thanh_Toan);
            this.Controls.Add(this.btn_Xoa_Hoa_Don);
            this.Controls.Add(this.btn_Sua_Hoa_Don);
            this.Name = "FORM_XUAT_HOA_DON";
            this.Text = "FORM_XUAT_HOA_DON";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hoa_Don)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Khuyen_Mai;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Hoa_Don;
        private System.Windows.Forms.Button btn_Thanh_Toan;
        private System.Windows.Forms.Button btn_Xoa_Hoa_Don;
        private System.Windows.Forms.Button btn_Sua_Hoa_Don;
    }
}
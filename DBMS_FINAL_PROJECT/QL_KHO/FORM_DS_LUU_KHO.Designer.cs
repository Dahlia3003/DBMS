namespace DBMS_FINAL_PROJECT.QL_KHO
{
    partial class FORM_DS_LUU_KHO
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
            this.btn_Lam_Moi = new System.Windows.Forms.Button();
            this.dgv_DS_Luu_Kho = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DS_Luu_Kho)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Lam_Moi
            // 
            this.btn_Lam_Moi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Lam_Moi.Location = new System.Drawing.Point(304, 394);
            this.btn_Lam_Moi.Name = "btn_Lam_Moi";
            this.btn_Lam_Moi.Size = new System.Drawing.Size(191, 42);
            this.btn_Lam_Moi.TabIndex = 3;
            this.btn_Lam_Moi.Text = "Làm mới";
            this.btn_Lam_Moi.UseVisualStyleBackColor = true;
            // 
            // dgv_DS_Luu_Kho
            // 
            this.dgv_DS_Luu_Kho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DS_Luu_Kho.Location = new System.Drawing.Point(2, 14);
            this.dgv_DS_Luu_Kho.Name = "dgv_DS_Luu_Kho";
            this.dgv_DS_Luu_Kho.RowHeadersWidth = 51;
            this.dgv_DS_Luu_Kho.RowTemplate.Height = 24;
            this.dgv_DS_Luu_Kho.Size = new System.Drawing.Size(797, 353);
            this.dgv_DS_Luu_Kho.TabIndex = 2;
            // 
            // FORM_DS_LUU_KHO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Lam_Moi);
            this.Controls.Add(this.dgv_DS_Luu_Kho);
            this.Name = "FORM_DS_LUU_KHO";
            this.Text = "FORM_DS_LUU_KHO";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DS_Luu_Kho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Lam_Moi;
        private System.Windows.Forms.DataGridView dgv_DS_Luu_Kho;
    }
}
namespace DBMS_FINAL_PROJECT.QL_MONAN
{
    partial class Form_QL_MonAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_QL_MonAn));
            this.textBox_gia_L = new System.Windows.Forms.TextBox();
            this.textBox_gia_M = new System.Windows.Forms.TextBox();
            this.textBox_gia_S = new System.Windows.Forms.TextBox();
            this.checkBox_L = new System.Windows.Forms.CheckBox();
            this.checkBox_CO_M = new System.Windows.Forms.CheckBox();
            this.checkBox_Co_S = new System.Windows.Forms.CheckBox();
            this.comboBox_loai_mon = new System.Windows.Forms.ComboBox();
            this.textBox_Ten_mon_an = new System.Windows.Forms.TextBox();
            this.button_remove = new System.Windows.Forms.Button();
            this.button_UPDATE = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.label_kich_co = new System.Windows.Forms.Label();
            this.label_loai_mon_an = new System.Windows.Forms.Label();
            this.label_ten_mon_an = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_DS_mon_an = new System.Windows.Forms.Label();
            this.dataGridView_DS_mon_an = new System.Windows.Forms.DataGridView();
            this.checkBox_Size_DF = new System.Windows.Forms.CheckBox();
            this.textBox_size_DF = new System.Windows.Forms.TextBox();
            this.textBox_ma_mon_an = new System.Windows.Forms.TextBox();
            this.label_ma_mon_an = new System.Windows.Forms.Label();
            this.textBox_ma_loai_mon_an = new System.Windows.Forms.TextBox();
            this.label_ma_loai_mon_an = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DS_mon_an)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_gia_L
            // 
            this.textBox_gia_L.Location = new System.Drawing.Point(964, 224);
            this.textBox_gia_L.Name = "textBox_gia_L";
            this.textBox_gia_L.Size = new System.Drawing.Size(100, 22);
            this.textBox_gia_L.TabIndex = 25;
            this.textBox_gia_L.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_gia_L_KeyPress);
            // 
            // textBox_gia_M
            // 
            this.textBox_gia_M.Location = new System.Drawing.Point(964, 196);
            this.textBox_gia_M.Name = "textBox_gia_M";
            this.textBox_gia_M.Size = new System.Drawing.Size(100, 22);
            this.textBox_gia_M.TabIndex = 24;
            this.textBox_gia_M.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_gia_M_KeyPress);
            // 
            // textBox_gia_S
            // 
            this.textBox_gia_S.Location = new System.Drawing.Point(964, 169);
            this.textBox_gia_S.Name = "textBox_gia_S";
            this.textBox_gia_S.Size = new System.Drawing.Size(100, 22);
            this.textBox_gia_S.TabIndex = 23;
            this.textBox_gia_S.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_gia_S_KeyPress);
            // 
            // checkBox_L
            // 
            this.checkBox_L.AutoSize = true;
            this.checkBox_L.Location = new System.Drawing.Point(894, 224);
            this.checkBox_L.Name = "checkBox_L";
            this.checkBox_L.Size = new System.Drawing.Size(36, 20);
            this.checkBox_L.TabIndex = 22;
            this.checkBox_L.Text = "L";
            this.checkBox_L.UseVisualStyleBackColor = true;
            // 
            // checkBox_CO_M
            // 
            this.checkBox_CO_M.AutoSize = true;
            this.checkBox_CO_M.Location = new System.Drawing.Point(894, 198);
            this.checkBox_CO_M.Name = "checkBox_CO_M";
            this.checkBox_CO_M.Size = new System.Drawing.Size(40, 20);
            this.checkBox_CO_M.TabIndex = 21;
            this.checkBox_CO_M.Text = "M";
            this.checkBox_CO_M.UseVisualStyleBackColor = true;
            // 
            // checkBox_Co_S
            // 
            this.checkBox_Co_S.AutoSize = true;
            this.checkBox_Co_S.Location = new System.Drawing.Point(894, 172);
            this.checkBox_Co_S.Name = "checkBox_Co_S";
            this.checkBox_Co_S.Size = new System.Drawing.Size(38, 20);
            this.checkBox_Co_S.TabIndex = 20;
            this.checkBox_Co_S.Text = "S";
            this.checkBox_Co_S.UseVisualStyleBackColor = true;
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
            this.comboBox_loai_mon.Location = new System.Drawing.Point(988, 120);
            this.comboBox_loai_mon.Name = "comboBox_loai_mon";
            this.comboBox_loai_mon.Size = new System.Drawing.Size(121, 24);
            this.comboBox_loai_mon.TabIndex = 19;
            this.comboBox_loai_mon.SelectedIndexChanged += new System.EventHandler(this.comboBox_loai_mon_SelectedIndexChanged);
            // 
            // textBox_Ten_mon_an
            // 
            this.textBox_Ten_mon_an.Location = new System.Drawing.Point(988, 69);
            this.textBox_Ten_mon_an.Name = "textBox_Ten_mon_an";
            this.textBox_Ten_mon_an.Size = new System.Drawing.Size(100, 22);
            this.textBox_Ten_mon_an.TabIndex = 18;
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(1068, 275);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(75, 23);
            this.button_remove.TabIndex = 17;
            this.button_remove.Text = "REMOVE\r\n";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // button_UPDATE
            // 
            this.button_UPDATE.Location = new System.Drawing.Point(964, 275);
            this.button_UPDATE.Name = "button_UPDATE";
            this.button_UPDATE.Size = new System.Drawing.Size(75, 23);
            this.button_UPDATE.TabIndex = 16;
            this.button_UPDATE.Text = "UPDATE";
            this.button_UPDATE.UseVisualStyleBackColor = true;
            this.button_UPDATE.Click += new System.EventHandler(this.button_UPDATE_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(867, 275);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 15;
            this.button_add.Text = "ADD";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(704, 24);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(75, 23);
            this.button_refresh.TabIndex = 14;
            this.button_refresh.Text = "refresh";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // label_kich_co
            // 
            this.label_kich_co.AutoSize = true;
            this.label_kich_co.Location = new System.Drawing.Point(864, 143);
            this.label_kich_co.Name = "label_kich_co";
            this.label_kich_co.Size = new System.Drawing.Size(50, 16);
            this.label_kich_co.TabIndex = 12;
            this.label_kich_co.Text = "Kích cỡ";
            // 
            // label_loai_mon_an
            // 
            this.label_loai_mon_an.AutoSize = true;
            this.label_loai_mon_an.Location = new System.Drawing.Point(866, 120);
            this.label_loai_mon_an.Name = "label_loai_mon_an";
            this.label_loai_mon_an.Size = new System.Drawing.Size(80, 16);
            this.label_loai_mon_an.TabIndex = 11;
            this.label_loai_mon_an.Text = "Loại món ăn";
            // 
            // label_ten_mon_an
            // 
            this.label_ten_mon_an.AutoSize = true;
            this.label_ten_mon_an.Location = new System.Drawing.Point(866, 69);
            this.label_ten_mon_an.Name = "label_ten_mon_an";
            this.label_ten_mon_an.Size = new System.Drawing.Size(78, 16);
            this.label_ten_mon_an.TabIndex = 10;
            this.label_ten_mon_an.Text = "Tên món ăn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(474, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1019, 64);
            this.label1.TabIndex = 9;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label_DS_mon_an
            // 
            this.label_DS_mon_an.AutoSize = true;
            this.label_DS_mon_an.Location = new System.Drawing.Point(35, 27);
            this.label_DS_mon_an.Name = "label_DS_mon_an";
            this.label_DS_mon_an.Size = new System.Drawing.Size(142, 16);
            this.label_DS_mon_an.TabIndex = 13;
            this.label_DS_mon_an.Text = "DANH SÁCH MÓN ĂN";
            // 
            // dataGridView_DS_mon_an
            // 
            this.dataGridView_DS_mon_an.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_DS_mon_an.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DS_mon_an.Location = new System.Drawing.Point(34, 53);
            this.dataGridView_DS_mon_an.Name = "dataGridView_DS_mon_an";
            this.dataGridView_DS_mon_an.RowHeadersVisible = false;
            this.dataGridView_DS_mon_an.RowHeadersWidth = 51;
            this.dataGridView_DS_mon_an.RowTemplate.Height = 24;
            this.dataGridView_DS_mon_an.Size = new System.Drawing.Size(745, 529);
            this.dataGridView_DS_mon_an.TabIndex = 8;
            this.dataGridView_DS_mon_an.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DS_mon_an_CellDoubleClick);
            // 
            // checkBox_Size_DF
            // 
            this.checkBox_Size_DF.AutoSize = true;
            this.checkBox_Size_DF.Location = new System.Drawing.Point(894, 249);
            this.checkBox_Size_DF.Name = "checkBox_Size_DF";
            this.checkBox_Size_DF.Size = new System.Drawing.Size(47, 20);
            this.checkBox_Size_DF.TabIndex = 22;
            this.checkBox_Size_DF.Text = "DF";
            this.checkBox_Size_DF.UseVisualStyleBackColor = true;
            // 
            // textBox_size_DF
            // 
            this.textBox_size_DF.Location = new System.Drawing.Point(964, 249);
            this.textBox_size_DF.Name = "textBox_size_DF";
            this.textBox_size_DF.Size = new System.Drawing.Size(100, 22);
            this.textBox_size_DF.TabIndex = 25;
            this.textBox_size_DF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_size_DF_KeyPress);
            // 
            // textBox_ma_mon_an
            // 
            this.textBox_ma_mon_an.Location = new System.Drawing.Point(990, 35);
            this.textBox_ma_mon_an.Name = "textBox_ma_mon_an";
            this.textBox_ma_mon_an.Size = new System.Drawing.Size(100, 22);
            this.textBox_ma_mon_an.TabIndex = 18;
            // 
            // label_ma_mon_an
            // 
            this.label_ma_mon_an.AutoSize = true;
            this.label_ma_mon_an.Location = new System.Drawing.Point(868, 35);
            this.label_ma_mon_an.Name = "label_ma_mon_an";
            this.label_ma_mon_an.Size = new System.Drawing.Size(73, 16);
            this.label_ma_mon_an.TabIndex = 10;
            this.label_ma_mon_an.Text = "Mã món ăn";
            // 
            // textBox_ma_loai_mon_an
            // 
            this.textBox_ma_loai_mon_an.Location = new System.Drawing.Point(988, 94);
            this.textBox_ma_loai_mon_an.Name = "textBox_ma_loai_mon_an";
            this.textBox_ma_loai_mon_an.ReadOnly = true;
            this.textBox_ma_loai_mon_an.Size = new System.Drawing.Size(100, 22);
            this.textBox_ma_loai_mon_an.TabIndex = 18;
            // 
            // label_ma_loai_mon_an
            // 
            this.label_ma_loai_mon_an.AutoSize = true;
            this.label_ma_loai_mon_an.Location = new System.Drawing.Point(866, 94);
            this.label_ma_loai_mon_an.Name = "label_ma_loai_mon_an";
            this.label_ma_loai_mon_an.Size = new System.Drawing.Size(101, 16);
            this.label_ma_loai_mon_an.TabIndex = 10;
            this.label_ma_loai_mon_an.Text = "Mã loại món ăn ";
            // 
            // Form_QL_MonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1561, 636);
            this.Controls.Add(this.textBox_size_DF);
            this.Controls.Add(this.textBox_gia_L);
            this.Controls.Add(this.textBox_gia_M);
            this.Controls.Add(this.textBox_gia_S);
            this.Controls.Add(this.checkBox_Size_DF);
            this.Controls.Add(this.checkBox_L);
            this.Controls.Add(this.checkBox_CO_M);
            this.Controls.Add(this.checkBox_Co_S);
            this.Controls.Add(this.comboBox_loai_mon);
            this.Controls.Add(this.textBox_ma_mon_an);
            this.Controls.Add(this.textBox_ma_loai_mon_an);
            this.Controls.Add(this.textBox_Ten_mon_an);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.button_UPDATE);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.label_kich_co);
            this.Controls.Add(this.label_loai_mon_an);
            this.Controls.Add(this.label_ma_mon_an);
            this.Controls.Add(this.label_ma_loai_mon_an);
            this.Controls.Add(this.label_ten_mon_an);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_DS_mon_an);
            this.Controls.Add(this.dataGridView_DS_mon_an);
            this.Name = "Form_QL_MonAn";
            this.Text = "Form_QL_MonAn";
            this.Load += new System.EventHandler(this.Form_QL_MonAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DS_mon_an)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_gia_L;
        private System.Windows.Forms.TextBox textBox_gia_M;
        private System.Windows.Forms.TextBox textBox_gia_S;
        private System.Windows.Forms.CheckBox checkBox_L;
        private System.Windows.Forms.CheckBox checkBox_CO_M;
        private System.Windows.Forms.CheckBox checkBox_Co_S;
        private System.Windows.Forms.ComboBox comboBox_loai_mon;
        private System.Windows.Forms.TextBox textBox_Ten_mon_an;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.Button button_UPDATE;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Label label_kich_co;
        private System.Windows.Forms.Label label_loai_mon_an;
        private System.Windows.Forms.Label label_ten_mon_an;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_DS_mon_an;
        private System.Windows.Forms.DataGridView dataGridView_DS_mon_an;
        private System.Windows.Forms.CheckBox checkBox_Size_DF;
        private System.Windows.Forms.TextBox textBox_size_DF;
        private System.Windows.Forms.TextBox textBox_ma_mon_an;
        private System.Windows.Forms.Label label_ma_mon_an;
        private System.Windows.Forms.TextBox textBox_ma_loai_mon_an;
        private System.Windows.Forms.Label label_ma_loai_mon_an;
    }
}
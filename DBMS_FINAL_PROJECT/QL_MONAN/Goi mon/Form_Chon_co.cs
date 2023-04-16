using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_FINAL_PROJECT.QL_MONAN.Goi_mon
{
    public partial class Form_Chon_co : Form
    {
        public SqlDataReader reader;
        public int mode = 0; //mode 0: them moi, mode 1 la chinh sua
        public string MaMonAn;
        public float sl_s = 0, sl_m = 0, sl_l = 0, sl_df = 0;
        Class_Control control = new Class_Control();

        public Form_Chon_co()
        {
            InitializeComponent();
        }

        public Form_Chon_co(string _MaMonAn)
        {
            InitializeComponent();
            MaMonAn = _MaMonAn;

        }
        public Form_Chon_co(int _mode,SqlDataReader _reader, string _MaMonAn)
        {
            InitializeComponent();
            mode = _mode;
            reader = _reader;
            MaMonAn = _MaMonAn;
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            control.xoamon(MaMonAn, "S");
            control.xoamon(MaMonAn, "M");
            control.xoamon(MaMonAn, "L");
            control.xoamon(MaMonAn, "DF");
            button_chon_Click(sender, e);
        }



        private void button_chon_Click(object sender, EventArgs e)
        {
            float SoLuong;
           
            if (checkBox_Co_S.Checked)
            {
                SoLuong = float.Parse(textBox_SL_S.Text);
                control.datmon(MaMonAn, "S", SoLuong);
            }
            if (checkBox_CO_M.Checked)
            {
                SoLuong = float.Parse(textBox_SL_M.Text);
                control.datmon(MaMonAn, "M", SoLuong);
            }
            if (checkBox_L.Checked)
            {
                SoLuong = float.Parse(textBox_SL_L.Text);
                control.datmon(MaMonAn, "L", SoLuong);
            }
            if (checkBox_DF.Checked)
            {
                SoLuong = float.Parse(textBox_SL_DF.Text);
                control.datmon(MaMonAn, "DF", SoLuong);
            }
            this.Close();

        }

        private void Form_Chon_co_Load(object sender, EventArgs e)
        {
            if (mode == 1)
            {
                button_chon.Visible = false;
                button_Sua.Visible = true;
                do
                {
                    string kichCo = reader["Kich co"].ToString();
                    float soLuong = float.Parse(reader["So luong"].ToString());
                    switch (kichCo)
                    {
                        case "S":
                            checkBox_Co_S.Checked = true;

                            textBox_SL_S.Text = soLuong.ToString();
                            break;
                        case "M":
                            checkBox_CO_M.Checked = true;

                            textBox_SL_M.Text = soLuong.ToString();
                            break;
                        case "L":
                            checkBox_L.Checked = true;

                            textBox_SL_L.Text = soLuong.ToString();
                            break;
                        case "DF":
                            checkBox_DF.Checked = true;

                            textBox_SL_DF.Text = soLuong.ToString();
                            break;
                    }
                }
                while (reader.Read());
            }
            

            if (control.ktraKichCoTonTai(MaMonAn, "S"))
            {
                checkBox_Co_S.Enabled = true; 
                textBox_SL_S.Enabled = true;
            }
            if (control.ktraKichCoTonTai(MaMonAn, "M"))
            {
                checkBox_CO_M.Enabled = true;
                textBox_SL_M.Enabled = true;
            }
            if (control.ktraKichCoTonTai(MaMonAn, "L"))
            {
                checkBox_L.Enabled = true;
                textBox_SL_L.Enabled = true;
            }
            if (control.ktraKichCoTonTai(MaMonAn, "DF"))
            {
                checkBox_DF.Enabled = true;
                textBox_SL_DF.Enabled = true;
            }

        }
    }
}

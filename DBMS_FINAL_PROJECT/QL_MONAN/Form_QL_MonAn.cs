using DBMS_FINAL_PROJECT.Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DBMS_FINAL_PROJECT.QL_MONAN
{
    public partial class Form_QL_MonAn : Form
    {
        public Form_QL_MonAn()
        {
            InitializeComponent();
        }

         private void Form_QL_MonAn_Load(object sender, EventArgs e)
        {
            myDB con = new myDB();
            con.openConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM View_Thuc_don ORDER BY [Ma loai] ASC, [Ma mon an] ASC, CASE [Kich co] WHEN 'S' THEN 1 WHEN 'M' THEN 2 WHEN 'L' THEN 3 WHEN 'DF' THEN 4 ELSE 5 END", con.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView_DS_mon_an.DataSource = dataTable;
            con.closeConnection();
        }

        public void fillData(SqlDataReader reader)
        {
            comboBox_loai_mon.Text = reader["Loai mon an"].ToString();
            textBox_Ten_mon_an.Text = reader["Ten mon an"].ToString();
            textBox_ma_loai_mon_an.Text = reader["Ma loai"].ToString();
            textBox_ma_mon_an.Text = reader["Ma mon an"].ToString();

            do
            {
                string kichCo = reader["Kich co"].ToString();
                float donGia = float.Parse(reader["Don gia"].ToString());

                switch (kichCo)
                {
                    case "S":
                        checkBox_Co_S.Checked = true;

                        textBox_gia_S.Text = donGia.ToString();
                        break;
                    case "M":
                        checkBox_CO_M.Checked = true;

                        textBox_gia_M.Text = donGia.ToString();
                        break;
                    case "L":
                        checkBox_L.Checked = true;

                        textBox_gia_L.Text = donGia.ToString();
                        break;
                    case "DF":
                        checkBox_Size_DF.Checked = true;

                        textBox_size_DF.Text = donGia.ToString();
                        break;
                }
            }
            while (reader.Read());
            /*switch (reader["Kich co"].ToString())

            {
                case "S":
                    checkBox_Co_S.Checked = true;
                    checkBox_CO_M.Checked = false;
                    checkBox_L.Checked = false;
                    checkBox_Size_DF.Checked = false;

                    *//*textBox_gia_L.Enabled = false;
                    textBox_gia_M.Enabled = false;
                    textBox_gia_S.Enabled = true;
                    textBox_size_DF .Enabled = false;*//*

                    textBox_gia_S.Text = reader["Don gia"].ToString();
                    textBox_gia_M.Text = "";
                    textBox_gia_L.Text = "";
                    textBox_size_DF.Text = "";

                    comboBox_loai_mon.Text= reader["Loai mon an"].ToString() ;
                    textBox_Ten_mon_an.Text = reader["Ten mon an"].ToString();
                    textBox_ma_loai_mon_an.Text = reader["Ma loai"].ToString();
                    textBox_ma_mon_an.Text = reader["Ma mon an"].ToString();*//*
                    break;
                case "M":
                    checkBox_Co_S.Checked = false;
                    checkBox_CO_M.Checked = true;
                    checkBox_L.Checked = false;
                    checkBox_Size_DF.Checked = false;

                    *//*textBox_gia_L.Enabled = false;
                    textBox_gia_M.Enabled = true;
                    textBox_gia_S.Enabled = false;
                    textBox_size_DF.Enabled = false;*//*

                    textBox_gia_S.Text = "";
                    textBox_gia_M.Text = reader["Don gia"].ToString();
                    textBox_gia_L.Text = "";
                    textBox_size_DF.Text = "";

                    comboBox_loai_mon.Text = reader["Loai mon an"].ToString();
                    textBox_Ten_mon_an.Text = reader["Ten mon an"].ToString();
                    textBox_ma_loai_mon_an.Text = reader["Ma loai"].ToString();
                    textBox_ma_mon_an.Text = reader["Ma mon an"].ToString();*//*
                    break;
                case "L":
                    checkBox_Co_S.Checked = false;
                    checkBox_CO_M.Checked = false;
                    checkBox_L.Checked = true;
                    checkBox_Size_DF.Checked = false;

                    *//*textBox_gia_L.Enabled = true;
                    textBox_gia_M.Enabled = false;
                    textBox_gia_S.Enabled = false;
                    textBox_size_DF.Enabled = false;*//*

                    textBox_gia_S.Text = "";
                    textBox_gia_M.Text = "";
                    textBox_gia_L.Text = reader["Don gia"].ToString();
                    textBox_size_DF.Text = "";

                    comboBox_loai_mon.Text = reader["Loai mon an"].ToString();
                    textBox_Ten_mon_an.Text = reader["Ten mon an"].ToString();
                    textBox_ma_loai_mon_an.Text = reader["Ma loai"].ToString();
                    textBox_ma_mon_an.Text = reader["Ma mon an"].ToString();*//*
                    break;
                case "DF":
                    checkBox_Co_S.Checked = false;
                    checkBox_CO_M.Checked = false;
                    checkBox_L.Checked = false;
                    checkBox_Size_DF.Checked = true;

                    *//*textBox_gia_L.Enabled = false;
                    textBox_gia_M.Enabled = false;
                    textBox_gia_S.Enabled = false;
                    textBox_size_DF.Enabled = true;*//*

                    textBox_gia_S.Text = "";
                    textBox_gia_M.Text = "";
                    textBox_gia_L.Text = "";
                    textBox_size_DF.Text = reader["Don gia"].ToString();

                    comboBox_loai_mon.Text = reader["Loai mon an"].ToString();
                    textBox_Ten_mon_an.Text = reader["Ten mon an"].ToString();
                    textBox_ma_loai_mon_an.Text = reader["Ma loai"].ToString();
                    textBox_ma_mon_an.Text = reader["Ma mon an"].ToString();*//*
                    break;
            }*/
        }

        private void dataGridView_DS_mon_an_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string maMonAn = dataGridView_DS_mon_an.CurrentRow.Cells["Ma mon an"].Value.ToString();

            myDB con = new myDB();
            con.openConnection();

            SqlCommand cmd = new SqlCommand("SELECT * FROM View_Thuc_don WHERE [Ma mon an] = @maMonAn", con.getConnection);
            cmd.Parameters.AddWithValue("@maMonAn", maMonAn);

            SqlDataReader reader = cmd.ExecuteReader();

            checkBox_Co_S.Checked = false;
            checkBox_CO_M.Checked = false;
            checkBox_L.Checked = false;
            checkBox_Size_DF.Checked = false;

            textBox_gia_S.Text = "";
            textBox_gia_M.Text = "";
            textBox_gia_L.Text = "";
            textBox_size_DF.Text = "";
            reader.Read();
            fillData(reader);
            con.closeConnection();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Class_Control control = new Class_Control();
            // Check if id already exists
            if (!control.ktraIDTontai(textBox_ma_mon_an.Text))
            {
                control.themMonAnMoi(textBox_Ten_mon_an.Text, textBox_ma_loai_mon_an.Text);
                string maMonAnMoi = control.themMonAnMoi(textBox_Ten_mon_an.Text, textBox_ma_loai_mon_an.Text);

                if (checkBox_Co_S.Checked == true)
                {
                    control.themKichCo(maMonAnMoi, "S", float.Parse(textBox_gia_S.Text));
                }
                if (checkBox_CO_M.Checked == true)
                {
                    control.themKichCo(maMonAnMoi, "M", float.Parse(textBox_gia_M.Text));
                }
                if (checkBox_L.Checked == true)
                {
                    control.themKichCo(maMonAnMoi, "L", float.Parse(textBox_gia_L.Text));
                }
                if (checkBox_Size_DF.Checked == true)
                {
                    control.themKichCo(maMonAnMoi, "DF", float.Parse(textBox_size_DF.Text));
                }
            }
            else
                MessageBox.Show("Mã món ăn tồn tại");
        }

        private void button_UPDATE_Click(object sender, EventArgs e)
        {
            Class_Control control = new Class_Control();
            // Check if id already exists
            if (!control.ktraIDTontai(textBox_ma_mon_an.Text))
            {
                if (checkBox_Co_S.Checked == true)
                {
                    control.capnhatMonAn(textBox_ma_mon_an.Text, textBox_Ten_mon_an.Text, textBox_ma_loai_mon_an.Text, "S", float.Parse(textBox_gia_S.Text));
                }
                if (checkBox_CO_M.Checked == true)
                {
                    control.capnhatMonAn(textBox_ma_mon_an.Text, textBox_Ten_mon_an.Text, textBox_ma_loai_mon_an.Text, "M", float.Parse(textBox_gia_M.Text));
                }
                if (checkBox_L.Checked == true)
                {
                    control.capnhatMonAn(textBox_ma_mon_an.Text, textBox_Ten_mon_an.Text, textBox_ma_loai_mon_an.Text, "L", float.Parse(textBox_gia_L.Text));
                }
                if (checkBox_Size_DF.Checked == true)
                {
                    control.capnhatMonAn(textBox_ma_mon_an.Text, textBox_Ten_mon_an.Text, textBox_ma_loai_mon_an.Text, "DF", float.Parse(textBox_size_DF.Text));
                }
            }
        }

        private void button_remove_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_loai_mon_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_loai_mon.SelectedItem.ToString())
            {
                case "Ga ran":
                    textBox_ma_loai_mon_an.Text = "LMA001";
                    break;
                case "Burger":
                    textBox_ma_loai_mon_an.Text = "LMA002";
                    break;
                case "Mon mi":
                    textBox_ma_loai_mon_an.Text = "LMA003";
                    break;
                case "Mon com":
                    textBox_ma_loai_mon_an.Text = "LMA004";
                    break;
                case "Trang mieng":
                    textBox_ma_loai_mon_an.Text = "LMA005";
                    break;
                case "Nuoc uong":
                    textBox_ma_loai_mon_an.Text = "LMA006";
                    break;
            }
        }

        private void textBox_gia_S_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_gia_M_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_gia_L_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_size_DF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            Form_QL_MonAn_Load(sender, e);
        }
    }
}

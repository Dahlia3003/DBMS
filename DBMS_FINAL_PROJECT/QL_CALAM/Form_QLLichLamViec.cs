using DBMS_FINAL_PROJECT.Connection;
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

namespace DBMS_FINAL_PROJECT.QL_CALAM
{
    public partial class Form_QLLichLamViec : Form
    {   
        public Form_QLLichLamViec()
        {
            InitializeComponent();
        }

        myDB con = new myDB();  

        private void Form_QLLichLamViec_Load(object sender, EventArgs e)
        {
            con.openConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM View_Chi_tiet_ca_lam", con.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView_Lich_lam_viec.DataSource = dataTable;
            con.closeConnection();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            con.openConnection();
            string query = "SELECT * FROM View_Chi_tiet_ca_lam WHERE 1=1 ";
            if (!string.IsNullOrEmpty(comboBox_Nam.Text))
            {
                query += "AND YEAR(Gio_vao_ca_cua_nhan_vien) = '" + comboBox_Nam.Text + "' ";
            }
            if (!string.IsNullOrEmpty(comboBox_Thang.Text))
            {
                query += "AND MONTH(Gio_vao_ca_cua_nhan_vien) = '" + comboBox_Thang.Text + "' ";
            }
            if (!string.IsNullOrEmpty(texBox_Ngay.Text))
            {
                query += "AND DAY(Gio_vao_ca_cua_nhan_vien) = '" + texBox_Ngay.Text + "' ";
            }
            SqlCommand command = new SqlCommand(query, con.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView_Lich_lam_viec.DataSource = dataTable;
            con.closeConnection();
        }

        private void button_XoaLoc_Click(object sender, EventArgs e)
        {
            comboBox_Nam.SelectedIndex = -1;
            comboBox_Thang.SelectedIndex = -1;
            texBox_Ngay.Text = "";
            button_search.PerformClick();
        }
    }
}

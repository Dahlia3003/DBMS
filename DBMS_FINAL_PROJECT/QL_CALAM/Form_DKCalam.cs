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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBMS_FINAL_PROJECT.QL_CALAM
{
    public partial class Form_DKCalam : Form
    {
        public Form_DKCalam()
        {
            InitializeComponent();
        }

        myDB con = new myDB();

        private void Form_DKCalam_Load(object sender, EventArgs e)
        {
            con.openConnection();

            SqlCommand command_controng = new SqlCommand("SELECT * FROM View_Ca_lam_theo_tuan WHERE Ma_nhan_vien IS NULL ", con.getConnection);
            SqlDataAdapter adapter_controng = new SqlDataAdapter(command_controng);
            DataTable dataTable_controng = new DataTable();
            adapter_controng.Fill(dataTable_controng);
            dataGridView_Ca_lam_con_trong.DataSource = dataTable_controng;

            SqlCommand command_dadangky = new SqlCommand("SELECT * FROM View_Ca_lam_theo_tuan WHERE Ma_nhan_vien = @MaNV  ", con.getConnection);
            command_dadangky.Parameters.AddWithValue("@MaNV", Program.MaNV);
            SqlDataAdapter adapter_dadangky = new SqlDataAdapter(command_dadangky);
            DataTable dataTable_dadangky = new DataTable();
            adapter_dadangky.Fill(dataTable_dadangky);
            dataGridView_Ca_lam_da_dang_ky.DataSource = dataTable_dadangky;

            con.closeConnection();
        }

        private void buttok_Dang_ky_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView_Ca_lam_con_trong.CurrentRow != null)
                {
                    // Lấy thông tin về ca làm từ DataGridView chưa đăng ký
                    string maCaLam = dataGridView_Ca_lam_con_trong.CurrentRow.Cells["Ma_ca_lam"].Value.ToString();

                    // Gọi stored procedure để thêm mới ca làm vào cơ sở dữ liệu
                    con.openConnection();
                    SqlCommand cmd = new SqlCommand("Them_chi_tiet_ca_lam", con.getConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ma_ca_lam", maCaLam);
                    cmd.Parameters.AddWithValue("@ma_nhan_vien", Program.MaNV);
                    cmd.ExecuteNonQuery();
                    con.closeConnection();
                    Form_DKCalam_Load(sender, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("Không có dòng được chọn");
                }
     
            }
            catch
            {
                MessageBox.Show("Đăng ký không thành công");
            }
        }

        private void button_Xoa_ca_da_dang_ky_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView_Ca_lam_da_dang_ky.CurrentRow != null)
                {
                    // Lấy thông tin về ca làm từ DataGridView đã đăng ký
                    string maCaLam = dataGridView_Ca_lam_da_dang_ky.CurrentRow.Cells["Ma_ca_lam"].Value.ToString();

                    // Gọi stored procedure để thêm mới ca làm vào cơ sở dữ liệu
                    con.openConnection();
                    SqlCommand cmd = new SqlCommand("Xoa_chi_tiet_ca_lam", con.getConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ma_ca_lam", maCaLam);
                    cmd.Parameters.AddWithValue("@ma_nhan_vien", Program.MaNV);
                    cmd.ExecuteNonQuery();
                    con.closeConnection();
                    Form_DKCalam_Load(sender, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("Không có dòng được chọn");
                }
            }
            catch
            {
                MessageBox.Show("Xóa không thành công");
            }
        }
    }
}

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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DBMS_FINAL_PROJECT.QL_MONAN.Goi_mon
{
    public partial class Form_goi_mon : Form
    {
        myDB con =new myDB();
        public Form_goi_mon()
        {
            InitializeComponent();
        }

        private void Form_goi_mon_Load(object sender, EventArgs e)
        {
            Class_Control control = new Class_Control();
            
            con.openConnection();

            SqlCommand command_thucdon = new SqlCommand("Select DISTINCT [Ma mon an], [Loai mon an], [Ten mon an] from View_Thuc_don ", con.getConnection);
            SqlDataAdapter adapter_thucdon = new SqlDataAdapter(command_thucdon);
            DataTable dataTable_thucdon = new DataTable();
            adapter_thucdon.Fill(dataTable_thucdon);
            dataGridView_ds_mon.DataSource = dataTable_thucdon;

            SqlCommand command_mondachon = new SqlCommand("SELECT * FROM View_Mon_an_Kich_co_Don_gia_So_luong", con.getConnection);
            SqlDataAdapter adapter_mondachon = new SqlDataAdapter(command_mondachon);
            DataTable dataTable_mondachon = new DataTable();
            adapter_mondachon.Fill(dataTable_mondachon);
            dataGridView_mon_da_chon.DataSource = dataTable_mondachon;

        }

        private void dataGridView_ds_mon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string maMonAn = dataGridView_ds_mon.CurrentRow.Cells["Ma mon an"].Value.ToString();

            Form_Chon_co form_Chon_Co = new Form_Chon_co(maMonAn);
            form_Chon_Co.ShowDialog();

            Form_goi_mon_Load(sender, e);

        }

        private void button_Chinh_sua_Click(object sender, EventArgs e)
        {
            Form_Chon_co form_Chon_Co = new Form_Chon_co();

        }

        private void dataGridView_mon_da_chon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string maMonAn = dataGridView_mon_da_chon.CurrentRow.Cells["Ma mon an"].Value.ToString();
            con.openConnection();

            SqlCommand cmd = new SqlCommand("SELECT * FROM View_Mon_an_Kich_co_Don_gia_So_luong WHERE [Ma mon an] = @maMonAn", con.getConnection);
            cmd.Parameters.AddWithValue("@maMonAn", maMonAn);

            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            Form_Chon_co form_Chon_Co = new Form_Chon_co(1,reader, maMonAn);
            form_Chon_Co.ShowDialog();

            con.closeConnection();
            Form_goi_mon_Load(sender, e);

        }

        private void button_Loc_Click(object sender, EventArgs e)
        {
            con.openConnection();
            string query = "Select DISTINCT [Ma mon an], [Loai mon an], [Ten mon an] from View_Thuc_don WHERE 1=1 ";
            if (!string.IsNullOrEmpty(comboBox_loai_mon.Text))
            {
                query += "AND [Loai mon an] = '" + comboBox_loai_mon.Text + "' ";
            }
            SqlCommand command = new SqlCommand(query, con.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView_ds_mon.DataSource = dataTable;
            con.closeConnection();
        }

        private void button_xoaLoc_Click(object sender, EventArgs e)
        {
            comboBox_loai_mon.SelectedIndex = -1;
            button_Loc_Click(sender, e);
        }

        private void button_XuatHoaDon_Click(object sender, EventArgs e)
        {

        }
    }
}

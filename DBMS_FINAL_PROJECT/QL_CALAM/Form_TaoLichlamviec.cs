using DBMS_FINAL_PROJECT.QL_CALAM.CALL_CONTROL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_FINAL_PROJECT.QL_CALAM
{
    public partial class Form_TaoLichlamviec : Form
    {
        public Form_TaoLichlamviec()
        {
            InitializeComponent();
        }


        private void comboBox_buoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy giá trị được chọn từ ComboBox
            string buoiLam = comboBox_buoi.SelectedItem.ToString().Trim();
            // Sáng lên các DateTimePicker tương ứng với buổi làm
            switch (buoiLam)
            {
                case "Sáng":
                    dateTimePicker_sang_tu.Enabled = true;
                    dateTimePicker_sang_den.Enabled = true;
                    dateTimePicker_chieu_tu.Enabled = false;
                    dateTimePicker_chieu_den.Enabled = false;
                    dateTimePicker_toi_tu.Enabled = false;
                    dateTimePicker_Toi_den.Enabled = false;
                    break;
                case "Chiều":
                    dateTimePicker_sang_tu.Enabled = false;
                    dateTimePicker_sang_den.Enabled = false;
                    dateTimePicker_chieu_tu.Enabled = true;
                    dateTimePicker_chieu_den.Enabled = true;
                    dateTimePicker_toi_tu.Enabled = false;
                    dateTimePicker_Toi_den.Enabled = false;
                    break;
                case "Tối":
                    dateTimePicker_sang_tu.Enabled = false;
                    dateTimePicker_sang_den.Enabled =false;
                    dateTimePicker_chieu_tu.Enabled = false;
                    dateTimePicker_chieu_den.Enabled = false;
                    dateTimePicker_toi_tu.Enabled = true;
                    dateTimePicker_Toi_den.Enabled = true;
                    break;
            }
        }

        private void button_Tao_Click(object sender, EventArgs e)
        {
            Class_Control control = new Class_Control();
            string buoiLam = comboBox_buoi.Text;
            switch (comboBox_buoi.SelectedItem.ToString())
            {
                case "Sáng":
                    buoiLam = "SA";
                    control.Taolichlamviec_Tao(dateTimePicker_ngay_tu.Value, dateTimePicker_ngay_den.Value, buoiLam, dateTimePicker_sang_tu.Value, dateTimePicker_sang_den.Value);
                    MessageBox.Show("Đã khởi tạo"); 
                    break;
                case "Chiều":
                    buoiLam = "CH";
                    control.Taolichlamviec_Tao(dateTimePicker_ngay_tu.Value, dateTimePicker_ngay_den.Value, buoiLam, dateTimePicker_chieu_tu.Value, dateTimePicker_chieu_den.Value);
                    MessageBox.Show("Đã khởi tạo");
                    break;
                case "Tối":
                    buoiLam = "TO";
                    control.Taolichlamviec_Tao(dateTimePicker_ngay_tu.Value, dateTimePicker_ngay_den.Value, buoiLam, dateTimePicker_toi_tu.Value, dateTimePicker_Toi_den.Value);
                    MessageBox.Show("Đã khởi tạo");
                    break;
                default:
                    MessageBox.Show("Khởi tạo thất bại");
                    break;
            }
                        


        }
    }
}

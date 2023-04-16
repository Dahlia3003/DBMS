using DBMS_FINAL_PROJECT.QL_CALAM.CALL_CONTROL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_FINAL_PROJECT.QL_CALAM
{
    public partial class Form_ChitietCalam : Form
    {
        public Form_ChitietCalam()
        {
            InitializeComponent();
        }

        private void button_Vao_ca_Click(object sender, EventArgs e)
        {
            if(textBox_Tien_ket_vao_ca.Text!="")
            {
                textBox_Gio_vao_ca.Text = DateTime.Now.ToString();

                DialogResult result = MessageBox.Show("Bạn có muốn tiếp tục?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //ktra ma ca lam theo gio thuc hien click button
                    Class_Control procedure_ktraCa = new Class_Control();
                    Program.MaCalam = procedure_ktraCa.KiemtraMaCalam();
                    if (Program.MaCalam != null)
                    {
                        Class_Control procedure_vaoca = new Class_Control();
                        try
                        {
                            procedure_vaoca.ChitietNhanvien_vaolam(DateTime.Now, float.Parse(textBox_Tien_ket_vao_ca.Text), Program.MaCalam, Program.MaNV);
                        }
                        catch
                        {
                            MessageBox.Show("Lỗi hệ thống, chưa thể chấm công!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể chấm công, ngoài giờ làm việc");
                    }


                }
            }
            else
            {
                MessageBox.Show("Nhập tiền vào ca");
            }
        }

        private void button_ra_ca_Click(object sender, EventArgs e)
        {
            textBox_Gio_ra_ca.Text = DateTime.Now.ToString();

            if(textBox_Tien_ket_ra_ca.Text!= "")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn tiếp tục?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Class_Control procedure_raca = new Class_Control();
                    try
                    {
                        procedure_raca.ChitietNhanvien_vaolam(DateTime.Now, float.Parse(textBox_Tien_ket_vao_ca.Text), Program.MaCalam, Program.MaNV);
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi hệ thống, chưa thể chấm công!");
                    }
                }
                else
                {
                    // Thực hiện công việc nếu người dùng chọn No
                }
            }
            else
            {
                MessageBox.Show("Nhập tiền kết ca");

            }
        }
    }
}

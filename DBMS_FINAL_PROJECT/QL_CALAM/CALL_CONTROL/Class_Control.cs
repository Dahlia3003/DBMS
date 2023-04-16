using DBMS_FINAL_PROJECT.Connection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_FINAL_PROJECT.QL_CALAM.CALL_CONTROL
{
    public class Class_Control
    {
        myDB con = new myDB();
        
        public void ChitietNhanvien_vaolam(DateTime gioVaoCa, float tienKetVaoCa, string maCaLam, string maNhanVien)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("Them_Chi_tiet_vao_ca_lam", con.getConnection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Gio_vao_ca_cua_nhan_vien", gioVaoCa);
                    command.Parameters.AddWithValue("@Tien_ket_vao_ca", tienKetVaoCa);
                    command.Parameters.AddWithValue("@Ma_ca_lam", maCaLam);
                    command.Parameters.AddWithValue("@Ma_nhan_vien", maNhanVien);

                    con.openConnection();

                    int result = command.ExecuteNonQuery(); // Thực thi procedure và lấy số bản ghi bị ảnh hưởng (nếu có)

                    con.closeConnection();
                }
            } 
            catch 
            {
                MessageBox.Show("Lỗi kết nối!!");
            }

        }

        public void ChitietNhanvien_ralam(DateTime gioKetCa, float tienKetKetCa, string maCaLam, string maNhanVien)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("Them_Chi_tiet_ket_ca_lam", con.getConnection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Gio_vao_ca_cua_nhan_vien", gioKetCa);
                    command.Parameters.AddWithValue("@Tien_ket_vao_ca", tienKetKetCa);
                    command.Parameters.AddWithValue("@Ma_ca_lam", maCaLam);
                    command.Parameters.AddWithValue("@Ma_nhan_vien", maNhanVien);

                    con.openConnection();

                    int result = command.ExecuteNonQuery(); // Thực thi procedure và lấy số bản ghi bị ảnh hưởng (nếu có)

                    con.closeConnection();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối!!");
            }

        }

        public string KiemtraMaCalam()
        {
            con.openConnection();
            using (SqlCommand command = new SqlCommand("SELECT dbo.KiemTraGioLamViec()", con.getConnection))
            {
                object result = command.ExecuteScalar();
                con.closeConnection();
                if (result != null && result != DBNull.Value)
                {
                    string maCaLam = (string)result;
                    return maCaLam;
                }
                else
                {
                    MessageBox.Show("Đang ngoài giờ làm việc");
                    return null;
                }
            }
            
        }

        public void Taolichlamviec_Tao(DateTime tuNgay, DateTime denNgay, string buoi, DateTime tuGio, DateTime denGio)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("Them_Ca_Lam", con.getConnection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@TuNgay", tuNgay);
                    command.Parameters.AddWithValue("@DenNgay", denNgay);
                    command.Parameters.AddWithValue("@Buoi", buoi);
                    command.Parameters.AddWithValue("@TuGio", tuGio);
                    command.Parameters.AddWithValue("@DenGio", denGio);


                    con.openConnection();

                    int result = command.ExecuteNonQuery(); // Thực thi procedure và lấy số bản ghi bị ảnh hưởng (nếu có)

                    con.closeConnection();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối!!");
            }
        }

}
}

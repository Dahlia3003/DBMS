using DBMS_FINAL_PROJECT.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_FINAL_PROJECT.QL_MONAN
{
    public class Class_Control
    {
        public string themMonAnMoi(string TenMonAn, string MaLoaiMonAn)
        {
            string maMonAn = "";
            myDB con = new myDB();
            con.openConnection();
            SqlCommand cmd = new SqlCommand("sp_Tao_Mon_An", con.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Ten_mon_an", TenMonAn);
            cmd.Parameters.AddWithValue("@Ma_loai_mon_an", MaLoaiMonAn);
            cmd.ExecuteNonQuery();
            

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    maMonAn = reader.GetString(0);
                }
            }
            con.closeConnection();
            return maMonAn;
        }       

        public void themKichCo(string MaMonAn,string KichCo, float DonGia)
        {
            myDB con = new myDB();
            con.openConnection();
            SqlCommand cmd = new SqlCommand("sp_Them_Kich_Co_Cho_Mon_An", con.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Ma_mon_an", MaMonAn);
            cmd.Parameters.AddWithValue("@Kich_co", KichCo);
            cmd.Parameters.AddWithValue("@Don_gia", DonGia);
            cmd.ExecuteNonQuery();
            con.closeConnection();
        }

        public bool ktraIDTontai(string maMonAN)
        {
            myDB db = new myDB();
            string query = "SELECT COUNT(*) FROM View_Thuc_don WHERE [Ma mon an] = @maMonAn";
            SqlCommand command = new SqlCommand(query, db.getConnection);
            command.Parameters.AddWithValue("@maMonAn", maMonAN );

            db.openConnection();
            int count = (int)command.ExecuteScalar();
            db.closeConnection();

            if (count > 0)
            {
                return true;
            }
            else return false;
        }

        public void capnhatMonAn(string MaMonAn, string TenMonAn, string MaLoaiMon, string KichCo, float DonGia)
        {
            myDB con = new myDB();
            con.openConnection();
            SqlCommand cmd = new SqlCommand("UpdateMonAn", con.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Ma_mon_an", MaMonAn);
            cmd.Parameters.AddWithValue("@Ten_mon_an", TenMonAn);
            cmd.Parameters.AddWithValue("@Ma_loai_mon_an", MaLoaiMon);
            cmd.Parameters.AddWithValue("@Kich_co", KichCo);
            cmd.Parameters.AddWithValue("@Don_gia", DonGia);
            cmd.ExecuteNonQuery();
            con.closeConnection();
        }

        public void datmon(string MaMonAn, string KichCo, float SoLuong)
        {
            myDB con = new myDB();
            con.openConnection();
            SqlCommand cmd = new SqlCommand("InsertChiTietHoaDon", con.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaMonAn", MaMonAn);
            cmd.Parameters.AddWithValue("@KichCo", KichCo);
            cmd.Parameters.AddWithValue("@SoLuong", SoLuong);
            cmd.ExecuteNonQuery();
            con.closeConnection();
        }

        public void xoamon(string MaMonAn, string KichCo)
        {
            myDB con = new myDB();
            con.openConnection();
            SqlCommand cmd = new SqlCommand("DeleteChiTietHoaDon", con.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaMonAn", MaMonAn);
            cmd.Parameters.AddWithValue("@KichCo", KichCo);
            cmd.ExecuteNonQuery();
            con.closeConnection();
        }

        public void xoaTMP()
        {
            myDB con = new myDB();
            con.openConnection();
            SqlCommand cmd = new SqlCommand("XoaHoaDonTMP", con.getConnection);
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.ExecuteReader();
            con.closeConnection();
        }

        public bool ktraKichCoTonTai(string MaMonAn, string KichCo)
        {
            myDB db = new myDB();
            string query = "SELECT COUNT(*) FROM View_Thuc_don WHERE [Ma mon an] = @maMonAn AND [Kich co] = @kichCo";
            SqlCommand command = new SqlCommand(query, db.getConnection);
            command.Parameters.AddWithValue("@maMonAn", MaMonAn);
            command.Parameters.AddWithValue("@kichCo", KichCo);

            db.openConnection();
            int count = (int)command.ExecuteScalar();
            db.closeConnection();

            if (count > 0)
            {
                return true;
            }
            else return false;
        }
    }
}

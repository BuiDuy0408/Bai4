using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BusinessLogic
{
    public class KetNoiDB
    {
        SqlConnection cn = new SqlConnection();
        static public String getconnect()
        {
            return (@"Data Source=NHOXHOANGANH\SQLEXPRESS;Initial Catalog=QL_KhoHang;Integrated Security=True");
        }
        public DataTable ShowNCC(string DieuKien)
        {
            string sql = @"SELECT * FROM NHACUNGCAP " + DieuKien;
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            ad.Fill(dt);
            return dt;
        }
        public void InsertNCC(string _TenNCC, string _DiaChi, string _SDT)
        {
            string sql = "ThemNCC";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@tenlh", _TenNCC);
            cmd.Parameters.AddWithValue("@diachi", _DiaChi);
            cmd.Parameters.AddWithValue("@sdt", _SDT);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }
        public void UpdateNCC(string _MaNCC, string _TenNCC, string _DiaChi, string _SDT)
        {
            string sql = "SuaNCC";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@mancc", _MaNCC);
            cmd.Parameters.AddWithValue("@tenncc", _TenNCC);
            cmd.Parameters.AddWithValue("@diachi", _DiaChi);
            cmd.Parameters.AddWithValue("@sdt", _SDT);


            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }
        public void DeleteNCC(string _MaNCC)
        {
            string sql = "XoaNCC";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@mancc", _MaNCC);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
    }
}

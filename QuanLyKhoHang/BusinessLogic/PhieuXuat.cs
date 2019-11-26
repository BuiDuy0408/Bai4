using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogic
{
    public class PhieuXuat
    {
        KetNoiDB kn = new KetNoiDB();

        public DataTable ShowPX(string DieuKien)
        {
            string sql = @"SELECT MaPX, MaCN, NgayXuat FROM PHIEUXUAT " + DieuKien;
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            ad.Fill(dt);
            return dt;
        }

        public void addTien(string MaPX)
        {
            string sql = "TienXuat";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaPX", MaPX);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        public DataTable HT_CTPX(string ngay1, string ngay2)
        {
            string str = "HT_TK_CTPX";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Ngay1", DateTime.Parse(ngay1));
            cmd.Parameters.AddWithValue("@Ngay2", DateTime.Parse(ngay2));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public DataTable HT_PX(string ngay1, string ngay2)
        {
            string str = "TK_PX";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Ngay1", DateTime.Parse(ngay1));
            cmd.Parameters.AddWithValue("@Ngay2", DateTime.Parse(ngay2));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        
        
    }
}

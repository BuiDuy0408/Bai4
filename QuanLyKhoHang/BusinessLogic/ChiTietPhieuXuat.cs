using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogic
{
    public class ChiTietPhieuXuat
    {
        KetNoiDB kn = new KetNoiDB();

        public DataTable ShowCTPX(string DieuKien)
        {
            string sql = @"SELECT MaHH, SoLuong, DonGia, ThanhTien FROM CHITIETPHIEUXUAT " + DieuKien;
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            ad.Fill(dt);
            return dt;
        }

       
    }
}

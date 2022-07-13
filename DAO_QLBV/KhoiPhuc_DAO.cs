using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO_QLBV
{
    public class KhoiPhuc_DAO
    {
        static SqlConnection con;
        public static bool PhucHoi(string sDuongDan)
        {
            string sql = "USE MASTER ALTER DATABASE QLVTHH SET SINGLE_USER WITH ROLLBACK IMMEDIATE restore database QLVTHH from disk = N'" + sDuongDan + "' With Replace";

            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sql, con);
            return kq;
        }
    }
}

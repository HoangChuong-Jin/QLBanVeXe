using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using DTO_QLBV;

namespace DAO_QLBV
{
    public class NhomQuyen_DAO
    {
        static SqlConnection con;
        public static List<NhomQuyen_DTO> LayQuyen()
        {
            string sTruyVan = "select * from tbl_QUYEN";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NhomQuyen_DTO> lstNhomQuyen = new List<NhomQuyen_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhomQuyen_DTO q = new NhomQuyen_DTO();
                q.SMaQuyen = dt.Rows[i]["Ma_Q"].ToString();
                q.STenQuyen = dt.Rows[i]["Ten_Q"].ToString();

                lstNhomQuyen.Add(q);
            }
            DataProvider.DongKetNoi(con);
            return lstNhomQuyen;
        }

        public static string LayTenQuyenTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select tenquyen from tbl_QUYEN where Ma_Q=N'{0}'", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.DongKetNoi(con);
                return null;
            }

            DataProvider.DongKetNoi(con);
            return dt.Rows[0]["Ten_Q"].ToString();
        }
    }
}

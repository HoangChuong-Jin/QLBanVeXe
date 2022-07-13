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
    public class Xe_DAO
    {
        static SqlConnection con;
        //Lấy tất cả các xe
        public static List<Xe_DTO> LayDSXE()
        {
            string sTruyVan = "select * from tbl_XE";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Xe_DTO> lstXe = new List<DTO_QLBV.Xe_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Xe_DTO xe = new Xe_DTO();
                xe.SSo_Xe = dt.Rows[i]["So_Xe"].ToString();
                xe.STong_Ghe = int.Parse(dt.Rows[0]["TongSoGhe"].ToString());
                xe.STai_Xe = dt.Rows[i]["TaiXe"].ToString();
                xe.SPhu_Xe = dt.Rows[i]["PhuXe"].ToString();

                lstXe.Add(xe);
            }
            DataProvider.DongKetNoi(con);
            return lstXe;
        }

        public static List<Xe_DTO> LayDSXETK(string soxe, string taixe, string phuxe)
        {
            string sTruyVan = string.Format(@"select *
from tbl_XE
where So_Xe like '%{0}%' and TaiXe like N'%{1}%' and PhuXe like N'%{2}%'", soxe, taixe, phuxe);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Xe_DTO> lstXe = new List<DTO_QLBV.Xe_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Xe_DTO xe = new Xe_DTO();
                xe.SSo_Xe = dt.Rows[i]["So_Xe"].ToString();
                xe.STong_Ghe = int.Parse(dt.Rows[0]["TongSoGhe"].ToString());
                xe.STai_Xe = dt.Rows[i]["TaiXe"].ToString();
                xe.SPhu_Xe = dt.Rows[i]["PhuXe"].ToString();

                lstXe.Add(xe);
            }
            DataProvider.DongKetNoi(con);
            return lstXe;
        }
    }
}

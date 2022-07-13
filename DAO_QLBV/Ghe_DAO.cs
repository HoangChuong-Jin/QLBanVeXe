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
    public class Ghe_DAO
    {
        static SqlConnection con;

        // Lấy danh sách tất cả ghe
        public static List<Ghe_DTO> LayDSGhe()
        {
            string sTruyVan = "select * from tbl_GHE";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Ghe_DTO> lstGhe = new List<DTO_QLBV.Ghe_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Ghe_DTO ghe = new Ghe_DTO();
                ghe.SMa_Ghe = dt.Rows[i]["Ma_GHE"].ToString();
                //ghe.SSo_Ghe = dt.Rows[i]["So_ghe"].ToString();
                ghe.SSo_Ghe = int.Parse(dt.Rows[i]["So_ghe"].ToString());
                ghe.STrang_Thai = bool.Parse(dt.Rows[i]["Trang_Thai"].ToString());
                ghe.SSo_Xe = dt.Rows[i]["So_Xe"].ToString();

                lstGhe.Add(ghe);
            }
            DataProvider.DongKetNoi(con);
            return lstGhe;
        }

        // Lấy danh sách tất cả ghe của xe ?
        public static List<Ghe_DTO> TimGheCuaXe(string soxe)
        {
            string sTruyVan = string.Format(@"select * from tbl_GHE where So_Xe like '%{0}%'", soxe);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Ghe_DTO> lstGhe = new List<DTO_QLBV.Ghe_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Ghe_DTO ghe = new Ghe_DTO();
                ghe.SMa_Ghe = dt.Rows[i]["Ma_GHE"].ToString();
                //ghe.SSo_Ghe = dt.Rows[i]["So_ghe"].ToString();
                ghe.SSo_Ghe = int.Parse(dt.Rows[i]["So_ghe"].ToString());
                ghe.STrang_Thai = bool.Parse(dt.Rows[i]["Trang_Thai"].ToString());
                ghe.SSo_Xe = dt.Rows[i]["So_Xe"].ToString();

                lstGhe.Add(ghe);
            }
            DataProvider.DongKetNoi(con);
            return lstGhe;
        }


        // tìm ghế còn trống
        public static List<Ghe_DTO> TimGheTrong(string soxe)
        {
            string sTruyVan = string.Format(@"select * from tbl_GHE
where Trang_Thai=0 and So_Xe like '%{0}%'", soxe);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Ghe_DTO> lstGhe = new List<DTO_QLBV.Ghe_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Ghe_DTO ghe = new Ghe_DTO();
                ghe.SMa_Ghe = dt.Rows[i]["Ma_GHE"].ToString();
                //ghe.SSo_Ghe = dt.Rows[i]["So_ghe"].ToString();
                ghe.SSo_Ghe = int.Parse(dt.Rows[i]["So_ghe"].ToString());
                ghe.STrang_Thai = bool.Parse(dt.Rows[i]["Trang_Thai"].ToString());
                ghe.SSo_Xe = dt.Rows[i]["So_Xe"].ToString();

                lstGhe.Add(ghe);
            }
            DataProvider.DongKetNoi(con);
            return lstGhe;
        }

        /* update trang thái ghế */
        public static bool SuaTrangThaiGhe(Ghe_DTO g)
        {
            string sTruyVan = string.Format(@"update tbl_GHE 
set Trang_Thai = '{0}'
where MA_GHE = '{1}'"
, g.STrang_Thai, g.SMa_Ghe);

            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;

        }
    }
}

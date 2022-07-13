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
    public class Tuyen_DAO
    {
        static SqlConnection con;
        //Lấy tất cả các tuyến
        public static List<Tuyen_DTO> LayDSTuyen()
        {
            string sTruyVan = "select * from tbl_TUYEN";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Tuyen_DTO> lstTuyen = new List<DTO_QLBV.Tuyen_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Tuyen_DTO t = new Tuyen_DTO();
                t.SMa_T = dt.Rows[i]["Ma_T"].ToString();
                t.SDiaDiemDi = dt.Rows[i]["DiaDiemDi"].ToString();
                t.SDiaDiemDen = dt.Rows[i]["DiaDiemDen"].ToString();
                t.SNgaychay = DateTime.Parse(dt.Rows[i]["NgayChay"].ToString());
                t.SGiaGoc = float.Parse(dt.Rows[i]["GiaGoc"].ToString());
                t.SSo_Xe = dt.Rows[i]["So_Xe"].ToString();

                lstTuyen.Add(t);
            }
            DataProvider.DongKetNoi(con);
            return lstTuyen;
        }

        //Lấy tất cả các tuyến theo đi vs đến
        public static List<Tuyen_DTO> LayDSTuyenTK(string ddi, string dde)
        {
            string sTruyVan = string.Format(@"select *
from tbl_TUYEN t
where t.DiaDiemDi like N'%{0}%' and t.DiaDiemDen like N'%{1}%'", ddi, dde);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Tuyen_DTO> lstTuyen = new List<DTO_QLBV.Tuyen_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Tuyen_DTO t = new Tuyen_DTO();
                t.SMa_T = dt.Rows[i]["Ma_T"].ToString();
                t.SDiaDiemDi = dt.Rows[i]["DiaDiemDi"].ToString();
                t.SDiaDiemDen = dt.Rows[i]["DiaDiemDen"].ToString();
                t.SNgaychay = DateTime.Parse(dt.Rows[i]["NgayChay"].ToString());
                t.SGiaGoc = float.Parse(dt.Rows[i]["GiaGoc"].ToString());
                t.SSo_Xe = dt.Rows[i]["So_Xe"].ToString();

                lstTuyen.Add(t);
            }
            DataProvider.DongKetNoi(con);
            return lstTuyen;
        }

        //Lấy tất cả các tuyến theo đi, đến, mã
        public static List<Tuyen_DTO> LayDSTuyenTK2(string ma, string ddi, string dde)
        {
            string sTruyVan = string.Format(@"select *
from tbl_TUYEN t
where t.Ma_T like N'%{0}%' and t.DiaDiemDi like N'%{1}%' and t.DiaDiemDen like N'%{2}%'", ma, ddi, dde);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Tuyen_DTO> lstTuyen = new List<DTO_QLBV.Tuyen_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Tuyen_DTO t = new Tuyen_DTO();
                t.SMa_T = dt.Rows[i]["Ma_T"].ToString();
                t.SDiaDiemDi = dt.Rows[i]["DiaDiemDi"].ToString();
                t.SDiaDiemDen = dt.Rows[i]["DiaDiemDen"].ToString();
                t.SNgaychay = DateTime.Parse(dt.Rows[i]["NgayChay"].ToString());
                t.SGiaGoc = float.Parse(dt.Rows[i]["GiaGoc"].ToString());
                t.SSo_Xe = dt.Rows[i]["So_Xe"].ToString();

                lstTuyen.Add(t);
            }
            DataProvider.DongKetNoi(con);
            return lstTuyen;
        }
    }
}

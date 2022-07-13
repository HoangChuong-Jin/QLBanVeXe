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
    public class Ve_DAO
    {
        static SqlConnection con;
        //Lấy tất cả các Vé
        public static List<Ve_DTO> LayDSVe()
        {
            string sTruyVan = "select * from tbl_VE v, tbl_TUYEN t, tbl_GHE g, tbl_HANHKHACH k where v.ID_HK=k.ID_HK and v.Ma_T = t.Ma_T and g.MA_GHE = v.MA_GHE";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Ve_DTO> lstVe = new List<DTO_QLBV.Ve_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Ve_DTO ve = new Ve_DTO();
                ve.SMA_VE = dt.Rows[i]["MA_VE"].ToString();
                ve.SMA_GHE = dt.Rows[i]["MA_GHE"].ToString();
                ve.SSo_GHE = dt.Rows[i]["So_Ghe"].ToString();
                ve.SSo_Xe = dt.Rows[i]["So_Xe"].ToString();
                ve.SNgayBan = DateTime.Parse(dt.Rows[i]["NgayBan"].ToString());
                ve.SNoiBan = dt.Rows[i]["NoiBan"].ToString();
                ve.SID_HK = int.Parse(dt.Rows[i]["ID_HK"].ToString());
                ve.STen_HK = dt.Rows[i]["TenHK"].ToString();
                ve.SMa_T = dt.Rows[i]["Ma_T"].ToString();


                lstVe.Add(ve);
            }
            DataProvider.DongKetNoi(con);
            return lstVe;
        }

        //Lấy tất cả các Vé có ma và tên
        public static List<Ve_DTO> LayDSVeTK(string ma, string ten)
        {
            string sTruyVan = string.Format(@"select *
from tbl_VE v, tbl_HANHKHACH k, tbl_GHE g, tbl_TUYEN t
where v.ID_HK = k.ID_HK and v.MA_GHE=g.MA_GHE and v.Ma_T = t.Ma_T
and v.MA_VE like '%{0}%' and k.TenHK like N'%{1}%'", ma, ten);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Ve_DTO> lstVe = new List<DTO_QLBV.Ve_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Ve_DTO ve = new Ve_DTO();
                ve.SMA_VE = dt.Rows[i]["MA_VE"].ToString();
                ve.SMA_GHE = dt.Rows[i]["MA_GHE"].ToString();
                ve.SSo_GHE = dt.Rows[i]["So_Ghe"].ToString();
                ve.SSo_Xe = dt.Rows[i]["So_Xe"].ToString();
                ve.SNgayBan = DateTime.Parse(dt.Rows[i]["NgayBan"].ToString());
                ve.SNoiBan = dt.Rows[i]["NoiBan"].ToString();
                ve.SID_HK = int.Parse(dt.Rows[i]["ID_HK"].ToString());
                ve.STen_HK = dt.Rows[i]["TenHK"].ToString();
                ve.SMa_T = dt.Rows[i]["Ma_T"].ToString();
                ve.SID_HK = int.Parse(dt.Rows[i]["ID_HK"].ToString());



                lstVe.Add(ve);
            }
            DataProvider.DongKetNoi(con);
            return lstVe;
        }

        // Lấy thông tin vé có mã ma, trả về null nếu không thấy
        public static Ve_DTO TimVeTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from tbl_VE where MA_VE=N'{0}'", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            Ve_DTO ve = new Ve_DTO();
            ve.SMA_VE = dt.Rows[0]["MA_VE"].ToString();
            ve.SMA_GHE = dt.Rows[0]["MA_GHE"].ToString();
            ve.SNgayBan = DateTime.Parse(dt.Rows[0]["NgayBan"].ToString());
            ve.SNoiBan = dt.Rows[0]["NoiBan"].ToString();
            ve.SID_HK = int.Parse(dt.Rows[0]["ID_HK"].ToString());
            ve.SMa_T = dt.Rows[0]["Ma_T"].ToString();

            DataProvider.DongKetNoi(con);
            return ve;
        }

        /* Thêm vé */
        public static bool ThemVe(Ve_DTO v)
        {
            string sTruyVan = string.Format(@"insert into tbl_VE (MA_VE, ID_HK, Ma_T, MA_GHE, NgayBan, NoiBan) values
('{0}',{1},'{2}','{3}','{4}',N'{5}')",
v.SMA_VE, v.SID_HK, v.SMa_T, v.SMA_GHE, v.SNgayBan, v.SNoiBan);

            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
            /*try
            {
                DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
                DataProvider.DongKetNoi(con);
                return true;
            }
            catch (Exception ex)
            {
                DataProvider.DongKetNoi(con);
                return false;
            }*/

        }

        /* Xóa vé */
        public static bool Xoave(Ve_DTO v)
        {
            string sTruyVan = string.Format(@"delete from nhanvien where MA_VE=N'{0}'",
v.SMA_VE);

            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;

        }

    }
}

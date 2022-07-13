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
    public class HanhKhach_DAO
    {
        static SqlConnection con;
        //Lấy tất cả các Khách
        public static List<HanhKhach_DTO> LayDSKhach()
        {
            string sTruyVan = "select * from tbl_HANHKHACH k, tbl_VE v, tbl_TUYEN t where k.ID_HK = v.ID_HK and t.Ma_T = v.Ma_T";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HanhKhach_DTO> lstKhach = new List<DTO_QLBV.HanhKhach_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HanhKhach_DTO kh = new HanhKhach_DTO();
                kh.SID_HK = int.Parse(dt.Rows[i]["ID_HK"].ToString());
                kh.STenHK = dt.Rows[i]["TenHK"].ToString();
                kh.SCMND = dt.Rows[i]["CMND"].ToString();
                kh.SGioiTinh = dt.Rows[i]["GioiTinh"].ToString();
                kh.SSDT = dt.Rows[i]["SDT"].ToString();
                kh.SDiaChi = dt.Rows[i]["DiaChi"].ToString();

                kh.SDiadiemdi = dt.Rows[i]["DiaDiemDi"].ToString();
                kh.SDiadiemden = dt.Rows[i]["DiaDiemDen"].ToString();
                kh.SNgaychay = DateTime.Parse(dt.Rows[i]["NgayChay"].ToString());
                kh.SSo_Xe = dt.Rows[i]["So_Xe"].ToString();

                lstKhach.Add(kh);
            }
            DataProvider.DongKetNoi(con);
            return lstKhach;
        }

        //Lấy tất cả các Khách của tuyến
        public static List<HanhKhach_DTO> LayDSKhachTK(string ten, string sdt,string ddi, string dde, string soxe)
        {
            string sTruyVan = string.Format(@"select *
from tbl_HANHKHACH k, tbl_VE v, tbl_TUYEN t
where k.ID_HK=v.ID_HK and t.Ma_T=v.Ma_T 
and k.TenHK like N'%{0}%' and k.SDT like N'%{1}%'
and t.DiaDiemDi like N'%{2}%' and t.DiaDiemDen like N'%{3}%'
and t.So_Xe like N'%{4}%'", ten, sdt, ddi, dde, soxe);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HanhKhach_DTO> lstKhach = new List<DTO_QLBV.HanhKhach_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HanhKhach_DTO kh = new HanhKhach_DTO();
                kh.SID_HK = int.Parse(dt.Rows[i]["ID_HK"].ToString());
                kh.STenHK = dt.Rows[i]["TenHK"].ToString();
                kh.SCMND = dt.Rows[i]["CMND"].ToString();
                kh.SGioiTinh = dt.Rows[i]["GioiTinh"].ToString();
                kh.SSDT = dt.Rows[i]["SDT"].ToString();
                kh.SDiaChi = dt.Rows[i]["DiaChi"].ToString();

                kh.SDiadiemdi = dt.Rows[i]["DiaDiemDi"].ToString();
                kh.SDiadiemden = dt.Rows[i]["DiaDiemDen"].ToString();
                kh.SNgaychay = DateTime.Parse(dt.Rows[i]["NgayChay"].ToString());
                kh.SSo_Xe = dt.Rows[i]["So_Xe"].ToString();


                lstKhach.Add(kh);
            }
            DataProvider.DongKetNoi(con);
            return lstKhach;
        }

        // Lấy thông tin Khách có ID, trả về null nếu không thấy
        public static HanhKhach_DTO TimVeTheoID(string id)
        {
            string sTruyVan = string.Format(@"select * from tbl_HANHKHACH where ID_HK={0}", id);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            HanhKhach_DTO kh = new HanhKhach_DTO();
            kh.SID_HK = int.Parse(dt.Rows[0]["ID_HK"].ToString());
            kh.STenHK = dt.Rows[0]["TenHK"].ToString();
            kh.SCMND = dt.Rows[0]["CMND"].ToString();
            kh.SGioiTinh = dt.Rows[0]["GioiTinh"].ToString();
            kh.SSDT = dt.Rows[0]["SDT"].ToString();
            kh.SDiaChi = dt.Rows[0]["DiaChi"].ToString();

            DataProvider.DongKetNoi(con);
            return kh;
        }


        /* Thêm hành khách */
        public static bool ThemHK(HanhKhach_DTO hk)
        {
            string sTruyVan = string.Format(@"insert into tbl_HANHKHACH values
({0},N'{1}',N'{2}','{3}',N'{4}', N'{5}')",
hk.SID_HK, hk.STenHK, hk.SCMND, hk.SGioiTinh, hk.SSDT, hk.SDiaChi);

            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
            //try
            //{
            //    DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            //    DataProvider.DongKetNoi(con);
            //    return true;
            //}
            //catch (Exception ex)
            //{
            //    DataProvider.DongKetNoi(con);
            //    return false;
            //}

        }
    }
}

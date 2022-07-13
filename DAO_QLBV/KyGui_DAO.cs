
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
    public class KyGui_DAO
    {
        static SqlConnection con;
        //Lấy tất cả các ký gửi
        public static List<KyGui_DTO> LayDSKyGui()
        {
            string sTruyVan = "select kg.*, t.* from tbl_KYGUI kg, tbl_TUYEN t where kg.Ma_T = t.Ma_T";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<KyGui_DTO> lstKygui = new List<DTO_QLBV.KyGui_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KyGui_DTO kg = new KyGui_DTO();
                kg.SMa_KyGui = dt.Rows[i]["Ma_KYGUI"].ToString();
                kg.SMa_T = dt.Rows[i]["Ma_T"].ToString();
                kg.SNguoiGui = dt.Rows[i]["NguoiGui"].ToString();
                kg.SNguoiNhan = dt.Rows[i]["NguoiNhan"].ToString();
                kg.SKhoiLuong = float.Parse(dt.Rows[i]["KhoiLuong"].ToString());
                kg.SGia = float.Parse(dt.Rows[i]["gia"].ToString());

                kg.SDiadiemdi = dt.Rows[i]["DiaDiemDi"].ToString();
                kg.SDiadiemde = dt.Rows[i]["DiaDiemDen"].ToString();

                kg.SNgaychay = DateTime.Parse(dt.Rows[i]["NgayChay"].ToString());
                kg.SSo_Xe = dt.Rows[i]["So_Xe"].ToString();

                /*kg.TTuyen = new Tuyen_DTO();
                kg.TTuyen.SDiaDiemDi = dt.Rows[i]["DiaDiemDi"].ToString();
                kg.TTuyen.SDiaDiemDen = dt.Rows[i]["DiaDiemDen"].ToString();
                kg.TTuyen.SNgaychay = DateTime.Parse(dt.Rows[i]["NgayChay"].ToString());*/

                lstKygui.Add(kg);
            }
            DataProvider.DongKetNoi(con);
            return lstKygui;
        }

        //Lấy tất cả các ký gửi của của tuyến có người nhận gửi
        public static List<KyGui_DTO> LayDSKyGuiTK(string nguoigui, string nguoinhan, string soxe)
        {
            string sTruyVan = string.Format(@"select kg.*, t.* from tbl_KYGUI kg, tbl_TUYEN t
where kg.Ma_T=t.Ma_T and kg.NguoiGui like N'%{0}%' and kg.NguoiNhan like N'%{1}%'
and t.So_Xe like N'%{2}%'", nguoigui, nguoinhan, soxe);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<KyGui_DTO> lstKygui = new List<DTO_QLBV.KyGui_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KyGui_DTO kg = new KyGui_DTO();
                kg.SMa_KyGui = dt.Rows[i]["Ma_KYGUI"].ToString();
                kg.SMa_T = dt.Rows[i]["Ma_T"].ToString();
                kg.SNguoiGui = dt.Rows[i]["NguoiGui"].ToString();
                kg.SNguoiNhan = dt.Rows[i]["NguoiNhan"].ToString();
                kg.SKhoiLuong = float.Parse(dt.Rows[i]["KhoiLuong"].ToString());
                kg.SGia = float.Parse(dt.Rows[i]["gia"].ToString());

                kg.SDiadiemdi = dt.Rows[i]["DiaDiemDi"].ToString();
                kg.SDiadiemde = dt.Rows[i]["DiaDiemDen"].ToString();

                kg.SNgaychay = DateTime.Parse(dt.Rows[i]["NgayChay"].ToString());
                kg.SSo_Xe = dt.Rows[i]["So_Xe"].ToString();

                lstKygui.Add(kg);
            }
            DataProvider.DongKetNoi(con);
            return lstKygui;
        }

        // Lấy thông tin ký gửi có mã ma, trả về null nếu không thấy
        public static KyGui_DTO TimKGTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from tbl_KYGUI where MA_KYGUI=N'{0}'", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            KyGui_DTO kg = new KyGui_DTO();
            kg.SMa_KyGui = dt.Rows[0]["Ma_KYGUI"].ToString();
            kg.SMa_T = dt.Rows[0]["Ma_T"].ToString();
            kg.SNguoiGui = dt.Rows[0]["NguoiGui"].ToString();
            kg.SNguoiNhan = dt.Rows[0]["NguoiNhan"].ToString();
            kg.SKhoiLuong = float.Parse(dt.Rows[0]["KhoiLuong"].ToString());
            kg.SGia = float.Parse(dt.Rows[0]["gia"].ToString());

            DataProvider.DongKetNoi(con);
            return kg;
        }

        /* Thêm */
        public static bool ThemKyGui(KyGui_DTO kg)
        {
            string sTruyVan = string.Format(@"insert into tbl_KYGUI values
(N'{0}',N'{1}',N'{2}',N'{3}','{4}',N'{5}')",
kg.SMa_KyGui, kg.SMa_T, kg.SNguoiGui, kg.SNguoiNhan, kg.SKhoiLuong, kg.SGia);
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

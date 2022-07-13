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
    public class User_DAO
    {
        static SqlConnection con;

        //tìm thông tin người dùng theo mật khẩu
        public static User_DTO Tim_Nguoi_Dung_Theo_Mat_Khau(string ma)
        {
            string sTruyVan = string.Format(@"select * from tbl_USER n, tbl_QUYEN nh where n.PASS=N'{0}' and nh.Ma_Q = n.Ma_Q", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;

            }
            User_DTO nd = new User_DTO();
            nd.STenDangNhap = dt.Rows[0]["TenDn"].ToString();
            nd.SHoTen = dt.Rows[0]["HoTen"].ToString();
            nd.SMatKhau = dt.Rows[0]["PASS"].ToString();
            nd.SMaQuyen = dt.Rows[0]["Ma_Q"].ToString();
            nd.STenQuyen = dt.Rows[0]["Ten_Q"].ToString();


            DataProvider.DongKetNoi(con);
            return nd;
        }
        //tìm thông tin người dùng theo tài khoản
        public static User_DTO Tim_Nguoi_Dung_Theo_Tai_Khoan(string tendangnhap)
        {
            string sTruyVan = string.Format(@"select *from tbl_USER where TenDN=N'{0}'", tendangnhap);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;

            }
            User_DTO nd = new User_DTO();
            nd.STenDangNhap = dt.Rows[0]["TenDn"].ToString();
            nd.SHoTen = dt.Rows[0]["HoTen"].ToString();
            nd.SMatKhau = dt.Rows[0]["PASS"].ToString();
            nd.SMaQuyen = dt.Rows[0]["Ma_Q"].ToString();


            DataProvider.DongKetNoi(con);
            return nd;

        }


        public static User_DTO Tim_Nguoi_Dung_Theo_Mat_Khau_Kiem_Tra(string ma, string m)
        {
            string sTruyVan = string.Format(@"select * from tbl_USER where TenDN=N'{0}' and PASS=N'{1}'", ma, m);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            User_DTO nd = new User_DTO();
            nd.STenDangNhap = dt.Rows[0]["TenDn"].ToString();
            nd.SHoTen = dt.Rows[0]["HoTen"].ToString();
            nd.SMatKhau = dt.Rows[0]["PASS"].ToString();
            nd.SMaQuyen = dt.Rows[0]["Ma_Q"].ToString();



            DataProvider.DongKetNoi(con);
            return nd;
        }
        public static string Dang_nhap(User_DTO tk)
        {
            try
            {
                DataTable dt = new DataTable();
                con = DataProvider.MoKetNoi();
                string load = string.Format("SELECT nd.Ma_Q " +
                    "from tbl_USER nd,tbl_QUYEN n " +
                    "WHERE nd.Ma_Q=n.Ma_Q and TenDN=N'{0}' and PASS=N'{1}'"
                    , tk.STenDangNhap, tk.SMatKhau);
                SqlCommand cmd = new SqlCommand(load, con);
                tk.SMaQuyen = cmd.ExecuteScalar().ToString();
                con.Close();
                if (tk.SMaQuyen != "")
                {
                    return tk.SMaQuyen;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static bool ThemNguoiDung(User_DTO tk)
        {

            string sTruyVan = string.Format(@"INSERT INTO tbl_USER(TenDN, HoTen, PASS, Ma_Q) 
VALUES ('{0}',N'{1}',N'{2}',N'{3}')",
                tk.STenDangNhap, tk.SHoTen, tk.SMatKhau, tk.SMaQuyen);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool SuaNguoiDung(User_DTO tk)
        {
            string sTruyVan = string.Format(@"update tbl_USER set HoTen=N'{1}', PASS = N'{2}',Ma_Q = N'{3}' where TenDN = N'{0}'",
           tk.STenDangNhap, tk.SHoTen, tk.SMatKhau, tk.SMaQuyen);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool XoaNguoiDung(User_DTO tendn)
        {
            string sTruyVan = string.Format(@"Delete from tbl_USER where TenDN = N'{0}'", tendn.STenDangNhap);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        //Đổi mật khẩu
        public static bool Doi_Mat_Khau(User_DTO dn)
        {
            string sTruyVan = string.Format(@"update tbl_USER set PASS=N'{0}' where TenDN=N'{1}'", dn.SMatKhau, dn.STenDangNhap);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }


        public static string LayMK(User_DTO tk)
        {
            try
            {
                DataTable dt = new DataTable();
                con = DataProvider.MoKetNoi();
                string load = "select * from tbl_USER";
                SqlCommand cmd = new SqlCommand(load, con);
                tk.SMaQuyen = cmd.ExecuteScalar().ToString();
                con.Close();
                if (tk.SMaQuyen != "")
                {
                    return tk.SMatKhau;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

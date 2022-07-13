using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

using DTO_QLBV;
using DAO_QLBV;

namespace BUS_QLBV
{
    public class User_BUS
    {
        public static User_DTO Tim_Nguoi_Dung_Theo_Tai_Khoan(string ma)
        {
            return User_DAO.Tim_Nguoi_Dung_Theo_Tai_Khoan(ma);
        }
        public static User_DTO Tim_Nguoi_Dung_Theo_Mat_Khau(string ma)
        {
            return User_DAO.Tim_Nguoi_Dung_Theo_Mat_Khau(ma);
        }
        public static User_DTO Tim_Nguoi_Dung_Theo_Mat_Khau_Kiem_Tra(string ma, string m)
        {
            return User_DAO.Tim_Nguoi_Dung_Theo_Mat_Khau_Kiem_Tra(ma, m);
        }

        //Cập nhật thông tin đăng nhập
        public static bool Doi_Mat_Mau(User_DTO up)
        {
            return User_DAO.Doi_Mat_Khau(up);
        }

        public static string Dang_nhap(User_DTO tk)
        {
            return User_DAO.Dang_nhap(tk);
        }
        public static bool ThemNguoiDung(User_DTO tk)
        {
            return User_DAO.ThemNguoiDung(tk);
        }
        public static bool SuaNguoiDung(User_DTO kh)
        {
            return User_DAO.SuaNguoiDung(kh);
        }
        public static bool XoaNguoiDung(User_DTO kh)
        {
            return User_DAO.XoaNguoiDung(kh);
        }
    }
}

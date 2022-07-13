using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO_QLBV;
using DAO_QLBV;

namespace BUS_QLBV
{
    public class HanhKhach_BUS
    {
        public static List<HanhKhach_DTO> LayDSKhach()
        {
            return HanhKhach_DAO.LayDSKhach();
        }

        public static List<HanhKhach_DTO> LayDSKhachTK(string ten, string sdt, string ddi, string dde, string soxe)
        {
            return HanhKhach_DAO.LayDSKhachTK(ten, sdt, ddi, dde, soxe);
        }

        public static HanhKhach_DTO TimVeTheoID(string id)
        {
            return HanhKhach_DAO.TimVeTheoID(id);
        }

        public static bool ThemHK(HanhKhach_DTO hk)
        {
            return HanhKhach_DAO.ThemHK(hk);
        }
    }
}

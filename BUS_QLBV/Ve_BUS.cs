using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO_QLBV;
using DAO_QLBV;

namespace BUS_QLBV
{
    public class Ve_BUS
    {
        public static List<Ve_DTO> LayDSVe()
        {
            return Ve_DAO.LayDSVe();
        }

        public static List<Ve_DTO> LayDSVeTK(string ma, string ten)
        {
            return Ve_DAO.LayDSVeTK(ma, ten);
        }

        public static Ve_DTO TimVeTheoMa(string ma)
        {
            return Ve_DAO.TimVeTheoMa(ma);
        }

        public static bool ThemVe(Ve_DTO v)
        {
            return Ve_DAO.ThemVe(v);
        }

        public static bool Xoave(Ve_DTO v)
        {
            return Ve_DAO.Xoave(v);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO_QLBV;
using DAO_QLBV;

namespace BUS_QLBV
{
    public class Ghe_BUS
    {
        public static List<Ghe_DTO> LayDSGhe()
        {
            return Ghe_DAO.LayDSGhe();
        }

        public static List<Ghe_DTO> TimGheCuaXe(string soxe)
        {
            return Ghe_DAO.TimGheCuaXe(soxe);
        }

        public static List<Ghe_DTO> TimGheTrong(string soxe)
        {
            return Ghe_DAO.TimGheTrong(soxe);
        }

        public static bool SuaTrangThaiGhe(Ghe_DTO g)
        {
            return Ghe_DAO.SuaTrangThaiGhe(g);
        }
    }
}

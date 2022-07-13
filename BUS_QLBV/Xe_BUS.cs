using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAO_QLBV;
using DTO_QLBV;

namespace BUS_QLBV
{
    public class Xe_BUS
    {
        public static List<Xe_DTO> LayDSXE()
        {
            return Xe_DAO.LayDSXE();
        }

        public static List<Xe_DTO> LayDSXETK(string soxe, string taixe, string phuxe)
        {
            return Xe_DAO.LayDSXETK(soxe, taixe, phuxe);
        }
    }
}

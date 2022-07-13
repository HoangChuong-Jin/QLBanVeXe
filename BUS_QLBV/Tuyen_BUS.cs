using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAO_QLBV;
using DTO_QLBV;

namespace BUS_QLBV
{
    public class Tuyen_BUS
    {
        public static List<Tuyen_DTO> LayDSTuyen()
        {
            return Tuyen_DAO.LayDSTuyen();
        }

        public static List<Tuyen_DTO> LayDSTuyenTK(string ddi, string dde)
        {
            return Tuyen_DAO.LayDSTuyenTK(ddi, dde);
        }

        public static List<Tuyen_DTO> LayDSTuyenTK2(string ma, string ddi, string dde)
        {
            return Tuyen_DAO.LayDSTuyenTK2(ma, ddi, dde);
        }
    }
}

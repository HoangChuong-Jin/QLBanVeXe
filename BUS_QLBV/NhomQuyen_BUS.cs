using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAO_QLBV;
using DTO_QLBV;

namespace BUS_QLBV
{
    public class NhomQuyen_BUS
    {
        public static List<NhomQuyen_DTO> LayQuyen()
        {
            return NhomQuyen_DAO.LayQuyen();
        }
        public static string LayTenQuyenTheoMa(string ma)
        {
            return NhomQuyen_DAO.LayTenQuyenTheoMa(ma);
        }
    }
}

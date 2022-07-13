using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO_QLBV;

namespace BUS_QLBV
{
    public class KhoiPhuc_BUS
    {
        public static bool Restore(string sDuongDan)
        {
            return KhoiPhuc_DAO.PhucHoi(sDuongDan);
        }
    }
}

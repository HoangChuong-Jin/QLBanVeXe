using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAO_QLBV;
using DTO_QLBV;

namespace BUS_QLBV
{
    public class KyGui_BUS
    {
        public static List<KyGui_DTO> LayDSKyGui()
        {
            return KyGui_DAO.LayDSKyGui();
        }

        public static List<KyGui_DTO> LayDSKyGuiTK(string nguoigui, string nguoinhan, string soxe)
        {
            return KyGui_DAO.LayDSKyGuiTK(nguoigui, nguoinhan, soxe);
        }

        /* tìm ký gửi theo ma */
        public static KyGui_DTO TimKGTheoMa(string ma)
        {
            return KyGui_DAO.TimKGTheoMa(ma);
        }

        /* thêm ký gửi */
        public static bool ThemKyGui(KyGui_DTO kg)
        {
            return KyGui_DAO.ThemKyGui(kg);
        }
    }
}

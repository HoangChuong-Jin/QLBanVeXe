using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBV
{
    public class Ghe_DTO
    {
        private string sMa_Ghe;

        public string SMa_Ghe
        {
            get { return sMa_Ghe; }
            set { sMa_Ghe = value; }
        }

        private int sSo_Ghe;

        public int SSo_Ghe
        {
            get { return sSo_Ghe; }
            set { sSo_Ghe = value; }
        }

        private bool sTrang_Thai;

        public bool STrang_Thai
        {
            get { return sTrang_Thai; }
            set { sTrang_Thai = value; }
        }

        private string sSo_Xe;

        public string SSo_Xe
        {
            get { return sSo_Xe; }
            set { sSo_Xe = value; }
        }

    }
}

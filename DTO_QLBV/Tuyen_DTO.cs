using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBV
{
    public class Tuyen_DTO
    {
        private string sMa_T;

        public string SMa_T
        {
            get { return sMa_T; }
            set { sMa_T = value; }
        }

        private string sDiaDiemDi;

        public string SDiaDiemDi
        {
            get { return sDiaDiemDi; }
            set { sDiaDiemDi = value; }
        }

        private string sDiaDiemDen;

        public string SDiaDiemDen
        {
            get { return sDiaDiemDen; }
            set { sDiaDiemDen = value; }
        }

        private DateTime sNgaychay;

        public DateTime SNgaychay
        {
            get { return sNgaychay; }
            set { sNgaychay = value; }
        }

        private float GiaGoc;

        public float SGiaGoc
        {
            get { return GiaGoc; }
            set { GiaGoc = value; }
        }

        private string sSo_Xe;

        public string SSo_Xe
        {
            get { return sSo_Xe; }
            set { sSo_Xe = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBV
{
    public class HanhKhach_DTO
    {
        private int sID_HK;
        public int SID_HK
        {
            get { return sID_HK; }
            set { sID_HK = value; }
        }

        private string sTenHK;

        public string STenHK
        {
            get { return sTenHK; }
            set { sTenHK = value; }
        }

        private string sCMND;

        public string SCMND
        {
            get { return sCMND; }
            set { sCMND = value; }
        }

        private string sGioiTinh;

        public string SGioiTinh
        {
            get { return sGioiTinh; }
            set { sGioiTinh = value; }
        }

        private string sSDT;

        public string SSDT
        {
            get { return sSDT; }
            set { sSDT = value; }
        }

        private string sDiaChi;

        public string SDiaChi
        {
            get { return sDiaChi; }
            set { sDiaChi = value; }
        }

        private string sDiadiemdi;

        public string SDiadiemdi
        {
            get { return sDiadiemdi; }
            set { sDiadiemdi = value; }
        }

        private string sDiadiemden;

        public string SDiadiemden
        {
            get { return sDiadiemden; }
            set { sDiadiemden = value; }
        }

        private DateTime sNgaychay;

        public DateTime SNgaychay
        {
            get { return sNgaychay; }
            set { sNgaychay = value; }
        }

        private string sSo_Xe;

        public string SSo_Xe
        {
            get { return sSo_Xe; }
            set { sSo_Xe = value; }
        }
    }
}

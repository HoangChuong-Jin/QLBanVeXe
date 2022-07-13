using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBV
{
    public class User_DTO
    {
        private string stendangnhap;

        public string STenDangNhap
        {
            get { return stendangnhap; }
            set { stendangnhap = value; }
        }
        private string shoten;
        public string SHoTen
        {
            get { return shoten; }
            set { shoten = value; }
        }
        private string smatkhau;
        public string SMatKhau
        {
            get { return smatkhau; }
            set { smatkhau = value; }
        }
        private string smaquyen;
        public string SMaQuyen
        {
            get { return smaquyen; }
            set { smaquyen = value; }
        }

        private string stenquyen;
        public string STenQuyen
        {
            get { return stenquyen; }
            set { stenquyen = value; }
        }
    }
}

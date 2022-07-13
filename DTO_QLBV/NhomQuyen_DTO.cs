using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO_QLBV
{
    public class NhomQuyen_DTO
    {
        private string maquyen;

        public string SMaQuyen
        {
            get { return maquyen; }
            set { maquyen = value; }
        }

        private string tenquyen;

        public string STenQuyen
        {
            get { return tenquyen; }
            set { tenquyen = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GUI_QLBV
{
    public partial class frm_XemFileLog : Form
    {
        public frm_XemFileLog()
        {
            InitializeComponent();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_log_Load(object sender, EventArgs e)
        {
            
        }

        private void panel_Top_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_XemFileLog_Load(object sender, EventArgs e)
        {
            StreamReader d = new StreamReader("test.txt");
            txtnhatki.Text = d.ReadToEnd();
            d.Close();
        }
    }
}

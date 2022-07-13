using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLBV
{
    public partial class frm_flash : Form
    {
        public frm_flash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pro_flash.Value += 1;
            if (pro_flash.Value == 100)
            {
                this.Dispose();
            }
        }

        private void frm_flash_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.Wheat;
            this.BackColor = Color.Wheat;
        }
    }
}

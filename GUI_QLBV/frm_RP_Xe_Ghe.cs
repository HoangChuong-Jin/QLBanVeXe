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
    public partial class frm_RP_Xe_Ghe : Form
    {
        public frm_RP_Xe_Ghe()
        {
            InitializeComponent();
        }

        private void frm_RP_Khach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLVXDataSet1.tbl_GHE' table. You can move, or remove it, as needed.
            this.tbl_GHETableAdapter.Fill(this.QLVXDataSet1.tbl_GHE);
            // TODO: This line of code loads data into the 'QLVXDataSet_Group.tbl_VE' table. You can move, or remove it, as needed.
            //this.tbl_VETableAdapter.Fill(this.QLVXDataSet_Group.tbl_VE);

            this.reportViewer1.RefreshReport();
        }
    }
}

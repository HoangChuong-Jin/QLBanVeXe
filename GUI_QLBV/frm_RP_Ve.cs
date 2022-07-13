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
    public partial class frm_RP_Ve : Form
    {
        public frm_RP_Ve()
        {
            InitializeComponent();
        }

        private void frm_RP_Ve_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLVXDataSet.tbl_VE' table. You can move, or remove it, as needed.
            this.tbl_VETableAdapter.Fill(this.QLVXDataSet.tbl_VE);

            //this.report_Ve.RefreshReport();
            //this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}

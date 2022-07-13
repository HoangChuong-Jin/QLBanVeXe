using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DTO_QLBV;
using BUS_QLBV;

namespace GUI_QLBV
{
    public partial class test2 : Form
    {
        public test2()
        {
            InitializeComponent();
        }

        private void test2_Load(object sender, EventArgs e)
        {
            HT_DataGrid_ghe();
        }

        private void CBO_Ghe_Trong(string soxe)
        {
            List<Ghe_DTO> lst = Ghe_BUS.TimGheTrong(soxe);
            cbo.DataSource = lst;
            cbo.DisplayMember = "SSo_ghe";
            cbo.ValueMember = "sMa_Ghe";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string a = textBox3.Text;

            CBO_Ghe_Trong(a);
        }

        private void HT_DataGrid_ghe()
        {
            List<Ghe_DTO> lstXe = Ghe_BUS.LayDSGhe();
            dataGridtes.DataSource = lstXe;
        }

        public test2(string a, string b) : this()
        {
            string A = a;
            string B = b;
            t1.Text = a;
            t2.Text = b;
        }
    }
}

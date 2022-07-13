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
    public partial class frm_thongtinve : Form
    {
        //string tendn;
        public frm_thongtinve()
        {
            InitializeComponent();

           /* txt_MTuyen_TTDV.Text = ma;
            txt_ddi_TTDV.Text = di;
            txt_dde_TTDV.Text = den;
            date_NgayChay_TTDV.Text = tg;
            txt_Soxe_TTDV.Text = sx;
            txt_GiaVe_TTDV.Text = gia;*/
        }

        public frm_thongtinve(string ma, string di, string den, string tg, string sx, string gia) : this()
        {
            txt_MTuyen_TTDV.Text = ma;
            txt_ddi_TTDV.Text = di;
            txt_dde_TTDV.Text = den;
            date_NgayChay_TTDV.Text = tg;
            txt_Soxe_TTDV.Text = sx;
            txt_GiaVe_TTDV.Text = gia;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Soxe_TTDV_TextChanged(object sender, EventArgs e)
        {
            string soxe = txt_Soxe_TTDV.Text;

            CBO_Ghe_Trong(soxe);
        }

        private void CBO_Ghe_Trong(string soxe)
        {
            List<Ghe_DTO> lst = Ghe_BUS.TimGheTrong(soxe);
            cbo_SoGhe_TTDV.DataSource = lst;
            cbo_SoGhe_TTDV.DisplayMember = "SSo_Ghe";
            cbo_SoGhe_TTDV.ValueMember = "SMa_Ghe";
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            // kiểm tra rỗng
            if (txt_MaVe_TTDV.Text == "" || txt_Hoten_TTDV.Text == "" || txt_Cmnd_TTDV.Text == "" ||
                txt_Gioitinh_TTDV.Text == "" || txt_Sdt_TTDV.Text == "" || txt_NoiBan.Text == "" ||
                date_NgayChay_TTDV.Text =="" || cbo_SoGhe_TTDV.Text == "" || txt_DiaChi_TTDV.Text ==""
                || nutext_IDHK.Value.ToString()=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }

            // Kiểm tra mã ký gửi có độ dài chuỗi hợp lệ hay không
            if (txt_MaVe_TTDV.Text.Length > 5)
            {
                MessageBox.Show("Mã ký gửi tối đa 5 ký tự!");
                return;
            }

            // Kiểm tra mã có bị trùng không
            if (Ve_BUS.TimVeTheoMa(txt_MaVe_TTDV.Text) != null)
            {
                MessageBox.Show("Mã Vé đã tồn tại!");
                return;
            }

            // Kiểm tra id có bị trùng không
            if (HanhKhach_BUS.TimVeTheoID(nutext_IDHK.Value.ToString()) != null)

            {
                MessageBox.Show("ID đã tồn tại!");
                return;
            }

            //Thêm hk
            HanhKhach_DTO hk = new HanhKhach_DTO();
            hk.SID_HK = int.Parse(nutext_IDHK.Value.ToString());
            hk.STenHK = txt_Hoten_TTDV.Text;
            hk.SCMND = txt_Cmnd_TTDV.Text;
            hk.SGioiTinh = txt_Gioitinh_TTDV.Text;
            hk.SSDT = txt_Sdt_TTDV.Text;
            hk.SDiaChi = txt_DiaChi_TTDV.Text;


            if(HanhKhach_BUS.ThemHK(hk) == true)
            {
                //Thêm vé
                Ve_DTO ve = new Ve_DTO();
                ve.SMA_VE = txt_MaVe_TTDV.Text;
                ve.SMa_T = txt_MTuyen_TTDV.Text;
                ve.SID_HK = int.Parse(nutext_IDHK.Value.ToString());
                ve.SMA_GHE = cbo_SoGhe_TTDV.SelectedValue.ToString();
                ve.SNoiBan = txt_NoiBan.Text;
                ve.SNgayBan = DateTime.Parse(date_NgayBan.Text);

                if(Ve_BUS.ThemVe(ve) == false)
                {
                    MessageBox.Show("Có lỗi.");
                    return;
                }


                
                Ghe_DTO g = new Ghe_DTO();
                g.STrang_Thai = true;
                g.SMa_Ghe = cbo_SoGhe_TTDV.SelectedValue.ToString();
                Ghe_BUS.SuaTrangThaiGhe(g);

                MessageBox.Show("Vé "+txt_MaVe_TTDV.Text+" đã thành công.", "Thông Báo");
  
            }    
            else
                MessageBox.Show("Có lỗi", "Thông Báo", MessageBoxButtons.OK);

            /*//Thêm vé
            Ve_DTO ve = new Ve_DTO();
            ve.SMA_VE = txt_MaVe_TTDV.Text;
            ve.SMa_T = txt_MTuyen_TTDV.Text;
            ve.SID_HK = int.Parse(nutext_IDHK.Value.ToString());
            ve.SMA_GHE = cbo_SoGhe_TTDV.SelectedValue.ToString();
            ve.SNoiBan = txt_NoiBan.Text;
            ve.SNgayBan = DateTime.Parse(date_NgayBan.Text);

            if (Ve_BUS.ThemVe(ve) == false)
            {
                MessageBox.Show("Có lỗi.");
                return;
            }*/

        }

        private void frm_thongtinve_Load(object sender, EventArgs e)
        {

        }
    }
}

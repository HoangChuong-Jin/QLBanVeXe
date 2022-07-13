using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BUS_QLBV;
using DTO_QLBV;

namespace GUI_QLBV
{
    public partial class frm_DoiMK : Form
    {
        string ten;
        public frm_DoiMK(string tenDN)
        {
            InitializeComponent();
            ten = tenDN;
        }

        private void btn_DoiMK_Click(object sender, EventArgs e)
        {
            if(txt_TenDN.Text == "" || txt_MK.Text == "" || txt_MK_moi.Text == "" || txt_nhaplaiMK_moi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }

            Encode mahoa = new Encode();
            string password_mahoa = mahoa.Encrypt(txt_MK.Text);

            // kiem tra người dùng 
            if (User_BUS.Tim_Nguoi_Dung_Theo_Tai_Khoan(txt_TenDN.Text) == null)
            {
                MessageBox.Show("Không tìm thấy tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_TenDN.Focus();
                return;
            }

            // kiem tra mật khẩu 
            if (User_BUS.Tim_Nguoi_Dung_Theo_Mat_Khau_Kiem_Tra(txt_TenDN.Text, password_mahoa) == null)
            {
                MessageBox.Show("Mật khẩu không đúng!");
                return;
            }
            else
            {
                if (txt_MK_moi.Text != txt_nhaplaiMK_moi.Text)
                {
                    MessageBox.Show("Xác nhận mật khẩu chưa chính xác !", "Thông báo", MessageBoxButtons.OK);
                    txt_MK.Focus();
                }
                else
                {
                    //Encode mahoa2 = new Encode();
                    User_DTO nd = new User_DTO();
                    nd.STenDangNhap = txt_TenDN.Text;
                    nd.SMatKhau = mahoa.Encrypt(txt_MK_moi.Text);


                    if (User_BUS.SuaNguoiDung(nd) == false)
                    {
                        MessageBox.Show("Không đổi được.");
                        return;
                    }

                    txt_TenDN.ResetText();
                    txt_MK.ResetText();
                    txt_MK_moi.ResetText();
                    txt_nhaplaiMK_moi.ResetText();
                    MessageBox.Show("Đã đổi mật khẩu.");
                }
            }

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Thoat_nut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_DoiMK_Load(object sender, EventArgs e)
        {
            txt_TenDN.Text = ten;
        }
    }
}

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

using DTO_QLBV;
using BUS_QLBV;

namespace GUI_QLBV
{
    public partial class frm_login : Form
    {
        Radian rad = new Radian();
        public frm_login()
        {
            InitializeComponent();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            rad.Radian_Pic(pic_txt1);
            rad.Radian_Pic(pic_txt2);
            rad.Radian_Btn(btn_Login);
            txt_Pass.UseSystemPasswordChar = true;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            // kiem tra du lieu co bi bo trong
            if (txt_TenDN.Text == "" || txt_Pass.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;

            }
            Encode mahoa = new Encode();
            string password_mahoa = mahoa.Encrypt(txt_Pass.Text);


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
            User_DTO nd = new User_DTO();
            nd.STenDangNhap = txt_TenDN.Text;
            nd.SMatKhau = password_mahoa;

            if (User_BUS.Tim_Nguoi_Dung_Theo_Tai_Khoan(txt_TenDN.Text) == null)
            {
                MessageBox.Show("Đăng nhập không thành công");

                return;

            }
            else
            {
                if (User_BUS.Dang_nhap(nd) != "")
                {
                    string quyenhan = User_BUS.Dang_nhap(nd);
                    switch (quyenhan)
                    {
                        case "Ad":
                            this.Hide();
                            MessageBox.Show("Đăng nhập thành công với quyền Administrator !!!");

                            WriteLog.Write(txt_TenDN.Text, "Đăng nhập thành công");

                            frm_main f1 = new frm_main(txt_TenDN.Text, quyenhan);
                            
                            f1.Admin();
                            


                            //WriteLog.Write(txt_TenDN.Text, "Mở form frm_main");

                            //ghi file log
                            StreamWriter writer = new StreamWriter("test.txt", true);
                            string chuoi = " ";
                            string getdate = DateTime.Now.ToString();
                            chuoi = "\n****    Vào lúc: " + getdate + " ---Tài khoản: " + txt_TenDN.Text + " --->Đã Đăng Nhập";
                            writer.WriteLine(chuoi);
                            writer.Close();
                            f1.Show();
                            ////

                            break;
                        case "Ql":
                            this.Hide();
                            MessageBox.Show("Đăng nhập thành công với quyền quản lý !!");
                            
                            frm_main f2 = new frm_main(txt_TenDN.Text, quyenhan);
                            //WriteLog.Write(txt_TenDN.Text, "Đăng nhập");

                            f2.Ql();
                            f2.Show();

                            //WriteLog.Write(txt_TenDN.Text, "Đăng nhập");
                            //ghi file log
                            StreamWriter writer1 = new StreamWriter("test.txt", true);
                            string chuoi1 = " ";
                            string getdate1 = DateTime.Now.ToString();
                            chuoi1 = "\n****    Vào lúc: " + getdate1 + " ---Tài khoản: " + txt_TenDN.Text + " --->Đã Đăng nhập";
                            writer1.WriteLine(chuoi1);
                            writer1.Close();
                            ////
                            ///*/
                            break;
                        case "NV":
                            this.Hide();
                            MessageBox.Show("Đăng nhập thành công với quyền nhân viên !");

                            frm_main f3 = new frm_main(txt_TenDN.Text, quyenhan);
                            //WriteLog.Write(txtTenDangNhap.Text, "Đăng nhập");

                            f3.Nv();
                            f3.Show();

                            //WriteLog.Write(txtTenDangNhap.Text, "Mở form frm_main");
                            //ghi file log
                            StreamWriter writer2 = new StreamWriter("test.txt", true);
                            string chuoi2 = " ";
                            string getdate2 = DateTime.Now.ToString();
                            chuoi2 = "\n****    Vào lúc: " + getdate2 + " ---Tài khoản: " + txt_TenDN.Text + " --->Đã Đăng Nhập";
                            writer2.WriteLine(chuoi2);
                            writer2.Close();
                            ////
                            break;
                        default:
                            MessageBox.Show("Lỗi!", "Thông báo", MessageBoxButtons.OK);
                            WriteLog.Write(txt_TenDN.Text, "Đăng nhập không thành công ");
                            
                            break;
                    }
                }
            }

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult tr;
            tr = MessageBox.Show("Bạn có muốn thoát chương trình hay không?",
                "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tr == DialogResult.OK)
            {
                Application.Exit();
                WriteLog.Write(txt_TenDN.Text, "Thoát chương trình");
            }
        }

        private void chk_HMK_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_HMK.Checked == false)
            {
                txt_Pass.UseSystemPasswordChar = true;
                var checkBox = (CheckBox)sender;
                checkBox.Text = "Hiện mật khẩu";
            }
            else
            {
                txt_Pass.UseSystemPasswordChar = false;
            }
        }

        private void frm_login_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode.Equals(Keys.Enter))
                {
                    btn_Login_Click(null, null);
                }
                if (e.KeyCode.Equals(Keys.Escape))
                {
                    btn_Thoat_Click(null, null);
                }
            }
        }

        private void linkLabel_Singup_Click(object sender, EventArgs e)
        {
            frm_DangKy f1 = new frm_DangKy();
            f1.Show();
        }
    }
}

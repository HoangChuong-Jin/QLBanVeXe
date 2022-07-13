using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BUS_QLBV;
using DTO_QLBV;

namespace GUI_QLBV
{
    public partial class frm_DangKy : Form
    {
        public static string ten;
        public frm_DangKy()
        {
            InitializeComponent();
            //ten = tendangnhap;
        }

        private void frm_DangKy_Load(object sender, EventArgs e)
        {
            txt_MK.UseSystemPasswordChar = true;
            txt_MK_Lai.UseSystemPasswordChar = true;


            List<NhomQuyen_DTO> LstChucVu = NhomQuyen_BUS.LayQuyen();
            cbo_Quyen.DataSource = LstChucVu;
            //NhomQuyen_DTO d1 = new NhomQuyen_DTO();
            cbo_Quyen.DisplayMember = "STenQuyen";

            //LstChucVu.Insert(0, d1);
            cbo_Quyen.ValueMember = "SMaQuyen";
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            if (txt_TenDN.Text == "" || txt_MK.Text == "" || txt_MK_Lai.Text == "" || txt_HoTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            else
            {
                // Kiểm tra mã  có độ dài chuỗi hợp lệ hay không
                if (txt_TenDN.Text.Length <= 3)
                {
                    MessageBox.Show("Tên đăng nhập tối thiểu 4 ký tự!");
                    return;
                }
                else
                {
                    // Kiểm tra tên đăng nhập có bị trùng không
                    if (User_BUS.Tim_Nguoi_Dung_Theo_Tai_Khoan(txt_TenDN.Text) != null)
                    {
                        MessageBox.Show("Tên đăng nhập đã tồn tại!");
                        return;
                    }
                    else
                    {
                        if (txt_MK.Text != txt_MK_Lai.Text)
                        {
                            MessageBox.Show("Xác nhận mật khẩu chưa chính xác !", "Thông báo", MessageBoxButtons.OK);
                            txt_MK.Focus();
                        }
                        else
                        {
                            Encode mahoa = new Encode();
                            User_DTO nd = new User_DTO();
                            nd.STenDangNhap = txt_TenDN.Text;
                            nd.SHoTen = txt_HoTen.Text;
                            nd.SMatKhau = mahoa.Encrypt(txt_MK.Text);
                            //nd.STenQuyen = cboQuyen.SelectedItem.ToString();
                            nd.SMaQuyen = cbo_Quyen.SelectedValue.ToString();


                            if (User_BUS.ThemNguoiDung(nd) == false)
                            {
                                MessageBox.Show("Không đăng ký được.");
                                return;
                            }

                            txt_TenDN.ResetText();
                            txt_MK.ResetText();
                            txt_MK_Lai.ResetText();
                            txt_HoTen.ResetText();
                            MessageBox.Show("Đã đăng ký.");
                            
                            //WriteLog.Write(ten, "Đã đăng ký người dùng có tên: " + txtHoTen.Text);
                            /*// ghi file log
                            StreamWriter writer = new StreamWriter("test.txt", true);
                            string chuoi = " ";
                            string getdate = DateTime.Now.ToString();
                            chuoi = "\n****    Vào lúc: " + getdate + " ---Tài khoản: " + ten + " --->Đã Thêm người dùng: " + txt_HoTen.Text;
                            writer.WriteLine(chuoi);
                            writer.Close();
                            */
                        }
                    }
                }
            }
        }

        private void btn_Thoat_nut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

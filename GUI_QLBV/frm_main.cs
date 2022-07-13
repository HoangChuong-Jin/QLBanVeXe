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
    public partial class frm_main : Form
    {
        public static string tennd;
        public static string quyen;
        public frm_main(string tenDN, string quyenhan)
        {
            InitializeComponent();
            tennd = tenDN;
            quyen = quyenhan;
        }
        /* quyền hạn */
        public void Admin()
        {
            lbl_HienthiTennguoidung.ResetText();
            lbl_HienthiTennguoidung.Text = "" + tennd.Trim();

            // không được quyền


            // Được quyền
            Btn_Trangchu.Enabled = true;
            btn_Banve.Enabled = true;
            btn_Kigui.Enabled = true;
            btn_DS.Enabled = true;

            btn_fileLog.Enabled = true;
            btn_DoiMK.Enabled = true;
            btn_DX.Enabled = true;
            btn_BC_Vexe.Enabled = true;
            btn_BC_Xe.Enabled = true;
            btn_fileLog.Enabled = true;
        }
        public void Ql()
        {
            lbl_HienthiTennguoidung.ResetText();
            lbl_HienthiTennguoidung.Text = "" + tennd.Trim();

            // không được quyền
            btn_fileLog.Enabled = false;
            btn_BC_Vexe.Enabled = true;
            btn_BC_Xe.Enabled = false;
            btn_fileLog.Enabled = false;
            btn_fileLog.Visible = false;
            btn_BC_Vexe.Visible = false;
            btn_BC_Xe.Visible = false;
            btn_Saoluu.Visible = false;
            btn_KhoiPhuc.Visible = false;

            // Được quyền
            Btn_Trangchu.Enabled = true;
            btn_Banve.Enabled = true;
            btn_Kigui.Enabled = true;
            btn_DS.Enabled = true;

            //btn_fileLog.Enabled = true;
            btn_DoiMK.Enabled = true;
            btn_DX.Enabled = true;

        }
        public void Nv()
        {
            lbl_HienthiTennguoidung.ResetText();
            lbl_HienthiTennguoidung.Text = "" + tennd.Trim();

            // không được quyền
            btn_DS.Enabled = false;
            btn_fileLog.Enabled = false;
            btn_BC_Vexe.Enabled = false;
            btn_BC_Xe.Enabled = false;
            btn_fileLog.Visible = false;
            btn_BC_Vexe.Visible = false;
            btn_BC_Xe.Visible = false;

            btn_Saoluu.Visible = false;
            btn_KhoiPhuc.Visible = false;

            // Được quyền
            Btn_Trangchu.Enabled = true;
            btn_Banve.Enabled = true;
            btn_Kigui.Enabled = true;
            //btn_DS.Enabled = true;

            //btn_fileLog.Enabled = true;
            btn_DoiMK.Enabled = true;
            btn_DX.Enabled = true;
        }



        private void frm_main_Load(object sender, EventArgs e)
        {
            /* Hiển thị datagridview */
            HT_DataGrid_Tuyen();
            dgDSTuyen.Columns["SMa_T"].HeaderText = "Mã Tuyến";
            dgDSTuyen.Columns["SMa_T"].Width = 100;
            dgDSTuyen.Columns["SDiaDiemDi"].HeaderText = "Nơi xuất phát";
            dgDSTuyen.Columns["SDiaDiemDi"].Width = 180;
            dgDSTuyen.Columns["SDiaDiemDen"].HeaderText = "Nơi đến";
            dgDSTuyen.Columns["SDiaDiemDen"].Width = 180;
            dgDSTuyen.Columns["SNgayChay"].HeaderText = "Thời gian chạy";
            dgDSTuyen.Columns["SNgayChay"].Width = 200;
            dgDSTuyen.Columns["SSo_Xe"].Visible = false;
            dgDSTuyen.Columns["SGiaGoc"].HeaderText = "Giá gốc";
            dgDSTuyen.Columns["SGiaGoc"].Width = 100;

            HT_DataGrid_Xe();
            dgDSXe.Columns["SSo_Xe"].HeaderText = "Số xe";
            dgDSXe.Columns["SSo_Xe"].Width = 180;
            dgDSXe.Columns["STong_Ghe"].HeaderText = "Tổng số ghế";
            dgDSXe.Columns["STong_Ghe"].Width = 80;
            dgDSXe.Columns["STai_Xe"].HeaderText = "Tài xế";
            dgDSXe.Columns["STai_Xe"].Width = 190;
            dgDSXe.Columns["SPhu_Xe"].HeaderText = "Phụ xe";
            dgDSXe.Columns["SPhu_Xe"].Width = 190;

            HT_DataGrid_HK();
            dgDSKhach.Columns["SID_HK"].HeaderText = "ID Khách";
            dgDSKhach.Columns["SID_HK"].Width = 50;
            dgDSKhach.Columns["STenHK"].HeaderText = "Tên khách";
            dgDSKhach.Columns["STenHK"].Width = 180;
            dgDSKhach.Columns["SCMND"].HeaderText = "CMND";
            dgDSKhach.Columns["SCMND"].Width = 100;
            dgDSKhach.Columns["SGioiTinh"].HeaderText = "Giới tính";
            dgDSKhach.Columns["SGioiTinh"].Width = 50;
            dgDSKhach.Columns["SSDT"].HeaderText = "SĐT";
            dgDSKhach.Columns["SSDT"].Width = 100;
            dgDSKhach.Columns["SDiaChi"].HeaderText = "Địa chỉ";
            dgDSKhach.Columns["SDiaChi"].Width = 250;
            dgDSKhach.Columns["SDiaDiemDi"].HeaderText = "Nơi xuất phát";
            dgDSKhach.Columns["SDiaDiemDi"].Width = 150;
            dgDSKhach.Columns["SDiaDiemDen"].HeaderText = "Nơi đến";
            dgDSKhach.Columns["SDiaDiemDen"].Width = 150;
            dgDSKhach.Columns["sNgaychay"].HeaderText = "Ngày chạy";
            dgDSKhach.Columns["sNgaychay"].Width = 150;
            dgDSKhach.Columns["SSo_Xe"].HeaderText = "Số xe";
            dgDSKhach.Columns["SSo_Xe"].Width = 100;

            HT_DataGrid_KG();
            dgDSKygui.Columns["SMa_KyGui"].HeaderText = "Mã ký gửi";
            dgDSKygui.Columns["SMa_KyGui"].Width = 70;
            dgDSKygui.Columns["SMa_T"].Visible = false;
            dgDSKygui.Columns["SNguoiGui"].HeaderText = "Người gửi";
            dgDSKygui.Columns["SNguoiGui"].Width = 180;
            dgDSKygui.Columns["SNguoiNhan"].HeaderText = "Người nhận";
            dgDSKygui.Columns["SNguoiNhan"].Width = 180;
            dgDSKygui.Columns["SKhoiLuong"].HeaderText = "Khối lượng";
            dgDSKygui.Columns["SKhoiLuong"].Width = 50;
            dgDSKygui.Columns["SGia"].HeaderText = "Giá";
            dgDSKygui.Columns["SGia"].Width = 100;
            dgDSKygui.Columns["SDiadiemdi"].HeaderText = "Nơi xuất phát";
            dgDSKygui.Columns["SDiadiemdi"].Width = 150;
            dgDSKygui.Columns["SDiadiemde"].HeaderText = "Nơi đến";
            dgDSKygui.Columns["SDiadiemde"].Width = 150;
            dgDSKygui.Columns["sNgaychay"].HeaderText = "Ngày chạy";
            dgDSKygui.Columns["sNgaychay"].Width = 150;
            dgDSKygui.Columns["SSo_Xe"].HeaderText = "Số xe";
            dgDSKygui.Columns["SSo_Xe"].Width = 100;


            HT_DataGrid_Tuyen_BanVe();
            dgDS_Tuyen_Banve.Columns["SMa_T"].HeaderText = "Mã Tuyến";
            dgDS_Tuyen_Banve.Columns["SMa_T"].Width = 100;
            dgDS_Tuyen_Banve.Columns["SDiaDiemDi"].HeaderText = "Nơi xuất phát";
            dgDS_Tuyen_Banve.Columns["SDiaDiemDi"].Width = 160;
            dgDS_Tuyen_Banve.Columns["SDiaDiemDen"].HeaderText = "Nơi đến";
            dgDS_Tuyen_Banve.Columns["SDiaDiemDen"].Width = 160;
            dgDS_Tuyen_Banve.Columns["SNgayChay"].HeaderText = "Thời gian chạy";
            dgDS_Tuyen_Banve.Columns["SNgayChay"].Width = 160;
            dgDS_Tuyen_Banve.Columns["SSo_Xe"].HeaderText = "Số xe";
            dgDS_Tuyen_Banve.Columns["SSo_Xe"].Width = 100;
            dgDS_Tuyen_Banve.Columns["SGiaGoc"].HeaderText = "Giá gốc";
            dgDS_Tuyen_Banve.Columns["SGiaGoc"].Width = 100;

            HT_DataGrid_Tuyen_KyGui();
            dgDs_Tuyen_Kygui.Columns["SMa_T"].HeaderText = "Mã Tuyến";
            dgDs_Tuyen_Kygui.Columns["SMa_T"].Width = 100;
            dgDs_Tuyen_Kygui.Columns["SDiaDiemDi"].HeaderText = "Nơi xuất phát";
            dgDs_Tuyen_Kygui.Columns["SDiaDiemDi"].Width = 180;
            dgDs_Tuyen_Kygui.Columns["SDiaDiemDen"].HeaderText = "Nơi đến";
            dgDs_Tuyen_Kygui.Columns["SDiaDiemDen"].Width = 180;
            dgDs_Tuyen_Kygui.Columns["SNgayChay"].HeaderText = "Thời gian chạy";
            dgDs_Tuyen_Kygui.Columns["SNgayChay"].Width = 180;
            dgDs_Tuyen_Kygui.Columns["SSo_Xe"].HeaderText = "Số xe";
            dgDs_Tuyen_Kygui.Columns["SSo_Xe"].Width = 120;
            dgDs_Tuyen_Kygui.Columns["SGiaGoc"].Visible = false;

            HT_DataGrid_Ve();
            dgDS_Ve.Columns["SMA_VE"].HeaderText = "Mã vé xe";
            dgDS_Ve.Columns["SMA_VE"].Width = 100;
            dgDS_Ve.Columns["SMA_GHE"].Visible = false;
            dgDS_Ve.Columns["SSo_GHE"].HeaderText = "Số ghế";
            dgDS_Ve.Columns["SSo_GHE"].Width = 50;
            dgDS_Ve.Columns["SSo_Xe"].HeaderText = "Số xe";
            dgDS_Ve.Columns["SSo_Xe"].Width = 100;
            dgDS_Ve.Columns["SNgayBan"].HeaderText = "Ngày bán";
            dgDS_Ve.Columns["SNgayBan"].Width = 120;
            dgDS_Ve.Columns["SNoiBan"].HeaderText = "Nơi bán";
            dgDS_Ve.Columns["SNoiBan"].Width = 180;
            dgDS_Ve.Columns["SID_HK"].Visible = false;
            dgDS_Ve.Columns["STen_HK"].HeaderText = "Tên hành khách";
            dgDS_Ve.Columns["STen_HK"].Width = 180;
            dgDS_Ve.Columns["SMa_T"].HeaderText = "Mã Tuyến";
            dgDS_Ve.Columns["SMa_T"].Width = 100;


            /* Hiên thị combobox */
            CBO_DDi_Tuyen();
            CBO_DDe_Tuyen();
            CBO_Soxe_Khach();
            CBO_Soxe_DSKG();
            CBO_DDi_BanVe();
            CBO_DDe_BanVe();
            CBO_MaT_BanVe();
            CBO_MaVe_Ve();
            CBO_Ma_Tuyen();

            /* datetime */
            //date_TG_Tuyen.Format = DateTimePickerFormat.Custom;
            //date_TG_Tuyen.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            date_NgayChay_BanVe.Format = DateTimePickerFormat.Custom;
            date_NgayChay_BanVe.CustomFormat = "MM/dd/yyyy hh:mm:ss";


        }


        /* Hiên thị datagridview */
        private void HT_DataGrid_Tuyen()
        {
            List<Tuyen_DTO> lstTuyen = Tuyen_BUS.LayDSTuyen();
            dgDSTuyen.DataSource = lstTuyen;
        }

        private void HT_DataGrid_Xe()
        {
            List<Xe_DTO> lstXe = Xe_BUS.LayDSXE();
            dgDSXe.DataSource = lstXe;
        }

        private void HT_DataGrid_KG()
        {
            List<KyGui_DTO> lstKG = KyGui_BUS.LayDSKyGui();
            dgDSKygui.DataSource = lstKG;
        }

        private void HT_DataGrid_HK()
        {
            List<HanhKhach_DTO> lstHK = HanhKhach_BUS.LayDSKhach();
            dgDSKhach.DataSource = lstHK;
        }

        private void HT_DataGrid_Tuyen_BanVe()
        {
            List<Tuyen_DTO> lst = Tuyen_BUS.LayDSTuyen();
            dgDS_Tuyen_Banve.DataSource = lst;
        }

        private void HT_DataGrid_Ve()
        {
            List<Ve_DTO> lst = Ve_BUS.LayDSVe();
            dgDS_Ve.DataSource = lst;
        }

        private void HT_DataGrid_Tuyen_KyGui()
        {
            List<Tuyen_DTO> lst = Tuyen_BUS.LayDSTuyen();
            dgDs_Tuyen_Kygui.DataSource = lst;
        }


        /* Hiển thị combobox */
        private void CBO_DDi_Tuyen()
        {
            List<Tuyen_DTO> lst = Tuyen_BUS.LayDSTuyen();
            cboDDi_Tuyen.DataSource = lst;
            cboDDi_Tuyen.DisplayMember = "SDiaDiemDi";
            //cboChucVu.ValueMember = "SMaCV";
        }

        private void CBO_DDe_Tuyen()
        {
            List<Tuyen_DTO> lst = Tuyen_BUS.LayDSTuyen();
            cboDDe_Tuyen.DataSource = lst;
            cboDDe_Tuyen.DisplayMember = "SDiaDiemDen";
        }

        private void CBO_Soxe_Khach()
        {
            List<Xe_DTO> lst = Xe_BUS.LayDSXE();
            cbo_Soxe_Khach.DataSource = lst;
            cbo_Soxe_Khach.DisplayMember = "SSo_Xe";
        }

        private void CBO_Soxe_DSKG()
        {
            List<Xe_DTO> lst = Xe_BUS.LayDSXE();
            cbo_Soxe_DSKG.DataSource = lst;
            cbo_Soxe_DSKG.DisplayMember = "SSo_Xe";
        }

        private void CBO_DDi_BanVe()
        {
            List<Tuyen_DTO> lst = Tuyen_BUS.LayDSTuyen();
            cbo_ddi_BanVe.DataSource = lst;
            cbo_ddi_BanVe.DisplayMember = "SDiaDiemDi";
        }

        private void CBO_DDe_BanVe()
        {
            List<Tuyen_DTO> lst = Tuyen_BUS.LayDSTuyen();
            cbo_dden_BanVe.DataSource = lst;
            cbo_dden_BanVe.DisplayMember = "SDiaDiemDen";
        }

        private void CBO_MaT_BanVe()
        {
            List<Tuyen_DTO> lst = Tuyen_BUS.LayDSTuyen();
            cbo_MaTuyen_BanVe.DataSource = lst;
            cbo_MaTuyen_BanVe.DisplayMember = "SMa_T";
        }

        private void CBO_MaVe_Ve()
        {
            List<Ve_DTO> lst = Ve_BUS.LayDSVe();
            cbo_MaVe_Ve.DataSource = lst;
            cbo_MaVe_Ve.DisplayMember = "SMA_VE";
        }

        private void CBO_Ma_Tuyen()
        {
            List<Tuyen_DTO> lst = Tuyen_BUS.LayDSTuyen();
            cbo_Tuyen_Kigui.DataSource = lst;
            cbo_Tuyen_Kigui.DisplayMember = "SMa_T";
        }



        /*  Chuyển màu & Chuyển view */
        private void Btn_Trangchu_Click(object sender, EventArgs e)
        {
            if (flpane_Trangchu.Visible == true)
            {
                flp_Banve.Visible = false;
                flp_DStuyen.Visible = false;
                flp_Kigui.Visible = false;

                /// màu nền nút
                Btn_Trangchu.BackColor = Color.Coral;

                btn_Banve.BackColor = Color.DarkOrange;
                btn_Kigui.BackColor = Color.DarkOrange;
                btn_DS.BackColor = Color.DarkOrange;

                btn_DSVe.BackColor = Color.NavajoWhite;
                btn_DSTuyen.BackColor = Color.NavajoWhite;
                btn_DSXe.BackColor = Color.NavajoWhite;
                btn_DSKhach.BackColor = Color.NavajoWhite;
                btn_DSKygui.BackColor = Color.NavajoWhite;

                /// màu chữ nút
                Btn_Trangchu.ForeColor = Color.White;

                btn_Banve.ForeColor = Color.Black;
                btn_Kigui.ForeColor = Color.Black;
                btn_DS.ForeColor = Color.Black;
            }
            else
            {
                pan_DanhSach.Visible = false;

                flpane_Trangchu.Visible = true;
                flp_Banve.Visible = false;
                flp_DStuyen.Visible = false;
                flp_Kigui.Visible = false;

                /// màu nền nút
                Btn_Trangchu.BackColor = Color.Coral;

                btn_Banve.BackColor = Color.DarkOrange;
                btn_Kigui.BackColor = Color.DarkOrange;
                btn_DS.BackColor = Color.DarkOrange;

                btn_DSVe.BackColor = Color.NavajoWhite;
                btn_DSTuyen.BackColor = Color.NavajoWhite;
                btn_DSXe.BackColor = Color.NavajoWhite;
                btn_DSKhach.BackColor = Color.NavajoWhite;
                btn_DSKygui.BackColor = Color.NavajoWhite;

                /// màu chữ nút
                Btn_Trangchu.ForeColor = Color.White;

                btn_Banve.ForeColor = Color.Black;
                btn_Kigui.ForeColor = Color.Black;
                btn_DS.ForeColor = Color.Black;
            }
        }

        private void btn_Banve_Click(object sender, EventArgs e)
        {
            if (flp_Banve.Visible == true)
            {
                flpane_Trangchu.Visible = false;
                flp_DStuyen.Visible = false;
                flp_Kigui.Visible = false;

                /// màu nền nút
                btn_Banve.BackColor = Color.Coral;

                Btn_Trangchu.BackColor = Color.DarkOrange;
                btn_Kigui.BackColor = Color.DarkOrange;
                btn_DS.BackColor = Color.DarkOrange;

                btn_DSVe.BackColor = Color.NavajoWhite;
                btn_DSTuyen.BackColor = Color.NavajoWhite;
                btn_DSXe.BackColor = Color.NavajoWhite;
                btn_DSKhach.BackColor = Color.NavajoWhite;
                btn_DSKygui.BackColor = Color.NavajoWhite;

                /// màu chữ nút
                btn_Banve.ForeColor = Color.White;

                Btn_Trangchu.ForeColor = Color.Black;
                btn_Kigui.ForeColor = Color.Black;
                btn_DS.ForeColor = Color.Black;
            }
            else
            {
                pan_DanhSach.Visible = false;

                flp_Banve.Visible = true;
                flpane_Trangchu.Visible = false;
                flp_DStuyen.Visible = false;
                flp_Kigui.Visible = false;

                /// màu nền nút
                btn_Banve.BackColor = Color.Coral;

                Btn_Trangchu.BackColor = Color.DarkOrange;
                btn_Kigui.BackColor = Color.DarkOrange;
                btn_DS.BackColor = Color.DarkOrange;

                btn_DSVe.BackColor = Color.NavajoWhite;
                btn_DSTuyen.BackColor = Color.NavajoWhite;
                btn_DSXe.BackColor = Color.NavajoWhite;
                btn_DSKhach.BackColor = Color.NavajoWhite;
                btn_DSKygui.BackColor = Color.NavajoWhite;

                /// màu chữ nút
                btn_Banve.ForeColor = Color.White;

                Btn_Trangchu.ForeColor = Color.Black;
                btn_Kigui.ForeColor = Color.Black;
                btn_DS.ForeColor = Color.Black;
            }
        }

        private void btn_Kigui_Click(object sender, EventArgs e)
        {
            if (flp_Kigui.Visible == true)
            {
                flpane_Trangchu.Visible = false;
                flp_DStuyen.Visible = false;
                flp_Banve.Visible = false;

                /// màu nền nút
                btn_Kigui.BackColor = Color.Coral;

                Btn_Trangchu.BackColor = Color.DarkOrange;
                btn_Banve.BackColor = Color.DarkOrange;
                btn_DS.BackColor = Color.DarkOrange;

                btn_DSVe.BackColor = Color.NavajoWhite;
                btn_DSTuyen.BackColor = Color.NavajoWhite;
                btn_DSXe.BackColor = Color.NavajoWhite;
                btn_DSKhach.BackColor = Color.NavajoWhite;
                btn_DSKygui.BackColor = Color.NavajoWhite;

                /// màu chữ nút
                btn_Kigui.ForeColor = Color.White;

                Btn_Trangchu.ForeColor = Color.Black;
                btn_Banve.ForeColor = Color.Black;
                btn_DS.ForeColor = Color.Black;
            }
            else
            {
                pan_DanhSach.Visible = false;

                flp_Kigui.Visible = true;
                flpane_Trangchu.Visible = false;
                flp_DStuyen.Visible = false;
                flp_Banve.Visible = false;

                /// màu nền nút
                btn_Kigui.BackColor = Color.Coral;

                Btn_Trangchu.BackColor = Color.DarkOrange;
                btn_Banve.BackColor = Color.DarkOrange;
                btn_DS.BackColor = Color.DarkOrange;

                btn_DSVe.BackColor = Color.NavajoWhite;
                btn_DSTuyen.BackColor = Color.NavajoWhite;
                btn_DSXe.BackColor = Color.NavajoWhite;
                btn_DSKhach.BackColor = Color.NavajoWhite;
                btn_DSKygui.BackColor = Color.NavajoWhite;

                /// màu chữ nút
                btn_Kigui.ForeColor = Color.White;

                Btn_Trangchu.ForeColor = Color.Black;
                btn_Banve.ForeColor = Color.Black;
                btn_DS.ForeColor = Color.Black;
            }
        }

        private void btn_DS_Click(object sender, EventArgs e)
        {
            //hien thi
            if (pan_DanhSach.Visible == true)
                pan_DanhSach.Visible = false;
            else pan_DanhSach.Visible = true;

            //chuyen màu
            if (btn_DS.BackColor == Color.Coral)
            {
                btn_DS.BackColor = Color.Coral;
                btn_DS.ForeColor = Color.White;
            }
            else
            {
                btn_DS.BackColor = Color.DarkOrange;
                btn_DS.ForeColor = Color.Black;
            }
        }

        private void btn_DSTuyen_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("test.txt", true);
            string chuoi = " ";
            string getdate = DateTime.Now.ToString();
            chuoi = "\n****    Vào lúc: " + getdate + " ---Tài khoản: " + tennd + " --->Đã mở danh sách tuyến.";
            writer.WriteLine(chuoi);
            writer.Close();

            btn_DSTuyen.BackColor = Color.Coral;
            btn_DSVe.BackColor = Color.NavajoWhite;
            btn_DSXe.BackColor = Color.NavajoWhite;
            btn_DSKhach.BackColor = Color.NavajoWhite;
            btn_DSKygui.BackColor = Color.NavajoWhite;

            Btn_Trangchu.ForeColor = Color.Black;
            btn_Banve.ForeColor = Color.Black;
            btn_Kigui.ForeColor = Color.Black;

            Btn_Trangchu.BackColor = Color.DarkOrange;
            btn_Banve.BackColor = Color.DarkOrange;
            btn_Kigui.BackColor = Color.DarkOrange;

            btn_DS.BackColor = Color.Coral;
            btn_DS.ForeColor = Color.White;

            if (flp_DStuyen.Visible == true)
            {
                flpane_Trangchu.Visible = false;
                flp_Banve.Visible = false;
                flp_Kigui.Visible = false;
                //flp_DStuyen.Visible = false;
                flp_DSVe.Visible = false;
                flp_DSXe.Visible = false;
                flp_DSKhach.Visible = false;
                flp_DSKygui.Visible = false;
            }
            else
            {
                flp_DStuyen.Visible = true;

                flpane_Trangchu.Visible = false;
                flp_Banve.Visible = false;
                flp_Kigui.Visible = false;
                //flp_DStuyen.Visible = false;
                flp_DSVe.Visible = false;
                flp_DSXe.Visible = false;
                flp_DSKhach.Visible = false;
                flp_DSKygui.Visible = false;
            }
        }

        private void btn_DSChuyenxe_Click(object sender, EventArgs e)
        {

        }

        private void btn_DSXe_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("test.txt", true);
            string chuoi = " ";
            string getdate = DateTime.Now.ToString();
            chuoi = "\n****    Vào lúc: " + getdate + " ---Tài khoản: " + tennd + " --->Đã mở danh sách xe.";
            writer.WriteLine(chuoi);
            writer.Close();

            btn_DSTuyen.BackColor = Color.NavajoWhite;
            btn_DSVe.BackColor = Color.NavajoWhite;
            btn_DSXe.BackColor = Color.Coral;
            btn_DSKhach.BackColor = Color.NavajoWhite;
            btn_DSKygui.BackColor = Color.NavajoWhite;

            Btn_Trangchu.BackColor = Color.DarkOrange;
            btn_Banve.BackColor = Color.DarkOrange;
            btn_Kigui.BackColor = Color.DarkOrange;

            Btn_Trangchu.ForeColor = Color.Black;
            btn_Banve.ForeColor = Color.Black;
            btn_Kigui.ForeColor = Color.Black;

            btn_DS.BackColor = Color.Coral;
            btn_DS.ForeColor = Color.White;

            if (flp_DSXe.Visible == true)
            {
                flpane_Trangchu.Visible = false;
                flp_Banve.Visible = false;
                flp_Kigui.Visible = false;
                flp_DStuyen.Visible = false;
                flp_DSVe.Visible = false;
                //flp_DSXe.Visible = false;
                flp_DSKhach.Visible = false;
                flp_DSKygui.Visible = false;
            }
            else
            {
                flp_DSXe.Visible = true;

                flpane_Trangchu.Visible = false;
                flp_Banve.Visible = false;
                flp_Kigui.Visible = false;
                flp_DStuyen.Visible = false;
                flp_DSVe.Visible = false;
                //flp_DSXe.Visible = false;
                flp_DSKhach.Visible = false;
                flp_DSKygui.Visible = false;
            }
        }

        private void btn_DSKhach_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("test.txt", true);
            string chuoi = " ";
            string getdate = DateTime.Now.ToString();
            chuoi = "\n****    Vào lúc: " + getdate + " ---Tài khoản: " + tennd + " --->Đã mở danh sách hành khách";
            writer.WriteLine(chuoi);
            writer.Close();

            btn_DSTuyen.BackColor = Color.NavajoWhite;
            btn_DSVe.BackColor = Color.NavajoWhite;
            btn_DSXe.BackColor = Color.NavajoWhite;
            btn_DSKhach.BackColor = Color.Coral;
            btn_DSKygui.BackColor = Color.NavajoWhite;

            Btn_Trangchu.ForeColor = Color.Black;
            btn_Banve.ForeColor = Color.Black;
            btn_Kigui.ForeColor = Color.Black;

            Btn_Trangchu.BackColor = Color.DarkOrange;
            btn_Banve.BackColor = Color.DarkOrange;
            btn_Kigui.BackColor = Color.DarkOrange;

            btn_DS.BackColor = Color.Coral;
            btn_DS.ForeColor = Color.White;

            if (flp_DSKhach.Visible == true)
            {
                flpane_Trangchu.Visible = false;
                flp_Banve.Visible = false;
                flp_Kigui.Visible = false;
                flp_DStuyen.Visible = false;
                flp_DSVe.Visible = false;
                flp_DSXe.Visible = false;
                //flp_DSKhach.Visible = false;
                flp_DSKygui.Visible = false;
            }
            else
            {
                flp_DSKhach.Visible = true;

                flpane_Trangchu.Visible = false;
                flp_Banve.Visible = false;
                flp_Kigui.Visible = false;
                flp_DStuyen.Visible = false;
                flp_DSVe.Visible = false;
                flp_DSXe.Visible = false;
                //flp_DSKhach.Visible = false;
                flp_DSKygui.Visible = false;
            }
        }

        private void btn_DSKygui_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("test.txt", true);
            string chuoi = " ";
            string getdate = DateTime.Now.ToString();
            chuoi = "\n****    Vào lúc: " + getdate + " ---Tài khoản: " + tennd + " --->Đã mở danh sách ký gửi.";
            writer.WriteLine(chuoi);
            writer.Close();

            btn_DSTuyen.BackColor = Color.NavajoWhite;
            btn_DSVe.BackColor = Color.NavajoWhite;
            btn_DSXe.BackColor = Color.NavajoWhite;
            btn_DSKhach.BackColor = Color.NavajoWhite;
            btn_DSKygui.BackColor = Color.Coral;

            Btn_Trangchu.ForeColor = Color.Black;
            btn_Banve.ForeColor = Color.Black;
            btn_Kigui.ForeColor = Color.Black;

            Btn_Trangchu.BackColor = Color.DarkOrange;
            btn_Banve.BackColor = Color.DarkOrange;
            btn_Kigui.BackColor = Color.DarkOrange;

            btn_DS.BackColor = Color.Coral;
            btn_DS.ForeColor = Color.White;

            if (flp_DSKygui.Visible == true)
            {
                flpane_Trangchu.Visible = false;
                flp_Banve.Visible = false;
                flp_Kigui.Visible = false;
                flp_DStuyen.Visible = false;
                flp_DSVe.Visible = false;
                flp_DSXe.Visible = false;
                flp_DSKhach.Visible = false;
                //flp_DSKygui.Visible = false;
            }
            else
            {
                flp_DSKygui.Visible = true;

                flpane_Trangchu.Visible = false;
                flp_Banve.Visible = false;
                flp_Kigui.Visible = false;
                flp_DStuyen.Visible = false;
                flp_DSVe.Visible = false;
                flp_DSXe.Visible = false;
                flp_DSKhach.Visible = false;
                //flp_DSKygui.Visible = false;
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult tr;
            tr = MessageBox.Show("Bạn có muốn đăng xuất hay không?",
                "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tr == DialogResult.OK)
            {
                this.Close();
                frm_login f1 = new frm_login();

                StreamWriter writer = new StreamWriter("test.txt", true);
                string chuoi = " ";
                string getdate = DateTime.Now.ToString();
                chuoi = "\n****    Vào lúc: " + getdate + " ---Tài khoản: " + tennd + " --->Đã Đăng xuất";
                writer.WriteLine(chuoi);
                writer.Close();

                f1.Show();
                //WriteLog.Write(txtTenDangNhap.Text, "Thoát chương trình");
            }
        }


        /* Sự kiện */
        private void btn_KT_Tuyen_Click(object sender, EventArgs e)
        {
            string ddi = cboDDi_Tuyen.Text;
            string dde = cboDDe_Tuyen.Text;
            List<Tuyen_DTO> lst = Tuyen_BUS.LayDSTuyenTK(ddi, dde);
            if (lst == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }
            dgDSTuyen.DataSource = lst;

        }

        private void btnTK_Xe_Click(object sender, EventArgs e)
        {
            string soxe = txt_Soxe_Xe.Text;
            string taixe = txt_Taixe_Xe.Text;
            string phuxe = txt_Phuxe_Xe.Text;
            List<Xe_DTO> lst = Xe_BUS.LayDSXETK(soxe, taixe, phuxe);
            if (lst == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }
            dgDSXe.DataSource = lst;
        }

        private void btn_Load_Xe_Click(object sender, EventArgs e)
        {
            List<Xe_DTO> lst = Xe_BUS.LayDSXE();
            dgDSXe.DataSource = lst;

            txt_Soxe_Xe.ResetText();
            txt_Taixe_Xe.ResetText();
            txt_Phuxe_Xe.ResetText();
        }

        private void btnLoad_Tuyến_Click(object sender, EventArgs e)
        {
            List<Tuyen_DTO> lst = Tuyen_BUS.LayDSTuyen();
            dgDSTuyen.DataSource = lst;


            cboDDi_Tuyen.Text = "TP. Long Xuyên";
            cboDDe_Tuyen.Text = "TP. Hồ Chí Minh";
        }

        private void btn_TK_Khach_Click(object sender, EventArgs e)
        {
            string ten = txt_TenKH_KH.Text;
            string sdt = txt_SDT_KH.Text;
            string ddi = txt_ddi_KH.Text;
            string dde = txt_dde_KH.Text;
            string soxe = cbo_Soxe_Khach.Text;
            List<HanhKhach_DTO> lst = HanhKhach_BUS.LayDSKhachTK(ten, sdt, ddi, dde, soxe);
            if (lst == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }
            dgDSKhach.DataSource = lst;
        }

        private void btnLoad_KH_Click(object sender, EventArgs e)
        {
            List<HanhKhach_DTO> lst = HanhKhach_BUS.LayDSKhach();
            dgDSKhach.DataSource = lst;

            txt_TenKH_KH.ResetText();
            txt_SDT_KH.ResetText();
            txt_ddi_KH.ResetText();
            txt_dde_KH.ResetText();
            cbo_Soxe_Khach.Text = "67A-555.66";

        }

        private void btn_TK_Kygui_Click(object sender, EventArgs e)
        {
            string nggui = txt_nggui_DSKG.Text;
            string ngnhan = txt_ngnhan_DSKG.Text;
            string soxe = cbo_Soxe_DSKG.Text;
            List<KyGui_DTO> lst = KyGui_BUS.LayDSKyGuiTK(nggui, ngnhan, soxe);
            if (lst == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }
            dgDSKygui.DataSource = lst;
        }

        private void btnLoad_KG_Click(object sender, EventArgs e)
        {
            List<KyGui_DTO> lst = KyGui_BUS.LayDSKyGui();
            dgDSKygui.DataSource = lst;

            txt_nggui_DSKG.ResetText();
            txt_ngnhan_DSKG.ResetText();
            cbo_Soxe_DSKG.Text = "67A-555.66";
        }

        private void btn_DSVe_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("test.txt", true);
            string chuoi = " ";
            string getdate = DateTime.Now.ToString();
            chuoi = "\n****    Vào lúc: " + getdate + " ---Tài khoản: " + tennd + " --->Đã mở danh sách vé.";
            writer.WriteLine(chuoi);
            writer.Close();

            btn_DSTuyen.BackColor = Color.NavajoWhite;
            btn_DSKygui.BackColor = Color.NavajoWhite;
            btn_DSXe.BackColor = Color.NavajoWhite;
            btn_DSKhach.BackColor = Color.NavajoWhite;
            btn_DSVe.BackColor = Color.Coral;

            Btn_Trangchu.ForeColor = Color.Black;
            btn_Banve.ForeColor = Color.Black;
            btn_Kigui.ForeColor = Color.Black;

            Btn_Trangchu.BackColor = Color.DarkOrange;
            btn_Banve.BackColor = Color.DarkOrange;
            btn_Kigui.BackColor = Color.DarkOrange;

            btn_DS.BackColor = Color.Coral;
            btn_DS.ForeColor = Color.White;

            if (flp_DSVe.Visible == true)
            {
                flpane_Trangchu.Visible = false;
                flp_Banve.Visible = false;
                flp_Kigui.Visible = false;
                flp_DStuyen.Visible = false;
                //flp_DSChuyenxe.Visible = false;
                flp_DSXe.Visible = false;
                flp_DSKhach.Visible = false;
                flp_DSKygui.Visible = false;
            }
            else
            {
                flp_DSVe.Visible = true;

                flpane_Trangchu.Visible = false;
                flp_Banve.Visible = false;
                flp_Kigui.Visible = false;
                flp_DStuyen.Visible = false;
                //flp_DSChuyenxe.Visible = false;
                flp_DSXe.Visible = false;
                flp_DSKhach.Visible = false;
                flp_DSKygui.Visible = false;
            }
        }

        /* đặt vé */
        private void dgDS_Tuyen_Banve_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = new DataGridViewRow();
            dr=dgDS_Tuyen_Banve.SelectedRows[0];
            cbo_MaTuyen_BanVe.Text = dr.Cells["SMa_T"].Value.ToString();
            cbo_ddi_BanVe.Text = dr.Cells["SDiaDiemDi"].Value.ToString();
            cbo_dden_BanVe.Text = dr.Cells["SDiaDiemDen"].Value.ToString();
            date_NgayChay_BanVe.Text = dr.Cells["SNgaychay"].Value.ToString();
            txt_Soxe_BanVe.Text = dr.Cells["SSo_Xe"].Value.ToString();
            txt_Gia_BanVe.Text = dr.Cells["SGiaGoc"].Value.ToString();


        }

        private void btn_TK_Banve_Click(object sender, EventArgs e)
        {
            string MaT = cbo_MaTuyen_BanVe.Text;
            string ddi = cbo_ddi_BanVe.Text;
            string dde = cbo_dden_BanVe.Text;
            List<Tuyen_DTO> lst = Tuyen_BUS.LayDSTuyenTK2(MaT, ddi, dde);
            if (lst == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }
            dgDS_Tuyen_Banve.DataSource = lst;
        }

        private void btnLoad_BanVe_Click(object sender, EventArgs e)
        {
            List<Tuyen_DTO> lst = Tuyen_BUS.LayDSTuyen();
            dgDS_Tuyen_Banve.DataSource = lst;

            cbo_MaTuyen_BanVe.Text = "HT001";
            cbo_ddi_BanVe.Text = "TP. Long Xuyên";
            cbo_dden_BanVe.Text = "TP. Hồ Chí Minh";
        }

        private void btn_Datve_Click(object sender, EventArgs e)
        {
            if(cbo_MaTuyen_BanVe.Text=="" || cbo_ddi_BanVe.Text=="" || cbo_dden_BanVe.Text== ""
                || date_NgayChay_BanVe.Text=="" || txt_Soxe_BanVe.Text=="" || txt_Gia_BanVe.Text=="")
            {
                MessageBox.Show("Hãy chọn tuyến muốn đặt vé!");
                return;
            }   
            else
            {
                string ma = cbo_MaTuyen_BanVe.Text;
                string di = cbo_ddi_BanVe.Text;
                string den = cbo_dden_BanVe.Text;
                string tg = date_NgayChay_BanVe.Text;
                string sx = txt_Soxe_BanVe.Text;
                string gia = txt_Gia_BanVe.Text;

                frm_thongtinve chuyen_DL = new frm_thongtinve(ma, di, den, tg, sx, gia);

                chuyen_DL.Show();
            }

            StreamWriter writer = new StreamWriter("test.txt", true);
            string chuoi = " ";
            string getdate = DateTime.Now.ToString();
            chuoi = "\n****    Vào lúc: " + getdate + " ---Tài khoản: " + tennd + " --->Đã đặt 1 vé.";
            writer.WriteLine(chuoi);
            writer.Close();
        }

        private void dgDS_Tuyen_Banve_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewRow dr = dgDS_Tuyen_Banve.SelectedRows[0];
            //cbo_MaTuyen_BanVe.SelectedValue = dr.Cells["SMa_T"].Value.ToString();
            //cbo_ddi_BanVe.SelectedValue = dr.Cells["SDiaDiemDi"].Value.ToString();
            //cbo_dden_BanVe.SelectedValue = dr.Cells["SDiaDiemDen"].Value.ToString();
        }

        /* DS Vé*/
        private void btn_TK_Ve_Click(object sender, EventArgs e)
        {
            string MaVe = cbo_MaVe_Ve.Text;
            string ten = txt_TenKH_Ve.Text;
            List<Ve_DTO> lst = Ve_BUS.LayDSVeTK(MaVe, ten);
            if (lst == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }
            dgDS_Ve.DataSource = lst;
        }

        private void btnLoad_Ve_Click(object sender, EventArgs e)
        {
            List<Ve_DTO> lst = Ve_BUS.LayDSVe();
            dgDS_Ve.DataSource = lst;
        }


        /* Ký gửi */
        private void txt_Khoiluong_TextChanged(object sender, EventArgs e)
        {
            if(txt_Khoiluong.Text=="")
            {
                txt_Thanhtien.Text = "";
            }
            else
            {
                float kl = float.Parse(txt_Khoiluong.Text);
                float gia = 0;
                gia = kl * 50000;

                txt_Thanhtien.Text = gia.ToString();
            }
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            // kiểm tra rỗng
            if(txt_MaKG.Text =="" || txt_Nguoigui.Text =="" || txt_nguoinhan.Text =="" ||
                cbo_Tuyen_Kigui.Text =="" || txt_Khoiluong.Text =="" || txt_Thanhtien.Text =="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }

            // Kiểm tra mã ký gửi có độ dài chuỗi hợp lệ hay không
            if (txt_MaKG.Text.Length > 5)
            {
                MessageBox.Show("Mã ký gửi tối đa 5 ký tự!");
                return;
            }
            
            // Kiểm tra mã có bị trùng không
            if (KyGui_BUS.TimKGTheoMa(txt_MaKG.Text) != null)
            {
                MessageBox.Show("Mã ký gửi đã tồn tại!");
                return;
            }

            KyGui_DTO kg = new KyGui_DTO();
            kg.SMa_KyGui = txt_MaKG.Text;
            kg.SNguoiGui = txt_Nguoigui.Text;
            kg.SNguoiNhan = txt_nguoinhan.Text;
            kg.SMa_T = cbo_Tuyen_Kigui.Text;
            kg.SKhoiLuong = float.Parse(txt_Khoiluong.Text);
            kg.SGia = float.Parse(txt_Thanhtien.Text);

            if (KyGui_BUS.ThemKyGui(kg) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }

            StreamWriter writer = new StreamWriter("test.txt", true);
            string chuoi = " ";
            string getdate = DateTime.Now.ToString();
            chuoi = "\n****    Vào lúc: " + getdate + " ---Tài khoản: " + tennd + " --->Đã thanh toán ký gửi"+kg.SMa_KyGui;
            writer.WriteLine(chuoi);
            writer.Close();

            //HienThiDSNhanVienLenDatagrid();
            //ghi file log
            StreamWriter writer1 = new StreamWriter("test.txt", true);
            string chuoi1 = " ";
            string getdate1 = DateTime.Now.ToString();
            chuoi1 = "\n****    Vào lúc: " + getdate1 + " ---Tài khoản: " + tennd + " --->Đã thanh toán 1 ký gửi.";
            writer1.WriteLine(chuoi1);
            writer1.Close();
            ////
            MessageBox.Show("Đã thanh toán.");



        }

        private void pic_BieuTuong_Click(object sender, EventArgs e)
        {
            if (pane_HienNut.Visible == true)
            {
                pane_HienNut.Visible = false;
            }
            else
                pane_HienNut.Visible = true;
        }

        private void lbl_HienthiTennguoidung_Click(object sender, EventArgs e)
        {
            if (pane_HienNut.Visible == true)
            {
                pane_HienNut.Visible = false;
            }
            else
                pane_HienNut.Visible = true;
        }

        private void pane_HienThiNguoiDung_Click(object sender, EventArgs e)
        {
            if (pane_HienNut.Visible == true)
            {
                pane_HienNut.Visible = false;
            }
            else
                pane_HienNut.Visible = true;
        }

        private void btn_DX_Click(object sender, EventArgs e)
        {
            DialogResult tr;
            tr = MessageBox.Show("Bạn có muốn đăng xuất hay không?",
                "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tr == DialogResult.OK)
            {
                this.Close();
                frm_login f1 = new frm_login();
                StreamWriter writer = new StreamWriter("test.txt", true);
                string chuoi = " ";
                string getdate = DateTime.Now.ToString();
                chuoi = "\n****    Vào lúc: " + getdate + " ---Tài khoản: " + tennd + " --->Đã Đăng xuất";
                writer.WriteLine(chuoi);
                writer.Close();

                f1.Show();

                //WriteLog.Write(tennd, "đã đăng xuất");
            }  
        }

        private void btn_DoiMK_Click(object sender, EventArgs e)
        {
            frm_DoiMK f1 = new frm_DoiMK(tennd);
            f1.Show();
        }

        private void btn_fileLog_Click(object sender, EventArgs e)
        {
            frm_XemFileLog f1 = new frm_XemFileLog();
            f1.Show();
        }

        private void btn_BC_Xe_Click(object sender, EventArgs e)
        {
            frm_RP_Ve f1 = new frm_RP_Ve();

            StreamWriter writer = new StreamWriter("test.txt", true);
            string chuoi = " ";
            string getdate = DateTime.Now.ToString();
            chuoi = "\n****    Vào lúc: " + getdate + " ---Tài khoản: " + tennd + " --->Đã xem báo cáo xe.";
            writer.WriteLine(chuoi);
            writer.Close();

            f1.Show();
        }

        private void btn_BC_Vexe_Click(object sender, EventArgs e)
        {
            frm_RP_Xe_Ghe f1 = new frm_RP_Xe_Ghe();

            StreamWriter writer = new StreamWriter("test.txt", true);
            string chuoi = " ";
            string getdate = DateTime.Now.ToString();
            chuoi = "\n****    Vào lúc: " + getdate + " ---Tài khoản: " + tennd + " --->Đã xem báo cáo vé xe.";
            writer.WriteLine(chuoi);
            writer.Close();

            f1.Show();
        }

        private void btn_HuyVe_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = new DataGridViewRow();
            dr = dgDS_Ve.SelectedRows[0];
            txt_H_MaV.Text = dr.Cells["SMA_VE"].Value.ToString();
            txt_H_ID.Text = dr.Cells["SID_HK"].Value.ToString();
            txt_H_Maghe.Text = dr.Cells["SMA_GHE"].Value.ToString();
            txt_H_MaT.Text = dr.Cells["SMa_T"].Value.ToString();
            date_H_Ngay.Text = dr.Cells["SNgayBan"].Value.ToString();
            txt_H_Noi.Text = dr.Cells["SNoiBan"].Value.ToString();

            // kiểm tra mã có tồn tại
            if (txt_H_MaV.Text == "" || Ve_BUS.TimVeTheoMa(txt_H_MaV.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn vé muốn hủy!");
                return;
            }
            Ve_DTO v = new Ve_DTO();
            v.SMA_VE = txt_H_MaV.Text;
            v.SMA_GHE = txt_H_Maghe.Text;
            v.SMa_T = txt_H_MaT.Text;
            v.SNgayBan = DateTime.Parse(date_H_Ngay.Text);
            v.SNoiBan = txt_H_Noi.Text;

            if (Ve_BUS.Xoave(v) == true)
            {
                //HienThiDSNhanVienLenDatagrid();
                MessageBox.Show("Đã xóa nhân viên.");
            }
            else
            {
                MessageBox.Show("Không xóa được.");
            }
        }

        private void dgDS_Ve_Click(object sender, EventArgs e)
        {
            /*DataGridViewRow dr = new DataGridViewRow();
            dr = dgDS_Ve.SelectedRows[0];
            txt_H_MaV.Text = dr.Cells["SMA_VE"].Value.ToString();
            txt_H_ID.Text = dr.Cells["SID_HK"].Value.ToString();
            txt_H_Maghe.Text = dr.Cells["SMA_GHE"].Value.ToString();
            txt_H_MaT.Text = dr.Cells["SMa_T"].Value.ToString();
            date_H_Ngay.Text = dr.Cells["SNgayBan"].Value.ToString();
            txt_H_Noi.Text = dr.Cells["SNoiBan"].Value.ToString();*/
        }

        private void btn_Saoluu_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog saoluuFolder = new FolderBrowserDialog();
            saoluuFolder.Description = "Chọn thư mục lưu trữ";
            if (saoluuFolder.ShowDialog() == DialogResult.OK)
            {
                string sDuongDan = saoluuFolder.SelectedPath;
                if (SaoLuu_BUS.SaoLuuDuLieu(sDuongDan) == true)
                    MessageBox.Show("Đã sao lưu dữ liệu vào " + sDuongDan);
                else
                    MessageBox.Show("Thao tác không thành công");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog phuchoiFile = new OpenFileDialog();
            phuchoiFile.Filter = "*.bak|*.bak";
            phuchoiFile.Title = "Chọn tập tin phục hồi (.bak)";
            if (phuchoiFile.ShowDialog() == DialogResult.OK &&
           phuchoiFile.CheckFileExists == true)
            {
                string sDuongDan = phuchoiFile.FileName;
                if (KhoiPhuc_BUS.Restore(sDuongDan) == true)
                    MessageBox.Show("Thành công");
                else
                    MessageBox.Show("Thất bại");
            }
        }
    }
}

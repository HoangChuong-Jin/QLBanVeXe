
namespace GUI_QLBV
{
    partial class frm_DangKy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_Top = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_TenDN = new System.Windows.Forms.TextBox();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.txt_MK = new System.Windows.Forms.TextBox();
            this.txt_MK_Lai = new System.Windows.Forms.TextBox();
            this.cbo_Quyen = new System.Windows.Forms.ComboBox();
            this.btn_DangKy = new System.Windows.Forms.Button();
            this.btn_Thoat_nut = new System.Windows.Forms.Button();
            this.panel_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.DarkOrange;
            this.panel_Top.Controls.Add(this.label1);
            this.panel_Top.Controls.Add(this.btn_Thoat);
            this.panel_Top.Location = new System.Drawing.Point(-1, -1);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(493, 95);
            this.panel_Top.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "Đăng Ký";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackgroundImage = global::GUI_QLBV.Properties.Resources.Thoat;
            this.btn_Thoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Thoat.Location = new System.Drawing.Point(455, 0);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(33, 30);
            this.btn_Thoat.TabIndex = 4;
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên đăng nhập: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mật khẩu: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nhập lại mật khẩu: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Họ tên: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Quyền: ";
            // 
            // txt_TenDN
            // 
            this.txt_TenDN.Location = new System.Drawing.Point(190, 129);
            this.txt_TenDN.Name = "txt_TenDN";
            this.txt_TenDN.Size = new System.Drawing.Size(262, 30);
            this.txt_TenDN.TabIndex = 9;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(190, 169);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(262, 30);
            this.txt_HoTen.TabIndex = 10;
            // 
            // txt_MK
            // 
            this.txt_MK.Location = new System.Drawing.Point(190, 212);
            this.txt_MK.Name = "txt_MK";
            this.txt_MK.Size = new System.Drawing.Size(262, 30);
            this.txt_MK.TabIndex = 11;
            // 
            // txt_MK_Lai
            // 
            this.txt_MK_Lai.Location = new System.Drawing.Point(190, 251);
            this.txt_MK_Lai.Name = "txt_MK_Lai";
            this.txt_MK_Lai.Size = new System.Drawing.Size(262, 30);
            this.txt_MK_Lai.TabIndex = 12;
            // 
            // cbo_Quyen
            // 
            this.cbo_Quyen.FormattingEnabled = true;
            this.cbo_Quyen.Location = new System.Drawing.Point(190, 300);
            this.cbo_Quyen.Name = "cbo_Quyen";
            this.cbo_Quyen.Size = new System.Drawing.Size(262, 30);
            this.cbo_Quyen.TabIndex = 13;
            // 
            // btn_DangKy
            // 
            this.btn_DangKy.Location = new System.Drawing.Point(134, 359);
            this.btn_DangKy.Name = "btn_DangKy";
            this.btn_DangKy.Size = new System.Drawing.Size(105, 35);
            this.btn_DangKy.TabIndex = 14;
            this.btn_DangKy.Text = "Đăng ký";
            this.btn_DangKy.UseVisualStyleBackColor = true;
            this.btn_DangKy.Click += new System.EventHandler(this.btn_DangKy_Click);
            // 
            // btn_Thoat_nut
            // 
            this.btn_Thoat_nut.Location = new System.Drawing.Point(245, 359);
            this.btn_Thoat_nut.Name = "btn_Thoat_nut";
            this.btn_Thoat_nut.Size = new System.Drawing.Size(105, 35);
            this.btn_Thoat_nut.TabIndex = 15;
            this.btn_Thoat_nut.Text = "Thoát";
            this.btn_Thoat_nut.UseVisualStyleBackColor = true;
            this.btn_Thoat_nut.Click += new System.EventHandler(this.btn_Thoat_nut_Click);
            // 
            // frm_DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(486, 416);
            this.Controls.Add(this.btn_Thoat_nut);
            this.Controls.Add(this.btn_DangKy);
            this.Controls.Add(this.cbo_Quyen);
            this.Controls.Add(this.txt_MK_Lai);
            this.Controls.Add(this.txt_MK);
            this.Controls.Add(this.txt_HoTen);
            this.Controls.Add(this.txt_TenDN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel_Top);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_DangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_DangKy";
            this.Load += new System.EventHandler(this.frm_DangKy_Load);
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_TenDN;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.TextBox txt_MK;
        private System.Windows.Forms.TextBox txt_MK_Lai;
        private System.Windows.Forms.ComboBox cbo_Quyen;
        private System.Windows.Forms.Button btn_DangKy;
        private System.Windows.Forms.Button btn_Thoat_nut;
    }
}
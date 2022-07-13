
namespace GUI_QLBV
{
    partial class frm_DoiMK
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
            this.btn_Thoat_nut = new System.Windows.Forms.Button();
            this.btn_DoiMK = new System.Windows.Forms.Button();
            this.txt_MK_moi = new System.Windows.Forms.TextBox();
            this.txt_MK = new System.Windows.Forms.TextBox();
            this.txt_TenDN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nhaplaiMK_moi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.DarkOrange;
            this.panel_Top.Controls.Add(this.label1);
            this.panel_Top.Controls.Add(this.btn_Thoat);
            this.panel_Top.Location = new System.Drawing.Point(-1, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(493, 95);
            this.panel_Top.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "Đổi mật khẩu";
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
            // btn_Thoat_nut
            // 
            this.btn_Thoat_nut.Location = new System.Drawing.Point(245, 360);
            this.btn_Thoat_nut.Name = "btn_Thoat_nut";
            this.btn_Thoat_nut.Size = new System.Drawing.Size(105, 35);
            this.btn_Thoat_nut.TabIndex = 28;
            this.btn_Thoat_nut.Text = "Thoát";
            this.btn_Thoat_nut.UseVisualStyleBackColor = true;
            this.btn_Thoat_nut.Click += new System.EventHandler(this.btn_Thoat_nut_Click);
            // 
            // btn_DoiMK
            // 
            this.btn_DoiMK.Location = new System.Drawing.Point(134, 360);
            this.btn_DoiMK.Name = "btn_DoiMK";
            this.btn_DoiMK.Size = new System.Drawing.Size(105, 35);
            this.btn_DoiMK.TabIndex = 27;
            this.btn_DoiMK.Text = "Đổi mật khẩu";
            this.btn_DoiMK.UseVisualStyleBackColor = true;
            this.btn_DoiMK.Click += new System.EventHandler(this.btn_DoiMK_Click);
            // 
            // txt_MK_moi
            // 
            this.txt_MK_moi.Location = new System.Drawing.Point(190, 212);
            this.txt_MK_moi.Name = "txt_MK_moi";
            this.txt_MK_moi.Size = new System.Drawing.Size(262, 22);
            this.txt_MK_moi.TabIndex = 25;
            // 
            // txt_MK
            // 
            this.txt_MK.Location = new System.Drawing.Point(190, 173);
            this.txt_MK.Name = "txt_MK";
            this.txt_MK.Size = new System.Drawing.Size(262, 22);
            this.txt_MK.TabIndex = 24;
            // 
            // txt_TenDN
            // 
            this.txt_TenDN.Location = new System.Drawing.Point(190, 130);
            this.txt_TenDN.Name = "txt_TenDN";
            this.txt_TenDN.Size = new System.Drawing.Size(262, 22);
            this.txt_TenDN.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Mật khẩu mới: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Mật khẩu hiện tại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tên đăng nhập: ";
            // 
            // txt_nhaplaiMK_moi
            // 
            this.txt_nhaplaiMK_moi.Location = new System.Drawing.Point(190, 254);
            this.txt_nhaplaiMK_moi.Name = "txt_nhaplaiMK_moi";
            this.txt_nhaplaiMK_moi.Size = new System.Drawing.Size(262, 22);
            this.txt_nhaplaiMK_moi.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Nhập lại mật khẩu mới: ";
            // 
            // frm_DoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(486, 416);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_nhaplaiMK_moi);
            this.Controls.Add(this.panel_Top);
            this.Controls.Add(this.btn_Thoat_nut);
            this.Controls.Add(this.btn_DoiMK);
            this.Controls.Add(this.txt_MK_moi);
            this.Controls.Add(this.txt_MK);
            this.Controls.Add(this.txt_TenDN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_DoiMK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_DoiMK";
            this.Load += new System.EventHandler(this.frm_DoiMK_Load);
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Thoat_nut;
        private System.Windows.Forms.Button btn_DoiMK;
        private System.Windows.Forms.TextBox txt_MK_moi;
        private System.Windows.Forms.TextBox txt_MK;
        private System.Windows.Forms.TextBox txt_TenDN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nhaplaiMK_moi;
        private System.Windows.Forms.Label label5;
    }
}
namespace GUI_QLBV
{
    partial class frm_flash
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
            this.components = new System.ComponentModel.Container();
            this.pro_flash = new System.Windows.Forms.ProgressBar();
            this.timer_flash = new System.Windows.Forms.Timer(this.components);
            this.pic_flash = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_flash)).BeginInit();
            this.SuspendLayout();
            // 
            // pro_flash
            // 
            this.pro_flash.BackColor = System.Drawing.Color.White;
            this.pro_flash.ForeColor = System.Drawing.Color.White;
            this.pro_flash.Location = new System.Drawing.Point(37, 139);
            this.pro_flash.Name = "pro_flash";
            this.pro_flash.Size = new System.Drawing.Size(185, 25);
            this.pro_flash.TabIndex = 4;
            // 
            // timer_flash
            // 
            this.timer_flash.Enabled = true;
            this.timer_flash.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pic_flash
            // 
            this.pic_flash.BackColor = System.Drawing.Color.Transparent;
            this.pic_flash.Image = global::GUI_QLBV.Properties.Resources.Flash;
            this.pic_flash.Location = new System.Drawing.Point(24, 21);
            this.pic_flash.Name = "pic_flash";
            this.pic_flash.Size = new System.Drawing.Size(224, 155);
            this.pic_flash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_flash.TabIndex = 3;
            this.pic_flash.TabStop = false;
            // 
            // frm_flash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 203);
            this.Controls.Add(this.pro_flash);
            this.Controls.Add(this.pic_flash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_flash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_flash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_flash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pro_flash;
        public System.Windows.Forms.Timer timer_flash;
        private System.Windows.Forms.PictureBox pic_flash;
    }
}


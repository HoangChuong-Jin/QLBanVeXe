
namespace GUI_QLBV
{
    partial class test2
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.cbo = new System.Windows.Forms.ComboBox();
            this.dataGridtes = new System.Windows.Forms.DataGridView();
            this.t1 = new System.Windows.Forms.TextBox();
            this.t2 = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridtes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.cbo);
            this.groupBox2.Location = new System.Drawing.Point(326, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(462, 157);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông khach";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(247, 36);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(197, 22);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(44, 122);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(197, 22);
            this.textBox4.TabIndex = 3;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(44, 34);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(197, 24);
            this.comboBox3.TabIndex = 0;
            // 
            // cbo
            // 
            this.cbo.FormattingEnabled = true;
            this.cbo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbo.Location = new System.Drawing.Point(247, 74);
            this.cbo.Name = "cbo";
            this.cbo.Size = new System.Drawing.Size(197, 24);
            this.cbo.TabIndex = 1;
            // 
            // dataGridtes
            // 
            this.dataGridtes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridtes.Location = new System.Drawing.Point(370, 224);
            this.dataGridtes.Name = "dataGridtes";
            this.dataGridtes.RowHeadersWidth = 51;
            this.dataGridtes.RowTemplate.Height = 24;
            this.dataGridtes.Size = new System.Drawing.Size(418, 184);
            this.dataGridtes.TabIndex = 7;
            // 
            // t1
            // 
            this.t1.Enabled = false;
            this.t1.Location = new System.Drawing.Point(45, 86);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(197, 22);
            this.t1.TabIndex = 4;
            // 
            // t2
            // 
            this.t2.Enabled = false;
            this.t2.Location = new System.Drawing.Point(45, 147);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(197, 22);
            this.t2.TabIndex = 4;
            // 
            // test2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.dataGridtes);
            this.Controls.Add(this.groupBox2);
            this.Name = "test2";
            this.Text = "test2";
            this.Load += new System.EventHandler(this.test2_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridtes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox cbo;
        private System.Windows.Forms.DataGridView dataGridtes;
        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.TextBox t2;
    }
}

namespace GUI_QLBV
{
    partial class frm_RP_Xe_Ghe
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tbl_GHEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLVXDataSet1 = new GUI_QLBV.QLVXDataSet1();
            this.tbl_VEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbl_GHETableAdapter = new GUI_QLBV.QLVXDataSet1TableAdapters.tbl_GHETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_GHEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLVXDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_VEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_GHEBindingSource
            // 
            this.tbl_GHEBindingSource.DataMember = "tbl_GHE";
            this.tbl_GHEBindingSource.DataSource = this.QLVXDataSet1;
            // 
            // QLVXDataSet1
            // 
            this.QLVXDataSet1.DataSetName = "QLVXDataSet1";
            this.QLVXDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_VEBindingSource
            // 
            this.tbl_VEBindingSource.DataMember = "tbl_VE";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbl_GHEBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI_QLBV.Report_GroupVe_Xe.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // tbl_GHETableAdapter
            // 
            this.tbl_GHETableAdapter.ClearBeforeFill = true;
            // 
            // frm_RP_Xe_Ghe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_RP_Xe_Ghe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "báo cáo xe-ghe";
            this.Load += new System.EventHandler(this.frm_RP_Khach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_GHEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLVXDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_VEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbl_VEBindingSource;
        private System.Windows.Forms.BindingSource tbl_GHEBindingSource;
        private QLVXDataSet1 QLVXDataSet1;
        private QLVXDataSet1TableAdapters.tbl_GHETableAdapter tbl_GHETableAdapter;
    }
}
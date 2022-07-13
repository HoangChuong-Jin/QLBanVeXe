
namespace GUI_QLBV
{
    partial class frm_RP_Ve
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
            this.tbl_VEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLVXDataSet = new GUI_QLBV.QLVXDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbl_VETableAdapter = new GUI_QLBV.QLVXDataSetTableAdapters.tbl_VETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_VEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLVXDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_VEBindingSource
            // 
            this.tbl_VEBindingSource.DataMember = "tbl_VE";
            this.tbl_VEBindingSource.DataSource = this.QLVXDataSet;
            // 
            // QLVXDataSet
            // 
            this.QLVXDataSet.DataSetName = "QLVXDataSet";
            this.QLVXDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbl_VEBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI_QLBV.ReportDSVe.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(950, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // tbl_VETableAdapter
            // 
            this.tbl_VETableAdapter.ClearBeforeFill = true;
            // 
            // frm_RP_Ve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_RP_Ve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo vé xe";
            this.Load += new System.EventHandler(this.frm_RP_Ve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_VEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLVXDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbl_VEBindingSource;
        private QLVXDataSet QLVXDataSet;
        private QLVXDataSetTableAdapters.tbl_VETableAdapter tbl_VETableAdapter;
    }
}
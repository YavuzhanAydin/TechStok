namespace TechStok
{
    partial class frmFaturaReport
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
            this.techStokDBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.techStokDBDataSet1 = new TechStok.TechStokDBDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.techStokDBDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techStokDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // techStokDBDataSet1BindingSource
            // 
            this.techStokDBDataSet1BindingSource.DataSource = this.techStokDBDataSet1;
            this.techStokDBDataSet1BindingSource.Position = 0;
            // 
            // techStokDBDataSet1
            // 
            this.techStokDBDataSet1.DataSetName = "TechStokDBDataSet1";
            this.techStokDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.techStokDBDataSet1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TechStok.Report.FaturaReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1208, 532);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmFaturaReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 532);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmFaturaReport";
            this.Text = "frmFaturaReport";
            this.Load += new System.EventHandler(this.frmFaturaReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.techStokDBDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techStokDBDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource techStokDBDataSet1BindingSource;
        private TechStokDBDataSet1 techStokDBDataSet1;
    }
}
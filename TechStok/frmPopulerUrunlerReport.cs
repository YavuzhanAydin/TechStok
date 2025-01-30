using BLL;
using DAL;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechStok
{
    public partial class frmPopulerUrunlerReport : Form
    {
        public frmPopulerUrunlerReport()
        {
            InitializeComponent();
        }

        private void frmPopulerUrunlerReport_Load(object sender, EventArgs e)
        {
            List<vw_TopSellingProducts> PopulerList = ProductManager.ProductGetPopular();

            this.reportViewer1.RefreshReport();
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "TechStok.Report.PopulerUrunlerReport.rdlc";
            ReportDataSource datasource = new ReportDataSource("DataSet1", PopulerList);
            reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.RefreshReport();
        }
    }
}

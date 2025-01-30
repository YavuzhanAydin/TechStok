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
    public partial class frmFaturaReport : Form
    {
        public frmFaturaReport()
        {
            InitializeComponent();
        }

        private void frmFaturaReport_Load(object sender, EventArgs e)
        {
            reportViewer1.RefreshReport();
             int siparisId = ShoppingService.ShoppingLastGetID(); // Örnek bir sipariş ID
    

            List<vSiparis> categoryStockList = ShopDetailsService.DetailsGetID(siparisId);
          
            this.reportViewer1.RefreshReport();
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "TechStok.Report.FaturaReport.rdlc";
            ReportDataSource datasource = new ReportDataSource("DataSet1", categoryStockList);
            reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.RefreshReport();




        }

        

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace LuckyDraw
{
    public partial class ViewReport : Form
    {
        public ViewReport()
        {
            InitializeComponent();
        }

        private void ViewReport_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            generateReport();
           
        }

        private void generateReport1()
        {

            try
            {
                LocalReport localReport = new LocalReport();
                localReport.ReportEmbeddedResource = "LuckyDraw.Report1.rdlc";
                localReport.SetParameters(new ReportParameter("ReportParameter1", textBox1.Text));
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void generateReport()
        {
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LuckyDraw.Report1.rdlc";
            //this.reportViewer1.LocalReport.SetParameters(new ReportParameter("ReportParameter1", textBox1.Text));
            this.reportViewer1.RefreshReport();
           
        }
    }
}

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
    public partial class LuckyDrawPrint : Form
    {
        public LuckyDrawPrint()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    LocalReport localReport = new LocalReport();
            //    localReport.ReportEmbeddedResource = "LuckyDraw.Report1.rdlc";
            //    localReport.SetParameters(new ReportParameter("ReportParameter1",textBox1.Text));
            //    localReport.Print();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
           
            CuponData data = new CuponData();
            data.Name = textBox1.Text;
            data.Count = Convert.ToInt16( printNum.Value);
            data.CuponNum = Convert.ToInt16(cuponNum.Value);
            data.enableCuponNum = enableCuponNum.Checked;
            //data.isReplicate2Col = checkText2Col.Checked;

            LuckyCuponLogger.WriteToFile(data);

            MyPrintDocument pd = new MyPrintDocument(data);
            //pd.EndPrint+=new System.Drawing.Printing.PrintEventHandler(pd_EndPrint);
            for (int i = 1; i <= printNum.Value; i++)
                pd.Print();
          cuponNum.Value=  pd.getCuponNumber();

         
           
        }
        //void pd_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        //{
        //    MyPrintDocument p = sender as MyPrintDocument;
           
        //}
        

    }
}

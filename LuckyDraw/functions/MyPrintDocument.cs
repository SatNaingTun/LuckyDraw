using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Printing;
using System.Drawing;
using System.ComponentModel;

namespace LuckyDraw
{
    class MyPrintDocument:PrintDocument
    {
        
        Font font = new Font("Arial", 16);
        CuponData docData;
         
         

        public MyPrintDocument( CuponData data)
        {
           
            docData = data;
            this.PrintPage += new PrintPageEventHandler(pd_PrintPage);
  

        }
        public int getCuponNumber()
        {
            return docData.CuponNum;
        }
      
        

        public void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
           
            //Get the Graphics object  
           
            Graphics g = ev.Graphics;

            //Create a font Arial with size 16  
            

            //Create a solid brush with black color  
            SolidBrush brush = new SolidBrush(Color.Black);

            if (docData.enableCuponNum == true)
            {
                SizeF cuponSize = new SizeF();
                cuponSize = g.MeasureString("CuponNum: " + docData.CuponNum, font);
                g.DrawString("CuponNum: " + docData.CuponNum, font, brush, new Rectangle(20, 0, Convert.ToInt16(cuponSize.Width) + 10, Convert.ToInt16(cuponSize.Height)));
            }


            SizeF stringSize = new SizeF();
            stringSize =g.MeasureString(docData.Name, font);
            //Draw "Hello Printer!";  
            g.DrawString(docData.Name, font, brush, new Rectangle(20, 20, Convert.ToInt16(stringSize.Width) + 10, Convert.ToInt16(stringSize.Height)));

            //if (docData.isReplicate2Col)
            //{
            //    if (docData.enableCuponNum == true)
            //    {
            //        SizeF cuponSize = new SizeF();
            //        cuponSize = g.MeasureString("CuponNum: " + docData.CuponNum, font);
            //        g.DrawString("CuponNum: " + docData.CuponNum, font, brush, new Rectangle(20, Convert.ToInt16(stringSize.Width) + 20, Convert.ToInt16(cuponSize.Width) + 10, Convert.ToInt16(cuponSize.Height)));
            //    }
            //    g.DrawString(docData.Name, font, brush, new Rectangle(Convert.ToInt16(stringSize.Width) + 20, 20, Convert.ToInt16(stringSize.Width) + 10, Convert.ToInt16(stringSize.Height)));
            //}
            docData.CuponNum++;
            
            
        }
      
    }
}

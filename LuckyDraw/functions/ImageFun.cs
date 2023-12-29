using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace LuckyDraw
{
   public static class ImageFun
    {
       public static Image RotateLeft90(this Image image)
       {
           
           Bitmap input = new Bitmap(image);
           Bitmap output = new Bitmap(input.Height, input.Width);
           for (int y = 0; y < input.Height; y++)
           {
               int ty = input.Width - 1;
               for (int x = 0; x < input.Width; x++)
               {
                   output.SetPixel(y, ty, input.GetPixel(x, y));
                   ty--;
               }
               
           }
           return output;
       }

       public static Image RotateRight90(this Image image)
       {
           Bitmap input = new Bitmap(image);
           Bitmap output = new Bitmap(input.Height, input.Width);
           for (int x = 0; x < input.Width; x++)
           {
               int tx = input.Height-1;
               for (int y = 0; y < input.Height; y++)  
               {
                   output.SetPixel(tx, x, input.GetPixel(x, y));
                   tx--;
               }

           }
           return output;
       }
       public static Image Rotate(this Image image, float angle)
       {
           Bitmap roteImg = new Bitmap(image.Width,image.Height);
           //roteImg.SetResolution(image.HorizontalResolution, image.VerticalResolution);
           
           Graphics g = Graphics.FromImage(roteImg);
           //g.InterpolationMode = InterpolationMode.HighQualityBicubic;
           g.TranslateTransform(image.Width / 2,image.Height / 2 );
           //g.ScaleTransform((float)1.0, (float)1.0);
           g.RotateTransform(angle);
          // g.TranslateTransform(-(image.Width / 2), image.Height / 2); 
           g.DrawImage(image, new PointF(0,0));
          

           return roteImg;
       }
       public static Image textToImage(string text,Font font)
       {
           Bitmap img = new Bitmap(400, 600);
           using ( Graphics g = Graphics.FromImage(img))
           {
               g.DrawString(text,font,Brushes.Red,new PointF(0,0));
           }
           return img;
       }
    }
}

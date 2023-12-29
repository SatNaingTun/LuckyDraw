using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using LuckyDraw.Properties;


namespace LuckyDraw
{
    public partial class LuckyDraw : Form
    {
        string[] luckydrawItem = { "You Won", "You Lose" };
        Image colorWheel = Resources.ColorWheel;
        bool isFinished;
        
        public LuckyDraw()
        {
            InitializeComponent();
        }

        private string getRandom()
        {
            Random rnd = new Random();
            int idex = rnd.Next(luckydrawItem.Length);
            return luckydrawItem[idex];
        }

        private void btnWithDraw_Click(object sender, EventArgs e)
        {

            pictureBox1.Image = colorWheel;
            waitingTime.Tick += new System.EventHandler(this.waitingTime_Tick);
            this.picRotateTime.Tick += new System.EventHandler(this.picRotateTime_Tick);
            isFinished = false;

            waitingTime.Start();

            picRotateTime.Start();

            
            
           
           

            
           
        }
        private void rotatePic()
        {
            //pictureBox1.Image = colorWheel;
            colorWheel=colorWheel.RotateLeft90();
            pictureBox1.Image = colorWheel;


            
        }

        private void picRotateTime_Tick(object sender, EventArgs e)
        {
            btnWithDraw.Enabled = false;
            rotatePic();

            
           
        }
        private void waitingTime_Tick(object sender, EventArgs e)
        {
           
            picRotateTime.Stop();

            
            waitingTime.Stop();

            if (isFinished==false)
            {
                string receivedItem = getRandom();
                pictureBox1.Image = ImageFun.textToImage(receivedItem, new Font("Times New Roman", 50, FontStyle.Bold));

                LuckyCuponLogger.WriteToFile(receivedItem);
                btnWithDraw.Enabled = true;
                isFinished = true;
            }
            

            
          

            

        }

       

       
    }
}

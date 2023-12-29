using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace LuckyDraw
{
    class LuckyCuponLogger
    {
        public static void WriteToFile(CuponData data)
        {
            try
            {
                //string path = AppDomain.CurrentDomain.BaseDirectory ;
                //if (!Directory.Exists(path))
                //{
                //    Directory.CreateDirectory(path);
                //}
                string filepath = AppDomain.CurrentDomain.BaseDirectory  +"LuckyCupponLog.txt";
             
                if (!File.Exists(filepath))
                {
                    // Create a file to write to.   
                    using (StreamWriter sw = File.CreateText(filepath))
                    {
                        //sw.WriteLine("LogType:" + logtype.ToString() + " ");
                        sw.WriteLine("Create Cuppon at " + DateTime.Now + ": ");
                        sw.WriteLine("Name:" + data.Name + "\t" + "Count:" + data.Count + "\t" + "StartCupponNum:" + data.CuponNum + "\t" + "EndCupponNum:" + (data.CuponNum + data.Count));
                        //sw.WriteLine(Message);

                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(filepath))
                    {
                        //sw.WriteLine("LogType:" + logtype.ToString() + " ");
                        sw.WriteLine("Create Cuppon at " + DateTime.Now + ": ");
                        sw.WriteLine("Name:" + data.Name + "\t" + "Count:" + data.Count + "\t" + "StartCupponNum:" + data.CuponNum + "\t" + "EndCupponNum:" + (data.CuponNum + data.Count));
                        //sw.WriteLine(Message);
                    }
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void WriteToFile(string item)
        {
            string filepath = AppDomain.CurrentDomain.BaseDirectory + "LuckyDrawLog.txt";
            if (!File.Exists(filepath))
            {
                using (StreamWriter sw = File.CreateText(filepath))
                {
                    sw.WriteLine("Create LuckyDraw at " + DateTime.Now + ": ");
                    sw.WriteLine("Lucky Draw Item:    " + item);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(filepath))
                {
                    sw.WriteLine("Create LuckyDraw at " + DateTime.Now + ": ");
                    sw.WriteLine("Lucky Draw Item:    " + item);
                }
            }
        }

    }
}

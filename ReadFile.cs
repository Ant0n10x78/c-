using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evalCsharp
{
    class ReadFile
    {
        public ReadFile()
        {
            srt tbl;
            tbl = new srt();

            Timer tp;
            tp = new Timer();

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Antonio\Documents\evalCsharp\archer.213.sc.srt");
            foreach (string line in lines)//Parcour chaque ligne du fichier srt
            {
                if (line == "")/* */
                {
                    //Saute la ligne sans caractere
                }
                else
                {
                    tbl.tri(line);
                }
                
            }
            System.Threading.Thread.Sleep(tp.wait(tbl.timer_start[0], "00:00:00,000"));
            print_reply(tp, tbl);
        }
        public void print_reply(Timer tp,srt tbl)
        {
            int k = 1;
            for (int i = 0; i < tbl.number_reply.Count(); i++) 
            {
            Console.WriteLine(tbl.reply[i]);
            System.Threading.Thread.Sleep(tp.wait(tbl.timer_start[i],tbl.timer_end[i]));
            Console.Clear();
                if (i-1< tbl.number_reply.Count())
                {
                   System.Threading.Thread.Sleep(tp.nothing_time(tbl.timer_start[i+k], tbl.timer_end[i]));
                }
            
            }
        }

        
    }
}

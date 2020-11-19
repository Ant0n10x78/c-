using System;
using System.Collections.Generic;
using System.Text;

namespace evalCsharp
{
    class srt
    {
        
        public List<int> number_reply = new List<int>();
        public List<string> timer_start = new List<string>();
        public List<string> timer_end = new List<string>();
        public List<string> reply = new List<string>();

        public int k = 0;
        public srt()
        {
        
        }
        public void tri (string line)
        {

            int i = 0;
            string s = "";
            if (int.TryParse(line, out i) && line[0] != 0)
            {
                number_reply.Add(i);
                k = 0;
            }
            else if(line[2].Equals(':')==true && line[5].Equals(':') == true )// je d
            {
                timer_start.Add(f_timer_start(line));
                timer_end.Add(f_timer_end(line));
                
                k = 0;
            }
            else
            {
                if (k == 0)
                {
                    reply.Add(line);
                    k=1;
                }
                else //concatene les deux derniere chaines
                {
                    reply[reply.Count-1] += "\n"+line; 
                }
                
            }
        }     
        
        //fonction qui pêrmet de remplacer un char dans un string
        public string ReplaceAtIndex(string text, int index, char c)
        {
            var stringBuilder = new StringBuilder(text);
            stringBuilder[index] = c;
            return stringBuilder.ToString();
        }
        //fonction qui retourne une chaine de caracteres contenant le temps
        public string f_timer_start (string line)
        {
            string s = "00:00:00.000";
            for (int i =0;i<11;i++)
            {
                s = ReplaceAtIndex(s,i,line[i]);
            }
            return s;
        }
        public string f_timer_end(string line)
        {
            string s = "00:00:00.000";
            
            
            for (int i = 17; i < 28; i++)
            {
                s = ReplaceAtIndex(s, i-17, line[i]);
           
            }
            return s;
        }
    }
}

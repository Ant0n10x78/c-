using System;
using System.Timers;
using System.Collections.Generic;
using System.Text;

public class Timer
{
    public static System.Timers.Timer aTimer;
    private int f = 0;
    private int s = 0;
    private int m = 0;
    private int h = 0;
    public Timer()
    {
        
        
    }
    public int wait(string start,string end)//retourne le temps d'affichage de chaque replique
    {
        int x = fff(start,end);
        x = Math.Abs(x);
        x += ss(start, end);
        x = Math.Abs(x);
        x += mm(start, end);
        x = Math.Abs(x);
        x += hh(start, end);
        x = Math.Abs(x);
        return x;
    }

    public int nothing_time(string start, string end)//retourne le temps d'affiche entre chaque replique
    {
        int x = fff(end, start);
        x += ss(end, start);
        x = Math.Abs(x);
        x += mm(end, start);
        x = Math.Abs(x);
        x += hh(end, start);
        x = Math.Abs(x);
        return x;
    }
    private int fff(string a,string b)//retourne une valeur en fff
    {
        int resultat = 0;
        int i = 0;
        string xa = "000";
        string xb = "000";
        xa = ReplaceAtIndex(xa, 0, a[9]);
        xa = ReplaceAtIndex(xa, 1, a[10]);
        xa = ReplaceAtIndex(xa, 2, a[11]);

        xb = ReplaceAtIndex(xb, 0, b[9]);
        xb = ReplaceAtIndex(xb, 1, b[10]);
        xb = ReplaceAtIndex(xb, 2, b[11]);

        int.TryParse(xa, out i);
        resultat = i;
        int.TryParse(xb, out i);
        resultat = resultat - i ;

        return resultat;
    }
    private int ss(string a, string b)//retourne une valeur en fff
    {
        int resultat = 0;
        int i = 0;
        string xa = "00";
        string xb = "00";
        xa = ReplaceAtIndex(xa, 0, a[6]);
        xa = ReplaceAtIndex(xa, 1, a[7]);
     
        xb = ReplaceAtIndex(xb, 0, b[6]);
        xb = ReplaceAtIndex(xb, 1, b[7]);
       
        int.TryParse(xa, out i);
        resultat = i;
        int.TryParse(xb, out i);
        resultat = resultat - i;

        return resultat*1000;
    }
    private int mm(string a, string b)//retourne une valeur en fff
    {
        int resultat = 0;
        int i = 0;
        string xa = "00";
        string xb = "00";
        xa = ReplaceAtIndex(xa, 0, a[3]);
        xa = ReplaceAtIndex(xa, 1, a[4]);

        xb = ReplaceAtIndex(xb, 0, b[3]);
        xb = ReplaceAtIndex(xb, 1, b[4]);

        int.TryParse(xa, out i);
        resultat = i;
        int.TryParse(xb, out i);
        resultat = resultat - i;

        return resultat*60000;
    }

    private int hh(string a, string b)//retourne une valeur en fff
    {
        int resultat = 0;
        int i = 0;
        string xa = "00";
        string xb = "00";
        xa = ReplaceAtIndex(xa, 0, a[0]);
        xa = ReplaceAtIndex(xa, 1, a[1]);

        xb = ReplaceAtIndex(xb, 0, b[0]);
        xb = ReplaceAtIndex(xb, 1, b[1]);

        int.TryParse(xa, out i);
        resultat = i;
        int.TryParse(xb, out i);
        resultat = resultat - i;

        return resultat*60*60000;
    }

    //fonction qui permet de remplacer un char dans un string
    public string ReplaceAtIndex(string text, int index, char c)
    {
        var stringBuilder = new StringBuilder(text);
        stringBuilder[index] = c;
        return stringBuilder.ToString();
    }

}
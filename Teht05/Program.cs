using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht05
{
    class Program
    {
        static void Main(string[] args)
        {
            int h, min, sek, luku;
            Console.WriteLine("Anna sekuntit:");
            luku = int.Parse(Console.ReadLine());
            h = (luku / 3600);
            min = luku / 60 - h * 60;
            sek = luku % 60;
            Console.WriteLine("Sekunnit voi myös ilmaista seuraavasti: " + h + " Tunnia " + min + " minuuttia " + sek +" sekuntia");
        }
    }
}

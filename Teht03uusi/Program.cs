using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03uusi
{
    class Program
    {
        static void Main(string[] args)
        {
            double luku1, luku2, luku3, sum, avrg;
            Console.WriteLine("Anna kolme lukua:  ");
            luku1 = double.Parse(Console.ReadLine());
            luku2 = double.Parse(Console.ReadLine());
            luku3 = double.Parse(Console.ReadLine());
            sum = (luku1 + luku2 + luku3);
            avrg = (sum / 3.0);
            Console.WriteLine("summa on " + sum);
            Console.WriteLine("Keskiarvo on " + avrg);
        }
    }
}

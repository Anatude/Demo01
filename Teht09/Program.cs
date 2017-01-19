using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht09
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku1, summa;

            
            summa = 0;

            do
            {
                Console.WriteLine("Anna luku");
                luku1 = int.Parse(Console.ReadLine());
                summa = summa + luku1;
            } while (luku1 != 0);
            Console.WriteLine("lukujen summa on: " + summa);


        }
    }
}

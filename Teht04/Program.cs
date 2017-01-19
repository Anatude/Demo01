using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Anna ikäsi: ");
            age = int.Parse(Console.ReadLine());

            if (age >=0 && age <= 17)
            {
                Console.WriteLine("Alaikäinen");
            }
            if (age >= 18 && age <= 65)
            {
                Console.WriteLine("Aikuinen");
            }
            if (age >= 66)
            {
                Console.WriteLine("Seniori");
            }

        }
    }
}

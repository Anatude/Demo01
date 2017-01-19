using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht06
{
    class Program
    {
        static void Main(string[] args)
        {
            int matka;
            double bensa, hinta;
            Console.WriteLine("Polttoaineen hinta: 1,595euroa\nAnna ajettu matka: ");
            matka = int.Parse(Console.ReadLine());
            bensa = matka * 0.0702;
            hinta = bensa * 1.595;
            Console.WriteLine("Polttoainetta kuluu matkalla: " + bensa + "l Hinnaksi tulee: " + hinta + "euroa");
        }
    }
}

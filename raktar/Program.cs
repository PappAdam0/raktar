using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace raktar
{
    class Program
    {
        static void Main(string[] args)
        {
            termek t = new termek("P0","Polo XXL",1500,10);
            Console.WriteLine($"{t.KOD} - {t.NEV} - {t.AR} - {t.DB}");


            Console.ReadKey();
        }
    }
}

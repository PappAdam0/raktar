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
        static List<termek> termekek = new List<termek>();
        static List<megrendeles> megrendelesek = new List<megrendeles>();
        static void BeolvasRaktar()
        {
            StreamReader raktar = new StreamReader("raktar.csv");
            

            while (!raktar.EndOfStream)
            {
                string[] sor = raktar.ReadLine().Split(';');
                termek t = new termek(sor[0], sor[1], int.Parse(sor[2]), int.Parse(sor[3]));
                termekek.Add(t);
            }
            raktar.Close();
        }
        static void BeolvasMegrendeles()
        {
            StreamReader rendeles = new StreamReader("rendeles.csv");

            while (!rendeles.EndOfStream)

            {

                string sor = rendeles.ReadLine();
                string[] adat = sor.Split(';');

                
                if (adat[0] == "M")
                {
                    megrendeles m = new megrendeles(adat[1], adat[2], adat[3]);
                    megrendelesek.Add(m);
                }
                else
                {
                    //megrendelesek[megrendelesek.Count - 1].tetelek.Add(sor);
                    megrendelesek[megrendelesek.Count - 1].TetelHozzaad(adat[2], int.Parse(adat[3]));

                }

            }
            rendeles.Close();
            
        }

        static void Main(string[] args)
        {
            //BeolvasRaktar();
            BeolvasMegrendeles();
            /*foreach (var t in termekek)
            {
                Console.WriteLine(t.NEV);
            }*/
            foreach (var m in megrendelesek)
            {
                Console.WriteLine($"{m.DATUM} {m.KOD} {m.EMAIL}");
            }

            Console.ReadKey();
        }
    }
}

﻿using System;
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
        static void BeolvasRaktar()
        {
            StreamReader raktar = new StreamReader("raktar.csv");

            while (!raktar.EndOfStream)
            {
                string[] sor = raktar.ReadLine().Split(';');
                termekek.Add(new termek(sor[0], sor[1], int.Parse(sor[2]), int.Parse(sor[3])));
            }


            raktar.Close();
        }
        static void Main(string[] args)
        {
            BeolvasRaktar();


            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Harjoitus_12_KT
{
    class Program
    {
        static void Main(string[] args)
        {
            int e = 1;
            List<string> pakka = new List<string>();

            for (int i = 0; i < 13; i++)
            {
                pakka.Add( "Pata : " + (i + 1));
                pakka.Add("Hertta : " + (i + 1));
                pakka.Add("Risti : " + (i + 1));
                pakka.Add("Ruutu  : " + (i + 1));
            }
            Console.WriteLine();
            Console.WriteLine("Kortit on lisätty pakkaan.");
            foreach (string kortti in pakka)
            {
                Console.WriteLine(kortti);
            }
            var rnd = new Random();
            var randomized = pakka.OrderBy(item => rnd.Next());
            Console.WriteLine();
            foreach (var value in randomized)
            {
                Console.WriteLine("{0}" + value, e);
                e++;
            }
            Console.ReadLine();
        }
    }
}
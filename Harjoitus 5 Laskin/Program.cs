using System;

namespace tehtävä5Laskin
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 5.0f;
            float b = 2.5f;


            float Summa = Laskin.Summa(a, b);
            float Erotus = Laskin.Erotus(a, b);
            float Jakolasku = Laskin.Jakolasku(a, b);
            float kertolasku = Laskin.Kertolasku(a, b);
            Console.WriteLine("Numeroiden {0} ja {1}:", a, b);
            Console.WriteLine("Summa: " + Summa);
            Console.WriteLine("Erotus:  " + Erotus);
            Console.WriteLine("Kertolasku:   " + kertolasku);
            Console.WriteLine("Jakolasku:   " + Jakolasku);
        }
    }
}



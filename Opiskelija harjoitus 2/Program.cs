using System;

namespace Opiskelija_harjoitus_2
{
    class Program
    {
        static void Main(string[] args)
        {
            opiskelija Opiskelija = new opiskelija("Matti", "132409A4442", 21);
            Opiskelija.TulostaData();
            Opiskelija.MuokkaaOpintopisteitä(21);
            Opiskelija.TulostaData();
        }
    }
}
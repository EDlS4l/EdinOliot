using System;
using System.Collections.Generic;
using System.Text;

namespace Kiuas_harjoitus_3
{
    class Kiuas
        static void Main(string[] args)
    {
        public string Merkki;
        public string Lampotila;
        public int Kosteus;
        public bool Tila;

        public Kiuas(string merkki, int lampotila, int kosteus);

        Merkki = merkki;
        Lampotila = lampotila;
        Kosteus = kosteus;
        Tila = false; //Alussa tila on aina false
        

    public void HaeTiedot()
    {
        Console.WriteLine("");
        if (Tila == true)
        {
            Console.WriteLine("Kiaus" + Merkki + "on päällä");
            Console.WriteLine(" -Lämpötila: " + Lampotila);
            Console.WriteLine(" -Kosteus:" + Kosteus);
        }
        else
        {
            Console.WriteLine("Kiuas" + Merkki + "ei ole päällä" );
        }
    }
}


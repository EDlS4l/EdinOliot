using System;
using System.Collections.Generic;
using System.Text;

namespace Ajoneuvo_harjoitus_1
{
    class ajoneuvo
    {
        public string Nimi { get; set; }
        public int Nopeus { get; set; }
        public int Renkaat { get; set; }

        public void TulostaData()
        {
            Console.WriteLine("Ajoneuvo:  ");
            Console.WriteLine(" --Merkki: " + Nimi);
            Console.WriteLine(" --Nopeus: " + Nopeus);
            Console.WriteLine(" --Renkaat" + Renkaat);
        }
        //public string ToString()
        //{

        //}
    }
}

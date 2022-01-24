using System;
using System.Collections.Generic;
using System.Text;

namespace Albumi4
{
    class Albumi

    {


        public string Artisti { get; set; }
        public string Nimi { get; set; }
        public string Genre { get; set; }
        public string Hinta { get; set; }
        public string Kappaleet { get; set; }



        List<string> PriceList = new List<string>(5);


        public void Tulostakappaleet()
        {
            PriceList.Add("tyttöni mun");
            PriceList.Add("Kagapylly");
            PriceList.Add("koira bileet");
            PriceList.Add("katkarapu salaatti");
            PriceList.Add("Nakki Bileet");
        }


        public void Tulostadata()
        {
            Console.WriteLine("Albumi");
            Console.WriteLine("--- Artisti:" + Artisti);
            Console.WriteLine("--- Nimi:" + Nimi);
            Console.WriteLine("---Genre:" + Genre);
            Console.WriteLine("---Hinta:" + Hinta);
            Console.WriteLine("---Kappaleet:" + Kappaleet);
            PriceList.Sort();
            PriceList.ForEach(Console.WriteLine);
        }



    }
}


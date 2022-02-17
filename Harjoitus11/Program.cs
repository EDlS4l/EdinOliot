using System;
using System.Collections.Generic;

namespace Harjoitus_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Opiskelija> opiskelijat = new Dictionary<int, Opiskelija>();
            string syöte;

            while (true)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("Mitä haluat tehdä?");
                Console.WriteLine("1) Lisää opiskelijan - Lisää opiskelijaa kokoelmaan");
                Console.WriteLine("2) Poista - Poistaa opiskelijan kokoelmasta");
                Console.WriteLine("3) Tulosta - Tulostaa opiskelija kokoelman");
                Console.WriteLine("4) Poistu - Poistuu sovelluksesta");

                syöte = Console.ReadLine();

                switch (syöte)
                {
                    case "Lisää":

                        LisääOpiskelija(opiskelijat);
                        break;
                    case "poista":

                        PoistaOpiskelija(opiskelijat);
                        break;
                    case "tulosta":

                        TulostaOpiskelijat(opiskelijat);
                        break;
                    case "Poistu":

                        return;
                    default:
                        break;
                }
            }
        }

        static void LisääOpiskelija(Dictionary<int, Opiskelija> opiskelijat)
        {
            Opiskelija uusiOpiskelija = new Opiskelija();

            while (true)
            {
                Console.WriteLine("Anna uudelle opiskelijalle tiedot:");
                Console.WriteLine("Etunimi: ");
                uusiOpiskelija.Enimi = Console.ReadLine();
                Console.WriteLine("Sukunimi: ");
                uusiOpiskelija.Snimi = Console.ReadLine();
                Console.WriteLine("Ryhmätunnus: ");
                uusiOpiskelija.Ryhmätunnus = Console.ReadLine();
                Console.WriteLine("OpiskelijaID: ");
                uusiOpiskelija.OpiskelijaNum = Convert.ToInt32(Console.ReadLine());

                if (opiskelijat.ContainsKey(uusiOpiskelija.OpiskelijaNum))
                {
                    Console.WriteLine("Opiskelija sanakirjassa on opiskelija samalla ID:llä");
                    
                }
                else
                {
                    opiskelijat.Add(uusiOpiskelija.OpiskelijaNum, uusiOpiskelija);
                    break;
                }
            }
        }

        static void PoistaOpiskelija(Dictionary<int, Opiskelija> opiskelijat)
        {
            Console.WriteLine("Anna opiskelijanID jonka haluat poistaa:");
            int syöte = Convert.ToInt32(Console.ReadLine());

            if (opiskelijat.ContainsKey(syöte))
            {
                Console.WriteLine("Opiskelija " + opiskelijat[syöte].Enimi + " on poistettu.");
            }
            else
            {
                Console.WriteLine("Opiskelijaa ID:llä " + syöte + " ei  ole löydetty, ");
            }

            opiskelijat.Remove(syöte);
        }

        static void TulostaOpiskelijat(Dictionary<int, Opiskelija> opiskelijat)
        {
            foreach (Opiskelija item in opiskelijat.Values)
            {
                item.TulostaTiedot();
            }
        }
    }
}

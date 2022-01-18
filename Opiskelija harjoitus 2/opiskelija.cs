using System;
using System.Collections.Generic;
using System.Text;

namespace Opiskelija_harjoitus_2
{       class opiskelija
        {
        private string Nimi { get; set; }
        private string OpiskelijaID { get; set; }
        private int Opintopisteet { get; set; }

        //Konstruktori "Opiskelija"  luokalle

        public opiskelija(string _nimi, string _id, int _op)
        {
           Nimi = _nimi;        //Opiskelijan nimi
           OpiskelijaID = _id;  //OpiskelijanID
           Opintopisteet = _op; //Opintopisteet

        }
        //Kirjoitetaan tieto Oppilaasta.
        public void TulostaData()
        {
            Console.WriteLine("Opiskelija: ");
            Console.WriteLine("--Opiskelijan nimi:  " + Nimi);
            Console.WriteLine("--Opiskelijan ID: " + OpiskelijaID);
            Console.WriteLine("--Opintopisteet: " + Opintopisteet);
            Console.WriteLine("");
        }
        public void MuokkaaOpintopisteitä(int i)
        {
            Opintopisteet += i;

            if (Opintopisteet < 0)
            {
                Opintopisteet = 0;
            }
        }



    }
}


    

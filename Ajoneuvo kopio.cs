﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ajoneuvo4
    class ajoneuvo
    {   public string Nimi { get; set; }
        public int Nopeus { get; set; }
        public int Renkaat { get; set; }

        public void TulostaData()
        {
            Console.WriteLine("Ajoneuvo: ");
            Console.WriteLine("-- Nimi:" + Nimi);
            Console.WriteLine("-- Nopeus:" + Nopeus);
            Console.WriteLine("-- Renkaat:" + Renkaat);
        }

        public string ToString()


        {
            string merkkijono = "Ajoneuvon nimi:" + Nimi + "Nopeus" + Nopeus + "km/h. Renkaat: " + Renkaat + "kpl";

            return merkkijono;
        }




    }
}


    

    


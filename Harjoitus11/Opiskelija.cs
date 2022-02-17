using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_11
{
    class Opiskelija
    {
        public string Enimi;
        public string Snimi;
        public string Ryhmätunnus;
        public int OpiskelijaNum;

        public void TulostaTiedot()
        {
            Console.WriteLine("Opiskelija : {0} {1}. Ryhmätunnus :  {2}. Opiskelijan Numero :  {3}", Enimi, Snimi, Ryhmätunnus, OpiskelijaNum);
        }
    }
}
using System;

namespace Kiuas_harjoitus_3
{
    class Kiuas
    {
        static void Main(string[] args)
        {
            Kiuas kiuas1 = new Kiuas("Harvia", 0);



            kiuas1.onOFF();




            kiuas1.MuokkaaKosteutta(10);
            kiuas1.MuokkaaLämpötilaa(120);
            kiuas1.Tulostadata();
            kiuas1.onOFF();







        }
    }
}
    


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus9
{
    internal class Kanava
    {
        public string nimi { get; set; }
        public string Kesto { get; set; }
        private decimal taajuus { get; set; }

        private readonly decimal MaxTaajuus = 107.9M;
        private readonly decimal MinTaajuus = 88.0M;

        public decimal Taajuus
        {
            get { return taajuus; }
            set
            {
                if (value > MaxTaajuus)
                {
                    value = MaxTaajuus;
                }
                else if (value < MinTaajuus)
                {
                    value = MinTaajuus;

                }
                taajuus = value;
            }
        }
    

            public Kanava(string _nimi, decimal _tajuus)
            {
                nimi = _nimi;
                taajuus = _tajuus;
            }
           public void TulostaKanava()
           {
            Console.WriteLine();
            Console.WriteLine("--- Radio kanava:  " + nimi);
            Console.WriteLine("--- Kappale soimassa:  ");
           }
           


            public void TulostaPopKanava()
            {
                
            }
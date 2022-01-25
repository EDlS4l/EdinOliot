using System;
using System.Collections.Generic;
using System.Text;

namespace Vahvistintehtävä
{
    class Vahvistincs
    {
        private int äänenvoimakkuus;
        public int Äänenvoimakkuus1
        { 
            get => äänenvoimakkuus;
            set
            {
                if (value > 100)
                {
                    Console.WriteLine("Arvoksi annettiin yli 100");
                }
                else if (value < 0)
                {
                    Console.WriteLine("Annettu arvo oli pienempi kuin 0 (sen pitäisi olla 0-100) ");
                    value = 0;
                }
                Console.WriteLine("Äänenvoimakkuus on asetettu " + value);

                äänenvoimakkuus = value;
               
            }
        

        
        }
    }
}   


using System;
using System.Collections.Generic;
using System.Text;

namespace Tehävä6Eläin
{
    class Kettu : Eläin
    {
        private static int instanssit = 0;

        public Kettu()
        {
            instanssit++;
        }
        public static new void KuinkaMonta()
        {
            Console.WriteLine("Kettu luotu " + instanssit);
        }
        public override void Ääntele()
        {
            Console.WriteLine("Meow Meow!");
        }
    }
}

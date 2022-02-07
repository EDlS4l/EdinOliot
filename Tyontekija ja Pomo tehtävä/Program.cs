using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        Tyontekija.KuinkaMonta();







        Henkilo henkilo1 = new Henkilo(55, 4000, "jari sillanpää");
        henkilo1.Ääntele();









        Pomo pomo2 = new Pomo(55, 4000, "Pekka Järvinen", "SAAB", 300);
        Pomo.KuinkaMonta();
        Tyontekija.KuinkaMonta();
        Henkilo.KuinkaMonta();
        Tyontekija.KuinkaMonta();





    }
}

usingRajapinnat;

usingSystem;

usingSystem.Collections.Generic;

usingSystem.Linq;

usingSystem.Text;

usingSystem.Threading.Tasks;



classprogram

{

    staticvoid Main(string[] args)

    {

        Varisvaris = new Varis("Varis", 90);



        varis.MakeAsound();

        varis.fly();



        Ahvenahven = new Ahven("ahven", 50, "blups");



        ahven.MakeAsound();

        ahven.Swim();

        Console.ReadLine();



        Sorsasorsa = new Sorsa("Sorsa", 90, 10);



        sorsa.MakeAsound();

        sorsa.Swim();

        sorsa.MakeAsound();





    }

}
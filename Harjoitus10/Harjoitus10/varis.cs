usingSystem;

usingSystem.Collections.Generic;

usingSystem.Linq;

usingSystem.Text;

usingSystem.Threading.Tasks;



namespaceRajapinnat

{

classVaris: Eläin, ICanFly

{

        publicfloat WingSize { get; set; }



        publicVaris(string_nimi, float _WingSize)



{

            nimi = _nimi;

            WingSize = _WingSize;



        }



        publicvoid fly()

        {

            Console.WriteLine("{0} Lentää siipien koko on {1}", nimi, WingSize);

        }



        publicoverride void MakeAsound()

        {

            Console.WriteLine("Kaakw Kaakw");

        }



    }





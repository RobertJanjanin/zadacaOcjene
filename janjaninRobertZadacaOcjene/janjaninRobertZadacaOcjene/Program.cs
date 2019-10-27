using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace janjaninRobertZadacaOcjene
{
    class Program
    {
        static void Main(string[] args)
        {
            int ocjena;
            
            Console.WriteLine("Upisite ocjenu");
            ocjena = Convert.ToInt16(Console.ReadLine());


            do
            {

                if (ocjena == 1)
                {
                    Console.WriteLine("Prosjek upisanih ocjena: 1 ");

                }
                if (ocjena < 1 || ocjena > 5)
                {
                    Console.WriteLine("Upisali ste krivu ocjenu");

                }

                if (ocjena == 2)
                {
                    Console.WriteLine("Upisali ste ocjenu 2");

                }

                if (ocjena == 3)
                {
                    Console.WriteLine("Upisali ste ocjenu 3");
                }

                if (ocjena == 4)
                {
                    Console.WriteLine("Upisali ste ocjenu 4");
                }

                if (ocjena == 5)
                {
                    Console.WriteLine("Upisali ste ocjenu 5");
                }
            } while (ocjena != 0 || ocjena <6);

                Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЦепочкаОбязанностей
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight knight1 = new Knight("First", 20);
            /*Knight knight2 = new Knight("Second", 30);*/
            Knight knight3 = new Knight("Third", 50);

            knight1.SetNextHero(knight3);
            /*knight2.SetNextHero(knight3);*/

            Dragon dragon = new Dragon(60);

            if (knight1.Handle(dragon))
            {
                Console.WriteLine("Wiiiiiin!");
            }

            Console.ReadLine();
        }
    }
}

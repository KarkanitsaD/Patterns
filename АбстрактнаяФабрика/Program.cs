using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace АбстрактнаяФабрика
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractCharectersFactory factory = new ElfFactory();
            AbstractAirCharecter airCharecter = factory.CreateAirCharecter();
            airCharecter.Fly();

            factory = new UndeadFactory();
            factory.CreateTerrestialCharecter().Run();

            Console.ReadKey();
        }
    }
}

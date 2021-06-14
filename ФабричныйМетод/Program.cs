using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ФабричныйМетод
{
    class Program
    {
        static void Main(string[] args)
        {
            PrivateHouseFactory privateHouseFactory = new PrivateHouseFactory("Build your house OAO");
            privateHouseFactory.BuildHouse();

            DwellingHouseFactory dwellingHouseFactory = new DwellingHouseFactory("Stoi dom OOO");
            dwellingHouseFactory.BuildHouse();

            Console.Read();
        }
    }
}

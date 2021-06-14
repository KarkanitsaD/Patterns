using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ФабричныйМетод
{
    public class DwellingHouseFactory:HouseFactory
    {
        public DwellingHouseFactory(string name) : base(name)
        {

        }
        public override House BuildHouse()
        {
            return new DwellingHouse();
        }
    }
}

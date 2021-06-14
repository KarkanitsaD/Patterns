using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ФабричныйМетод
{
    public class PrivateHouseFactory : HouseFactory
    {
        public PrivateHouseFactory(string name) : base(name)
        {

        }
        public override House BuildHouse()
        {
            return new PrivateHouse();
        }
    }
}

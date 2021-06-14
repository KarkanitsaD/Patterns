using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace АбстрактнаяФабрика
{
    public class UndeadFactory : AbstractCharectersFactory
    {
        public override AbstractAirCharecter CreateAirCharecter()
        {
            return new AirGoblin();
        }

        public override AbstractTerrestialCharecter CreateTerrestialCharecter()
        {
            return new TerrestialGoblin();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace АбстрактнаяФабрика
{
    public class ElfFactory : AbstractCharectersFactory
    {
        public override AbstractAirCharecter CreateAirCharecter()
        {
            return new AirElf();
        }

        public override AbstractTerrestialCharecter CreateTerrestialCharecter()
        {
            return new TerrestialElf();
        }
    }
}

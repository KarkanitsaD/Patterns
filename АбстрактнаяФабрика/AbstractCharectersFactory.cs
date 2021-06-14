using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace АбстрактнаяФабрика
{
    public abstract class AbstractCharectersFactory
    {
        public abstract AbstractTerrestialCharecter CreateTerrestialCharecter();
        public abstract AbstractAirCharecter CreateAirCharecter();
    }
}

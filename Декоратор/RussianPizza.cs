using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Декоратор
{
    public class RussianPizza: Pizza
    {
        public RussianPizza() : base("Russian pizza") { }

        public override int GetCost()
        {
            return 100;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Декоратор
{
    public class TomatoPizzaDecorator : PizzaDecorator
    {

        public TomatoPizzaDecorator(Pizza p)
        : base(p.Name + ", with tomato", p)
        { }
        public override int GetCost()
        {
            return pizza.GetCost() + 2;
        }
    }
}

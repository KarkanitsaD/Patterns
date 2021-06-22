using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Декоратор
{
    public abstract class PizzaDecorator: Pizza
    {
        protected Pizza pizza;
        public PizzaDecorator(string n, Pizza p) : base(n)
        {
            pizza = p;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Декоратор
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = new ItalianPizza();
            Pizza p = new TomatoPizzaDecorator(pizza);

            Console.WriteLine(p.GetCost());

            Console.Read();
        }
    }
}

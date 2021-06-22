using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Декоратор
{
    public abstract class Pizza
    {
        public Pizza(string name)
        {

        }

        public string Name { get; set; }
        public abstract int GetCost();
    }
}

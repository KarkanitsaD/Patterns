using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace АбстрактнаяФабрика
{
    public class TerrestialGoblin : AbstractTerrestialCharecter
    {
        public override void Run()
        {
            Console.WriteLine("I'am terrastial goblin. I run 10 km/h.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace АбстрактнаяФабрика
{
    public class TerrestialElf : AbstractTerrestialCharecter
    {
        public override void Run()
        {
            Console.WriteLine("I'am terrastial elf. I run 25 km/h.");
        }
    }
}

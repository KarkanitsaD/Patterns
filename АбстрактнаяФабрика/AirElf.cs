using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace АбстрактнаяФабрика
{
    public class AirElf : AbstractAirCharecter
    {
        public override void Fly()
        {
            Console.WriteLine("I'am flying elf. I fly on pegasus!");
        }
    }
}

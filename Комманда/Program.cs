using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Команда
{
    class Program
    {
        static void Main(string[] args)
        {
            Pult pult = new Pult();
            TV tv = new TV();

            pult.SetCommand(new TVOnCommand(tv));
            pult.PressOnButton();
            pult.PressOffButton();

            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Прототип
{
    class Program
    {
        static void Main(string[] args)
        {
            IFigure figure = new Rectangle(4,10);
            figure.GetInfo();

            IFigure clone = figure.Clone();
            clone.GetInfo();


            Console.ReadKey();

        }
    }
}

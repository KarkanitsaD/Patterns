using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Прототип
{
    public class Circle : IFigure
    {
        private int radius;

        public Circle(int r)
        {
            radius = r;
        }

        public IFigure Clone()
        {
            return new Circle(radius);
        }

        public void GetInfo()
        {
            Console.WriteLine($"Radius = {radius}");
        }
    }
}

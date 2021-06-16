using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ШаблонныйМетод
{
    class Program
    {
        static void Main(string[] args)
        {
            Delivery del = new CarDelivery();
            del.Deliver();

            del = new TrainDelivery();
            del.Deliver();

            Console.Read();
        }
    }
}

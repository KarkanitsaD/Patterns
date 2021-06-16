using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ШаблонныйМетод
{
    public class CarDelivery : Delivery
    {
        public override void DeliverToPickUpPoint()
        {
            Console.WriteLine("Доставка товара машиной по дорогам.");
        }

        public override void PackOrder()
        {
            Console.WriteLine("Упаковка товара.");
        }

        public override void ReciveOrder()
        {
            Console.WriteLine("Получение товара");
        }
    }
}

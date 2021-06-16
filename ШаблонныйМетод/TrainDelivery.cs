using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ШаблонныйМетод
{
    public class TrainDelivery : Delivery
    {
        public override void DeliverToPickUpPoint()
        {
            Console.WriteLine("Доставляем вашу посылку поездом.");
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

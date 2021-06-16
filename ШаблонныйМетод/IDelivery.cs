using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ШаблонныйМетод
{
    public abstract class Delivery
    {
        public void Deliver()
        {
            ReciveOrder();
            PackOrder();
            DeliverToPickUpPoint();
        }
        public abstract void ReciveOrder();
        public abstract void PackOrder();
        public abstract void DeliverToPickUpPoint();
    }
}

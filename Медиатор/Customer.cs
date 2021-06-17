using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Медиатор
{
    public class Customer : AbstractTeamMember
    {
        public Customer(AbstractManager manager): base(manager) { }
        public override void Notify(string message)
        {
            Console.WriteLine("Message to customer: " + message);
        }
    }
}

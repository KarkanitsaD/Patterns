using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Медиатор
{
    public class Tester: AbstractTeamMember
    {
        public Tester(AbstractManager manager) : base(manager) { }
        public override void Notify(string message)
        {
            Console.WriteLine("Message to tester: " + message);
        }
    }
}

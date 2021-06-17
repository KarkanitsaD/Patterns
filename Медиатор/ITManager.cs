using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Медиатор
{
    public class ITManager : AbstractManager
    {
        public Programmer Programmer { get; set; }
        public Tester Tester { get; set; }
        public Customer Customer { get; set; }
        public override void Send(string message, AbstractTeamMember teamMember)
        {
            if(teamMember == Customer)
            {
                Programmer.Notify(message);
            }
            else if(teamMember == Programmer)
            {
                Tester.Notify(message);
            }
            else if(teamMember == Tester)
            {
                Customer.Notify(message);
            }
        }
    }
}

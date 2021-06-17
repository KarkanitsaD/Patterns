using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Медиатор
{
    public abstract class AbstractManager
    {
        public abstract void Send(string message, AbstractTeamMember teamMember);
    }
}

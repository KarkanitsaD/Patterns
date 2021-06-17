using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Медиатор
{
    public abstract class AbstractTeamMember
    {
        protected AbstractManager manager;

        public AbstractTeamMember(AbstractManager manager)
        {
            this.manager = manager;
        }

        public virtual void Send(string message)
        {
            manager.Send(message, this);
        }
        public abstract void Notify(string message);
    }
}

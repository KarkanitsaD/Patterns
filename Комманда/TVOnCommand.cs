using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Команда
{
    public class TVOnCommand : ICommand
    {
        TV tv;


        public TVOnCommand(TV tv)
        {
            this.tv = tv;
        }
        public void Execute()
        {
            tv.On();
        }

        public void Undo()
        {
            tv.Off();
        }
    }
}

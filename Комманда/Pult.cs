using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Команда
{
    public class Pult
    {
        ICommand command;

        public Pult()
        {

        }


        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public void PressOnButton()
        {
            command.Execute();
        }

        public void PressOffButton()
        {
            command.Undo();
        }

    }
}

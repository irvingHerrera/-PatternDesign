using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.vehicle
{
    class ControladorLucesInvoker : IInvoker
    {
        private ICommand command;

        public void Invoke()
        {
            command.Execute();
        }

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }
    }
}

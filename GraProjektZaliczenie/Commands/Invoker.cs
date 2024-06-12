using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraProjektZaliczenie
{
    public class Invoker
    {
        private List<ICommand> commands = new List<ICommand>();
        public void SetCommand(ICommand command)
        {
            this.commands.Add(command);
        }

        public void DoTask()
        {
            foreach (ICommand c in commands)
            {
                c.Execute();
            }
        }
    }
}

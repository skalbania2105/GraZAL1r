using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraProjektZaliczenie
{
    public class CollectWood : ICommand
    {
        private Stewardess stewardess;

        public CollectWood(Stewardess stewardess)
        {
            this.stewardess = stewardess;
        }

        public void Execute()
        {
             Console.WriteLine(stewardess.CollectWood());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraProjektZaliczenie
{
    public class GatherFood : ICommand
    {
        private Scout Scout;

        public GatherFood(Scout scout)
        {
            Scout = scout;
        }

        public void Execute()
        {
            Console.WriteLine(Scout.CollectFood());
        }
    }
}

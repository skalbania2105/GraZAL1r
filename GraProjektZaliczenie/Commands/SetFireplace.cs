using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraProjektZaliczenie
{
    public class SetFireplace : ICommand
    {
        private Scout Scout;

        public SetFireplace(Scout scout) 
        {
            this.Scout = scout;        
        }

        public void Execute()
        {
            Console.WriteLine(Scout.SetFireplace());
        }
    }
}

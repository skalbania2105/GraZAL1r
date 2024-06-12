using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraProjektZaliczenie
{
    public class Deer : Animal
    {
        public Deer(int strength, int health) : base("jeleń",strength, health ) { }

        public override string MakeNoise()
        {
            return "Ueee";
        }
    }
}

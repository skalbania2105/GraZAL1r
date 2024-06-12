using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraProjektZaliczenie
{
    public class Tiger : Animal
    {
        public Tiger(int strength, int health) : base("tygrys", strength, health) { }

        public override string MakeNoise()
        {
            return "Roarrr";
        }
    }
}

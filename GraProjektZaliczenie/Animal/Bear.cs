using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraProjektZaliczenie
{
    public class Bear : Animal
    {
        public Bear(int strength, int health) : base("niedźwiedź", strength, health) { }

        public override string MakeNoise()
        {
            return "Grrrrr";
        }
    }
}

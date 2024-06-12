using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraProjektZaliczenie
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Health { get; set; }

        public Animal(string name, int strength, int health)
        {
            Name = name;
            Strength = strength;
            Health = health;
        }

        public virtual string MakeNoise()
        {
            return "";
        }
    }
}

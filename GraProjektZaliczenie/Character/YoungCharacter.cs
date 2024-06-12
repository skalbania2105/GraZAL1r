using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraProjektZaliczenie
{
    public abstract class YoungCharacter : Character
    {
        public int Strength { get; set; }

        public YoungCharacter(string name, List<string> skills, int height, int weight, int age, int hunger, int strength,string description)
            : base(name, skills, height, weight, age,hunger, description)
        {
            Strength = strength;
        }

        public override string Eat(int f)
        {
            // Zjedz i zregeneruj energię
            if (Hunger > 75)
            {
                if (Warehouse.food > 0)
                {
                    Health += 5;
                    Hunger -= f;

                    Warehouse.food -= f;

                    return $"{Name} zjadł i zregenerował trochę zdrowia.\n";
                }
                else
                {
                    return "Nie ma wystarczająco dużo jedzenia w magazynie!\n";
                }
            }
            else
            {
                return $"{Name} nie jest teraz głodny.\n";
            }
        }

        public override string Rest()
        {
            if (Warehouse.food >= 5)
            {
                Warehouse.food -= 5;
                if (Energy + 15 > MaxEnergy)
                {
                    Energy = MaxEnergy;
                    return $"{Name} jest pełen energii i nie potrzebuje już odpoczywać!\n";
                }
                Energy += 15;

                if (Stress - 5 < 10)
                {
                    Stress = 10;
                }

                Stress -= 5;

                return $"{Name} odpoczął i odzyskał trochę energii!\n";
            }
            return "Nie ma wystarczająco dużo jedzenia w magazynie!\n";
        }

        public override string DisplayPersonMenu()
        {
            return base.DisplayPersonMenu() + $"Siła: {Strength}"; 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraProjektZaliczenie
{
    public class OldCharacter : Character
    {
        public int WorkTime { get; set; }

        public OldCharacter(string name, List<string> skills, int height, int weight, int age, int hunger, int workTime, string description)
            : base(name, skills, height, weight, age,hunger,description)
        {
            WorkTime = workTime;
        }

        public override string Eat(int f)
        {
            // Zjedz i zregeneruj zdrowie
            if (Hunger > 75)
            {
                if (Warehouse.food > 0)
                {
                    Health += 5;
                    Hunger -= f;

                    Warehouse.food -= f;

                    return $"{AsciiArt.food}\n\n{Name} zjadł i zregenerował trochę zdrowia.\n";
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
            if (Warehouse.food >= 10)
            {
                Warehouse.food -= 10;
                if (Energy + 10 > MaxEnergy)
                {
                    Energy = MaxEnergy;
                    return $"{Name} jest pełen energii i nie potrzebuje już odpoczywać!\n";
                }
                Energy += 10;

                if (Stress - 5 < 10)
                {
                    Stress = 10;
                }

                Stress -= 5;

                return $"{AsciiArt.energy}\n\n{Name} odpoczął i odzyskał trochę energii!\n";
            }
            return "Nie ma wystarczająco dużo jedzenia w magazynie!\n";
        }

        public override string DisplayPersonMenu()
        {
            return base.DisplayPersonMenu() + $"Czas Pracy: {WorkTime}";
        }
    }
}

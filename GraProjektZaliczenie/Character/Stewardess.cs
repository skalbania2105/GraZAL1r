using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraProjektZaliczenie
{
    public class Stewardess : YoungCharacter
    {
        public int Wood { get; set; }


        public Stewardess(string name, List<string> skills, int height, int weight, int age,int hunger, int strength)
            : base(name, skills, height, weight, age, hunger, strength, "Stewardessa: zbiera drewno, które może pociąć drwal") { }

        public string CollectWood()
        {
            // Zwiększ ilość drewna i zużyj energie
            int e = rnd.Next(10, 21);
            if (EnoughEnergy(e))
            {
                int wood = rnd.Next(1,11);
                Warehouse.wood += wood;
                Energy -= e;
                Hunger += 20;
                lvl.AddExp(20);
                if (lvl.CanLvlUp())
                {
                    Console.WriteLine(lvl.LevelUp(this));
                }
                return $"{AsciiArt.wood}\n\n{Name} zebrała {wood} kawałków drewna!\n";
            }
            else
            {
                return $"{AsciiArt.energy}\n\n{Name} nie ma wystarczająco dużo energii by zbierać drewno.\n";
            }
        }

      /*  public override string DisplayTasksToGive()
        {
            return base.DisplayTasksToGive() + "4.Zbierz drewno\n";
        }

        public override void ChooseTask()
        {
            base.ChooseTask();
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D4:
                    TasksManager.WoodCommand();
                    break;
                default:
                    break;
            }
        } */
    }
}

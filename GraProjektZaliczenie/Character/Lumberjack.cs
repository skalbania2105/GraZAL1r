using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraProjektZaliczenie
{
    public class Lumberjack : OldCharacter
    {
        public Lumberjack(string name, List<string> skills, int height, int weight, int age, int hunger, int workTime) :
            base(name, skills, height, weight, age,hunger, workTime, "Drwal: tnie drewno na mniejsze kawałki, które można użyć do rozpalenia ogniska")
        { }

        public string CutWood()
        {
            if (Warehouse.wood > 1)
            {
                int woodToChop = Warehouse.wood / 2;

                if (EnoughEnergy(5 * woodToChop) == false)
                {
                    return $"{AsciiArt.energy}\n\n{Name} ma za mało energii aby siekać drewno!\n";
                }
                else
                {
                    Energy -= (5 * woodToChop);
                    Hunger += (5 * woodToChop);
                    Stress += 10;
                    lvl.AddExp(20);
                    if (lvl.CanLvlUp())
                    {
                        Console.WriteLine(lvl.LevelUp(this));
                    }
                    if (Hunger >= 100)
                    {
                        Hunger = 100;
                    }
                    Warehouse.wood -= woodToChop;
                    Warehouse.choppedWood += woodToChop * 3;
                    return $"{AsciiArt.axe}\n\n{Name} posiekał {woodToChop} kawałków drewna!\n";
                }
            }
            else
            {
                return $"{AsciiArt.wood}\n\nNie ma wystarczająco dużo drewna w magazynie!\n";
            }
        }

       /* public override string DisplayTasksToGive()
        {
            return base.DisplayTasksToGive() + "4.Tnij drewno\n";
        }

        public override void ChooseTask()
        {
            base.ChooseTask();
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D4:
                    Console.WriteLine(CutWood());
                    break;
                default:
                    break;
            }
        }
       */
    }
}

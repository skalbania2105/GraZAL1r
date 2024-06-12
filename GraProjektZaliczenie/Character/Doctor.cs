using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraProjektZaliczenie
{
    public class Doctor : OldCharacter
    {
        
        public Doctor(string name, List<string> skills, int height, int weight, int age,int hunger, int workTime) :
        base(name, skills, height, weight, age,hunger, workTime, "Doktor: leczy inne postaci")
        {
        }

        public string GiveMedicine(Character character)
        {
            if (Warehouse.medicine > 0)
            {
                if (character.Health < 5)
                {
                    character.Health = 50;
                    Warehouse.medicine -= 1;
                    lvl.AddExp(50);
                    if (lvl.CanLvlUp())
                    {
                        Console.WriteLine(lvl.LevelUp(this));
                    }
                    if (character is Scout)
                    {
                        Scout.failedFight = false;
                    }
                    return $"{AsciiArt.medcine}\n\nDoktor wyleczył {character.Name}!";
                }
                return $"{AsciiArt.heart}\n\n{character.Name} nie potrzebuje leczenia!";
            } 
            else
            {
                character.Health = 0;
                character.IsDead = true;
                Manager.Die(character);
                return $"{AsciiArt.medcine}\n\nDoktor nie miał wystarczająco lekarstw aby przeprowadzić leczenie. {character.Name} zmarł.";
            }
        }

        /*public override string DisplayTasksToGive()
        {
            return base.DisplayTasksToGive() + "4.Daj lekarstwo\n";
        }

        public override void ChooseTask()
        {
            base.ChooseTask();
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D4:
                    GiveMedicine(Manager.Player);
                    break;
                default:
                    break;
            }
        } */
    }
}

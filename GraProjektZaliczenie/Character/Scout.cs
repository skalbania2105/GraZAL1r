using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraProjektZaliczenie
{
    public class Scout : YoungCharacter
    {
        public static bool failedFight = false;
        public Scout(string name, List<string> skills, int height, int weight, int age,int hunger, int strength) :
            base(name, skills, height, weight, age, strength, hunger, "Skaut: zbiera jedzenie dla wszystkich postaci, potrafi rozpalić ognisko") { }

        public string CollectFood()
        {
            int e = rnd.Next(10, 16);
            if (EnoughEnergy(e))
            {
                int food = rnd.Next(1, 9);

                Warehouse.food += food;
                Energy -= e;
                Stress += 5;
                Hunger += 10;
                lvl.AddExp(10);
                if (lvl.CanLvlUp())
                {
                    Console.WriteLine(lvl.LevelUp(this));
                }

                return $"{AsciiArt.food}\n\n{Name} zebrał {food} kawałków jedzenia!\n";
            }
            else
            {
                return $"{AsciiArt.energy}\n\n{Name} nie ma wystarczająco dużo energii by zbierać jedzenie!\n";
            }
        }
        public string FightAnimal(Animal animal)
        {
            if (EnoughEnergy(20))
            {
                if (Strength * rnd.Next(1, 4) > animal.Strength)
                {
                    Warehouse.food += rnd.Next(1, 9);
                    Stress += 10;
                    Energy -= 20;
                    Hunger += 20;
                    lvl.AddExp(10);
                    if (lvl.CanLvlUp())
                    {
                        Console.WriteLine(lvl.LevelUp(this));
                    }
                    failedFight = false;
                    return $"{AsciiArt.animal}\n\n{Name} pokonał zwierzę {animal.Name}!\n";
                }
                else
                {
                    foreach (Character c in TasksManager.charactersToChoose)
                    {
                        c.Stress += 20;

                        if (c.Stress == c.MaxStress)
                        {
                            Manager.Die(c);
                        }
                    }

                    Health = 1;
                    failedFight = true;
                    return $"{AsciiArt.animal}\n\n{Name} nie zdołał pokonać zwierzęcia {animal.Name}. Bohater potrzebuje teraz leczenia!\n";
                }
            }
            else
            {
                foreach (Character c in TasksManager.charactersToChoose)
                {
                    c.Stress += 20;

                    if (c.Stress == c.MaxStress)
                    {
                        Manager.Die(c);
                    }
                }

                Health = 1;
                failedFight = true;
                return $"{AsciiArt.energy}\n\n{Name} nie miał wystarczająco energii by walczyć ze zwierzęciem! Bohater potrzebuje leczenia!\n";
            }
        }

        public string SetFireplace()
        {
            if (EnoughEnergy(5))
            {
                if (Warehouse.choppedWood >= 20)
                {
                    Warehouse.choppedWood -= 20;
                    lvl.AddExp(10);
                    Stress += 5;
                    Energy -= 5;
                    Hunger += 5;
                    if (lvl.CanLvlUp())
                    {
                        Console.WriteLine(lvl.LevelUp(this));
                    }
                    return $"{AsciiArt.fireplace}\n\n{Name} rozpalił ognisko!\n";
                }
                else
                {
                    return $"{AsciiArt.wood}\n\nNie ma wystarczająco dużo kawałków drewna w magazynie!\n";
                }
            } 
            else
            {
                foreach (Character c in TasksManager.charactersToChoose)
                {
                    c.Stress += 10;

                    if (c.Stress == c.MaxStress)
                    {
                        Manager.Die(c);
                    }
                }
                return $"{AsciiArt.energy}\n\n{Name} nie miał wystarczająco dużo energii by rozpalić ognisko!\n";
            }
        }

      /*  public override string DisplayTasksToGive()
        {
            return base.DisplayTasksToGive() + "4.Zbierz jedzenie\n5.Walcz ze zwierzęciem\n6.Rozpal Ognisko\n";
        }

        public override void ChooseTask()
        {
            base.ChooseTask();
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D4:
                    Console.WriteLine(CollectFood());
                    break;
                case ConsoleKey.D5:
                    Console.WriteLine(FightAnimal(AnimalManager.animals[rnd.Next(AnimalManager.animals.Count)]));
                    break;
                case ConsoleKey.D6:
                    Console.WriteLine(SetFireplace());
                    break;
                default:
                    break;
            }
        } */
    }
}




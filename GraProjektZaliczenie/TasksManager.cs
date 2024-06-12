using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraProjektZaliczenie
{
    public static class TasksManager
    {
        public static Random rnd = new Random();
        //stworzenie nowej listy postaci z listy wszystkich postaci oprócz gracza
        public static List<Character> charactersToChoose = ChooseCharacter.characters.Where(x => x.Name != Manager.Player.Name).ToList();
        
        //metoda zwracajaca spis postaci oraz zadan ktore mozna wykonac z odpowiadajacymi im klawiszami
        public static string DisplayPeople()
        {
            string output = "Wybierz postać aby zobaczyć statystyki:\n";
            for (int i = 0; i < charactersToChoose.Count; i++)
            {
                output += $"{i+1}. {charactersToChoose[i].Name}\n";
            }
            return output + $"{charactersToChoose.Count + 1}. Ty\n\n\n\n\n[W] Wyślij bohaterów na zbiórkę i cięcie drewna oraz rozpal ognisko!\n[J] Wyślij skauta na zbiórkę jedzenia\n\n\n[M] Zobacz stan magazynu\n";
        }
        
        //metoda odpowiadająca za wyświetlenie menu osoby wybranej przez użytkownika oraz wykonanie zadania
        public static void ChoosePerson()
        {
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Console.WriteLine(charactersToChoose[0].DisplayPersonMenu());
                    Console.WriteLine(charactersToChoose[0].DisplayTasksToGive());
                    charactersToChoose[0].ChooseTask();
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Console.WriteLine(charactersToChoose[1].DisplayPersonMenu());
                    Console.WriteLine(charactersToChoose[1].DisplayTasksToGive());
                    charactersToChoose[1].ChooseTask();
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    Console.WriteLine(charactersToChoose[2].DisplayPersonMenu());
                    Console.WriteLine(charactersToChoose[2].DisplayTasksToGive());
                    charactersToChoose[2].ChooseTask();
                    break;
                case ConsoleKey.D4:
                    Console.Clear();
                    Console.WriteLine(Manager.Player.DisplayPersonMenu());
                    Console.WriteLine(Manager.Player.DisplayTasksToGive());
                    Manager.Player.ChooseTask();
                    break;
                case ConsoleKey.W:
                    Console.Clear();
                    WoodCommand();
                    break;
                case ConsoleKey.J:
                    Console.Clear();
                    FoodCommand();
                    break;
                default:
                    break;
            }
        }

        //ustawienie polecenia odpowiadającego za zbiórkę i cięcie drewna oraz rozpalenie ogniska
        public static void WoodCommand()
        {
            Invoker inv = new Invoker();

            if (ChooseCharacter.characters[2].IsDead == false)
            {
                inv.SetCommand(new CollectWood((Stewardess)ChooseCharacter.characters[2]));
            } 
            if (ChooseCharacter.characters[3].IsDead == false)
            {
                inv.SetCommand(new CutWood((Lumberjack)ChooseCharacter.characters[3]));
            }
            if (Warehouse.choppedWood >= 20 && ChooseCharacter.characters[1].IsDead == false)
            {
                inv.SetCommand(new SetFireplace((Scout)ChooseCharacter.characters[1]));
            }

            inv.DoTask();
        }

        //ustawienie polecenia odpowiadającego za zbieranie jedzenia 
        public static void FoodCommand()
        {
            Invoker inv = new Invoker();

            if (ChooseCharacter.characters[1].IsDead == false)
            {
                inv.SetCommand(new GatherFood((Scout)ChooseCharacter.characters[1]));
            }
            
            //55% szans na to że zaatakuje nas zwierzę
            bool animalAttack = rnd.Next(101) <= 45 ? false : true;

            if (animalAttack)
            {
                if (ChooseCharacter.characters[1].IsDead == false)
                {
                    //dodanie polecenia walki
                    inv.SetCommand(new FightAnimal((Scout)ChooseCharacter.characters[1]));
                        //ustawienie polecenia leczenia 
                        if (ChooseCharacter.characters[0].IsDead == false)
                        {
                            inv.SetCommand(new Heal((Doctor)ChooseCharacter.d, ChooseCharacter.s));
                        }
                }
            }

            inv.DoTask();
        }
    }
}

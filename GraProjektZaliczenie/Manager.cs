using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Figgle;
using GraProjektZaliczenie.Quiz;
using GraProjektZaliczenie.Quiz.Managers;
using Pastel;

namespace GraProjektZaliczenie
{
    public static class Manager
    {
        public static Character Player { get; set; }
        public static bool finished = false;
        
        //metoda wyświetlająca menu gry
        public static string DisplayMenu()
        {
            string title = AsciiArt.title1.Pastel("#FF0000") + AsciiArt.title2.Pastel("#00FF00");
            return title + "\n\n1.Rozpocznij grę\n2.Wyjdź\n";
        }

        //metoda pozwalająca na wybranie opcji w menu
        public static void ChooseFromMenu()
        {
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Story.DisplayCrash();
                    Story.DisplayStory(Story.GetStory(Story.beginning));
                    Console.ReadKey();
                    StartQuiz();
                    break;
                case ConsoleKey.D2:
                    Environment.Exit(1);
                    break;
                default:
                    break;
            }
        }

        //rozpoczęcie gry
        public static void Run()
        {
            Console.WriteLine(DisplayMenu());
            ChooseFromMenu();
        }

        //metoda pozwalająca na trwanie gry dopóki jej nie wygramy
        public static void StartGame()
        {
            while (finished == false)
            {
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine(TasksManager.DisplayPeople());
                TasksManager.ChoosePerson();

                if (Console.ReadKey(true).Key == ConsoleKey.M)
                {
                    Console.Clear();
                    Console.WriteLine(Warehouse.DisplayWarehouseState());
                }

                if (Warehouse.choppedWood >= 500)
                {
                    finished = true;
                    Console.WriteLine();
                    Console.WriteLine(EndGame(3));
                    Console.ReadKey();
                    Environment.Exit(1);
                }
            }
        }

        //rozpoczęcie quizu
        public static void StartQuiz()
        {
            StageManager.ReadStages();
            Menu.HandleInput("1");
        }

        //metoda pozwalająca na wybranie bohatera przez gracza
        public static void ChoosePlayer()
        {
            Console.Write(ChooseCharacter.DisplayCharacters());
            ChooseCharacter.ChooseCh();
            Story.DisplayStory(Story.GetStory(Story.tasks));
            StartGame();
        }

        //metoda odpowidająca za zakończenie gry z odpowiednim rezultatem
        public static string EndGame(int ending)
        {
            switch (ending)
            {
                case 1:
                    return $"{AsciiArt.death}\n\nŻadna grupa nie przetrwa bez przywódcy. Ponieważ umarłeś Wasza przygoda się kończy...\n\n> Enter";
                case 2:
                    return $"{AsciiArt.allDead}\n\nWszyscy bohaterowie zginęli...\n\n> Enter";
                case 3:
                    return $"{AsciiArt.raft}\n\n\nUdało się Wam utworzyć tratwę i uciec z wyspy!\n Gratulacje, wygrałeś grę!\n\n> Enter";
                default:
                    break;
            }
            return "The End";
        }

        //metoda odpowiadająca za śmierć bohatera
        public static void Die(Character ch)
        {
            if (ch.Name == Player.Name)
            {
                //jesli umrze gracz koniec gry
                Console.WriteLine($"{ch.Name} umarł.\n\n> Enter");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine(EndGame(1));
                Console.ReadKey();
                Environment.Exit(1);
            }
            else
            {
                if (TasksManager.charactersToChoose.Count <= 0)
                {
                    //jeśli nie ma żadnego bohatera koniec gry
                    Console.WriteLine(EndGame(2));
                    Console.ReadKey();
                    Environment.Exit(1);
                }
                else
                {
                    int chIndex = TasksManager.charactersToChoose.FindIndex(c => c.Name == ch.Name);
                    TasksManager.charactersToChoose.RemoveAt(chIndex);
                    foreach (Character c in TasksManager.charactersToChoose)
                    {
                        //śmierć któregokolwiek bohatera powoduje wzrost stresu u pozostałych
                        c.Stress += 30;

                        //jesli stres osiągnie poziom maksymalny bohater umiera (atak serca)
                        if (c.Stress == c.MaxStress)
                        {
                            Console.WriteLine($"{AsciiArt.death}\n\n\n{c.Name} umarł.\n");
                            Die(c);
                        }
                    }
                }
            }
        }
    }
}

using GraProjektZaliczenie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraProjektZaliczenie
{
    //klasa pozwalająca na wybór bohatera
    public static class ChooseCharacter
    {
        public static Doctor d = new Doctor("Jan", new List<string>() { "leczenie ran" }, 180, 80, 50, 20, 8);
        public static Scout s = new Scout("Marek", new List<string>() { "skradanie się", "zastawianie pułapek", "rozpalanie ogniska" }, 170, 60, 30, 80, 50);
        public static Stewardess st = new Stewardess("Anna", new List<string>() { "walka wręcz", "strzelanie" }, 168, 90, 25, 80, 60);
        public static Lumberjack l = new Lumberjack("Piotr", new List<string>() { "cięcie drewna", "walka bronią białą" }, 190, 100, 35, 80, 10);
        public static List<Character> characters = new List<Character>() {d,s,st,l};

        public static string DisplayCharacters()
        {
            string output = "\n\nWybierz postać:\n";
            for (int i = 0; i < characters.Count; i++ )
            {
                output += $"{i + 1}. {characters[i].Name} - {characters[i].Description}.\n";
            }
            
            return output;
        }

        public static void ChooseCh()
        {
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    Manager.Player = characters[0];
                    break;
                case ConsoleKey.D2:
                    Manager.Player = characters[1];
                    break;
                case ConsoleKey.D3:
                    Manager.Player = characters[2];
                    break;
                case ConsoleKey.D4:
                    Manager.Player = characters[3];
                    break;
                default:
                    break;
            }
        }
    }
}

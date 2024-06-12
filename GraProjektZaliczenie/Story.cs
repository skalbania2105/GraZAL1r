using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pastel;

namespace GraProjektZaliczenie
{
    //klasa statyczna Story odpowiada za wypisywanie tekstu
    static class Story
    {
        //statyczne stringi zawierajace odpowiednie czesci historii

        public static string beginning = @"Nic nie wskazywało na to, że lot na Maltę zostanie przerwany przez awarię samolotu. Jednak stało się to a pasażerowie znaleźli się na niezamieszkanej wyspie około 2h drogi od celu podróży. Twoim zadaniem będzie przetrwać na wyspie oraz zgromadzić 500 kawałków drewna aby zbudować tratwę na której będziecie mogli przedostać się do zamieszkanej lokacji.";

        public static string tasks = @"
Zdecydowałeś przejąć dowództwo nad ocalałymi. Rozdzielaj zadania między pozostałymi postaciami i przeżyj!
> Enter!";

        //metoda pozwalajaca na wywietlenie wypadku samolotu
        public static void DisplayCrash()
        {
            //podzielenie okna konsoli na 3
            int widthTo3 = Console.WindowWidth / 3;
            //ustawienie kursora
            Console.SetCursorPosition(0, 0);
            //wyrysowanie pierwszej klatki z samolotem
            for (int i = 0; i < AsciiArt.plane.Length; i++)
            {
                Console.SetCursorPosition(0, 0 + i);
                Console.WriteLine(AsciiArt.plane[i].Pastel("#808080"));
            }
            //zatrzymanie wykonywania metody na 1 sekunde
            Thread.Sleep(1000);
            //wyczyszczenie konsoli
            Console.Clear();
            //wyrysowanie drugiej klatki z samolotem na odpowiednim miejscu w konsoli
            Console.SetCursorPosition(0 + widthTo3, 0);
            for (int i = 0; i < AsciiArt.plane.Length; i++)
            {
                Console.SetCursorPosition(0 + widthTo3, 0 + i);
                Console.WriteLine(AsciiArt.plane[i].Pastel("#808080"));
            }
            Thread.Sleep(1000);
            Console.Clear();
            //wyrysowanie trzeciej klatki na odpowiednim miejcu w konssoli
            Console.SetCursorPosition(0 + widthTo3 + widthTo3/2, 0);
            for (int i = 0; i < AsciiArt.planeCrash.Length; i++)
            {
                Console.SetCursorPosition(0 + widthTo3 + widthTo3 / 2, 0 + i);
                Console.WriteLine(AsciiArt.planeCrash[i].Pastel("#808080"));
            }
            Thread.Sleep(1000);
            Console.Clear();
            //powrot ppozycji kursora na lewy gorny rog konsoli
            Console.SetCursorPosition(0, 0);
        }

        //metoda pozwalajaca na uzyskanie listy slow z podanego tekstu
        public static List<string> GetStory(string text)
        {
            List<string> words = text.Split(' ').ToList();
            return words;
        }

        //metoda wypisujaca historie slowo po slowie i litera po literze by stworzyc efekt pisania
        public static void DisplayStory(List<string> text)
        {
            int letters = 0;
            for (int current = 0; current < text.Count(); current++)
            {
                for (int i = 0; i < text[current].Length; i++)
                {
                    if (letters + text[current].Length > Console.WindowWidth)
                    {
                        Console.Write(Environment.NewLine);
                        letters = 0;
                    }
                    Console.Write(text[current][i]);
                    Thread.Sleep(20);
                }
                Console.Write(" ");
                letters = letters + text[current].Length + 1;
            }
        }
    }
}

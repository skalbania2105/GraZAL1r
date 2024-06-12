using System;

namespace GraProjektZaliczenie 
{
    class Program
    {
        static void Main(string[] args)
        {
            //ustawienie tytułu okna konsoli
            Console.Title = "Katastrofa Lotnicza";
            //ustawienie widoczności kursora w konsoli na niewidoczny
            Console.CursorVisible = false;

            //tworzenie okna konsoli o okreslonym rozmiarze, jesli jest niemozliwe wypisanie bledu
            try
            {
                Console.WindowWidth = 120;
                Console.WindowHeight = 30;
            }
            catch
            {
                Console.WriteLine("Cannot create console Window of that size!");
            }

            //uruchomienie gry z klasy Manager
            Manager.Run();
            
            //umożliwenie niezamykania się samoistnie konsoli
            Console.ReadKey(true);
        }
    }
}
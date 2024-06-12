using System.Reflection.Metadata;
using GraProjektZaliczenie.Quiz.Managers;

namespace GraProjektZaliczenie.Quiz
{

    public static class Menu
    {
        // zadeklaruj słownik z kluczem o typie short i wartościa Action
        // w skrócie deklaruje tu działa nie menu tj. jaki przycisk wykonuje jaką akcje
        public static Dictionary<short, Action> MenuActions = new()
    {
        { 1, Game.Start },
        { 2, SaveManager.DisplaySavesToLoad },
        { 0, Game.Quit },
    };

        // wyświetl menu
        public static void Display()
        {
            Console.Clear();

            Console.WriteLine($"{Globals.GameName}");
            Console.WriteLine($"{Environment.NewLine}");

            Console.WriteLine("1] Nowa gra");
            Console.WriteLine("2] Wczytaj grę");
            Console.WriteLine("0] Wyjdź\n");

            Console.Write("Wybór: ");
            var input = Console.ReadLine();
            HandleInput(input);
        }

        public static void HandleInput(string? input)
        {
            // ogarnij to co wpisal user
            try
            {
                var shortInput = Convert.ToInt16(input);
                MenuActions.TryGetValue(shortInput, out var action);
                action?.Invoke();
            }

            catch (Exception e)
            {
                ErrorHandler.HandleError(e.Message);
            }
        }
    }
}
using GraProjektZaliczenie.Quiz.Managers;

namespace GraProjektZaliczenie.Quiz
{

    public static class Game
    {
        public static void Start()
        {
            // sprawdz czy lista etapow nie jest pusta
            if (!StageManager.Stages.Any())
                ErrorHandler.HandleError("Lista etapów nie może być pusta!");

            Console.Clear();

            // inicjalizuj pierwszy etap
            StageManager.Stages.First().Initialize();
        }

        public static void Quit()
        {
            Console.Clear();

            Console.WriteLine("Jesteś pewien, że chcesz wyjść (t/n)?");
            var choice = Console.ReadLine();

            try
            {
                var lowerChoice = choice?.ToLower();

                // sprawdz input usera
                switch (lowerChoice)
                {
                    case "t":
                        Environment.Exit(1);
                        break;

                    case "n":
                        Menu.Display();
                        break;
                };
            }

            catch
            {
                ErrorHandler.HandleMenuInvalidChoice();
            }

        }

        public static void End()
        {
            Console.Clear();
            Console.WriteLine("Brawo wygarłeś! Udało Ci się przeżyć :) \n Koniec gry nacisnij dowonly klawisz aby kontynuować...");
            Console.ReadKey();
            Environment.Exit(1);
        }

        public static void GameOver()
        {
            Console.Clear();
            Console.WriteLine("Przegrałeś, Koniec gry! \nKliknij dowolny przycisk aby spróbować ponownie...");
            Console.ReadKey();
            Start();
        }
    }
}
using GraProjektZaliczenie.Quiz.Managers;

namespace GraProjektZaliczenie.Quiz
{

    public static class ErrorHandler
    {

        public static void HandleError(string message)
        {
            Console.Clear();

            Console.WriteLine($"BŁĄD: {message}");
            Console.WriteLine($"Wciśnij dowonly przycisk aby zacząć od nowa...");

            Console.ReadKey();
            Game.Start();
        }

        public static void HandleStageError(string message, short stageIndex)
        {
            Console.Clear();

            Console.WriteLine($"BŁĄD: {message}");
            Console.WriteLine($"Wystąpił błąd etapu gry, wciśnij dowolny przycisk aby spróbować ponownie jeśli to nic nie da sprawdź logi!");

            Console.ReadKey();
            StageManager.LoadStage(stageIndex);
        }

        public static void HandleMenuInvalidChoice()
        {
            Console.Clear();

            Console.WriteLine($"BŁĄD: Podałeś nieprawidłową wartość!");
            Console.WriteLine($"Wciśnij dowonly przycisk aby wrócić do menu");

            Console.ReadKey();
            Menu.Display();
        }


        public static void HandleStageInvalidChoice(short stageIndex)
        {
            Console.Clear();

            Console.WriteLine($"BŁĄD: Podałeś nieprawidłową wartość!");
            Console.WriteLine($"Wciśnij dowonly przycisk aby zacząć ten etap od nowa...");

            Console.ReadKey();
            StageManager.LoadStage(stageIndex);
        }
    }
}
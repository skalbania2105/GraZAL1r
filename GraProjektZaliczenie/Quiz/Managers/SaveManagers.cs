using GraProjektZaliczenie.Quiz.Models;

namespace GraProjektZaliczenie.Quiz.Managers
{

    public static class SaveManager
    {
        public static void SaveCurrentProgress()
        {
            // zawratość pliku tworzonego poniżej
            var content = $"{StageManager.GetCurrentStageIndex().ToString()}" +
                               $"{Environment.NewLine}" +
                               $"{DateTime.Now}";

            // tworzenie pliku wraz z zawratością powyżej
            File.WriteAllText(
                $"{DateTime.Now.ToString("YYMMddHHmmss")}.save",
                content
            );
        }

        public static void DisplaySavesToLoad()
        {
            Console.Clear();
            Console.WriteLine("#\tDATA\t\t\tPOZIOM");

            // deklaracja pustej listy SavesModel
            var saves = new List<SavesModel>();

            // try czyli spróbuj coś zrobic jak się nie uda to zrób to co jest w catch
            try
            {
                // weż wszystkie lokalizacje plików kończące się na ".save" czy po prostu wszystkie savy
                var files = Directory.GetFiles(
                    Environment.CurrentDirectory,
                    "*.save"
                ).ToList();


                // pętla po tych plikach
                for (var i = 0; i < files.Count; i++)
                {
                    // zawartość pliku
                    var content = File.ReadAllText(files[i]);

                    // dodaj dane saveu wyczytane z pliku do listy
                    saves.Add(new SavesModel
                    {
                        DateTime = Convert.ToDateTime(content.Split(Environment.NewLine)[1]),
                        StageIndex = Convert.ToInt16(content.Split(Environment.NewLine)[0])
                    });

                    // wypisz save'y
                    Console.WriteLine($"{i}\t{saves.Last().DateTime}\t{saves.Last().StageIndex}");
                }

                Console.WriteLine(Environment.NewLine);
                Console.Write("Wybór: ");
            }

            catch (Exception e)
            {
                ErrorHandler.HandleError(e.Message);
            }

            // spróbuj odczytać wybór użytkownika jak jest nie poprawny to zrob to co w catch
            try
            {
                // przekonwertuj wpisany input user'a ktory domyslnie jest stringiem na short'a
                var choice = Convert.ToInt16(Console.ReadLine());

                // zaladuj etap o podanych indexie
                StageManager.LoadStage(saves[choice].StageIndex);
            }

            catch
            {
                ErrorHandler.HandleMenuInvalidChoice();
            }
        }
    }
}
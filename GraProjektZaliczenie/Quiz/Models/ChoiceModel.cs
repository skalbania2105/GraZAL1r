using GraProjektZaliczenie.Quiz.Managers;

namespace GraProjektZaliczenie.Quiz.Models
{
    public class ChoiceModel
    {
        public short StageIndex { get; set; }
        public string? Title { get; set; }
        public Dictionary<string, Action> Choices { get; set; } = new();

        public void TryDisplay()
        {
            Console.WriteLine(Title + "\n\nCo robisz?");

            for (var i = 0; i < Choices.Count; i++)
                Console.WriteLine($"{i + 1}] {Choices.ElementAt(i).Key}");

            Console.WriteLine($"0] Zapisz dotychczasowy postęp");

            Console.Write("\nWybór: ");

            try
            {
                var choiceInput = Convert.ToInt16(Console.ReadLine());

                if (choiceInput == 0)
                {
                    SaveManager.SaveCurrentProgress();
                    Console.Clear();
                    Console.WriteLine("Pomyślnie zapisano.");
                    TryDisplay();
                }

                var test = Choices.ElementAt(choiceInput - 1);

                Choices.ElementAt(choiceInput - 1).Value.Invoke();
            }

            catch
            {
                ErrorHandler.HandleStageInvalidChoice(StageIndex);
            }
        }
    }
}
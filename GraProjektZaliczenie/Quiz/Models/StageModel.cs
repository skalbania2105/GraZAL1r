using GraProjektZaliczenie.Quiz.Managers;

namespace GraProjektZaliczenie.Quiz.Models
{

    public class StageModel
    {
        public short Index { get; set; }

        public string Title { get; set; }
        public List<string> Choices { get; set; } = new();
        public short CorrectChoiceIndex { get; set; }

        public void Initialize()
        {
            Console.Clear();

            if (string.IsNullOrEmpty(Title) || Choices == null || !Choices.Any())
            {
                ErrorHandler.HandleStageError("Title, Choices and CorrectChoiceIndex cannot be null or empty!", Index);
                return;
            }

            var choiceModel = new ChoiceModel
            {
                Title = Title,
                StageIndex = Index
            };

            for (var i = 0; i < Choices.Count; i++)
            {
                choiceModel.Choices.Add(Choices[i], i == CorrectChoiceIndex ? StageManager.LoadNextStage : Game.GameOver);
            }

            choiceModel.TryDisplay();
        }
    }
}
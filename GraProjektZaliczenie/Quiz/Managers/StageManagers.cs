using System.Text.Json;
using GraProjektZaliczenie.Quiz.Models;

namespace GraProjektZaliczenie.Quiz.Managers
{

    public static class StageManager
    {
        // propercje
        private static short _currentStage;
        public static List<StageModel> Stages = new();

        public static void ReadStages()
        {

            try
            {
                // przeczytaj zawartość pliku JSON który ma w sobie etapy
                var fileContent = File.ReadAllText(Globals.StagesFilePath);

                // przekonwertuj JSON na liste klas StageModel
                var stages = JsonSerializer.Deserialize<List<StageModel>>(fileContent);

                // dodaj etapy do gry
                Stages.AddRange(stages);

                // ustaw index etapow
                for (short i = 0; i < Stages.Count; i++)
                    Stages[i].Index = i;
            }
            catch (Exception e)
            {
                ErrorHandler.HandleError(e.Message);
            }
        }

        public static short GetCurrentStageIndex() => _currentStage;

        public static void LoadNextStage()
        {
            _currentStage++;

            // jak nie ma juz etapow to koniec quizu
            if (_currentStage + 1 > Stages.Count)
            {
                Manager.ChoosePlayer();
            }
            // zaladuj następny etap
            Stages[_currentStage].Initialize();
        }

        public static void LoadStage(short stageIndex)
        {
            var stage = Stages[stageIndex];
            // zaladuj etap
            stage.Initialize();
        }
    }
}
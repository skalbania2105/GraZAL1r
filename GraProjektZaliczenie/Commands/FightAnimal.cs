using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraProjektZaliczenie
{
    public class FightAnimal : ICommand
    {
        public Random rnd = new Random();
        private Scout Scout;
        public FightAnimal(Scout scout)
        {
            Scout = scout;
        }

        public void Execute()
        {
            Console.WriteLine(Scout.FightAnimal(AnimalManager.animals[rnd.Next(AnimalManager.animals.Count)]));
        }
    }
}

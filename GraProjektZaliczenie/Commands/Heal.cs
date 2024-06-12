using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraProjektZaliczenie
{
    public class Heal : ICommand
    {
        private Doctor Doctor;
        private Character Character;

        public Heal(Doctor doctor, Character character)
        {
            Doctor = doctor;
            Character = character;
        }

        public void Execute()
        {
            Console.WriteLine(Doctor.GiveMedicine(Character));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraProjektZaliczenie
{
    public class CutWood : ICommand
    {
        private Lumberjack Lumberjack;

        public CutWood(Lumberjack lumberjack)
        {
            Lumberjack = lumberjack;
        }

        public void Execute()
        {
            Console.WriteLine(Lumberjack.CutWood());
        }
    }
}

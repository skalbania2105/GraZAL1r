using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraProjektZaliczenie
{
    //klasa zawierająca zwierzęta w grze i ich listę
    static class AnimalManager
    {
        public static Bear b1 = new Bear(40,20);
        public static Bear b2 = new Bear(50,30);
        public static Bear b3 = new Bear(60,40);

        public static Deer d1 = new Deer(20,40);
        public static Deer d2 = new Deer(30,60);
        public static Deer d3 = new Deer(60,80);

        public static Tiger t1 = new Tiger(40,15);
        public static Tiger t2 = new Tiger(80,25);
        public static Tiger t3 = new Tiger(100,35);

        public static List<Animal> animals = new List<Animal>() { b1, d1, t1, b2, d2, t2, b3, d3, t3 };
    }
}

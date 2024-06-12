using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraProjektZaliczenie
{
    //klasa odpowiadajaca za poziom postaci
    public class Level
    {
        public int Exp { get; set; }

        public int MaxExp { get; }

        public Level(int exp)
        {
            Exp = exp;
            MaxExp = 100;
        }

        //metoda dzieki ktorej bohater osiaga nowy poziom, zmiana statystyk
        public string LevelUp(Character ch)
        {
                ch.Stress -= 10;
                ch.MaxHealth += 10;
                ch.MaxEnergy += 10;
                ch.Health = ch.MaxHealth;
                ch.Energy = ch.MaxEnergy;
                ch.Lvl++;
                ch.lvl.Exp = 0;
                return $"Bohater {ch.Name} osiągnął nowy poziom!\n";            
        }

        //dodawanie punktow doswiadczenia
        public void AddExp(int e)
        {
            Exp += e;
        }

        //metoda sprawdzajaca czy mozna osiagnac nowy poziom
        public bool CanLvlUp()
        {
            if (Exp == MaxExp)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

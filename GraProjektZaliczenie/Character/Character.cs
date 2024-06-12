using Pastel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraProjektZaliczenie
{
    public abstract class Character
    {
        public Level lvl = new Level(0);
        public string Name { get; set; }
        public List<string> Skills { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int Age { get; set; }
        public int Energy { get; set; }
        public int MaxEnergy { get; set; }
        public int Hunger { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int Stress { get; set; }

        public int MaxStress { get; }

        public int Lvl { get; set; }

        public bool IsDead { get; set; }
        public string Description { get; set; }

        public Random rnd = new Random();
        public Character(string name, List<string> skills, int height, int weight, int age, int hunger, string description)
        {
            Name = name;
            Skills = skills;
            Height = height;
            Weight = weight;
            Age = age;
            Hunger = hunger;
            Description = description;
            IsDead = false;
            Stress = 10;
            MaxStress = 100;
            MaxEnergy = 50;
            MaxHealth = 50;
            Energy = MaxEnergy;
            Health = MaxHealth;
            Lvl = 1;
        }
        public virtual string Eat(int f)
        {
            return "";
        }

        public virtual string Rest()
        {
            return "";
        }

        public void PerformAction()
        {
            // Wykonaj akcję zgodnie z umiejętnościami postaci
        }


        //opis postaci
        public virtual string DisplayPersonMenu()
        {
            string output = $"Bohater {Name} ma {Age} lat, {Height}cm wzrostu, {Weight}kg wagi\n\nEnergia: {Energy}\nZdrowie: {Health}\nGłód: {Hunger}\nPoziom stresu: {Stress}/{MaxStress}\n";
            return output;
        }

        //zadania jakie moze wykonac postac
        public virtual string DisplayTasksToGive()
        {
            return "\nWybierz zadanie:\n\n1.Zjedz\n2.Odpocznij\n";
        }

        //wyswietlenie zadan
        public void MenuTasks()
        {
            Console.WriteLine(DisplayPersonMenu());
            Console.WriteLine(DisplayTasksToGive());
            ChooseTask();
        }

        //wwybor zadania przez wcisniecie odpowiedniego klawisza na klawiaturze
        public void ChooseTask()
        {
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Console.WriteLine(Eat(rnd.Next(1,11)));
                    MenuTasks();
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Console.WriteLine(Rest());
                    MenuTasks();
                    break;
                default:
                    break;
            }
        }

        //metoda sprawdzajaca czy na dane zadanie jest odpowiednio duzo energii
        public bool EnoughEnergy(int eToSub)
        {
            //jesli po wykonaniu zadania poziom energii bedzie wiekszy od 0, mozna wykonac zadania
            if (Energy - eToSub > 0)
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

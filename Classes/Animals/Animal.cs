using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_OOP_Inheritance.Classes.Animals
{
    internal abstract class Animal
    {
        public string Species { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int NumOfLegs { get; set; }
        public bool IsTame { get; set; }
        public string Habitat { get; set; }

        public Animal(string species, string name, int age, int numOfLegs, bool isTame, string habitat)
        {
            Species = species;
            Name = name;
            Age = age;
            NumOfLegs = numOfLegs;
            IsTame = isTame;
            Habitat = habitat;
        }

        public virtual void Introduce()
        {
            Console.WriteLine($"{Name} är en {Species} som är {Age} år gammal. {Name} har {NumOfLegs} ben och bor {Habitat}.");
            if (IsTame)
            {
                Console.WriteLine($"{Name} är tam. Du får klappa om du vill!");
            }
            else
            {
                Console.WriteLine($"{Name} är inte tam. Var försiktig!");
            }
        }

        public abstract void MakeSound();

        public abstract void Move();

        public virtual void Eat()
        {
            Console.WriteLine($"{Name} äter.");
        }

    }
}

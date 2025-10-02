using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_OOP_Inheritance.Classes.Animals
{
    internal abstract class Animal
    {
        public string Species { get; set; } = "obestämd art";
        public string Name { get; set; }
        public int Age { get; set; }
        public int NumOfLegs { get; set; }
        public bool IsTame { get; set; }
        public string Habitat { get; set; } = "i det vilda";

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
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

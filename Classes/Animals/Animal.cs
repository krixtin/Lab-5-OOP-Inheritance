using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_OOP_Inheritance.Classes.Animals
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int NumOfLegs { get; set; }
        public bool IsTame { get; set; }
        public string Habitat { get; set; }

        public Animal(string name, int age, int numOfLegs, bool isTame, string habitat)
        {
            Name = name;
            Age = age;
            NumOfLegs = numOfLegs;
            IsTame = isTame;
            Habitat = habitat;
        }

        public abstract void Introduce();
        public abstract void MakeSound();

        public abstract void Move();

        public virtual void Eat()
        {
            Console.WriteLine($"{Name} äter.");
        }

    }
}

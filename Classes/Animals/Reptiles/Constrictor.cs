using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_OOP_Inheritance.Classes.Animals.Reptiles
{
    internal class Constrictor : Snake
    {
        public Constrictor(string name, int age, int lengthInCm) : base(name, age, lengthInCm)
        {
        }

        public void Constrict()
        {
            Console.WriteLine($"{Name} kramar sitt byte till döds.");
        }

    }
}

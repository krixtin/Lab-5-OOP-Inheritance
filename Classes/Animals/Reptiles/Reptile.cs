using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_OOP_Inheritance.Classes.Animals.Reptiles
{
    internal abstract class Reptile : Animal
    {
        public Reptile(string name, int age) : base(name, age)
        {
        }

        public virtual void LayEgg()
        {
            Console.WriteLine($"{Name} lägger ägg.");
        }

    }
}

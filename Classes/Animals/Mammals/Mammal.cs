using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_5_OOP_Inheritance.Classes.Animals.Mammals
{
    internal abstract class Mammal : Animal
    {
        public int NumOfNipples { get; set; }

        public Mammal(string name, int age) : base(name, age)
        {
            Name = name;
            Age = age;
        }

        public abstract void HaveKids(int numOfKids);


    }
}

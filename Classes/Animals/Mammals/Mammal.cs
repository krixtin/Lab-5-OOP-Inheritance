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

        public Mammal(string name, int age, int numOfLegs, bool isTame, string habitat, int numOfNipples) : base(name, age, numOfLegs, isTame, habitat)
        {
            Name = name;
            Age = age;
            NumOfLegs = numOfLegs;
            IsTame = isTame;
            Habitat = habitat;
            NumOfNipples = numOfNipples;
        }

        public abstract void HaveKids(int numOfKids);


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_OOP_Inheritance.Classes.Animals.Mammals
{
    internal class Cat : Mammal
    {
        public bool IsLongHaired { get; set; }

        public Cat(string name, int age, int numOfLegs, bool isTame, string habitat, int numOfNipples, bool isLongHaired) : base(name, age, numOfLegs, isTame, habitat, numOfNipples)
        {
            Name = name;
            Age = age;
            NumOfLegs = numOfLegs;
            IsTame = isTame;
            Habitat = habitat;
            NumOfNipples = numOfNipples;
            IsLongHaired = isLongHaired;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} säger: \"Mjau!\"");
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} svansar omkring.");
        }

        public override void HaveKids(int numOfKids)
        {
            Console.WriteLine($"{Name} får en kull med {numOfKids} underbara kattungar.");
        }

        public void Purr()
        {
            Console.WriteLine($"{Name} spinner förnöjt.");
        }


    }
}

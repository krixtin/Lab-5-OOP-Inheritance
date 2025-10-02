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
        public string Species { get; set; } = "katt";
        public int NumOfLegs { get; set; } = 4;
        public bool IsTame { get; set; } = true;
        public string Habitat { get; set; } = "i ett hus";
        public int NumOfNipples { get; set; } = 8;
        

        public Cat(string name, int age, bool isLongHaired) : base(name, age)
        {
            Name = name;
            Age = age;
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

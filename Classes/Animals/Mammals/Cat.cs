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
        

        public Cat(string name, int age, bool isLongHaired) : base(name, age)
        {
            Species = "katt";
            NumOfLegs = 4;
            IsTame = true;
            Habitat = "i ett hus";
            NumOfNipples = 8;
            IsLongHaired = isLongHaired;
        }

        public override void Introduce()
        {
            if (IsLongHaired)
            {
                Console.WriteLine($"{Name} är en långhårig katt som är {Age} år gammal. {Name} har {NumOfLegs} ben och bor {Habitat}.");
            }
            else
            {
                Console.WriteLine($"{Name} är en korthårig katt som är {Age} år gammal. {Name} har {NumOfLegs} ben och bor {Habitat}.");
            }
            if (IsTame == false)
            {
                Console.WriteLine($"{Name} är inte tam. Var försiktig!");
            }
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

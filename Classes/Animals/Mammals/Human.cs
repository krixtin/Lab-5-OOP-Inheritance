using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_OOP_Inheritance.Classes.Animals.Mammals
{
    internal class Human : Mammal
    {
        public int HeightInCm { get; set; } = 170;

        public Human(string name, int age, int heightInCm) : base(name, age)
        {
            Species = "människa";
            NumOfLegs = 2;
            IsTame = false;
            Habitat = "i ett hus";
            NumOfNipples = 2;
            HeightInCm = heightInCm;
        }

        public override void Introduce()
        {
            Console.WriteLine($"{Name} är en {Species} som är {Age} år gammal och {HeightInCm} cm lång. {Name} bor {Habitat} och har {NumOfLegs} ben.");            
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} säger: \"Hej hej!\"");
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} går på en promenad.");
        }

        public override void HaveKids(int numOfKids)
        {
            if (numOfKids == 1)
            {
                Console.WriteLine($"{Name} har fått ett barn!");
            }
            else if (numOfKids == 2)
            {
                Console.WriteLine($"{Name} har fått tvillingar!");
            }
            else if (numOfKids == 3)
            {
                Console.WriteLine($"Jösses! {Name} har fått trillingar!");
            }
            else if (numOfKids > 3 && numOfKids < 9)
            {
                Console.WriteLine($"Det ballar ur! {Name} har fått {numOfKids}-lingar!");
            }
            else
            {
                Console.WriteLine("Människor kan inte få så många barn, tror jag.");
            }

        }

        public void Cook()
        {
            Console.WriteLine($"{Name} lagar mat, för {Name} är en människa och människor kan göra sånt.");
        }

        public void Categorise()
        {
            Console.WriteLine($"Människor älskar att kategorisera saker! På gott och ont...");
        }



    }
}

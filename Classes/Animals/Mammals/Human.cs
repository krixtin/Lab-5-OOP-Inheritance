using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_OOP_Inheritance.Classes.Animals.Mammals
{
    internal class Human : Mammal
    {
        public int HeightInCm {  get; set; }

        public Human(string species, string name, int age, int numOfLegs, bool isTame, string habitat, int numOfNipples, int heightInCm) : base(species, name, age, numOfLegs, isTame, habitat, numOfNipples)
        {
            Name = name;
            Age = age;
            NumOfLegs = numOfLegs;
            IsTame = isTame;
            Habitat = habitat;
            NumOfNipples = numOfNipples;
            HeightInCm = heightInCm;
        }

        public override void Introduce()
        {
            Console.WriteLine($"{Name} är en {Species} som är {Age} år gammal och {HeightInCm} cm lång.");            
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

        }

        public void Cook()
        {
            Console.WriteLine($"{Name} lagar mat, för {Name} är en människa och människor kan göra sånt.");
        }



    }
}

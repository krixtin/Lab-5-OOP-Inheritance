using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_OOP_Inheritance.Classes.Animals.Mammals
{
    internal class Llama : Mammal
    {
        public bool IsWearingHat { get; set; }
        public string Species { get; set; } = "lama";
        public int NumOfLegs { get; set; } = 4;
        public bool IsTame { get; set; } = true;
        public string Habitat { get; set; } = "i en hage";
        public int NumOfNipples { get; set; } = 4;

        public Llama(string name, int age, bool isWearingHat) : base(name, age)
        {
            Name = name;
            Age = age;
            IsWearingHat = isWearingHat;
        }

        public override void Introduce()
        {
            base.Introduce();
            if (IsWearingHat)
            {
                Console.WriteLine($"{Name} har på sig en hatt! Vad gulligt!");
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} bräker!");
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} skuttar omkring.");
        }

        public override void HaveKids(int numOfKids)
        {
            if (numOfKids == 1)
            {
                Console.WriteLine($"{Name} har fått en gullig liten lamaunge!");
            }
            else if (numOfKids == 2)
            {
                Console.WriteLine($"{Name} har fått tvillingar! Lamor kan få det, men det är ovanligt!");
            }
            else
            {
                Console.WriteLine("Lamor kan inte få så många ungar, tror jag.");
            }
        }

        public void Spit()
        {
            Console.WriteLine($"{Name} spottar. Akta!");
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_OOP_Inheritance.Classes.Animals.Reptiles
{
    internal class Snake : Reptile
    {
        public int LengthInCm { get; set; } = 100;


        public Snake(string name, int age, int lengthInCm) : base(name, age)
        {
            Species = "orm";
            NumOfLegs = 0;
            IsTame = false;
            Habitat = "i skogen";
            LengthInCm = lengthInCm;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} väser.");
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} slingrar sig fram.");
        }

        public override void LayEgg()
        {
            Console.WriteLine($"{Name} lägger en hög med ägg och slingrar sig runt den.");
        }

        public void Bite()
        {
            Console.WriteLine($"Akta! {Name} hugger!");
        }


    }
}

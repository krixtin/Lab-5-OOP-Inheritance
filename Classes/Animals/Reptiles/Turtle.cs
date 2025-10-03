using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_OOP_Inheritance.Classes.Animals.Reptiles
{
    internal class Turtle : Reptile
    {

        public string Size { get; set; } = "medelstor";
        
        public Turtle(string name, int age, string size) : base(name, age)
        {
            Species = "sköldpadda";
            NumOfLegs = 4;
            IsTame = false;
            Habitat = "i sitt skal";
            Size = size;
        }
        public override void Introduce()
        {
            Console.WriteLine($"{Name} är en {Size} {Species} som är {Age} år gammal. {Name} har {NumOfLegs} ben och bor {Habitat}.");
            if (IsTame)
            {
                Console.WriteLine($"{Name} är tam. Du får klappa om du vill!");
            }
            else
            {
                Console.WriteLine($"{Name} är inte tam. Var försiktig!");
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} gör sköldpaddsljud.");
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} går lååångsamt framåt.");
        }

        public override void LayEgg()
        {
            Console.WriteLine($"{Name} lägger hundratals ägg i sanden, gräver ner dem och går sen vidare med sitt liv utan en ytterligare tanke på sin avkomma.");
        }

        public void Swim()
        {
            Console.WriteLine($"{Name} simmar.");
        }

        public void Hibernate()
        {
            Console.WriteLine($"Det har blivit dags för {Name} att gå i sin årliga dvala.");
        }

    }
}

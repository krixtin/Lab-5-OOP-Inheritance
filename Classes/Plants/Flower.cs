using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_OOP_Inheritance.Classes.Plants
{
    internal class Flower : Plant
    {
        public string Color { get; set; }

        public Flower(string species, string color) : base(species)
        {
            Color = color;
        }

        public void Bloom()
        {
            Console.WriteLine($"Nu blommar {Species}en. Blommorna har färgen {Color}.");
        }






    }
}

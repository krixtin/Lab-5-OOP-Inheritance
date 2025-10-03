using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_OOP_Inheritance.Classes.Plants
{
    internal abstract class Plant
    {
        public bool IsDomesticated { get; set; }
        public string Species { get; set; } = "obestämd art";

        public Plant(string species)
        {
            Species = species;
        }

        public void Grow()
        {
            Console.WriteLine($"Det växer {Species} här.");
        }

    }
}

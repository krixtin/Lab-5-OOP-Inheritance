using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_OOP_Inheritance.Classes.Plants
{
    internal class Crop : Plant
    {
        public string Season { get; set; }
        
        public Crop(string species) : base(species)
        {
            IsDomesticated = true;
        }

        public void Harvest()
        {
            Console.WriteLine($"Det är dags att skörda {Species}.");
        }

    }
}

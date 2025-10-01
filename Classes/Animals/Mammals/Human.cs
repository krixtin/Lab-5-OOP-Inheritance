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

        public Human(string name, int age, int numOfLegs, bool isTame, string habitat, int numOfNipples, int heightInCm) : base(name, age, numOfLegs, isTame, habitat, numOfNipples)
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
            throw new NotImplementedException();
        }
        public override void MakeSound()
        {
            
        }

        public override void Eat()
        {
            base.Eat();
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }

        public override void HaveKids(int numOfKids)
        {
            throw new NotImplementedException();
        }

        public void Cook()
        {

        }



    }
}

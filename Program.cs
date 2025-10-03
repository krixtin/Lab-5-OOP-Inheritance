using Lab_5_OOP_Inheritance.Classes.Animals;
using Lab_5_OOP_Inheritance.Classes.Animals.Mammals;
using Lab_5_OOP_Inheritance.Classes.Animals.Reptiles;
using Lab_5_OOP_Inheritance.Classes.Plants;

namespace Lab_5_OOP_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Cat kattenAlba = new("Alba", 8, false);
            Snake newSnake = new("Ormis", 8, 40);
            Cat kattenLaima = new("Laima", 9, true);
            Constrictor newConstrictorSnake = new("Kaa", 12, 147);
            Llama newLlama = new("Putte", 5, true);
            Human jag = new("Kristin", 36, 158);
            Turtle newTurtle = new("Skalman", 53, "stor");
            Turtle littleTurtle = new("Melvin", 6, "liten");


            List<Animal> animals = new() { kattenAlba, newSnake, kattenLaima, newConstrictorSnake, newLlama, jag, newTurtle, littleTurtle };

            foreach (Animal animal in animals)
            {
                animal.Introduce();
            }

            Console.WriteLine();

            foreach (Animal animal in animals)
            {
                animal.MakeSound();
            }

            Console.WriteLine();

            foreach (Animal animal in animals)
            {
                animal.Move();
            }


            Flower sunflower = new("solros", "gul");
            Flower forgetmenot = new("förgätmigej", "blå");
            Crop tomato = new("tomat");

            List<Plant> plants = new() { sunflower, forgetmenot, tomato };

            Console.WriteLine();

            foreach (Plant plant in plants)
            {
                plant.Grow();
            }
            
            forgetmenot.Bloom();

            tomato.Harvest();
        }
    }
}

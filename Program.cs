using Lab_5_OOP_Inheritance.Classes.Animals.Mammals;

namespace Lab_5_OOP_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat kattenLaima = new Cat("katt", "Laima", 9, 4, true, "i en lägenhet", 8, true);
            kattenLaima.Introduce();
            kattenLaima.Eat();
            kattenLaima.Purr();

            Human jag = new Human("människa", "Kristin", 36, 2, false, "i en lägenhet", 2, 158);
            jag.Introduce();
            jag.Cook();
            jag.HaveKids(1);


        }
    }
}

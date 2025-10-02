using Lab_5_OOP_Inheritance.Classes.Animals.Mammals;

namespace Lab_5_OOP_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat kattenLaima = new("Laima", 9, true);
            kattenLaima.IsTame = true;
            kattenLaima.Introduce();
            kattenLaima.Eat();
            kattenLaima.Purr();

            Human jag = new("Kristin", 36, 158);
            jag.Introduce();
            jag.Cook();
            jag.HaveKids(1);


        }
    }
}

using System;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            // In the Main method, get the user input, create a Circle object, and display the
            //circumference and area.
            bool repeat = true;
            int num = 0;
            Console.WriteLine("Welcome to the Circumference Calculator!\n");
            while (repeat)
            {
                    Console.WriteLine("Please enter a radius: ");
                    double radius = Validator.ValidateNumber();
                    Circle circle = new Circle(radius);
                    Console.WriteLine($"Circumference: {circle.CalculateFormattedCircumference()}\nArea: {circle.CalculateFormattedArea()}");
                    repeat = Validator.Repeat();
                    num += 1;
            }
            if (num > 1)
            {
                Console.WriteLine($"GoodBye!\nYou created {num} cirlces!");
            }
            else
            {
                Console.WriteLine($"GoodBye!\nYou created {num} cirlce!");
            }
        }
    
    }
}

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
            bool success = true;
            Console.WriteLine("Welcome to the Circumference Calculator!\n");
            while (repeat)
            {
                //try
                //{
                    Console.WriteLine("Please enter a radius: ");
                    double radius = Validator.ValidateNumber();
                    Circle circle = new Circle(radius);
                    Console.WriteLine($"Circumference: {circle.CalculateFormattedCircumference()}\nArea: {circle.CalculateFormattedArea()}");
                    //success = true;
                    repeat = Validator.Repeat();
                //}
                //catch (Exception)
                //{
                //    //Console.WriteLine("Im sorry thats not a valid repsonse!");
                //    //repeat = true;
                //    success = false;
                //}
                //if (success)
                //{
                    num += 1;
                //}
                
            }
            if (num > 1)
            {
                Console.WriteLine($"GoodBye! You created {num} cirlces!");
            }
            else
            {
                Console.WriteLine($"GoodBye! You created {num} cirlce!");
            }
        }
    
    }
}

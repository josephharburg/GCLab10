using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10
{
    class Validator
    {
        public Validator()
        {

        }

        public static double ValidateNumber()
        {
            bool repeat = true;
            double test = 0;
            while (repeat)
            {
                try
                {
                    test = double.Parse(Console.ReadLine());
                    repeat = false;
                    
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Please enter a number!");
                    repeat = true;

                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("Please enter a number!");
                    repeat = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a number!");
                    repeat = true;
                }
            }
            return test;

        }
        public static bool Repeat()
        {
            bool repeater = true;
            while (repeater)
            {
                Console.WriteLine("Would You like to Continue?");
                string reply = Console.ReadLine();
                if (string.IsNullOrEmpty(reply))
                {
                    Console.WriteLine("Not a valid response");
                    repeater = true;
                }
                else if (reply.ToLower() == "y" || reply.ToLower() == "yes")
                {
                    repeater = false;
                    return true;

                }
                else if (reply.ToLower() == "n" || reply.ToLower() == "no")
                {
                    repeater = false;
                    return false;

                }
                else
                {
                    Console.WriteLine("Please respond with a y or n!");
                }
            }
            return repeater;


        }
    }
}

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
            string error = "Please enter a number!";
            while (repeat)
            {
                try
                {
                    test = double.Parse(Console.ReadLine());
                    repeat = false;
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine(error);
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine(error);
                }
                catch (Exception)
                {
                    Console.WriteLine(error);
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

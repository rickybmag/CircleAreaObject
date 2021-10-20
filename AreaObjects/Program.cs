using System;
using System.Collections.Generic;

namespace AreaObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Circle> circles = new List<Circle>();

            bool goOn = true;
            bool circleAgain = true;

            while (circleAgain)
            {
                string input = GetInput("Please enter the radius of a circle");

                //Loop to validate radius input. Also asks user if they want to continue to input more circle radius' to add to the radius list.
                try
                {
                    double output = double.Parse(input);

                    if (output >= 0)
                    {
                        //ToString Override
                        Circle c = new Circle(output);

                        //Adds radius input to list, while calculating circle math
                        circles.Add(c);

                        circleAgain = Continue("Would you like to add another circle?");
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number greater than 0\n");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a number\n");
                }
            }
                //Once the user decides to stop inputting circles, their inputs and a good-bye message prints        
                Console.WriteLine();
                Console.WriteLine($"Before you go, you've entered {circles.Count} circle(s)");
                Console.WriteLine("Here are the circles you entered:\n");
                for(int i = 0; i < circles.Count; i++)
                {
                    Console.WriteLine($"{i+1}: {circles[i]}" );
                    Console.WriteLine();
                }
            Console.WriteLine("Goodbye!");
        }

        public static string GetInput(string input)
        {
            Console.WriteLine(input);
            string output = Console.ReadLine();
            return output;
        }

        public static bool Continue(string input)
        {
            {
                Console.WriteLine(input);
                string output = Console.ReadLine().ToLower();
                if (output == "y")
                {
                    return true;
                }
                else if (output == "n")
                {                    
                    return false;
                }
                else
                {
                    Console.WriteLine("Please enter 'y' or 'n'");
                    return Continue(input);
                }
            }
        }     
    }
}

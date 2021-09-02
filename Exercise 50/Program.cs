using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_50
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                List<Triangle> triangleList = BuildList();
                if (triangleList.Any()) // Check that list isn't empty
                {
                    var count = triangleList.Count;
                    var avgArea = triangleList.Average(x => x.Area);
                    var avgPerimeter = triangleList.Average(x => x.Perimeter);

                    Console.WriteLine($"You created {count} Triangles.");                    
                    Console.WriteLine($"Average area:{avgArea}");
                    Console.WriteLine($"Average perimeter {avgPerimeter}");
                    
                }
                else // run if list is empty
                {
                    Console.WriteLine("You didn't enter any data");
                }
            }
            while (WillContinue());

        }
        public static List<Triangle> BuildList()
        {
            List<Triangle> triangleList = new List<Triangle>();
            string inputSides;
            bool exit = true;
            while (exit)
            {
                Console.Write("Enter the 3 side lengths of a triangle separated by single space (q to quit): ");
                inputSides = Console.ReadLine();
                string[] numbers = inputSides.Split(' '); // Split input string into array by spaces
                
                if (inputSides == "q") // Change exit condition if user inputs 'q'
                {
                    exit = false;
                }
                else if (numbers.Length != 3 )
                {
                    Console.WriteLine("Incorrect number of sides.");
                }    
                else if (Double.TryParse(numbers[0], out double sideOne) && Double.TryParse(numbers[1], out double sideTwo) && Double.TryParse(numbers[2], out double sideThree)) // Test if input is valid as double, add to list if true
                {
                    triangleList.Add(new Triangle(sideOne, sideTwo, sideThree));
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
            return triangleList;
        }
        public static bool WillContinue()
        {
            Console.Write("Would you like to continue (y/n)?"); // prompt user to continue or exit

            if (Console.ReadLine().ToLower() == "y") // user input to continue or exit
            {
                return true;
            }

            else
            {
                Console.WriteLine("Goodbye!");
                return false;
            }
        }
    }
}

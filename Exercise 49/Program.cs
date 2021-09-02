using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_49
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                List<Square> squareList = BuildList();
                if (squareList.Any())  // Check that list is not empty. 
                {
                    
                    var count = squareList.Count;
                    var maxLength = squareList.Max(x => x.Length);
                    var minLength = squareList.Min(x => x.Length);
                    var avgArea = squareList.Average(x => x.Area);
                    var avgPerimeter = squareList.Average(x => x.Perimeter);

                    Console.WriteLine($"You created {count} Squares.");
                    Console.WriteLine($"Largest: {maxLength}");
                    Console.WriteLine($"Smallest: {minLength}");
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

        public static List<Square> BuildList()
        {
            List<Square> squareList = new List<Square>();
            string inputLength;
            bool exit = true;
            while (exit)
            {
                Console.Write("Enter a side length (q to quit): ");
                inputLength = Console.ReadLine();

                if (inputLength == "q") // Change exit condition if user inputs 'q'
                {
                    exit = false;  
                }

                else if (Double.TryParse(inputLength, out double isDouble)) // Test if input is valid as double, add to list if true
                {
                    squareList.Add(new Square(isDouble));  
                }

                else  // if user input is not q or not valid as double
                {
                    Console.WriteLine("Invalid input");
                }       
            }
            return squareList;
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

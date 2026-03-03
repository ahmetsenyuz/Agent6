using System;

namespace Agent6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime Number Checker");
            Console.WriteLine("====================");
            Console.WriteLine("Enter integers to check if they are prime.");
            Console.WriteLine("Press ESC key to exit.");
            Console.WriteLine();

            while (true)
            {
                Console.Write("Enter an integer (or ESC to exit): ");
                string input = Console.ReadLine();
                
                // Check if user wants to exit
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("\nExiting application...");
                    break;
                }
                
                // Try to parse the input as an integer
                if (int.TryParse(input, out int number))
                {
                    bool isPrime = PrimeChecker.IsPrime(number);
                    Console.WriteLine($"{number} is {(isPrime ? "" : "not ")}prime.");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer or press ESC to exit.");
                }
                
                Console.WriteLine();
            }
        }
    }
}
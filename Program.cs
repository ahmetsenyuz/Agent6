using System;

namespace Agent6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            // Test the PrimeChecker
            Console.WriteLine("Testing PrimeChecker:");
            int[] testNumbers = { -5, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 17, 25, 29 };
            
            foreach (int num in testNumbers)
            {
                bool isPrime = PrimeChecker.IsPrime(num);
                Console.WriteLine($"{num} is {(isPrime ? "" : "not ")}prime");
            }

            // Wait for user input before closing
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
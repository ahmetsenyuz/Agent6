using System;

namespace Agent6
{
    public class PrimeChecker
    {
        /// <summary>
        /// Determines whether the specified number is prime.
        /// </summary>
        /// <param name="number">The number to check.</param>
        /// <returns>true if the number is prime; otherwise, false.</returns>
        public static bool IsPrime(int number)
        {
            // Handle edge cases
            if (number <= 1)
                return false;

            if (number <= 3)
                return true;

            // Even numbers greater than 2 are not prime
            if (number % 2 == 0)
                return false;

            // Check for divisors from 3 up to the square root of the number
            for (int i = 3; i * i <= number; i += 2)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}
using System;
using System.Diagnostics;
using Agent6.Exceptions;
using Agent6.Logging;

namespace Agent6
{
    /// <summary>
    /// Provides methods for checking if numbers are prime.
    /// </summary>
    public class PrimeChecker
    {
        /// <summary>
        /// Counter for numbers checked
        /// </summary>
        public static int NumbersChecked { get; set; } = 0;
        
        /// <summary>
        /// Counter for primes found
        /// </summary>
        public static int PrimesFound { get; set; } = 0;

        /// <summary>
        /// Determines whether the specified number is prime.
        /// </summary>
        /// <param name="number">The number to check.</param>
        /// <returns>true if the number is prime; otherwise, false.</returns>
        public static bool IsPrime(int number)
        {
            try
            {
                NumbersChecked++;
                
                // Handle edge cases
                if (number <= 1)
                    return false;

                if (number <= 3)
                    return true;

                // Even numbers greater than 2 are not prime
                if (number % 2 == 0)
                    return false;

                // Check for divisors from 3 up to the square root of the number
                // Only check odd divisors
                for (int i = 3; i * i <= number; i += 2)
                {
                    if (number % i == 0)
                        return false;
                }

                PrimesFound++;
                return true;
            }
            catch (Exception ex)
            {
                Logger.LogError($"Error in IsPrime method for number {number}: {ex.Message}");
                throw new PrimeCheckException($"An error occurred while checking if {number} is prime", ex);
            }
        }

        /// <summary>
        /// Determines whether the specified number is prime with performance measurement.
        /// </summary>
        /// <param name="number">The number to check.</param>
        /// <returns>true if the number is prime; otherwise, false.</returns>
        public static bool IsPrimeWithTiming(int number)
        {
            try
            {
                var stopwatch = Stopwatch.StartNew();
                bool result = IsPrime(number);
                stopwatch.Stop();

                Logger.LogInfo($"Prime check for {number} took {stopwatch.ElapsedMilliseconds} ms");
                return result;
            }
            catch (Exception ex)
            {
                Logger.LogError($"Error in IsPrimeWithTiming method for number {number}: {ex.Message}");
                throw new PrimeCheckException($"An error occurred while checking if {number} is prime with timing", ex);
            }
        }
    }
}
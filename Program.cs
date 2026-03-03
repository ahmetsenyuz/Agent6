using System;
using Agent6.Exceptions;
using Agent6.Logging;

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

                // Handle empty input
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Invalid input. Empty input is not allowed. Please enter a valid integer or press ESC to exit.");
                    Console.WriteLine();
                    continue;
                }

                // Try to parse the input as an integer
                if (int.TryParse(input, out int number))
                {
                    try
                    {
                        bool isPrime = PrimeChecker.IsPrimeWithTiming(number);
                        Console.WriteLine($"{number} is {(isPrime ? "" : "not ")}prime.");
                    }
                    catch (InvalidInputException ex)
                    {
                        Console.WriteLine($"Invalid input error: {ex.Message}");
                        Logger.LogError($"Invalid input error: {ex.Message}");
                    }
                    catch (CalculationOverflowException ex)
                    {
                        Console.WriteLine($"Calculation overflow error: {ex.Message}");
                        Logger.LogError($"Calculation overflow error: {ex.Message}");
                    }
                    catch (PrimeCheckException ex)
                    {
                        Console.WriteLine($"Prime check error: {ex.Message}");
                        Logger.LogError($"Prime check error: {ex.Message}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Unexpected error during prime check: {ex.Message}");
                        Logger.LogError($"Unexpected error during prime check: {ex.Message}");
                    }
                }
                else
                {
                    // Handle non-numeric strings
                    if (input.Contains(".") || input.Contains(","))
                    {
                        // Handle decimal numbers
                        Console.WriteLine("Invalid input. Decimal numbers are not allowed. Please enter a valid integer or press ESC to exit.");
                    }
                    else if (input.Any(c => !char.IsLetter(c)))
                    {
                        // Handle strings with letters
                        Console.WriteLine("Invalid input. Non-numeric strings are not allowed. Please enter a valid integer or press ESC to exit.");
                    }
                    else if (input.Any(c => !char.IsDigit(c) && c != '-' && c != '+'))
                    {
                        // Handle strings with special characters
                        Console.WriteLine("Invalid input. Special characters are not allowed. Please enter a valid integer or press ESC to exit.");
                    }
                    else
                    {
                        // Handle very large numbers that might cause overflow
                        try
                        {
                            long longNumber = long.Parse(input);
                            if (longNumber > int.MaxValue || longNumber < int.MinValue)
                            {
                                Console.WriteLine("Invalid input. Number is too large. Please enter a valid integer or press ESC to exit.");
                            }
                            else
                            {
                                // This shouldn't happen given our checks, but just in case
                                Console.WriteLine("Unexpected error parsing input. Please enter a valid integer or press ESC to exit.");
                            }
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("Invalid input. Number is too large. Please enter a valid integer or press ESC to exit.");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid input. Please enter a valid integer or press ESC to exit.");
                        }
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
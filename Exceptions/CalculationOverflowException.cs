using System;

namespace Agent6.Exceptions
{
    public class CalculationOverflowException : Exception
    {
        public CalculationOverflowException() : base()
        {
        }

        public CalculationOverflowException(string message) : base(message)
        {
        }

        public CalculationOverflowException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
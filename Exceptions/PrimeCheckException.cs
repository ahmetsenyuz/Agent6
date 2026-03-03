using System;

namespace Agent6.Exceptions
{
    public class PrimeCheckException : Exception
    {
        public PrimeCheckException() : base()
        {
        }

        public PrimeCheckException(string message) : base(message)
        {
        }

        public PrimeCheckException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
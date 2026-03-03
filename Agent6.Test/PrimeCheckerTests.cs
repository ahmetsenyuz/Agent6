using System;
using Xunit;

namespace Agent6.Test
{
    public class PrimeCheckerTests
    {
        [Fact]
        public void IsPrime_Should_Return_True_For_Prime_Numbers()
        {
            // Arrange
            var primeChecker = new PrimeChecker();

            // Act & Assert
            Assert.True(primeChecker.IsPrime(2));
            Assert.True(primeChecker.IsPrime(3));
            Assert.True(primeChecker.IsPrime(5));
            Assert.True(primeChecker.IsPrime(7));
            Assert.True(primeChecker.IsPrime(11));
            Assert.True(primeChecker.IsPrime(13));
            Assert.True(primeChecker.IsPrime(17));
            Assert.True(primeChecker.IsPrime(19));
            Assert.True(primeChecker.IsPrime(23));
        }

        [Fact]
        public void IsPrime_Should_Return_False_For_Composite_Numbers()
        {
            // Arrange
            var primeChecker = new PrimeChecker();

            // Act & Assert
            Assert.False(primeChecker.IsPrime(4));
            Assert.False(primeChecker.IsPrime(6));
            Assert.False(primeChecker.IsPrime(8));
            Assert.False(primeChecker.IsPrime(9));
            Assert.False(primeChecker.IsPrime(10));
            Assert.False(primeChecker.IsPrime(12));
            Assert.False(primeChecker.IsPrime(14));
            Assert.False(primeChecker.IsPrime(15));
            Assert.False(primeChecker.IsPrime(16));
        }

        [Fact]
        public void IsPrime_Should_Return_False_For_Negative_Numbers()
        {
            // Arrange
            var primeChecker = new PrimeChecker();

            // Act & Assert
            Assert.False(primeChecker.IsPrime(-1));
            Assert.False(primeChecker.IsPrime(-2));
            Assert.False(primeChecker.IsPrime(-100));
        }

        [Fact]
        public void IsPrime_Should_Return_False_For_Zero_And_One()
        {
            // Arrange
            var primeChecker = new PrimeChecker();

            // Act & Assert
            Assert.False(primeChecker.IsPrime(0));
            Assert.False(primeChecker.IsPrime(1));
        }

        [Fact]
        public void IsPrime_Should_Return_True_For_Large_Primes()
        {
            // Arrange
            var primeChecker = new PrimeChecker();

            // Act & Assert
            Assert.True(primeChecker.IsPrime(97));
            Assert.True(primeChecker.IsPrime(101));
            Assert.True(primeChecker.IsPrime(103));
            Assert.True(primeChecker.IsPrime(107));
            Assert.True(primeChecker.IsPrime(109));
            Assert.True(primeChecker.IsPrime(113));
        }

        [Fact]
        public void IsPrime_Should_Return_False_For_Large_Composites()
        {
            // Arrange
            var primeChecker = new PrimeChecker();

            // Act & Assert
            Assert.False(primeChecker.IsPrime(100));
            Assert.False(primeChecker.IsPrime(102));
            Assert.False(primeChecker.IsPrime(104));
            Assert.False(primeChecker.IsPrime(105));
            Assert.False(primeChecker.IsPrime(106));
            Assert.False(primeChecker.IsPrime(108));
        }
    }
}
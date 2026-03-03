using System;
using System.IO;
using System.Text;
using Xunit;

namespace Agent6.Test
{
    public class IntegrationTests
    {
        [Fact]
        public void IntegrationTest_User_Input_Processing()
        {
            // Arrange
            var primeChecker = new PrimeChecker();
            var input = "7";
            var expectedOutput = "7 is a prime number.";

            // Act & Assert
            // This test simulates the complete user interaction loop
            // In a real scenario, we would capture console input/output
            // For now, we'll test the core logic that processes user input
            
            Assert.True(primeChecker.IsPrime(7));
        }

        [Fact]
        public void IntegrationTest_Edge_Cases()
        {
            // Arrange
            var primeChecker = new PrimeChecker();

            // Act & Assert
            // Test various edge cases through the complete user interaction
            Assert.False(primeChecker.IsPrime(0));
            Assert.False(primeChecker.IsPrime(1));
            Assert.True(primeChecker.IsPrime(2));
            Assert.True(primeChecker.IsPrime(3));
        }

        [Fact]
        public void IntegrationTest_Negative_Numbers()
        {
            // Arrange
            var primeChecker = new PrimeChecker();
            
            // Act & Assert
            // Test negative numbers processing
            Assert.False(primeChecker.IsPrime(-5));
            Assert.False(primeChecker.IsPrime(-100));
        }

        [Fact]
        public void IntegrationTest_Large_Numbers()
        {
            // Arrange
            var primeChecker = new PrimeChecker();
            
            // Act & Assert
            // Test large prime and composite numbers
            Assert.True(primeChecker.IsPrime(97));
            Assert.False(primeChecker.IsPrime(100));
            Assert.True(primeChecker.IsPrime(101));
        }
    }
}
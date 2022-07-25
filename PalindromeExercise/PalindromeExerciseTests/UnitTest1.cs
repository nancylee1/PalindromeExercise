using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("dad", true)]
        [InlineData("Hannah", true)]  // using Linq's .ToLower()
        [InlineData("levels", false)]
        [InlineData(null, false)]
        [InlineData("", true)]
        [InlineData("Was it a car or a cat I saw", true)]  // using Linq's .Replace(" ", "")
        [InlineData("never odd or even", true)] // using Linq's .Replace(" ", "") to remove the spaces, then ending with .Reverse()) to check for Palindrome!

        public void PalindromeTestTakesInString_OutputsTrueOrFalseIfPalindrome(string word, bool expected)
        {
            //Arrange - create a new wordsmith object
            var wordSmith = new WordSmith(); 

            //Act
            var answer = wordSmith.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, answer);
        }
    }
}

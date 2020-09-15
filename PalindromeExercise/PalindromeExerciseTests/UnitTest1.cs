using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        [InlineData("civic", true)]
        [InlineData("cat", false)]
        [InlineData("stats", true)]
        public void IsAPalindrome(string input, bool expected)
        {
            var p = new WordSmith();
            bool actual = p.IsAPalindrome(input);
            Assert.Equal(actual, expected);
        }
    }
}

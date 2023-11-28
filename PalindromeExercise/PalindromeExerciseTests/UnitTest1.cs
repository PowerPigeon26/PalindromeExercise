using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("mom", true)]
        [InlineData("rotator", true)]
        [InlineData("Maverick", false)]
        [InlineData("Sociopath", false)]
        [InlineData("fish", false)]
        public void Test1(string word, bool expected)
        {
            WordSmith instance = new WordSmith();

            var actual = instance.IsAPalindrome(word);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("racecar", true)]
        [InlineData("A man, a plan, a canal, Panama!", true)]
        [InlineData("Never odd or even.", true)]
        [InlineData("Maverick", false)]
        [InlineData("Ah, hello hello?", false)]
        [InlineData("Ugh, a bug!", false)]
        public void Test2(string word, bool expected)
        {
            WordSmith instance = new WordSmith();

            var actual = instance.IsASuperPalindrome(word);

            Assert.Equal(expected, actual);
        }
    }
}

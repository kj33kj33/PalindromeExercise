using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("smart", false)]
        [InlineData("Otto", true)]
        [InlineData("rocket", false)]
        [InlineData("eye", true)]
        public void Test1(string word, bool expected)
        {
            WordSmith wordsmith = new WordSmith();

            var actual = wordsmith.IsAPalindrome(word);

            Assert.Equal(actual, expected);
        }
    }
}

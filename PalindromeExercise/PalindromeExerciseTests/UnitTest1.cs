using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        
        
        public class PalTest
        {
            [Theory]
            [InlineData("racecar", true)]
            [InlineData("Racecar", true)]
            [InlineData("kayak", true)]
            [InlineData("hannah", true)]
            [InlineData("banana", false)]
            [InlineData("test", false)]
            public void IsAPalindromeTest(string word, bool expected)
            {
                //arrange
                var ws = new WordSmith();
                //act
                var actual = ws.IsAPalindrome(word);
                //assert
                Assert.Equal(expected, actual);

            }  
                
        }
    }   

}

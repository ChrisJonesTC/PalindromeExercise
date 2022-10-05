using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
  public class UnitTest1
  {
    
        [Theory]
    [InlineData("racecar", true)]
    [InlineData("deified", true)]
    [InlineData("noon", true)]
    [InlineData("rotator", true)]
    [InlineData("firetruck", false)]
    [InlineData("coding", false)]
    [InlineData("", false)]
    [InlineData(null, false)]
    public void IsAPalindrome_Test(string word, bool expected)
    {
        //Arrange
        var ws = new WordSmith();
        //Act
        var actual = ws.IsAPalindrome(word);
        //Assert
        Assert.Equal(expected, actual);
    }
    
  }
}

namespace Tests;

public class MinimumWindowSubstringTest
{
    [Fact]
    public void MinimumWindowSubstring_ShouldReturnMinimumWindowSubstring()
    {

        //Arrange
        var MinimumWindowSubstring = new MinimumWindowSubstring();
        string s = "ADOBECODEBANC", t = "ABC", output = "BANC";

        //Act
        var result = MinimumWindowSubstring.FindMinimumWindowSubstring(s, t);

        //Assert
        Assert.Equal(output, result);
    }


    [Fact]
    public void MinimumWindowSubstring_ShouldReturnStringEmptyIfSubstringDoesNotExist()
    {

        //Arrange
        var MinimumWindowSubstring = new MinimumWindowSubstring();
        string s = "a", t = "aa", output = "";

        //Act
        var result = MinimumWindowSubstring.FindMinimumWindowSubstring(s, t);

        //Assert
        Assert.Equal(output, result);
    }

     [Fact]
        public void FindMinimumWindowSubstring_ShouldReturnSubstringWithDuplicates()
        {
            // Arrange
            var MinimumWindowSubstring = new MinimumWindowSubstring();
            string s = "ADOBECODEBANCCODEBANC", t = "ABCC", output = "BANCC";

            // Act
            var result = MinimumWindowSubstring.FindMinimumWindowSubstring(s, t);

            // Assert
            Assert.Equal(output, result);
        }
}

using Exercises;
namespace Tests;

public class ValidAnagramTest
{
    [Fact]
    public void AreAnagrams_ShouldReturnTrue_WhenWordsAreAnagrams()
    {
        // Arrange
        var validAnagram = new ValidAnagram();
        string firstWord = "rato";
        string secondWord = "taro";

        // Act
        bool result = validAnagram.AreAnagrams(firstWord, secondWord);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void AreAnagrams_ShouldReturnFalse_WhenWordsAreEqual()
    {
        // Arrange
        var validAnagram = new ValidAnagram();
        string firstWord = "bola";
        string secondWord = "bola";

        // Act
        bool result = validAnagram.AreAnagrams(firstWord, secondWord);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void AreAnagrams_ShouldReturnFalse_WhenWordsAreNotAnagrams()
    {
        // Arrange
        var validAnagram = new ValidAnagram();
        string firstWord = "rato";
        string secondWord = "rata";

        // Act
        bool result = validAnagram.AreAnagrams(firstWord, secondWord);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void AreAnagrams_ShouldReturnFalse_WhenWordsHaveDifferentLengths()
    {
        // Arrange
        var validAnagram = new ValidAnagram();
        string firstWord = "soccer";
        string secondWord = "futebol";

        // Act
        bool result = validAnagram.AreAnagrams(firstWord, secondWord);

        // Assert
        Assert.False(result);
    }

}

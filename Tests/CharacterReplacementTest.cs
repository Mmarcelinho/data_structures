namespace Tests;

public class CharacterReplacementTest
{
    [Fact]
    public void CharacterReplacement_ShouldReturnLongestSubstringWithKReplacedElements()
    {

        //Arrange
        var CharacterReplacement = new CharacterReplacement();
        string str = "AABABBA";
        int k = 1;

        //Act
        var result = CharacterReplacement.ReplaceCharacter(str, k);

        //Assert
        Assert.Equal(4, result);
    }

    [Fact]
    public void ReplaceCharacter_ShouldReturnStringLengthForKGreaterThanStringLength()
    {
        // Arrange
        var characterReplacement = new CharacterReplacement();
        string str = "ABCDEF";
        int k = 10;

        // Act
        var result = CharacterReplacement.ReplaceCharacter(str, k);

        // Assert
        Assert.Equal(str.Length, result);
    }

    [Fact]
    public void ReplaceCharacter_ShouldReturnLongestSubstringWithKReplacedElementsForKEqualZero()
    {
        // Arrange
        var characterReplacement = new CharacterReplacement();
        string str = "AABABBA";
        int k = 0;

        // Act
        var result = CharacterReplacement.ReplaceCharacter(str, k);

        // Assert
        Assert.Equal(2, result);
    }

    [Fact]
    public void ReplaceCharacter_ShouldReturnStringLengthForKEqualZeroAndEmptyString()
    {
        // Arrange
        var characterReplacement = new CharacterReplacement();
        string str = "";
        int k = 0;

        // Act
        var result = CharacterReplacement.ReplaceCharacter(str, k);

        // Assert
        Assert.Equal(0, result);
    }
}

namespace Tests;

    public class ValidPalindromeTest
    {
        [Fact]
        public void ValidPalindrome_ShouldReturnTrue_WhenPhraseArePalindrome(){

            //Arrange
            var ValidPalindrome = new ValidPalindrome();
            string Phrase = "A man, a plan, a canal: Panama";

            //Act
            var result = ValidPalindrome.IsPalindrome(Phrase);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void ValidPalindrome_ShouldReturnFalse_WhenPhraseNotPalindrome(){

            //Arrange
            var ValidPalindrome = new ValidPalindrome();
            string Phrase = "race a car";

            //Act
            var result = ValidPalindrome.IsPalindrome(Phrase);

            //Assert
            Assert.False(result);
        }
        
    }

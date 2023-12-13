namespace Tests;

    public class LongestSubstringCalculatorTest
    {
        [Fact]
        public void LongestSubstringCalculator_ShouldReturnLongestSubstring(){

            //Arrange
            var LongestSubstringCalculator = new LongestSubstringCalculator();
            string str = "abcabcbb";

            //Act
            var result = LongestSubstringCalculator.CalculateLengthOfLongestSubstring(str);

            //Assert
            Assert.Equal(3,result);
        }
    }

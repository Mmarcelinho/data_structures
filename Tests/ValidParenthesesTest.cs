namespace Test;

    public class ValidParenthesesTest
    {
        [Fact]
        public void ValidParentheses_ShoudReturnTrue_WhenParenthesesAreBalanced(){

            //Arrange
            var ValidParentheses = new ValidParentheses();
            string s = "()[]{}";

            //Act
            var result = ValidParentheses.IsValid(s);
            
            //Assert
            Assert.True(result);
        }        

        [Fact]
        public void ValidParentheses_ShoudReturnFalse_WhenParenthesesAreNotBalanced(){

            //Arrange
            var ValidParentheses = new ValidParentheses();
            string s = "(]";

            //Act
            var result = ValidParentheses.IsValid(s);
            
            //Assert
            Assert.False(result);
        }        
    }

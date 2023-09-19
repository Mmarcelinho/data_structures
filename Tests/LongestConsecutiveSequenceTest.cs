using Exercises;
namespace Tests;
    public class LongestConsecutiveSequenceTest
    {
        [Fact]
        public void LongestConsecutiveSequence_ShouldReturnLongestStreak()
        {
            //Arrange
            var LongestConsecutiveSequence = new LongestConsecutiveSequence();
            int[] numbers = {0,3,7,2,5,8,4,6,0,1};

            //Act
            var result = LongestConsecutiveSequence.LongestConsecutive(numbers);

            //Assert
            Assert.Equal(9, result);
        }
    }

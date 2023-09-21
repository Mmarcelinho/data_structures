namespace Tests;

    public class ContainsDuplicateTests
    {
        [Fact]
        public void ContainsDuplicate_ReturnsTrue_WhenDuplicatesExist()
        {
            // Arrange
            var ContainsDuplicate = new ContainsDuplicate();
            int[] numbers = { 1, 2, 3, 4, 2, 5 };

            // Act
            bool result = ContainsDuplicate.containsDuplicate(numbers);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void ContainsDuplicate_ReturnsFalse_WhenNoDuplicatesExist()
        {
            // Arrange
            var ContainsDuplicate = new ContainsDuplicate();
            int[] numbers = { 1, 2, 3, 4, 5 };

            // Act
            bool result = ContainsDuplicate.containsDuplicate(numbers);

            // Assert
            Assert.False(result);
        }
    }

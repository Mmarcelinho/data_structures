namespace Tests;

    public class TwoSumTest
    {

    [Fact]
    public void FindTwoSum_ShouldReturnIndicesOfElementsEqualTarget()
    {
        // Arrange
        var twoSum = new TwoSum();
        int[] numbers = { 1, 2, 3, 4 };
        int[] expectedIndices = { 1, 3 };
        int targetSum = 6;

        // Act
        int[] result = twoSum.FindTwoSum(numbers, targetSum);

        // Assert
        Assert.Equal(expectedIndices, result);
    }

    [Fact]
    public void FindTwoSum_ShouldReturnEmptyArrayWhenNoMatch()
    {
        // Arrange
        var twoSum = new TwoSum();
        int[] numbers = { 1, 2, 3, 4 };
        int targetSum = 10;

        // Act
        int[]? result = twoSum.FindTwoSum(numbers, targetSum);

        // Assert
        Assert.Empty(result); 
    }
}




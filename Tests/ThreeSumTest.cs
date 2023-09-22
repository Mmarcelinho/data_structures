namespace Tests;

public class ThreeSumTest
{
    [Fact]
    public void ThreeSum_ShouldGroupCorrectlyNums()
    {
        // Arrange
        var ThreeSum = new ThreeSum();
        int[] nums = { -1, 0, 1, 2, -1, -4 };

        // Act
        IList<IList<int>> result = ThreeSum.threeSum(nums);

        // Assert
        Assert.Contains(new List<int> { -1, -1, 2 }, result);
        Assert.Contains(new List<int> { -1, 0, 1 }, result);
    }

    [Fact]
    public void ThreeSum_NoSolution_ShouldReturnEmptyList()
    {
        // Arrange
        var ThreeSum = new ThreeSum();
        int[] nums = { 1, 2, 3, 4, 5 };

        // Act
        IList<IList<int>> result = ThreeSum.threeSum(nums);

        // Assert
        Assert.Empty(result);
    }

    [Fact]
    public void ThreeSum_ShouldReturnTripletsWithZeroSum()
    {
        // Arrange
        var ThreeSum = new ThreeSum();
        int[] nums = { -1, 0, 1, 2, -1, -4 };

        // Act
        IList<IList<int>> result = ThreeSum.threeSum(nums);

        // Assert
        foreach (var triplet in result)
        {
            int sum = triplet.Sum();
            Assert.Equal(0, sum);
        }
    }

    [Fact]
    public void ThreeSum_EmptyInput_ShouldReturnEmptyList()
    {
        // Arrange
        var ThreeSum = new ThreeSum();
        int[] nums = { };

        // Act
        IList<IList<int>> result = ThreeSum.threeSum(nums);

        // Assert
        Assert.Empty(result);
    }

}

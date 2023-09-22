namespace Tests;

public class ContainerWithMostWaterTest
{
    [Fact]
    public void ContainerWithMostWater_ShouldReturnMaxArea()
    {
        //Arrange
        var ContainerWithMostWater = new ContainerWithMostWater();
        int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };

        //Act
        var result = ContainerWithMostWater.MaxArea(height);

        //Assert
        Assert.Equal(49, result);
    }

    [Fact]
    public void ContainerWithMostWater_ShouldReturnZeroForEmptyArray()
    {
        // Arrange
        var container = new ContainerWithMostWater();
        int[] height = new int[0];

        // Act
        var result = container.MaxArea(height);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void ContainerWithMostWater_ShouldReturnZeroForSingleElementArray()
    {
        // Arrange
        var container = new ContainerWithMostWater();
        int[] height = { 5 };

        // Act
        var result = container.MaxArea(height);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void ContainerWithMostWater_ShouldHandleDescendingHeights()
    {
        // Arrange
        var container = new ContainerWithMostWater();
        int[] height = { 9, 7, 5, 3, 1 };

        // Act
        var result = container.MaxArea(height);

        // Assert
        Assert.Equal(10, result);
    }

}

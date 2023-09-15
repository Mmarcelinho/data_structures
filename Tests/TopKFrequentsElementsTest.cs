using Exercises;
namespace Tests;

public class TopKFrequentsElementsTest
{
    [Fact]
    public void FindTopKFrequentNumbers_ShouldReturnTopKFrequentElements()
    {
        // Arrange
        var topKFrequentsElements = new TopKFrequentsElements();
        int[] numbers = { 1, 1, 1, 2, 2, 3 };
        int n = 2;
        int[] expected = { 1, 2 };

        // Act
        int[] result = topKFrequentsElements.FindTopKFrequentNumbers(numbers, n);

        // Assert
        Assert.Equal(expected, result);
    }

 
    [Fact]
    public void FindTopKFrequentNumbers_ShouldHandleEmptyArray()
    {
        // Arrange
        var topKFrequentsElements = new TopKFrequentsElements();
        int[] numbers = { };
        int n = 2;
        int[] expected = { }; 

        // Act
        int[] result = topKFrequentsElements.FindTopKFrequentNumbers(numbers, n);

        // Assert
        Assert.Equal(expected, result);
    }
}

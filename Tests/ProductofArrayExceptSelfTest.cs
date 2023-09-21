namespace Tests;


public class ProductExceptSelfTest
{
    [Fact] 
    public void CalculateProductExceptSelf_ReturnsExpectedResult()
    {
        // Arrange 
        ProductExceptSelf calculator = new ProductExceptSelf(); 
        int[] inputNumbers = { 1, 2, 3, 4 }; 

        // Act
        int[] result = calculator.CalculateProductExceptSelf(inputNumbers); 

        //Assert
        Assert.Equal(inputNumbers.Length, result.Length);
        Assert.Equal(new int[] { 24, 12, 8, 6 }, result);
    }
}



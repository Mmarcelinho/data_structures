namespace Tests;

public class BestTimeToBuyAndSellStockTest
{
    [Fact]
    public void StockAnalyzer_ShouldReturnMaximumProfit()
    {

        //Arrange
        var StockAnalyzer = new StockAnalyzer();
        int[] prices = { 7, 1, 5, 3, 6, 4 };

        //Act
        var result = StockAnalyzer.FindMaxProfit(prices);

        //Assert
        Assert.Equal(5, result);
    }

    [Fact]
    public void StockAnalyzer_ShouldReturnMaximumProfitZeroWhenNoTransactionIsMade()
    {

        //Arrange
        var StockAnalyzer = new StockAnalyzer();
        int[] prices = { 7, 6, 4, 3, 1 };

        //Act
        var result = StockAnalyzer.FindMaxProfit(prices);

        //Assert
        Assert.Equal(0, result);
    }
}

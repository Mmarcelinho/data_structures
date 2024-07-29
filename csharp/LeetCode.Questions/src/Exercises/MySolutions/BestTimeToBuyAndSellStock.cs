namespace Exercises.MySolutions;

    public class BestTimeToBuyAndSellStock
    {
        // static void Main()
        // {
        //     int[] prices = { 7,6,4,3,1 };
        //     var BestTimeToBuyAndSellStock = new BestTimeToBuyAndSellStock();
        //     BestTimeToBuyAndSellStock.FindMaxProfit(prices);
        // }
         public int FindMaxProfit(int[] prices)
        {
            var Max = 0;
            var Min = prices[0];

            for(var i = 1; i < prices.Length; i++)
            {

                if(Min > prices[i])
                Min = prices[i];

                var current = prices[i] - Min;

                if(current > Max)
                Max = current;
            }
            return Max;
        }       
    }

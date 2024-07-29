namespace Exercises.Solutions;
    public class BestTimeToBuyAndSellStock
    {
        public int FindMaxProfit(int[] prices)
        {
            // Inicializamos a variável de lucro máximo como 0 e a variável de preço mínimo com o primeiro elemento do array.
            int maxProfit = 0;
            int minPrice = prices[0];

            // Percorremos os preços das ações a partir do segundo elemento.
            for (int i = 1; i < prices.Length; i++)
            {
                // Capturamos o preço atual.
                int currentPrice = prices[i];

                // Atualizamos o preço mínimo, se o preço atual for menor.
                minPrice = Math.Min(minPrice, currentPrice);

                // Calculamos o lucro máximo ao subtrair o preço atual pelo preço mínimo anterior.
                maxProfit = Math.Max(maxProfit, currentPrice - minPrice);
            }

            // Retornamos o lucro máximo obtido.
            return maxProfit;
        }
    }


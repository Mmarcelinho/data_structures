package code

// FindMaxProfit calcula o lucro máximo possível comprando e vendendo uma ação uma única vez.
// Recebe uma lista de preços das ações em dias consecutivos e retorna o lucro máximo.
func FindMaxProfit(prices []int) int {
	// Inicializamos a variável maxProfit como 0 para representar o lucro máximo.
	maxProfit := 0
	// Inicializamos a variável minPrice com o primeiro preço, pois será o menor preço encontrado até o momento.
	minPrice := prices[0]

	// Percorremos os preços das ações a partir do segundo elemento.
	for i := 1; i < len(prices); i++ {
		currentPrice := prices[i] // Capturamos o preço atual.

		// Se o preço atual for menor que o menor preço até o momento, atualizamos minPrice.
		if currentPrice < minPrice {
			minPrice = currentPrice
		}

		// Calculamos o lucro potencial atual (preço atual - menor preço até o momento).
		// Se for maior que o maxProfit registrado, atualizamos maxProfit.
		if currentPrice-minPrice > maxProfit {
			maxProfit = currentPrice - minPrice
		}
	}

	// Retornamos o lucro máximo calculado.
	return maxProfit
}

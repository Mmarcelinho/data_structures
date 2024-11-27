package code

// MaxArea calcula a área máxima de água que pode ser contida entre dois índices de alturas.
func MaxArea(height []int) int {
	// Inicializando a área máxima como zero.
	maxArea := 0

	// Inicializando os ponteiros 'left' e 'right'.
	left := 0
	right := len(height) - 1

	// Enquanto o ponteiro 'left' for menor que o ponteiro 'right', continue o loop.
	for left < right {
		// Calculando a altura mínima entre as alturas em 'left' e 'right'.
		minHeight := height[left]
		if height[right] < height[left] {
			minHeight = height[right]
		}

		// Calculando a área atual usando a altura mínima e a distância entre os ponteiros.
		currentArea := minHeight * (right - left)

		// Atualizando a 'maxArea' com o valor máximo entre a 'maxArea' atual e a 'currentArea'.
		if currentArea > maxArea {
			maxArea = currentArea
		}

		// Avançando o ponteiro 'left' se a altura em 'left' for menor que a altura em 'right'.
		if height[left] < height[right] {
			left++
		} else {
			// Movendo o ponteiro 'right' para a esquerda se a altura em 'right' for menor ou igual à altura em 'left'.
			right--
		}
	}

	// Retornando a área máxima encontrada.
	return maxArea
}

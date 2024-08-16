package binarysearch

// BS realiza uma busca binária em uma slice de inteiros ordenada.
// Se o elemento for encontrado, retorna o índice onde ele está localizado.
// Caso contrário, retorna -1.
func BS(nums []int, key int) int {

	// Inicializa os limites inferior e superior da busca
	low := 0
	high := len(nums) - 1

	// Continua a busca enquanto a parte considerada do array não for exaurida
	for low <= high {
		// Calcula o índice do ponto médio da parte atualmente considerada
		mid := (high + low) / 2

		// Verifica se o elemento no ponto médio é o que estamos procurando
		if nums[mid] == key {
			return mid // Elemento encontrado, retorna o índice
		}

		// Se o elemento procurado for menor que o elemento no ponto médio,
		// ajusta o limite superior para focar na metade inferior da parte considerada
		if key < nums[mid] {
			high = mid - 1
		} else {
			// Se o elemento procurado for maior que o elemento no ponto médio,
			// ajusta o limite inferior para focar na metade superior da parte considerada
			low = mid + 1
		}
	}

	// Se sair do loop, o elemento não foi encontrado na slice, retorna -1
	return -1
}

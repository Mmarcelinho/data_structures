package code

// Search realiza uma busca binária modificada em um array rotacionado
// Retorna o índice do target se encontrado, ou -1 se o target não estiver presente
func Search(nums []int, target int) int {

	low := 0                 // Inicializa o limite inferior
	high := len(nums) - 1    // Inicializa o limite superior

	// Continua enquanto a faixa de busca for válida
	for low <= high {
		// Calcula o índice do meio
		mid := (low + high) / 2

		// Verifica se o elemento do meio é o alvo
		if nums[mid] == target {
			return mid // Retorna o índice se encontrado
		}

		// Verifica se a metade esquerda do array está ordenada
		if nums[low] <= nums[mid] {
			// Verifica se o alvo está dentro da metade esquerda ordenada
			if target > nums[mid] || target < nums[low] {
				// Move o limite inferior para a direita do meio
				low = mid + 1
			} else {
				// Ajusta o limite superior para procurar na metade esquerda
				high = mid - 1
			}
		} else {
			// A metade direita do array está ordenada
			if target < nums[mid] || target > nums[high] {
				// Ajusta o limite superior para procurar na metade esquerda
				high = mid - 1
			} else {
				// Move o limite inferior para a direita para procurar na metade direita
				low = mid + 1
			}
		}
	}

	// Se o alvo não foi encontrado, retorna -1
	return -1
}

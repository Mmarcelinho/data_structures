package mathematics

import "fmt"

// PrintArray imprime os elementos de um array de inteiros
func PrintArray(array []int) {
	// Obtém o tamanho do array
	n := len(array)

	// Loop para percorrer cada elemento do array
	for i := 0; i < n; i++ {
		// Imprime o elemento atual do array
		fmt.Printf("%d ", array[i])
	}
	fmt.Println()
}

// RemoveEven remove os números pares de um array de inteiros e retorna um novo array com apenas números ímpares
func RemoveEven(array []int) []int {
	// Contador para os números ímpares
	oddCount := 0

	// Loop para percorrer cada elemento do array
	for i := 0; i < len(array); i++ {
		// Se o elemento atual é ímpar, incrementa o contador
		if array[i]%2 != 0 {
			oddCount++
		}
	}

	// Cria um novo slice para armazenar os números ímpares
	result := make([]int, oddCount)

	// Índice para o novo slice
	idx := 0

	// Loop para percorrer cada elemento do array original
	for i := 0; i < len(array); i++ {
		// Se o elemento atual é ímpar, adiciona ao novo slice
		if array[i]%2 != 0 {
			result[idx] = array[i]
			idx++
		}
	}

	// Retorna o novo slice com apenas números ímpares
	return result
}

package search

import "errors"

// Search é uma função que procura por um elemento 'x' em um array 'arr'.
// Retorna o índice do elemento se encontrado, ou um erro se o array estiver vazio ou o elemento não for encontrado.
func Search(arr []int, x int) (int, error) {

	// Verifica se o array está vazio. Se estiver, retorna um erro.
	if len(arr) == 0 {
		return -1, errors.New("array is null")
	}

	// Itera sobre o array para procurar o elemento 'x'.
	for i := 0; i < len(arr); i++ {
		if arr[i] == x {
			return i, nil // Retorna o índice do elemento encontrado.
		}
	}

	// Se o elemento não for encontrado, retorna -1 e um erro informando que o elemento não foi encontrado.
	return -1, errors.New("element not found")
}

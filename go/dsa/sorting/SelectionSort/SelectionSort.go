package selectionsort

import "fmt"

// PrintArray imprime os elementos do array em uma única linha.
func PrintArray(arr []int) {
	for _, v := range arr { // Itera sobre cada elemento do array
		fmt.Printf("%d ", v) // Imprime o valor atual com um espaço
	}
	fmt.Println() // Quebra de linha após imprimir todos os elementos
}

// Sort realiza o algoritmo de ordenação Selection Sort em um array.
func Sort(arr []int) {
	n := len(arr) // Obtém o tamanho do array

	// Laço externo que percorre o array até o penúltimo elemento
	for i := 0; i < n-1; i++ {

		min := i // Assume que o índice atual é o menor

		// Laço interno que percorre os elementos restantes
		for j := i + 1; j < n; j++ {

			// Se encontrar um valor menor que o valor atual mínimo,
			// atualiza o índice do menor valor.
			if arr[j] < arr[min] {
				min = j
			}
		}

		// Troca o menor valor encontrado com o valor da posição inicial do laço externo
		temp := arr[min]  // Armazena o menor valor temporariamente
		arr[min] = arr[i] // Move o valor da posição inicial para a posição do menor valor
		arr[i] = temp     // Coloca o menor valor na posição inicial
	}
}

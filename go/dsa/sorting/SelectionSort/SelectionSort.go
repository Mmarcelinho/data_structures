package selectionsort

import "fmt"

// PrintArray exibe os elementos do array na tela.
// Utiliza um loop para iterar sobre cada elemento e imprimi-lo.
// Complexidade de tempo: O(n), onde n é o número de elementos no array.
func PrintArray(arr []int) {
	for _, v := range arr {
		fmt.Printf("%d ", v)
	}
	fmt.Println()
}

// Sort implementa o algoritmo de ordenação por seleção (Selection Sort).
// O Selection Sort percorre o array várias vezes, selecionando o menor elemento
// e trocando-o com o elemento no início da parte não ordenada do array.
// Complexidade de tempo: O(n^2), onde n é o número de elementos no array.
// Isso ocorre porque o algoritmo tem dois loops aninhados: o primeiro percorre 
// todos os elementos (O(n)) e o segundo percorre os elementos restantes para 
// encontrar o menor (também O(n)).
func Sort(arr []int) {
	n := len(arr) // Armazena o comprimento do array

	// Loop principal para mover a fronteira do subarray não ordenado
	for i := 0; i < n-1; i++ {
		// Assume que o primeiro elemento não ordenado é o menor
		min := i

		// Loop para encontrar o menor elemento na parte não ordenada
		for j := i + 1; j < n; j++ {
			// Se encontrar um elemento menor, atualiza o índice do menor elemento
			if arr[j] < arr[min] {
				min = j
			}
		}

		// Troca o menor elemento encontrado com o primeiro elemento não ordenado
		temp := arr[min]
		arr[min] = arr[i]
		arr[i] = temp
	}
}

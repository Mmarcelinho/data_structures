package bubblesort

import "fmt"

// PrintArray imprime os elementos do array em uma linha
func PrintArray(arr []int) {
	n := len(arr)

	// Itera pelo array e imprime cada elemento
	for i := 0; i < n; i++ {
		fmt.Printf("%v ", arr[i]) // Imprime o valor do elemento seguido de um espaço
	}
	fmt.Println() // Move o cursor para uma nova linha após a impressão do array
}

// Sort ordena o array utilizando o algoritmo Bubble Sort
func Sort(arr []int) {
	n := len(arr)

	// Variável para verificar se houve uma troca na iteração atual
	var isSwapped bool

	// Itera sobre cada elemento do array, exceto o último
	for i := 0; i < n-1; i++ {
		isSwapped = false

		// Compara e troca os elementos adjacentes se estiverem fora de ordem
		for j := 0; j < n-1-i; j++ {
			// Se o elemento atual for maior que o próximo, realiza a troca
			if arr[j] > arr[j+1] {
				// Armazena o valor do elemento atual em uma variável temporária
				temp := arr[j]
				// Substitui o elemento atual pelo próximo elemento
				arr[j] = arr[j+1]
				// Coloca o valor armazenado na posição do próximo elemento
				arr[j+1] = temp

				// Marca que houve uma troca nesta iteração
				isSwapped = true
			}
		}

		// Se não houve troca, o array já está ordenado e o loop pode ser interrompido
		if !isSwapped {
			break
		}
	}
}

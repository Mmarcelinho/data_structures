package insertionsort

import "fmt"

// PrintArray imprime os elementos do array na saída padrão.
// Recebe um array de inteiros como argumento e o percorre
// para imprimir cada elemento seguido por um espaço.
func PrintArray(arr []int) {
	// Obtém o tamanho do array
	n := len(arr)

	// Itera por cada elemento do array e o imprime
	for i := 0; i < n; i++ {
		fmt.Printf("%v ", arr[i])
	}
	// Imprime uma nova linha para separar as saídas
	println()
}

// Sort implementa o algoritmo de Insertion Sort para ordenar
// um array de inteiros. Ele organiza os elementos do array
// de forma crescente.
func Sort(arr []int) {
	// Obtém o tamanho do array
	n := len(arr)

	// Começa a iteração a partir do segundo elemento
	// (índice 1), pois o primeiro elemento já é considerado ordenado
	for i := 1; i < n; i++ {
		// Armazena o valor do elemento atual
		temp := arr[i]
		// Define j como o índice do elemento anterior
		j := i - 1

		// Move os elementos do array que são maiores que temp
		// uma posição à frente de sua posição atual
		for j >= 0 && arr[j] > temp {
			// Desloca o elemento maior para a posição seguinte
			arr[j+1] = arr[j]
			// Move o índice j uma posição para trás
			j = j - 1
		}
		// Insere temp (o valor original de arr[i]) na posição correta
		arr[j+1] = temp
	}
}

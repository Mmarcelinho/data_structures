package movezeros

import "fmt"

// moveZeros move todos os zeros no array para o final, mantendo a ordem relativa dos elementos não-zero.
func moveZeros(array []int) {
	j := 0 // Inicializa o ponteiro 'j' para rastrear a posição do próximo elemento não-zero
	for i := 0; i < len(array); i++ { // Percorre o array
		if array[i] != 0 { // Se o elemento atual não for zero
			if i != j { // Se o índice atual 'i' não for igual ao índice 'j'
				array[i], array[j] = array[j], array[i] // Troca os elementos nas posições 'i' e 'j'
			}
			j++ // Incrementa o ponteiro 'j' para apontar para o próximo elemento potencialmente zero
		}
	}
}

// printArray imprime todos os elementos de um array, separados por um espaço.
func printArray(array []int) {
	for _, v := range array { // Percorre cada elemento do array
		fmt.Printf("%d ", v) // Imprime o elemento seguido de um espaço
	}
	fmt.Println() // Finaliza com uma nova linha
}

// arrayDemo demonstra a funcionalidade de moveZeros e printArray.
func arrayDemo() {
	array := []int{8, 1, 0, 2, 1, 0, 3} // Inicializa um array com elementos incluindo zeros
	printArray(array) // Imprime o array original
	moveZeros(array) // Move todos os zeros para o final do array
	printArray(array) // Imprime o array após mover os zeros
}


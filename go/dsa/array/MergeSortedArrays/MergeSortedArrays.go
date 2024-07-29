package mergesortedarrays

import (
	"fmt"
)

// printArray imprime todos os elementos de um array, separados por um espaço.
func printArray(array []int) {
	for _, v := range array { // Percorre cada elemento do array
		fmt.Printf("%d ", v) // Imprime o elemento seguido de um espaço
	}
	fmt.Println() // Finaliza com uma nova linha
}

// merge mescla dois arrays ordenados em um novo array ordenado.
func merge(array1, array2 []int) []int {
	n := len(array1) // Obtém o tamanho do primeiro array
	m := len(array2) // Obtém o tamanho do segundo array
	resultado := make([]int, n+m) // Cria um novo array para armazenar o resultado da mesclagem

	i, j, k := 0, 0, 0 // Inicializa os índices para percorrer array1, array2 e resultado, respectivamente

	// Mescla elementos dos dois arrays enquanto ambos possuem elementos não processados
	for i < n && j < m {
		if array1[i] < array2[j] { // Se o elemento atual de array1 for menor que o de array2
			resultado[k] = array1[i] // Adiciona o elemento de array1 ao resultado
			i++ // Move o índice de array1 para o próximo elemento
		} else {
			resultado[k] = array2[j] // Caso contrário, adiciona o elemento de array2 ao resultado
			j++ // Move o índice de array2 para o próximo elemento
		}
		k++ // Move o índice do resultado para o próximo elemento
	}

	// Se ainda restam elementos em array1, adiciona todos ao resultado
	for i < n {
		resultado[k] = array1[i]
		i++
		k++
	}

	// Se ainda restam elementos em array2, adiciona todos ao resultado
	for j < m {
		resultado[k] = array2[j]
		j++
		k++
	}

	return resultado // Retorna o array resultado, que é a mescla ordenada de array1 e array2
}

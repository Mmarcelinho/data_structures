package mergesort

import (
	"fmt"
)

func PrintArray(arr []int) {
	for _, v := range arr {
		fmt.Printf("%d ", v)
	}
	fmt.Println()
}

// Função para ordenar um array usando Merge Sort
func Sort(arr, tempArr []int, left, right int) {
	if left < right {
		mid := (left + right) / 2 // Calcula o índice do meio

		// Ordena a primeira metade do array
		Sort(arr, tempArr, left, mid)

		// Ordena a segunda metade do array
		Sort(arr, tempArr, mid+1, right)

		// Combina as duas metades em um array ordenado
		merge(arr, tempArr, left, mid, right)
	}
}

// Função para combinar duas metades de um array em um array ordenado
func merge(arr, tempArr []int, left, mid, right int) {
	// Copia os elementos do array original para o array temporário
	for i := left; i <= right; i++ {
		tempArr[i] = arr[i]
	}

	i := left
	j := mid + 1
	k := left

	// Enquanto houver elementos nas duas metades
	for i <= mid && j <= right {
		// Se o elemento da primeira metade for menor ou igual ao da segunda metade
		if tempArr[i] <= tempArr[j] {
			// Copia o elemento da primeira metade para o array original
			arr[k] = tempArr[i]
			i++
		} else {
			// Caso contrário, copia o elemento da segunda metade para o array original
			arr[k] = tempArr[j]
			j++
		}
		k++
	}

	// Copia os elementos restantes da primeira metade, se houver
	for i <= mid {
		arr[k] = tempArr[i]
		k++
		i++
	}
}

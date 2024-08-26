package sort012

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

// ThreeNumberSort implementa o algoritmo de ordenação de um array contendo
// apenas os números 0, 1 e 2. A ideia é usar três ponteiros para segregar
// os valores 0, 1 e 2 no array.
// Complexidade de tempo: O(n), onde n é o número de elementos no array.
// Complexidade de espaço: O(1), pois o algoritmo usa um espaço constante adicional.
func ThreeNumberSort(arr []int) {
	i := 0            // Ponteiro para a próxima posição de 0
	j := 0            // Ponteiro para o próximo 1
	k := len(arr) - 1 // Ponteiro para o próximo 2

	// Loop até que o ponteiro 'i' ultrapasse 'k'
	for i <= k {
		if arr[i] == 0 {
			// Se o elemento for 0, troque-o com o elemento na posição 'j'
			swap(arr, i, j)
			i++
			j++
		} else if arr[i] == 1 {
			// Se o elemento for 1, apenas avance o ponteiro 'i'
			i++
		} else if arr[i] == 2 {
			// Se o elemento for 2, troque-o com o elemento na posição 'k'
			swap(arr, i, k)
			k--
		}
	}
}

// swap realiza a troca de elementos em duas posições especificadas no array.
// Complexidade de tempo: O(1), pois a troca é uma operação constante.
func swap(arr []int, first int, second int) {
	temp := arr[first]
	arr[first] = arr[second]
	arr[second] = temp
}

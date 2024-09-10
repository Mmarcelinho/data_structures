package sort012

import "fmt"

// PrintArray imprime os elementos do array em uma única linha.
func PrintArray(arr []int) {
	for _, v := range arr { // Itera sobre cada elemento do array
		fmt.Printf("%d ", v) // Imprime o valor atual com um espaço
	}
	fmt.Println() // Quebra de linha após imprimir todos os elementos
}

// ThreeNumberSort realiza a ordenação de um array contendo apenas os números 0, 1 e 2.
// O algoritmo é conhecido como "Dutch National Flag Problem".
func ThreeNumberSort(arr []int) {
	i := 0            // Ponteiro que indica a posição atual no array
	j := 0            // Ponteiro que indica a posição do próximo 0 a ser trocado
	k := len(arr) - 1 // Ponteiro que indica a posição do próximo 2 a ser trocado

	// O loop continua enquanto o ponteiro i estiver antes ou na mesma posição que k
	for i <= k {
		// Se o valor na posição i for 0
		if arr[i] == 0 {
			// Troca o valor atual com a posição do próximo 0 (indicado por j)
			swap(arr, i, j)
			i++ // Avança o ponteiro i para o próximo elemento
			j++ // Avança o ponteiro j para a próxima posição onde o próximo 0 deve estar
		} else if arr[i] == 1 {
			// Se o valor na posição i for 1, apenas avança o ponteiro i
			i++
		} else if arr[i] == 2 {
			// Se o valor na posição i for 2
			// Troca o valor atual com a posição do próximo 2 (indicado por k)
			swap(arr, i, k)
			k-- // Diminui o ponteiro k para que o próximo 2 seja colocado corretamente
		}
	}
}

// swap troca os valores de dois elementos no array
func swap(arr []int, first int, second int) {
	temp := arr[first]    // Armazena temporariamente o valor da posição first
	arr[first] = arr[second] // Move o valor da posição second para first
	arr[second] = temp    // Coloca o valor armazenado temporariamente na posição second
}

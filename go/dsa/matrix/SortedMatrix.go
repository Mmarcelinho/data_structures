package matrix

import "fmt"

// Search busca por um valor x em uma matriz ordenada.
// A busca começa no canto superior direito da matriz e segue
// para a esquerda ou para baixo, dependendo da comparação com x.
func Search(matrix [][]int, n int, x int) {
	// Inicializa as variáveis i e j. i começa na primeira linha (0),
	// e j começa na última coluna (n - 1).
	i := 0
	j := n - 1

	// Continua a busca enquanto i estiver dentro dos limites da matriz
	// e j não ultrapassar o limite esquerdo.
	for i < n && j >= 0 {
		// Se o elemento atual é igual a x, imprime a posição e sai da função.
		if matrix[i][j] == x {
			fmt.Printf("x found at - %v,%v\n", i, j)
			return
		}

		// Se o elemento atual é maior que x, move para a esquerda.
		if matrix[i][j] > x {
			j--
		} else {
			// Se o elemento atual é menor que x, move para baixo.
			i++
		}
	}
	// Se o loop terminar sem encontrar x, imprime que o valor não foi encontrado.
	fmt.Println("Value not found!")
}

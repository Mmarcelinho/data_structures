package matrix

import "fmt"

// SpiralPrint imprime a matriz dada em ordem espiral
// matrix: matriz 2D de inteiros
// r: número de linhas na matriz
// c: número de colunas na matriz
func SpiralPrint(matrix [][]int, r int, c int) {

	// Variáveis auxiliares para controlar os limites da matriz
	i := 0  // índice para iteração
	k := 0  // início da linha
	l := 0  // início da coluna

	// Enquanto ainda houver elementos para processar nas submatrizes
	for k < r && l < c {

		// Imprime a primeira linha da submatriz restante
		for i = l; i < c; i++ {
			fmt.Printf("%v"+" ", matrix[k][i])
		}
		k++  // Move o limite superior para a próxima linha

		// Imprime a última coluna da submatriz restante
		for i = k; i < r; i++ {
			fmt.Printf("%v"+" ", matrix[i][c-1])
		}
		c--  // Move o limite direito para a esquerda

		// Verifica se ainda há linhas restantes após o movimento superior
		if k < r {
			// Imprime a última linha da submatriz restante, da direita para a esquerda
			for i := c - 1; i >= l; i-- {
				fmt.Printf("%v"+" ", matrix[r-1][i])
			}
			r--  // Move o limite inferior para cima
		}

		// Verifica se ainda há colunas restantes após o movimento direito
		if l < c {
			// Imprime a primeira coluna da submatriz restante, de baixo para cima
			for i := r - 1; i >= k; i-- {
				fmt.Printf("%v"+" ", matrix[i][l])
			}
			l++  // Move o limite esquerdo para a direita
		}
	}
}

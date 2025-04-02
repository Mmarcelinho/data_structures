package code

// TreeNode representa um nó da árvore binária
/*
type TreeNode struct {
	Val   int
	Left  *TreeNode
	Right *TreeNode
}
*/

// levelOrder realiza a travessia por nível (level-order / BFS) de uma árvore binária.
// Retorna uma matriz de inteiros, onde cada linha representa os valores de um nível da árvore.
func LevelOrder(root *TreeNode) [][]int {
	var res [][]int // Resultado final: uma matriz de níveis

	// Se a árvore estiver vazia, retorna uma matriz vazia
	if root == nil {
		return res
	}

	// Fila para armazenar os nós a serem processados
	queue := []*TreeNode{root}

	// Enquanto houver nós na fila
	for len(queue) > 0 {
		levelSize := len(queue) // Número de nós no nível atual
		var level []int         // Lista para armazenar os valores deste nível

		// Processa todos os nós do nível atual
		for i := 0; i < levelSize; i++ {
			node := queue[0]       // Pega o primeiro nó da fila
			queue = queue[1:]      // Remove o nó da fila

			level = append(level, node.Val) // Adiciona o valor do nó atual ao nível

			// Adiciona os filhos do nó atual à fila (para o próximo nível)
			if node.Left != nil {
				queue = append(queue, node.Left)
			}
			if node.Right != nil {
				queue = append(queue, node.Right)
			}
		}

		// Adiciona o nível completo à resposta final
		res = append(res, level)
	}

	// Retorna todos os níveis da árvore
	return res
}

package code

func SumNumbers(root *TreeNode) int {
	return dfs(root, 0)
}

func dfs(node *TreeNode, currentSum int) int {
	if node == nil {
		return 0
	}

	// Soma atual = valor acumulado até agora * 10 + valor do nó atual
	currentSum = currentSum*10 + node.Val

	// Se for folha, retorna o número completo
	if node.Left == nil && node.Right == nil {
		return currentSum
	}

	// Soma os valores dos dois lados (esquerda e direita)
	return dfs(node.Left, currentSum) + dfs(node.Right, currentSum)
}

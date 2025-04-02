package code

// TreeNode representa um nó da árvore binária
type TreeNode struct {
	Val   int
	Left  *TreeNode
	Right *TreeNode
}

// InvertTree inverte os filhos de todos os nós da árvore
func InvertTree(root *TreeNode) *TreeNode {
	if root != nil {
		// Troca os filhos esquerdo e direito
		root.Left, root.Right = root.Right, root.Left

		// Chama recursivamente para os filhos
		InvertTree(root.Left)
		InvertTree(root.Right)
	}

	return root
}

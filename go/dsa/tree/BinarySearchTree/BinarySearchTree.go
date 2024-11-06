package binarysearchtree

import "fmt"

// BinarySearchTree é a estrutura principal da árvore binária de busca
type BinarySearchTree struct {
	root *TreeNode // A raiz da árvore
}

// TreeNode representa um nó da árvore
type TreeNode struct {
	data  int       // O valor do nó
	left  *TreeNode // O nó filho à esquerda
	right *TreeNode // O nó filho à direita
}

// NewBinarySearchTree cria e retorna uma nova instância de BinarySearchTree
func NewBinarySearchTree() *BinarySearchTree {
	return &BinarySearchTree{}
}

// Insert insere um valor na árvore
func (bst *BinarySearchTree) Insert(value int) {
	bst.root = bst.insertNode(bst.root, value)
}

// insertNode é um método recursivo para inserir um valor na árvore
func (bst *BinarySearchTree) insertNode(root *TreeNode, value int) *TreeNode {
	// Se a árvore estiver vazia, cria um novo nó
	if root == nil {
		return &TreeNode{data: value}
	}
	// Se o valor for menor que o valor do nó atual, insere à esquerda
	if value < root.data {
		root.left = bst.insertNode(root.left, value)
	} else { // Se o valor for maior que o valor do nó atual, insere à direita
		root.right = bst.insertNode(root.right, value)
	}
	return root
}

// InOrder imprime os valores da árvore em ordem
func (bst *BinarySearchTree) InOrder() {
	bst.inOrderTraversal(bst.root)
	fmt.Println()
}

// inOrderTraversal é um método recursivo para imprimir os valores da árvore em ordem
func (bst *BinarySearchTree) inOrderTraversal(root *TreeNode) {
	if root == nil {
		return
	}
	// Primeiro imprime o valor do nó à esquerda
	bst.inOrderTraversal(root.left)
	// Depois imprime o valor do nó atual
	fmt.Print(root.data, " ")
	// Por fim, imprime o valor do nó à direita
	bst.inOrderTraversal(root.right)
}

// Search procura um valor na árvore
func (bst *BinarySearchTree) Search(key int) *TreeNode {
	return bst.searchNode(bst.root, key)
}

// searchNode é um método recursivo para procurar um valor na árvore
func (bst *BinarySearchTree) searchNode(root *TreeNode, key int) *TreeNode {
	// Se a árvore estiver vazia ou se o valor do nó atual for o valor procurado, retorna o nó
	if root == nil || root.data == key {
		return root
	}
	// Se o valor procurado for menor que o valor do nó atual, procura à esquerda
	if key < root.data {
		return bst.searchNode(root.left, key)
	}
	// Se o valor procurado for maior que o valor do nó atual, procura à direita
	return bst.searchNode(root.right, key)
}
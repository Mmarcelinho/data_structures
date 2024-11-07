package binarytree

import (
    "container/list"
    "fmt"
    "math"
)

// BinaryTree é a estrutura principal da árvore binária
type BinaryTree struct {
    Root *TreeNode // Nó raiz da árvore
}

// NewBinaryTree cria e retorna uma nova instância de BinaryTree
func NewBinaryTree() *BinaryTree {
    return &BinaryTree{}
}

// TreeNode representa um nó da árvore
type TreeNode struct {
    Data  int       // Dado armazenado no nó
    Left  *TreeNode // Nó filho à esquerda
    Right *TreeNode // Nó filho à direita
}

// CreateBinaryTree cria uma árvore binária com valores fixos
func (bt *BinaryTree) CreateBinaryTree() {
    first := &TreeNode{Data: 1}
    second := &TreeNode{Data: 2}
    third := &TreeNode{Data: 3}
    fourth := &TreeNode{Data: 4}
    fifth := &TreeNode{Data: 5}
    sixth := &TreeNode{Data: 6}
    seventh := &TreeNode{Data: 7}

    bt.Root = first
    first.Left = second
    first.Right = third
    second.Left = fourth
    second.Right = fifth
    third.Left = sixth
    third.Right = seventh
}

// PreOrder realiza a travessia pré-ordem de forma recursiva
func (bt *BinaryTree) PreOrder(root *TreeNode) {
    if root == nil {
        return
    }
    fmt.Print(root.Data, " ")
    bt.PreOrder(root.Left)
    bt.PreOrder(root.Right)
}

// PreOrderIterative realiza a travessia pré-ordem de forma iterativa
func (bt *BinaryTree) PreOrderIterative() {
    if bt.Root == nil {
        return
    }

    stack := list.New()
    stack.PushBack(bt.Root)

    for stack.Len() > 0 {
        node := stack.Remove(stack.Back()).(*TreeNode)
        fmt.Print(node.Data, " ")
        if node.Right != nil {
            stack.PushBack(node.Right)
        }
        if node.Left != nil {
            stack.PushBack(node.Left)
        }
    }
}

// InOrder realiza a travessia in-ordem de forma recursiva
func (bt *BinaryTree) InOrder(root *TreeNode) {
    if root == nil {
        return
    }
    bt.InOrder(root.Left)
    fmt.Print(root.Data, " ")
    bt.InOrder(root.Right)
}

// InOrderIterative realiza a travessia in-ordem de forma iterativa
func (bt *BinaryTree) InOrderIterative() {
    stack := list.New()
    current := bt.Root

    for current != nil || stack.Len() > 0 {
        for current != nil {
            stack.PushBack(current)
            current = current.Left
        }
        current = stack.Remove(stack.Back()).(*TreeNode)
        fmt.Print(current.Data, " ")
        current = current.Right
    }
}

// PostOrder realiza a travessia pós-ordem de forma recursiva
func (bt *BinaryTree) PostOrder(root *TreeNode) {
    if root == nil {
        return
    }
    bt.PostOrder(root.Left)
    bt.PostOrder(root.Right)
    fmt.Print(root.Data, " ")
}

// PostOrderIterative realiza a travessia pós-ordem de forma iterativa
func (bt *BinaryTree) PostOrderIterative() {
    stack := list.New()
    current := bt.Root
    var lastVisited *TreeNode

    for current != nil || stack.Len() > 0 {
        if current != nil {
            stack.PushBack(current)
            current = current.Left
        } else {
            peekNode := stack.Back().Value.(*TreeNode)
            if peekNode.Right != nil && lastVisited != peekNode.Right {
                current = peekNode.Right
            } else {
                fmt.Print(peekNode.Data, " ")
                lastVisited = stack.Remove(stack.Back()).(*TreeNode)
            }
        }
    }
}

// LevelOrder realiza a travessia por nível (BFS)
func (bt *BinaryTree) LevelOrder() {
    if bt.Root == nil {
        return
    }

    queue := list.New()
    queue.PushBack(bt.Root)

    for queue.Len() > 0 {
        node := queue.Remove(queue.Front()).(*TreeNode)
        fmt.Print(node.Data, " ")
        if node.Left != nil {
            queue.PushBack(node.Left)
        }
        if node.Right != nil {
            queue.PushBack(node.Right)
        }
    }
}

// FindMax encontra o valor máximo na árvore
func (bt *BinaryTree) FindMax(root *TreeNode) int {
    if root == nil {
        return math.MinInt
    }

    result := root.Data
    left := bt.FindMax(root.Left)
    right := bt.FindMax(root.Right)

    if left > result {
        result = left
    }
    if right > result {
        result = right
    }
    return result
}

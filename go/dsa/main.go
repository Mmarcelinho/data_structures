package main

import (
    b "dsa/tree/BinaryTree"
    "fmt"
)

func main() {
    bt := b.NewBinaryTree()
    bt.CreateBinaryTree()

    fmt.Println("Pré-ordem (recursivo):")
    bt.PreOrder(bt.Root)
    fmt.Println("\nPré-ordem (iterativo):")
    bt.PreOrderIterative()

    fmt.Println("\n\nIn-ordem (recursivo):")
    bt.InOrder(bt.Root)
    fmt.Println("\nIn-ordem (iterativo):")
    bt.InOrderIterative()

    fmt.Println("\n\nPós-ordem (recursivo):")
    bt.PostOrder(bt.Root)
    fmt.Println("\nPós-ordem (iterativo):")
    bt.PostOrderIterative()

    fmt.Println("\n\nOrdem por nível:")
    bt.LevelOrder()

    fmt.Println("\n\nValor máximo na árvore:")
    fmt.Println(bt.FindMax(bt.Root))
}

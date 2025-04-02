package main

import (
    t "exercises/code"
    "fmt"
)

// imprimirArvore imprime a árvore de forma visual
func imprimirArvore(root *t.TreeNode, prefixo string, isEsquerda bool) {
    if root == nil {
        return
    }

    // Imprime o valor do nó atual com formatação visual
    if isEsquerda {
        fmt.Printf("%s├── %d\n", prefixo, root.Val)
        prefixo += "│   "
    } else {
        fmt.Printf("%s└── %d\n", prefixo, root.Val)
        prefixo += "    "
    }

    // Recursivamente imprime os filhos
    if root.Left != nil {
        imprimirArvore(root.Left, prefixo, root.Right != nil)
    }
    if root.Right != nil {
        imprimirArvore(root.Right, prefixo, false)
    }
}

// criarArvoreTeste cria uma árvore binária de exemplo
func criarArvoreTeste() *t.TreeNode {
    // Estrutura da árvore:
    //       4
    //      / \
    //     2   7
    //    / \ / \
    //   1  3 6  9

    root := &t.TreeNode{Val: 4}
    root.Left = &t.TreeNode{Val: 2}
    root.Right = &t.TreeNode{Val: 7}
    root.Left.Left = &t.TreeNode{Val: 1}
    root.Left.Right = &t.TreeNode{Val: 3}
    root.Right.Left = &t.TreeNode{Val: 6}
    root.Right.Right = &t.TreeNode{Val: 9}

    return root
}

func main() {
    // Cria a árvore de teste
    arvore := criarArvoreTeste()

    fmt.Println("Árvore original (visualização em árvore):")
    imprimirArvore(arvore, "", false)

    // Demonstração do SumRootToLeafNumbers
    fmt.Println("\nCaminhos da raiz até as folhas:")
    fmt.Println("4 -> 2 -> 1 = 421")
    fmt.Println("4 -> 2 -> 3 = 423")
    fmt.Println("4 -> 7 -> 6 = 476")
    fmt.Println("4 -> 7 -> 9 = 479")
    
    soma := t.SumNumbers(arvore)
    fmt.Printf("\nSoma de todos os números formados pelos caminhos: %d\n", soma)
    fmt.Println("(421 + 423 + 476 + 479 = 1799)")
    
    // Criando uma segunda árvore para demonstração
    fmt.Println("\n\nOutro exemplo:")
    //      1
    //     / \
    //    2   3
    outraArvore := &t.TreeNode{
        Val: 1,
        Left: &t.TreeNode{Val: 2},
        Right: &t.TreeNode{Val: 3},
    }
    
    fmt.Println("Segunda árvore (visualização):")
    imprimirArvore(outraArvore, "", false)
    
    fmt.Println("\nCaminhos da raiz até as folhas:")
    fmt.Println("1 -> 2 = 12")
    fmt.Println("1 -> 3 = 13")
    
    outroResultado := t.SumNumbers(outraArvore)
    fmt.Printf("\nSoma de todos os números formados pelos caminhos: %d\n", outroResultado)
    fmt.Println("(12 + 13 = 25)")
}
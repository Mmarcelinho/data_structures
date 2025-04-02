package main

import (
    "fmt"
    t "exercises/code" 
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
    
    // Demonstração da travessia por nível (Level Order Traversal)
    fmt.Println("\nTravessia por nível (BFS):")
    resultado := t.LevelOrder(arvore)
    
    // Exibe cada nível da árvore
    for i, nivel := range resultado {
        fmt.Printf("Nível %d: %v\n", i, nivel)
    }
    
    // Demonstração da inversão da árvore
    fmt.Println("\nÁrvore invertida:")
    arvoreInvertida := t.InvertTree(arvore)
    imprimirArvore(arvoreInvertida, "", false)
    
    // Exibe a travessia por nível da árvore invertida
    fmt.Println("\nTravessia por nível da árvore invertida:")
    resultadoInvertido := t.LevelOrder(arvoreInvertida)
    for i, nivel := range resultadoInvertido {
        fmt.Printf("Nível %d: %v\n", i, nivel)
    }
}
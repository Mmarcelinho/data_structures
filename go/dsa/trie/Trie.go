package trie

import (
    "errors"
    "strings"
)

// Trie é a estrutura principal da Trie com a raiz
type Trie struct {
    Root *TrieNode // A raiz da Trie
}

// TrieNode representa um nó da Trie
type TrieNode struct {
    Children [26]*TrieNode // Array para armazenar os nós filhos
    IsWord   bool          // Indica se o nó representa o fim de uma palavra
}

// NewTrie cria uma nova Trie e inicializa a raiz
func NewTrie() *Trie {
    return &Trie{Root: &TrieNode{}}
}

// Insert insere uma palavra na Trie
func (t *Trie) Insert(word string) error {
    // Verifica se a palavra é válida
    if word == "" {
        return errors.New("Invalid input: word cannot be empty")
    }

    // Converte a palavra para minúsculas
    word = strings.ToLower(word)

    // Começa na raiz da Trie
    current := t.Root
    for i := 0; i < len(word); i++ {
        // Obtém o caractere atual da palavra e seu índice correspondente no array de filhos
        index := word[i] - 'a'
        
        // Se o nó filho correspondente ao caractere não existir, cria um novo nó
        if current.Children[index] == nil {
            current.Children[index] = &TrieNode{}
        }
        // Move para o nó filho
        current = current.Children[index]
    }
    // Marca o último nó como o fim de uma palavra
    current.IsWord = true
    return nil
}

// Search verifica se uma palavra está na Trie
func (t *Trie) Search(word string) bool {
    current := t.Root
    for i := 0; i < len(word); i++ {
        index := word[i] - 'a'
        if current.Children[index] == nil {
            return false
        }
        current = current.Children[index]
    }
    return current.IsWord
}

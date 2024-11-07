package main

import (
	t "dsa/trie"
	"fmt"
)

func main() {
	t := t.NewTrie()

	words := []string{"cat", "cab", "son", "so"}
	for _, word := range words {
		err := t.Insert(word)
		if err != nil {
			fmt.Println("Erro ao inserir palavra:", err)
		}
	}

	fmt.Println("Palavras inseridas com sucesso")

	// Exemplo de busca
	searchWord := "cat"
	if t.Search(searchWord) {
		fmt.Printf("A palavra '%s' foi encontrada na Trie.\n", searchWord)
	} else {
		fmt.Printf("A palavra '%s' não foi encontrada na Trie.\n", searchWord)
	}
}

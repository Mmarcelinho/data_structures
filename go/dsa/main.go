package main

import (
	s "dsa/stack/impl/List"
	"fmt"
)

func main() {

	// Cria uma nova pilha com o tamanho inicial padrão.
	s := s.NewStack()

	// Adiciona elementos à pilha.
	s.Push(10)
	s.Push(15)
	s.Push(20)

	// Mostra o topo da pilha e remove o elemento do topo.
	if value, err := s.Peek(); err == nil {
		fmt.Println("Topo da pilha:", value) // Esperado: 20
	}
	s.Pop()

	// Mostra o novo topo da pilha e remove o elemento do topo.
	if value, err := s.Peek(); err == nil {
		fmt.Println("Novo topo da pilha:", value) // Esperado: 15
	}
	s.Pop()

	// Mostra o topo da pilha e remove o elemento do topo.
	if value, err := s.Peek(); err == nil {
		fmt.Println("Topo da pilha após remoção:", value) // Esperado: 10
	}
	s.Pop()

	// Tenta remover um elemento de uma pilha vazia, o que causará um erro.
	if _, err := s.Pop(); err != nil {
		fmt.Println("Erro:", err) // Esperado: stack is empty
	}
}

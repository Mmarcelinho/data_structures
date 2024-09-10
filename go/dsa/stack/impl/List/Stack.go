package stack

import (
	"errors"
)

// ListNode representa um nó da lista encadeada usada para a pilha.
type ListNode struct {
	data int       // Dado armazenado no nó
	next *ListNode // Ponteiro para o próximo nó na pilha
}

// Stack representa a estrutura de uma pilha, implementada com uma lista encadeada.
type Stack struct {
	top    *ListNode // Ponteiro para o nó no topo da pilha
	length int       // Quantidade de elementos na pilha
}

// NewStack cria e retorna uma nova pilha vazia.
func NewStack() *Stack {
	return &Stack{
		top:    nil,  // Inicialmente, o topo é nil, indicando que a pilha está vazia
		length: 0,    // A pilha começa com comprimento 0
	}
}

// Length retorna o número de elementos na pilha.
func (s *Stack) Length() int {
	return s.length // Retorna o valor da variável length que mantém o tamanho da pilha
}

// IsEmpty verifica se a pilha está vazia.
func (s *Stack) IsEmpty() bool {
	return s.length == 0 // Se length for 0, a pilha está vazia
}

// Push insere um novo elemento no topo da pilha.
func (s *Stack) Push(data int) {
	// Cria um novo nó com o dado fornecido
	newNode := &ListNode{data: data}

	// O próximo do novo nó passa a ser o nó atual do topo
	newNode.next = s.top

	// Atualiza o topo para o novo nó
	s.top = newNode

	// Incrementa o comprimento da pilha
	s.length++
}

// Pop remove e retorna o elemento do topo da pilha.
func (s *Stack) Pop() (int, error) {

	// Verifica se a pilha está vazia antes de tentar remover
	if s.IsEmpty() {
		return 0, errors.New("stack is empty") // Retorna um erro se a pilha estiver vazia
	}

	// Obtém o valor do topo
	result := s.top.data

	// Atualiza o topo para o próximo nó
	s.top = s.top.next

	// Decrementa o comprimento da pilha
	s.length--

	// Retorna o valor removido
	return result, nil
}

// Peek retorna o valor do topo da pilha sem removê-lo.
func (s *Stack) Peek() (int, error) {

	// Verifica se a pilha está vazia antes de tentar acessar o topo
	if s.IsEmpty() {
		return 0, errors.New("stack is empty") // Retorna um erro se a pilha estiver vazia
	}

	// Retorna o valor armazenado no topo da pilha
	return s.top.data, nil
}

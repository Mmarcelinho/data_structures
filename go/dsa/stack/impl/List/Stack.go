package stack

import (
	"errors"
)

// ListNode representa um nó em uma lista encadeada.
type ListNode struct {
	data int        // Valor armazenado no nó.
	next *ListNode  // Ponteiro para o próximo nó na lista.
}

// Stack representa uma pilha usando uma lista encadeada.
type Stack struct {
	top    *ListNode // Ponteiro para o topo da pilha.
	length int       // Número de elementos na pilha.
}

// NewStack cria uma nova pilha com o topo inicializado como nil e comprimento 0.
// Complexidade: O(1), pois apenas inicializa as propriedades.
func NewStack() *Stack {
	return &Stack{
		top:    nil,
		length: 0,
	}
}

// Length retorna o número de elementos na pilha.
// Complexidade: O(1), pois apenas retorna o valor armazenado em length.
func (s *Stack) Length() int {
	return s.length
}

// IsEmpty verifica se a pilha está vazia.
// Complexidade: O(1), pois apenas compara length com 0.
func (s *Stack) IsEmpty() bool {
	return s.length == 0
}

// Push adiciona um novo elemento ao topo da pilha.
// Complexidade: O(1), pois cria um novo nó e o adiciona ao topo.
func (s *Stack) Push(data int) {
	// Cria um novo nó com o valor de data.
	newNode := &ListNode{data: data}
	// O novo nó aponta para o nó atual no topo da pilha.
	newNode.next = s.top
	// O novo nó se torna o topo da pilha.
	s.top = newNode
	// Incrementa o tamanho da pilha.
	s.length++
}

// Pop remove e retorna o elemento do topo da pilha.
// Complexidade: O(1), pois remove o nó do topo e ajusta o ponteiro.
func (s *Stack) Pop() (int, error) {
	// Se a pilha estiver vazia, retorna um erro.
	if s.IsEmpty() {
		return 0, errors.New("stack is empty")
	}
	// Armazena o valor do nó do topo.
	result := s.top.data
	// Move o topo para o próximo nó na pilha.
	s.top = s.top.next
	// Decrementa o tamanho da pilha.
	s.length--
	// Retorna o valor do nó removido.
	return result, nil
}

// Peek retorna o valor do elemento do topo da pilha sem removê-lo.
// Complexidade: O(1), pois apenas retorna o valor do nó do topo.
func (s *Stack) Peek() (int, error) {
	// Se a pilha estiver vazia, retorna um erro.
	if s.IsEmpty() {
		return 0, errors.New("stack is empty")
	}
	// Retorna o valor do nó do topo.
	return s.top.data, nil
}

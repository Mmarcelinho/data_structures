package array

import "errors"

// Stack representa uma pilha usando um array.
type Stack struct {
	top int   // Índice do topo da pilha.
	arr []int // Array para armazenar os elementos da pilha.
}

// NewStack cria uma nova pilha com a capacidade especificada.
// Complexidade: O(1), pois apenas aloca um array e inicializa o topo.
func NewStack(capacity int) *Stack {
	return &Stack{
		top: -1,                    // Inicialmente, a pilha está vazia, então o topo é -1.
		arr: make([]int, capacity), // Cria um array com a capacidade especificada.
	}
}

// NewDefaultStack cria uma nova pilha com a capacidade padrão de 10.
// Complexidade: O(1), pois chama NewStack com capacidade 10.
func NewDefaultStack() *Stack {
	return NewStack(10)
}

// Size retorna o número de elementos na pilha.
// Complexidade: O(1), pois apenas retorna o valor do topo + 1.
func (s *Stack) Size() int {
	return s.top + 1
}

// IsEmpty verifica se a pilha está vazia.
// Complexidade: O(1), pois verifica se o topo é menor que 0.
func (s *Stack) IsEmpty() bool {
	return s.top < 0
}

// IsFull verifica se a pilha está cheia.
// Complexidade: O(1), pois compara o tamanho do array com o tamanho atual da pilha.
func (s *Stack) IsFull() bool {
	return len(s.arr) == s.Size()
}

// Push empilha um novo elemento na pilha.
// Complexidade: O(1), pois a operação de adicionar um elemento é constante.
// Se a pilha estiver cheia, retorna um erro.
func (s *Stack) Push(data int) error {
	if s.IsFull() {
		return errors.New("stack is full")
	}

	s.top++             // Incrementa o índice do topo.
	s.arr[s.top] = data // Adiciona o novo elemento no topo.
	return nil
}

// Pop remove e retorna o elemento do topo da pilha.
// Complexidade: O(1), pois a operação de remover um elemento é constante.
// Se a pilha estiver vazia, retorna um erro.
func (s *Stack) Pop() (int, error) {
	if s.IsEmpty() {
		return 0, errors.New("stack is empty")
	}
	result := s.arr[s.top] // Armazena o elemento do topo.
	s.top--                // Decrementa o índice do topo.
	return result, nil
}

// Peek retorna o elemento do topo da pilha sem removê-lo.
// Complexidade: O(1), pois a operação de acessar o topo é constante.
// Se a pilha estiver vazia, retorna um erro.
func (s *Stack) Peek() (int, error) {
	if s.IsEmpty() {
		return 0, errors.New("stack is empty")
	}
	return s.arr[s.top], nil // Retorna o elemento do topo.
}

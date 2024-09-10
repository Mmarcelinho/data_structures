package array

import "errors"

// Stack define a estrutura de uma pilha (stack) com um topo e um array de inteiros.
type Stack struct {
	top int   // Índice do topo da pilha
	arr []int // Array que armazena os elementos da pilha
}

// NewStack cria uma nova pilha com a capacidade especificada.
func NewStack(capacity int) *Stack {
	return &Stack{
		top: -1,                   // Inicializa o topo como -1, indicando que a pilha está vazia
		arr: make([]int, capacity), // Cria um array de inteiros com o tamanho especificado
	}
}

// NewDefaultStack cria uma pilha com capacidade padrão de 10 elementos.
func NewDefaultStack() *Stack {
	return NewStack(10) // Chama NewStack com capacidade de 10
}

// Size retorna o número de elementos na pilha.
func (s *Stack) Size() int {
	return s.top + 1 // O topo é o índice do último elemento, então soma-se 1 para obter o tamanho
}

// IsEmpty verifica se a pilha está vazia.
func (s *Stack) IsEmpty() bool {
	return s.top < 0 // A pilha está vazia se o índice do topo for menor que 0
}

// IsFull verifica se a pilha está cheia.
func (s *Stack) IsFull() bool {
	return len(s.arr) == s.Size() // A pilha está cheia se o tamanho da pilha for igual à capacidade do array
}

// Push insere um novo elemento no topo da pilha.
func (s *Stack) Push(data int) error {
	if s.IsFull() { // Verifica se a pilha está cheia antes de adicionar um novo elemento
		return errors.New("stack is full") // Retorna um erro se a pilha estiver cheia
	}

	s.top++            // Incrementa o topo para apontar para a nova posição
	s.arr[s.top] = data // Armazena o dado na nova posição do topo
	return nil          // Retorna nil, indicando que a operação foi bem-sucedida
}

// Pop remove e retorna o elemento do topo da pilha.
func (s *Stack) Pop() (int, error) {
	if s.IsEmpty() { // Verifica se a pilha está vazia antes de tentar remover um elemento
		return 0, errors.New("stack is empty") // Retorna um erro se a pilha estiver vazia
	}
	result := s.arr[s.top] // Obtém o valor do topo
	s.top--                // Decrementa o topo, removendo o elemento do topo
	return result, nil      // Retorna o valor removido
}

// Peek retorna o elemento do topo da pilha sem removê-lo.
func (s *Stack) Peek() (int, error) {
	if s.IsEmpty() { // Verifica se a pilha está vazia
		return 0, errors.New("stack is empty") // Retorna um erro se a pilha estiver vazia
	}
	return s.arr[s.top], nil // Retorna o valor no topo da pilha sem removê-lo
}

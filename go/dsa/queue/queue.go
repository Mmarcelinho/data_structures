package queue

import "fmt"

// ListNode representa um nó da lista ligada que compõe a fila.
type ListNode struct {
	Data int        // Valor armazenado no nó.
	Next *ListNode  // Ponteiro para o próximo nó na lista.
}

// Queue representa a estrutura de uma fila com referência ao primeiro e último nó, além do comprimento.
type Queue struct {
	front  *ListNode  // Referência para o primeiro elemento da fila.
	rear   *ListNode  // Referência para o último elemento da fila.
	length int        // Número de elementos na fila.
}

// NewQueue cria uma nova fila vazia e retorna um ponteiro para ela.
func NewQueue() *Queue {
	return &Queue{
		front:  nil,   // Inicialmente, a fila está vazia, então front é nil.
		rear:   nil,   // Rear também é nil, pois não há elementos.
		length: 0,     // Comprimento inicial da fila é 0.
	}
}

// Length retorna o número de elementos atualmente na fila.
func (q *Queue) Length() int {
	return q.length
}

// IsEmpty verifica se a fila está vazia.
func (q *Queue) IsEmpty() bool {
	return q.length == 0
}

// Enqueue adiciona um novo elemento ao final da fila.
func (q *Queue) Enqueue(data int) {
	// Cria um novo nó com o dado fornecido.
	newNode := &ListNode{Data: data}
	
	// Se a fila estiver vazia, o novo nó será tanto o front quanto o rear.
	if q.IsEmpty() {
		q.front = newNode
	} else {
		// Se a fila não estiver vazia, o último nó aponta para o novo nó.
		q.rear.Next = newNode
	}
	
	// Atualiza o rear para ser o novo nó.
	q.rear = newNode
	// Incrementa o comprimento da fila.
	q.length++
}

// Dequeue remove e retorna o primeiro elemento da fila.
// Retorna um erro se a fila estiver vazia.
func (q *Queue) Dequeue() (int, error) {
	if q.IsEmpty() {
		return 0, fmt.Errorf("Queue is already empty")
	}

	// Armazena o valor do front para ser retornado.
	result := q.front.Data
	// Avança o front para o próximo nó.
	q.front = q.front.Next
	
	// Se o front se tornar nil, significa que a fila ficou vazia,
	// então rear também deve ser nil.
	if q.front == nil {
		q.rear = nil
	}
	
	// Decrementa o comprimento da fila.
	q.length--
	return result, nil
}

// Print exibe todos os elementos da fila na ordem em que estão armazenados.
func (q *Queue) Print() {
	if q.IsEmpty() {
		return
	}

	// Itera sobre os nós da fila, começando do front.
	current := q.front
	for current != nil {
		// Imprime o valor do nó atual.
		fmt.Printf("%d --> ", current.Data)
		// Avança para o próximo nó.
		current = current.Next
	}
	
	// Indica o final da fila.
	fmt.Println("null")
}

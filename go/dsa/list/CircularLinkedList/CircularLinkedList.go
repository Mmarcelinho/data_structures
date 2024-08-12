package circularlinkedlist

import "fmt"

// ListNode representa um nó em uma lista ligada circular.
type ListNode struct {
	Next *ListNode // Ponteiro para o próximo nó na lista
	Data int       // Dados armazenados no nó
}

// CircularLinkedList representa uma lista ligada circular.
type CircularLinkedList struct {
	last   *ListNode // Ponteiro para o último nó da lista (que aponta para o primeiro nó)
	length int       // Número de nós na lista
}

// NewCircularLinkedList cria uma nova lista ligada circular vazia.
func NewCircularLinkedList() *CircularLinkedList {
	return &CircularLinkedList{}
}

// Length retorna o número de nós na lista.
func (cl *CircularLinkedList) Length() int {
	return cl.length
}

// IsEmpty verifica se a lista está vazia.
func (cl *CircularLinkedList) IsEmpty() bool {
	return cl.length == 0
}

// CreateCircularLinkedList cria uma lista ligada circular com quatro nós.
func (cl *CircularLinkedList) CreateCircularLinkedList() {
	// Cria quatro nós
	first := &ListNode{Data: 1}
	second := &ListNode{Data: 5}
	third := &ListNode{Data: 10}
	fourth := &ListNode{Data: 15}

	// Conecta os nós entre si para formar um círculo
	first.Next = second
	second.Next = third
	third.Next = fourth
	fourth.Next = first

	// Define o último nó como o quarto nó e ajusta o comprimento da lista
	cl.last = fourth
	cl.length = 4
}

// Display exibe todos os nós da lista ligada circular.
func (cl *CircularLinkedList) Display() {
	// Se a lista estiver vazia, não faz nada
	if cl.last == nil {
		return
	}

	// Começa pelo primeiro nó (o nó após o último)
	first := cl.last.Next
	// Itera sobre os nós e imprime seus valores
	for first != cl.last {
		fmt.Printf("%d --> ", first.Data)
		first = first.Next
	}
	// Imprime o valor do último nó para completar o ciclo
	fmt.Println(first.Data)
}

// InsertFirst insere um novo nó no início da lista ligada circular.
func (cl *CircularLinkedList) InsertFirst(Data int) {
	// Cria um novo nó com os dados fornecidos
	temp := &ListNode{Data: Data}
	if cl.last == nil {
		// Se a lista estiver vazia, o novo nó aponta para si mesmo e se torna o último nó
		cl.last = temp
		cl.last.Next = cl.last
	} else {
		// Caso contrário, insere o novo nó após o último nó e o conecta ao primeiro
		temp.Next = cl.last.Next
		cl.last.Next = temp
	}
	// Incrementa o comprimento da lista
	cl.length++
}

// InsertLast insere um novo nó no final da lista ligada circular.
func (cl *CircularLinkedList) InsertLast(Data int) {
	// Cria um novo nó com os dados fornecidos
	temp := &ListNode{Data: Data}
	if cl.last == nil {
		// Se a lista estiver vazia, o novo nó aponta para si mesmo e se torna o último nó
		cl.last = temp
		cl.last.Next = cl.last
	} else {
		// Caso contrário, insere o novo nó após o último nó e o atualiza como o novo último nó
		temp.Next = cl.last.Next
		cl.last.Next = temp
		cl.last = temp
	}
	// Incrementa o comprimento da lista
	cl.length++
}

// RemoveFirst remove o primeiro nó da lista ligada circular e retorna o nó removido.
func (cl *CircularLinkedList) RemoveFirst() *ListNode {
	// Verifica se a lista está vazia
	if cl.IsEmpty() {
		panic("Circular Singly Linked List is already empty")
	}

	// Temporariamente armazena o nó que será removido (o primeiro nó)
	temp := cl.last.Next
	if cl.last.Next == cl.last {
		// Se houver apenas um nó, a lista se torna vazia
		cl.last = nil
	} else {
		// Caso contrário, o segundo nó se torna o primeiro nó
		cl.last.Next = temp.Next
	}
	// Desconecta o nó removido e diminui o comprimento da lista
	temp.Next = nil
	cl.length--
	return temp // Retorna o nó removido
}

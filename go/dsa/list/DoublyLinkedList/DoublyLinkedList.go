package doublylinkedlist

import "fmt"

// ListNode representa um nó na lista duplamente encadeada
type ListNode struct {
	Data     int       // Dado armazenado no nó
	Next     *ListNode // Ponteiro para o próximo nó na lista
	Previous *ListNode // Ponteiro para o nó anterior na lista
}

// DoublyLinkedList representa a estrutura da lista duplamente encadeada
type DoublyLinkedList struct {
	head   *ListNode // Ponteiro para o primeiro nó da lista
	tail   *ListNode // Ponteiro para o último nó da lista
	length int       // Contador do número de nós na lista
}

// NewDoublyLinkedList cria e retorna uma nova lista duplamente encadeada
func NewDoublyLinkedList() *DoublyLinkedList {
	return &DoublyLinkedList{}
}

// IsEmpty verifica se a lista está vazia
func (dll *DoublyLinkedList) IsEmpty() bool {
	return dll.length == 0
}

// Length retorna o comprimento da lista
func (dll *DoublyLinkedList) Length() int {
	return dll.length
}

// DisplayForward exibe a lista do início ao fim
func (dll *DoublyLinkedList) DisplayForward() {
	if dll.head == nil {
		return
	}

	temp := dll.head
	for temp != nil {
		fmt.Printf("%d --> ", temp.Data)
		temp = temp.Next
	}
	fmt.Println("null")
}

// DisplayBackward exibe a lista do fim ao início
func (dll *DoublyLinkedList) DisplayBackward() {
	if dll.tail == nil {
		return
	}

	temp := dll.tail
	for temp != nil {
		fmt.Printf("%d --> ", temp.Data)
		temp = temp.Previous
	}
	fmt.Println("null")
}

// InsertFirst insere um nó no início da lista
func (dll *DoublyLinkedList) InsertFirst(value int) {
	newNode := &ListNode{Data: value}
	if dll.IsEmpty() {
		dll.tail = newNode
	} else {
		dll.head.Previous = newNode
	}
	newNode.Next = dll.head
	dll.head = newNode
	dll.length++
}

// InsertEnd insere um nó no fim da lista
func (dll *DoublyLinkedList) InsertEnd(value int) {
	newNode := &ListNode{Data: value}
	if dll.IsEmpty() {
		dll.head = newNode
	} else {
		dll.tail.Next = newNode
		newNode.Previous = dll.tail
	}
	dll.tail = newNode
	dll.length++
}

// DeleteFirst remove o primeiro nó da lista e o retorna
func (dll *DoublyLinkedList) DeleteFirst() *ListNode {
	if dll.IsEmpty() {
		panic("Doubly Linked List is already empty")
	}

	temp := dll.head
	if dll.head == dll.tail {
		dll.tail = nil
	} else {
		dll.head.Next.Previous = nil
	}
	dll.head = dll.head.Next
	temp.Next = nil
	dll.length--
	return temp
}

// DeleteLast remove o último nó da lista e o retorna
func (dll *DoublyLinkedList) DeleteLast() *ListNode {
	if dll.IsEmpty() {
		panic("Doubly Linked List is already empty")
	}

	temp := dll.tail
	if dll.head == dll.tail {
		dll.head = nil
	} else {
		dll.tail.Previous.Next = nil
	}
	dll.tail = dll.tail.Previous
	temp.Previous = nil
	dll.length--
	return temp
}

package singlylinkedlist

import (
	"errors"
	"fmt"
)

// ListNode representa um nó na lista encadeada simples.
type ListNode struct {
	Data int        // Valor armazenado no nó.
	Next *ListNode  // Ponteiro para o próximo nó na lista.
}

// SinglyLinkedList representa a lista encadeada simples.
type SinglyLinkedList struct {
	Head *ListNode  // Ponteiro para o primeiro nó da lista.
}

// Display exibe todos os nós da lista encadeada.
func (sll *SinglyLinkedList) Display() {
	current := sll.Head
	for current != nil {
		fmt.Printf("%d --> ", current.Data)
		current = current.Next
	}
	fmt.Println("null")  // Final da lista
}

// Length retorna o comprimento (número de nós) da lista.
func (sll *SinglyLinkedList) Length() int {
	if sll.Head == nil {
		return 0  // Lista vazia
	}
	count := 0
	current := sll.Head
	for current != nil {
		count++
		current = current.Next
	}
	return count  // Retorna o número de nós na lista
}

// InsertFirst insere um nó no início da lista.
func (sll *SinglyLinkedList) InsertFirst(value int) {
	newNode := &ListNode{Data: value}
	newNode.Next = sll.Head  // Aponta para o antigo primeiro nó
	sll.Head = newNode       // Atualiza o Head para o novo nó
}

// Insert insere um nó em uma posição específica na lista (1-indexada).
func (sll *SinglyLinkedList) Insert(position, value int) {
	newNode := &ListNode{Data: value}
	if position == 1 {
		// Inserção no início
		newNode.Next = sll.Head
		sll.Head = newNode
	} else {
		// Inserção em outra posição
		previous := sll.Head
		count := 1
		for count < position-1 {
			previous = previous.Next
			count++
		}
		newNode.Next = previous.Next
		previous.Next = newNode
	}
}

// InsertLast insere um nó no final da lista.
func (sll *SinglyLinkedList) InsertLast(value int) {
	newNode := &ListNode{Data: value}
	if sll.Head == nil {
		// Caso especial: lista vazia
		sll.Head = newNode
		return
	}
	current := sll.Head
	for current.Next != nil {
		current = current.Next
	}
	current.Next = newNode  // Adiciona o novo nó ao final
}

// DeleteFirst remove e retorna o primeiro nó da lista.
func (sll *SinglyLinkedList) DeleteFirst() *ListNode {
	if sll.Head == nil {
		return nil  // Lista vazia, nada para remover
	}
	temp := sll.Head
	sll.Head = sll.Head.Next  // Atualiza o Head para o próximo nó
	temp.Next = nil           // Desconecta o nó removido
	return temp
}

// Delete remove um nó de uma posição específica na lista.
func (sll *SinglyLinkedList) Delete(position int) {
	if position == 1 {
		// Remoção no início
		sll.Head = sll.Head.Next
	} else {
		// Remoção em outra posição
		previous := sll.Head
		count := 1
		for count < position-1 {
			previous = previous.Next
			count++
		}
		current := previous.Next
		previous.Next = current.Next  // Remove o nó
	}
}

// DeleteLast remove e retorna o último nó da lista.
func (sll *SinglyLinkedList) DeleteLast() *ListNode {
	if sll.Head == nil {
		return sll.Head  // Lista vazia
	}
	if sll.Head.Next == nil {
		// Caso especial: lista com um único nó
		temp := sll.Head
		sll.Head = nil
		return temp
	}
	current := sll.Head
	var previous *ListNode
	for current.Next != nil {
		previous = current
		current = current.Next
	}
	previous.Next = nil  // Remove o último nó
	return current
}

// Find verifica se um valor específico existe na lista.
func (sll *SinglyLinkedList) Find(searchKey int) bool {
	current := sll.Head
	for current != nil {
		if current.Data == searchKey {
			return true  // Valor encontrado
		}
		current = current.Next
	}
	return false  // Valor não encontrado
}

// Reverse reverte a ordem dos nós na lista.
func (sll *SinglyLinkedList) Reverse() *ListNode {
	if sll.Head == nil {
		return nil  // Lista vazia
	}

	var previous, Next *ListNode
	current := sll.Head
	for current != nil {
		Next = current.Next    // Armazena o próximo nó
		current.Next = previous  // Inverte a direção do ponteiro
		previous = current     // Move previous e current para frente
		current = Next
	}
	sll.Head = previous  // Atualiza o Head para o novo primeiro nó
	return sll.Head
}

// GetMiddleNode retorna o nó do meio da lista (para listas ímpares) ou o segundo nó do meio (para listas pares).
func (sll *SinglyLinkedList) GetMiddleNode() *ListNode {
	if sll.Head == nil {
		return nil  // Lista vazia
	}
	slowPtr := sll.Head
	fastPtr := sll.Head
	// O ponteiro lento avança uma posição, enquanto o rápido avança duas posições.
	// Quando o ponteiro rápido chega ao final, o ponteiro lento está no meio.
	for fastPtr != nil && fastPtr.Next != nil {
		slowPtr = slowPtr.Next
		fastPtr = fastPtr.Next.Next
	}
	return slowPtr
}

// GetNthNodeFromEnd retorna o n-ésimo nó a partir do final da lista.
func (sll *SinglyLinkedList) GetNthNodeFromEnd(n int) (*ListNode, error) {
	if sll.Head == nil || n <= 0 {
		return nil, errors.New("valor inválido para n")  // Verificação de entrada inválida
	}
	mainPtr, refPtr := sll.Head, sll.Head
	count := 0
	// Mova o ponteiro de referência n posições à frente
	for count < n {
		if refPtr == nil {
			return nil, errors.New("valor inválido para n")
		}
		refPtr = refPtr.Next
		count++
	}
	// Mova ambos os ponteiros até que o ponteiro de referência chegue ao final
	for refPtr != nil {
		refPtr = refPtr.Next
		mainPtr = mainPtr.Next
	}
	return mainPtr, nil
}

// InsertInSortedList insere um nó em uma lista ordenada, mantendo a ordem.
func (sll *SinglyLinkedList) InsertInSortedList(value int) *ListNode {
	newNode := &ListNode{Data: value}
	if sll.Head == nil || sll.Head.Data >= newNode.Data {
		// Caso especial: inserção no início
		newNode.Next = sll.Head
		sll.Head = newNode
		return sll.Head
	}
	current := sll.Head
	// Encontre a posição correta para inserção
	for current.Next != nil && current.Next.Data < newNode.Data {
		current = current.Next
	}
	newNode.Next = current.Next
	current.Next = newNode
	return sll.Head
}

// DeleteNode remove o nó que contém um valor específico.
func (sll *SinglyLinkedList) DeleteNode(key int) {
	current := sll.Head
	var previous *ListNode
	// Caso especial: o nó a ser removido é o primeiro
	if current != nil && current.Data == key {
		sll.Head = current.Next
		return
	}
	// Encontre o nó a ser removido
	for current != nil && current.Data != key {
		previous = current
		current = current.Next
	}
	// Se o nó não for encontrado, faça nada
	if current == nil {
		return
	}
	// Remova o nó da lista
	previous.Next = current.Next
}

// ContainsLoop verifica se a lista contém um loop.
func (sll *SinglyLinkedList) ContainsLoop() bool {
	slowPtr, fastPtr := sll.Head, sll.Head
	// Use dois ponteiros, um movendo-se mais rápido que o outro.
	// Se houver um loop, eles eventualmente se encontrarão.
	for fastPtr != nil && fastPtr.Next != nil {
		slowPtr = slowPtr.Next
		fastPtr = fastPtr.Next.Next
		if slowPtr == fastPtr {
			return true  // Loop detectado
		}
	}
	return false  // Nenhum loop detectado
}

// StartNodeInALoop encontra o nó onde o loop começa, se houver.
func (sll *SinglyLinkedList) StartNodeInALoop() *ListNode {
	slowPtr, fastPtr := sll.Head, sll.Head
	// Primeiro, detecte se há um loop usando dois ponteiros.
	for fastPtr != nil && fastPtr.Next != nil {
		slowPtr = slowPtr.Next
		fastPtr = fastPtr.Next.Next
		if slowPtr == fastPtr {
			// Encontre o nó de início do loop
			return sll.getStartingNode(slowPtr)
		}
	}
	return nil  // Nenhum loop encontrado
}

// getStartingNode encontra o nó de início do loop.
func (sll *SinglyLinkedList) getStartingNode(slowPtr *ListNode) *ListNode {
	temp := sll.Head
	// Move ambos os ponteiros até que eles se encontrem no nó de início do loop.
	for temp != slowPtr {
		temp = temp.Next
		slowPtr = slowPtr.Next
	}
	return temp
}

// RemoveLoop remove um loop na lista, se existir.
func (sll *SinglyLinkedList) RemoveLoop() {
	slowPtr, fastPtr := sll.Head, sll.Head
	// Primeiro, detecte o loop.
	for fastPtr != nil && fastPtr.Next != nil {
		slowPtr = slowPtr.Next
		fastPtr = fastPtr.Next.Next
		if slowPtr == fastPtr {
			// Remova o loop uma vez detectado
			sll.removeLoop(slowPtr)
			return
		}
	}
}

// removeLoop desconecta o nó que forma o loop.
func (sll *SinglyLinkedList) removeLoop(slowPtr *ListNode) {
	temp := sll.Head
	// Encontre o nó onde o loop começa e desconecte-o.
	for temp.Next != slowPtr.Next {
		temp = temp.Next
		slowPtr = slowPtr.Next
	}
	slowPtr.Next = nil  // Remove o loop
}

// CreateALoopInLinkedList cria um loop na lista para fins de teste.
func (sll *SinglyLinkedList) CreateALoopInLinkedList() {
	first := &ListNode{Data: 1}
	second := &ListNode{Data: 2}
	third := &ListNode{Data: 3}
	fourth := &ListNode{Data: 4}
	fifth := &ListNode{Data: 5}
	sixth := &ListNode{Data: 6}

	sll.Head = first
	first.Next = second
	second.Next = third
	third.Next = fourth
	fourth.Next = fifth
	fifth.Next = sixth
	sixth.Next = third // Cria um loop apontando para o terceiro nó
}

// Merge mescla duas listas encadeadas ordenadas em uma única lista ordenada.
func Merge(a, b *ListNode) *ListNode {
	dummy := &ListNode{}
	tail := dummy
	// Continue mesclando até que uma das listas acabe.
	for a != nil && b != nil {
		if a.Data <= b.Data {
			tail.Next = a
			a = a.Next
		} else {
			tail.Next = b
			b = b.Next
		}
		tail = tail.Next
	}
	// Anexa o restante da lista que ainda tem elementos.
	if a != nil {
		tail.Next = a
	} else {
		tail.Next = b
	}
	return dummy.Next  // Retorna a lista mesclada
}

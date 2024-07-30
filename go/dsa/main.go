package main

import (
	doublylinkedlist "dsa/list/DoublyLinkedList"
	"fmt"
)

func main() {
	dll := doublylinkedlist.NewDoublyLinkedList()

	// Inserir elementos no fim da lista
	dll.InsertEnd(1)
	dll.InsertEnd(2)
	dll.InsertEnd(3)

	// Exibir a lista do início ao fim
	fmt.Println("Displaying list forward:")
	dll.DisplayForward()

	// Exibir a lista do fim ao início
	fmt.Println("Displaying list backward:")
	dll.DisplayBackward()

	// Remover elementos do fim da lista
	fmt.Println("Removing last element:")
	dll.DeleteLast()
	fmt.Println("Removing last element:")
	dll.DeleteLast()

	// Exibir a lista do início ao fim após remoções
	fmt.Println("Displaying list forward after deletions:")
	dll.DisplayForward()

	// Inserir elementos no início da lista
	fmt.Println("Inserting elements at the beginning:")
	dll.InsertFirst(4)
	dll.InsertFirst(5)

	// Exibir a lista do início ao fim após inserções
	fmt.Println("Displaying list forward after insertions:")
	dll.DisplayForward()
}

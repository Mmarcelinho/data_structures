package main

import (
	circularlinkedlist "dsa/list/CircularLinkedList"
	"fmt"
)

func main() {
	cll := circularlinkedlist.NewCircularLinkedList()

	cll.CreateCircularLinkedList()

	fmt.Println("Lista após criar a lista circularmente encadeada:")
	cll.Display()

	cll.InsertFirst(20)
	cll.InsertLast(25)

	fmt.Println("\nLista após inserir nós no início e no final:")
	cll.Display()

	removedNode := cll.RemoveFirst()
	fmt.Printf("\nNó removido: %d\n", removedNode.Data)

	fmt.Println("\nLista após remover o primeiro nó:")
	cll.Display()
}

package main

import (
	singlylinkedlist "dsa/list/SinglyLinkedList"
	"fmt"
)

func main() {
	// Cria uma nova lista encadeada
	list := &singlylinkedlist.SinglyLinkedList{}

	// Insere elementos no início da lista
	list.InsertFirst(10)
	list.InsertFirst(20)
	list.InsertFirst(30)

	// Exibe a lista
	fmt.Println("Lista após inserir no início:")
	list.Display()

	// Insere um elemento no final da lista
	list.InsertLast(5)
	fmt.Println("Lista após inserir no final:")
	list.Display()

	// Insere um elemento na segunda posição
	list.Insert(2, 25)
	fmt.Println("Lista após inserir na segunda posição:")
	list.Display()

	// Verifica o comprimento da lista
	fmt.Printf("Comprimento da lista: %d\n", list.Length())

	// Remove o primeiro elemento
	list.DeleteFirst()
	fmt.Println("Lista após remover o primeiro elemento:")
	list.Display()

	// Remove o último elemento
	list.DeleteLast()
	fmt.Println("Lista após remover o último elemento:")
	list.Display()

	// Remove o segundo elemento
	list.Delete(2)
	fmt.Println("Lista após remover o segundo elemento:")
	list.Display()

	// Verifica se a lista contém um determinado valor
	searchKey := 25
	found := list.Find(searchKey)
	fmt.Printf("Elemento %d encontrado? %v\n", searchKey, found)

	// Insere elementos de forma ordenada
	list.InsertInSortedList(15)
	list.InsertInSortedList(35)
	fmt.Println("Lista após inserir elementos de forma ordenada:")
	list.Display()

	// Reverte a lista
	list.Reverse()
	fmt.Println("Lista após reverter:")
	list.Display()

	// Obtém o nó do meio da lista
	middleNode := list.GetMiddleNode()
	if middleNode != nil {
		fmt.Printf("O nó do meio tem o valor: %d\n", middleNode.Data)
	} else {
		fmt.Println("A lista está vazia.")
	}

	// Obtém o segundo nó a partir do final
	nthNode, err := list.GetNthNodeFromEnd(2)
	if err != nil {
		fmt.Println(err)
	} else {
		fmt.Printf("O segundo nó a partir do final tem o valor: %d\n", nthNode.Data)
	}

	// Cria um loop na lista para fins de teste
	list.CreateALoopInLinkedList()

	// Verifica se a lista contém um loop
	if list.ContainsLoop() {
		fmt.Println("A lista contém um loop.")
		list.RemoveLoop()
		fmt.Println("Loop removido.")
	} else {
		fmt.Println("A lista não contém um loop.")
	}

	// Exibe a lista após remover o loop
	fmt.Println("Lista após remover o loop:")
	list.Display()

	// Mescla duas listas encadeadas ordenadas
	list1 := &singlylinkedlist.SinglyLinkedList{}
	list1.InsertInSortedList(10)
	list1.InsertInSortedList(20)
	list1.InsertInSortedList(30)

	list2 := &singlylinkedlist.SinglyLinkedList{}
	list2.InsertInSortedList(15)
	list2.InsertInSortedList(25)
	list2.InsertInSortedList(35)

	mergedList := singlylinkedlist.Merge(list1.Head, list2.Head)
	fmt.Println("Lista após mesclar duas listas ordenadas:")
	current := mergedList
	for current != nil {
		fmt.Printf("%d --> ", current.Data)
		current = current.Next
	}
	fmt.Println("null")
}

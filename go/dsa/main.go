package main

import (
	t "dsa/tree/BinarySearchTree"
	"fmt"
)

func main() {
	bst := t.NewBinarySearchTree()
    bst.Insert(5)
    bst.Insert(3)
    bst.Insert(7)
    bst.Insert(1)

    bst.InOrder()

    if bst.Search(10) != nil {
        fmt.Println("Key found")
    } else {
        fmt.Println("Key not found")
    }
}

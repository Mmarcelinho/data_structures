package main

import (
	s "dsa/stack/impl/Array"
	"fmt"
)

func main() {
	stack := s.NewDefaultStack()

	if err := stack.Push(10); err != nil {
		fmt.Println(err)
	}
	if err := stack.Push(15); err != nil {
		fmt.Println(err)
	}
	if err := stack.Push(20); err != nil {
		fmt.Println(err)
	}

	if val, err := stack.Peek(); err != nil {
		fmt.Println(err)
	} else {
		fmt.Println(val)
	}
	if _, err := stack.Pop(); err != nil {
		fmt.Println(err)
	}

	if val, err := stack.Peek(); err != nil {
		fmt.Println(err)
	} else {
		fmt.Println(val)
	}
	if _, err := stack.Pop(); err != nil {
		fmt.Println(err)
	}

	if val, err := stack.Peek(); err != nil {
		fmt.Println(err)
	} else {
		fmt.Println(val)
	}
	if _, err := stack.Pop(); err != nil {
		fmt.Println(err)
	}

	// Tentando remover um elemento de uma pilha vazia, o que causará um erro.
	if _, err := stack.Pop(); err != nil {
		fmt.Println(err)
	}
}

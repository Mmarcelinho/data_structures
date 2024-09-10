package main

import (
	s "dsa/stack/StringReverse"
	"fmt"
)

func main() {
	str := "ABCD"
	fmt.Printf("Before reverse - %s\n", str)
	fmt.Printf("After reverse  - %s\n", s.Reverse(str))
}

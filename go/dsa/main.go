package main

import (
	s "dsa/sorting/SelectionSort"
)

func main() {
	arr := []int{5, 1, 2, 9, 16}

	s.PrintArray(arr)
	s.Sort(arr)
	s.PrintArray(arr)
}

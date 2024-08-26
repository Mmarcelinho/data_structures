package main

import (
	s "dsa/sorting/Sort012"
)

func main() {
	arr := []int{ 2, 0, 0, 1, 0, 2, 0, 1, 0, 2, 2, 0 }

	s.PrintArray(arr)
	s.ThreeNumberSort(arr)
	s.PrintArray(arr)
}

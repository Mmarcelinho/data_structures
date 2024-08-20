package main

import (
	i "dsa/sorting/InsertionSort"
)

func main() {
	arr := []int{5, 4, 3, 2, 9, 10}

	i.PrintArray(arr)
	i.Sort(arr)
	i.PrintArray(arr)
}

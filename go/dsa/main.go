package main

import (
	b "dsa/sorting/BubbleSort"
)

func main() {
	arr := []int{15, 1, 2, 9, 10}

	b.PrintArray(arr)
	b.Sort(arr)
	b.PrintArray(arr)
}

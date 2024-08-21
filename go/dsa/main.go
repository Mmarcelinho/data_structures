package main

import (
	m "dsa/sorting/MergeSort"
)

func main() {
	arr := []int{9, 5, 2, 4, 3, -1}
	tempArr := make([]int, len(arr))

	m.PrintArray(arr)
	m.Sort(arr, tempArr, 0, len(arr)-1)
	m.PrintArray(arr)
}

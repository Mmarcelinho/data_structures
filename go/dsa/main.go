package main

import (
	r "dsa/mathematics"
)

func main() {
	arr := []int{3, 2, 4, 7, 10, 6, 5}

	r.PrintArray(arr)

	result := r.RemoveEven(arr)

	r.PrintArray(result)
}

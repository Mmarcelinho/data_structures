package main

import (
	b "dsa/binarysearch"
	"fmt"
)

func main() {
	nums := []int{1, 10, 20, 47, 59, 65, 75, 88, 99}

	result := b.BS(nums, 59)

	if result == -1 {
		print("value not found.")
	}

	fmt.Printf("%v", result)
}

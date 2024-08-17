package main

import (
	s "dsa/search"
	"fmt"
)

func main() {
	nums := []int{1, 10, 20, 47, 59, 65, 75, 88, 99}

	result, err := s.Search(nums, 75)

	if err != nil {
		fmt.Println(err)
		return
	}

	fmt.Printf("%v", result)
}

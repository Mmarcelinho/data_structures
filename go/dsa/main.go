package main

import (
	s "dsa/matrix"
)

func main() {

	matrix := [][]int{
		{10, 20, 30, 40},
		{15, 25, 35, 45},
		{27, 29, 37, 48},
		{32, 33, 39, 51},
	}

	s.Search(matrix, len(matrix), 32)
	s.Search(matrix, len(matrix), 100)
}

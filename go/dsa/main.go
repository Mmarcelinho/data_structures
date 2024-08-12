package main

import (
	s "dsa/matrix"
)

func main() {

	matrix := [][]int{
		{1, 2, 3, 4},
		{5, 6, 7, 8},
		{9, 10, 11, 12},
		{13, 14, 15, 16},
	}

	s.SpiralPrint(matrix, len(matrix), len(matrix[0]))
}

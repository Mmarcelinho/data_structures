package dp

import "math"

// Função para encontrar a soma máxima de um subarray contíguo
func MaxSubArraySum(array []int) int {
	currentMax := array[0] // Inicializa o máximo atual como o primeiro elemento do array
	maxSoFar := array[0]   // Inicializa o máximo até agora como o primeiro elemento do array

	// Itera sobre o array a partir do segundo elemento
	for i := 1; i < len(array); i++ {
		// Atualiza o máximo atual: é o maior valor entre o elemento atual e a soma do máximo atual com o elemento atual
		currentMax = int(math.Max(float64(currentMax+array[i]), float64(array[i])))

		// Atualiza o máximo até agora se o máximo atual for maior
		if maxSoFar < currentMax {
			maxSoFar = currentMax
		}
	}

	return maxSoFar // Retorna a soma máxima de um subarray contíguo
}

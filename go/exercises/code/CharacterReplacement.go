package code

import "math"

// ReplaceCharacter calcula o comprimento máximo de uma substring que pode ser formada
// com no máximo `k` substituições de caracteres.
func ReplaceCharacter(s string, k int) int {
	left := 0                          // Ponteiro esquerdo da janela
	maxLength := 0                     // Comprimento máximo da substring
	mostFrequentLetterCount := 0       // Contador da letra mais frequente na janela
	charCounts := make([]int, 26)      // Contador para cada letra (A a Z)

	// Percorre a string com o ponteiro direito da janela
	for right := 0; right < len(s); right++ {
		// Incrementa o contador da letra atual na posição 'right'
		charCounts[s[right]-'A']++

		// Atualiza o contador da letra mais frequente na janela
		mostFrequentLetterCount = int(math.Max(float64(mostFrequentLetterCount), float64(charCounts[s[right]-'A'])))

		// Calcula quantas letras precisam ser alteradas na janela atual
		lettersToChange := (right - left + 1) - mostFrequentLetterCount

		// Se o número de letras a serem alteradas for maior que `k`,
		// move o ponteiro esquerdo e ajusta o contador de letras
		if lettersToChange > k {
			charCounts[s[left]-'A']-- // Remove o caractere na posição 'left'
			left++                    // Move o ponteiro esquerdo
		}

		// Atualiza o comprimento máximo da substring
		maxLength = int(math.Max(float64(maxLength), float64(right-left+1)))
	}

	// Retorna o comprimento máximo da substring com no máximo `k` substituições
	return maxLength
}

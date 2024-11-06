package string

import (
	"strings"
)

// StringUtil é uma estrutura para agrupar as funções de utilidade de string
type StringUtil struct{}

// IsSubsequence verifica se 'seq' é uma subsequência de 'str'
func IsSubsequence(str, seq string) bool {
	i, j := 0, 0 // i percorre 'str' e j percorre 'seq'

	// Enquanto não chegamos ao fim de 'str' ou 'seq'
	for i < len(str) && j < len(seq) {
		// Se o caractere atual de 'str' é igual ao de 'seq', avançamos em 'seq'
		if str[i] == seq[j] {
			j++
		}
		// Avançamos sempre em 'str'
		i++
	}
	// Se j atingiu o comprimento de 'seq', então 'seq' é uma subsequência de 'str'
	return j == len(seq)
}

// RemoveVowels remove todas as vogais de uma string
func RemoveVowels(str string) string {
	// Define um conjunto de caracteres que são considerados vogais
	vowels := "aeiou"
	var result strings.Builder // strings.Builder para construir a nova string

	// Percorre cada caractere na string
	for _, ch := range str {
		// Se o caractere atual não é uma vogal, adiciona-o ao resultado
		if !strings.ContainsRune(vowels, ch) {
			result.WriteRune(ch)
		}
	}
	// Retorna a string sem vogais
	return result.String()
}

// FirstNonRepeatingCharacter retorna o índice do primeiro caractere não repetido em 'str'
func FirstNonRepeatingCharacter(str string) int {
	// Mapa para armazenar a frequência de cada caractere
	characterFrequencyMap := make(map[rune]int)
	chars := []rune(str) // Converte a string para um slice de runas

	// Conta a frequência de cada caractere
	for _, ch := range chars {
		characterFrequencyMap[ch]++
	}

	// Percorre os caracteres novamente para encontrar o primeiro não repetido
	for i, ch := range chars {
		if characterFrequencyMap[ch] == 1 {
			return i // Retorna o índice do primeiro caractere não repetido
		}
	}
	// Se nenhum caractere com frequência 1 foi encontrado, retorna -1
	return -1
}

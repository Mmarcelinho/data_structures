package code

// ContainsDuplicate verifica se há números duplicados no slice fornecido
func ContainsDuplicate(numbers []int) bool {
	// Cria um mapa para armazenar números únicos
	uniqueNumbers := make(map[int]bool)

	// Percorre cada número no slice "numbers"
	for _, number := range numbers {
		// Verifica se o número já está presente no mapa
		if _, exists := uniqueNumbers[number]; exists {
			// Se o número já existir, encontramos um número duplicado
			return true
		}

		// Caso contrário, adiciona o número ao mapa
		uniqueNumbers[number] = true
	}

	// Se nenhum número duplicado foi encontrado, retorna "false"
	return false
}

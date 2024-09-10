package stringreverse

type Stack struct {
	items []rune // Usamos rune para suportar caracteres Unicode
}

// Push adiciona um caractere à pilha
func (s *Stack) Push(item rune) {
	s.items = append(s.items, item)
}

// Pop remove e retorna o último caractere da pilha
func (s *Stack) Pop() rune {
	if len(s.items) == 0 {
		return 0 // Retorna 0 (valor de rune) se a pilha estiver vazia
	}
	// Remove o último elemento da pilha
	lastIndex := len(s.items) - 1
	item := s.items[lastIndex]
	s.items = s.items[:lastIndex]
	return item
}

// Reverse inverte a string usando uma pilha
func Reverse(str string) string {
	// Criamos uma nova pilha de caracteres
	stack := Stack{}

	// Convertemos a string em um slice de runas (suporta caracteres Unicode)
	chars := []rune(str)

	// Empurra cada caractere da string para a pilha
	for _, c := range chars {
		stack.Push(c)
	}

	// Remove os caracteres da pilha na ordem inversa
	for i := 0; i < len(chars); i++ {
		chars[i] = stack.Pop()
	}

	// Converte o slice de runas de volta para uma string e a retorna
	return string(chars)
}

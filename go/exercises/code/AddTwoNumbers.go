package code

// ListNode representa um nó em uma lista ligada
type ListNode struct {
	Val  int       // Valor armazenado no nó
	Next *ListNode // Referência para o próximo nó na lista
}

// NewListNode cria um novo nó para a lista ligada
func NewListNode(val int, next *ListNode) *ListNode {
	return &ListNode{
		Val:  val,
		Next: next,
	}
}

// AddTwoNumbers soma os números representados por duas listas ligadas e retorna a lista resultante
func AddTwoNumbers(l1 *ListNode, l2 *ListNode) *ListNode {
	// Cria um nó inicial para a lista ligada de resultado
	sumList := NewListNode(0, nil)
	current := sumList // Aponta para o nó atual na lista resultante
	carry := 0         // Armazena o valor que "sobra" das somas que ultrapassam 9

	// Loop continua enquanto qualquer uma das listas l1 ou l2 não forem nulas ou houver um carry
	for l1 != nil || l2 != nil || carry == 1 {
		// Se l1 ou l2 forem nulos, seus valores são considerados 0
		v1, v2 := 0, 0
		if l1 != nil {
			v1 = l1.Val
		}
		if l2 != nil {
			v2 = l2.Val
		}

		// Soma os valores dos nós atuais de l1 e l2, e o carry
		sum := v1 + v2 + carry
		// Atualiza carry. Se a soma for maior que 9, carry será 1; caso contrário, será 0
		if sum > 9 {
			carry = 1
		} else {
			carry = 0
		}
		// Obtém o dígito das unidades da soma (0-9)
		sum = sum % 10

		// Cria um novo nó com o valor da soma e o adiciona na lista resultante
		current.Next = NewListNode(sum, nil)
		current = current.Next // Move current para o próximo nó na lista resultante

		// Move para o próximo nó em l1, se existir
		if l1 != nil {
			l1 = l1.Next
		}
		// Move para o próximo nó em l2, se existir
		if l2 != nil {
			l2 = l2.Next
		}
	}

	// Retorna a lista resultante, ignorando o nó inicial de valor 0
	return sumList.Next
}

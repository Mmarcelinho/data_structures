package arrayutil

import (
	"errors"
	"fmt"
	"math"
	"sort"
)

// ArrayDemo demonstra o uso da função FindMissingNumber
func ArrayDemo() {
	array := []int{1, 3, 6, 8, 2, 4, 7}
	fmt.Println(FindMissingNumber(array)) // Encontra e imprime o número faltante no array
}

// PrintArray imprime todos os elementos de um array
func PrintArray(array []int) {
	for _, v := range array { // Percorre cada elemento do array
		fmt.Printf("%d ", v) // Imprime o elemento seguido de um espaço
	}
}

// FindMinimum encontra e retorna o menor valor em um array
func FindMinimum(array []int) (int, error) {
	if len(array) == 0 { // Verifica se o array está vazio
		return 0, errors.New("entrada inválida")
	}

	menor := array[0] // Inicializa o menor valor com o primeiro elemento do array

	for i := 1; i < len(array); i++ { // Percorre o restante do array
		if array[i] < menor { // Atualiza o menor valor se encontrar um valor menor
			menor = array[i]
		}
	}
	return menor, nil // Retorna o menor valor encontrado
}

// Reverse inverte a ordem dos elementos em um subarray de 'numeros', do índice 'inicio' até 'fim'
func Reverse(numeros []int, inicio, fim int) {
	for inicio < fim { // Continua enquanto 'inicio' for menor que 'fim'
		numeros[inicio], numeros[fim] = numeros[fim], numeros[inicio] // Troca os elementos
		inicio++ // Incrementa 'inicio'
		fim-- // Decrementa 'fim'
	}
}

// TwoSum retorna os índices de dois números que somam 'alvo' em um array
func TwoSum(numeros []int, alvo int) ([]int, error) {
	resultado := make([]int, 2) // Cria um array para armazenar os resultados
	mapa := make(map[int]int) // Cria um mapa para armazenar os índices dos números

	for i, num := range numeros { // Percorre o array
		if idx, ok := mapa[alvo-num]; ok { // Verifica se o complemento necessário está no mapa
			resultado[0] = idx
			resultado[1] = i
			return resultado, nil // Retorna os índices encontrados
		}
		mapa[num] = i // Adiciona o número atual e seu índice ao mapa
	}
	return nil, errors.New("Dois números não encontrados") // Retorna um erro se não encontrar dois números que somam 'alvo'
}

// TwoSumII retorna dois números que somam 'alvo' em um array ordenado
func TwoSumII(array []int, alvo int) []int {
	sort.Ints(array) // Ordena o array
	left, right := 0, len(array)-1 // Inicializa os ponteiros

	resultado := make([]int, 2) // Cria um array para armazenar os resultados

	for left < right { // Continua enquanto 'left' for menor que 'right'
		soma := array[left] + array[right] // Calcula a soma dos elementos apontados
		if soma == alvo { // Verifica se a soma é igual ao alvo
			resultado[0] = array[left]
			resultado[1] = array[right]
			return resultado // Retorna os números encontrados
		} else if soma < alvo { // Se a soma for menor que o alvo, move o ponteiro esquerdo para a direita
			left++
		} else { // Se a soma for maior que o alvo, move o ponteiro direito para a esquerda
			right--
		}
	}
	return []int{} // Retorna um array vazio se não encontrar dois números que somam 'alvo'
}

// SortedSquares retorna um novo array com os quadrados dos elementos de 'array', ordenados
func SortedSquares(array []int) []int {
	numeroDeElementos := len(array) // Obtém o comprimento do array
	i, j := 0, numeroDeElementos-1 // Inicializa os ponteiros
	resultado := make([]int, numeroDeElementos) // Cria um array para armazenar os resultados

	for k := numeroDeElementos - 1; k >= 0; k-- { // Preenche o array resultado de trás para frente
		if math.Abs(float64(array[i])) > math.Abs(float64(array[j])) { // Compara os valores absolutos
			resultado[k] = array[i] * array[i] // Armazena o quadrado do elemento maior
			i++ // Move o ponteiro esquerdo para a direita
		} else {
			resultado[k] = array[j] * array[j] // Armazena o quadrado do elemento maior
			j-- // Move o ponteiro direito para a esquerda
		}
	}
	return resultado // Retorna o array com os quadrados ordenados
}

// FindMissingNumber calcula e retorna o número que está faltando em um array que deveria conter todos os números de 1 a N
func FindMissingNumber(array []int) int {
	numeroDeElementos := len(array) + 1 // Calcula o número de elementos esperado
	soma := numeroDeElementos * (numeroDeElementos + 1) / 2 // Calcula a soma dos números de 1 a N

	for _, num := range array { // Subtrai cada elemento do array da soma
		soma -= num
	}
	return soma // Retorna o número faltante
}

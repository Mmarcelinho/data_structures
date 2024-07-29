package heap

import "fmt"

// MaxPQ define a estrutura da fila de prioridade máxima.
type MaxPQ struct {
	heap []int // Array para armazenar os elementos do heap.
	n    int   // Número de elementos atualmente no heap.
}

// NewMaxPQ inicializa o heap com uma capacidade específica.
func NewMaxPQ(capacity int) *MaxPQ {
	// O índice 0 não é usado, então a capacidade é aumentada em 1.
	return &MaxPQ{
		heap: make([]int, capacity+1),
		n:    0,
	}
}

// IsEmpty verifica se o heap está vazio.
func (pq *MaxPQ) IsEmpty() bool {
	return pq.n == 0
}

// Size retorna o número de elementos no heap.
func (pq *MaxPQ) Size() int {
	return pq.n
}

// Insert insere um novo elemento no heap.
func (pq *MaxPQ) Insert(x int) {
	// Se o heap estiver cheio, redimensiona para o dobro do seu tamanho atual.
	if pq.n == len(pq.heap)-1 {
		pq.resize(2 * len(pq.heap))
	}

	// Insere o novo elemento na próxima posição disponível.
	pq.n++
	pq.heap[pq.n] = x
	// Ajusta a posição do elemento para manter a propriedade de max heap.
	pq.swim(pq.n)
}

// swim é um método auxiliar para manter a propriedade de max heap após inserção.
func (pq *MaxPQ) swim(k int) {
	// Enquanto o elemento for maior que seu pai, troque-os de lugar.
	for k > 1 && pq.heap[k/2] < pq.heap[k] {
		pq.heap[k], pq.heap[k/2] = pq.heap[k/2], pq.heap[k]
		k = k / 2
	}
}

// resize redimensiona o array do heap.
func (pq *MaxPQ) resize(capacity int) {
	// Cria um novo array com a capacidade especificada.
	temp := make([]int, capacity)
	// Copia os elementos do heap antigo para o novo.
	copy(temp, pq.heap)
	pq.heap = temp
}

// PrintMaxHeap imprime os elementos do heap.
func (pq *MaxPQ) PrintMaxHeap() {
	// Itera sobre os elementos do heap e os imprime.
	for i := 1; i <= pq.n; i++ {
		fmt.Printf("%d ", pq.heap[i])
	}
	fmt.Println() // Adiciona uma nova linha ao final da impressão.
}

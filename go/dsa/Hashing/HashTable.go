package hashing

import "errors"

// HashNode define a estrutura de cada nó na lista encadeada.
type HashNode struct {
	Key   int
	Value string
	Next  *HashNode
}

// HashTable define a estrutura da tabela hash.
type HashTable struct {
	buckets      []*HashNode // Array de listas encadeadas que armazenam os nós hash.
	numOfBuckets int         // Número total de buckets na tabela hash.
	size         int         // Contador do número de pares chave-valor presentes na tabela hash.
}

// NewHashTable inicializa a tabela hash com uma capacidade específica.
func NewHashTable(capacity int) *HashTable {
	return &HashTable{
		numOfBuckets: capacity,                // Define o número de buckets com a capacidade fornecida.
		buckets:      make([]*HashNode, capacity), // Inicializa o array de buckets.
	}
}

// Size retorna o número de pares chave-valor na tabela hash.
func (ht *HashTable) Size() int {
	return ht.size
}

// IsEmpty verifica se a tabela hash está vazia.
func (ht *HashTable) IsEmpty() bool {
	return ht.size == 0
}

// Put adiciona um novo par chave-valor ou atualiza um existente.
func (ht *HashTable) Put(key int, value string) error {
	// Verifica se o valor é nulo.
	if value == "" {
		return errors.New("value cannot be null")
	}

	// Calcula o índice do bucket baseado na chave.
	bucketIndex := ht.getBucketIndex(key)
	head := ht.buckets[bucketIndex]

	// Procura por uma chave existente para atualizar o valor.
	for head != nil {
		if head.Key == key {
			head.Value = value
			return nil
		}
		head = head.Next
	}

	// Insere um novo nó na cabeça da lista se a chave não foi encontrada.
	ht.size++
	node := &HashNode{
		Key:   key,
		Value: value,
		Next:  ht.buckets[bucketIndex],
	}
	ht.buckets[bucketIndex] = node
	return nil
}

// getBucketIndex calcula o índice do bucket com base no hash da chave.
func (ht *HashTable) getBucketIndex(key int) int {
	return abs(key % ht.numOfBuckets)
}

// Get recupera o valor associado a uma chave específica.
func (ht *HashTable) Get(key int) string {
	// Calcula o índice do bucket baseado na chave.
	bucketIndex := ht.getBucketIndex(key)
	head := ht.buckets[bucketIndex]

	// Procura pelo nó com a chave fornecida.
	for head != nil {
		if head.Key == key {
			return head.Value
		}
		head = head.Next
	}
	return ""
}

// Remove remove um par chave-valor baseado na chave fornecida.
func (ht *HashTable) Remove(key int) string {
	// Calcula o índice do bucket baseado na chave.
	bucketIndex := ht.getBucketIndex(key)
	head := ht.buckets[bucketIndex]
	var previous *HashNode

	// Procura pelo nó com a chave fornecida.
	for head != nil {
		if head.Key == key {
			break
		}
		previous = head
		head = head.Next
	}

	// Se a chave não for encontrada, retorna uma string vazia.
	if head == nil {
		return ""
	}

	// Reduz o tamanho da tabela hash.
	ht.size--

	// Remove o nó da lista encadeada.
	if previous != nil {
		previous.Next = head.Next
	} else {
		ht.buckets[bucketIndex] = head.Next
	}
	return head.Value
}

// abs retorna o valor absoluto de um número inteiro.
func abs(x int) int {
	if x < 0 {
		return -x
	}
	return x
}

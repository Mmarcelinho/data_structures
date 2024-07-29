package adjmatrixgraph

import (
	"fmt"
	"strings"
)

// Estrutura que representa o grafo
type AdjMatrixGraph struct {
	vertices  int     // Número de vértices no grafo
	edges     int     // Número de arestas no grafo
	adjMatrix [][]int // Matriz de adjacências: uma matriz 2D onde adjMatrix[u][v] == 1 indica uma aresta entre u e v
}

// Função que cria um novo grafo com um número específico de nós
func NewAdjMatrixGraph(nodes int) *AdjMatrixGraph {
	g := &AdjMatrixGraph{
		vertices:  nodes,                  // Define o número de vértices
		adjMatrix: make([][]int, nodes),   // Inicializa a matriz de adjacências
	}
	for i := range g.adjMatrix {
		g.adjMatrix[i] = make([]int, nodes) // Inicializa cada linha da matriz
	}
	return g
}

// Método para adicionar uma aresta entre dois vértices u e v
func (g *AdjMatrixGraph) AddEdge(u, v int) {
	g.adjMatrix[u][v] = 1 // Marca a presença de uma aresta de u para v
	g.adjMatrix[v][u] = 1 // Marca a presença de uma aresta de v para u (grafo não-direcionado)
	g.edges++             // Incrementa o contador de arestas
}

// Método para representar o grafo como uma string
func (g *AdjMatrixGraph) String() string {
	var sb strings.Builder
	sb.WriteString(fmt.Sprintf("%d vertices, %d edges\n", g.vertices, g.edges)) // Adiciona informações sobre o número de vértices e arestas
	for v := 0; v < g.vertices; v++ {
		sb.WriteString(fmt.Sprintf("%d: ", v)) // Adiciona o vértice atual
		for _, w := range g.adjMatrix[v] {
			sb.WriteString(fmt.Sprintf("%d ", w)) // Adiciona os valores da matriz de adjacências
		}
		sb.WriteString("\n") // Nova linha para o próximo vértice
	}
	return sb.String()
}

package adjlistgraph

import (
	"fmt"
	"strings"
)

// Estrutura que representa o grafo
type AdjListGraph struct {
	adj      [][]int // Lista de adjacências: cada índice representa um vértice e contém um slice dos vértices adjacentes
	vertices int     // Número de vértices no grafo
	edges    int     // Número de arestas no grafo
}

// Função que cria um novo grafo com um número específico de nós
func NewAdjListGraph(nodes int) *AdjListGraph {
	g := &AdjListGraph{
		vertices: nodes,          // Define o número de vértices
		adj:      make([][]int, nodes), // Inicializa a lista de adjacências
	}
	return g
}

// Método para adicionar uma aresta entre dois vértices u e v
func (g *AdjListGraph) AddEdge(u, v int) {
	g.adj[u] = append(g.adj[u], v) // Adiciona v na lista de adjacência de u
	g.adj[v] = append(g.adj[v], u) // Adiciona u na lista de adjacência de v (grafo não-direcionado)
	g.edges++                      // Incrementa o contador de arestas
}

// Método para representar o grafo como uma string
func (g *AdjListGraph) String() string {
	var sb strings.Builder
	sb.WriteString(fmt.Sprintf("%d vertices, %d edges\n", g.vertices, g.edges)) // Adiciona informações sobre o número de vértices e arestas
	for v := 0; v < g.vertices; v++ {
		sb.WriteString((fmt.Sprintf("%d: ", v))) // Adiciona o vértice atual
		for _, w := range g.adj[v] {
			sb.WriteString(fmt.Sprintf("%d ", w)) // Adiciona os vértices adjacentes
		}
		sb.WriteString("\n") // Nova linha para o próximo vértice
	}
	return sb.String()
}

// Método para realizar a busca em largura (BFS) a partir de um vértice inicial
func (g *AdjListGraph) Bfs(start int) {
	visited := make([]bool, g.vertices) // Slice para acompanhar quais vértices foram visitados
	queue := []int{start}               // Fila inicializa com o vértice de partida
	visited[start] = true               // Marca o vértice inicial como visitado
	
	for len(queue) > 0 {
		u := queue[0]      // Remove o primeiro elemento da fila
		queue = queue[1:]  // Atualiza a fila
		fmt.Printf("%d ", u) // Imprime o vértice visitado

		for _, v := range g.adj[u] {
			if !visited[v] {   // Se o vértice adjacente não foi visitado
				visited[v] = true        // Marca como visitado
				queue = append(queue, v) // Adiciona à fila
			}
		}
	}
	fmt.Println()
}

// Método para realizar a busca em profundidade (DFS) para todo o grafo
func (g *AdjListGraph) Dfs() {
	visited := make([]bool, g.vertices) // Slice para acompanhar quais vértices foram visitados
	for v := 0; v < g.vertices; v++ {
		if !visited[v] {     // Se o vértice não foi visitado
			g.dfs(v, visited) // Realiza a DFS a partir dele
		}
	}
	fmt.Println()
}

// Função auxiliar para a DFS, que visita os vértices recursivamente
func (g *AdjListGraph) dfs(v int, visited []bool) {
	visited[v] = true            // Marca o vértice como visitado
	fmt.Printf("%d ", v)         // Imprime o vértice visitado
	for _, w := range g.adj[v] {
		if !visited[w] {          // Se o vértice adjacente não foi visitado
			g.dfs(w, visited)   // Chama a DFS recursivamente
		}
	}
}

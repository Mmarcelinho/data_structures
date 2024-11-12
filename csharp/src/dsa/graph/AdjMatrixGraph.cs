using System.Text;

namespace dsa.graph;

public class AdjMatrixGraph
{
    // static void Main()
    // {
    //     AdjMatrixGraph g = new(4); // Cria um grafo com 4 vértices.
    //     g.addEdge(0, 1); // Adiciona aresta entre o vértice 0 e 1.
    //     g.addEdge(1, 2); // Adiciona aresta entre o vértice 1 e 2.
    //     g.addEdge(2, 3); // Adiciona aresta entre o vértice 2 e 3.
    //     g.addEdge(3, 0); // Adiciona aresta entre o vértice 3 e 0 (fechando um ciclo).
    //     Console.WriteLine(g); // Imprime a representação em string do grafo.
    // }

    private int _vertices; // Número de vértices no grafo.
    private int _edges; // Número de arestas no grafo.
    private int[][] _adjMatrix; // Matriz de adjacência para representar as arestas.

    public AdjMatrixGraph(int nodes)
    {
        _vertices = nodes;
        _edges = 0;
        _adjMatrix = new int[nodes][]; // Inicializa a matriz de adjacência.
        for (int i = 0; i < nodes; i++)
        {
            _adjMatrix[i] = new int[nodes]; // Inicializa cada linha da matriz.
        }
    }

    public void addEdge(int u, int v)
    {
        _adjMatrix[u][v] = 1; // Define o valor na matriz para 1, indicando uma aresta entre u e v.
        _adjMatrix[v][u] = 1; // Como o grafo é não direcionado, define o valor simétrico.
        _edges++; // Incrementa o contador de arestas.
    }

    // Sobrescreve o método ToString para fornecer uma representação textual do grafo.
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append($"{_vertices} vertices, {_edges} edges\n");
        for (int v = 0; v < _vertices; v++)
        {
            sb.Append($"{v}: "); // Inicia a linha para o vértice v.
            foreach (int w in _adjMatrix[v]) // Itera sobre a linha da matriz para o vértice v.
            {
                sb.Append($"{w} "); // Adiciona cada valor da matriz na linha (0 ou 1).
            }
            sb.Append("\n"); // Adiciona uma quebra de linha após cada linha da matriz.
        }
        return sb.ToString();
    }
}

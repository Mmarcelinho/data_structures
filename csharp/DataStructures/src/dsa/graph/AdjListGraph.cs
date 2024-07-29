using System.Text;

namespace dsa.graph;

    public class AdjListGraph
    {
        // static void Main()
        // {
        //     AdjListGraph g = new AdjListGraph(5);
        //     g.AddEdge(0, 1);
        //     g.AddEdge(1, 2);
        //     g.AddEdge(2, 3);
        //     g.AddEdge(3, 0);

        //     Console.WriteLine(g);
        //     g.Dfs();
        // }

        // Array de listas para armazenar a lista de adjacência de cada vértice
        private List<int>[] _adj;

        // Número total de vértices no grafo 
        private int _vertices;

        // Número total de arestas no grafo.
        private int _edges;

        // Construtor para inicializar o grafo com um determinado número de vértices
        public AdjListGraph(int nodes)
        {
            _vertices = nodes;
            _edges = 0;
            _adj = new List<int>[nodes];
            for(int v = 0; v < nodes; v++)
            {
                _adj[v] = new List<int>();
            }
        }

        // Método para adicionar uma aresta não direcionada entre os vértices u e v.
        public void AddEdge(int u, int v)
        {
            _adj[u].Add(v);
            _adj[v].Add(u);
            _edges++;
        }

    // Sobrescreve o método ToString para fornecer uma representação uma representação textual do grafo.
    public override string ToString()
    {
        StringBuilder sb = new();
        sb.Append($"{_vertices} vertices, {_edges} edges\n");
        for(int v = 0; v < _vertices; v++)
        {
            sb.Append($"{v}: ");
            foreach (int w in _adj[v])
            {
                sb.Append($"{w} ");
            }
            sb.Append("\n");
        }
        return sb.ToString();
    }

    // Implementa a busca em largura (BFS) a partir de um vértice inicial s.
    public void Bfs(int start)
    {
        bool[] visited = new bool[_vertices];
        Queue<int> queue = new Queue<int>();
        visited[start] = true;
        queue.Enqueue(start);

        while (queue.Count > 0)
        {
            int u = queue.Dequeue();
            Console.Write($"{u} ");

            foreach (int v in _adj[u])
            {
                if (!visited[v])
                {
                    visited[v] = true;
                    queue.Enqueue(v);
                }
            }
        }
    }

    // Implementa a busca em profundidade (DFS) para todo o grafo
    public void Dfs()
    {
        bool[] visited = new bool[_vertices];
        for(int v = 0; v < _vertices; v++)
        {
            if(!visited[v])
            Dfs(v, visited);
        }
    }

    // Método privado recursivo para executar DFS a partir de um vértice específico
    private void Dfs(int v, bool[] visited)
    {
        visited[v] = true;
        Console.Write($"{v} ");
        foreach (int w in _adj[v])
        {
            if(!visited[w])
            Dfs(w, visited);
        }
    }
    }

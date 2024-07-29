namespace dsa.heap;

public class MaxPQ
{
    // static void Main()
    // {
    //     // Cria uma instância da fila de prioridade com capacidade inicial de 3.
    //     MaxPQ pq = new(3);
    //     // Insere elementos na fila.
    //     pq.insert(5);
    //     pq.insert(2);
    //     pq.insert(6);
    //     pq.insert(1);
    //     pq.insert(3);

    //     // Exibe o tamanho atual da fila.
    //     Console.WriteLine(pq.size());
    //     // Imprime os elementos do heap em ordem.
    //     pq.printMaxHeap();
    // }

    // Array para armazenar os elementos do heap.
    private int[] heap;
    // Número de elementos atualmente no heap.
    private int n;

    // Construtor para inicializar o heap com uma capacidade específica.
    public MaxPQ(int capacity)
    {
        // O índice 0 não é usado, então a capacidade é aumentada em 1.
        heap = new int[capacity + 1];
        n = 0;
    }

    // Método para verificar se o heap está vazio.
    public bool isEmpty()
    {
        return n == 0;
    }

    // Método para obter o número de elementos no heap.
    public int size()
    {
        return n;
    }

    // Método para inserir um novo elemento no heap.
    public void insert(int x)
    {
        // Se o heap estiver cheio, redimensiona para o dobro do seu tamanho atual.
        if (n == heap.Length - 1)
        {
            resize(2 * heap.Length);
        }
        // Insere o novo elemento na próxima posição disponível.
        n++;
        heap[n] = x;
        // Ajusta a posição do elemento para manter a propriedade de max heap.
        swim(n);
    }

    // Método auxiliar para manter a propriedade de max heap após inserção.
    private void swim(int k)
    {
        // Enquanto o elemento for maior que seu pai, troque-os de lugar.
        while (k > 1 && heap[k / 2] < heap[k])
        {
            int temp = heap[k];
            heap[k] = heap[k / 2];
            heap[k / 2] = temp;
            k = k / 2;
        }
    }

    // Método para redimensionar o array do heap.
    private void resize(int capacity)
    {
        // Cria um novo array com a capacidade especificada.
        int[] temp = new int[capacity];
        // Copia os elementos do heap antigo para o novo.
        for (int i = 0; i < heap.Length; i++)
        {
            temp[i] = heap[i];
        }
        heap = temp;
    }

    // Método para imprimir os elementos do heap.
    public void printMaxHeap()
    {
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(heap[i] + " ");
        }
    }
}

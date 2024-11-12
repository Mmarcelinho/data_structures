namespace dsa.queue;

public class Queue
{

    // static void Main()
    // {

    //     Queue queue = new();
        
    //     queue.enqueue(10);
    //     queue.enqueue(15);
    //     queue.enqueue(20);

    //     queue.print();

    //     queue.dequeue();
    //     queue.dequeue();

    //     queue.print();
    // }

    public class ListNode
    {
        public int data; // O valor armazenado no nó.
        public ListNode next; // O próximo nó na lista.

        // O construtor inicializa o nó com um valor.
        public ListNode(int data)
        {
            this.data = data;
            this.next = null;
        }
    }

    ListNode front; // O primeiro elemento da fila.
    ListNode rear; // O último elemento da fila.
    int _length; // O número de elementos na fila.

    // O construtor inicializa uma fila vazia.
    public Queue()
    {
        front = null;
        rear = null;
        _length = 0;
    }

    // Retorna o número de elementos na fila.
    public int length() => _length;

    // Verifica se a fila está vazia.
    public bool isEmpty() => _length == 0;

    // Adiciona um elemento ao final da fila.
    public void enqueue(int data)
    {
        ListNode temp = new(data);
        if (isEmpty())
            front = temp;
        else
            rear.next = temp;

        rear = temp;
        _length++;
    }

    // Remove e retorna o primeiro elemento da fila.
    public int dequeue()
    {
        if (isEmpty())
            throw new Exception("Queue is already empty");

        int result = front.data;
        front = front.next;
        if (front == null)
            rear = null;

        _length--;
        return result;
    }

    // Imprime todos os elementos da fila.
    public void print()
    {
        if (isEmpty())
            return;

        ListNode current = front;
        while (current != null)
        {
            Console.Write(current.data + " --> ");
            current = current.next;
        }
        Console.WriteLine("null");
    }
}

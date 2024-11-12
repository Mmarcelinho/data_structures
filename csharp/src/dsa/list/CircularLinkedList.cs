namespace dsa.list;

public class CircularLinkedList
{
    // static void Main()
    // {
    //     CircularLinkedList cll = new();
    //     cll.createCircularLinkedList();
    //     cll.display();
    // }

    // A classe CircularLinkedList tem dois campos: 'last' que aponta para o último nó da lista e '_length' que armazena o tamanho da lista
    public ListNode last;
    public int _length;

    // A classe ListNode representa um nó na lista. Cada nó tem um campo 'data' que armazena o valor do nó e um campo 'next' que aponta para o próximo nó na lista
    public class ListNode
    {
        public ListNode next;
        public int data;

        // Construtor da classe ListNode
        public ListNode(int data) => this.data = data;
    }

    // Construtor da classe CircularLinkedList
    public CircularLinkedList()
    {
        last = null;
        this._length = 0;
    }

    // Método para obter o tamanho da lista
    public int length() => _length;

    // Método para verificar se a lista está vazia
    public bool isEmpty() => _length == 0;

    // Método para criar uma lista circularmente encadeada com quatro nós
    public void createCircularLinkedList()
    {
        ListNode first = new ListNode(1);
        ListNode second = new ListNode(5);
        ListNode third = new ListNode(10);
        ListNode fourth = new ListNode(15);

        first.next = second;
        second.next = third;
        third.next = fourth;
        fourth.next = first;

        last = fourth;
    }

    // Método para exibir a lista
    public void display()
    {
        if (last == null)
            return;

        ListNode first = last.next;
        while (first != last)
        {
            Console.Write(first.data + " --> ");
            first = first.next;
        }
        Console.WriteLine(first.data);
    }

    // Método para inserir um nó no início da lista
    public void insertFirst(int data)
    {
        ListNode temp = new ListNode(data);
        if (last == null)
            last = temp;

        else
            temp.next = last.next;

        last.next = temp;
        _length++;
    }

    // Método para inserir um nó no final da lista
    public void insertLast(int data)
    {
        ListNode temp = new ListNode(data);
        if (last == null)
        {
            last = temp;
            last.next = last;
        }
        else
        {
            temp.next = last.next;
            last.next = temp;
            last = temp;
        }
        _length++;
    }

    // Método para remover o primeiro nó da lista
    public ListNode removeFirst()
    {
        if (isEmpty())
            throw new NullReferenceException("Circular Singly Linked List is already empty");

        ListNode temp = last.next;
        if (last.next == last)
            last = null;

        else
            last.next = temp.next;

        temp.next = null;
        _length--;
        return temp;
    }
}

namespace dsa.stack.impl.list;

public class Stack
{
    // static void Main()
    // {
    //     Stack stack = new();

    //     stack.push(10);
    //     stack.push(15);
    //     stack.push(20);

    //     Console.WriteLine(stack.peek());
    //     stack.pop();

    //     Console.WriteLine(stack.peek());
    //     stack.pop();

    //     Console.WriteLine(stack.peek());
    //     stack.pop();

    //     // Tenta remover um elemento de uma pilha vazia, o que causará uma exceção
    //     try
    //     {
    //         stack.pop();
    //     }
    //     catch (Exception e)
    //     {
    //         Console.WriteLine(e.Message);
    //     }
    // }

    // A classe Stack tem duas propriedades: top e _length.
    // 'top' é um nó que aponta para o topo da pilha.
    // '_length' armazena o número de elementos na pilha.
    public ListNode top;
    public int _length;

    // A classe ListNode representa um nó na lista encadeada.
    public class ListNode
    {
        // Cada nó tem um valor de 'data' e um ponteiro 'next' para o próximo nó.
        public int data;
        public ListNode next;

        // O construtor da classe ListNode inicializa o valor de 'data' e define 'next' como null.
        public ListNode(int data)
        {
            this.data = data;
            this.next = null;
        }
    }

    // O construtor da classe Stack inicializa 'top' como null e '_length' como 0.
    public Stack()
    {
        top = null;
        _length = 0;
    }

    // O método 'length' retorna o número de elementos na pilha.
    public int length() => _length;

    // O método 'isEmpty' verifica se a pilha está vazia.
    public bool isEmpty() => _length == 0;

    // O método 'push' adiciona um novo elemento ao topo da pilha.
    public void push(int data)
    {
        // Cria um novo nó com o valor de 'data'.
        ListNode temp = new(data);
        // O novo nó aponta para o nó atual no topo da pilha.
        temp.next = top;
        // O novo nó se torna o topo da pilha.
        top = temp;
        // Incrementa o tamanho da pilha.
        _length++;
    }

    // O método 'pop' remove e retorna o elemento do topo da pilha.
    public int pop()
    {
        // Se a pilha estiver vazia, lança uma exceção.
        if (isEmpty())
            throw new Exception("Stack empty");

        // Armazena o valor do nó do topo.
        int result = top.data;
        // Move o topo para o próximo nó na pilha.
        top = top.next;
        // Decrementa o tamanho da pilha.
        _length--;
        // Retorna o valor do nó removido.
        return result;
    }

    // O método 'peek' retorna o valor do elemento do topo da pilha sem removê-lo.
    public int peek()
    {
        // Se a pilha estiver vazia, lança uma exceção.
        if (isEmpty())
            throw new Exception();

        // Retorna o valor do nó do topo.
        return top.data;
    }
}

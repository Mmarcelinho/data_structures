namespace dsa.stack.impl.array;

public class Stack
{
    // static void Main()
    // {
    //     Stack stack = new(3);

    //     stack.push(10);
    //     stack.push(15);
    //     stack.push(20);

    //     Console.WriteLine(stack.peek());
    //     stack.pop();

    //     Console.WriteLine(stack.peek());
    //     stack.pop();

    //     Console.WriteLine(stack.peek());
    //     stack.pop();

    //     Tenta remover um elemento de uma pilha vazia, o que causará uma exceção
    //     try
    //     {
    //         stack.pop();
    //     }
    //     catch (Exception e)
    //     {
    //         Console.WriteLine(e.Message);
    //     }
    // }

    // Variáveis de instância para armazenar o topo da pilha e o array que representa a pilha
    public int top;
    public int[] arr;

    // Construtor que inicializa o topo da pilha e o array com a capacidade especificada
    public Stack(int capacity)
    {
        top = -1;
        arr = new int[capacity];
    }

    // Construtor sem argumentos que chama o construtor acima com capacidade 10
    public Stack() : this(10) { }

    // Método que retorna o tamanho da pilha
    public int size() => top + 1;

    // Método que verifica se a pilha está vazia
    public bool isEmpty() => top < 0;

    // Método que verifica se a pilha está cheia
    public bool isFull() => arr.Length == size();

    // Método que empilha um novo elemento na pilha
    public void push(int data)
    {
        // Se a pilha estiver cheia, lança uma exceção
        if (isFull())
            throw new Exception("Stack is full !!!");

        // Incrementa o topo e adiciona o novo elemento
        top++;
        arr[top] = data;
    }

    // Método que remove e retorna o elemento do topo da pilha
    public int pop()
    {
        // Se a pilha estiver vazia, lança uma exceção
        if (isEmpty())
            throw new Exception("Stack is empty !!!");

        // Armazena o elemento do topo, decrementa o topo e retorna o elemento
        int result = arr[top];
        top--;
        return result;
    }

    // Método que retorna o elemento do topo da pilha sem removê-lo
    public int peek()
    {
        // Se a pilha estiver vazia, lança uma exceção
        if (isEmpty())
            throw new Exception("Stack is empty !!!");

        // Retorna o elemento do topo
        return arr[top];
    }
}

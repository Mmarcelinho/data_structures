namespace dsa.list;

public class SinglyLinkedList
{
    // static void Main()
    // {
    //     SinglyLinkedList sll1 = new();
    //     sll1.insertLast(1);
    //     sll1.insertLast(4);
    //     sll1.insertLast(8);

    //     SinglyLinkedList sll2 = new();

    //     sll2.insertLast(3);
    //     sll2.insertLast(5);
    //     sll2.insertLast(8);
    //     sll2.insertLast(9);
    //     sll2.insertLast(14);
    //     sll2.insertLast(18);

    //     sll2.display();
    //     sll2.display();

    //     SinglyLinkedList result = new();
    //     result.head = merge(sll1.head, sll2.head);

    //     result.display();
    // }

    // Variável head do tipo ListNode
    public ListNode head;

    public class ListNode
    {
        // Variável para armazenar o valor do nó
        public int data;

        // Variável para referenciar o próximo nó na lista
        public ListNode next;

        public ListNode(int data)
        {
            // Atribui o valor passado para a variável data
            this.data = data;

            // Inicializa o próximo nó como null
            this.next = null;
        }
    }

    public void display()
    {
        // Inicializa o nó atual como o cabeçalho da lista
        ListNode current = head;

        // Loop para percorrer a lista
        while (current != null)
        {
            // Imprime o valor do nó atual
            Console.Write(current.data + "--> ");

            // Move para o próximo nó
            current = current.next;
        }

        // Imprime null no final da lista
        Console.Write("null");


        Console.WriteLine();
    }

    // Método para obter o comprimento da lista
    public int length()
    {
        // Se a lista estiver vazia, retorna 0
        if (head == null)
        {
            return 0;
        }

        // Inicializa o contador de nós
        int count = 0;

        // Inicializa o nó atual como o cabeçalho da lista
        ListNode current = head;

        // Loop para percorrer a lista
        while (current != null)
        {
            // Incrementa o contador
            count++;

            // Move para o próximo nó
            current = current.next;
        }

        // Retorna o número de nós na lista
        return count;
    }


    // Método para inserir um nó no início da lista
    public void insertFirst(int value)
    {
        // Cria um novo nó com o valor fornecido
        ListNode newNode = new ListNode(value);

        // O próximo do novo nó aponta para o atual cabeçalho da lista
        newNode.next = head;

        // O novo nó se torna o cabeçalho da lista
        head = newNode;
    }

    // Método para inserir um nó em uma posição específica na lista
    public void insert(int position, int value)
    {
        // Cria um novo nó com o valor fornecido
        ListNode node = new ListNode(value);

        // Se a posição é 1, insere no início da lista
        if (position == 1)
        {
            node.next = head;
            head = node;
        }
        else
        {
            // Inicializa o nó anterior como o cabeçalho da lista
            ListNode previous = head;
            int count = 1;

            // Loop para encontrar o nó na posição anterior à posição desejada
            while (count < position - 1)
            {
                previous = previous.next;
                count++;
            }

            // O nó atual é o próximo do nó anterior
            ListNode current = previous.next;

            // O próximo do nó anterior aponta para o novo nó
            previous.next = node;

            // O próximo do novo nó aponta para o nó atual
            node.next = current;
        }
    }

    // Método para inserir um nó no final da lista
    public void insertLast(int value)
    {
        // Cria um novo nó com o valor fornecido
        ListNode newNode = new ListNode(value);

        // Se a lista está vazia, o novo nó se torna o cabeçalho da lista
        if (head == null)
        {
            head = newNode;
            return;
        }

        // Inicializa o nó atual como o cabeçalho da lista
        ListNode current = head;

        // Loop para encontrar o último nó da lista
        while (null != current.next)
        {
            current = current.next;
        }

        // O próximo do último nó aponta para o novo nó
        current.next = newNode;
    }

    // Método para remover o primeiro nó da lista
    public ListNode deleteFirst()
    {
        // Se a lista está vazia, retorna null
        if (head == null)
            return null;

        // O nó temporário aponta para o cabeçalho da lista
        ListNode temp = head;

        // O cabeçalho da lista se torna o próximo do nó temporário
        head = head.next;

        // O próximo do nó temporário se torna null
        temp.next = null;

        // Retorna o nó removido
        return temp;
    }


    // Método para remover um nó em uma posição específica na lista
    public void delete(int position)
    {
        // Se a posição é 1, remove o primeiro nó da lista
        if (position == 1)
            head = head.next;
        else
        {
            // Inicializa o nó anterior como o cabeçalho da lista
            ListNode previous = head;
            int count = 1;

            // Loop para encontrar o nó na posição anterior à posição desejada
            while (count < position - 1)
            {
                previous = previous.next;
                count++;
            }

            // O nó atual é o próximo do nó anterior
            ListNode current = previous.next;

            // O próximo do nó anterior aponta para o próximo do nó atual
            previous.next = current.next;
        }
    }

    // Método para remover o último nó da lista
    public ListNode deleteLast()
    {
        // Se a lista está vazia, retorna o cabeçalho da lista
        if (head == null)
            return head;

        // Se a lista tem apenas um nó, remove o nó e retorna
        if (head.next == null)
        {
            ListNode temp = head;
            head = head.next;
            return temp;
        }

        // Inicializa o nó atual como o cabeçalho da lista
        ListNode current = head;
        ListNode previous = null;

        // Loop para encontrar o último nó da lista
        while (current.next != null)
        {
            previous = current;
            current = current.next;
        }

        // O próximo do nó anterior se torna null
        previous.next = null;

        // Retorna o último nó
        return current;
    }

    // Método para encontrar um valor na lista
    public bool find(int searchKey)
    {
        // Se a lista está vazia, retorna false
        if (head == null)
            return false;

        // Inicializa o nó atual como o cabeçalho da lista
        ListNode current = head;

        // Loop para percorrer a lista
        while (current != null)
        {
            // Se o valor do nó atual é igual à chave de pesquisa, retorna true
            if (current.data == searchKey)
                return true;

            // Move para o próximo nó
            current = current.next;
        }

        // Se a chave de pesquisa não foi encontrada, retorna false
        return false;
    }

    // Método para reverter a lista
    public ListNode reverse()
    {
        // Se a lista está vazia, retorna null
        if (head == null)
            return null;

        // Inicializa o nó atual como o cabeçalho da lista
        ListNode current = head;
        ListNode previous = null;
        ListNode next = null;

        // Loop para percorrer a lista
        while (current != null)
        {
            // O próximo nó é o próximo do nó atual
            next = current.next;

            // O próximo do nó atual se torna o nó anterior
            current.next = previous;

            // O nó anterior se torna o nó atual
            previous = current;

            // O nó atual se torna o próximo nó
            current = next;
        }

        // Retorna o nó anterior que é agora o cabeçalho da lista revertida
        return previous;
    }


    // Método para obter o nó do meio da lista
    public ListNode getMiddleNode()
    {
        // Se a lista está vazia, retorna null
        if (head == null)
            return null;

        // Inicializa dois ponteiros, um se move duas vezes mais rápido que o outro
        ListNode slowPtr = head;
        ListNode fastPtr = head;

        // Enquanto o ponteiro rápido não chegar ao final da lista
        while (fastPtr != null && fastPtr.next != null)
        {
            // Move o ponteiro lento um passo
            slowPtr = slowPtr.next;

            // Move o ponteiro rápido dois passos
            fastPtr = fastPtr.next.next;
        }

        // Quando o ponteiro rápido chega ao final da lista, o ponteiro lento está no meio
        return slowPtr;
    }

    // Método para obter o n-ésimo nó a partir do final da lista
    public ListNode getNthNodeFromEnd(int n)
    {
        // Se a lista está vazia, retorna null
        if (head == null)
            return null;

        // Se n é menor ou igual a 0, lança uma exceção
        if (n <= 0)
            throw new InvalidDataException($"Invalid value: n = {n}");

        // Inicializa dois ponteiros
        ListNode mainPtr = head;
        ListNode refPtr = head;

        int count = 0;

        // Move o ponteiro de referência n passos à frente
        while (count < n)
        {
            // Se o ponteiro de referência chegar ao final da lista antes de mover n passos, lança uma exceção
            if (refPtr == null)
                throw new InvalidDataException($"Invalid value: n = {n}");

            refPtr = refPtr.next;
            count++;
        }

        // Move ambos os ponteiros até que o ponteiro de referência chegue ao final da lista
        while (refPtr != null)
        {
            refPtr = refPtr.next;
            mainPtr = mainPtr.next;
        }

        // Quando o ponteiro de referência chega ao final da lista, o ponteiro principal está no n-ésimo nó a partir do final
        return mainPtr;
    }

    // Método para inserir um nó em uma lista ordenada
    public ListNode insertInSortedList(int value)
    {
        // Cria um novo nó com o valor fornecido
        ListNode newNode = new ListNode(value);

        // Se a lista está vazia, retorna o novo nó
        if (head == null)
            return newNode;

        // Inicializa dois ponteiros
        ListNode current = head;
        ListNode temp = null;

        // Encontra a posição para inserir o novo nó
        while (current != null && current.data < newNode.data)
        {
            temp = current;
            current = current.next;
        }

        // Insere o novo nó na posição correta
        newNode.next = current;
        temp.next = newNode;

        // Retorna o cabeçalho da lista
        return head;
    }

    // Método para remover um nó com uma chave específica
    public void deleteNode(int key)
    {
        // Inicializa dois ponteiros
        ListNode current = head;
        ListNode temp = null;

        // Se a chave está no primeiro nó, remove o primeiro nó
        if (current != null && current.data == key)
        {
            head = current.next;
            return;
        }

        // Encontra o nó com a chave
        while (current != null && current.data != key)
        {
            temp = current;
            current = current.next;
        }

        // Se a chave não foi encontrada, retorna
        if (current == null)
            return;

        // Remove o nó com a chave
        temp.next = current.next;
    }

    // Método para verificar se a lista contém um loop
    public bool containsLoop()
    {
        // Inicializa dois ponteiros, um se move duas vezes mais rápido que o outro
        ListNode fastPtr = head;
        ListNode slowPtr = head;

        // Enquanto o ponteiro rápido não chegar ao final da lista
        while (fastPtr != null && fastPtr.next != null)
        {
            // Move o ponteiro lento um passo
            slowPtr = slowPtr.next;

            // Move o ponteiro rápido dois passos
            fastPtr = fastPtr.next.next;

            // Se os dois ponteiros se encontram, a lista contém um loop
            if (fastPtr == slowPtr)
                return true;
        }

        // Se o ponteiro rápido chega ao final da lista, a lista não contém um loop
        return false;
    }

    // Método para encontrar o nó de início de um loop em uma lista
    public ListNode startNodeInALoop()
    {
        // Inicializa dois ponteiros, um se move duas vezes mais rápido que o outro
        ListNode fastPtr = head;
        ListNode slowPtr = head;

        // Enquanto o ponteiro rápido não chegar ao final da lista
        while (fastPtr != null && fastPtr.next != null)
        {
            // Move o ponteiro lento um passo
            slowPtr = slowPtr.next;

            // Move o ponteiro rápido dois passos
            fastPtr = fastPtr.next.next;

            // Se os dois ponteiros se encontram, a lista contém um loop
            if (fastPtr == slowPtr)
                // Retorna o nó de início do loop
                return getStartingNode(slowPtr);
        }

        // Se o ponteiro rápido chega ao final da lista, a lista não contém um loop
        return null;
    }

    // Método para encontrar o nó de início de um loop
    public ListNode getStartingNode(ListNode slowPtr)
    {
        // Inicializa um ponteiro temporário no cabeçalho da lista
        ListNode temp = head;

        // Enquanto o ponteiro temporário e o ponteiro lento não se encontram
        while (temp != slowPtr)
        {
            // Move ambos os ponteiros um passo
            temp = temp.next;
            slowPtr = slowPtr.next;
        }

        // Retorna o nó de início do loop
        return temp;
    }

    // Método para remover um loop de uma lista
    public void removeLoop()
    {
        // Inicializa dois ponteiros, um se move duas vezes mais rápido que o outro
        ListNode fastPtr = head;
        ListNode slowPtr = head;

        // Enquanto o ponteiro rápido não chegar ao final da lista
        while (fastPtr != null && fastPtr.next != null)
        {
            // Move o ponteiro lento um passo
            slowPtr = slowPtr.next;

            // Move o ponteiro rápido dois passos
            fastPtr = fastPtr.next.next;

            // Se os dois ponteiros se encontram, a lista contém um loop
            if (fastPtr == slowPtr)
            {
                // Remove o loop
                removeLoop(slowPtr);
                return;
            }
        }
    }

    // Método para remover um loop de uma lista
    public void removeLoop(ListNode slowPtr)
    {
        // Inicializa um ponteiro temporário no cabeçalho da lista
        ListNode temp = head;

        // Enquanto o próximo do ponteiro temporário e o próximo do ponteiro lento não são iguais
        while (temp.next != slowPtr.next)
        {
            // Move ambos os ponteiros um passo
            temp = temp.next;
            slowPtr = slowPtr.next;
        }

        // Faz o próximo do ponteiro lento null para remover o loop
        slowPtr.next = null;
    }


    // Método para criar um loop em uma lista vinculada
    public void createALoopInLinkedList()
    {
        // Cria seis novos nós
        ListNode first = new ListNode(1);
        ListNode second = new ListNode(2);
        ListNode third = new ListNode(3);
        ListNode fourth = new ListNode(4);
        ListNode fifth = new ListNode(5);
        ListNode sixth = new ListNode(6);

        // Conecta os nós para formar uma lista vinculada
        head = first;
        first.next = second;
        second.next = third;
        third.next = fourth;
        fourth.next = fifth;
        fifth.next = sixth;

        // Cria um loop na lista vinculada fazendo o último nó apontar para o terceiro nó
        sixth.next = third;
    }

    // Método para mesclar duas listas vinculadas ordenadas
    public static ListNode merge(ListNode a, ListNode b)
    {
        // Cria um nó dummy para servir como cabeçalho temporário da lista mesclada
        ListNode dummy = new(0);
        ListNode tail = dummy;

        // Loop para percorrer ambas as listas até que uma delas esteja vazia
        while (a != null && b != null)
        {
            // Se o valor do nó a é menor ou igual ao valor do nó b
            if (a.data <= b.data)
            {
                // Adiciona o nó a à lista mesclada
                tail.next = a;

                // Move para o próximo nó na lista a
                a = a.next;
            }
            else
            {
                // Adiciona o nó b à lista mesclada
                tail.next = b;

                // Move para o próximo nó na lista b
                b = b.next;
            }

            // Move para o próximo nó na lista mesclada
            tail = tail.next;
        }

        // Se a lista a está vazia, adiciona o restante da lista b à lista mesclada
        if (a == null)
            tail.next = b;

        // Se a lista b está vazia, adiciona o restante da lista a à lista mesclada
        else
            tail.next = a;

        // Retorna a lista mesclada, ignorando o nó dummy no início
        return dummy.next;
    }

}

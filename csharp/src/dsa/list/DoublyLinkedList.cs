namespace dsa.list
{
    public class DoublyLinkedList
    {
        // static void Main()
        // {
        //     DoublyLinkedList dll = new DoublyLinkedList();
        //     dll.insertEnd(1);
        //     dll.insertEnd(2);
        //     dll.insertEnd(3);

        //     dll.displayForward();

        //     dll.deleteLast();
        //     dll.deleteLast();

        //     dll.displayForward();
        // }
        
        // Ponteiro para o primeiro nó da lista
        private ListNode head;
        // Ponteiro para o último nó da lista
        private ListNode tail;
        // Contador do número de nós na lista
        private int _length;

        // Classe interna para representar um nó na lista
        public class ListNode
        {
            // Dado armazenado no nó
            public int data;
            // Ponteiro para o próximo nó na lista
            public ListNode next;
            // Ponteiro para o nó anterior na lista
            public ListNode previous;

            // Construtor do nó
            public ListNode(int data)
            {
                this.data = data;
            }
        }

        // Construtor da lista duplamente encadeada
        public DoublyLinkedList()
        {
            head = null;
            tail = null;
            _length = 0;
        }

        // Método para verificar se a lista está vazia
        public bool isEmpty() => _length == 0;

        // Método para obter o comprimento da lista
        public int length() => _length;

        // Método para exibir a lista do início ao fim
        public void displayForward()
        {
            if (head == null)
                return;

            ListNode temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " --> ");
                temp = temp.next;
            }
            Console.WriteLine("null");
        }

        // Método para exibir a lista do fim ao início
        public void displayBackward()
        {
            if (tail == null)
                return;

            ListNode temp = tail;
            while (temp != null)
            {
                Console.Write(temp.data + " --> ");
                temp = temp.previous;
            }
            Console.WriteLine("null");
        }

        // Método para inserir um nó no início da lista
        public void insertFirst(int value)
        {
            ListNode newNode = new ListNode(value);
            if (isEmpty())
            {
                tail = newNode;
            }
            else
            {
                head.previous = newNode;
            }
            newNode.next = head;
            head = newNode;
            _length++;
        }

        // Método para inserir um nó no fim da lista
        public void insertEnd(int value)
        {
            ListNode newNode = new ListNode(value);
            if (isEmpty())
            {
                head = newNode;
            }
            else
            {
                tail.next = newNode;
                newNode.previous = tail;
            }
            tail = newNode;
            _length++;
        }

        // Método para excluir o primeiro nó da lista
        public ListNode deleteFirst()
        {
            if (isEmpty())
            {
                throw new InvalidOperationException();
            }

            ListNode temp = head;
            if (head == tail)
            {
                tail = null;
            }
            else
            {
                head.next.previous = null;
            }
            head = head.next;
            temp.next = null;
            _length--;
            return temp;
        }

        // Método para excluir o último nó da lista
        public ListNode deleteLast()
        {
            if (isEmpty())
            {
                throw new InvalidOperationException();
            }

            ListNode temp = tail;
            if (head == tail)
            {
                head = null;
            }
            else
            {
                tail.previous.next = null;
            }
            tail = tail.previous;
            temp.previous = null;
            _length--;
            return temp;
        }
    }
}

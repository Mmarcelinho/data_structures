namespace exercises.code;
    public class ReverseLinkedList
    {
        public class ListNode
        {
            public int Value;
            public ListNode Next;

            public ListNode(int value = 0, ListNode next = null)
            {
                Value = value;
                Next = next;
            }
        }

        public ListNode ReverseList(ListNode head)
        {
            // Inicializa 'previous' como nulo, pois no início não há nenhuma ligação.
            // Inicializa 'current' com o nó inicial 'head'.
            ListNode previous = null;
            ListNode current = head;

            while (current != null)
            {
                // Mantém uma referência para o próximo nó na lista original em 'nextNode'.
                var nextNode = current.Next;

                // Inverte a ligação do 'current', fazendo com que aponte para o 'previous'.
                // Exemplo: Se 'previous' representa 1 e 'current.Next' representa 3,
                // essa linha fará 'current' apontar para 'previous', resultando em: 2 <- 1
                current.Next = previous;

                // Atualiza 'previous' para apontar para o 'current' invertido.
                previous = current;

                // Move para o próximo nó na lista original, que foi armazenado em 'nextNode'.
                current = nextNode;
            }

            // Quando o loop termina, 'previous' aponta para o novo início da lista invertida.
            return previous;
        }
    }



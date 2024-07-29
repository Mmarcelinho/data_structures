namespace dsa.hashing;

    public class HashTable
    {
        // public static void Main(string[] args)
        // {
        //     HashTable table = new HashTable(10); // Cria uma tabela hash com capacidade para 10 elementos.
        //     table.Put(105, "Tom"); // Adiciona elementos à tabela.
        //     table.Put(21, "Harry");
        //     table.Put(31, "Dinesh");
        //     Console.WriteLine(table.Size()); // Exibe o tamanho da tabela hash.
        //     Console.WriteLine(table.Remove(21)); // Remove elementos e exibe o valor removido.
        //     Console.WriteLine(table.Remove(31));
        //     Console.WriteLine(table.Size()); // Exibe o tamanho atualizado da tabela hash.
        // }

        private HashNode[] buckets; // Array de listas encadeadas que armazenam os nós hash.
        private int numOfBuckets; // Número total de buckets na tabela hash.
        private int size; // Contador do número de pares chave-valor presentes na tabela hash.

        // Construtor para inicializar a tabela hash com uma capacidade específica ou padrão de 10.
        public HashTable(int capacity = 10)
        {
            numOfBuckets = capacity;
            buckets = new HashNode[numOfBuckets];
            size = 0;
        }

        // Classe interna HashNode que define a estrutura de cada nó na lista encadeada.
        private class HashNode
        {
            public int Key; // Chave do nó, tipo simplificado para int.
            public string Value; // Valor associado à chave.
            public HashNode Next; // Referência ao próximo nó na lista encadeada.

            // Construtor do HashNode que inicializa a chave e o valor.
            public HashNode(int key, string value)
            {
                Key = key;
                Value = value;
            }
        }

        // Método para obter o número de pares chave-valor na tabela hash.
        public int Size()
        {
            return size;
        }

        // Método que verifica se a tabela hash está vazia.
        public bool IsEmpty()
        {
            return size == 0;
        }

        // Método para adicionar um novo par chave-valor ou atualizar um existente.
        public void Put(int key, string value)
        {
            if (value == null)
            {
                throw new ArgumentException("Value cannot be null");
            }
            int bucketIndex = GetBucketIndex(key); // Calcula o índice do bucket baseado na chave.
            HashNode head = buckets[bucketIndex]; // Obtém a cabeça da lista no bucket.
            // Procura por uma chave existente para atualizar o valor.
            while (head != null)
            {
                if (head.Key == key)
                {
                    head.Value = value;
                    return;
                }
                head = head.Next;
            }
            // Insere um novo nó na cabeça da lista se a chave não foi encontrada.
            size++;
            head = buckets[bucketIndex];
            HashNode node = new HashNode(key, value);
            node.Next = head;
            buckets[bucketIndex] = node;
        }

        // Método que calcula o índice do bucket com base no hash da chave.
        private int GetBucketIndex(int key)
        {
            return Math.Abs(key % numOfBuckets); // Usa o valor absoluto para evitar índices negativos.
        }

        // Método para recuperar o valor associado a uma chave específica.
        public string Get(int key)
        {
            int bucketIndex = GetBucketIndex(key);
            HashNode head = buckets[bucketIndex];
            while (head != null)
            {
                if (head.Key == key)
                {
                    return head.Value;
                }
                head = head.Next;
            }
            return null; // Retorna null se a chave não for encontrada.
        }

        // Método para remover um par chave-valor baseado na chave fornecida.
        public string Remove(int key)
        {
            int bucketIndex = GetBucketIndex(key); // Encontra o bucket correto.
            HashNode head = buckets[bucketIndex];
            HashNode previous = null;
            // Procura o nó com a chave especificada.
            while (head != null)
            {
                if (head.Key == key)
                {
                    break;
                }
                previous = head;
                head = head.Next;
            }
            if (head == null) // Se a chave não for encontrada, retorna null.
            {
                return null;
            }
            size--; // Reduz o tamanho da tabela hash.
            // Remove o nó da lista encadeada.
            if (previous != null)
            {
                previous.Next = head.Next;
            }
            else
            {
                buckets[bucketIndex] = head.Next;
            }
            return head.Value;
        }
    }


namespace dsa.trie;

public class Trie
{
    // static void Main()
    // {
    //     Trie trie = new();
    //     trie.insert("cat");
    //     trie.insert("cab");
    //     trie.insert("son");
    //     trie.insert("so");
    //     Console.WriteLine("Values inserted successfully");
    // }

    // A raiz da Trie
    public TrieNode root;

    // Construtor da Trie que inicializa a raiz
    public Trie() => root = new TrieNode();

    // Classe interna para representar um nó da Trie
    public class TrieNode
    {
        // Array para armazenar os nós filhos
        public TrieNode[] children;
        // Indica se o nó representa o fim de uma palavra
        public bool isWord;

        // Construtor do nó que inicializa o array de filhos
        public TrieNode() => this.children = new TrieNode[26];
    }

    // Método para inserir uma palavra na Trie
    public void insert(string word)
    {
        // Verifica se a palavra é válida
        if (word == null || word.Count() == 0)
            throw new Exception("Invalid input");

        // Converte a palavra para minúsculas
        word = word.ToLower();

        // Começa na raiz da Trie
        TrieNode current = root;
        for (int i = 0; i < word.Length; i++)
        {
            // Obtém o caractere atual da palavra e seu índice correspondente no array de filhos
            char c = word[i];
            int index = c - 'a';

            // Se o nó filho correspondente ao caractere não existir, cria um novo nó
            if (current.children[index] == null)
            {
                TrieNode node = new();
                current.children[index] = node;
                current = node;
            }
            // Se o nó filho já existir, move para esse nó
            else
                current = current.children[index];
        }
        // Marca o último nó como o fim de uma palavra
        current.isWord = true;
    }

    // Método para procurar uma palavra na Trie (ainda não implementado)
    public bool search(string word) => false;
}

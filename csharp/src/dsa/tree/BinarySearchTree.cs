namespace dsa.tree;

public class BinarySearchTree
{
    // static void Main()
    // {
    //     BinarySearchTree bst = new();
    //     bst.insert(5);
    //     bst.insert(3);
    //     bst.insert(7);
    //     bst.insert(1);

    //     bst.inOrder();

    //     Console.WriteLine();

    //     if (null != bst.search(10))
    //         Console.WriteLine("Key found");
    //     else
    //         Console.WriteLine("Key not found");
    // }
    
    // A raiz da árvore
    public TreeNode root;

    // Classe interna para representar um nó da árvore
    public class TreeNode
    {
        // O valor do nó
        public int data;
        // O nó filho à esquerda
        public TreeNode left;
        // O nó filho à direita
        public TreeNode right;

        // Construtor do nó que inicializa o valor do nó
        public TreeNode(int data) => this.data = data;
    }

    // Método para inserir um valor na árvore
    public void insert(int value) => root = insert(root, value);

    // Método recursivo para inserir um valor na árvore
    public TreeNode insert(TreeNode root, int value)
    {
        // Se a árvore estiver vazia, cria um novo nó
        if (root == null)
        {
            root = new TreeNode(value);
            return root;
        }

        // Se o valor for menor que o valor do nó atual, insere à esquerda
        if (value < root.data)
            root.left = insert(root.left, value);
        // Se o valor for maior que o valor do nó atual, insere à direita
        else
            root.right = insert(root.right, value);

        return root;
    }

    // Método para imprimir os valores da árvore em ordem
    public void inOrder() => inOrder(root);

    // Método recursivo para imprimir os valores da árvore em ordem
    public void inOrder(TreeNode root)
    {
        // Se a árvore estiver vazia, retorna
        if (root == null)
            return;

        // Primeiro imprime o valor do nó à esquerda
        inOrder(root.left);
        // Depois imprime o valor do nó atual
        Console.Write(root.data + " ");
        // Por fim, imprime o valor do nó à direita
        inOrder(root.right);
    }

    // Método para procurar um valor na árvore
    public TreeNode search(int key) => search(root, key);

    // Método recursivo para procurar um valor na árvore
    public TreeNode search(TreeNode root, int key)
    {
        // Se a árvore estiver vazia ou se o valor do nó atual for o valor procurado, retorna o nó
        if (root == null || root.data == key)
            return root;

        // Se o valor procurado for menor que o valor do nó atual, procura à esquerda
        if (key < root.data)
            return search(root.left, key);
        // Se o valor procurado for maior que o valor do nó atual, procura à direita
        else
            return search(root.right, key);
    }
}

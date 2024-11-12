namespace dsa.tree;

public class BinaryTree
{
    // static void Main()
    // {
    //     BinaryTree bt = new();
    //     bt.createBinaryTree();
    //     bt.postOrder();
    // }

    // Nó raiz da árvore
    public TreeNode root;

    // Classe interna para representar um nó da árvore
    public class TreeNode
    {
        public TreeNode left;  // Nó filho à esquerda
        public TreeNode right; // Nó filho à direita
        public int data;       // Dado armazenado no nó

        // Construtor do nó
        public TreeNode(int data) => this.data = data;
    }

    // Método de pré-ordem recursivo
    public void preOrder(TreeNode root)
    {
        if (root == null)
            return;

        Console.Write(root.data + " "); // Processa o nó atual
        preOrder(root.left);            // Processa o nó à esquerda
        preOrder(root.right);           // Processa o nó à direita
    }

    // Método de pré-ordem iterativo
    public void preOrder()
    {
        if (root == null)
            return;

        Stack<TreeNode> stack = new();
        stack.Push(root);

        while (stack.Count != 0)
        {
            TreeNode temp = stack.Pop();
            Console.Write(temp.data + " ");
            if (temp.right != null)
                stack.Push(temp.right);

            if (temp.left != null)
                stack.Push(temp.left);
        }
    }

    // Método de ordem simétrica recursivo
    public void inOrder(TreeNode root)
    {
        if (root == null)
            return;

        inOrder(root.left);             // Processa o nó à esquerda
        Console.Write(root.data + " "); // Processa o nó atual
        inOrder(root.right);            // Processa o nó à direita
    }

    // Método de ordem simétrica iterativo
    public void inOrder()
    {
        if (root == null)
            return;

        Stack<TreeNode> stack = new();
        TreeNode temp = root;

        while (stack.Count != 0 || temp != null)
        {
            if (temp != null)
            {
                stack.Push(temp);
                temp = temp.left;
            }
            else
            {
                temp = stack.Pop();
                Console.Write(temp.data + " ");
                temp = temp.right;
            }
        }
    }

    // Método de pós-ordem recursivo
    public void postOrder(TreeNode root)
    {
        if (root == null)
            return;

        postOrder(root.left);           // Processa o nó à esquerda
        postOrder(root.right);          // Processa o nó à direita
        Console.Write(root.data + " "); // Processa o nó atual
    }

    // Método de pós-ordem iterativo
    public void postOrder()
    {
        TreeNode current = root;
        Stack<TreeNode> stack = new();

        while (current != null || stack.Count != 0)
        {
            if (current != null)
            {
                stack.Push(current);
                current = current.left;
            }
            else
            {
                TreeNode temp = stack.Peek().right;
                if (temp == null)
                {
                    temp = stack.Pop();
                    Console.Write(temp.data + " ");
                    while (stack.Count != 0 && temp == stack.Peek().right)
                    {
                        temp = stack.Pop();
                        Console.Write(temp.data + " ");
                    }
                }
                else
                    current = temp;
            }
        }
    }

    // Método de ordem de nível
    public void levelOrder()
    {
        if (root == null)
            return;

        Queue<TreeNode> queue = new();
        queue.Enqueue(root);

        while (queue.Count != 0)
        {
            TreeNode temp = queue.Dequeue();
            Console.Write(temp.data + " ");
            if (temp.left != null)
                queue.Enqueue(temp.left);

            if (temp.right != null)
                queue.Enqueue(temp.right);
        }
    }

    // Método para encontrar o valor máximo na árvore
    public int findMax() => findMax(root);

    // Método recursivo para encontrar o valor máximo
    public int findMax(TreeNode root)
    {
        if (root == null)
            return int.MinValue;

        int result = root.data;
        int left = findMax(root.left);
        int right = findMax(root.right);

        if (left > result)
            result = left;

        if (right > result)
            result = right;

        return result;
    }

    // Método para criar a árvore binária
    public void createBinaryTree()
    {
        TreeNode first = new(1);
        TreeNode second = new(2);
        TreeNode third = new(3);
        TreeNode fourth = new(4);
        TreeNode fifth = new(5);
        TreeNode sixth = new(6);
        TreeNode seventh = new(7);

        root = first;
        first.left = second;
        first.right = third;
        second.left = fourth;
        second.right = fifth;
        third.left = sixth;
        third.right = seventh;
    }
}

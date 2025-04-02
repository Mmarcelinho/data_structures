namespace exercises.code
{
    // Definição do nó da árvore binária
    public class TreeNode
    {
        public int val;         
        public TreeNode left;   
        public TreeNode right;    

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Solution
    {
        // Realiza a travessia em nível (level-order) da árvore binária
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            // Lista de listas para armazenar os valores por nível
            var res = new List<IList<int>>();

            // Se a raiz for nula, retorna lista vazia
            if (root == null) return res;

            // Fila para armazenar os nós que serão visitados
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root); // Começa pela raiz

            // Enquanto houver nós na fila
            while (queue.Count > 0)
            {
                int levelSize = queue.Count;     // Número de nós no nível atual
                var level = new List<int>();     // Lista para armazenar os valores deste nível

                // Processa todos os nós do nível atual
                for (int i = 0; i < levelSize; i++)
                {
                    var node = queue.Dequeue();  // Remove o nó da fila
                    level.Add(node.val);         // Adiciona o valor do nó à lista do nível

                    // Se o nó possui filho à esquerda, adiciona na fila
                    if (node.left != null)
                        queue.Enqueue(node.left);

                    // Se o nó possui filho à direita, adiciona na fila
                    if (node.right != null)
                        queue.Enqueue(node.right);
                }

                // Após processar o nível, adiciona a lista à resposta final
                res.Add(level);
            }

            // Retorna a lista com os valores por nível
            return res;
        }
    }
}

namespace exercises.code;

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

public class SumRootToLeafNumbers
{
    public class Solution
    {
        // Método principal que inicia a busca com valor acumulado 0
        public int SumNumbers(TreeNode root)
        {
            return DFS(root, 0);
        }

        // DFS percorre a árvore e acumula os valores dos caminhos
        private int DFS(TreeNode node, int currentSum)
        {
            // Se o nó for nulo, retornamos 0 (sem contribuição para a soma)
            if (node == null) return 0;

            // Atualiza o valor acumulado: "empurra" os dígitos para a esquerda (ex: 12 → 120 + 3 = 123)
            currentSum = currentSum * 10 + node.val;

            // Se chegamos em uma folha (sem filhos), retornamos o valor completo
            if (node.left == null && node.right == null) return currentSum;

            // Se não for folha, somamos os valores dos caminhos da esquerda e da direita
            return DFS(node.left, currentSum) + DFS(node.right, currentSum);
        }
    }
}

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

public class Solution
{
    public TreeNode InvertTree(TreeNode root)
    {
        if (root != null)
        {
            // Troca os filhos da esquerda e direita
            TreeNode temp = root.left;
            root.left = root.right;
            root.right = temp;

            // Chama recursivamente para os filhos
            InvertTree(root.left);
            InvertTree(root.right);
        }

        return root;
    }
}
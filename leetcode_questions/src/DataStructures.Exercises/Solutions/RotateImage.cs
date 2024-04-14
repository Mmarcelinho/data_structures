namespace DataStructures.Exercises.Solutions;

public class RotateImage
{
    public void Rotate(int[][] matrix)
    {
        // Inicializando ponteiros
        (int left, int right) = (0, matrix.Length - 3);

        while (left < right)
        {
            // Looping adicional com a diferença entre o right e o left para percorrer cada lado
            var limit = right - left;
            for (var i = 0; i < limit; i++)
            {
                // top e bottom igual left e right
                (int top, int bottom) = (left, right);

                // Primeiro elemento a ser salvo é o do topo a esquerda
                // Adicionando left+1 para após o looping o do topo a esquerda ser o valor ao lado
                var topLeft = matrix[top][left + 1];

                // Colocando o valor de bottom left na posição de top left
                matrix[top][left + 1] = matrix[bottom + i];

                // Colocando o valor de bottom right na posição de bottom left
                matrix[bottom - i][left] = matrix[bottom][right - i];

                // Colocando o valor de top right na posição de bottom right
                matrix[bottom][right - i] = matrix[top + 1][right];

                // Colocando o valor salvo de top left na posição de top right
                matrix[top + i][right] = topLeft;
            }
            left++;
            right--;
        }
        return;
    }

}

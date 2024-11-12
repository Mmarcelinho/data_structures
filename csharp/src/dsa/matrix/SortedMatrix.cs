namespace dsa.matrix;

public class SortedMatrix
{
    // static void Main()
    // {
    //     int[][] matrix = {
    //         new int[] { 10, 20, 30, 40 },
    //         new int[] { 15, 25, 35, 45 },
    //         new int[] { 27, 29, 37, 48 },
    //         new int[] { 32, 33, 39, 51 }
    //     };

    //     SortedMatrix sm = new();
    //     sm.Search(matrix, matrix.Length, 32);
    //     sm.Search(matrix, matrix.Length, 100);
    // }

    public void Search(int[][] matrix, int n, int x)
    {
        // Iniciamos no topo direito da matriz, a posição mais estratégica para a busca.
        int i = 0;
        int j = n - 1;

        // Vamos percorrer a matriz enquanto estivermos dentro dos limites dela.
        while (i < n && j >= 0)
        {
            // Se encontrarmos o número que estamos procurando, mostramos onde ele está.
            if (matrix[i][j] == x)
            {
                Console.WriteLine($"x found at - {i},{j}");
                return;
            }
            // Se o número na posição atual for maior que o procurado, movemos para a esquerda.
            if (matrix[i][j] > x)
                j--;
            // Se for menor, descemos para a próxima linha.
            else
                i++;
        }
        // Se terminarmos a busca sem encontrar o número, avisamos que ele não está na matriz.
        Console.WriteLine("Value not found");
    }
}

namespace dsa.matrix;

    public class SpiralMatrix
    {
        // static void Main()
        // {
        //     int[][] matrix = {
        //         new int[] { 1, 2, 3, 4 },
        //         new int[] { 5, 6, 7, 8 },
        //         new int[] { 9, 10, 11, 12 },
        //         new int[] { 13, 14, 15, 16 }
        //     };
        //     spiralPrint(matrix, matrix.Length, matrix[0].Length);
        // }

        public static void spiralPrint(int[][] matrix, int r, int c)
        {
            int i;
            int k = 0; // k -> r
            int l = 0; // l -> c

            // Enquanto houver linhas e colunas para serem percorridas
            while (k < r && l < c)
            {
                // Da esquerda para a direita --> a coluna varia --> l -> c - 1, a linha permanece constante
                for (i = l; i < c; i++)
                {
                    Console.Write(matrix[k][i] + " ");
                }
                k++;

                // De cima para baixo --> a linha varia --> k -> r - 1, a coluna permanece constante
                for (i = k; i < r; i++)
                {
                    Console.Write(matrix[i][c - 1] + " ");
                }
                c--;

                if (k < r)
                {
                    // Da direita para a esquerda --> a coluna varia --> c - 1 -> l, a linha permanece constante
                    for (i = c - 1; i >= l; i--)
                    {
                        Console.Write(matrix[r - 1][i] + " ");
                    }
                    r--;
                }

                if (l < c)
                {
                    // De baixo para cima --> a linha varia --> r - 1 -> k, a coluna permanece constante
                    for (i = r - 1; i >= k; i--)
                    {
                        Console.Write(matrix[i][l] + " ");
                    }
                    l++;
                }
            }
        }
    }


namespace exercises.code;

public class RotateImage
{
        public void Rotate(int[][] matrix)
        {
            // Define os limites esquerdo e direito da matriz
            (int left, int right) = (0, matrix.Length - 1);

            // Enquanto o limite esquerdo for menor que o direito
            while (left < right)
            {
                // Define o limite para a rotação
                var limit = right - left;
                // Para cada elemento dentro do limite
                for (var i = 0; i < limit; i++)
                {
                    // Define os limites superior e inferior
                    (int top, int bottom) = (left, right);

                    // Salva o valor da posição superior esquerda
                    var topLeft = matrix[top][left + i];

                    // Coloca o valor da posição inferior esquerda na posição superior esquerda
                    matrix[top][left + i] = matrix[bottom - i][left];

                    // Coloca o valor da posição inferior direita na posição inferior esquerda
                    matrix[bottom - i][left] = matrix[bottom][right - i];

                    // Coloca o valor da posição superior direita na posição inferior direita
                    matrix[bottom][right - i] = matrix[top + i][right];

                    // Coloca o valor salvo da posição superior esquerda na posição superior direita
                    matrix[top + i][right] = topLeft;
                }

                // Incrementa o limite esquerdo e decrementa o direito para a próxima iteração
                left++;
                right--;
            }

            // Retorna do método
            return;
        }
    }
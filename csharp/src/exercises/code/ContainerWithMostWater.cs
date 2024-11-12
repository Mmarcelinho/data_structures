namespace exercises.code;

public class ContainerWithMostWater
{
    public int MaxArea(int[] height)
    {
        // Inicializando a área máxima como zero.
        int maxArea = 0;
        // Inicializando os ponteiros 'left' e 'right'.
        int left = 0;
        int right = height.Length - 1;

        // Enquanto o ponteiro 'left' for menor que o ponteiro 'right', continue o loop.
        while (left < right)
        {
            // Calculando a altura mínima entre as alturas em 'left' e 'right'.
            int minHeight = Math.Min(height[left], height[right]);
            // Calculando a área atual usando a altura mínima e a distância entre os ponteiros.
            int currentArea = minHeight * (right - left);
            // Atualizando a 'maxArea' com o valor máximo entre a 'maxArea' atual e a 'currentArea'.
            maxArea = Math.Max(maxArea, currentArea);

            // Avançando o ponteiro 'left' se a altura em 'left' for menor que a altura em 'right'.
            if (height[left] < height[right])
            {
                left++;
            }
            // Movendo o ponteiro 'right' para a esquerda se a altura em 'right' for menor ou igual à altura em 'left'.
            else
            {
                right--;
            }
        }
        // Retornando a área máxima encontrada.
        return maxArea;
    }
}
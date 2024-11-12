namespace exercises.code;

public class TrappingRainWater
{
    public class Solution
    {
        public int Trap(int[] height)
        {
            // n como largura do array
            int n = height.Length;

            int[] water = new int[n];

            // high com 0 como altura maxima e incrementa a cada valor maior
            int high = 0;

            for (int i = 0; i < n - 1; i++)
            {
                // Verifica se a altura que esta no indice i é maior que a altura maxima
                if (height[i] > high)
                    // Se for, aumenta a altura maxima
                    high = height[i];

                // Se for menor, adiciona "água" no array water
                if (height[i] < high)
                    // A quantidade de água a ser adicionada vai ser high menos a altura do elemento que está percorrendo
                    water[i] += high - height[i];
            }

            high = 0;

            // Percorrendo array ao contrario
            for (int i = n - 1; i >= 0; i--)
            {
                // Se altura atual for maior que a maxima
                if (height[i] > high)
                    high = height[i];

                // Calcula a diferença entre a altura maxima e a altura atual
                int diff = high - height[i];

                if (diff < water[i])
                    // Se a diferença for menor que a quantidade de agua, a quantidade de agua vai ser a diferença
                    water[i] = diff;
            }
            int sum = water.Sum();

            return sum;
        }

    }

    public class Solution2
{
    public int Trap(int[] height)
    {
        // Se a altura for nula ou o comprimento for 0, retorne 0
        if (height is null || height.Length == 0) return 0;

        // Inicializa os ponteiros esquerdo e direito
        int left = 0, right = height.Length - 1;
        
        // Inicializa as variáveis leftMax e rightMax com os valores iniciais de height[left] e height[right]
        int leftMax = height[left], rightMax = height[right];
        
        // Inicializa o resultado como 0
        var result = 0;

        // Enquanto o ponteiro esquerdo for menor que o direito
        while (left < right)
        {
            // Se leftMax for menor que rightMax
            if (leftMax < rightMax)
            {
                // Incrementa o ponteiro esquerdo
                left++;
                
                // Atualiza leftMax para ser o máximo entre leftMax e height[left]
                leftMax = Math.Max(leftMax, height[left]);
                
                // Adiciona a diferença entre leftMax e height[left] ao resultado
                result += leftMax - height[left];
            }
            else
            {
                // Decrementa o ponteiro direito
                right--;
                
                // Atualiza rightMax para ser o máximo entre rightMax e height[right]
                rightMax = Math.Max(rightMax, height[right]);
                
                // Adiciona a diferença entre rightMax e height[right] ao resultado
                result += rightMax - height[right];
            }
        }
        // Retorna o resultado
        return result;
    }
}

}


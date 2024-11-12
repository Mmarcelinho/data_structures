namespace dsa.dp;

public class MaxSubArraySum
{
    // static void Main()
    // {
    //     // Define um array de exemplo para teste.
    //     int[] array = { 4, 3, -2, 6, -12, 7, -1, 6 };
    //     // Imprime o resultado da soma máxima do subarray.
    //     Console.WriteLine(maxSubArraySum(array));  
    // }
    
    // Calcula a soma máxima de qualquer subarray contíguo dentro de um array dado.
    public static int maxSubArraySum(int[] array)
    {
        // Inicializa currentMax e maxSoFar com o primeiro elemento do array.
        int currentMax = array[0];
        int maxSoFar = array[0];

        // Itera sobre o array a partir do segundo elemento.
        for (int i = 1; i < array.Length; i++)
        {
            // Atualiza currentMax para ser o maior entre a soma do currentMax atual com o elemento array[i]
            // ou o próprio elemento array[i] (isso reinicia o subarray se array[i] for maior).
            currentMax = Math.Max(currentMax + array[i], array[i]);

            // Atualiza maxSoFar para ser o maior entre maxSoFar e o currentMax atualizado.
            if (maxSoFar < currentMax)
            {
                maxSoFar = currentMax;
            }
        }
        
        // Retorna o valor máximo encontrado, que é a soma máxima de qualquer subarray contíguo.
        return maxSoFar;
    }
}

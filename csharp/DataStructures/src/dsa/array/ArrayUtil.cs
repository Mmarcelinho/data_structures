namespace dsa.array;

public class ArrayUtil
{
    // static void Main()
    // {
    //     ArrayUtil arrayUtil = new();
    //     arrayUtil.arrayDemo();
    // }

    // Demonstra o uso de um método específico da classe para encontrar o número faltante em um array.
    public void arrayDemo()
    {
        int[] array = { 1, 3, 6, 8, 2, 4, 7 };
        Console.WriteLine(findMissingNumber(array));
    }

    // Imprime todos os elementos de um array no console.
    public void printArray(int[] array)
    {
        int numeroDeElementos = array.Length;

        for (int i = 0; i < numeroDeElementos; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

    // Encontra e retorna o menor valor em um array.
    public int findMinimum(int[] array)
    {
        if (array == null || array.Length == 0)
            throw new InvalidOperationException("Entrada Inválida");

        int menor = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < menor)
                menor = array[i];
        }
        return menor;
    }

    // Reverte a ordem dos elementos em um subarray de 'numeros', do índice 'inicio' até 'fim'.
    public void reverse(int[] numeros, int inicio, int fim)
    {
        while (inicio < fim)
        {
            int temp = numeros[inicio];
            numeros[inicio] = numeros[fim];
            numeros[fim] = temp;
            inicio++;
            fim--;
        }
    }

    // Retorna os índices de dois números que somam 'alvo' em um array. 
    // Usa um dicionário para mapear os complementos necessários para atingir 'alvo'.
    public static int[] twoSum(int[] numeros, int alvo)
    {
        int[] resultado = new int[2];
        Dictionary<int, int> map = new();

        for (int i = 0; i < numeros.Length; i++)
        {
            if (!map.ContainsKey(alvo - numeros[i]))
                map.Add(numeros[i], i);

            else
            {
                resultado[1] = i;
                resultado[0] = map[alvo - numeros[i]];
                return resultado;
            }
        }
        throw new InvalidOperationException("Dois números não encontrados");
    }

    // Retorna dois números que somam 'alvo' em um array ordenado.
    // Utiliza um método de dois ponteiros para encontrar a soma.
    public static int[] twoSumII(int[] array, int alvo)
    {
        Array.Sort(array);
        int left = 0;
        int right = array.Length - 1;
        int[] resultado = new int[2];
        while (left < right)
        {
            int soma = array[left] + array[right];
            if (soma == alvo)
            {
                resultado[0] = array[left];
                resultado[1] = array[right];
                return resultado;
            }
            else if (soma < alvo)
                left++;
            else
                right--;
        }
        return new int[0]; // Retorna um array vazio se não encontrar dois números que somem ao alvo.
    }

    // Retorna um novo array com os quadrados dos elementos de 'array', ordenados.
    public static int[] sortedSquares(int[] array)
    {
        int numeroDeElementos = array.Length;
        int i = 0;
        int j = numeroDeElementos - 1;
        int[] resultado = new int[numeroDeElementos];

        for (int k = numeroDeElementos - 1; k >= 0; k--)
        {
            if (Math.Abs(array[i]) > Math.Abs(array[j]))
            {
                resultado[k] = array[i] * array[i];
                i++;
            }
            else
            {
                resultado[k] = array[j] * array[j];
                j--;
            }
        }
        return resultado;
    }

    // Calcula e retorna o número que está faltando em um array que deveria conter todos os números de 1 a N.
    public static int findMissingNumber(int[] array)
    {
        int numeroDeElementos = array.Length + 1;
        int sum = numeroDeElementos * (numeroDeElementos + 1) / 2;
        foreach (int num in array)
            sum -= num;

        return sum;
    }
}

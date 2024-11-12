namespace dsa.sorting;

public class Sort012
{
    // static void Main()
    // {
    //     int[] arr = new int[] { 2, 0, 0, 1, 0, 2, 0, 1, 0, 2, 2, 0 };

    //     Sort012 st = new();

    //     st.printArray(arr);
    //     st.threeNumberSort(arr);
    //     st.printArray(arr);
    // }
    
    public void printArray(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }

    public void threeNumberSort(int[] arr)
    {
        int i = 0;
        int j = 0;
        int k = arr.Length - 1;

        // Percorre o array
        while (i <= k)
        {
            // Se o elemento atual é 0, troca com o elemento na posição j e incrementa i e j
            if (arr[i] == 0)
            {
                swap(arr, i, j);
                j++;
                i++;
            }
            // Se o elemento atual é 1, apenas incrementa i
            else if (arr[i] == 1)
                i++;

            // Se o elemento atual é 2, troca com o elemento na posição k e decrementa k
            else if (arr[i] == 2)
            {
                swap(arr, i, k);
                k--;
            }
        }
    }

    // Método para trocar dois elementos de um array
    private static void swap(int[] arr, int first, int second)
    {
        // Armazena temporariamente o valor do primeiro elemento
        int temp = arr[first];

        // Troca os valores dos elementos
        arr[first] = arr[second];
        arr[second] = temp;
    }
}

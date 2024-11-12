namespace dsa.sorting;

public class MergeSort
{
    // static void Main()
    // {
    //     int[] arr = [9, 5, 2, 4, 3, -1];
        
    //     MergeSort ms = new();
    //     ms.sort(arr, new int[arr.Length], 0, arr.Length - 1);
    //     ms.printArray(arr);
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

    // Método para ordenar um array usando Merge Sort
    public void sort(int[] arr, int[] temp, int low, int high)
    {
        // Verifica se há mais de um elemento no array
        if (low < high)
        {
            // Calcula o índice do meio
            int mid = low + (high - low) / 2;

            // Ordena a primeira metade do array
            sort(arr, temp, low, mid);
            
            // Ordena a segunda metade do array
            sort(arr, temp, mid + 1, high);
            
            // Combina as duas metades em um array ordenado
            merge(arr, temp, low, mid, high);
        }
    }

    // Método para combinar duas metades de um array em um array ordenado
    private void merge(int[] arr, int[] temp, int low, int mid, int high)
    {
        // Copia os elementos do array original para o array temporário
        for (int index = low; index <= high; index++)
        {
            temp[index] = arr[index];
        }

        int i = low;
        int j = mid + 1;
        int k = low;

        // Enquanto houver elementos nas duas metades
        while (i <= mid && j <= high)
        {
            // Se o elemento da primeira metade for menor ou igual ao da segunda metade
            if (temp[i] <= temp[j])
            {
                // Copia o elemento da primeira metade para o array original
                arr[k] = temp[i];
                i++;
            }
            else
            {
                // Caso contrário, copia o elemento da segunda metade para o array original
                arr[k] = temp[j];
                j++;
            }
            k++;
        }

        // Copia os elementos restantes da primeira metade, se houver
        while (i <= mid)
        {
            arr[k] = temp[i];
            k++;
            i++;
        }
    }
}

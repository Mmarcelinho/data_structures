namespace dsa.sorting;

public class SelectionSort
{
    // static void Main()
    // {
    //     int[] arr = new int[] { 5, 1, 2, 9, 10 };

    //     SelectionSort ss = new();

    //     ss.printArray(arr);
    //     ss.sort(arr);
    //     ss.printArray(arr);
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

    public void sort(int[] arr)
    {
        int n = arr.Length;

        // Percorre cada elemento do array
        for (int i = 0; i < n - 1; i++)
        {
            // Assume que o elemento atual é o menor
            int min = i;

            // Procura pelo menor elemento no restante do array
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[min])
                    min = j;
            }

            // Troca o elemento atual com o menor elemento encontrado
            int temp = arr[min];
            arr[min] = arr[i];
            arr[i] = temp;
        }
    }
}

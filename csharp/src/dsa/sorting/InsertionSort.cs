namespace dsa.sorting;

    public class InsertionSort
    {
        // static void Main()
        // {
        //     int[] arr = new int[] { 5, 1, 2, 9, 10 };
        //     InsertionSort Is = new();

        //     Is.printArray(arr);
        //     Is.sort(arr);
        //     Is.printArray(arr);
        // }

        public void printArray(int[] arr)
        {
            // Obtém o tamanho do array
            int n = arr.Length;

            // Itera por cada elemento do array e imprime o valor
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            // Imprime uma nova linha para separar os arrays impressos
            Console.WriteLine();
        }

        public void sort(int[] arr)
        {
            // Obtém o tamanho do array
            int n = arr.Length;

            // Itera por cada elemento do array começando do segundo elemento (índice 1)
            for (int i = 1; i < n; i++)
            {
                // Armazena o valor do elemento atual em uma variável temporária
                int temp = arr[i];

                // Define j como o índice do elemento anterior
                int j = i - 1;

                // Move os elementos do array que são maiores que temp
                // para uma posição à frente de sua posição atual
                while (j >= 0 && arr[j] > temp)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }

                // Insere temp (o valor original de arr[i]) na posição correta
                arr[j + 1] = temp;
            }
        }
    }


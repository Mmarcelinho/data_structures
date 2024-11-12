namespace dsa.sorting;

    public class BubbleSort
    {
        // static void Main()
        // {
        //     int[] arr = [5, 1, 2, 9, 10];

        //     BubbleSort bs = new();

        //     bs.printArray(arr);
        //     bs.sort(arr);
        //     bs.printArray(arr);
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
            // Obtém o tamanho do array
            int n = arr.Length;

            // Variável para verificar se houve uma troca na iteração atual
            bool isSwapped;

            // Itera por cada elemento do array
            for (int i = 0; i < n - 1; i++)
            {
                // Inicializa isSwapped como false para cada nova iteração
                isSwapped = false;

                // Itera pelo array até n - 1 - i
                for (int j = 0; j < n - 1 - i; j++)
                {
                    // Compara o elemento atual (arr[j]) com o próximo elemento (arr[j + 1])
                    if (arr[j] > arr[j + 1])
                    {
                        // Se o elemento atual for maior, troca os elementos
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                        // Define isSwapped como true, pois houve uma troca
                        isSwapped = true;
                    }
                }
                // Se não houve trocas na iteração atual, interrompe o loop, pois o array já está ordenado
                if (isSwapped == false)
                    break;
            }
        }
    }


namespace dsa.mathematics;

    public class RemoveEvenInteger
    {
        // static void Main()
        // {
        //     // Define um array de inteiros
        //     int[] arr = { 3, 2, 4, 7, 10, 6, 5 };
            
        //     // Chama o método PrintArray para imprimir o array
        //     PrintArray(arr);
            
        //     // Chama o método RemoveEven para remover os números pares do array
        //     int[] result = RemoveEven(arr);
            
        //     // Imprime o array resultante após a remoção dos números pares
        //     PrintArray(result);
        // }
        
        // Método para imprimir um array
        public static void PrintArray(int[] arr)
        {
            // Obtém o tamanho do array
            int n = arr.Length;
            
            // Loop para percorrer cada elemento do array
            for (int i = 0; i < n; i++)
            {
                // Imprime o elemento atual do array
                Console.Write(arr[i] + " ");
            }
            
            Console.WriteLine();
        }

        // Método para remover os números pares de um array
        public static int[] RemoveEven(int[] arr)
        {
            // Contador para os números ímpares
            int oddCount = 0;
            
            // Loop para percorrer cada elemento do array
            for (int i = 0; i < arr.Length; i++)
            {
                // Se o elemento atual é ímpar, incrementa o contador
                if (arr[i] % 2 != 0)
                    oddCount++;
            }
            
            // Cria um novo array para armazenar os números ímpares
            int[] result = new int[oddCount];
            
            // Índice para o novo array
            int idx = 0;
            
            // Loop para percorrer cada elemento do array original
            for (int i = 0; i < arr.Length; i++)
            {
                // Se o elemento atual é ímpar, adiciona ao novo array
                if (arr[i] % 2 != 0)
                {
                    result[idx] = arr[i];
                    idx++;
                }
            }
            
            // Retorna o novo array com apenas números ímpares
            return result;
        }
    }


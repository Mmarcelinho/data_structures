namespace dsa_study.array;

    public class ArrayUtil
    {
        // static void Main()
        // {
        //     ArrayUtil arrayUtil = new();
        //     arrayUtil.arrayDemo();
        // }

        public void printArray(int [] array)
        {
            int numeroDeElementos = array.Length;
            
            for(int i = 0; i < numeroDeElementos; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        public int findMinimum(int[] array)
        {
            if(array == null || array.Length == 0)
            throw new InvalidOperationException("Entrada Inválida");

            int menor = array[0];

            for(int i = 1; i < array.Length; i++)
            {
                if(array[i] < menor)
                menor = array[i];
            }
            return menor;
        }

        public void reverse(int[] numeros, int inicio, int fim)
        {
            while(inicio < fim)
            {
                int temp = numeros[inicio];
                numeros[inicio] = numeros[fim];
                numeros[fim] = temp;
                inicio++;
                fim--;
            }
        }

        public static int[] twoSum(int[] numeros, int alvo)
        {
            int[] resultado = new int[2];
            Dictionary<int,int> map = new();

            for(int i = 0; i < numeros.Length; i++)
            {
                if(!map.ContainsKey(alvo - numeros[i]))
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

        public static int[] twoSumII(int[] array, int alvo)
        {
            Array.Sort(array);
            int left = 0;
            int right = array.Length - 1;
            int[] resultado = new int[2];
            while(left < right)
            {
                int soma = array[left] + array[right];
                if(soma == alvo)
                {
                resultado[0] = array[left];
                resultado[1] = array[right];

                return resultado;
                }

                else if(soma < alvo)
                
                left++;

                else
                right--;
            }
            return new int[0];
        }

        public static int[] sortedSquares(int[] array)
        {
            int numeroDeElementos = array.Length;
            int i = 0;
            int j = numeroDeElementos - 1;
            int[] resultado = new int[numeroDeElementos];

            for(int k = numeroDeElementos - 1; k >= 0; k--)
            {
                if(Math.Abs(array[i]) > Math.Abs(array[j]))
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

        public static int findMissingNumber(int[] array)
        {
            int numeroDeElementos = array.Length + 1;
            int sum = numeroDeElementos * (numeroDeElementos + 1) / 2;
            foreach(int num in array)
                sum -= num;
            
            return sum;
        }

        public void arrayDemo()
        {
            int[] array = { 1, 3, 6, 8, 2, 4, 7 };
            Console.WriteLine(findMissingNumber(array));
        }
    }

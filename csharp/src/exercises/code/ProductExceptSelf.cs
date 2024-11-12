namespace exercises.code;

    public class ProductExceptSelf
    {
        public int[] CalculateProductExceptSelf(int[] inputNumbers)
        {
            // Variáveis para armazenar produtos à esquerda e à direita do elemento atual
            int prefixProduct = 1, postfixProduct = 1;

            // Array para armazenar os resultados finais
            int[] result = new int[inputNumbers.Length];

            // Etapa 1: Calcular produtos à esquerda de cada elemento
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                // Atribuir o valor atual de prefixProduct ao elemento correspondente em "result"
                result[i] = prefixProduct;

                // Multiplicar prefixProduct pelo elemento atual em "inputNumbers"
                prefixProduct *= inputNumbers[i];
            }

            // Etapa 2: Calcular produtos à direita de cada elemento e combiná-los com produtos à esquerda
            for (int i = inputNumbers.Length - 1; i >= 0; i--)
            {
                // Multiplicar o elemento atual em "result" pelo valor atual de postfixProduct
                result[i] *= postfixProduct;

                // Atualizar postfixProduct multiplicando-o pelo elemento correspondente em "inputNumbers"
                postfixProduct *= inputNumbers[i];
            }

            // O array "result" agora contém os produtos de todos os elementos em "inputNumbers"
            // exceto o elemento na posição atual.

            return result;
        }
    }

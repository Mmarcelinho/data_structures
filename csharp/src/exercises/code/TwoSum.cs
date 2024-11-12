namespace exercises.code;

    public class TwoSum
    {
        // Este método encontra dois números no array 'numbers' cuja soma é igual a 'targetSum'.
        public int[] FindTwoSum(int[] numbers, int targetSum)
        {
            // Criando um dicionário que associará os números aos seus índices no array.
            Dictionary<int, int> numberIndices = new Dictionary<int, int>();

            // Percorrendo o array 'numbers' com um loop.
            for (int currentIndex = 0; currentIndex < numbers.Length; currentIndex++)
            {
                // Calculando a diferença ('difference') entre o 'targetSum' e o elemento atual.
                var difference = targetSum - numbers[currentIndex];

                // Verificando se o dicionário já contém a chave 'difference'.
                if (numberIndices.ContainsKey(difference))
                {
                    // Se o dicionário já contém 'difference', significa que encontramos dois elementos
                    // cuja soma é igual a 'targetSum'. Retornamos os índices correspondentes a esses elementos.
                    // Por exemplo, se 'numbers' for [1, 2, 3, 4] e 'targetSum' for 6,
                    // a diferença ('difference') será 2 (6 - 4), que é o valor que, somado ao elemento atual (4),
                    // resulta em 'targetSum'. Se o dicionário já contém a chave 2, isso significa que encontramos
                    // os índices correspondentes a esses dois elementos.
                    return new int[] { numberIndices[difference], currentIndex };
                }

                // Caso contrário, adicionamos o elemento atual como chave e seu índice como valor ao dicionário
                // para futura referência, caso encontremos seu par correspondente mais tarde.
                numberIndices[numbers[currentIndex]] = currentIndex;
            }

            // Se nenhum par de elementos com a soma igual a 'targetSum' for encontrado, retornamos um array vazio.
            return new int[] { };
        }
    }


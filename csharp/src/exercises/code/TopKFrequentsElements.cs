namespace exercises.code;

    public class TopKFrequentsElements
    {
        // Método para encontrar os 'n' principais elementos frequentes em um array 'numbers'.
        public int[] FindTopKFrequentNumbers(int[] numbers, int n)
        {
            // Cria um dicionário para rastrear a frequência de cada elemento no array 'numbers'.
            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

            // Itera sobre cada elemento no array 'numbers'.
            foreach (int number in numbers)
            {
                // Verifica se o dicionário 'frequencyMap' já contém a chave correspondente ao elemento atual.
                // Se sim, incrementa o valor associado a essa chave no dicionário.
                // Se não, cria uma nova chave com o valor inicial 1.
                frequencyMap[number] = frequencyMap.ContainsKey(number) ? frequencyMap[number] + 1 : 1;
            }

            // Obtém uma coleção de todas as chaves do dicionário 'frequencyMap'.
            var sortedKeys = frequencyMap.Keys
                .OrderByDescending(key => frequencyMap[key])  // Classifica essas chaves em ordem decrescente com base no valor associado a cada chave no dicionário.
                .Take(n)// A função Take(n) pega os primeiros 'n' elementos da sequência classificada.
                .ToArray();// Converte esses 'n' elementos selecionados em um array.

            // Retorna o array contendo as 'n' chaves mais frequentes.
            return sortedKeys;
        }
    }

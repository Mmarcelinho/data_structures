namespace Exercises
{
    public class TopKFrequentsElements
    {
       
        public int[] FindTopKFrequentNumbers(int[] numbers, int n)
        {
            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();
            foreach (int number in numbers)
            {
                frequencyMap[number] = frequencyMap.ContainsKey(number) ? frequencyMap[number] + 1 : 1;
            }

            var sortedKeys = frequencyMap.Keys
                .OrderByDescending(key => frequencyMap[key])
                .Take(n)
                .ToArray();

            return sortedKeys;
        }

    }

    // Este código cria um dicionário para contar a frequência de elementos em um array 'numbers'.
    // Ele percorre o array 'numbers' e verifica se o dicionário 'frequencyMap' já contém a chave correspondente ao elemento atual.
    // Se a chave já existe, incrementa o valor associado a essa chave no dicionário.
    // Se a chave não existe, cria uma nova chave com o valor inicial 1.
    // Em seguida, obtém uma coleção de todas as chaves do dicionário.
    // Classifica essas chaves em ordem decrescente com base no valor associado a cada chave no dicionário.
    // A função Take(n) pega os primeiros 'n' elementos da sequência classificada.
    // Finalmente, converte esses 'n' elementos selecionados em um array, que é atribuído à variável 'sortedKeys'.

}

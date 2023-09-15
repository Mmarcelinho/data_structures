namespace Exercises;
public class TwoSum
{
  
    public int[] FindTwoSum(int[] numbers, int targetSum)
    {
        Dictionary<int, int> numberIndices = new Dictionary<int, int>();

        for (int currentIndex = 0; currentIndex < numbers.Length; currentIndex++)
        {
            var difference = targetSum - numbers[currentIndex];

            if (numberIndices.ContainsKey(difference))
            {
                return new int[] { numberIndices[difference], currentIndex };
            }

            numberIndices[numbers[currentIndex]] = currentIndex;
        }

        return new int[] {};
    }

}

// Criando um dicionário que associa elementos a seus índices.
// Percorrendo o array 'numbers' com um loop.
// Para cada elemento, calculando a diferença ('difference') entre o 'targetSum' e o elemento atual.
// Verificando se o dicionário já contém a chave 'difference'.
// Se o dicionário já contém 'difference', significa que encontramos dois elementos cuja soma é igual a 'targetSum'.
// Exemplo: Se 'numbers' for [1, 2, 3, 4] e 'targetSum' for 6,
// a diferença ('difference') seria 2 (6 - 4), que é o valor que, somado ao elemento atual (4), resulta em 'targetSum'.
// Se o dicionário já contém a chave 2, isso significa que encontramos os índices correspondentes a esses dois elementos.
// Caso contrário, adicionamos o elemento atual como chave e seu índice como valor ao dicionário para futura referência.

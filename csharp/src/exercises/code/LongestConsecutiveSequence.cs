namespace exercises.code;

public class LongestConsecutiveSequence
{
    public class Solution
    {
        public int LongestConsecutive(int[] nums)
        {
            // Verifica se o tamanho do array é menor que 2 e retorna o tamanho se for.
            if (nums.Length < 2)
                return nums.Length;

            // Cria um conjunto HashSet a partir do array de números.
            var numberSet = new HashSet<int>(nums);

            // Inicializa a variável que armazenará o maior streak (sequência).
            var longestStreak = 0;

            // Itera sobre os números no conjunto.
            foreach (var num in numberSet)
            {
                // Verifica se o número anterior não está presente no conjunto.
                if (!numberSet.Contains(num - 1))
                {
                    var currentNum = num;  // Inicializa o número atual.
                    var currentStreak = 1; // Inicializa o streak atual como 1 (o número atual).

                    // Enquanto o próximo número estiver presente no conjunto, incrementa o streak.
                    while (numberSet.Contains(currentNum + 1))
                    {
                        currentNum++;
                        currentStreak++;
                    }

                    // Atualiza o streak mais longo, se necessário.
                    longestStreak = Math.Max(longestStreak, currentStreak);
                }
            }

            // Retorna o streak mais longo encontrado.
            return longestStreak;
        }
    }

    public class Solution2
    {
        public int LongestConsecutive(int[] nums)
        {
            if (nums.Length < 2) return 0;
            // Ordena o array
            Array.Sort(nums);
            // Variavel com valor do numero anterior no array, valor 0.5 para garantir que não seja um valor ja existente no array
            var prev = 0.5;
            // Melhor sequencia com valor de 1
            var best = 1;
            // Sequencia atual com valor de 1
            var current = 1;

            foreach (int i in nums)
            {
                // Verifica se i é igual ao valor anterior e ignora o valor atual
                if (i == prev)
                    continue;

                // Se o numero atual for igual ao numero anterior mais 1, adiciona 1 na sequencia atual
                if (i == prev + 1)
                    current += 1;

                // Se não for, reseta a sequencia
                else
                    current = 1;

                // Se a sequencia atual for maior que a melhor sequencia, a melhor vira a atual
                if (current > best)
                    best = current;

                // Valor anterior vira valor atual para continuar a sequencia
                prev = i;
            }

            return best;
        }
    }

}
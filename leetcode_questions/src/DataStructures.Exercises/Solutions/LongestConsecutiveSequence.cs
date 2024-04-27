namespace DataStructures.Exercises.Solutions;

public class LongestConsecutiveSequence
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
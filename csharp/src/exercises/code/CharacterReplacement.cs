namespace exercises.code;

    public class CharacterReplacement
    {

     
      public static int ReplaceCharacter(string s, int k)
        {
            int left = 0; // Ponteiro esquerdo da janela
            int maxLength = 0; // Comprimento máximo da substring
            int mostFrequentLetterCount = 0; // Contador da letra mais frequente em uma janela
            int[] charCounts = new int[26]; // Contador por letra (de A a Z)

            for (int right = 0; right < s.Length; right++)
            {
                // Incrementa o contador da letra atual na posição 'right'
                charCounts[s[right] - 'A']++;

                // Atualiza o contador da letra mais frequente na janela
                mostFrequentLetterCount = Math.Max(mostFrequentLetterCount, charCounts[s[right] - 'A']);

                // Calcula quantas letras precisam ser alteradas na janela atual
                int lettersToChange = (right - left + 1) - mostFrequentLetterCount;

                // Se o número de letras a serem alteradas for maior que 'k',
                // move o ponteiro esquerdo e ajusta o contador de letras
                if (lettersToChange > k)
                {
                    charCounts[s[left] - 'A']--; // Remove o caractere na posição 'left'
                    left++; // Move o ponteiro esquerdo
                }

                // Atualiza o comprimento máximo da substring
                maxLength = Math.Max(maxLength, (right - left + 1));
            }

            // Retorna o comprimento máximo da substring com no máximo 'k' substituições
            return maxLength;
        }
    }
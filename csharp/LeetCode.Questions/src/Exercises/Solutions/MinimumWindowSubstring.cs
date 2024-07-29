namespace Exercises.Solutions;

    public class MinimumWindowSubstring
    {

        public static string FindMinimumWindowSubstring(string s, string t)
        {
            if (string.IsNullOrEmpty(t))
            {
                // Retorna uma string vazia se a string 't' for nula ou vazia.
                return string.Empty;
            }

            var tCharCount = new Dictionary<char, int>();
            var windowCharCount = new Dictionary<char, int>();

            // Conta a ocorrência de cada caractere em 't' e armazena em 'tCharCount'.
            foreach (var c in t)
            {
                IncrementCharCount(c, tCharCount);
            }

            int requiredChars = tCharCount.Count; // Número de caracteres únicos em 't'.
            int haveChars = 0; // Número de caracteres em 't' que já foram encontrados em 's'.
            int left = 0;
            int[] resultIndices = { -1, -1 }; // Índices que representam a menor janela encontrada.
            int minLength = int.MaxValue; // Comprimento da menor janela.

            for (int right = 0; right < s.Length; right++)
            {
                char currentChar = s[right];

                // Incrementa a contagem do caractere atual em 'windowCharCount'.
                IncrementCharCount(currentChar, windowCharCount);

                if (tCharCount.ContainsKey(currentChar) && windowCharCount[currentChar] == tCharCount[currentChar])
                {
                    // Se o caractere atual em 's' também existe em 't' e a contagem bate,
                    // incrementa o número de caracteres encontrados em 't'.
                    haveChars++;
                }

                while (haveChars == requiredChars)
                {
                    int windowSize = right - left + 1;

                    if (windowSize < minLength)
                    {
                        // Se a janela atual for menor que a menor janela encontrada até agora,
                        // atualiza os índices da menor janela e seu comprimento.
                        resultIndices[0] = left;
                        resultIndices[1] = right;
                        minLength = windowSize;
                    }

                    char leftChar = s[left];

                    // Remove o caractere mais à esquerda da janela e ajusta as contagens.
                    windowCharCount[leftChar]--;

                    if (tCharCount.ContainsKey(leftChar) && windowCharCount[leftChar] < tCharCount[leftChar])
                    {
                        // Se o caractere removido da janela existir em 't' e sua contagem
                        // em 'windowCharCount' for menor do que em 'tCharCount', decrementa o
                        // número de caracteres encontrados em 't'.
                        haveChars--;
                    }

                    left++; // Move a janela para a direita.
                }
            }

            return minLength == int.MaxValue
                ? string.Empty
                : s.Substring(resultIndices[0], resultIndices[1] - resultIndices[0] + 1);
        }

        private static void IncrementCharCount(char c, Dictionary<char, int> charCount)
        {
            if (charCount.ContainsKey(c))
            {
                // Se o caractere já existe no dicionário, incrementa sua contagem.
                charCount[c]++;
            }
            else
            {
                // Se o caractere é encontrado pela primeira vez, adiciona-o ao dicionário com
                // contagem igual a 1.
                charCount.Add(c, 1);
            }
        }
    }

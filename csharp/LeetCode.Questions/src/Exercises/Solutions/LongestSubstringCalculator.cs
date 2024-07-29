namespace Exercises.Solutions;

    public class LongestSubstringCalculator
    {
        public int CalculateLengthOfLongestSubstring(string s)
        {
            // Inicialização dos ponteiros esquerdo (left) e direito (right) e variável para rastrear o comprimento máximo da substring.
            int left = 0, right = 0, maxLength = 0;

            // HashSet para rastrear caracteres únicos em nossa janela deslizante.
            HashSet<char> uniqueChars = new HashSet<char>();

            // Enquanto o ponteiro direito não alcançar o final da string.
            while (right < s.Length)
            {
                // Obtém o caractere atual na posição right.
                char currentChar = s[right];

                // Verifica se o caractere atual já está na janela deslizante.
                if (uniqueChars.Contains(currentChar))
                {
                    // Se estiver, remove o caractere mais à esquerda até que não haja duplicatas.
                    uniqueChars.Remove(s[left]);
                    left++;
                }
                else
                {
                    // Se não estiver, adiciona o caractere à janela deslizante.
                    uniqueChars.Add(currentChar);

                    // Calcula o tamanho da substring atual e verifica se é o maior até agora.
                    // (right - left + 1) é o tamanho da janela deslizante atual.
                    maxLength = Math.Max(maxLength, right - left + 1);

                    // Move o ponteiro direito para expandir a janela deslizante.
                    right++;
                }
            }

            // Retorna o comprimento máximo da substring onde os caracteres não se repetem.
            return maxLength;
        }
    }

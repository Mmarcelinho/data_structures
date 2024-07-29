namespace dsa.str;

public class StringUtil
{
    // static void Main()
    // {
    //     Console.WriteLine(FirstNonRepeatingCharacter("abafbabe"));
    //     Console.WriteLine(isSubsequence("abcde", "ace"));
    //     Console.WriteLine(removeVowels("hello world"));
    // }

    public static bool isSubsequence(String str, String seq)
    {
        int i = 0; // Índice para percorrer a string 'str'
        int j = 0; // Índice para percorrer a string 'seq'

        // Enquanto não chegamos ao fim de 'str' ou 'seq'
        while (i < str.Length && j < seq.Length)
        {
            // Se o caractere atual em 'str' é igual ao caractere atual em 'seq', incrementamos 'j'
            if (str[i] == seq[j])
                j++;

            // Sempre incrementamos 'i' para avançar para o próximo caractere em 'str'
            i++;
        }
        // Se 'j' é igual ao comprimento de 'seq', então todos os caracteres de 'seq' foram encontrados em 'str' na ordem correta
        return j == seq.Length;
    }

    public static String removeVowels(String str)
    {
        // Define um conjunto de caracteres que são considerados vogais
        HashSet<char> vowels = ['a', 'e', 'i', 'o', 'u'];

        // Cria uma lista para armazenar os caracteres da string sem as vogais
        List<char> chars = [];

        // Percorre cada caractere na string
        foreach (char ch in str)
        {
            // Se o caractere atual não é uma vogal, adiciona-o à lista
            if (!vowels.Contains(ch))
                chars.Add(ch);
        }
        // Converte a lista de caracteres de volta para uma string e retorna
        return new string(chars.ToArray());
    }

    public static int FirstNonRepeatingCharacter(string str)
    {
        // Cria um dicionário para armazenar a frequência de cada caractere na string
        Dictionary<char, int> characterFrequencyMap = [];
        // Converte a string para um array de caracteres
        char[] chars = str.ToCharArray();

        // Percorre cada caractere no array
        foreach (char ch in chars)
        {
            // Se o caractere já está no dicionário, incrementa sua frequência
            if (characterFrequencyMap.ContainsKey(ch))
                characterFrequencyMap[ch]++;
            // Se o caractere não está no dicionário, adiciona-o com frequência 1
            else
                characterFrequencyMap[ch] = 1;
        }

        // Percorre cada caractere no array novamente
        for (int i = 0; i < chars.Length; i++)
        {
            // Se a frequência do caractere atual é 1, retorna seu índice
            if (characterFrequencyMap[chars[i]] == 1)
                return i;
        }
        // Se nenhum caractere com frequência 1 foi encontrado, retorna -1
        return -1;
    }
}


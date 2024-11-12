namespace exercises.code;

public class GroupAnagrams
{
    // Método para agrupar palavras anagramas em uma lista de listas.
    public IList<IList<string>> GroupAnagramsInList(string[] words)
    {
        // Um dicionário para mapear a representação única das letras de cada palavra para suas anagramas.
        var anagramGroups = new Dictionary<string, IList<string>>();

        // Iterando através de todas as palavras na lista de entrada.
        foreach (string word in words)
        {
            // Um vetor para contar quantas vezes cada letra aparece na palavra.
            char[] characterCounts = new char[26];

            // Iterando através de cada caractere na palavra.
            foreach (char character in word)
            {
                // Calculando o índice no vetor com base no caractere ('a' é subtraído do caractere atual).
                characterCounts[character - 'a']++;
            }

            // Gerando uma chave única com base na contagem de letras da palavra.
            string key = new string(characterCounts);

            // Verificando se a chave não existe no dicionário.
            if (!anagramGroups.ContainsKey(key))
            {
                // Se não existir, criamos uma nova entrada no dicionário.
                anagramGroups[key] = new List<string>();
            }

            // Adicionando a palavra atual à lista correspondente à chave no dicionário.
            anagramGroups[key].Add(word);
        }

        // Retornando os valores do dicionário como uma lista de listas de palavras anagramas.
        return anagramGroups.Values.ToList();
    }
}
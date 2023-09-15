namespace Exercises;

public class GroupAnagrams
{
   
    public IList<IList<string>> groupAnagrams(string[] words)
    {
        var anagramGroups = new Dictionary<string, IList<string>>();

        foreach (string word in words)
        {
            char[] characterCounts = new char[26];
            foreach (char character in word)
            {
                characterCounts[character - 'a']++;
            }

            string key = new string(characterCounts);
            if (!anagramGroups.ContainsKey(key))
            {
                anagramGroups[key] = new List<string>();
            }
            anagramGroups[key].Add(word);
        }

        return anagramGroups.Values.ToList();
    }


}

// Este código cria um dicionário onde a chave é uma representação única das letras de cada palavra,
// e o valor é uma lista de palavras que são anagramas umas das outras, ou seja, têm as mesmas letras
// em diferentes ordens.

// Iniciamos percorrendo cada palavra na lista de entrada.
// Para cada palavra, criamos um vetor chamado characterCounts para contar quantas vezes cada letra
// aparece, considerando as letras de 'a' a 'z'.

// Em seguida, percorremos os caracteres da palavra e subtraímos o código ASCII do caractere 'a' para
// determinar o índice no vetor characterCounts onde devemos incrementar. Isso nos permite contar
// quantas vezes cada letra aparece na palavra.

// Por exemplo, para a letra 'e', a diferença c - 'a' é igual a 4, então incrementamos characterCounts[4] em 1.
// Isso nos dá uma representação única para cada palavra baseada na contagem de letras.

// À medida que percorremos as palavras, criamos uma chave usando a representação única (characterCounts)
// da primeira palavra. Verificamos se o dicionário (anagramGroups) já possui essa chave. Se não existir,
// criamos uma nova entrada no dicionário com a chave e uma lista vazia como valor.

// Em seguida, adicionamos a palavra atual à lista correspondente à chave no dicionário.
// Isso agrupa palavras que são anagramas sob a mesma chave.

// Finalmente, retornamos os valores do dicionário anagramGroups como uma lista de listas de palavras,
// onde cada lista contém palavras que são anagramas umas das outras.

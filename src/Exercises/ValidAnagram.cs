namespace Exercises
{
    public class ValidAnagram
    {
     

        public bool AreAnagrams(string firstWord, string secondWord)
        {
            if (firstWord.Length != secondWord.Length) return false;
            if (firstWord == secondWord) return true;

            Dictionary<char, int> firstWordLetterCounts = new Dictionary<char, int>();
            Dictionary<char, int> secondWordLetterCounts = new Dictionary<char, int>();

            for (int i = 0; i < firstWord.Length; i++)
            {
                firstWordLetterCounts[firstWord[i]] = 1 + (firstWordLetterCounts.ContainsKey(firstWord[i]) ? firstWordLetterCounts[firstWord[i]] : 0);
                secondWordLetterCounts[secondWord[i]] = 1 + (secondWordLetterCounts.ContainsKey(secondWord[i]) ? secondWordLetterCounts[secondWord[i]] : 0);
            }

            foreach (char letter in firstWordLetterCounts.Keys)
            {
                int secondWordLetterCount = secondWordLetterCounts.ContainsKey(letter) ? secondWordLetterCounts[letter] : 0;
                if (firstWordLetterCounts[letter] != secondWordLetterCount) return false;
            }
            return true;
        }

    }

    // Este método recebe duas palavras como entrada e determina se uma delas é um anagrama da outra.

    // Verificamos se o tamanho das duas palavras é diferente. Se forem diferentes, elas não podem ser anagramas uma da outra.

    // Em seguida, criamos dois dicionários para contar a ocorrência de cada caractere nas palavras.
    // Um dicionário é usado para a primeira palavra (firstWordLetterCounts), e o outro para a segunda palavra (secondWordLetterCounts).

    // Utilizamos um loop para percorrer as letras das palavras e atualizar os contadores nos dicionários.
    // Para cada letra na posição 'i', verificamos se a letra já está no dicionário firstWordLetterCounts.
    // Se estiver, incrementamos o contador para essa letra em firstWordLetterCounts[firstWord[i]].
    // Caso contrário, adicionamos a letra ao dicionário com um contador inicial de 1.

    // Em seguida, percorremos as chaves do dicionário firstWordLetterCounts (que contém as letras da primeira palavra).
    // Para cada chave (representando uma letra), verificamos se essa chave também está presente no dicionário secondWordLetterCounts
    // (que contém as letras da segunda palavra).
    // Se a chave existir em secondWordLetterCounts, obtemos o contador correspondente (secondWordLetterCount).
    // Se a chave não existir em secondWordLetterCounts, assumimos que o contador é 0.
    // Comparamos então os contadores das duas palavras para a mesma letra.
    // Se em algum momento encontrarmos uma letra com contadores diferentes, retornamos 'false' porque as palavras não são anagramas uma da outra.

    // Se o loop terminar sem encontrar diferenças nos contadores, retornamos 'true' indicando que as palavras são anagramas.

    // Este código é uma maneira eficiente de verificar se duas palavras são anagramas, contando a ocorrência de cada letra em ambas as palavras.

    // Observe que esse código não é sensível a maiúsculas e minúsculas, ou seja, "Listen" e "silent" seriam consideradas anagramas.

}

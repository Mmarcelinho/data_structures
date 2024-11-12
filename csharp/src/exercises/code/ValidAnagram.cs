namespace exercises.code;

    public class ValidAnagram
    {
        // Este método recebe duas palavras como entrada e determina se uma delas é um anagrama da outra.
        public bool AreAnagrams(string firstWord, string secondWord)
        {
            // Verificamos se o tamanho das duas palavras é diferente. Se forem diferentes, elas não podem ser anagramas uma da outra.
            if (firstWord.Length != secondWord.Length)
                return false;
            
            // Se as duas palavras forem idênticas, elas são consideradas anagramas.
            if (firstWord == secondWord)
                return true;

            // Criamos dois dicionários para contar a ocorrência de cada caractere nas palavras.
            Dictionary<char, int> firstWordLetterCounts = new Dictionary<char, int>();
            Dictionary<char, int> secondWordLetterCounts = new Dictionary<char, int>();

            // Percorremos as letras das palavras e atualizamos os contadores nos dicionários.
            for (int i = 0; i < firstWord.Length; i++)
            {
                // Verificamos se a letra já está no dicionário firstWordLetterCounts.
                // Se estiver, incrementamos o contador para essa letra em firstWordLetterCounts[firstWord[i]].
                // Caso contrário, adicionamos a letra ao dicionário com um contador inicial de 1.
                firstWordLetterCounts[firstWord[i]] = 1 + (firstWordLetterCounts.ContainsKey(firstWord[i]) ? firstWordLetterCounts[firstWord[i]] : 0);
                secondWordLetterCounts[secondWord[i]] = 1 + (secondWordLetterCounts.ContainsKey(secondWord[i]) ? secondWordLetterCounts[secondWord[i]] : 0);
            }

            // Percorremos as chaves do dicionário firstWordLetterCounts (que contém as letras da primeira palavra).
            foreach (char letter in firstWordLetterCounts.Keys)
            {
                // Para cada chave (representando uma letra), verificamos se essa chave também está presente no dicionário secondWordLetterCounts
                // (que contém as letras da segunda palavra).
                // Se a chave existir em secondWordLetterCounts, obtemos o contador correspondente (secondWordLetterCount).
                // Se a chave não existir em secondWordLetterCounts, assumimos que o contador é 0.
                int secondWordLetterCount = secondWordLetterCounts.ContainsKey(letter) ? secondWordLetterCounts[letter] : 0;

                // Comparamos então os contadores das duas palavras para a mesma letra.
                // Se em algum momento encontrarmos uma letra com contadores diferentes, retornamos 'false'
                // porque as palavras não são anagramas uma da outra.
                if (firstWordLetterCounts[letter] != secondWordLetterCount)
                    return false;
            }
            
            // Se o loop terminar sem encontrar diferenças nos contadores, retornamos 'true' indicando que as palavras são anagramas.
            return true;
        }
    }


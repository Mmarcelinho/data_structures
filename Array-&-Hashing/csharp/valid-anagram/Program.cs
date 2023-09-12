public class Program {

     static void Main(string[] args)
    {
       IsAnagram("rato","toro");
    }

    private static bool IsAnagram(string s, string t) { //Recebe as duas palavras
        if (s.Length != t.Length) return false; //Se o tamanho for diferente t não é anagrama de s
        if (s == t) return true; //Se for igual os caracteres estão na mesma ordem

        Dictionary<char, int> sCounts = new Dictionary<char, int>(); //Criando um dicionário de chave/valor para s e t
        Dictionary<char, int> tCounts = new Dictionary<char, int>();
        
        for (int i = 0; i < s.Length; i++) {
            sCounts[s[i]] = 1 + (sCounts.ContainsKey(s[i]) ? sCounts[s[i]] : 0);
            tCounts[t[i]] = 1 + (tCounts.ContainsKey(t[i]) ? tCounts[t[i]] : 0);
            //Looping fazendo verifição dos caracteres de s e t nos dicionarios na posição i
            //sCounts[s[i]] - Verificando o caracter de s na posição i
            //sCounts.ContainsKey(t[i]) ? - Verificando se o dicionário possui aquela chave de s que está na posição i
            //Se existe, retorna o valor dela em sCounts[s[i]] e faz a soma: 1 + valor da chave, atribuindo ao dicionário sCounts[s[i]] 
            //Se não, retorna valor padrão 0, e aquele caracter é criado como chave no dicionário, adicionando o valor 1 a chave
        }

        foreach (char c in sCounts.Keys) {
            int tCount = tCounts.ContainsKey(c) ? tCounts[c] : 0;
            if (sCounts[c] != tCount)
            {
                Console.WriteLine("different");
                return false;
            }
            //Looping passando as chaves do dicionario sCounts para c
            //tCount - Variável recebendo atribução da condição 
            //tCounts.ContainsKey(c) ? - Verifica se no dicionario tCounts contem a chave c que é do dicionario sCounts
            //Se contém, adiciona o valor dessa chave que ta no dicionário tcounts a variavel
            //Se não, adiciona valor padrão 0
            // if (sCounts[c] != tCount) return false; - Verifica em sCounts se o valor da chave que ta em c é diferente do valor da mesma chave que está na variavel tcount
        }
        Console.WriteLine("equal");
        return true;
        
    }
}
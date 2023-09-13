public class Program
{
    static void Main(string[] args)
    {
        string[] strgs = { "eat", "tea", "tan", "ate", "nat", "bat" };
        GroupAnagrams(strgs);
        IList<IList<string>> result = GroupAnagrams(strgs);//Recebendo os valores do dicionário groups como uma lista de listas de strings. 
        foreach (var group in result)//Percorrendo cada grupo
        {
            foreach (var word in group)//Imrpimindo as palavras de cada grupo
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
        }
    }
    private static IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var groups = new Dictionary<string, IList<string>>();//Criando um dicionário com chave string e valor que será uma lista de string com os anagramas semelhantes entre si

        foreach (string s in strs)
        {//Pegando os elementos da string
            char[] hash = new char[26];//Criando um hash tipo char para para contar quantas vezes cada letra aparece, representando letras de A a Z
            foreach (char c in s)
            {//Pegando os caracteres da string
                hash[c - 'a']++;//Subtraindo o codigo ASCII do caracter da string por a, para armazenar e fazer a contagem de quantas vezes a letra aparece
                                //Ex: Para 'e', c - 'a' é 4, então hash[4] é incrementado em 1.
            }

            string key = new string(hash);//Cria uma chave com o hash da primeira string
            if (!groups.ContainsKey(key))
            {//Condicional verificando se o dicionario não possui essa chave
                groups[key] = new List<string>();//Criando uma lista para a chave
            }
            groups[key].Add(s);//Adicionando a string/Anagrama pra lista daquela chave
        }
        return groups.Values.ToList();//Retorna os valores do dicionário groups como uma lista de listas de strings. 
    }
}
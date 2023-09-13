public class Program{
     static void Main(string[] args)
    {
        int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8 };
        TwoSum(nums, 12);
    }
    private static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> indices = new Dictionary<int, int>(); //Criando um dicionario chave/valor para armazenar elemento e seu indice

        for (int i = 0; i < nums.Length; i++) //Looping percorrendo array do tamanho de nums
        {
            var diff = target - nums[i]; //Atribuindo a diff(diferente) o valor do elemento passado na função menos o valor de nums que ta na posição i
            if (indices.ContainsKey(diff))//Verificando se o dicionario ja contem esse item 
            {
                return new int[] { indices[diff], i };//Caso ja contenha, mostre seus indices
                //Exemplo: [1,2,3,4], target = 6
                //diff = 6 - 4 = 2 que é o valor somado a 4(elemento atual) que resulta no valor de target
                //Se dicionario ja contem valor 2, mostre o indice do valor 2 e o indice de i que é o indice do valor 4
            }
            indices[nums[i]] = i;//Se essa chave não contem ainda no dicionario, adicione o valor como chave e i que é o indice como valor
        }
        return null;
    }
}
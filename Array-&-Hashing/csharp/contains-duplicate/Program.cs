public class Program
{
    static void Main(string[] args)
    {
        int[] num = { 1, 2, 3, 4, 5, 6};
        ContainsDuplicate(num);
    }

    private static bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> set = new HashSet<int>(); //Hashset para armazenar elementos da coleção de "nums"

        foreach (int x in nums)//x em nums recebendo por ordem os elementos da coleção
        {
            if (set.Contains(x))//Verifica se contém x no hashset, se sim, retorna a intrução do abaixo
            {
                Console.WriteLine("repeated number");
                return false;
            }
            set.Add(x);//Se não contém, adiciona o elemento no hashset

        }
        Console.WriteLine("not contain number duplicate"); //Caso não haja números duplicados, sai do loop e retorna a instrução passada
        return true;
    }

}


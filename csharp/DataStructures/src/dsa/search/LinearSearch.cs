namespace dsa.search;

public class LinearSearch
{
    // static void Main()
    // {
    //     int[] arr = { 5, 1, 9, 2, 10, 15, 20 };
    //     LinearSearch ls = new();
    //     Console.WriteLine(ls.search(arr, arr.Length, 9));
    // }

    public int search(int[] arr, int n, int x)
    {
        // Verifica se o array é nulo ou vazio. Se for, lança uma exceção.
        if (arr == null || arr.Length == 0)
            throw new Exception("Invalid input");

        // Itera por cada item do array. A variável 'i' é o índice atual.
        for (int i = 0; i < n; i++)
        {
            // Compara o elemento atual do array (arr[i]) com o valor alvo (x).
            // Se eles forem iguais, retorna o índice atual, pois o valor alvo foi encontrado.
            if (arr[i] == x)
                return i;
        }

        // Se o valor alvo não foi encontrado após percorrer todo o array, retorna -1.
        return -1;
    }
}


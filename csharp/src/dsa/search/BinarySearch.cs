namespace dsa.search;

public class BinarySearch
{
    // static void Main()
    // {
    //     BinarySearch bs = new();
    //     int[] nums = { 1, 10, 20, 47, 59, 65, 75, 88, 99 };
    //     Console.WriteLine(bs.binarySearch(nums, 65));
    // }

    public int binarySearch(int[] nums, int key)
    {
        // Define os limites inferior e superior do array
        int low = 0;
        int high = nums.Length - 1;

        // Enquanto o limite inferior for menor ou igual ao superior
        while (low <= high)
        {
            // Calcula o índice do meio
            int mid = (high + low) / 2;

            // Se o número no índice do meio for igual à chave, retorna o índice
            if (nums[mid] == key)
                return mid;

            // Se a chave for menor que o número no índice do meio, move o limite superior para o meio - 1
            if (key < nums[mid])
                high = mid - 1;

            // Se a chave for maior que o número no índice do meio, move o limite inferior para o meio + 1
            else
                low = mid + 1;
        }
        // Se a chave não for encontrada, retorna -1
        return -1;
    }
}

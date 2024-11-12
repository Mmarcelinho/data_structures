namespace exercises.code;

    public class FindMinimumInRotatedSortedArray
    {
       
        public static int FindMinimum(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                // Caso base: se o subarray restante estiver ordenado, o primeiro elemento é o mínimo.
                if (nums[left] <= nums[right])
                {
                    return nums[left];
                }

                int mid = (left + right) / 2; // Calcula o índice do elemento do meio.

                // Verifica se o elemento do meio é maior ou igual ao elemento da esquerda.
                if (nums[mid] >= nums[left])
                {
                    left = mid + 1; // Descarta a metade esquerda, incluindo o meio.
                }
                else
                {
                    right = mid; // Descarta a metade direita, mantendo o elemento do meio.
                }
            }
            throw new InvalidOperationException("Input array is empty.");
        }
    }

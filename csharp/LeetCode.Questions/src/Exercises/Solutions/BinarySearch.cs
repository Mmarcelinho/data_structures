namespace Exercises.Solutions;

    public class BinarySearch
    {
        public static int search(int[] nums, int target)
        {
            int low = 0; // Inicializa o índice mais baixo do array
            int high = nums.Length - 1; // Inicializa o índice mais alto do array

            // Realiza a busca enquanto o índice mais baixo não ultrapassa o mais alto
            while (low <= high)
            {
                var mid = (low + high) / 2; // Calcula o índice do elemento do meio

                if (nums[mid] == target) // Se o elemento do meio for o alvo, retorna o índice
                    return mid;
                else if (nums[low] <= nums[mid]) // Verifica se a metade esquerda está ordenada
                {
                    if (target > nums[mid] || target < nums[low]) // Verifica se o alvo está na metade direita
                    {
                        low = mid + 1; // Descarta a metade esquerda, incluindo o meio
                    }
                    else
                    {
                        high = mid - 1; // Descarta a metade direita, mantendo o elemento do meio
                    }
                }
                else // Caso contrário, a metade direita está ordenada
                {
                    if (target < nums[mid] || target > nums[high]) // Verifica se o alvo está na metade esquerda
                    {
                        high = mid - 1; // Descarta a metade direita, mantendo o elemento do meio
                    }
                    else
                    {
                        low = mid + 1; // Descarta a metade esquerda, incluindo o meio
                    }
                }
            }
            return -1; // Retorna -1 se o alvo não for encontrado no array
        }
    }


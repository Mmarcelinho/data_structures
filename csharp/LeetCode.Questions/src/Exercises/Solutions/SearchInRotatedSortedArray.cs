namespace Exercises.Solutions;

    public class SearchInRotatedSortedArray
    {
        public static int Search(int[] nums, int target) 
        {
            int low = 0;
            int high = nums.Length - 1;
            
            // Inicia a busca binária
            while(low <= high) 
            {
                // Calcula o índice do meio do array
                var mid = (low + high) / 2;
                
                // Verifica se o valor no índice do meio é igual ao valor alvo
                if(nums[mid] == target) 
                {
                    // Se for igual, retorna o índice do meio
                    return mid;
                } 
                else if(nums[low] <= nums[mid]) 
                {
                    // Se o valor no índice do meio for maior ou igual ao valor no índice mais baixo,
                    // isso significa que a metade esquerda está ordenada de forma crescente.
                    if(target > nums[mid] ||  target < nums[low])
                    {
                        // Se o valor alvo for maior que o valor no meio ou menor que o valor mais baixo,
                        // move o ponteiro 'low' para a direita do meio.
                        low = mid + 1;
                    }
                    else 
                    {
                        // Caso contrário, move o ponteiro 'high' para a esquerda do meio.
                        high = mid - 1;
                    }
                } 
                else 
                {
                    // Se o valor no índice do meio for menor que o valor no índice mais baixo,
                    // isso significa que a metade direita está ordenada de forma crescente.
                    if(target < nums[mid] || target > nums[high])
                    {
                        // Se o valor alvo for menor que o valor no meio ou maior que o valor mais alto,
                        // move o ponteiro 'high' para a esquerda do meio.
                        high = mid - 1;
                    }
                    else 
                    {
                        // Caso contrário, move o ponteiro 'low' para a direita do meio.
                        low = mid + 1;
                    }
                }
            }
            
            // Se a busca binária não encontrar o valor alvo, retorna -1
            return -1;
        }
    }

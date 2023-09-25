namespace Exercises
{
    public class ThreeSum
    {
       
        public IList<IList<int>> ThreeNumberSum(int[] nums)
        {
            // Lista de listas do tipo int para armazenar os conjuntos de elementos cuja soma é igual a 0.
            List<IList<int>> result = new List<IList<int>>();

            // Ordena os números em ordem crescente para facilitar a busca dos elementos.
            Array.Sort(nums);

            // Loop principal para iterar através dos números.
            for (int i = 0; i < nums.Length; i++)
            {
                // Ignora elementos duplicados, verificando se o elemento atual é igual ao anterior.
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                // Define dois ponteiros, 'left' apontando para o próximo elemento após 'i' e 'right' apontando para o último elemento.
                int left = i + 1;
                int right = nums.Length - 1;

                // Calcula a soma dos três elementos atuais.
                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];

                    // Se a soma for maior que 0, decrementa 'right' para diminuir a soma.
                    if (sum > 0)
                    {
                        right--;
                    }
                    // Se a soma for menor que 0, incrementa 'left' para aumentar a soma.
                    else if (sum < 0)
                    {
                        left++;
                    }
                    else
                    {
                        // Se a soma for igual a 0, cria uma lista com esses valores e adiciona à lista 'result'.
                        result.Add(new List<int> { nums[i], nums[left], nums[right] });

                        // Ignora elementos duplicados à esquerda.
                        while (left < right && nums[left] == nums[left + 1])
                        {
                            left++;
                        }

                        // Ignora elementos duplicados à direita.
                        while (left < right && nums[right] == nums[right - 1])
                        {
                            right--;
                        }

                        left++;
                        right--;
                    }
                }
            }

            // Retorna a lista de listas contendo os conjuntos de elementos cuja soma é igual a 0.
            return result;
        }
    }
}

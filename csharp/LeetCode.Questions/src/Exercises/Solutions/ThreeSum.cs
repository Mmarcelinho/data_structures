namespace Exercises.Solutions;

public class ThreeSum
{
    public IList<List<int>> threeSum(int[] nums)
    {
        List<List<int>> resultado = [];

        int left, right;

        // Ordenando de forma crescente para trabalhar o array de forma mais simples
        Array.Sort(nums);

        // Utilizando ponto fixo inicial para fazer o twoSum
        for (int i = 0; i < nums.Length; i++)
        {
            // Se for maior que 0 e for igual ao número anterior vai ser pulado essa interação no loop para não ter respostas duplicadas
            if (i > 0 && nums[i] == nums[i - 1])
                continue;


            // Inicializando ponteiros
            // left começa após o ponto fixo 
            left = i + 1;
            right = nums.Length - 1;

            // Fazendo twoSum
            while (left < right)
            {
                // Se a soma for menor que 0 pula um pra direita
                // Se for maior que 0 pega o ponteiro da direita e diminui 1
                if (nums[i] + nums[left] + nums[right] > 0)
                    right--;

                else if (nums[i] + nums[left] + nums[right] < 0)
                    left++;

                // Se for igual a 0 será adicionado os três elementos em uma lista dentro de resultado
                else
                    resultado.Add(new List<int> { nums[i], nums[left], nums[right] });

                // Mudando a posição do ponteiro para o proximo elemento a ser trabalhado
                left++;

                // Checando se o ponteiro ta percorrendo um numero igual
                while (nums[left] == nums[left - 1] && left < right)
                {
                    left++;
                }
            }
        }
        return resultado;
    }
}

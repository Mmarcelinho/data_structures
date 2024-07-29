namespace Exercises.Solutions;

    public class ContainsDuplicate
    {

        public bool HasDuplicateElements(int[] numbers)
        {
            // Cria um HashSet para armazenar números únicos.
            HashSet<int> uniqueNumbers = new HashSet<int>();

            // Percorre os elementos na coleção "numbers" um por um.
            foreach (int number in numbers)
            {
                // Verifica se o número já existe no HashSet.
                if (uniqueNumbers.Contains(number))
                {
                    // Se o número já existe, há um número duplicado, então retorna "true".
                    return true;
                }

                // Caso contrário, adiciona o número ao HashSet.
                uniqueNumbers.Add(number);
            }

            // Se não houver números duplicados em toda a coleção, o loop termina e o método retorna "false".
            return false;
        }
    }


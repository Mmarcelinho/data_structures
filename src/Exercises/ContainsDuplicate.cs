namespace Exercises
{
    public class ContainsDuplicate
    {

        public bool containsDuplicate(int[] numbers)
        {
            HashSet<int> uniqueNumbers = new HashSet<int>();
            foreach (int number in numbers)
            {
                if (uniqueNumbers.Contains(number)) return true;
                uniqueNumbers.Add(number);
            }
            return false;
        }

        // Este código utiliza um HashSet para armazenar elementos únicos.
        // Ele percorre os elementos na coleção "numbers" um por um na ordem em que aparecem.
        // Para cada elemento, verifica se já existe no HashSet.
        // Se o elemento já estiver presente, isso significa que há um número duplicado e retorna "true".
        // Caso contrário, adiciona o elemento ao HashSet.
        // Se não houver números duplicados em toda a coleção, o loop termina e o método retorna "false".
    }
}
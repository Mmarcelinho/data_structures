namespace dsa_study.array;

public class MoveZeros
{
    // Método principal para executar demonstrações de funcionalidades da classe.
    // static void Main()
    // {
    //     MoveZeros moveZeros = new();
    //     moveZeros.arrayDemo();
    // }

    // Método para demonstrar a funcionalidade de mover zeros para o fim de um array.
    public void arrayDemo()
    {
        int[] array = { 8, 1, 0, 2, 1, 0, 3 };
        printArray(array); // Imprime o array antes da operação
        moveZeros(array, array.Length); // Executa o método para mover zeros
        printArray(array); // Imprime o array após mover os zeros
    }

    // Imprime todos os elementos de um array, separados por espaço.
    public void printArray(int[] array)
    {
        int numeroDeElementos = array.Length;

        for (int i = 0; i < numeroDeElementos; i++)
        {
            Console.Write(array[i] + " "); // Imprime cada elemento seguido de um espaço
        }
        Console.WriteLine(); // Finaliza com uma nova linha
    }

    // Método para mover todos os zeros de um array para o seu final, mantendo a ordem relativa dos outros elementos.
    public void moveZeros(int[] array, int numeroDeElementos)
    {
        int j = 0; // Inicializa o ponteiro 'j' para a posição do primeiro elemento não-zero
        for (int i = 0; i < numeroDeElementos; i++)
        {
            if (array[i] != 0)
            {
                // Se o elemento atual não for zero e 'j' for menor que 'i', troca os elementos
                if (i != j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
                j++; // Incrementa 'j' para apontar para o próximo elemento potencialmente zero
            }
        }
    }
}

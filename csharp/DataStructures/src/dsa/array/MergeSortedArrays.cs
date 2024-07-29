namespace dsa.array;

public class MergeSortedArrays
{
    // static void Main()
    // {
    //     MergeSortedArrays msa = new ();
    //     int[] array1 = { 0, 1, 8, 10 };
    //     int[] array2 = { 2, 4, 11, 15, 20 };
    //     msa.printArray(array1);
    //     msa.printArray(array2);

    //     int[] resultado = msa.merge(array1, array2, array1.Length, array2.Length);
    //     msa.printArray(resultado);
    // }

    // Método para imprimir todos os elementos de um array.
    public void printArray(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n; i++)
        {
            Console.Write(array[i] + " "); // Imprime cada elemento seguido de um espaço.
        }
        Console.WriteLine(); // Insere uma nova linha após imprimir todos os elementos do array.
    }

    // Método para mesclar dois arrays ordenados em um novo array também ordenado.
    public int[] merge(int[] array1, int[] array2, int n, int m)
    {
        int[] resultado = new int[n + m]; // Cria um array para guardar o resultado da mesclagem.
        int i = 0; // Índice para o primeiro array.
        int j = 0; // Índice para o segundo array.
        int k = 0; // Índice para o array de resultado.

        // Enquanto ambos os arrays ainda têm elementos não processados, pegue o menor elemento.
        while (i < n && j < m)
        {
            if (array1[i] < array2[j])
            {
                resultado[k] = array1[i]; // Adiciona o elemento de array1 ao resultado se for menor.
                i++; // Incrementa o índice de array1.
            }
            else
            {
                resultado[k] = array2[j]; // Adiciona o elemento de array2 ao resultado se for menor ou igual.
                j++; // Incrementa o índice de array2.
            }
            k++; // Incrementa o índice do array resultado.
        }

        // Se ainda restam elementos em array1, adiciona todos ao final do array resultado.
        while (i < n)
        {
            resultado[k] = array1[i];
            i++;
            k++;
        }

        // Se ainda restam elementos em array2, adiciona todos ao final do array resultado.
        while (j < m)
        {
            resultado[k] = array2[j];
            j++;
            k++;
        }

        return resultado; // Retorna o array resultado mesclado e ordenado.
    }
}

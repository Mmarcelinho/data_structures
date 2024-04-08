namespace dsa_study.array;

public class MergeSortedArrays
{
    static void Main()
    {
        MergeSortedArrays msa = new ();
        int[] array1 = { 0, 1, 8, 10 };
        int[] array2 = { 2, 4, 11, 15, 20 };
        msa.printArray(array1);
        msa.printArray(array2);

        int[] resultado = msa.merge(array1, array2, array1.Length, array2.Length);
        msa.printArray(resultado);
    }

    public void printArray(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
    public int[] merge(int[] array1, int[] array2, int n, int m)
    {
        int[] resultado = new int[n + m];
        int i = 0;
        int j = 0;
        int k = 0;

        while (i < n && j < m)
        {
            if (array1[i] < array2[j])
            {
                resultado[k] = array1[i];
                i++;
            }
            else
            {
                resultado[k] = array2[j];
                j++;
            }
            k++;
        }

        while (i < n)
        {
            resultado[k] = array1[i];
            i++;
            k++;
        }

        while (j < m)
        {
            resultado[k] = array2[j];
            j++;
            k++;
        }

        return resultado;
    }
}

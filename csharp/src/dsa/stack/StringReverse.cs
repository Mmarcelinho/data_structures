namespace dsa.stack;

public class StringReverse
{
    // static void Main()
    // {
    //     String str = "ABCD";
    //     Console.WriteLine($"Before reverse - {str}");
    //     Console.WriteLine($"After reverse - " + reverse(str));
    // }

    public static String reverse(String str)
    {
        // Uma nova pilha de caracteres é criada.
        Stack<Char> stack = new();
        // A string é convertida em um array de caracteres.
        char[] chars = str.ToCharArray();

        // Cada caractere da string é empurrado para a pilha.
        foreach (char c in chars)
        {
            stack.Push(c);
        }

        // Cada caractere é removido da pilha e colocado de volta no array.
        // Como a pilha é uma estrutura de dados LIFO (Last In, First Out),
        // os caracteres são removidos na ordem inversa em que foram inseridos.
        for (int i = 0; i < str.Length; i++)
        {
            chars[i] = stack.Pop();
        }

        // O array de caracteres é convertido de volta para uma string e retornado.
        return new String(chars);
    }
}


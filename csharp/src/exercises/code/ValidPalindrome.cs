namespace exercises.code;

public class ValidPalindrome
{
   
    public bool IsPalindrome(string inputString)
    {
        int leftPointer = 0;
        int rightPointer = inputString.Length - 1;

        while (leftPointer < rightPointer)
        {
            // Ignora caracteres que não são letras ou dígitos no início da string
            if (!char.IsLetterOrDigit(inputString[leftPointer]))
            {
                leftPointer++;
            }
            // Ignora caracteres que naõ são letras ou dígitos no final da string
            else if (!char.IsLetterOrDigit(inputString[rightPointer]))
            {
                rightPointer--;
            }

            // Compara os caracteres ignorando diferenças de maiúsculas e minúsculas
            else
            {
                if (char.ToLower(inputString[leftPointer]) != char.ToLower(inputString[rightPointer]))
                {
                    return false; //Retorna falso caso não forem iguais, afirmando que a string não é um palíndromo
                }
                //Acrescenta +1 nos ponteiros para comparar os próximos caracteres
                leftPointer++;
                rightPointer--;
            }
        }
        // Retorna true se a string for um palíndromo
        return true;
    }

}

namespace exercises.code;

public class ValidParentheses
{
  
    // Método para verificar se uma string contém parênteses válidos
    public bool IsValid(string s)
    {
        // Cria uma pilha para armazenar os caracteres abertos
        var openStack = new Stack<char>();

        // Define um dicionário para mapear os caracteres de fechamento aos caracteres de abertura correspondentes
        var matchingPairs = new Dictionary<char, char>()
        {
            [')'] = '(',
            [']'] = '[',
            ['}'] = '{'
        };

        // Percorre a string
        foreach (char currentChar in s)
        {
            // Se o caractere atual não é um caractere de fechamento
            if (!matchingPairs.ContainsKey(currentChar))
            {
                // Empilha o caractere de abertura correspondente na pilha
                openStack.Push(currentChar);
            }
            else
            {
                // Se encontramos um caractere de fechamento
                // Verificamos se a pilha está vazia ou se o topo da pilha não corresponde ao caractere de abertura adequado
                if (openStack.Count == 0 || openStack.Pop() != matchingPairs[currentChar])
                {
                    // Se a pilha está vazia ou não há correspondência, retorna falso
                    return false;
                }
            }
        }

        // No final da verificação, a pilha deve estar vazia para que a string seja válida
        return openStack.Count == 0;
    }
}


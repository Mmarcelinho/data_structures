namespace exercises.code;

public class EncodeAndDecodeStrings
{

    public string Encode(List<string> strings)
    {
        // Inicialmente, declaramos um método chamado "Encode" que recebe uma lista de strings como entrada.
        // O objetivo deste método é codificar a lista de strings em uma única string, usando o formato "length#string".
        // Usamos LINQ para mapear cada string na lista para o formato desejado e, em seguida, usamos "string.Concat"
        // para unir todas as strings codificadas em uma única string.
        return string.Concat(strings.Select(s => $"{s.Length}#{s}"));
    }

    public List<string> Decode(string encodedString)
    {
        // Aqui, definimos o método "Decode" que recebe uma string codificada como entrada.
        // O propósito deste método é decodificar a string codificada em uma lista de strings, revertendo o processo
        // de codificação feito no método "Encode".

        var decodedStrings = new List<string>();

        // Inicializamos um índice (currentIndex) para acompanhar a posição atual na string codificada.
        var currentIndex = 0;
        while (currentIndex < encodedString.Length)
        {
            var start = currentIndex;
            while (encodedString[start] != '#')
            {
                ++start;
            }

            // Em seguida, extraímos a parte da string que representa o comprimento da string original.
            // Convertendo essa parte em um inteiro (length).
            int.TryParse(encodedString.Substring(currentIndex, start - currentIndex), out var length);
            start++;
            // Com base no comprimento, extraímos a substring que representa a string original e a adicionamos à lista decodificada.
            decodedStrings.Add(encodedString.Substring(start, length));

            // Atualizamos o índice atual para apontar para o próximo caractere após a string decodificada.
            currentIndex = start + length;
        }
        // Finalmente, retornamos a lista de strings decodificada.
        return decodedStrings;
    }

}

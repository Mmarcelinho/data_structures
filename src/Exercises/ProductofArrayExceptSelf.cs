namespace Exercises;
public class ProductExceptSelf
{
    static void Main()
    { }
    public int[] CalculateProductExceptSelf(int[] inputNumbers)
    {
        int prefixProduct = 1, postfixProduct = 1;
        int[] result = new int[inputNumbers.Length];

        for (int i = 0; i < inputNumbers.Length; i++)
        {
            result[i] = prefixProduct;
            prefixProduct *= inputNumbers[i];
        }

        for (int i = inputNumbers.Length - 1; i >= 0; i--)
        {
            result[i] *= postfixProduct;
            postfixProduct *= inputNumbers[i];
        }

        return result;
    }
}

// Este algoritmo calcula o produto de todos os elementos em um array de entrada, exceto o elemento na posição atual.
// Para fazer isso, usamos duas variáveis: prefixProduct e postfixProduct, inicializadas com o valor 1.
// Também criamos um array de resultados chamado "result" com o mesmo tamanho que o array de entrada "inputNumbers".

// Primeira fase: Cálculo do prefixo
// Inicializamos prefixProduct como 1.
// Em um loop for, percorremos o array "inputNumbers" e, em cada iteração:
//   - Atribuímos o valor atual de prefixProduct ao elemento correspondente em "result".
//   - Multiplicamos prefixProduct pelo elemento atual em "inputNumbers".
// Isso resulta em um array "result" que contém os produtos à esquerda de cada elemento em "inputNumbers".

// Exemplo passo a passo:
// inputNumbers[1, 2, 3, 4]  result[1, 1, 2, 6]

// Segunda fase: Cálculo do sufixo
// Agora, calculamos o produto à direita de cada elemento.
// Iniciamos postfixProduct como 1 e percorremos o array "result" de trás para frente (do último elemento ao primeiro).
// Em cada iteração:
//   - Multiplicamos o elemento atual em "result" pelo valor atual de postfixProduct.
//   - Atualizamos postfixProduct multiplicando-o pelo elemento correspondente em "inputNumbers".
// Isso resulta em um array "result" que contém os produtos à esquerda e à direita de cada elemento em "inputNumbers".

// Exemplo passo a passo:
// [1] [1] [2] [6] * postfixProduct = 1  postfixProduct = 1 * inputNumbers[i] = 4
// [1] [1] [2] * postfixProduct = 4  [6]  postfixProduct = 4 * inputNumbers[i] = 3
// [1] [1] * postfixProduct = 12 [8] [6]  postfixProduct = 12 * inputNumbers[i] = 2
// [1] * postfixProduct = 24 [12] [8] [6]  postfixProduct = 24 * inputNumbers[i] = 1

// O resultado final é um array "result" que contém os produtos de todos os elementos em "inputNumbers" exceto o elemento na posição atual.

// Exemplo final:
// [24] [12] [8] [6]

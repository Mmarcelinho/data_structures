namespace Exercises.Solutions;

public class AddTwoNumbers
{

    // Definição da classe ListNode que representa um nó em uma lista ligada
    public class ListNode
    {
        public int val; // Valor armazenado no nó
        public ListNode next; // Referência para o próximo nó na lista
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            // Cria um nó inicial para a lista ligada de resultado
            ListNode sumList = new(0);
            // 'current' aponta para o nó inicial de sumList
            var current = sumList;
            // 'carry' armazena o valor que "sobra" das somas que ultrapassam 9
            int carry = 0;

            // Loop continua enquanto qualquer uma das listas l1 ou l2 não são nulas ou há um carry
            while (l1 != null || l2 != null || carry == 1)
            {
                // Se l1 for nulo, v1 recebe 0, caso contrário, v1 recebe l1.val
                var v1 = l1 == null ? 0 : l1.val;
                // Se l2 for nulo, v2 recebe 0, caso contrário, v2 recebe l2.val 
                var v2 = l2 == null ? 0 : l2.val;

                // Soma os valores v1, v2 e carry
                int sum = v1 + v2 + carry;
                // Atualiza carry. Se a soma for maior que 9, carry será 1, caso contrário, 0
                carry = sum > 9 ? 1 : 0;
                // Pega o dígito das unidades da soma (0-9)
                sum = sum % 10;
                // Cria um novo nó com o valor da soma e o adiciona na lista resultante
                current.next = new ListNode(sum);
                // Move current para o próximo nó na lista resultante
                current = current.next;

                // Move para o próximo nó em l1, se existir
                l1 = l1 == null ? null : l1.next;
                // Move para o próximo nó em l2, se existir
                l2 = l2 == null ? null : l2.next;
            }

            // Retorna a lista resultante, ignorando o nó inicial de valor 0
            return sumList.next;
        }
    }
}

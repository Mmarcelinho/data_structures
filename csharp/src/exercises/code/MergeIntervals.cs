namespace exercises.code;

public class MergeIntervals
{
    public class Solution
    {
        public int[][] Merge(int[][] intervals)
        {
            if (intervals.Length == 0) return []; // Retorna um array vazio se não houver intervalos

            // Ordenação dos Intervalos
            var sortedInterval = intervals.Clone() as int[][]; // Clona o array original para não modificá-lo
            Array.Sort(sortedInterval, (a, b) => a[0] - b[0]); // Ordena os intervalos pelo ponto de início

            // Inicialização da Resposta
            var mergedInterval = new List<int[]>(); // Lista para armazenar os intervalos combinados
            var lastInterval = sortedInterval[0]; // O primeiro intervalo é adicionado à lista
            mergedInterval.Add(lastInterval);

            // Iteração sobre os Intervalos (a partir do segundo)
            for (var i = 1; i < sortedInterval.Length; i++)
            {
                // Obter informações do intervalo atual e do último intervalo adicionado
                var current = sortedInterval[i];
                var lastIntervalEnd = lastInterval[1];
                var nextIntervalEnd = current[1];
                var nextIntervalStart = current[0];

                // Verificação de Sobreposição
                if (lastIntervalEnd >= nextIntervalStart) // Se houver sobreposição
                {
                    // Combinação de Intervalos Sobrepostos
                    lastInterval[1] = Math.Max(nextIntervalEnd, lastIntervalEnd); // Atualiza o ponto final do último intervalo
                }
                else // Se não houver sobreposição
                {
                    // Adição de Intervalos Não Sobrepostos
                    lastInterval = current; // Atualiza o último intervalo
                    mergedInterval.Add(lastInterval); // Adiciona o intervalo atual à lista
                }
            }

            // Retorno do Resultado
            return mergedInterval.ToArray(); // Converte a lista em array e retorna
        }
    }

}
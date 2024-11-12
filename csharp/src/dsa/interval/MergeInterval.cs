namespace dsa.interval;

public class MergeInterval
{
    // static void Main()
    // {
    //     MergeInterval mergeInterval = new MergeInterval();
    //     List<Interval> intervals = new List<Interval>
    //         {
    //             new Interval(0, 1),
    //             new Interval(3, 5),
    //             new Interval(7, 8),
    //             new Interval(9, 10)
    //         };

    //     // Adiciona e mescla o novo intervalo
    //     List<Interval> merge = mergeInterval.Insert(intervals, new Interval(2, 6));
    //     foreach (Interval a in merge)
    //     {
    //         Console.WriteLine($"{a.Start},{a.End}");
    //     }

    //     // Exemplo adicional de mesclagem de intervalos
    //     /* 
    //     List<Interval> intervals1 = new List<Interval>
    //     {
    //         new Interval(6, 7),
    //         new Interval(2, 4),
    //         new Interval(5, 9)
    //     };
    //     List<Interval> merge1 = mergeInterval.Merge(intervals1);
    //     foreach (Interval a in merge1)
    //     {
    //         Console.WriteLine($"{a.Start},{a.End}");
    //     }
    //     */

    //     // Outro exemplo de mesclagem de intervalos
    //     /*
    //     List<Interval> intervals2 = new List<Interval>
    //     {
    //         new Interval(1, 4),
    //         new Interval(2, 6),
    //         new Interval(3, 5)
    //     };
    //     List<Interval> merge2 = mergeInterval.Merge(intervals2);
    //     foreach (Interval a in merge2)
    //     {
    //         Console.WriteLine($"{a.Start},{a.End}");
    //     }
    //     */
    // }

    // Definição da classe Intervalo
    public class Interval
    {
        public int Start { get; set; }
        public int End { get; set; }

        public Interval(int start, int end)
        {
            Start = start;
            End = end;
        }
    }

    // Método para inserir um novo intervalo em uma lista de intervalos
    public List<Interval> Insert(List<Interval> intervals, Interval newInterval)
    {
        if (intervals == null || intervals.Count == 0)
            return intervals;

        List<Interval> result = new List<Interval>();
        int i = 0;

        // Adiciona os intervalos que terminam antes do novo intervalo começar

        while (i < intervals.Count && intervals[i].End < newInterval.Start)
        {
            result.Add(intervals[i]);
            i++;
        }

        // Combina os intervalos que se sobrepõem com o novo intervalo
        while (i < intervals.Count && intervals[i].Start <= newInterval.End)
        {
            Interval current = intervals[i];
            newInterval.Start = Math.Min(current.Start, newInterval.Start);
            newInterval.End = Math.Max(current.End, newInterval.End);
            i++;
        }

        result.Add(newInterval);

        // Adiciona os intervalos restantes
        while (i < intervals.Count)
        {
            result.Add(intervals[i]);
            i++;
        }
        return result;
    }

    // Método para mesclar os intervalos na lista
    public List<Interval> Merge(List<Interval> intervals)
    {
        if (intervals.Count < 2)
            return intervals;

        // Ordena os intervalos com base no início
        intervals.OrderBy(interval => interval.Start).ToList();

        List<Interval> mergedIntervals = new List<Interval>();
        Interval interval = intervals[0];
        int start = interval.Start;
        int end = interval.End;

        // Percorre os intervalos para mesclar os sobrepostos
        foreach (Interval curr in intervals)
        {
            if (curr.Start <= end)
            {
                end = Math.Max(curr.End, end);
            }
            else
            {
                mergedIntervals.Add(new Interval(start, end));
                start = curr.Start;
                end = curr.End;
            }
        }

        mergedIntervals.Add(new Interval(start, end));
        return mergedIntervals;
    }
}

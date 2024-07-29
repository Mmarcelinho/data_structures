package interval

import "sort"

// Interval define a estrutura de um intervalo com um início e um fim.
type Interval struct {
	Start int
	End   int
}

// MergeInterval é uma estrutura que encapsula métodos para manipular intervalos.
type MergeInterval struct{}

// Insert insere um novo intervalo em uma lista de intervalos e mescla intervalos sobrepostos.
func (mi *MergeInterval) Insert(intervals []Interval, newInterval Interval) []Interval {
	// Se a lista de intervalos estiver vazia, retorna-a diretamente.
	if len(intervals) == 0 {
		return intervals
	}

	result := []Interval{}
	i := 0

	// Adiciona os intervalos que terminam antes do novo intervalo começar.
	for i < len(intervals) && intervals[i].End < newInterval.Start {
		result = append(result, intervals[i])
		i++
	}

	// Combina os intervalos que se sobrepõem com o novo intervalo.
	for i < len(intervals) && intervals[i].Start <= newInterval.End {
		newInterval.Start = min(intervals[i].Start, newInterval.Start)
		newInterval.End = max(intervals[i].End, newInterval.End)
		i++
	}

	// Adiciona o novo intervalo mesclado.
	result = append(result, newInterval)

	// Adiciona os intervalos restantes.
	for i < len(intervals) {
		result = append(result, intervals[i])
		i++
	}

	return result
}

// Merge mescla intervalos sobrepostos em uma lista de intervalos.
func (mi *MergeInterval) Merge(intervals []Interval) []Interval {
	// Se houver menos de dois intervalos, retorna a lista diretamente.
	if len(intervals) < 2 {
		return intervals
	}

	// Ordena os intervalos com base no início.
	sort.Slice(intervals, func(i, j int) bool {
		return intervals[i].Start < intervals[j].Start
	})

	mergedIntervals := []Interval{}
	start := intervals[0].Start
	end := intervals[0].End

	// Percorre os intervalos para mesclar os sobrepostos.
	for _, curr := range intervals {
		if curr.Start <= end {
			// Se o intervalo atual se sobrepõe com o intervalo anterior, ajusta o fim do intervalo mesclado.
			end = max(curr.End, end)
		} else {
			// Se o intervalo atual não se sobrepõe, adiciona o intervalo mesclado e inicia um novo.
			mergedIntervals = append(mergedIntervals, Interval{start, end})
			start = curr.Start
			end = curr.End
		}
	}

	// Adiciona o último intervalo mesclado.
	mergedIntervals = append(mergedIntervals, Interval{start, end})
	return mergedIntervals
}

// min retorna o menor valor entre dois inteiros.
func min(a, b int) int {
	if a < b {
		return a
	}
	return b
}

// max retorna o maior valor entre dois inteiros.
func max(a, b int) int {
	if a > b {
		return a
	}
	return b
}

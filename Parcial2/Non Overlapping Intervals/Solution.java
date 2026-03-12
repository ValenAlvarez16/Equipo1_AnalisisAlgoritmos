class Solution {
    // Determinar el número mínimo de intervalos que se deben eliminar
    // para que el resto no se solapen entre sí.
    //
    // Estrategia: algoritmo greedy seleccionando la mayor cantidad posible
    // de intervalos no superpuestos.
    //
    // Complejidad temporal: O(n log n) debido al ordenamiento de los intervalos.
    // Complejidad espacial: O(1) adicional (sin contar el espacio usado por sort).
    public int eraseOverlapIntervals(int[][] intervals) {
        Arrays.sort(intervals, (a, b) -> a[1] - b[1]);

        int kept = 1;
        int prevEnd = intervals[0][1];

        for (int i = 1; i < intervals.length; i++) {
            int start = intervals[i][0];
            int end = intervals[i][1];
            if (start >= prevEnd) {
                kept++;
                prevEnd = end;
            }
        }

        return intervals.length - kept;
    }
}
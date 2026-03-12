class Solution {
    // Objetivo: determinar el número mínimo de intervalos que se deben eliminar
    // para que los intervalos restantes no se solapen entre sí.
    //
    // Enfoque: algoritmo greedy, seleccionando la mayor cantidad posible
    // de intervalos no superpuestos.
    //
    // Justificación: elegir primero el intervalo que termina antes deja la
    // mayor cantidad de espacio disponible para los siguientes intervalos,
    // lo que permite conservar el máximo número de intervalos no solapados.
    // Al maximizar los intervalos conservados, se minimiza la cantidad
    // de intervalos eliminados.
    //
    // Complejidad temporal: O(n log n), debido al ordenamiento de los intervalos.
    // Complejidad espacial: O(1) adicional, sin contar el espacio usado por sort.
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
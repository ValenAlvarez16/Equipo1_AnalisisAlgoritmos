class Solution {
    // Objetivo: fusionar intervalos que se solapan para obtener un conjunto de
    // intervalos no superpuestos que represente los mismos rangos.
    //
    // Enfoque: algoritmo greedy. Tras ordenar los intervalos por su inicio,
    // se fusionan inmediatamente aquellos que se traslapan, manteniendo
    // siempre el intervalo combinado más amplio posible hasta ese punto.
    //
    // Justificación: al estar ordenados por inicio, si un intervalo se solapa,
    // solo puede hacerlo con el último intervalo fusionado. Por ello, fusionarlos
    // de inmediato conserva toda la información de los rangos cubiertos y
    // garantiza una solución correcta.
    //
    // Complejidad temporal: O(n log n), debido al ordenamiento.
    // Complejidad espacial: O(n), por la estructura usada para almacenar el resultado.
    public int[][] merge(int[][] intervals) {
        Arrays.sort(intervals, (a, b) -> a[0] - b[0]);
        List<int[]> result = new ArrayList<>();

        for(int[] interval : intervals) {
            if (result.isEmpty() || result.get(result.size() - 1)[1] < interval[0]) {
                result.add(interval);
            } else {
                result.get(result.size() - 1)[1] = Math.max(result.get(result.size() - 1)[1], interval[1]);
            }
        }

        return result.toArray(new int[result.size()][]);
    }
}
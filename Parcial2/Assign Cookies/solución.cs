public class Solution {

    /// <summary>
    /// Calcula cuántos niños pueden quedar satisfechos con las galletas disponibles.
    /// Ordena los niños y las galletas y las compara para asignarlas.
    /// 
    /// Args:
    ///     g: Arreglo con el nivel de avaricia de cada niño (tamaño mínimo de galleta que necesita).
    ///     s: Arreglo con el tamaño de cada galleta.
    /// 
    /// Returns:
    ///     Número máximo de niños que pueden recibir una galleta suficiente.
    /// 
    /// Complejidad:
    ///     Tiempo: O(n log n + m log m) por la ordenación de los arreglos.
    ///     Espacio: O(1).
    /// </summary>

    public int FindContentChildren(int[] g, int[] s) {
        Array.Sort(g);
        Array.Sort(s);
        
        int nino = 0;
        int galleta = 0;
        
        while (nino < g.Length && galleta < s.Length) {
            if (s[galleta] >= g[nino]) {
                nino++;
            }
            galleta++;
        }
        
        return nino;
    }
}

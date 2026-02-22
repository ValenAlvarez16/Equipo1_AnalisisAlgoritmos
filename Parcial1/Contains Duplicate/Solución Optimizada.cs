public class Solution {

    /// <summary>
    /// Revisa si el arreglo tiene números repetidos usando una solución optimizada.
    /// 
    /// Recorre el arreglo una sola vez. Para cada número revisa si ya apareció antes.
    /// Si ya está en el conjunto, significa que hay un duplicado y retorna true.
    /// Si no, lo guarda y continúa con el siguiente. Si termina el recorrido sin
    /// encontrar repetidos, retorna false.
    /// 
    /// Args:
    ///     nums: Arreglo de enteros.
    /// 
    /// Returns:
    ///     true si hay al menos un número repetido.
    ///     false si todos son distintos.
    /// 
    /// Complejidad:
    ///     Tiempo: O(n)
    ///     Espacio: O(n) porque el HashSet puede almacenar hasta n elementos.
    /// </summary>

    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> seen = new HashSet<int>();

        foreach (int num in nums)
        {
            if (seen.Contains(num))
                return true;

            seen.Add(num);
        }

        return false;
    }
}

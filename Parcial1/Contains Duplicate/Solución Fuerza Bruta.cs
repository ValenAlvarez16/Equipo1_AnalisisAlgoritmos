public class Solution {

    /// <summary>
    /// Revisa si el arreglo tiene números repetidos usando fuerza bruta.
    /// 
    /// Primero ordena el arreglo para que los números iguales queden juntos.
    /// Luego recorre el arreglo y compara cada número con el que sigue.
    /// Si en algún momento encuentra dos números iguales, significa que
    /// hay un duplicado y retorna true. Si termina sin encontrar repetidos,
    /// retorna false.
    /// 
    /// Args:
    ///     nums: Arreglo de enteros.
    /// 
    /// Returns:
    ///     true si hay al menos un número repetido.
    ///     false si todos son distintos.
    /// 
    /// Complejidad:
    ///     Tiempo: O(n log n)
    ///     Espacio: O(1)
    /// </summary>

    public bool ContainsDuplicate(int[] nums) {
        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == nums[i + 1])
                return true;
        }

        return false;
    }
}

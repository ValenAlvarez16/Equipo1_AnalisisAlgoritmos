public class Solution {

    /// <summary>
    /// Devuelve la longitud de la subsecuencia estrictamente creciente más larga.
    /// Usa programación dinámica, donde se va guardando la mejor longitud posible
    /// para cada posición comparándola con los valores anteriores.
    ///
    /// Args:
    ///     nums: Arreglo de enteros donde se busca la subsecuencia.
    ///
    /// Returns:
    ///     Longitud de la subsecuencia estrictamente creciente más larga.
    ///
    /// Complejidad:
    ///     Tiempo: O(n²) por el doble recorrido del arreglo.
    ///     Espacio: O(n) por el arreglo auxiliar.
    /// </summary>

    public int LengthOfLIS(int[] nums) {
        int n = nums.Length;
        int[] dp = new int[n];

        Array.Fill(dp, 1);

        for (int i = 1; i < n; i++) {
            for (int j = 0; j < i; j++) {
                if (nums[j] < nums[i]) {
                    dp[i] = Math.Max(dp[i], dp[j] + 1);
                }
            }
        }

        return dp.Max();
    }
}

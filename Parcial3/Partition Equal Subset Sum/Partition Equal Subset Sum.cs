/*
    Intentamos dividir el arreglo en dos subconjuntos con igual suma. La idea es encontrar un subconjunto cuya suma sea la mitad del total.

    Args: nums: Arreglo de enteros.
    Returns: Verdadero si se peude dividir en dos subconjuntos iguales, de lo contrario falso.
    Complejidad: Tiempo: O(n * target), Espacio: O(target)
*/
public class Solution {
    public bool CanPartition(int[] nums) {
        int total = 0;

        foreach (int num in nums) total += num;

        if (total % 2 != 0) return false;

        int target = total / 2;
        bool[] dp = new bool[target + 1];
        dp[0] = true;

        foreach (int num in nums)
        {
            for (int i = target; i >= num; i--)
            {
                dp[i] = dp[i] || dp[i - num];
            }
        }

        return dp[target];
    }
}
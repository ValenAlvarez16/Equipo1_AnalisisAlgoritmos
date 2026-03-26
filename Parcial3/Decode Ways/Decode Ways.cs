/*
    Devuelve las formas a de decodificar una cadena.
    Utilizamos DP recorriendo de derecha a izquierda y evaluando si se puede tomar 1 o 2 dígitos válidos en cada posición.
    s: Cadena de dígitos.
    Return: Número de formas de decodificación.
    Complejidad: Tiempo: O(n), Espacio: O(1).
*/
public class Solution {
    public int NumDecodings(string s) {
        int n = s.Length, dp1 = 1, dp2 = 0;        

        for (int i = n - 1; i >= 0; i--) {

            int dp = s[i] == '0' ? 0 : dp1;

            if (i < n - 1 && (s[i] == '1' || (s[i] == '2' && s[i + 1] < '7'))) {
                dp += dp2;
            }

            dp2 = dp1;
            dp1 = dp;
        }

        return dp1;
    }
}
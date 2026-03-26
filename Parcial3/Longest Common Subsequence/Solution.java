// Estado DP:   dp[i][j] = longitud de la LCS entre text1[:i] y text2[:j]
// Transición:  dp[i][j] = dp[i-1][j-1] + 1             si text1[i-1] == text2[j-1]
//              dp[i][j] = max(dp[i-1][j], dp[i][j-1])   si no coinciden
// Tiempo:      O(m × n)   donde m = text1.length(), n = text2.length()
// Espacio:     O(m × n)   tabla 2D de (m+1) × (n+1)
// Respuesta:   dp[m][n]

class Solution {
    public int longestCommonSubsequence(String text1, String text2) {
        int m = text1.length();
        int n = text2.length();

        // Tabla DP inicializada en 0
        // dp[i][j] representa la LCS de text1[:i] y text2[:j]
        int[][] dp = new int[m + 1][n + 1];

        for (int i = 1; i <= m; i++) {
            for (int j = 1; j <= n; j++) {
                if (text1.charAt(i - 1) == text2.charAt(j - 1)) {
                    // Caracteres iguales: extender la LCS anterior (diagonal)
                    dp[i][j] = dp[i - 1][j - 1] + 1;
                } else {
                    // Caracteres distintos: tomar el mejor subproblema previo
                    dp[i][j] = Math.max(dp[i - 1][j], dp[i][j - 1]);
                }
            }
        }

        // La LCS completa de ambas cadenas está en la esquina inferior derecha
        return dp[m][n];
    }
}
public class Solution {

    /// <summary>
    /// Determina si una cadena se puede separar en palabras del diccionario.
    /// Va revisando distintas particiones y marca cuáles posiciones se pueden formar.
    ///
    /// Args:
    ///     s: Cadena a evaluar.
    ///     wordDict: Lista de palabras disponibles.
    ///
    /// Returns:
    ///     true si se puede formar la cadena, false en caso contrario.
    ///
    /// Complejidad:
    ///     Tiempo: O(n²).
    ///     Espacio: O(n).
    /// </summary>

    public bool WordBreak(string s, IList<string> wordDict) {
        HashSet<string> words = new HashSet<string>(wordDict);
        bool[] alcanzable = new bool[s.Length + 1];

        alcanzable[0] = true;

        for (int i = 1; i <= s.Length; i++) {
            for (int j = 0; j < i; j++) {
                if (alcanzable[j] && words.Contains(s.Substring(j, i - j))) {
                    alcanzable[i] = true;
                    break;
                }
            }
        }

        return alcanzable[s.Length];
    }
}

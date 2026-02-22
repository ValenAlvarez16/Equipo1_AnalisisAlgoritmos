public class Solution {

    /// <summary>
    /// Revisa si dos palabras son anagramas usando conteo de letras.
    /// 
    /// Primero cuenta cuántas veces aparece cada letra en la primera palabra.
    /// Luego recorre la segunda y va restando esos valores. Si alguna letra
    /// no existe o el conteo se vuelve negativo, significa que no son anagramas.
    /// 
    /// Args:
    ///     s: Primera palabra.
    ///     t: Segunda palabra.
    /// 
    /// Returns:
    ///     true si tienen las mismas letras con la misma cantidad.
    ///     false en caso contrario.
    /// 
    /// Complejidad:
    ///     Tiempo: O(n)
    ///     Espacio: O(1) porque solo hay 26 letras posibles.
    /// </summary>

    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;

        Dictionary<char, int> count = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if (count.ContainsKey(c))
                count[c]++;
            else
                count[c] = 1;
        }

        foreach (char c in t)
        {
            if (!count.ContainsKey(c))
                return false;

            count[c]--;

            if (count[c] < 0)
                return false;
        }

        return true;
    }
}

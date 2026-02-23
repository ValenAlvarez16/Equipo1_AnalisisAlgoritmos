public class Solution{

    /// <summary>
    /// Revisa si dos palabras son anagramas.
    /// 
    /// Toma cada letra de la primera palabra y la busca en una copia
    /// de la segunda. Si la encuentra, la elimina para no repetirla.
    /// Si en algún momento no aparece o las longitudes son diferentes,
    /// entonces no son anagramas.
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
    ///     Tiempo: O(n²)
    ///     Espacio: O(n)
    /// </summary>

    public bool IsAnagram(string s, string t){
        if (s.Length != t.Length)
            return false;

        List<char> tList = new List<char>(t);

        foreach (char c in s)
        {
            if (!tList.Contains(c))
                return false;

            tList.Remove(c);
        }

        return true;
    }
}

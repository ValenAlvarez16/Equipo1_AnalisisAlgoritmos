import java.util.*;

public class Optimizada {
    /*
        Complejidad temporal: O(n)

        El algoritmo recorre la cadena una sola vez, comparando cada carácter con el anterior.
        No hay ciclos anidados.
        Por lo tanto, la complejidad es lineal respecto a n.
    */
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int n = sc.nextInt();
        String s = sc.next();

        int removed = 0;
        for (int i = 1; i < n; i++) {
            if (s.charAt(i) == s.charAt(i - 1)) {
                removed++;
            }
        }

        System.out.println(removed);
        sc.close();
    }
}
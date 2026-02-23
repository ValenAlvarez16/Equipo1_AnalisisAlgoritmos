import java.util.*;
public class FuerzaBruta {
    /*
        Complejidad temporal: O(n²)

        Cada vez que encontramos dos piedras iguales consecutivas, eliminamos una reconstruyendo la cadena.
        Las operaciones sobre String generan copias.
    */
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int n = sc.nextInt();
        String s = sc.next();

        int removed = 0;
        for (int i = 1; i < n; i++) {
            if (s.charAt(i) == s.charAt(i - 1)) {
                s = s.substring(0, i) + s.substring(i + 1);
                removed++;
                n--;
                i--;
            }
        }

        System.out.println(removed);
        sc.close();
    }
}
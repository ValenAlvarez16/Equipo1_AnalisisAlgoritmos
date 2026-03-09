/*
    Justificación Greedy

    Se utiliza greedy ya que en cada posición mantiene el mayor alcance posible de saltos. A medida que recorre el arreglo, se actualiza jump cuando
    encuentra una posición desde la cual se puede llegar más lejos. En cada iteración se resta un salto porque se avanza una posición; 
    si jump llega a ser menor que 0 significa que no se puede continuar. Asi siempre la mejor decisión para avanzar lo más lejos posible, con 
    complejidad O(N) en tiempo y O(1) en espacio.
*/
public class Solution
{
    public bool CanJump(int[] nums)
    {
        int jump = 0;
        foreach (int n in nums)
        {
            if (jump < 0)
                return false;
            else if (n > jump)
                jump = n;

            jump--;
        }
        return true;
    }
}
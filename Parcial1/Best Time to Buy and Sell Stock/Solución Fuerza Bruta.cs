/*
    - Se realiza por fuerza bruta O(N^2), 
    - Variable para la ganancia máxima.
    - Recorremos el arreglo para tomar el día de compra.
    - Para cada día de compra, recorremos los días siguientes como posibles días de venta.
    - Si la ganancia (venta - compra) es mayor que la ganancia máxima actual, actualizamos la ganancia máxima.
*/
public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int GananciaMax = 0, T = prices.Length;

        for (int i = 0; i < T - 1; i++)
        {
            for (int n = i + 1; n < T; n++)
            {
                if ((prices[n] - prices[i]) > GananciaMax)
                    GananciaMax = prices[n] - prices[i];
            }
        }
        return GananciaMax;
    }
}
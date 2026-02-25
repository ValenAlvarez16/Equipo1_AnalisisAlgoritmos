/*
    - Se optimiza y se logra O(n) tiempo, O(1) espacio.
    - Se recorre el vector una sola vez pero se mantiene el precio minimos, en cada
        iteracion se calcula la posible ganancia si vendiera en el día actual y actualizo la ganancia máxima.
*/
using System;

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int GananciaMax = 0, BuyPrice = int.MaxValue;

        for (int i = 0; i < prices.Length; i++)
        {
            BuyPrice = Math.Min(BuyPrice, prices[i]);
            GananciaMax = Math.Max(GananciaMax, prices[i] - BuyPrice);
        }
        return GananciaMax;
    }
}
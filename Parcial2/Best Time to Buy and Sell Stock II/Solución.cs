public class Solution {

    /// <summary>
    /// Calcula la ganancia máxima posible al comprar y vender acciones.
    /// Recorre los precios y suma cada vez que el precio sube de un día a otro.
    /// 
    /// Args:
    ///     prices: Arreglo con el precio de la acción en cada día.
    /// 
    /// Returns:
    ///     Ganancia máxima que se puede obtener.
    /// 
    /// Complejidad:
    ///     Tiempo: O(n) porque se recorre el arreglo una sola vez.
    ///     Espacio: O(1).
    /// </summary>
    
    public int MaxProfit(int[] prices) {
        int ganancia = 0;

        for (int i = 1; i < prices.Length; i++) {
            if (prices[i] > prices[i - 1]) {
                ganancia += prices[i] - prices[i - 1];
            }
        }

        return ganancia;
    }
}

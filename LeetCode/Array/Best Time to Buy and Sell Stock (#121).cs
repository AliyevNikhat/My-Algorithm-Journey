public class Solution {
    public int MaxProfit(int[] prices) {
            int minPrice = prices[0];
            int MaxProfit = 0;
            for(int i=0; i<prices.Length;i++)
            {
                if(minPrice > prices[i])
                {
                    minPrice = prices[i];
                }
                int current = prices[i] - minPrice;
                if(MaxProfit < current)
                {
                    MaxProfit = current;
                }
            }
            return MaxProfit;
    }
}
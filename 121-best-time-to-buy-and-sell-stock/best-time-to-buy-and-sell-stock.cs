public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit=0;
        int profit=0;
        int minPrice=prices[0];

        for(int i=0;i<prices.Length;i++)
        {
            if(minPrice>prices[i])
            {
                minPrice=prices[i];
            }

            profit=prices[i]-minPrice;

            if(maxProfit<profit)
            {
                maxProfit=profit;
            }
        }
        return maxProfit;
    }
}
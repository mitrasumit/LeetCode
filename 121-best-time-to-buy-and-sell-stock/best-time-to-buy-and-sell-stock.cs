public class Solution {
    public int MaxProfit(int[] prices) 
    {
        int i=0;
        int maxProfit=0;
        int minValue=prices[0];

        for(i=0;i<prices.Length;i++)
        {
            if(minValue>prices[i])
            {
                minValue=prices[i];
            }

            if(maxProfit<prices[i]-minValue)
            {
                maxProfit=prices[i]-minValue;
            }
        }
        return maxProfit;
    }
}
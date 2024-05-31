internal class Program
{
    private static void Main(string[] args)
    {
        //int[] prices = { 7, 1, 5, 3, 6, 4 };
        int[] prices = { 2, 1, 4 };
        var profit = MaxProfit(prices);
        Console.ReadLine();
    }

    private static int MaxProfit(int[] prices)
    {
        int buyIndx = 0;
        int sellIndx = 1;
        int maxProfit = 0;
        while (sellIndx < prices.Length)
        {
            int profit = prices[sellIndx] - prices[buyIndx];
            if (profit >= 0)
            {
                if (profit > maxProfit) maxProfit = profit;
            }
            else
            {
                buyIndx = sellIndx;
            }
            sellIndx++;
        }
        return maxProfit;
    }

    //The points of interest are the peaks and valleys in the given graph. 
    // We need to find the largest price following each valley, which difference could be the max profit.
    // We can maintain two variables - minprice and maxprofit corresponding to the smallest valley 
    // and maximum profit (maximum difference between selling price and minprice) obtained so far respectively.
    private static int MaxProfitLeetCode(int[] prices)
    {
        int minprice = int.MaxValue;
        int maxprofit = 0;
        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < minprice)
                minprice = prices[i];
            else if (prices[i] - minprice > maxprofit)
                maxprofit = prices[i] - minprice;
        }

        return maxprofit;
    }
}
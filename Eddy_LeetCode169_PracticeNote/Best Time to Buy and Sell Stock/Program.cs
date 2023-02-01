// See https://aka.ms/new-console-template for more information
int[] arrayQuestion = new []{1,4,7,6,5};
Console.WriteLine("Hello, World!");


public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int result = 0; 
        List<int> list = new List<int>();
        // 微分抓區間，區間比大小
        for (int i = 0; i < prices.Length; i++)
        {
            list.Add(prices[i + 1] - prices[i]);
        }

        //int localPriceChange = 0;
        //int localMaxDayPrice = 0;
        //int localMinDayPrice = 0;
        //foreach (var dayPrice in prices)
        //{
        //    dayPrice
        //    if (dayPrice > localMaxDayPrice) localMaxDayPrice = dayPrice;
        //    if (dayPrice < localMaxDayPrice) localMaxDayPrice = dayPrice;
        //}


        return result;
    }
}
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
    //// See https://aka.ms/new-console-template for more information
    //using System.Collections.Generic;

    //Console.WriteLine("Hello, World!");
    //int[] input = new int[] { 1, 2, 4, 8, 2, 4, 5 };
    //List <int> slope = new List<int>();
    ////List<Dictionary<string, int>> isSlopeChange = new List<Dictionary<string, int>>();
    //List <int> localMaxima = new List<int>();
    //List<int> localMinima = new List<int>();
    //bool Is
    //for (int i = 0; i < input.Length - 1; i++)
    //{
    //    slope.Add(input[i + 1] - input[i]);
    //}
    //for (int i = 0; i < slope.Count - 1; i++)
    //{
    //    // 若slope == 0 只記錄一次轉擇點
    //    // 若最低點在最高點之後?
    //    // 
    //    if (slope[i] >= 0 || slope[i + 1] < 0)
    //    {
    //        localMaxima.Add(input[i]);
    //    }
    //    else if (slope[i] < 0 || slope[i + 1] >= 0)
    //    {
    //        //isSlopeChange[i] = true;
    //        localMaxima.Add(input[i]);
    //    }
    //    else 
    //    {
    //        //isSlopeChange[i] = false;
    //    }
    //}


}
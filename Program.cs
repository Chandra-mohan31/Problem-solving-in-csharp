using System.Diagnostics;

namespace SellStock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stocks Problem");
            //int[] stocks = { 7 ,1, 5, 3, 6, 4 };
            int[] stocks =  { 1,2,4,2,5,7,2,4,9,0,9};

            Console.WriteLine("The maximum profit you can make is : " + CalcProfitOptimised(stocks));
            //Console.Write(CalcProfitOptimised(stocks));


        }
        static int CalcProfit(int[] stocks)
        {
            int max_profit = 0;
            
            for (int i = 0; i < stocks.Length - 1; i++)
            {
                for (int j = i + 1; j < stocks.Length; j++)
                {
                    if (stocks[j] > stocks[i])
                    {
                        max_profit = Math.Max((stocks[j] - stocks[i]), max_profit);
                    }
                }
            }
            return max_profit;
        }
        //int[] stocks = { 7, 1, 5, 3, 6, 4 };

        static int CalcProfitOptimised(int[] stocks)
        {
            int max_profit = 0;
            int curr_buy_day = 0;
            int curr_sell_day = 1;
            
            while(curr_sell_day < stocks.Length && curr_buy_day < stocks.Length) {
                if (stocks[curr_sell_day] - stocks[curr_buy_day] > 0)
                {
                    max_profit = Math.Max((stocks[curr_sell_day] - stocks[curr_buy_day]), max_profit);
                    curr_sell_day++;
                }
                else
                {
                    curr_buy_day=curr_sell_day;
                    curr_sell_day++;
                }
            }

            return max_profit;

            
        }
    }
}
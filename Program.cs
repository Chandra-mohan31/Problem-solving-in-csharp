using System.Collections;
using System.Collections.Generic;

namespace Spiral_matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Spiral Matrix!");
            int[,] arr = {{ 1, 2, 3, 4},{5, 6, 7, 8},{9, 10, 11, 12} };
            int m = arr.GetLength(0);
            int n = arr.GetLength(1);
            Console.WriteLine(m + "," + n);
            int l = 0;
            int r = n - 1;
            int t = 0;
            int b = m - 1;
            int d = 0;

            while(l <= r && t<= b)
            {
                if (d == 0)
                {
                    for (int i = l; i <= r; i++)
                    {
                        Console.Write($"{arr[t,i]} ");
                    }
                    d = 1; t++;
                }else if (d == 1)
                {
                    for (int i = t; i <= b; i++)
                    {
                        Console.Write($"{arr[i,r]} ");
                    }
                    d = 2; r--;
                }else if(d == 2)
                {
                    for (int i = r; i >= l; i--)
                    {
                        Console.Write($"{arr[b,i]} ");
                    }
                    d = 3; b--;
                }else if(d == 3)
                {
                    for (int i = b; i >= t; i--)
                    {
                        Console.Write($"{arr[i,l]} ");
                    }
                    d = 0; l++;
                }
            }

        }
    }
}
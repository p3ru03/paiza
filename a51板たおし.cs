//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        string[] datas = Console.ReadLine().Split(' ');
//        int H = int.Parse(datas[0]);
//        int W = int.Parse(datas[1]);

//        int[,] points = new int[H, W];

//        for (int i = 0; i < H; i++)
//        {
//            datas = Console.ReadLine().Split(' ');
//            for (int j = 0; j < W; j++)
//            {
//                points[i, j] = int.Parse(datas[j]);
//            }
//        }

//        int max = 0;
//        var dp = new Dictionary<int, int>();
//        int[] dpcopy = new int[W];
//        dp[-1] = 0;
//        dp[W] = 0;

//        for (int j = 0; j < W; j++)
//        {
//            dp[j] = points[0, j];
//        }

//        for (int i = 1; i < H; i++)
//        {
//            for (int j = 0; j < W; j++)
//            {
//                dpcopy[j] = points[i, j] + Math.Max(Math.Max(dp[j - 1], dp[j]), dp[j + 1]);
//            }
//            for (int j = 0; j < W; j++)
//            {
//                dp[j] = dpcopy[j];
//            }
//        }

//        for (int j = 0; j < W; j++)
//        {
//            if (dp[j] > max)
//            {
//                max = dp[j];
//            }
//        }

//        Console.WriteLine(max);
//    }
//}


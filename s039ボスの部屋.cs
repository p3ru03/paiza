//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        string[] dimensions = Console.ReadLine().Split(' ');
//        int H = int.Parse(dimensions[0]);
//        int W = int.Parse(dimensions[1]);
//        char[,] dungeon = new char[H, W];
//        int[,] dp = new int[H, W];
//        for (int i = 0; i < H; i++)
//        {
//            string row = Console.ReadLine();
//            for (int j = 0; j < W; j++)
//            {
//                dungeon[i, j] = row[j];
//            }
//        }
//        int maxArea = 0;
//        // 上方向への累積和を計算
//        for (int i = 0; i < H; i++)
//        {
//            for (int j = 0; j < W; j++)
//            {
//                if (dungeon[i, j] == '.')
//                {
//                    dp[i, j] = 1;
//                    if (i > 0)
//                    {
//                        dp[i, j] += dp[i - 1, j];
//                    }
//                }
//                else
//                {
//                    dp[i, j] = 0;
//                }
//            }
//        }
//        // 面積の最大値を更新
//        for (int i = 0; i < H; i++)
//        {
//            for (int j = 0; j < W; j++)
//            {
//                int minHeight = dp[i, j];
//                for (int k = j; k < W; k++)
//                {
//                    if (dp[i, k] == 0)
//                    {
//                        break;
//                    }
//                    minHeight = Math.Min(minHeight, dp[i, k]);
//                    maxArea = Math.Max(maxArea, minHeight * (k - j + 1));
//                }
//            }
//        }
//        Console.WriteLine(maxArea);
//    }
//}
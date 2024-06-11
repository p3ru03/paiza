//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        string[] data = Console.ReadLine().Split(' ');

//        int n = int.Parse(data[0]);
//        int x = int.Parse(data[1]);
//        int a = int.Parse(data[2]);
//        int y = int.Parse(data[3]);
//        int b = int.Parse(data[4]);
//        int z = int.Parse(data[5]);
//        int c = int.Parse(data[6]);

//        var dp = new Dictionary<int, int>();

//        dp[0] = 0;

//        for (int i = 1; i < n + z; i++)
//        {
//            //最小値を求めるから大きい初期値を設定
//            dp[i] = 100000;
//            if (i >= x)
//            {
//                dp[i] = Math.Min(dp[i], dp[i - x] + a);
//            }
//            if (i >= y)
//            {
//                dp[i] = Math.Min(dp[i], dp[i - y] + b);
//            }
//            if (i >= z)
//            {
//                dp[i] = Math.Min(dp[i], dp[i - z] + c);
//            }
//        }
//        //n個以上も考える
//        for (int i = n + z - 2; i >= 1; i--)
//        {
//            dp[i] = Math.Min(dp[i], dp[i + 1]);
//        }

//        Console.WriteLine(dp[n]);
//    }
//}


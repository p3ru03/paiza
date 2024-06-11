//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        string[] data = Console.ReadLine().Split(' ');
//        //段数
//        int n = int.Parse(data[0]);
//        //登り方
//        int a = int.Parse(data[1]);
//        int b = int.Parse(data[2]);
//        int c = int.Parse(data[3]);

//        var dp = new Dictionary<int, int>();

//        dp[0] = 1;

//        for (int i = 1; i < n + 1; i++)
//        {
//            dp[i] = 0;
//            if (i >= a)
//            {
//                dp[i] += dp[i - a];
//            }
//            if (i >= b)
//            {
//                dp[i] += dp[i - b];
//            }
//            if (i >= c)
//            {
//                dp[i] += dp[i - c];
//            }
//        }
//        Console.WriteLine(dp[n]);
//    }
//}


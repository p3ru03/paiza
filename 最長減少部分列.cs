//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        //木の数
//        int n = int.Parse(Console.ReadLine());
//        //木の高さ
//        var a = new Dictionary<int, int>();
//        for (int i = 1; i <= n; i++)
//        {
//            a[i] = int.Parse(Console.ReadLine());
//        }
//        //伐採されずに残る木の数
//        var dp = new Dictionary<int, int>();
//        dp[1] = 1;

//        int answer = 1;

//        for (int i = 2; i <= n; i++)
//        {
//            dp[i] = 1;
//            for (int j = 1; j < i; j++)
//            {
//                if (a[j] > a[i])
//                {
//                    dp[i] = Math.Max(dp[i], dp[j] + 1);
//                }
//            }
//            if (dp[i] > answer)
//            {
//                answer = dp[i];
//            }
//        }     
//        Console.WriteLine(answer);
//    }
//}


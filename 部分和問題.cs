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

//        var a = new Dictionary<int, int>();
//        for (int i = 0; i < n; i++)
//        {
//            a[i] = int.Parse(Console.ReadLine());
//        }

//        bool[] dp = new bool[x + 1];
//        dp[0] = true;
//        //"x-おもりの重さ"までの重さを，作れるかどうか調べる
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = a[i]; j <= x; j++)
//            {
//                if (dp[j - a[i]])
//                {
//                    dp[j] = true;
//                }
//            }
//        }

//        if (dp[x])
//        {
//            Console.WriteLine("yes");
//        }
//        else
//        {
//            Console.WriteLine("no");
//        }
//    }
//}


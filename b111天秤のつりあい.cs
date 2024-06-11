//using System;

//class Program
//{
//    static void Main()
//    {
//        int n = int.Parse(Console.ReadLine());
//        string[] weights_str = Console.ReadLine().Split(' ');
//        int[] weights = new int[n];

//        for (int i = 0; i < n; i++)
//        {
//            weights[i] = int.Parse(weights_str[i]);
//        }

//        int totalWeight = 0;
//        for (int i = 0; i < n; i++)
//        {
//            totalWeight += weights[i];
//        }

//        int halfTotal = totalWeight / 2;

//        // dp[i, w] は、最初の i 個の分銅を使って、合計重さが w になるような分銅の選び方が存在するかどうかを表す
//        bool[,] dp = new bool[n + 1, halfTotal + 1];

//        dp[0, 0] = true;

//        for (int i = 0; i < n; i++)
//        {
//            for (int w = 0; w <= halfTotal; w++)
//            {
//                // i 番目の分銅を選ぶ場合
//                if (w >= weights[i])
//                {
//                    dp[i + 1, w] |= dp[i, w - weights[i]];
//                }

//                // i 番目の分銅を選ばない場合
//                dp[i + 1, w] |= dp[i, w];
//            }
//        }

//        int minDifference = int.MaxValue;

//        // 左皿の重さを w としたとき、右皿の重さは totalWeight - w になる
//        for (int w = 0; w <= halfTotal; w++)
//        {
//            if (dp[n, w])
//            {
//                int difference = Math.Abs(totalWeight - 2 * w);
//                minDifference = Math.Min(minDifference, difference);
//            }
//        }

//        Console.WriteLine(minDifference);
//    }
//}

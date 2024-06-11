//using System;
//using System.Text;
//class Program
//{
//    static void Main()
//    {
//        string[] datas = Console.ReadLine().Split(' ');
//        int N = int.Parse(datas[0]);
//        int x = int.Parse(datas[1]);

//        int[,] gfishes = new int[N, 2];
//        for (int i = 0; i < N; i++)
//        {
//            datas = Console.ReadLine().Split(' ');
//            gfishes[i, 0] = int.Parse(datas[0]);
//            gfishes[i, 1] = int.Parse(datas[1]);
//        }
//        //初期値
//        int[,] dp = new int[N + 1, x + 1];
//        for (int j = 0; j < x + 1; j++)
//        {
//            dp[0, j] = 0;
//        }

//        for (int i = 0; i < N; i++)
//        {
//            for (int j = 0; j < x + 1; j++)
//            {
//                if (j > gfishes[i, 0])
//                {
//                    dp[i + 1, j] = Math.Max(dp[i, j - gfishes[i, 0]] + gfishes[i, 1], dp[i, j]);
//                }
//                else
//                {
//                    dp[i + 1, j] = dp[i, j];
//                }
//            }
//        }
//        Console.WriteLine(dp[N, x]);
//    }
//}
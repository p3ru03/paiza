//using System;
//using System.Linq;
//using System.Collections.Generic;
//class Program
//{
//    static void Main()
//    {
//        string[] datas = Console.ReadLine().Split(' ');
//        int N = int.Parse(datas[0]);
//        int K = int.Parse(datas[1]);

//        int[,] vote = new int[N, K];
//        for (int i = 0; i < N; i++)
//        {
//            string data = Console.ReadLine();
//            for (int j = 0; j < K; j++)
//            {
//                vote[i, j] = int.Parse(data) / (j + 1);
//            }
//        }

//        int[] seats = new int[N];
//        for (int x = 0; x < K; x++)
//        {
//            int max = vote.Cast<int>().Max();
//            var maxes = new Dictionary<int, int>();
//            //最大値を持っている場所を探す
//            for (int i = 0; i < N; i++)
//            {
//                for (int j = 0; j < K; j++)
//                {
//                    if (vote[i, j] == max)
//                    {
//                        maxes.Add(i, j);
//                    }
//                }
//            }
//            //票が同じときは獲得した議席数で比較
//            int maxseat = -1;
//            int i2 = 0;
//            int j2 = 0;
//            foreach (var i in maxes)
//            {
//                if (maxseat < seats[i.Key])
//                {
//                    maxseat = seats[i.Key];
//                    i2 = i.Key;
//                    j2 = i.Value;
//                }

//            }
//            seats[i2]++;
//            vote[i2, j2] = 0;
//        }

//        foreach (var i in seats)
//        {
//            Console.WriteLine(i);
//        }
//    }
//}

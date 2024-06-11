//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        string[] datas = Console.ReadLine().Split(' ');
//        int N = int.Parse(datas[0]);

//        int[,] mountains = new int[N + 2, N + 2];
//        //地図の外は0のまま
//        for (int i = 1; i < N + 1; i++)
//        {
//            datas = Console.ReadLine().Split(' ');
//            for (int j = 1; j < N + 1; j++)
//            {
//                mountains[i, j] = int.Parse(datas[j - 1]);
//            }
//        }

//        var tops = new List<int>();
//        int count = 0;
//        //山頂を探す
//        for (int i = 1; i < N + 1; i++)
//        {
//            for (int j = 1; j < N + 1; j++)
//            {
//                if (mountains[i, j] > mountains[i - 1, j]
//                    && mountains[i, j] > mountains[i + 1, j]
//                    && mountains[i, j] > mountains[i, j - 1]
//                    && mountains[i, j] > mountains[i, j + 1])
//                {
//                    tops.Add(mountains[i, j]);
//                }
//            }
//        }
//        //降順にソート
//        var orderedtops = tops.OrderByDescending(x => x);

//        foreach (var i in orderedtops)
//        {
//            Console.WriteLine(i);
//        }
//    }
//}


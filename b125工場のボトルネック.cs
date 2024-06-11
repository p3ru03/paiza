//using System;
//using System.Text;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        string[] datas = Console.ReadLine().Split(' ');
//        int L = int.Parse(datas[0]);
//        int Q = int.Parse(datas[1]);

//        int[,] record = new int[Q, 3];
//        for (int i = 0; i < Q; i++)
//        {
//            datas = Console.ReadLine().Split(' ');
//            for (int j = 0; j < 2; j++)
//            {
//                record[i, j] = int.Parse(datas[j]);
//            }
//        }

//        for (int i = 0; i < Q; i++)
//        {
//            if (record[i, 0] != 0)
//            {
//                continue;
//            }

//            for (int i2 = 0; i2 < i; i2++)
//            {
//                if (record[i2, 0] == 0)
//                {
//                    continue;
//                }
//                if (record[i2, 0] * (record[i, 1] - record[i2, 1]) < L)
//                {
//                    continue;
//                }
//                //パッキングにかかった時間の計算（まだパッキングされていないなら）
//                if (record[i2, 2] == 0)
//                {
//                    record[i2, 2] = record[i, 1] - record[i2, 1];
//                }
//            }
//        }

//        int ans = 0;
//        for (int i = 0; i < Q; i++)
//        {
//            ans = Math.Max(ans, record[i, 2]);
//        }
//        Console.WriteLine(ans);
//    }
//}
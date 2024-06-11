//using System;
//using System.Text;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        string[] datas = Console.ReadLine().Split(' ');
//        int N = int.Parse(datas[0]);
//        int K = int.Parse(datas[1]);

//        int[,] points = new int[N + 1, K + 1];
//        for (int i = 1; i < N + 1; i++)
//        {
//            datas = Console.ReadLine().Split(' ');
//            for (int j = 1; j < K + 1; j++)
//            {
//                points[i, j] = int.Parse(datas[j - 1]);
//            }
//        }
//        int kcount = 0;
//        //1位のプレイヤーのリスト
//        var ans = new List<int>();
//        do
//        {
//            //各プレイヤーのマックス
//            int[] maxes = new int[N + 1];
//            for (int i = 1; i < N + 1; i++)
//            {
//                for (int j = 1; j < K + 1; j++)
//                {
//                    maxes[i] = Math.Max(maxes[i], points[i, j]);
//                }
//            }
//            //全員の最高得点
//            int max_max = 0;
//            for (int i = 1; i < N + 1; i++)
//            {
//                max_max = Math.Max(max_max, maxes[i]);
//            }
//            for (int i = 1; i < N + 1; i++)
//            {
//                if (max_max != maxes[i])
//                {
//                    for (int j = 1; j < K + 1; j++)
//                    {
//                        points[i, j] = -1;
//                    }
//                }
//                else
//                {
//                    ans.Add(i);
//                    for (int j = 1; j < K + 1; j++)
//                    {
//                        if (points[i, j] == max_max)
//                        {
//                            points[i, j] = -1;
//                        }
//                    }
//                }
//            }
//            kcount++;
//            //1位が一人になったか，全ての結果を試したら終了
//            if (ans.Count == 1 || kcount == K)
//            {
//                break;
//            }
//            ans.Clear();
//        } while (true);

//        foreach (int i in ans)
//        {
//            Console.WriteLine(i);
//        }
//    }
//}
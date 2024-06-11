//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        string[] datas = Console.ReadLine().Split(' ');
//        int H = int.Parse(datas[0]);
//        int W = int.Parse(datas[1]);
//        int K = int.Parse(datas[2]);

//        char[,] map = new char[H, W];
//        int i_now = 0;
//        int j_now = 0;
//        for (int i = 0; i < H; i++)
//        {
//            string data = Console.ReadLine();
//            for (int j = 0; j < W; j++)
//            {
//                map[i, j] = data[j];
//                //現在地
//                if (map[i, j] == 'N')
//                {
//                    i_now = i;
//                    j_now = j;
//                }
//            }
//        }
//        //セーブポイントまでの最短距離を求める
//        int min = H * W;
//        for (int i = 0; i < H; i++)
//        {
//            for (int j = 0; j < W; j++)
//            {
//                //セーブポイントなら
//                if (map[i, j] != '#' && map[i, j] != 'N')
//                {
//                    if (Math.Abs(i_now - i) + Math.Abs(j_now - j) < min)
//                    {
//                        min = Math.Abs(i_now - i) + Math.Abs(j_now - j);
//                    }
//                }
//            }
//        }

//        var dictionary = new Dictionary<char, int>();
//        int N = 0;
//        for (int i = 0; i < H; i++)
//        {
//            for (int j = 0; j < W; j++)
//            {
//                //最短距離にあるセーブポイントを格納
//                if (map[i, j] != '#' && map[i, j] != 'N' && Math.Abs(i_now - i) + Math.Abs(j_now - j) == min)
//                {
//                    dictionary.Add(map[i, j], min);
//                    N++;
//                }
//            }
//        }

//        var sorteddic = dictionary.OrderBy(x => x.Key);
//        Console.WriteLine(N);
//        foreach (var i in sorteddic)
//        {
//            Console.WriteLine(i.Key);
//        }
//    }
//}
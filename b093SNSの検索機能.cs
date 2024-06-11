//using System;
//using System.Linq;
//using System.Collections.Generic;
//class Program
//{
//    static void Main()
//    {
//        string[] datas = Console.ReadLine().Split(' ');
//        int N = int.Parse(datas[0]);
//        int M = int.Parse(datas[1]);

//        string[,] posting = new string[N, 5];
//        for (int i = 0; i < N; i++)
//        {
//            datas = Console.ReadLine().Split(' ');
//            posting[i, 0] = (i + 1).ToString();
//            posting[i, 1] = datas[1];

//            datas = Console.ReadLine().Split(' ');
//            posting[i, 2] = datas[0];
//            posting[i, 3] = datas[1];
//            posting[i, 4] = datas[2];
//        }

//        string[] keyword = new string[M];
//        for (int i = 0; i < M; i++)
//        {
//            datas = Console.ReadLine().Split(' ');
//            keyword[i] = datas[1];
//        }

//        var ans = new Dictionary<int, double>();
//        //m番目のキーワードを見る
//        for (int m = 0; m < M; m++)
//        {
//            //n番目の投稿を見る
//            for (int n = 0; n < N; n++)
//            {
//                //キーの重複を回避
//                if (posting[n, 1].Contains(keyword[m])
//                    && !ans.ContainsKey(int.Parse(posting[n, 0])))
//                {
//                    ans.Add(int.Parse(posting[n, 0]),
//                        double.Parse(posting[n, 2])
//                        + double.Parse(posting[n, 3]) / 100
//                        + double.Parse(posting[n, 4]) / 10000);
//                }
//            }
//        }

//        if (ans.Count == 0)
//        {
//            Console.WriteLine("None");
//        }
//        else
//        {
//            foreach (var i in ans.OrderBy(x => x.Value).ThenBy(x => x.Key))
//            {
//                Console.WriteLine(i.Key);
//            }
//        }
//    }
//}

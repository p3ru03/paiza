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
//        int M = int.Parse(datas[1]);

//        double[,] ranks = new double[N, M];
//        double[] ave = new double[N];
//        bool[] semifinal = new bool[N];
//        for (int i = 0; i < N; i++)
//        {
//            datas = Console.ReadLine().Split(' ');
//            for (int j = 0; j < M; j++)
//            {
//                ranks[i, j] = double.Parse(datas[j]);
//                ave[i] += ranks[i, j];
//                //3位以内の順位があれば
//                if (ranks[i, j] < 4)
//                {
//                    semifinal[i] = true;
//                }
//            }
//            ave[i] /= M;
//        }

//        int ans = 0;
//        var finals = new List<int>();
//        double mincopy = 0;
//        int now = 0;
//        int[] rankcount = new int[3];
//        //決勝進出者を決める
//        while (true)
//        {
//            double min = ave.Min();
//            if (min == int.MaxValue)
//            {
//                break;
//            }

//            now = now + rankcount[now];
//            if (now > 2)
//            {
//                break;
//            }

//            mincopy = min;

//            for (int i = 0; i < N; i++)
//            {
//                if (ave[i] != min)
//                {
//                    continue;
//                }

//                finals.Add(i);
//                ave[i] = int.MaxValue;
//                rankcount[now]++;
//            }


//        }

//        for (int i = 0; i < N; i++)
//        {
//            if (finals.Contains(i))
//            {
//                continue;
//            }
//            if (semifinal[i])
//            {
//                ans++;
//            }
//        }

//        Console.WriteLine(ans);
//    }


//}
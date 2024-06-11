//using System;
//using System.Text;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        int N = int.Parse(Console.ReadLine());
//        int[,] delta = new int[N, 3];
//        for (int i = 0; i < N; i++)
//        {
//            string[] datas = Console.ReadLine().Split(' ');
//            for (int j = 0; j < 3; j++)
//            {
//                delta[i, j] = int.Parse(datas[j]);
                
//            }
//        }

//        int Q = int.Parse(Console.ReadLine());
//        int[] questions = new int[Q];
//        for (int i = 0; i < Q; i++)
//        {
//            questions[i] = int.Parse(Console.ReadLine());
//        }

//        int[] real = new int[1001];
//        int[] delay = new int[2001];

//        for (int n = 0; n < N; n++)
//        {
//            for (int i = delta[n, 0]; i < real.Length; i++)
//            {
//                real[i] += delta[n, 2];
//                delay[i + delta[n, 1]] += delta[n, 2];
//            }
//        }

//        var ans = new List<int>();
//        for (int i = 0; i < Q; i++)
//        {
//            ans.Add(real[questions[i]] - delay[questions[i]]);
//        }
//        foreach (var i in ans)
//        {
//            Console.WriteLine(i);
//        }
//    }
//}
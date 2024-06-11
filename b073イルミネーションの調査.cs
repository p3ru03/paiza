//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        string[] datas = Console.ReadLine().Split(' ');
//        int N = int.Parse(datas[0]);
//        int M = int.Parse(datas[1]);

//        datas = Console.ReadLine().Split(' ');
//        int[] bulbs = new int[N];
//        for (int i = 0; i < N; i++)
//        {
//            bulbs[i] = int.Parse(datas[i]);
//        }

//        int Q = int.Parse(Console.ReadLine());

//        int[,] sections = new int[Q, 2];
//        for (int i = 0; i < Q; i++)
//        {
//            datas = Console.ReadLine().Split(' ');
//            for (int j = 0; j < 2; j++)
//            {
//                sections[i, j] = int.Parse(datas[j]);
//            }
//        }

//        for (int i = 0; i < Q; i++)
//        {
//            int sum = 0;
//            int count = 0;
//            for (int j = sections[i, 0] - 1; j < sections[i, 1]; j++)
//            {
//                sum += bulbs[j];
//                count++;
//            }
//            //電球が足りなかったら
//            if (sum / count < M)
//            {
//                for (int j = sections[i, 0] - 1; j < sections[i, 1]; j++)
//                {
//                    bulbs[j] += M - sum / count;
//                }
//            }
//        }

//        for (int i = 0; i < N; i++)
//        {
//            Console.Write(bulbs[i]);
//            if (i != N - 1)
//            {
//                Console.Write(" ");
//            }
//            else
//            {
//                Console.WriteLine();
//            }
//        }
//    }
//}


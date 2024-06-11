//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        string[] datas = Console.ReadLine().Split(' ');
//        //回答者
//        int N = int.Parse(datas[0]);
//        //設問
//        int M = int.Parse(datas[1]);

//        int[,] answers = new int[N, M];
//        int[] cleansing = new int[M];

//        for (int i = 0; i < N; i++)
//        {
//            datas = Console.ReadLine().Split(' ');
//            for (int j = 0; j < M; j++)
//            {
//                int errer = 0;
//                //数字意外だと0を返す
//                bool check = int.TryParse(datas[j], out errer);
//                answers[i, j] = errer;
//                if (!check)
//                {
//                    answers[i, j] = -1;
//                }
//            }
//        }

//        for (int j = 0; j < M; j++)
//        {
//            int sum = 0;
//            int count = 0;
//            for (int i = 0; i < N; i++)
//            {
//                if (answers[i, j] >= 0 && answers[i, j] <= 100)
//                {
//                    sum += answers[i, j];
//                    count++;
//                }
//            }
//            if (count == 0)
//            {
//                count++;
//            }
//            cleansing[j] = sum / count;
//        }

//        for (int j = 0; j < M; j++)
//        {
//            Console.WriteLine(cleansing[j]);
//        }
//    }
//}


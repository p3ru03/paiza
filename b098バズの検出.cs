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
//        int T = int.Parse(datas[2]);
//        int K = int.Parse(datas[3]);

//        int[,] good = new int[M, N];
//        string[] buzz_str = new string[N];
//        int[] buzz_int = new int[N];

//        for (int i = 0; i < M; i++)
//        {
//            datas = Console.ReadLine().Split(' ');
//            for (int j = 0; j < N; j++)
//            {
//                good[i, j] = int.Parse(datas[j]);
//            }
//        }

//        for (int j = 0; j < N; j++)
//        {
//            for (int i = 0; i + T <= M; i++)
//            {
//                int sum = 0;
//                for (int k = 0; k < T; k++)
//                {
//                    sum += good[i + k, j];
//                    if (sum >= K)
//                    {
//                        buzz_str[j] = "yes";
//                        buzz_int[j] = i + k + 1;
//                        //最初のバズが分かれば良い
//                        break;
//                    }
//                }
//                //最初のバズが分かれば良い
//                if (buzz_str[j] == "yes")
//                {
//                    break;
//                }
//            }
//            if (buzz_str[j] == null)
//            {
//                buzz_str[j] = "no";
//            }
//        }

//        for (int j = 0; j < N; j++)
//        {
//            Console.WriteLine(buzz_str[j] + " " + buzz_int[j]);
//        }

//    }
//}


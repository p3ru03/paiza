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
//        int K = int.Parse(datas[2]);

//        int[] cards = new int[N];
//        int[] cardscopy = new int[N];

//        for (int i = 0; i < N; i++)
//        {
//            cards[i] = i + 1;
//        }
//        //K回繰り返す
//        for(int k = 0; k < K; k++)
//        {
//            for (int x = 0; x < N / M; x++)
//            {
//                for (int i = 0; i < M; i++)
//                {
//                    cardscopy[N - M * (x + 1) + i] = cards[M * x + i];
//                }
//            }

//            //余り
//            for (int i = N / M * M; i < N; i++)
//            {
//                cardscopy[i - N / M * M] = cards[i];
//            }

//            for (int i = 0; i < N; i++)
//            {
//                cards[i] = cardscopy[i];
//            }
//        }
        
//        for (int i = 0; i < N; i++)
//        {
//            Console.WriteLine(cards[i]);
//        }
//    }
//}


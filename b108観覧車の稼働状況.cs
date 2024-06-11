//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        string[] data = Console.ReadLine().Split(' ');
//        //ゴンドラ
//        int N = int.Parse(data[0]);
//        int[] gondola = new int[N];
//        int[] gondola_copy = new int[N];
//        for (int i = 0; i < N; i++)
//        {
//            gondola[i] = int.Parse(Console.ReadLine());
//            gondola_copy[i] = gondola[i];
//        }
//        //グループ
//        int M = int.Parse(data[1]);
//        int[] group = new int[M];
//        for (int i = 0; i < M; i++)
//        {
//            group[i] = int.Parse(Console.ReadLine());
//        }

//        int[] sums = new int[N];

//        int n = 0;
//        int m = 0;
//        do
//        {
//            if (gondola[n] >= group[m])
//            {
//                sums[n] += group[m];
//                gondola[n] -= group[m];
//                group[m] -= gondola[n];
//                m++;
//            }
//            else
//            {
//                sums[n] += gondola[n];
//                group[m] -= gondola[n];               
//            }
//            n++;
//            //ゴンドラが一周したら
//            if(n == N)
//            {
//                n = 0;
//                for(int i = 0; i < N; i++)
//                {
//                    gondola[i] = gondola_copy[i];
//                }
//            }
//            //M組乗り終わるまでループ
//        } while (m !=M);


//        for (int i = 0; i < N; i++)
//        {
//            Console.WriteLine(sums[i]);
//        }

//    }
//}


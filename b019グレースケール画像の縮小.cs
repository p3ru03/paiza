//using System;
//using System.Text;
//class Program
//{
//    static void Main()
//    {
//        string[] datas = Console.ReadLine().Split(' ');
//        int N = int.Parse(datas[0]);
//        int K = int.Parse(datas[1]);

//        int x = N / K;
//        int[,] ans = new int[x, x];

//        int[,] picture = new int[N, N];
//        for (int i = 0; i < N; i++)
//        {
//            datas = Console.ReadLine().Split(' ');
//            for (int j = 0; j < N; j++)
//            {
//                picture[i, j] = int.Parse(datas[j]);
//            }
//        }

//        for (int xi = 0; xi < x; xi++)
//        {
//            for (int xj = 0; xj < x; xj++)
//            {

//                int sum = 0;
//                int icount = xi * K;

//                while (icount / K == xi)
//                {
//                    int jcount = xj * K;
//                    while (jcount / K == xj)
//                    {
//                        sum += picture[icount, jcount];
//                        jcount++;
//                    }
//                    icount++;
//                }

//                ans[xi, xj] = sum / (K * K);
//            }
//        }

//        for (int xi = 0; xi < x; xi++)
//        {
//            for (int xj = 0; xj < x; xj++)
//            {
//                Console.Write(ans[xi, xj]);
//                if (xj != x - 1)
//                {
//                    Console.Write(" ");
//                }
//            }
//            Console.WriteLine();
//        }


//    }
//}
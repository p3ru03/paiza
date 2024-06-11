//using System;
//class Program
//{
//    static void Main()
//    {
//        string[] datas = Console.ReadLine().Split(' ');
//        int N = int.Parse(datas[0]);
//        int M = int.Parse(datas[1]);
//        int K = int.Parse(datas[2]);

//        bool[] exist = new bool[N];
//        int[] rabbit = new int[M];
//        for (int i = 0; i < M; i++)
//        {
//            rabbit[i] = int.Parse(Console.ReadLine());
//            exist[rabbit[i] - 1] = true;
//        }

//        //K回ジャンプ
//        for (int k = 0; k < K; k++)
//        {
//            //i番目のうさぎのジャンプ
//            for (int i = 0; i < M; i++)
//            {
//                int checker = rabbit[i] - 1;
//                do
//                {
//                    //しげみが空いていたら
//                    if (!exist[checker])
//                    {
//                        //ジャンプ成功
//                        exist[checker] = true;
//                        exist[rabbit[i] - 1] = false;
//                        rabbit[i] = checker + 1;
//                        break;
//                    }
//                    checker++;
//                    if (checker == N)
//                    {
//                        checker = 0;
//                    }
//                } while (true);
//            }
//        }

//        for (int i = 0; i < M; i++)
//        {
//            Console.WriteLine(rabbit[i]);
//        }
//    }
//}

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
//        int S = int.Parse(Console.ReadLine());
//        int[,] inf = new int[S, 3];
//        for (int i = 0; i < S; i++)
//        {
//            datas = Console.ReadLine().Split(' ');
//            for (int j = 0; j < 3; j++)
//            {
//                inf[i, j] = int.Parse(datas[j]);
//            }
//        }

//        int[,] field = new int[N, M];
//        for (int s = 0; s < S; s++)
//        {
//            int height = inf[s, 0];
//            int x = inf[s, 1] - 1;
//            int y = inf[s, 2] - 1;
//            //高さ1は例外
//            if (height == 1)
//            {
//                field[y, x]++;
//                continue;
//            }

//            int end = 4 * (height - 1);
//            int count = 0;

//            int start = (height - 1) / 2;
//            y -= start;
//            x -= start;

//            while (true)
//            {
//                if (count == end)
//                {
//                    break;
//                }
//                count++;
//                //畑の外
//                if (y < 0 || y > N - 1 || x < 0 || x > M - 1)
//                {
//                    //移動
//                    Move(ref y, ref x, count, height);
//                    continue;
//                }
//                else
//                {
//                    //種まき
//                    field[y, x]++;
//                }
//                Move(ref y, ref x, count, height);
//            }
//        }

//        for (int i = 0; i < N; i++)
//        {
//            for (int j = 0; j < M; j++)
//            {
//                Console.Write(field[i, j]);
//                if (j != M - 1)
//                {
//                    Console.Write(" ");
//                }
//            }
//            Console.WriteLine();
//        }
//    }

//    //現在地で移動先を変える
//    static void Move(ref int y, ref int x, int count, int height)
//    {
//        if (count < height)
//        {
//            x++;
//        }
//        else if (count < 2 * height - 1)
//        {
//            y++;
//        }
//        else if (count < 3 * height - 2)
//        {
//            x--;
//        }
//        else
//        {
//            y--;
//        }
//    }
//}
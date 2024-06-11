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
//        int X = int.Parse(datas[2]);

//        string[,] blocks = new string[N, M];
//        for (int i = 0; i < N; i++)
//        {
//            datas = Console.ReadLine().Split(' ');
//            for (int j = 0; j < M; j++)
//            {
//                blocks[i, j] = datas[j];
//            }
//        }

//        string[,] ans = new string[N, M];
//        Array.Copy(blocks, ans, blocks.Length);

//        //消す工程
//        for (int i = 0; i < N; i++)
//        {
//            for (int j = 0; j < M; j++)
//            {
//                //上方向
//                if (i - 1 >= 0)
//                {
//                    if (Check(blocks, i, j, -1, 0))
//                    {
//                        ans[i, j] = "#";
//                        continue;
//                    }
//                }
//                //右方向
//                if (j + 1 < M)
//                {
//                    if (Check(blocks, i, j, 0, 1))
//                    {
//                        ans[i, j] = "#";
//                        continue;
//                    }
//                }
//                //下方向
//                if (i + 1 < N)
//                {
//                    if (Check(blocks, i, j, 1, 0))
//                    {
//                        ans[i, j] = "#";
//                        continue;
//                    }
//                }
//                //左方向
//                if (j - 1 >= 0)
//                {
//                    if (Check(blocks, i, j, 0, -1))
//                    {
//                        ans[i, j] = "#";
//                        continue;
//                    }
//                }
//            }
//        }

//        //移動する工程
//        int count;
//        do
//        {
//            count = 0;
//            for (int i = N - 2; i >= 0; i--)
//            {
//                for (int j = M - 1; j >= 0; j--)
//                {
//                    if (ans[i, j] == "#")
//                    {
//                        continue;
//                    }

//                    if (ans[i + 1, j] == "#")
//                    {
//                        ans[i + 1, j] = ans[i, j];
//                        ans[i, j] = "#";
//                        count++;
//                    }
//                }
//            }
//        } while (count != 0);


//        for (int i = 0; i < N; i++)
//        {
//            for (int j = 0; j < M; j++)
//            {
//                Console.Write(ans[i, j]);
//                if (j != M - 1)
//                {
//                    Console.Write(" ");
//                }
//            }
//            Console.WriteLine();
//        }
//    }

//    static bool Check(string[,] blocks, int i, int j, int di, int dj)
//    {
//        if (blocks[i, j] == blocks[i + di, j + dj])
//        {
//            return true;
//        }
//        return false;
//    }
//}